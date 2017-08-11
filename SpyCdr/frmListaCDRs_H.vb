Imports Dundas.Charting.WinControl
Imports System.Data
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Export
Imports DevExpress.XtraGrid.Views.Grid

Public Class frmListaCDRs_H
    Dim IndicadorNome() As String = {"CO0", "CO1", "CO2", "CO3", "DSC", "LO", "NR1", "NR5", "OK1", "OK5", "OU"}
    Dim Operadores() As String = {"=", "<>", ">", ">=", "<", "<=", "LIKE", "NOT LIKE"}
    Dim Campos() As String = {"CLASSIF", "DATA", "DURACAO", "ASS_A", "cli_A.CLIENTE", "R_ENT", "LST_TG_E.`tg_name` ", _
                              "J_ENT", "CSP", "ASS_B", "cli_B.CLIENTE", "R_SAI", "LST_TG_S.`tg_name`", "J_SAI", "RN2", "RN3", _
                              "PT", "Dialed_Number", "Caller_Category", "Bill_Type", "Free_Ind", "Charged_Party_Ind", _
                              "Call_Type", "GSVN", "Failure_Code", "Termination_code", "Bearer_Service", "Tele_Service", _
                              "RxFlus", "TxFlus", "Caller_GK_Address", "Caller_GW_Address", "Called_GK_Address", "Called_GW_Address"}

    Public DataInicio As Date = Now.Date
    Public DataFim As Date = Now.Date
    Public HoraInicio, HoraFim As String
    Public LimiteAtivado As Boolean = True
    Public LimiteValor As String
    Public Ordem As String = "Sem"
    Private m_Search As BalloonSearch

    Dim tCol As DataColumn
    Dim corStatusBack As Color
    Dim LinhaInicialPesquisaLoop, InicioLIMIT As Integer
    Public flagAtualizaSQL As Boolean = False

    'Declare a variable to hold the last accessed edit control
    Private CurEditControl As Control
    Const BLOCO_DE_CDRs = 5000
    Dim horaI, horaF As DateTime

    Dim dt As New DataTable("cdrs_sel")
    Private Sub ProcessoInicio()
        pb1.Text = "Processando..."
        horaI = Now
        'Me.statusTempoGasto.BackColor = Color.Aqua
        'statusTempoGasto.Visible = True
        pb1.Refresh()
        Cursor = Cursors.WaitCursor
    End Sub

    Private Sub ProcessoFim()

        WindowState = FormWindowState.Maximized
        horaF = Now
        'statusRecCount.Text = "Registros: " & dGridCdrs.RowCount
        If gvCDRs.RowCount < 1 And InStr(txtSQL.Text, "LIMIT 0") < 1 Then MsgBox("Nenhum registro foi encontrado!")
        'statusTempoGasto.Text = "Tempo: " & Format((horaF - horaI).TotalSeconds, "####") & " segundos  "
        'statusRecCount.Visible = True
        'statusTempoGasto.Visible = True
        Cursor = Cursors.Default

    End Sub

    Private Sub ExecSQL()
        pb1.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee
        pb1.Text = "Realizando busca no banco de dados..."
        pb1.Visible = True
        Application.DoEvents()
        Try
            dt = MySQL_Select(Conn, txtSQL.Text)

        Catch ex As Exception
            dt.Rows.Clear()
            gcCDRs.DataSource = dt
            gcCDRs.DataBindings.Clear()
            MsgBox(ex.Message)
        Finally
            pb1.Text = "Preenchendo a grade..."
            Application.DoEvents()
            gcCDRs.DataSource = dt
            'gcCDRs.MainView = gvCDRs
            GeraPizza()
            ProcessoFim()
            pb1.Visible = False
            Cursor.Current = System.Windows.Forms.Cursors.Default
            'BackgroundWorker1.Dispose()
        End Try
    End Sub

    Private Function RetiraStr(ByRef str As String, ByVal ch As String) As String
        Dim p1, p2 As Integer

        str = str.Trim
        RetiraStr = str
        p1 = str.IndexOf(ch)
        If p1 >= 0 Then
            str = str.Substring(p1 + 1, str.Length - p1 - 1)
            p2 = str.IndexOf(ch)
            If p2 > 0 Then RetiraStr = str.Substring(0, p2)
        End If
        str = str.Substring(RetiraStr.Length, str.Length - RetiraStr.Length).Trim
    End Function
    Function RetiraCampo(ByRef str As String) As String
        Dim s As String
        Dim i, idxOpr, p1, p2 As Integer

        'procura o primeiro operador
        p1 = str.Length
        idxOpr = 0
        For i = 0 To Operadores.Length - 1
            p2 = str.IndexOf(Operadores(i))
            If p2 < p1 And p2 <> -1 Then
                p1 = p2
                idxOpr = i
            End If
        Next i

        If p1 > 0 Then
            s = str.Substring(0, p1 - 1)
        End If
        RetiraCampo = s
        str = str.Substring(s.Length, str.Length - s.Length).Trim
    End Function
    Function RetiraOperador(ByRef str As String) As String
        Dim i, idxOpr, p1 As Integer

        str = str.Trim
        'procura o operador
        p1 = 0
        idxOpr = 0
        For i = 0 To Operadores.Length - 1
            If str.Length >= Operadores(i).Length Then
                If Operadores(i) = str.Substring(0, Operadores(i).Length) Then
                    RetiraOperador = Operadores(i)
                    str = str.Substring(Operadores(i).Length, str.Length - Operadores(i).Length)
                    Exit Function
                End If
            End If
        Next i
    End Function

    Private Sub SQL2Filtro()
        Dim nomeTabela, strSELECT, strWHERE As String
        Dim i, j, mLimit As Integer
        Dim mCampo(6), mOperador(6), mValor(6), mConector(6) As String
        Dim mParenteseA(6), mParenteseF(6) As Boolean

        If txtSQL.Text = "" Then Exit Sub
        nomeTabela = txtSQL.Text.Substring(txtSQL.Text.IndexOf("cdrs_"), 13)
        mLimit = 500

        strSELECT = txtSQL.Text.Substring(txtSQL.Text.IndexOf("SELECT") + 7, txtSQL.Text.IndexOf("FROM") - txtSQL.Text.IndexOf("SELECT") - 7)

        If txtSQL.Text.IndexOf("WHERE") > 0 Then 'tem a clausula WHERE
            strWHERE = txtSQL.Text.Substring(txtSQL.Text.IndexOf("WHERE") + 6, txtSQL.Text.Length - txtSQL.Text.IndexOf("WHERE") - 6)
            For i = 0 To 6
                mCampo(i) = ""
                mOperador(i) = "="
                mValor(i) = ""
                mConector(i) = ""
                mParenteseA(i) = False
                mParenteseF(i) = False
            Next
            i = 0
            While (strWHERE.Length > 1)
                If strWHERE.IndexOf("(") < 2 And strWHERE.IndexOf("(") >= 0 Then
                    mParenteseA(i) = True
                    'retira parentese
                    strWHERE = strWHERE.Substring(strWHERE.IndexOf("(") + 1, strWHERE.Length - strWHERE.IndexOf("(") - 1)
                End If
                'extrai campo
                mCampo(i) = RetiraCampo(strWHERE)
                'clia_B.CLIENTE='CIA ALAGOANA' AND (CLASSIF='OK1' OR CLASSIF='OK5')
                mOperador(i) = RetiraOperador(strWHERE) 'extrai Operador
                mValor(i) = RetiraStr(strWHERE, "'") 'extrai valor
                If strWHERE.IndexOf(")") = 0 Or strWHERE.IndexOf(")") = 1 Then
                    mParenteseF(i) = True
                End If
                If strWHERE.Length > 1 Then
                    mConector(i) = RetiraStr(strWHERE, " ") 'extrai valor
                    'strWHERE = strWHERE.Substring(mConector(i).Length + 2, (strWHERE.Length - mConector(i).Length) - 2)
                    If mConector(i) = "LIMIT" Then
                        j = Val(RetiraStr(strWHERE, " ")) 'Pega valor do LIMIT
                        If j > 0 Then
                            mLimit = j
                        End If
                    ElseIf mConector(i) = "AND" Then
                        mConector(i) = "E"
                    Else
                        mConector(i) = "OU"
                    End If
                End If
                'strWHERE = strWHERE.Substring(strWHERE.IndexOf(" ") + 1, strWHERE.Length - strWHERE.IndexOf(" ") - 1)
                i += 1
            End While
            'Captura data
            'Me.DateTimePicker1.Text = Format(CDate(nomeTabela.Substring(5, 4) & "-" & nomeTabela.Substring(9, 2) & "-" & nomeTabela.Substring(11, 2)))
            DataInicio = CDate(nomeTabela.Substring(5, 4) & "-" & nomeTabela.Substring(9, 2) & "-" & nomeTabela.Substring(11, 2))

            Me.cbCampo1.Text = mCampo(0)
            Me.cbCampo2.Text = mCampo(1)
            Me.cbCampo3.Text = mCampo(2)
            Me.cbCampo4.Text = mCampo(3)
            Me.cbCampo5.Text = mCampo(4)
            Me.cbOperador1.Text = mOperador(0)
            Me.cbOperador2.Text = mOperador(1)
            Me.cbOperador3.Text = mOperador(2)
            Me.cbOperador4.Text = mOperador(3)
            Me.cbOperador5.Text = mOperador(4)
            Me.txtValor1.Text = mValor(0)
            Me.txtValor2.Text = mValor(1)
            Me.txtValor3.Text = mValor(2)
            Me.txtValor4.Text = mValor(3)
            Me.txtValor5.Text = mValor(4)
            Me.cbConector1.Text = mConector(0)
            Me.cbConector2.Text = mConector(1)
            Me.cbConector3.Text = mConector(2)
            Me.cbConector4.Text = mConector(3)
            Me.cbParenteseA1.Checked = mParenteseA(0)
            Me.cbParenteseA2.Checked = mParenteseA(1)
            Me.cbParenteseA3.Checked = mParenteseA(2)
            Me.cbParenteseA4.Checked = mParenteseA(3)
            Me.cbParenteseA5.Checked = mParenteseA(4)
            Me.cbParenteseF1.Checked = mParenteseF(0)
            Me.cbParenteseF2.Checked = mParenteseF(1)
            Me.cbParenteseF3.Checked = mParenteseF(2)
            Me.cbParenteseF4.Checked = mParenteseF(3)
            Me.cbParenteseF5.Checked = mParenteseF(4)
        End If

        'Dim conteudoLista = Split(strSELECT, ",")
        Me.cbCampo1.Items.Clear()
        For i = 0 To Campos.Length - 1
            Me.cbCampo1.Items.Add(Campos(i))
        Next i
        Me.cbCampo2.Items.Clear()
        Me.cbCampo3.Items.Clear()
        Me.cbCampo4.Items.Clear()
        Me.cbCampo5.Items.Clear()
        For i = 0 To Me.cbCampo1.Items.Count - 1
            Me.cbCampo2.Items.Add(Me.cbCampo1.Items(i))
            Me.cbCampo3.Items.Add(Me.cbCampo1.Items(i))
            Me.cbCampo4.Items.Add(Me.cbCampo1.Items(i))
            Me.cbCampo5.Items.Add(Me.cbCampo1.Items(i))
        Next
        LimiteValor = mLimit
        LimiteAtivado = True

    End Sub
    Public Sub Filtro2SQL()
        Dim nomeTabela, strSELECT, strFROM, strWHERE As String
        If DataInicio.ToString = "" Then Exit Sub
        'btnProximoLoop.Enabled = False

        If txtSEL.Visible Then
            nomeTabela = "cdrs_SEL"
        Else
            nomeTabela = "cdrs_" & Format(DataInicio, "yyyyMMdd")
        End If
        If nuDias.Value > 1 And nuDias.Visible Then
            'strSELECT = "SELECT CLASSIF, ASS_A, CSP, ASS_B,  PT, R_ENT, R_SAI, DATA, DURACAO, TTFILE "
            strSELECT = "SELECT CLASSIF,DATA,DURACAO,ASS_A,CSP,ASS_B,Dialed_Number,PT,R_ENT,R_SAI,Caller_category,CSN,Switch_ID,Bill_Type,End_Date,Billed_Party,Connected_Number,Charged_Number,Partial_Record_Ind,Free_Ind,Charged_Party_Ind,Call_Type,GSVN,Failure_Code,Termination_Code,Bearer_Service,Tele_Service,RxFlus,TxFlus,Caller_GK_Address,Caller_GW_Address,Called_GK_Address,Called_GW_Address,Coding_Type,Centrex_group_number,Caller_ctx_number,Called_ctx_number,Clock_Indicator,Partial_Counter,Seizure_Date,Release_Date,TTFILE, RN2, RN3 "
        Else
            strSELECT = "SELECT CLASSIF ,DATA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,LST_TG_E.`tg_name` AS ROTA_E,CSP, " _
                        & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, LST_TG_S.`tg_name` AS ROTA_S, RN2, RN3, PT, Dialed_Number, Caller_Category, Bill_Type, Free_Ind, Charged_Party_Ind, " _
                        & "Call_Type, GSVN, Failure_Code, Termination_code, Bearer_Service, Tele_Service, RxFlus, TxFlus, Caller_GK_Address, Caller_GW_Address, Called_GK_Address, Called_GW_Address  "
        End If

        strFROM = "FROM " & nomeTabela & " LEFT JOIN LST_TG AS LST_TG_E ON " & nomeTabela & ".R_ENT = LST_TG_E.`tg_number` " _
            & "LEFT JOIN LST_TG AS LST_TG_S ON " & nomeTabela & ".R_SAI = LST_TG_S.`tg_number`  " _
            & "LEFT JOIN cliente_terminal AS term_A ON " & nomeTabela & ".ASS_A = term_A.TERMINAL " _
            & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
            & "LEFT JOIN cliente_terminal AS term_B ON " & nomeTabela & ".ASS_B = term_B.TERMINAL " _
            & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI "
        If Me.cbCampo1.Text <> "" Then
            If Me.cbParenteseA1.Checked Then
                strWHERE = "WHERE ("
            Else
                strWHERE = "WHERE "
            End If
            strWHERE &= Me.cbCampo1.Text & " " & Me.cbOperador1.Text & " '" & Me.txtValor1.Text & "'"
            If Me.cbParenteseF1.Checked Then
                strWHERE &= ")"
            End If
            If Me.cbCampo2.Text <> "" Then
                If Me.cbConector1.Text = "E" Then
                    strWHERE &= " AND "
                Else
                    strWHERE &= " OR "
                End If

                If Me.cbParenteseA2.Checked Then
                    strWHERE &= "("
                End If

                If Me.cbOperador2.Text = "*" Then
                    strWHERE &= Me.cbCampo2.Text & " LIKE '" & Me.txtValor2.Text & "'"
                Else
                    strWHERE &= Me.cbCampo2.Text & " " & Me.cbOperador2.Text & " '" & Me.txtValor2.Text & "'"
                End If
                If Me.cbParenteseF2.Checked Then
                    strWHERE &= ")"
                End If
                If Me.cbCampo3.Text <> "" Then
                    If Me.cbConector2.Text = "E" Then
                        strWHERE &= " AND "
                    Else
                        strWHERE &= " OR "
                    End If
                    If Me.cbParenteseA3.Checked Then
                        strWHERE &= "("
                    End If
                    If Me.cbOperador3.Text = "*" Then
                        strWHERE &= Me.cbCampo3.Text & " LIKE '" & Me.txtValor3.Text & "'"
                    Else
                        strWHERE &= Me.cbCampo3.Text & " " & Me.cbOperador3.Text & " '" & Me.txtValor3.Text & "'"
                    End If
                    If Me.cbParenteseF3.Checked Then
                        strWHERE &= ")"
                    End If
                End If
                If Me.cbCampo4.Text <> "" Then
                    If Me.cbConector3.Text = "E" Then
                        strWHERE &= " AND "
                    Else
                        strWHERE &= " OR "
                    End If
                    If Me.cbParenteseA4.Checked Then
                        strWHERE &= "("
                    End If
                    If Me.cbOperador4.Text = "*" Then
                        strWHERE &= Me.cbCampo4.Text & " LIKE '" & Me.txtValor4.Text & "'"
                    Else
                        strWHERE &= Me.cbCampo4.Text & " " & Me.cbOperador4.Text & " '" & Me.txtValor4.Text & "'"
                    End If
                    If Me.cbParenteseF4.Checked Then
                        strWHERE &= ")"
                    End If
                End If
                If Me.cbCampo5.Text <> "" Then
                    If Me.cbConector4.Text = "E" Then
                        strWHERE &= " AND "
                    Else
                        strWHERE &= " OR "
                    End If
                    If Me.cbParenteseA5.Checked Then
                        strWHERE &= "("
                    End If
                    strWHERE &= Me.cbCampo5.Text & " " & Me.cbOperador5.Text & " '" & Me.txtValor5.Text & "'"
                    If Me.cbParenteseF5.Checked Then
                        strWHERE &= ")"
                    End If
                End If
            End If
        Else
            strWHERE = ""
        End If
        If HoraInicio <> "00:00:00" Or HoraFim <> "23:59:59" Then
            If strWHERE = "" Then
                strWHERE = String.Format("WHERE TIME(data) BETWEEN '{0:hh:mm:ss}' AND '{1:hh:mm:ss}' ", HoraInicio, HoraFim)
            Else
                strWHERE &= String.Format(" AND TIME(data) BETWEEN '{0:hh:mm:ss}' AND '{1:hh:mm:ss}' ", HoraInicio, HoraFim)
            End If
        End If

        txtSQL.Text = strSELECT & strFROM & strWHERE
        If Ordem.Substring(0, 3) <> "Sem" Then
            txtSQL.Text &= " ORDER BY " & Ordem
        End If
        If LimiteAtivado Then
            txtSQL.Text &= " LIMIT " & LimiteValor
        End If
        If nuDias.Value > 1 And nuDias.Visible Then
            txtSQL.Text = "INSERT INTO CDRs_SEL " & txtSQL.Text
        End If

    End Sub

    Private Sub _TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor1.TextChanged, txtValor5.TextChanged, txtValor4.TextChanged, txtValor3.TextChanged, txtValor2.TextChanged, cbParenteseF5.CheckedChanged, cbParenteseF4.CheckedChanged, cbParenteseF3.CheckedChanged, cbParenteseF2.CheckedChanged, cbParenteseF1.CheckedChanged, cbParenteseA5.CheckedChanged, cbParenteseA4.CheckedChanged, cbParenteseA2.CheckedChanged, cbParenteseA1.CheckedChanged, cbOperador5.SelectedIndexChanged, cbOperador4.SelectedIndexChanged, cbOperador3.SelectedIndexChanged, cbOperador2.SelectedIndexChanged, cbOperador1.SelectedIndexChanged, cbConector4.SelectedIndexChanged, cbConector3.SelectedIndexChanged, cbConector2.SelectedIndexChanged, cbCampo5.SelectedIndexChanged, cbCampo4.SelectedIndexChanged, cbCampo3.SelectedIndexChanged, cbCampo2.SelectedIndexChanged, cbCampo1.SelectedIndexChanged, txtSEL.TextChanged, nuDias.ValueChanged
        If flagAtualizaSQL Then
            Filtro2SQL()
        End If
    End Sub

    Private Sub frmListaCdrs_Activated(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Text = "Lista CDRs - " & frmManutencao.cbBilhetador.Text
    End Sub

    Private Sub frmListaCdrs_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        txtSQL.Text = ""
    End Sub

    Private Sub frmConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nomeTabela As String

        HoraInicio = "00:00:00"
        HoraFim = "23:59:59"
        'corStatusBack = Me.statusTempoGasto.BackColor

        Me.Text = "Pesquisa CDRs - " & frmManutencao.cbBilhetador.Text
        If Not My.Settings.strSQL Is Nothing Then
            'SplitContainer1.SplitterDistance = 0
            expandableSplitter1.Expanded = False
            txtSQL.Text = My.Settings.strSQL
            nomeTabela = My.Settings.strTABELA

            SQL2Filtro()
            flagAtualizaSQL = True
            Processar()
            Exit Sub
        End If

        flagAtualizaSQL = True

        nomeTabela = String.Format("cdrs_{0:yyyyMMdd}", DataInicio)
        Me.WindowState = FormWindowState.Maximized
        If txtSQL.Text = "" Then
            txtSQL.Text = "SELECT CLASSIF ,DATA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,LST_TG_E.`tg_name` AS ROTA_E,CSP, " _
                            & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, LST_TG_S.`tg_name` AS ROTA_S, RN2, RN3, PT,Dialed_Number, Caller_Category, Bill_Type, Free_Ind, Charged_Party_Ind, " _
                            & "Call_Type, GSVN, Failure_Code, Termination_code, Bearer_Service, Tele_Service, RxFlus, TxFlus, Caller_GK_Address, Caller_GW_Address, Called_GK_Address, Called_GW_Address " _
                            & "FROM " & nomeTabela & " LEFT JOIN LST_TG AS LST_TG_E ON " & nomeTabela & ".R_ENT = LST_TG_E.`tg_number` " _
                            & "LEFT JOIN LST_TG AS LST_TG_S ON " & nomeTabela & ".R_SAI = LST_TG_S.`tg_number`  " _
                            & "LEFT JOIN cliente_terminal AS term_A ON " & nomeTabela & ".ASS_A = term_A.TERMINAL " _
                            & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                            & "LEFT JOIN cliente_terminal AS term_B ON " & nomeTabela & ".ASS_B = term_B.TERMINAL " _
                            & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI LIMIT 0;"
            'SplitContainer1.SplitterDistance = 140
            expandableSplitter1.Expanded = True
        Else
            'SplitContainer1.SplitterDistance = 0
            expandableSplitter1.Expanded = False
        End If

        ExecSQL()
        SQL2Filtro()
        LimiteValor = 500
        Filtro2SQL()
        'Open Conn
        'Conn = MySQL_Conn(frmManutencao.cbServidorMySql.Text, frmManutencao.txtBancoMySql.Text, frmManutencao.cbUsuarioMySql.Text, frmManutencao.cbSenhaMySql.Text)

    End Sub

    Private Sub GeraPizza()
        Dim r As Integer

        'Dim IndicadorNomeA(grid.Columns.Count - 4) As String
        Dim IndPorcentual(10) As Double
        Dim IndQuantidade(10) As Integer

        If gvCDRs.RowCount < 1 Or gvCDRs.Columns.Count < 1 Then
            Exit Sub
        End If
        'zera contadores
        For r = 0 To 9
            IndQuantidade(r) = 0
        Next
        'Calcula Quantidades
        For r = 0 To gvCDRs.RowCount - 1
            Select Case gvCDRs.GetDataRow(r).Item("CLASSIF").ToString.Trim
                Case "CO0"
                    IndQuantidade(0) += 1
                Case "CO1"
                    IndQuantidade(1) += 1
                Case "CO2"
                    IndQuantidade(2) += 1
                Case "CO3"
                    IndQuantidade(3) += 1
                Case "DSC"
                    IndQuantidade(4) += 1
                Case "LO"
                    IndQuantidade(5) += 1
                Case "NR1"
                    IndQuantidade(6) += 1
                Case "NR5"
                    IndQuantidade(7) += 1
                Case "OK1"
                    IndQuantidade(8) += 1
                Case "OK5"
                    IndQuantidade(9) += 1
                Case "OU"
                    IndQuantidade(10) += 1
            End Select
        Next
        'calcula porcentuais
        For r = 0 To 10
            IndPorcentual(r) = IndQuantidade(r) / gvCDRs.RowCount * 100
        Next

        With chartBarra
            .Series(0).Points.DataBindXY(IndicadorNome, IndQuantidade)
            .Series(0).Points(0).Color = Color.Brown  'co0
            .Series(0).Points(1).Color = Color.Red 'co1
            .Series(0).Points(2).Color = Color.DarkRed     'CO2
            .Series(0).Points(3).Color = Color.Purple      'CO3
            .Series(0).Points(4).Color = Color.Magenta   'DSC
            .Series(0).Points(5).Color = Color.Aqua    'LO
            .Series(0).Points(6).Color = Color.Blue  'NR1
            .Series(0).Points(7).Color = Color.DarkBlue 'NR5
            .Series(0).Points(8).Color = Color.Green 'ok1
            .Series(0).Points(9).Color = Color.DarkGreen 'oK5
            .Series(0).Points(10).Color = Color.Yellow  'OU
            '.Series(0).Points(4).FontColor = Color.White  'DSC
            .Series(0).Points(5).FontColor = Color.Black  'LO
            .Series(0).Points(10).FontColor = Color.Black  'NR1
            .Series(0).Font = New Font("Tahoma", 7, FontStyle.Regular)
            .ChartAreas("Default").AxisX.LabelStyle.Font = New Font("Tahoma", 8, FontStyle.Regular)
            .ChartAreas("Default").AxisX.LabelStyle.FontAngle = -30
            .ChartAreas("Default").AxisX.LabelStyle.Interval = 1

            .ChartAreas("Default").ReCalc()
        End With

        With chartPizza
            '.ChartAreas("Default").AxisX.LabelStyle.Format = "%"
            .Series(0).Points.DataBindXY(IndicadorNome, IndPorcentual)
            .Series(0).Points(1).Color = Color.Brown  'co0
            .Series(0).Points(1).Color = Color.Red 'co1
            .Series(0).Points(2).Color = Color.DarkRed     'CO2
            .Series(0).Points(2).FontColor = Color.White  'CO2
            .Series(0).Points(3).Color = Color.Purple      'CO3
            .Series(0).Points(3).FontColor = Color.White  'CO3
            .Series(0).Points(4).Color = Color.Magenta   'DSC
            .Series(0).Points(5).Color = Color.Aqua    'LO
            .Series(0).Points(6).Color = Color.Blue  'NR1
            .Series(0).Points(7).Color = Color.DarkBlue 'NR5
            .Series(0).Points(7).FontColor = Color.White  'NR5
            .Series(0).Points(8).Color = Color.Green 'ok1
            .Series(0).Points(9).Color = Color.DarkGreen 'oK5
            .Series(0).Points(10).Color = Color.Yellow  'OU
            .Series(0).Points(4).FontColor = Color.White  'DSC
            .Series(0).Points(5).FontColor = Color.Black  'LO
            .Series(0).Points(10).FontColor = Color.Black  'NR1
            .Series(0).Font = New Font("Times New Roman", 8, FontStyle.Regular)
            .Series(0).LabelFormat = "p1"

            .ChartAreas("Default").ReCalc()
        End With
    End Sub

    Private Sub btnSEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEL.Click
        If btnSEL.Text = "SEL" Then
            frmPrincipal2.dtpDataInicio.Visible = False
            nuDias.Visible = False
            txtSEL.Visible = True
            btnSEL.Text = "DIA"
        Else
            frmPrincipal2.dtpDataInicio.Visible = True
            btnSEL.Text = "SEL"
            txtSEL.Visible = False
            nuDias.Visible = True
        End If
        Filtro2SQL()
    End Sub

    Public Sub Gravar_Criterio()
        Dim caminho As DialogResult
        Dim fluxoTexto As IO.StreamWriter
        Dim Arquivo As String

        SaveFileDialog1.CheckFileExists = False

        SaveFileDialog1.Title = "Arquivos Script SQL |*.sql |"
        SaveFileDialog1.DefaultExt = "sql"
        SaveFileDialog1.FileName = "*.sql"
        caminho = SaveFileDialog1.ShowDialog
        If caminho = DialogResult.Cancel Then Exit Sub
        Arquivo = SaveFileDialog1.FileName

        If Arquivo = Nothing Then
            MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK)
        Else
            fluxoTexto = New IO.StreamWriter(Arquivo)
            fluxoTexto.Write(txtSQL.Text)
            fluxoTexto.Close()
        End If

    End Sub

    Public Sub Carregar_Criterio()
        Dim caminho As DialogResult
        Dim fluxoTexto As IO.StreamReader
        Dim Arquivo As String

        OpenFileDialog1.Title = "Abrir como"
        OpenFileDialog1.FileName = "Nome Arquivo"
        OpenFileDialog1.Filter = "Arquivos Script SQL (*.sql)|*.sql"
        caminho = OpenFileDialog1.ShowDialog
        If caminho = DialogResult.Cancel Then Exit Sub
        Arquivo = OpenFileDialog1.FileName

        If Arquivo = Nothing Then
            MessageBox.Show("Arquivo Invalido", "Salvar Como", MessageBoxButtons.OK)
        Else
            fluxoTexto = New IO.StreamReader(Arquivo)
            txtSQL.Text = fluxoTexto.ReadToEnd
            fluxoTexto.Close()
            SQL2Filtro()
        End If
    End Sub

    Public Sub btnLimpar_Criterios()
        cbOperador1.Text = "="
        cbOperador2.Text = "="
        cbOperador3.Text = "="
        cbOperador4.Text = "="
        cbOperador5.Text = "="
        Me.cbCampo1.Text = ""
        Me.cbCampo2.Text = ""
        Me.cbCampo3.Text = ""
        Me.cbCampo4.Text = ""
        Me.cbCampo5.Text = ""
        Me.txtValor1.Text = ""
        Me.txtValor2.Text = ""
        Me.txtValor3.Text = ""
        Me.txtValor4.Text = ""
        Me.txtValor5.Text = ""
        Me.cbConector1.Text = "E"
        Me.cbConector2.Text = "E"
        Me.cbConector3.Text = "E"
        Me.cbConector4.Text = "E"
        Me.cbParenteseA1.Checked = False
        Me.cbParenteseA2.Checked = False
        Me.cbParenteseA3.Checked = False
        Me.cbParenteseA4.Checked = False
        Me.cbParenteseA5.Checked = False
        Me.cbParenteseF1.Checked = False
        Me.cbParenteseF2.Checked = False
        Me.cbParenteseF3.Checked = False
        Me.cbParenteseF4.Checked = False
        Me.cbParenteseF5.Checked = False
        'btnProximoLoop.Enabled = False
        LimiteAtivado = True
    End Sub

    Public Sub Processar()
        Dim i As Integer
        Dim dt1 As Date
        tbcGrafico.SelectedIndex = 0
        If nuDias.Value > 1 Then
            ProcessoInicio()
            dt1 = frmPrincipal2.dtpDataInicio.Value.Date
            Try
                MySQL_cmd(Conn, "DELETE FROM `cdrs_sel`")
                For i = 0 To nuDias.Value - 1
                    'statusRecCount.Text = "Selecionando em: " & Me.DateTimePicker1.Value.ToShortTimeString
                    MySQL_cmd(Conn, txtSQL.Text)
                    frmPrincipal2.dtpDataInicio.Value = frmPrincipal2.dtpDataInicio.Value.AddDays(1)  'incrementa 1 dia
                    'Me.statusTabela.Text = "cdrs_" & Format(CDate(DateTimePicker1.Text), "yyyyMMdd")
                    'Me.StatusStrip1.Refresh()
                    'Filtro2SQL()
                Next i
            Finally
                frmPrincipal2.dtpDataInicio.Value = dt1
            End Try
            frmPrincipal2.dtpDataInicio.Visible = False
            nuDias.Visible = False
            txtSEL.Visible = True
            LimiteAtivado = False
            btnSEL.Text = "DIA"

            txtSQL.Text = "SELECT CLASSIF ,DATA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,LST_TG_E.`tg_name` AS ROTA_E,CSP, " _
                & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, LST_TG_S.`tg_name` AS ROTA_S, RN2, RN3, PT,Dialed_Number, Caller_Category, Bill_Type, Free_Ind, Charged_Party_Ind, " _
                & "Call_Type, GSVN, Failure_Code, Termination_code, Bearer_Service, Tele_Service, RxFlus, TxFlus, Caller_GK_Address, Caller_GW_Address, Called_GK_Address, Called_GW_Address " _
                & "FROM CDRs_Sel LEFT JOIN LST_TG AS LST_TG_E ON CDRs_Sel.R_ENT = LST_TG_E.`tg_number` " _
                & "LEFT JOIN LST_TG AS LST_TG_S ON CDRs_Sel.R_SAI = LST_TG_S.`tg_number`  " _
                & "LEFT JOIN cliente_terminal AS term_A ON CDRs_Sel.ASS_A = term_A.TERMINAL " _
                & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                & "LEFT JOIN cliente_terminal AS term_B ON CDRs_Sel.ASS_B = term_B.TERMINAL " _
                & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI"

            Try
                ProcessoInicio()
                pb1.Text = "Executando Consulta..."
                'statusRecCount.Visible = True
                ExecSQL()
                'BackgroundWorker1.RunWorkerAsync()
            Catch ex As Exception
                pb1.Visible = False
                'btnCancelar.Visible = False
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                ProcessoInicio()
                pb1.Text = "Executando Consulta..."
                'statusRecCount.Visible = True
                ExecSQL()
                'BackgroundWorker1.RunWorkerAsync()
            Catch ex As Exception
                pb1.Visible = False
                'btnCancelar.Visible = False
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Private Sub tvCausas_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvCausas.AfterSelect
        If tvCausas.SelectedNode Is Nothing Then Exit Sub
        Select Case tvCausas.SelectedNode.Name
            Case Is = "Todos CDRs"
                gvCDRs.ActiveFilterString = ""
            Case Is = "OK"
                gvCDRs.ActiveFilterString = "CLASSIF='OK1' OR CLASSIF='OK5'"
            Case Is = "OK1"
                gvCDRs.ActiveFilterString = "CLASSIF='OK1'"
            Case Is = "OK5"
                gvCDRs.ActiveFilterString = "CLASSIF='OK5'"
            Case Is = "NOK"
                gvCDRs.ActiveFilterString = "CLASSIF<>'OK1' AND CLASSIF<>'OK5'"
            Case Is = "CO"
                gvCDRs.ActiveFilterString = "CLASSIF='CO0' OR CLASSIF='CO1' OR CLASSIF='CO2' OR CLASSIF='CO3'"
            Case Is = "CO0"
                gvCDRs.ActiveFilterString = "CLASSIF='CO0'"
            Case Is = "CO1"
                gvCDRs.ActiveFilterString = "CLASSIF='CO1'"
            Case Is = "CO2"
                gvCDRs.ActiveFilterString = "CLASSIF='CO2'"
            Case Is = "CO3"
                gvCDRs.ActiveFilterString = "CLASSIF='CO3'"
            Case Is = "DSC"
                gvCDRs.ActiveFilterString = "CLASSIF='DSC'"
            Case Is = "PAB"
                gvCDRs.ActiveFilterString = "CLASSIF='NR1' OR CLASSIF='NR5' OR CLASSIF='LO'"
            Case Is = "LO"
                gvCDRs.ActiveFilterString = "CLASSIF='LO'"
            Case Is = "NR1"
                gvCDRs.ActiveFilterString = "CLASSIF='NR1'"
            Case Is = "NR5"
                gvCDRs.ActiveFilterString = "CLASSIF='NR5'"
            Case Is = "NR"
                gvCDRs.ActiveFilterString = "CLASSIF='NR1' OR CLASSIF='NR5'"
            Case Is = "OU"
                If tvCausas.SelectedNode.Level = 2 Then
                    gvCDRs.ActiveFilterString = "CLASSIF='OU'"
                Else
                    Select Case tvCausas.SelectedNode.Parent.Name
                        Case Is = "CO1"
                            gvCDRs.ActiveFilterString = "CLASSIF='CO1' AND (Not ROTA_S like '%XF' AND Not ROTA_S like '%QF' AND Not ROTA_S like '%HF')"
                        Case Is = "CO2"
                            gvCDRs.ActiveFilterString = "CLASSIF='CO2' AND (Not ROTA_S like '%XF' AND Not ROTA_S like '%QF' AND Not ROTA_S like '%HF')"
                        Case Is = "DSC"
                            gvCDRs.ActiveFilterString = "CLASSIF='DSC' AND (Not ROTA_S like '%XF' AND Not ROTA_S like '%QF' AND Not ROTA_S like '%HF')"
                    End Select
                End If
            Case Is = "XF"
                Select Case tvCausas.SelectedNode.Parent.Name
                    Case Is = "CO1"
                        gvCDRs.ActiveFilterString = "CLASSIF='CO1' AND ROTA_S like '%XF'"
                    Case Is = "CO2"
                        gvCDRs.ActiveFilterString = "CLASSIF='CO2' AND ROTA_S like '%XF'"
                    Case Is = "DSC"
                        gvCDRs.ActiveFilterString = "CLASSIF='DSC' AND ROTA_S like '%XF'"
                End Select
            Case Is = "QF"
                Select Case tvCausas.SelectedNode.Parent.Name
                    Case Is = "CO1"
                        gvCDRs.ActiveFilterString = "CLASSIF='CO1' AND ROTA_S like '%QF'"
                    Case Is = "CO2"
                        gvCDRs.ActiveFilterString = "CLASSIF='CO2' AND ROTA_S like '%QF'"
                    Case Is = "DSC"
                        gvCDRs.ActiveFilterString = "CLASSIF='DSC' AND ROTA_S like '%QF'"
                End Select
            Case Is = "HF"
                Select Case tvCausas.SelectedNode.Parent.Name
                    Case Is = "CO1"
                        gvCDRs.ActiveFilterString = "CLASSIF='CO1' AND ROTA_S like '%HF'"
                    Case Is = "CO2"
                        gvCDRs.ActiveFilterString = "CLASSIF='CO2' AND ROTA_S like '%HF'"
                    Case Is = "DSC"
                        gvCDRs.ActiveFilterString = "CLASSIF='DSC' AND ROTA_S like '%HF'"
                End Select
            Case Is = "LCL"
                Select Case tvCausas.SelectedNode.Parent.Name
                    Case Is = "LO"
                        gvCDRs.ActiveFilterString = "CLASSIF='LO' AND CSP='--' AND (Not ASS_B like '30%' AND Not ASS_B like '50%' AND Not ASS_B like '80%')"
                    Case Is = "NR1"
                        gvCDRs.ActiveFilterString = "CLASSIF='NR1' AND CSP='--' AND (Not ASS_B like '30%' AND Not ASS_B like '50%' AND Not ASS_B like '80%')"
                    Case Is = "NR5"
                        gvCDRs.ActiveFilterString = "CLASSIF='NR5' AND CSP='--' AND (Not ASS_B like '30%' AND Not ASS_B like '50%' AND Not ASS_B like '80%')"
                End Select
            Case Is = "LDN"
                Select Case tvCausas.SelectedNode.Parent.Name
                    Case Is = "LO"
                        gvCDRs.ActiveFilterString = "CLASSIF='LO' AND CSP <> '--'"
                    Case Is = "NR1"
                        gvCDRs.ActiveFilterString = "CLASSIF='NR1' AND CSP <> '--'"
                    Case Is = "NR5"
                        gvCDRs.ActiveFilterString = "CLASSIF='NR5' AND CSP <> '--'"
                End Select
            Case Is = "SNG"
                Select Case tvCausas.SelectedNode.Parent.Name
                    Case Is = "LO"
                        gvCDRs.ActiveFilterString = "CLASSIF='LO' AND (ASS_B like '30%' OR ASS_B like '50%' OR ASS_B like '80%')"
                    Case Is = "NR1"
                        gvCDRs.ActiveFilterString = "CLASSIF='NR1' AND (ASS_B like '30%' OR ASS_B like '50%' OR ASS_B like '80%')"
                    Case Is = "NR5"
                        gvCDRs.ActiveFilterString = "CLASSIF='NR5' AND (ASS_B like '30%' OR ASS_B like '50%' OR ASS_B like '80%')"
                End Select
        End Select
    End Sub

    Private Sub txtValor1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor1.KeyPress
        If (e.KeyChar = "%" Or e.KeyChar = "_") And cbOperador1.Text = "=" Then
            cbOperador1.Text = "LIKE"
        End If
    End Sub

    Private Sub txtValor2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor2.KeyPress
        If (e.KeyChar = "%" Or e.KeyChar = "_") And cbOperador2.Text = "=" Then
            cbOperador2.Text = "LIKE"
        End If
    End Sub

    Private Sub txtValor3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor3.KeyPress
        If (e.KeyChar = "%" Or e.KeyChar = "_") And cbOperador3.Text = "=" Then
            cbOperador3.Text = "LIKE"
        End If
    End Sub

    Private Sub txtValor4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor4.KeyPress
        If (e.KeyChar = "%" Or e.KeyChar = "_") And cbOperador4.Text = "=" Then
            cbOperador4.Text = "LIKE"
        End If
    End Sub

    Private Sub txtValor5_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor5.KeyPress
        If (e.KeyChar = "%" Or e.KeyChar = "_") And cbOperador5.Text = "=" Then
            cbOperador5.Text = "LIKE"
        End If
    End Sub

#Region "Exportar"
    Public Sub Exportar(ByVal index As Integer)
        'ProcessoInicio()
        'ExportToExcel(dGridCdrs, xlsOption.xlsOpen)
        'ProcessoFim()
        Dim exportData(,) As String = { _
       {"Documento HTML", "Documentos HTML|*.html", "htm"}, _
       {"Documento XML", "Documentos XML|*.xml", "xml"}, _
       {"Documento Microsoft Excel 2007", "Microsoft Excel|*.xlsx", "xlsx"}, _
       {"Documento Microsoft Excel", "Microsoft Excel|*.xls", "xls"}, _
       {"Documento RTF", "Arquivos RTF|*.rtf", "rtf"}, _
       {"Documento PDF", "Arquivos PDF|*.pdf", "pdf"}, _
       {"Documento MHT", "Arquivos MHT|*.mht", "mht"}, _
       {"Documento Texto", "Arquivos Text|*.txt", "txt"}}


        'saveFileDialog1.Filter = "*.xls|Arquivos excel (*.xls"
        'If saveFileDialog1.ShowDialog Then
        'frmLancamentos.gcLancamentos.ExportToXls(saveFileDialog1.FileName)
        'MsgBox(String.Format("O aquivo {0:s} foi gravado.", saveFileDialog1.FileName))
        'End If

        If index < 0 Then
            Return
        End If
        Dim fileName As String = ShowSaveFileDialog(exportData.GetValue(index, 0).ToString(), exportData.GetValue(index, 1).ToString())
        If fileName = String.Empty Then
            Return
        End If
        If exportData.GetValue(index, 2).Equals("xml") Then
            ExportTo(New ExportXmlProvider(fileName))
            OpenFile(fileName)
        Else
            ExportToEx(fileName, exportData.GetValue(index, 2).ToString(), gvCDRs)
            OpenFile(fileName)
        End If

    End Sub

    Private Sub ExportToEx(ByVal filename As String, ByVal ext As String, ByVal exportView As BaseView)
        Dim currentCursor As System.Windows.Forms.Cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor
        pb1.Text = "Exportando..."
        pb1.ProgressType = DevComponents.DotNetBar.eProgressItemType.Standard
        pb1.Visible = True
        Application.DoEvents()

        Dim ps As DevExpress.XtraPrinting.IPrintingSystem = DevExpress.XtraPrinting.PrintHelper.GetCurrentPS()
        AddHandler ps.AfterChange, AddressOf Export_ProgressEx
        If ext = "rtf" Then
            exportView.ExportToRtf(filename)
        End If
        If ext = "pdf" Then
            exportView.ExportToPdf(filename)
        End If
        If ext = "mht" Then
            exportView.ExportToMht(filename)
        End If
        If ext = "htm" Then
            exportView.ExportToHtml(filename)
        End If
        If ext = "txt" Then
            exportView.ExportToText(filename)
        End If
        If ext = "xls" Then
            exportView.ExportToXls(filename)
        End If
        If ext = "xlsx" Then
            exportView.ExportToXlsx(filename)
        End If
        RemoveHandler ps.AfterChange, AddressOf Export_ProgressEx
        Cursor.Current = currentCursor
    End Sub
    Private Sub Export_Progress(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Export.ProgressEventArgs)
        If e.Phase = DevExpress.XtraGrid.Export.ExportPhase.Link Then
            SetPosition(e.Position)
        End If
    End Sub
    Private Sub Export_ProgressEx(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.ChangeEventArgs)
        If e.EventName = DevExpress.XtraPrinting.SR.ProgressPositionChanged Then
            SetPosition(CInt(Fix(e.ValueOf(DevExpress.XtraPrinting.SR.ProgressPosition))))
        End If
    End Sub
    Private Sub SetPosition(ByVal pos As Integer)
        pb1.Value = pos
        Application.DoEvents()
        'Me.Update()
    End Sub

    Private Function ShowSaveFileDialog(ByVal title As String, ByVal filter As String) As String
        Dim dlg As New SaveFileDialog()
        Dim name As String = Application.ProductName
        Dim n As Integer = name.LastIndexOf(".") + 1
        If n > 0 Then
            name = name.Substring(n, name.Length - n)
        End If
        dlg.Title = "Exportar Para " & title
        dlg.FileName = name
        dlg.Filter = filter
        If dlg.ShowDialog() = DialogResult.OK Then
            Return dlg.FileName
        End If
        Return ""
    End Function
    Private Sub OpenFile(ByVal fileName As String)
        If XtraMessageBox.Show("Quer abrir o arquivo exportado?", "Exportar Para...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                Dim process As New System.Diagnostics.Process()
                process.StartInfo.FileName = fileName
                process.StartInfo.Verb = "Open"
                process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                process.Start()
            Catch
                DevExpress.XtraEditors.XtraMessageBox.Show(Me, "Não foi encontrado programa para abrir o arquivo exportado.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        pb1.Value = 0
        pb1.Visible = False
    End Sub
    Private Sub ExportTo(ByVal provider As IExportProvider)
        Dim currentCursor As System.Windows.Forms.Cursor = Cursor.Current
        Cursor.Current = Cursors.WaitCursor

        Me.FindForm().Refresh()
        Dim link As BaseExportLink = gvCDRs.CreateExportLink(provider)
        TryCast(link, GridViewExportLink).ExpandAll = False
        AddHandler link.Progress, AddressOf Export_Progress
        link.ExportTo(True)
        provider.Dispose()
        RemoveHandler link.Progress, AddressOf Export_Progress

        Cursor.Current = currentCursor
    End Sub

#End Region
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs)
        Try
            ExecSQL()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs)
        Try
            'statusRecCount.Text = "Preenchendo Grade..."
            pb1.Refresh()
            gcCDRs.DataSource = dt
            GeraPizza()
            ProcessoFim()
            'ToolStripProgressBar1.Visible = False
            'btnCancelar.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub gvCDRs_DoubleClick(sender As System.Object, e As System.EventArgs) Handles gvCDRs.DoubleClick
        If Me.cbCampo1.Text = "" Then
            Me.cbCampo1.Text = gvCDRs.FocusedColumn.Name
            Me.txtValor1.Text = gvCDRs.GetDataRow(gvCDRs.FocusedRowHandle).Item(gvCDRs.FocusedColumn.Name)
        Else
            If Me.cbCampo2.Text = "" Then
                Me.cbCampo2.Text = gvCDRs.FocusedColumn.Name
                Me.txtValor2.Text = gvCDRs.GetDataRow(gvCDRs.FocusedRowHandle).Item(gvCDRs.FocusedColumn.Name).ToString
                Me.cbConector1.Text = "E"
            Else
                Me.cbCampo3.Text = gvCDRs.FocusedColumn.Name
                Me.txtValor3.Text = gvCDRs.GetDataRow(gvCDRs.FocusedRowHandle).Item(gvCDRs.FocusedColumn.Name)
                Me.cbConector2.Text = "E"
            End If
        End If
        If Me.cbCampo1.Text = "CLIENTE_A" Then Me.cbCampo1.Text = "cli_A.CLIENTE"
        If Me.cbCampo2.Text = "CLIENTE_A" Then Me.cbCampo2.Text = "cli_A.CLIENTE"
        If Me.cbCampo3.Text = "CLIENTE_A" Then Me.cbCampo3.Text = "cli_A.CLIENTE"
        If Me.cbCampo4.Text = "CLIENTE_A" Then Me.cbCampo4.Text = "cli_A.CLIENTE"
        If Me.cbCampo5.Text = "CLIENTE_A" Then Me.cbCampo5.Text = "cli_A.CLIENTE"

        If Me.cbCampo1.Text = "CLIENTE_B" Then Me.cbCampo1.Text = "cli_B.CLIENTE"
        If Me.cbCampo2.Text = "CLIENTE_B" Then Me.cbCampo2.Text = "cli_B.CLIENTE"
        If Me.cbCampo3.Text = "CLIENTE_B" Then Me.cbCampo3.Text = "cli_B.CLIENTE"
        If Me.cbCampo4.Text = "CLIENTE_B" Then Me.cbCampo4.Text = "cli_B.CLIENTE"
        If Me.cbCampo5.Text = "CLIENTE_B" Then Me.cbCampo5.Text = "cli_B.CLIENTE"

        If Me.cbCampo1.Text = "ROTA_E" Then Me.cbCampo1.Text = "LST_TG_E.`tg_name`"
        If Me.cbCampo2.Text = "ROTA_E" Then Me.cbCampo2.Text = "LST_TG_E.`tg_name`"
        If Me.cbCampo3.Text = "ROTA_E" Then Me.cbCampo3.Text = "LST_TG_E.`tg_name`"
        If Me.cbCampo4.Text = "ROTA_E" Then Me.cbCampo4.Text = "LST_TG_E.`tg_name`"
        If Me.cbCampo5.Text = "ROTA_E" Then Me.cbCampo5.Text = "LST_TG_E.`tg_name`"

        If Me.cbCampo1.Text = "ROTA_S" Then Me.cbCampo1.Text = "LST_TG_S.`tg_name`"
        If Me.cbCampo2.Text = "ROTA_S" Then Me.cbCampo2.Text = "LST_TG_S.`tg_name`"
        If Me.cbCampo3.Text = "ROTA_S" Then Me.cbCampo3.Text = "LST_TG_S.`tg_name`"
        If Me.cbCampo4.Text = "ROTA_S" Then Me.cbCampo4.Text = "LST_TG_S.`tg_name`"
        If Me.cbCampo5.Text = "ROTA_S" Then Me.cbCampo5.Text = "LST_TG_S.`tg_name`"

        If Me.cbCampo1.Text = "DATA" Then Me.txtValor1.Text = Format(CDate(Me.txtValor1.Text), "yyyy-MM-dd hh:MM:ss")
        If Me.cbCampo2.Text = "DATA" Then Me.txtValor2.Text = Format(CDate(Me.txtValor2.Text), "yyyy-MM-dd hh:MM:ss")
        If Me.cbCampo3.Text = "DATA" Then Me.txtValor3.Text = Format(CDate(Me.txtValor3.Text), "yyyy-MM-dd hh:MM:ss")
        If Me.cbCampo4.Text = "DATA" Then Me.txtValor4.Text = Format(CDate(Me.txtValor4.Text), "yyyy-MM-dd hh:MM:ss")
        If Me.cbCampo5.Text = "DATA" Then Me.txtValor5.Text = Format(CDate(Me.txtValor5.Text), "yyyy-MM-dd hh:MM:ss")

    End Sub

    Private Function LocalizaDentroDoBloco(ByVal LinhaInicial As Integer) As Integer
        Dim i, j As Integer
        Dim vASS_B, vASS_A, vDATA As String
        Dim Coincidencias As Integer

        If Me.gvCDRs.RowCount <= 0 Then Exit Function

        Coincidencias = 0

        vASS_B = gvCDRs.GetDataRow(LinhaInicial).Item("ASS_B").ToString
        vASS_A = gvCDRs.GetDataRow(LinhaInicial).Item("ASS_A").ToString
        vDATA = gvCDRs.GetDataRow(LinhaInicial).Item("DATA").ToString
        For i = LinhaInicial + 1 To gvCDRs.RowCount - 1
            If vASS_B = gvCDRs.GetDataRow(i).Item("ASS_B") And _
                vASS_A = gvCDRs.GetDataRow(i).Item("ASS_A") And _
                vDATA = gvCDRs.GetDataRow(i).Item("DATA") Then
                Coincidencias += 1
            Else
                vASS_B = gvCDRs.GetDataRow(i).Item("ASS_B").ToString
                vASS_A = gvCDRs.GetDataRow(i).Item("ASS_A").ToString
                vDATA = gvCDRs.GetDataRow(i).Item("DATA").ToString
                Coincidencias = 0
            End If
            If Coincidencias > 2 Then
                For j = i To gvCDRs.RowCount - 1
                    If vASS_B = gvCDRs.GetDataRow(j).Item("ASS_B") And _
                        vASS_A = gvCDRs.GetDataRow(j).Item("ASS_A") Then
                        'vDATA = Me.dGridCdrs.Item(Me.dGridCdrs.Columns("DATA").Index, j).Value Then
                        LocalizaDentroDoBloco = j
                    Else
                        Continue For
                    End If
                Next j

                Dim filtro As String
                filtro = "ASS_B='" & vASS_B & "' AND ASS_A='" & vASS_A & "'"
                Dim dt As DataTable = CType(gvCDRs.DataSource, DataView).Table
                Dim drc As DataRow() = dt.Select(filtro)
                Dim dv As New DataView(dt)
                dv.RowFilter = filtro

                gcCDRs.DataSource = dv
                gcCDRs.DataSource = dv
                'Me.statusRecCount.Text = "Registros: " & dGridCdrs.RowCount
                'Me.statusTempoGasto.BackColor = Color.Aqua
                'Me.statusTempoGasto.Text = "FILTRADO: [" & filtro & "]"
                'StatusStrip1.Refresh()
                Exit Function
            End If
        Next i
        LocalizaDentroDoBloco = 0
    End Function

    Public Function LocalizaLoop(ByVal Inicio As Integer) As Integer
        Dim TeveLoop As Boolean

        ProcessoInicio()
        expandableSplitter1.Expanded = False
        btnLimpar_Criterios()
        LimiteValor = 0
        LimiteAtivado = True
        ExecSQL()
        gcCDRs.DataSource = dt
        gcCDRs.Refresh()
        LimiteValor = 500
        cbCampo1.Text = "CLASSIF"
        cbOperador2.Text = "="
        txtValor1.Text = "DSC"

        cbCampo2.Text = "ASS_A"
        cbOperador2.Text = "<>"
        txtValor2.Text = ""

        cbCampo3.Text = "ASS_B"
        cbOperador3.Text = "<>"
        txtValor3.Text = ""

        InicioLIMIT = Inicio
        TeveLoop = False
        Do
            LimiteAtivado = False
            txtSQL.Text &= " LIMIT " & InicioLIMIT & "," & BLOCO_DE_CDRs
            'Preparar SQL
            ExecSQL()

            gcCDRs.DataSource = dt
            If gvCDRs.RowCount <= 0 Then Continue Do
            LinhaInicialPesquisaLoop = LocalizaDentroDoBloco(0)
            If LinhaInicialPesquisaLoop <> 0 Then
                'frmPrincipal.btnContinuarPesquisaLoop.Enabled = True
                LocalizaLoop = Inicio + LinhaInicialPesquisaLoop
                TeveLoop = True
            Else
                InicioLIMIT += BLOCO_DE_CDRs
            End If
        Loop While (gvCDRs.RowCount = BLOCO_DE_CDRs)
        If Not TeveLoop Then
            LimiteValor = 0
            LimiteAtivado = True
            ExecSQL()
            gcCDRs.DataSource = dt
            MsgBox("Parabéns! Não encontrei indícios de LOOP.")
            LimiteAtivado = 500
        End If
        ProcessoFim()
    End Function

End Class