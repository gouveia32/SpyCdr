Imports Dundas.Charting.WinControl
Imports System.Data

Public Class frmListaCdrs_N
    Dim IndicadorNome() As String = {"CO0", "CO1", "CO2", "CO3", "DSC", "LO", "NR1", "NR5", "OK1", "OK5", "OU"}
    Dim Operadores() As String = {"=", "<>", ">", ">=", "<", "<=", "LIKE", "NOT LIKE"}
    Dim Campos() As String = {"CLASSIF", "DATA", "HORA", "DURACAO", "ASS_A", "cli_A.CLIENTE", "R_ENT", _
                              "IGT", "CSP", "ASS_B", "cli_B.CLIENTE", "R_SAI", "OGT", "NR_DISCADO", "RN2", "RN3", "CAUSA", _
                              "CAT", "FDS", "PT", "CL", "OCUP_INICIO", "OCUP_FIM"}
    'define a string de Conn
    Dim tCol As DataColumn
    'define os objetos connecton, command e dataadapter
    Dim corStatusBack As Color
    Dim LinhaInicialPesquisaLoop, InicioLIMIT As Integer

    'Declare a variable to hold the last accessed edit control
    Private CurEditControl As Control
    Const BLOCO_DE_CDRs = 5000
    Dim horaI, horaF As DateTime
    Private m_Search As BalloonSearch

    Private Sub ProcessoInicio()
        statusTempoGasto.Text = "Processando..."
        horaI = Now
        Me.statusTempoGasto.BackColor = Color.Aqua
        statusTempoGasto.Visible = True
        Me.StatusStrip1.Refresh()
        Cursor = Cursors.WaitCursor
    End Sub

    Private Sub ProcessoFim()
        Me.statusTempoGasto.BackColor = corStatusBack
        Me.StatusStrip1.Refresh()
        horaF = Now
        Me.statusTempoGasto.Text = "Tempo: " & Format((horaF - horaI).TotalSeconds, "####") & " seg  "
        Cursor = Cursors.Default
    End Sub

    Private Sub FormataGrid()

        'formata as colunas de dGrid
        With dGridCdrs
            .Font = New Font("Tahoma", 7.0!, FontStyle.Regular)
            '0        1     2       3      4              5      6      7    8    9      10             11     12   13   14   15   16   17  18   19        20  
            'CLASSIF, Data, Hora, DURACAO, ASS_A, cli_A.CLIENTE, R_ENT, ICT, CSP, ASS_B, cli_B.CLIENTE, R_SAI, OGT, EOS, CAT, FDS, PT, ECH, DUR_RING, DUR_TOTAL 
            .Columns(0).Width = 35  'CLASSIF
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(1).Width = 63  'DATA
            .Columns(1).DefaultCellStyle.BackColor = Color.LightYellow
            .Columns(1).DefaultCellStyle.Format = "yyyy-MM-dd"
            .Columns(2).Width = 45  'HORA
            .Columns(2).DefaultCellStyle.BackColor = Color.LightYellow
            .Columns(3).Width = 45  'DUR
            .Columns(3).DefaultCellStyle.BackColor = Color.LightYellow
            .Columns(4).Width = 70  'Ass-A
            .Columns(4).DefaultCellStyle.BackColor = Color.LightBlue
            .Columns(5).Width = 85  'Cliente
            .Columns(5).DefaultCellStyle.BackColor = Color.LightBlue
            .Columns(6).Width = 50  'R_ENT
            .Columns(6).DefaultCellStyle.BackColor = Color.LightBlue
            .Columns(7).Width = 30  'ICT
            .Columns(7).DefaultCellStyle.BackColor = Color.LightBlue
            .Columns(8).Width = 25  'CSP
            .Columns(8).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(9).Width = 70  'ASS_B
            .Columns(9).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(10).Width = 85  'CLIENTE
            .Columns(10).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(11).Width = 50  'R_SAI
            .Columns(11).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(12).Width = 30 'OGT
            .Columns(12).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(13).Width = 50  'NR_Discado
            .Columns(13).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(14).Width = 45 'RN2
            .Columns(14).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(15).Width = 20 'RN3
            .Columns(15).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(16).Width = 30 'EOS
            .Columns(17).Width = 25 'CAT
            .Columns(18).Width = 25 'FDS
            .Columns(19).Width = 25 'PT
            .Columns(20).Width = 25 'ECH
            .Columns(21).Width = 55 'DUR_RING
            .Columns(21).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(22).Width = 55 'DUR_TOTAL
            .Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        End With
    End Sub
    Private Sub ExecSQL()

        Dim horaI As DateTime
        'define os objetos connecton, command e dataadapter
        Try
            horaI = Now
            ProcessoInicio()

            '---abre a Conn---
            Conn.Open()

            Dim dt As New DataTable
            dt = MySQL_Select(Conn, txtSQL.Text)
            ' vincula a tabela ao datagrid
            dGridCdrs.DataSource = dt.DefaultView
            '---fecha a Conn---
            Conn.Close()
            'Chart1.DataSource = ds
            FormataGrid()
            GeraPizza()

            'txtRecCount.Text = dGridCdrs.RowCount - 1
            Me.statusRecCount.Text = "Registros: " & dGridCdrs.RowCount
        Catch ex As Exception
            'MsgBox(ex.Message)
        Finally
            Me.WindowState = FormWindowState.Maximized
            Cursor.Current = System.Windows.Forms.Cursors.Default
            ProcessoFim()
            If dGridCdrs.RowCount < 1 And InStr(txtSQL.Text, "LIMIT 0") < 1 Then MsgBox("Nenhum registro foi encontrado!")
        End Try
    End Sub

    Private Sub ExecSQL_insert()
        'define os objetos connecton, command e dataadapter
        Dim dt As DataTable
        Try
            ProcessoInicio()

            dt = MySQL_Select(Conn, txtSQL.Text)

            Me.statusRecCount.Text = "Registros: " & dGridCdrs.RowCount
        Catch ex As Exception
            MsgBox(ex.Message)
            ProcessoFim()
        Finally
            Me.WindowState = FormWindowState.Maximized
            Cursor.Current = System.Windows.Forms.Cursors.Default
            'horaF = Now
            'Me.statusTempoGasto.Text = "Tempo: " & Format((horaF - horaI).TotalSeconds, "####") & " seg  "
            ProcessoFim()
            If dGridCdrs.RowCount < 1 And InStr(txtSQL.Text, "LIMIT 0") < 1 Then MsgBox("Nenhum registro foi encontrado!")
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
            Me.DateTimePicker1.Text = Format(CDate(nomeTabela.Substring(5, 4) & "-" & nomeTabela.Substring(9, 2) & "-" & nomeTabela.Substring(11, 2)))

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
        Me.nudLimite.Value = mLimit
        Me.cbLimite.Checked = True

    End Sub
    Private Sub Filtro2SQL()
        Dim nomeTabela, strSELECT, strFROM, strWHERE As String

        If DateTimePicker1.Text = "" Then Exit Sub
        'btnProximoLoop.Enabled = False

        If txtSEL.Visible Then
            nomeTabela = "cdrs_SEL"
        Else
            nomeTabela = "cdrs_" & Format(CDate(DateTimePicker1.Value), "yyyyMMdd")
        End If
        If nuDias.Value > 1 And nuDias.Visible Then
            strSELECT = "SELECT CLASSIF, ASS_A, CSP, ASS_B, CAT, FDS, CAUSA, PT, CL, ICT, OGT, R_ENT, R_SAI, DATA, HORA, OCUP_INICIO, DURACAO, OCUP_FIM, TTFILE, NR_DISCADO, RN2, RN3 "
        Else
            strSELECT = "SELECT CLASSIF ,DATA, HORA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,ICT,CSP, " _
                        & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, OGT, NR_DISCADO, RN2, RN3, CAUSA, CAT, FDS, PT, CL, OCUP_INICIO, OCUP_FIM "
        End If

        strFROM = "FROM " & nomeTabela & " " _
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

        txtSQL.Text = strSELECT & strFROM & strWHERE
        If Me.cbOrdenar.Text.Substring(0, 3) <> "Sem" Then
            txtSQL.Text &= " ORDER BY " & cbOrdenar.Text
        End If
        If Me.cbLimite.Checked Then
            txtSQL.Text &= " LIMIT " & Me.nudLimite.Value.ToString
        End If
        If nuDias.Value > 1 And nuDias.Visible Then
            txtSQL.Text = "INSERT INTO CDRs_SEL " & txtSQL.Text
        End If

    End Sub
    Private Sub _TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor1.TextChanged, txtValor5.TextChanged, txtValor4.TextChanged, txtValor3.TextChanged, txtValor2.TextChanged, nudLimite.ValueChanged, cbParenteseF5.CheckedChanged, cbParenteseF4.CheckedChanged, cbParenteseF3.CheckedChanged, cbParenteseF2.CheckedChanged, cbParenteseF1.CheckedChanged, cbParenteseA5.CheckedChanged, cbParenteseA4.CheckedChanged, cbParenteseA3.CheckedChanged, cbParenteseA2.CheckedChanged, cbParenteseA1.CheckedChanged, cbOperador5.SelectedIndexChanged, cbOperador4.SelectedIndexChanged, cbOperador3.SelectedIndexChanged, cbOperador2.SelectedIndexChanged, cbOperador1.SelectedIndexChanged, cbLimite.CheckedChanged, cbConector4.SelectedIndexChanged, cbConector3.SelectedIndexChanged, cbConector2.SelectedIndexChanged, cbConector1.SelectedIndexChanged, cbCampo5.SelectedIndexChanged, cbCampo4.SelectedIndexChanged, cbCampo3.SelectedIndexChanged, cbCampo2.SelectedIndexChanged, cbCampo1.SelectedIndexChanged, txtSEL.TextChanged, DateTimePicker1.ValueChanged, nuDias.ValueChanged, cbOrdenar.SelectedIndexChanged
        Filtro2SQL()
    End Sub


    Private Sub btnLimpar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpar.Click
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
        btnProximoLoop.Enabled = False
        cbLimite.Checked = True
    End Sub
    Private Sub dGridCdrs_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGridCdrs.CellDoubleClick
        If Me.cbCampo1.Text = "" Then
            Me.cbCampo1.Text = dGridCdrs.Columns(e.ColumnIndex).Name.ToString()
            Me.txtValor1.Text = dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString()
        Else
            If Me.cbCampo2.Text = "" Then
                Me.cbCampo2.Text = dGridCdrs.Columns(e.ColumnIndex).Name.ToString()
                Me.txtValor2.Text = dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString()
                Me.cbConector1.Text = "E"
            Else
                Me.cbCampo3.Text = dGridCdrs.Columns(e.ColumnIndex).Name.ToString()
                Me.txtValor3.Text = dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString()
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

        If Me.cbCampo1.Text = "ROTA_E" Then Me.cbCampo1.Text = "_exrop_E.ROTA"
        If Me.cbCampo2.Text = "ROTA_E" Then Me.cbCampo2.Text = "_exrop_E.ROTA"
        If Me.cbCampo3.Text = "ROTA_E" Then Me.cbCampo3.Text = "_exrop_E.ROTA"
        If Me.cbCampo4.Text = "ROTA_E" Then Me.cbCampo4.Text = "_exrop_E.ROTA"
        If Me.cbCampo5.Text = "ROTA_E" Then Me.cbCampo5.Text = "_exrop_E.ROTA"

        If Me.cbCampo1.Text = "ROTA_S" Then Me.cbCampo1.Text = "_exrop_S.ROTA"
        If Me.cbCampo2.Text = "ROTA_S" Then Me.cbCampo2.Text = "_exrop_S.ROTA"
        If Me.cbCampo3.Text = "ROTA_S" Then Me.cbCampo3.Text = "_exrop_S.ROTA"
        If Me.cbCampo4.Text = "ROTA_S" Then Me.cbCampo4.Text = "_exrop_S.ROTA"
        If Me.cbCampo5.Text = "ROTA_S" Then Me.cbCampo5.Text = "_exrop_S.ROTA"

        If Me.cbCampo1.Text = "DATA" Then Me.txtValor1.Text = Format(CDate(Me.txtValor1.Text), "yyyy-MM-dd hh:MM:ss")
        If Me.cbCampo2.Text = "DATA" Then Me.txtValor2.Text = Format(CDate(Me.txtValor2.Text), "yyyy-MM-dd hh:MM:ss")
        If Me.cbCampo3.Text = "DATA" Then Me.txtValor3.Text = Format(CDate(Me.txtValor3.Text), "yyyy-MM-dd hh:MM:ss")
        If Me.cbCampo4.Text = "DATA" Then Me.txtValor4.Text = Format(CDate(Me.txtValor4.Text), "yyyy-MM-dd hh:MM:ss")
        If Me.cbCampo5.Text = "DATA" Then Me.txtValor5.Text = Format(CDate(Me.txtValor5.Text), "yyyy-MM-dd hh:MM:ss")

    End Sub


    Private Sub dGridCdrs_CellContextMenuStripNeeded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventArgs) Handles dGridCdrs.CellContextMenuStripNeeded

        If e.ColumnIndex < 0 Then Exit Sub
        Me.ContextMenuStrip1.Items.Clear()
        Me.ContextMenuStrip1.Items.Add(dGridCdrs.Columns(e.ColumnIndex).Name & " = '" & dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString & "'")
        Me.ContextMenuStrip1.Items(0).Name = "mnuFiltrar1"
        Me.ContextMenuStrip1.Items.Add(" AND " & dGridCdrs.Columns(e.ColumnIndex).Name & " = '" & dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString & "'")
        Me.ContextMenuStrip1.Items(1).Name = "mnuFiltrar2"
        Me.ContextMenuStrip1.Items.Add(" OR " & dGridCdrs.Columns(e.ColumnIndex).Name & " = '" & dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString & "'")
        Me.ContextMenuStrip1.Items(2).Name = "mnuFiltrar3"
        Me.ContextMenuStrip1.Items.Add(dGridCdrs.Columns(e.ColumnIndex).Name & " <> '" & dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString & "'")
        Me.ContextMenuStrip1.Items(3).Name = "mnuFiltrar4"
        Me.ContextMenuStrip1.Items.Add(dGridCdrs.Columns(e.ColumnIndex).Name & " > '" & dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString & "'")
        Me.ContextMenuStrip1.Items(4).Name = "mnuFiltrar5"
        Me.ContextMenuStrip1.Items.Add(dGridCdrs.Columns(e.ColumnIndex).Name & " < '" & dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString & "'")
        Me.ContextMenuStrip1.Items(5).Name = "mnuFiltrar6"
        Me.ContextMenuStrip1.Items.Add("-")
        Me.ContextMenuStrip1.Items(6).Name = "mnuSeparador1"
        Me.ContextMenuStrip1.Items.Add(dGridCdrs.Columns(e.ColumnIndex).Name & " = '...'")
        Me.ContextMenuStrip1.Items(7).Name = "mnuFiltrar7"
        Me.ContextMenuStrip1.Items.Add(dGridCdrs.Columns(e.ColumnIndex).Name & " <> '...'")
        Me.ContextMenuStrip1.Items(8).Name = "mnuFiltrar8"
        Me.ContextMenuStrip1.Items.Add(dGridCdrs.Columns(e.ColumnIndex).Name & " > '...'")
        Me.ContextMenuStrip1.Items(9).Name = "mnuFiltrar9"
        Me.ContextMenuStrip1.Items.Add(dGridCdrs.Columns(e.ColumnIndex).Name & " < '...'")
        Me.ContextMenuStrip1.Items(10).Name = "mnuFiltrar10"
        Me.ContextMenuStrip1.Items.Add(dGridCdrs.Columns(e.ColumnIndex).Name & " LIKE '%...%'")
        Me.ContextMenuStrip1.Items(11).Name = "mnuFiltrar11"
        Me.ContextMenuStrip1.Items.Add(dGridCdrs.Columns(e.ColumnIndex).Name & " LIKE '...'")
        Me.ContextMenuStrip1.Items(12).Name = "mnuFiltrar12"
        Me.ContextMenuStrip1.Items.Add(" AND " & dGridCdrs.Columns(e.ColumnIndex).Name & " LIKE '...'")
        Me.ContextMenuStrip1.Items(13).Name = "mnuFiltrar13"
        Me.ContextMenuStrip1.Items.Add(" OR " & dGridCdrs.Columns(e.ColumnIndex).Name & " LIKE '...'")
        Me.ContextMenuStrip1.Items(14).Name = "mnuFiltrar14"
        Me.ContextMenuStrip1.Items.Add("-")
        Me.ContextMenuStrip1.Items(15).Name = "mnuSeparador2"
        Me.ContextMenuStrip1.Items.Add("Localizar: " & dGridCdrs.Columns(e.ColumnIndex).Name & " = '...'")
        Me.ContextMenuStrip1.Items(16).Name = "mnuLocalizar"
        Me.ContextMenuStrip1.Items(16).Image = My.Resources.Aussichten
        Me.ContextMenuStrip1.Items.Add("-")
        Me.ContextMenuStrip1.Items(17).Name = "mnuSeparador3"
        Me.ContextMenuStrip1.Items.Add("Limpar Filtro")
        Me.ContextMenuStrip1.Items(18).Name = "mnuLiberarFiltro"
        Me.ContextMenuStrip1.Items(18).Image = My.Resources.eraser
        Me.ContextMenuStrip1.Items.Add("Fechar")
        Me.ContextMenuStrip1.Items(19).Name = "mnuFechar"
        Me.ContextMenuStrip1.Items(19).Image = My.Resources._EXIT
    End Sub

    Private Sub Filtrar(ByVal filtro As String)
        ' obtem a tabela vinculada ao datagrid
        Dim dt As DataTable = CType(dGridCdrs.DataSource, DataView).Table

        ' localiza os registros usando o método select do datatable
        Dim drc As DataRow() = dt.Select(filtro)

        ' localiza os registros usando a propriedade RowFilter do DataView
        Dim dv As New DataView(dt)

        If filtro <> "" Then
            'executa o filtro no dataview
            dv.RowFilter = filtro

            'vincula o resultado ao dtagrid
            dGridCdrs.DataSource = dv
            Me.statusRecCount.Text = "Registros: " & dGridCdrs.RowCount
            Me.statusTempoGasto.BackColor = Color.Aqua
            Me.statusTempoGasto.Text = "FILTRADO: [" & filtro & "]"
            StatusStrip1.Refresh()
        Else
            'Liberar Filtro
            dv.RowFilter = ""

            'vincula o resultado ao dtagrid
            dGridCdrs.DataSource = dv
            Me.statusRecCount.Text = "Registros: " & dGridCdrs.RowCount
            Me.statusTempoGasto.BackColor = corStatusBack
            Me.statusTempoGasto.Text = ""
            StatusStrip1.Refresh()
        End If
        GeraPizza()

    End Sub
    Private Sub ContextMenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Dim i As Integer
        Select Case e.ClickedItem.Name
            Case "mnuFiltrar1", "mnuFiltrar4", "mnuFiltrar5", "mnuFiltrar6"
                ' obtem a tabela vinculada ao datagrid
                Dim dt As DataTable = CType(dGridCdrs.DataSource, DataView).Table
                Dim filtro As String

                filtro = e.ClickedItem.Text
                Filtrar(filtro)
            Case "mnuFiltrar2", "mnuFiltrar3"
                ' obtem a tabela vinculada ao datagrid
                Dim dt As DataTable = CType(dGridCdrs.DataSource, DataView).Table
                Dim filtro As String

                If Me.statusTempoGasto.Text <> "" Then
                    If Me.statusTempoGasto.Text.Substring(0, 5) <> "Tempo" Then
                        filtro = Me.statusTempoGasto.Text.Substring(Me.statusTempoGasto.Text.IndexOf("[") + 1, _
                                 Me.statusTempoGasto.Text.IndexOf("]") - Me.statusTempoGasto.Text.IndexOf("[") - 1) _
                                 & e.ClickedItem.Text
                    Else
                        filtro = e.ClickedItem.Text.Substring(4, e.ClickedItem.Text.Length - 4)
                    End If
                Else
                    filtro = e.ClickedItem.Text.Substring(4, e.ClickedItem.Text.Length - 4)
                End If
                Filtrar(filtro)
            Case "mnuFiltrar7", "mnuFiltrar8", "mnuFiltrar9", "mnuFiltrar10", "mnuFiltrar11", "mnuFiltrar12"
                Dim filtroValor, filtro As String
                filtro = e.ClickedItem.Text.Substring(0, e.ClickedItem.Text.IndexOf("'") + 1)
                filtroValor = InputBox(filtro, "Digite o valor do filtro:", "")
                If e.ClickedItem.Name = "mnuFiltrar11" Then 'LIKE
                    filtro &= "%" & filtroValor & "%'"
                Else
                    filtro &= filtroValor & "'"
                End If
                Filtrar(filtro)
            Case "mnuFiltrar13", "mnuFiltrar14"
                Dim filtroValor, filtro As String
                filtroValor = InputBox(filtro, "Digite o valor do filtro:", "%")
                If Me.statusTempoGasto.Text <> "" Then
                    If Me.statusTempoGasto.Text.Substring(0, 5) <> "Tempo" Then
                        filtro = Me.statusTempoGasto.Text.Substring(Me.statusTempoGasto.Text.IndexOf("[") + 1, _
                                 Me.statusTempoGasto.Text.IndexOf("]") - Me.statusTempoGasto.Text.IndexOf("[") - 1)
                        filtro &= e.ClickedItem.Text.Substring(0, e.ClickedItem.Text.IndexOf("'") + 1)
                    Else
                        filtro = e.ClickedItem.Text.Substring(4, e.ClickedItem.Text.Length - 4)
                        filtro &= e.ClickedItem.Text.Substring(0, e.ClickedItem.Text.IndexOf("'") + 1)

                    End If
                Else
                    filtro = e.ClickedItem.Text.Substring(4, e.ClickedItem.Text.Length - 4)
                End If
                filtro &= filtroValor & "'"
                Filtrar(filtro)

            Case "mnuLiberarFiltro"
                Filtrar("")
            Case "mnuLocalizar"
                Dim filtroValor, filtro As String
                filtro = e.ClickedItem.Text.Substring(11, e.ClickedItem.Text.IndexOf("'") - 14)
                filtroValor = InputBox(filtro, "Digite o valor para Localizar:", "").ToUpper
                If filtroValor <> "" Then
                    dGridCdrs.Rows(dGridCdrs.CurrentCell.RowIndex).Selected = False
                    For i = 0 To Me.dGridCdrs.Rows.Count - 1
                        If dGridCdrs.Item(dGridCdrs.Columns(filtro).Index, i).Value.ToString.ToUpper = filtroValor Then
                            dGridCdrs.Rows(i).Selected = True
                            dGridCdrs.CurrentCell = dGridCdrs(0, i)
                            Exit Sub
                        End If
                    Next
                    MsgBox("Não encontrei: [" & filtroValor & "].")
                End If
            Case "mnuFechar"
                Me.Close()
        End Select
    End Sub
    Private Sub dGridCdrs_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dGridCdrs.EditingControlShowing
        Me.CurEditControl = e.Control
    End Sub
    Private Sub frmConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nomeTabela As String

        corStatusBack = Me.statusTempoGasto.BackColor

        Me.Text = "Pesquisa CDRs - " & frmManutencao.cbBilhetador.Text

        nomeTabela = Me.statusTabela.Text
        Me.WindowState = FormWindowState.Maximized
        If txtSQL.Text = "" Then
            txtSQL.Text = "SELECT CLASSIF ,DATA, HORA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,ICT,CSP, " _
                        & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, OGT, NR_DISCADO, RN2, RN3, CAUSA, CAT, FDS, PT, CL, OCUP_INICIO, OCUP_FIM " _
                        & "FROM " & nomeTabela & " " _
                        & "LEFT JOIN cliente_terminal AS term_A ON " & nomeTabela & ".ASS_A = term_A.TERMINAL " _
                        & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                        & "LEFT JOIN cliente_terminal AS term_B ON " & nomeTabela & ".ASS_B = term_B.TERMINAL " _
                        & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI LIMIT 0;"
            expandableSplitter1.Expanded = True
        Else
            expandableSplitter1.Expanded = False
        End If

        ExecSQL()
        SQL2Filtro()
        nudLimite.Value = 500
        'Open Conn
        'Conn = MySQL_Conn(frmManutencao.cbServidorMySql.Text, frmManutencao.txtBancoMySql.Text, frmManutencao.cbUsuarioMySql.Text, frmManutencao.cbSenhaMySql.Text)

    End Sub

    Private Sub GeraPizza()
        Dim r As Integer

        'Dim IndicadorNomeA(grid.Columns.Count - 4) As String
        Dim IndPorcentual(10) As Double
        Dim IndQuantidade(10) As Integer

        If dGridCdrs.Rows.Count < 1 Or dGridCdrs.ColumnCount < 1 Then
            Exit Sub
        End If
        'zera contadores
        For r = 0 To 9
            IndQuantidade(r) = 0
        Next
        'Calcula Quantidades
        For r = 0 To dGridCdrs.Rows.Count - 1
            Select Case dGridCdrs.Item(dGridCdrs.Columns("CLASSIF").Index, r).Value.ToString.Trim
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
            IndPorcentual(r) = IndQuantidade(r) / dGridCdrs.Rows.Count * 100
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

    Private Function LocalizaLoop(ByVal LinhaInicial As Integer) As Integer
        Dim i, j As Integer
        Dim vASS_B, vASS_A, vDATA As String
        Dim Coincidencias As Integer

        If Me.dGridCdrs.RowCount <= 0 Then Exit Function

        Coincidencias = 0

        vASS_B = Me.dGridCdrs.Item(Me.dGridCdrs.Columns("ASS_B").Index, LinhaInicial).Value
        vASS_A = Me.dGridCdrs.Item(Me.dGridCdrs.Columns("ASS_A").Index, LinhaInicial).Value
        vDATA = Me.dGridCdrs.Item(Me.dGridCdrs.Columns("DATA").Index, LinhaInicial).Value
        For i = LinhaInicial + 1 To Me.dGridCdrs.RowCount - 1
            If vASS_B = Me.dGridCdrs.Item(Me.dGridCdrs.Columns("ASS_B").Index, i).Value And _
                vASS_A = Me.dGridCdrs.Item(Me.dGridCdrs.Columns("ASS_A").Index, i).Value And _
                vDATA = Me.dGridCdrs.Item(Me.dGridCdrs.Columns("DATA").Index, i).Value Then
                Coincidencias += 1
            Else
                vASS_B = Me.dGridCdrs.Item(Me.dGridCdrs.Columns("ASS_B").Index, i).Value
                vASS_A = Me.dGridCdrs.Item(Me.dGridCdrs.Columns("ASS_A").Index, i).Value
                vDATA = Me.dGridCdrs.Item(Me.dGridCdrs.Columns("DATA").Index, i).Value
                Coincidencias = 0
            End If
            If Coincidencias > 2 Then
                For j = i To Me.dGridCdrs.RowCount - 1
                    If vASS_B = Me.dGridCdrs.Item(Me.dGridCdrs.Columns("ASS_B").Index, j).Value And _
                        vASS_A = Me.dGridCdrs.Item(Me.dGridCdrs.Columns("ASS_A").Index, j).Value Then
                        'vDATA = Me.dGridCdrs.Item(Me.dGridCdrs.Columns("DATA").Index, j).Value Then
                        LocalizaLoop = j
                    Else
                        Continue For
                    End If
                Next j

                Dim filtro As String
                filtro = "ASS_B='" & vASS_B & "' AND ASS_A='" & vASS_A & "'"
                Dim dt As DataTable = CType(dGridCdrs.DataSource, DataView).Table
                Dim drc As DataRow() = dt.Select(filtro)
                Dim dv As New DataView(dt)
                dv.RowFilter = filtro

                dGridCdrs.DataSource = dv
                Me.statusRecCount.Text = "Registros: " & dGridCdrs.RowCount
                Me.statusTempoGasto.BackColor = Color.Aqua
                Me.statusTempoGasto.Text = "FILTRADO: [" & filtro & "]"
                StatusStrip1.Refresh()
                Exit Function
            End If
        Next i
        LocalizaLoop = 0
    End Function

    Private Sub btnLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoop.Click
        Dim TeveLoop As Boolean

        ProcessoInicio()
        Me.btnProximoLoop.Enabled = False
        Call btnLimpar_Click(sender, e) 'Limpar campos
        nudLimite.Value = 0
        cbLimite.Checked = True
        ExecSQL()
        dGridCdrs.Refresh()
        nudLimite.Value = 500
        cbCampo1.Text = "CLASSIF"
        cbOperador2.Text = "="
        txtValor1.Text = "DSC"

        InicioLIMIT = 0
        TeveLoop = False
        Do
            cbLimite.Checked = True
            cbLimite.Checked = False 'forcar a retirada da clausula LIMIT
            txtSQL.Text &= " LIMIT " & InicioLIMIT & "," & BLOCO_DE_CDRs
            'Preparar SQL
            ExecSQL()
            If dGridCdrs.RowCount <= 0 Then Continue Do
            LinhaInicialPesquisaLoop = LocalizaLoop(0)
            If LinhaInicialPesquisaLoop <> 0 Then
                Me.btnProximoLoop.Enabled = True
                TeveLoop = True
            Else
                InicioLIMIT += BLOCO_DE_CDRs
            End If
        Loop While (dGridCdrs.RowCount = BLOCO_DE_CDRs)
        If Not TeveLoop Then
            nudLimite.Value = 0
            cbLimite.Checked = True
            ExecSQL()
            MsgBox("Parabéns! Não encontrei indícios de LOOP.")
            nudLimite.Value = 500
        End If
        ProcessoFim()
    End Sub

    Private Sub btnProximoLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProximoLoop.Click

        Dim dt As DataTable = CType(dGridCdrs.DataSource, DataView).Table
        Dim drc As DataRow() = dt.Select("")
        Dim dv As New DataView(dt)
        dv.RowFilter = ""
        ProcessoInicio()
        dGridCdrs.DataSource = dv
        Me.statusRecCount.Text = "Registros: " & dGridCdrs.RowCount
        Me.statusTempoGasto.BackColor = corStatusBack
        Me.statusTempoGasto.Text = ""
        StatusStrip1.Refresh()

        If LinhaInicialPesquisaLoop > 0 Then
            LinhaInicialPesquisaLoop = LocalizaLoop(LinhaInicialPesquisaLoop)
        End If
        If LinhaInicialPesquisaLoop <= 0 Then
            Do
                cbLimite.Checked = True
                cbLimite.Checked = False 'forcar a retirada da clausula LIMIT
                txtSQL.Text &= " LIMIT " & InicioLIMIT & "," & BLOCO_DE_CDRs
                'Preparar SQL
                ExecSQL()
                LinhaInicialPesquisaLoop = 0
                If dGridCdrs.RowCount <= 0 Then Continue Do
                LinhaInicialPesquisaLoop = LocalizaLoop(LinhaInicialPesquisaLoop)
                InicioLIMIT += BLOCO_DE_CDRs
            Loop While (dGridCdrs.RowCount = BLOCO_DE_CDRs)
            If LinhaInicialPesquisaLoop <= 0 Then
                nudLimite.Value = 0
                cbLimite.Checked = True
                ExecSQL()
                MsgBox("Não encontrei mais indícios de LOOP.")
                nudLimite.Value = 500
            End If
        End If
        ProcessoFim()
    End Sub

    Private Sub btnProcessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessar.Click
        Dim i As Integer
        Dim dt1 As Date
        btnProximoLoop.Enabled = False
        tbcGrafico.SelectedIndex = 0
        If nuDias.Value > 1 Then
            ProcessoInicio()
            dt1 = Me.DateTimePicker1.Value
            Try
                'Conn = MySQL_Conn(frmManutencao.cbServidorMySql.Text, frmManutencao.txtBancoMySql.Text, frmManutencao.cbUsuarioMySql.Text, frmManutencao.cbSenhaMySql.Text)
                MySQL_cmd(conn, "DELETE FROM `cdrs_sel`")
                For i = 0 To nuDias.Value - 1
                    MySQL_cmd(conn, txtSQL.Text)
                    Me.DateTimePicker1.Value = Me.DateTimePicker1.Value.AddDays(1)  'incrementa 1 dia
                    Me.statusTabela.Text = "cdrs_" & Format(CDate(DateTimePicker1.Text), "yyyyMMdd")
                    Me.StatusStrip1.Refresh()
                    'Filtro2SQL()
                Next i
            Finally
                Me.DateTimePicker1.Text = dt1
            End Try
            DateTimePicker1.Visible = False
            nuDias.Visible = False
            lblDias.Visible = False
            txtSEL.Visible = True
            cbLimite.Checked = False
            btnSEL.Text = "DIA"
            Filtro2SQL()
            ExecSQL()
            MsgBox("Concluído a seleção de registros.")
            ProcessoFim()
        Else
            ExecSQL()
        End If
    End Sub

    Private Sub btnSEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSEL.Click
        If btnSEL.Text = "SEL" Then
            DateTimePicker1.Visible = False
            nuDias.Visible = False
            lblDias.Visible = False
            txtSEL.Visible = True
            btnSEL.Text = "DIA"
        Else
            DateTimePicker1.Visible = True
            btnSEL.Text = "SEL"
            txtSEL.Visible = False
            nuDias.Visible = True
            lblDias.Visible = True
        End If
        Filtro2SQL()
    End Sub

    Private Sub btnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravar.Click
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

    Private Sub btnCarregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregar.Click
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

    Private Sub tbcGrafico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbcGrafico.SelectedIndexChanged
        If tbcGrafico.SelectedTab.Name <> "tpDiagrama" Then
            Exit Sub
        End If
        If dGridCdrs.Rows.Count < 1 Then Exit Sub

        Dim l, cLO_LCL, cLO_LDN, cLO_SNG, cNR1_LCL, _
            cNR1_LDN, cNR1_SNG, cNR5_LCL, cNR5_LDN, cNR5_SNG, cNR, cPAB, cDSC_XF, cDSC_QF, cDSC_HF, cDSC_OU, cOK, cNOK, cCO, cCO0, _
            cCO1, cCO2, cCO3, cDSC, cLO, cNR1, cNR5, cOK1, cOK5, cOU As Integer
        Dim pCO2_OU, pLO_LCL, pLO_LDN, pLO_SNG, pNR1_LCL, pNR1_LDN, pNR1_SNG, pNR5_LCL, pNR5_LDN, pNR5_SNG, pNR, pPAB, _
            pOK, pNOK, pCO, pOk1, pOk5, pCO0, pCO1, pCO2, pCO3, pDSC, pLO, pNR1, pNR5, pOU As Double

        ProcessoInicio()

        'tvCausas.Nodes.Clear()
        cLO_LCL = 0
        cLO_LDN = 0 : cLO_SNG = 0 : cNR1_LCL = 0 : cNR1_LDN = 0 : cNR1_SNG = 0 : cNR5_LCL = 0
        cNR5_LDN = 0 : cNR1_SNG = 0 : cNR = 0 : cPAB = 0 : cCO = 0 : cCO0 = 0 : cCO1 = 0 : cCO2 = 0 : cCO3 = 0
        cDSC_XF = 0 : cDSC_QF = 0 : cDSC_HF = 0 : cDSC_OU = 0 : cDSC = 0 : cLO = 0 : cNR1 = 0 : cNR5 = 0 : cOK1 = 0 : cOK5 = 0 : cOU = 0

        pCO2_OU = 0 : pLO_LCL = 0 : pLO_LDN = 0
        pLO_SNG = 0 : pNR1_LCL = 0 : pNR1_LDN = 0 : pNR1_SNG = 0 : pNR5_LCL = 0
        pNR5_LDN = 0 : pNR5_SNG = 0 : pNR = 0 : pPAB = 0 : pCO = 0 : pCO0 = 0 : pCO1 = 0 : pCO2 = 0 : pCO3 = 0
        cDSC_XF = 0 : cDSC_QF = 0 : cDSC_HF = 0 : cDSC_OU = 0 : pDSC = 0 : pLO = 0 : pNR1 = 0 : pNR5 = 0 : pOk1 = 0 : pOk5 = 0 : pOU = 0

        For l = 0 To dGridCdrs.Rows.Count - 1

            Select Case dGridCdrs.Rows(l).Cells("CLASSIF").Value
                Case "CO0"
                    cCO0 += 1
                Case "CO1"
                    cCO1 += 1
                Case "CO2"
                    cCO2 += 1
                Case "CO3"
                    cCO3 += 1
                Case "DSC"
                    cDSC += 1
                Case "LO"
                    cLO += 1
                    If dGridCdrs.Rows(l).Cells("CSP").Value = "--" Then
                        If dGridCdrs.Rows(l).Cells("ASS_B").Value.ToString.Substring(0, 2) = "30" Or _
                           dGridCdrs.Rows(l).Cells("ASS_B").Value.ToString.Substring(0, 2) = "50" Or _
                           dGridCdrs.Rows(l).Cells("ASS_B").Value.ToString.Substring(0, 2) = "80" Then
                            cLO_SNG += 1
                        Else
                            cLO_LCL += 1
                        End If
                    Else
                        cLO_LDN += 1
                    End If
                Case "NR1"
                    cNR1 += 1
                    If dGridCdrs.Rows(l).Cells("CSP").Value = "--" Then
                        If dGridCdrs.Rows(l).Cells("ASS_B").Value.ToString.Substring(0, 2) = "30" Or _
                           dGridCdrs.Rows(l).Cells("ASS_B").Value.ToString.Substring(0, 2) = "50" Or _
                           dGridCdrs.Rows(l).Cells("ASS_B").Value.ToString.Substring(0, 2) = "80" Then
                            cNR1_SNG += 1
                        Else
                            cNR1_LCL += 1
                        End If
                    Else
                        cNR1_LDN += 1
                    End If
                Case "NR5"
                    cNR5 += 1
                    If dGridCdrs.Rows(l).Cells("CSP").Value = "--" Then
                        If dGridCdrs.Rows(l).Cells("ASS_B").Value.ToString.Substring(0, 2) = "30" Or _
                           dGridCdrs.Rows(l).Cells("ASS_B").Value.ToString.Substring(0, 2) = "50" Or _
                           dGridCdrs.Rows(l).Cells("ASS_B").Value.ToString.Substring(0, 2) = "80" Then
                            cNR5_SNG += 1
                        Else
                            cNR5_LCL += 1
                        End If
                    Else
                        cNR5_LDN += 1
                    End If
                Case "OK1"
                    cOK1 += 1
                Case "OK5"
                    cOK5 += 1
                Case "OU"
                    cOU += 1
            End Select
        Next
        cOK = cOK1 + cOK5
        pOk1 = cOK1 / (cOK1 + cOK5) * 100
        pOk5 = cOK5 / (cOK1 + cOK5) * 100
        pOK = cOK / dGridCdrs.Rows.Count * 100

        cCO = cCO0 + cCO1 + cCO2 + cCO3
        cNR = cNR1 + cNR5
        cPAB = cNR + cLO
        cNOK = cPAB + cCO + cDSC + cOU

        If cNR > 0 Then pNR1 = cNR1 / cNR * 100
        If cNR1 > 0 Then
            pNR1_LCL = cNR1_LCL / cNR1 * 100
            pNR1_LDN = cNR1_LDN / cNR1 * 100
            pNR1_SNG = cNR1_SNG / cNR1 * 100
        End If
        If cNR > 0 Then pNR5 = cNR5 / cNR * 100
        If cNR5 > 0 Then
            pNR5_LCL = cNR5_LCL / cNR5 * 100
            pNR5_LDN = cNR5_LDN / cNR5 * 100
            pNR5_SNG = cNR5_SNG / cNR5 * 100
        End If
        pNR = cNR / cPAB * 100
        If cLO > 0 Then
            pLO_LCL = cLO_LCL / cLO * 100
            pLO_LDN = cLO_LDN / cLO * 100
            pLO_SNG = cLO_SNG / cLO * 100
        End If
        If cPAB > 0 Then pLO = cLO / cPAB * 100
        If cNOK > 0 Then
            pPAB = cPAB / cNOK * 100
            pCO = cCO / cNOK * 100
            pDSC = cDSC / cNOK * 100
            pOU = cOU / cNOK * 100
        End If
        If cCO > 0 Then
            pCO0 = cCO0 / cCO * 100
            pCO1 = cCO1 / cCO * 100
            pCO2 = cCO2 / cCO * 100
            pCO3 = cCO3 / cCO * 100
        End If

        pNOK = cNOK / dGridCdrs.Rows.Count * 100
        tvCausas.Nodes(0).Expand()
        tvCausas.BeginUpdate()
        tvCausas.Nodes("Todos CDRs").Nodes("OK").Text = String.Format(" OK:{0,6:#,##0;(#,##0);0}", cOK) & String.Format("({0,3:f1}%) ", pOK)
        tvCausas.Nodes("Todos CDRs").Nodes("OK").Nodes("OK1").Text = String.Format("OK1:{0,6:#,##0;(#,##0);0}", cOK1) & String.Format("({0,3:f1}%) ", pOk1)
        tvCausas.Nodes("Todos CDRs").Nodes("OK").Nodes("OK5").Text = String.Format("OK5:{0,6:#,##0;(#,##0);0}", cOK5) & String.Format("({0,3:f1}%) ", pOk5)

        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Text = String.Format("NOK:{0,6:#,##0;(#,##0);0}", cNOK) & String.Format("({0,3:f1}%) ", pNOK)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Text = String.Format("PAB:{0,6:#,##0;(#,##0);0}", cPAB) & String.Format("({0,3:f1}%) ", pPAB)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Nodes("LO").Text = String.Format("LO:{0,6:#,##0;(#,##0);0}", cLO) & String.Format("({0,3:f1}%) ", pLO)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Nodes("LO").Nodes("LCL").Text = String.Format("LCL:{0,6:#,##0;(#,##0);0}", cLO_LCL) & String.Format("({0,3:f1}%) ", pLO_LCL)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Nodes("LO").Nodes("LDN").Text = String.Format("LDN:{0,6:#,##0;(#,##0);0}", cLO_LDN) & String.Format("({0,3:f1}%) ", pLO_LDN)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Nodes("LO").Nodes("SNG").Text = String.Format("SNG:{0,6:#,##0;(#,##0);0}", cLO_SNG) & String.Format("({0,3:f1}%) ", pLO_SNG)

        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Nodes("NR").Text = String.Format("NR:{0,6:#,##0;(#,##0);0}", cNR) & String.Format("({0,3:f1}%) ", pNR)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Nodes("NR").Nodes("NR1").Text = String.Format("NR1:{0,6:#,##0;(#,##0);0}", cNR1) & String.Format("({0,3:f1}%) ", pNR1)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Nodes("NR").Nodes("NR1").Nodes("LCL").Text = String.Format("LCL:{0,6:#,##0;(#,##0);0}", cNR1_LCL) & String.Format("({0,3:f1}%) ", pNR1_LCL)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Nodes("NR").Nodes("NR1").Nodes("LDN").Text = String.Format("LDN:{0,6:#,##0;(#,##0);0}", cNR1_LDN) & String.Format("({0,3:f1}%) ", pNR1_LDN)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Nodes("NR").Nodes("NR1").Nodes("SNG").Text = String.Format("SNG:{0,6:#,##0;(#,##0);0}", cNR1_SNG) & String.Format("({0,3:f1}%) ", pNR1_SNG)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Nodes("NR").Nodes("NR5").Text = String.Format("NR5:{0,6:#,##0;(#,##0);0}", cNR5) & String.Format("({0,3:f1}%) ", pNR5)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Nodes("NR").Nodes("NR5").Nodes("LCL").Text = String.Format("LCL:{0,6:#,##0;(#,##0);0}", cNR5_LCL) & String.Format("({0,3:f1}%) ", pNR5_LCL)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Nodes("NR").Nodes("NR5").Nodes("LDN").Text = String.Format("LDN:{0,6:#,##0;(#,##0);0}", cNR5_LDN) & String.Format("({0,3:f1}%) ", pNR5_LDN)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("PAB").Nodes("NR").Nodes("NR5").Nodes("SNG").Text = String.Format("SNG:{0,6:#,##0;(#,##0);0}", cNR5_SNG) & String.Format("({0,3:f1}%) ", pNR5_SNG)

        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Text = String.Format(" CO:{0,6:#,##0;(#,##0);0}", cCO) & String.Format("({0,3:f1}%) ", pCO)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO0").Text = String.Format("CO0:{0,6:#,##0;(#,##0);0}", cCO0) & String.Format("({0,3:f1}%) ", pCO0)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO1").Text = String.Format("CO1:{0,6:#,##0;(#,##0);0}", cCO1) & String.Format("({0,3:f1}%) ", pCO1)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO2").Text = String.Format("CO2:{0,6:#,##0;(#,##0);0}", cCO2) & String.Format("({0,3:f1}%) ", pCO2)

        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO3").Text = String.Format("CO3:{0,6:#,##0;(#,##0);0}", cCO3) & String.Format("({0,3:f1}%) ", pCO3)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("DSC").Text = String.Format("DSC:{0,6:#,##0;(#,##0);0}", cDSC) & String.Format("({0,3:f1}%) ", pDSC)

        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("OU").Text = String.Format(" OU:{0,6:#,##0;(#,##0);0}", cOU) & String.Format("({0,3:f1}%) ", pOU)

        tvCausas.EndUpdate()
        ProcessoFim()

    End Sub
    Private Sub tvCausas_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvCausas.AfterSelect
        If tvCausas.SelectedNode Is Nothing Then Exit Sub
        Select Case tvCausas.SelectedNode.Name
            Case Is = "Todos CDRs"
                Filtrar("")
            Case Is = "OK"
                Filtrar("CLASSIF='OK1' OR CLASSIF='OK5'")
            Case Is = "OK1"
                Filtrar("CLASSIF='OK1'")
            Case Is = "OK5"
                Filtrar("CLASSIF='OK5'")
            Case Is = "NOK"
                Filtrar("CLASSIF<>'OK1' AND CLASSIF<>'OK5'")
            Case Is = "CO"
                Filtrar("CLASSIF='CO0' OR CLASSIF='CO1' OR CLASSIF='CO2' OR CLASSIF='CO3'")
            Case Is = "CO0"
                Filtrar("CLASSIF='CO0'")
            Case Is = "CO1"
                Filtrar("CLASSIF='CO1'")
            Case Is = "CO2"
                Filtrar("CLASSIF='CO2'")
            Case Is = "CO3"
                Filtrar("CLASSIF='CO3'")
            Case Is = "DSC"
                Filtrar("CLASSIF='DSC'")
            Case Is = "PAB"
                Filtrar("CLASSIF='NR1' OR CLASSIF='NR5' OR CLASSIF='LO'")
            Case Is = "LO"
                Filtrar("CLASSIF='LO'")
            Case Is = "NR1"
                Filtrar("CLASSIF='NR1'")
            Case Is = "NR5"
                Filtrar("CLASSIF='NR5'")
            Case Is = "NR"
                Filtrar("CLASSIF='NR1' OR CLASSIF='NR5'")
            Case Is = "OU"
                If tvCausas.SelectedNode.Level = 2 Then
                    Filtrar("CLASSIF='OU'")
                Else
                    Select Case tvCausas.SelectedNode.Parent.Name
                        Case Is = "CO1"
                            Filtrar("CLASSIF='CO1' AND (Not ROTA_S like '%XF' AND Not ROTA_S like '%QF' AND Not ROTA_S like '%HF')")
                        Case Is = "CO2"
                            Filtrar("CLASSIF='CO2' AND (Not ROTA_S like '%XF' AND Not ROTA_S like '%QF' AND Not ROTA_S like '%HF')")
                        Case Is = "DSC"
                            Filtrar("CLASSIF='DSC' AND (Not ROTA_S like '%XF' AND Not ROTA_S like '%QF' AND Not ROTA_S like '%HF')")
                    End Select
                End If
            Case Is = "XF"
                Select Case tvCausas.SelectedNode.Parent.Name
                    Case Is = "CO1"
                        Filtrar("CLASSIF='CO1' AND ROTA_S like '%XF'")
                    Case Is = "CO2"
                        Filtrar("CLASSIF='CO2' AND ROTA_S like '%XF'")
                    Case Is = "DSC"
                        Filtrar("CLASSIF='DSC' AND ROTA_S like '%XF'")
                End Select
            Case Is = "QF"
                Select Case tvCausas.SelectedNode.Parent.Name
                    Case Is = "CO1"
                        Filtrar("CLASSIF='CO1' AND ROTA_S like '%QF'")
                    Case Is = "CO2"
                        Filtrar("CLASSIF='CO2' AND ROTA_S like '%QF'")
                    Case Is = "DSC"
                        Filtrar("CLASSIF='DSC' AND ROTA_S like '%QF'")
                End Select
            Case Is = "HF"
                Select Case tvCausas.SelectedNode.Parent.Name
                    Case Is = "CO1"
                        Filtrar("CLASSIF='CO1' AND ROTA_S like '%HF'")
                    Case Is = "CO2"
                        Filtrar("CLASSIF='CO2' AND ROTA_S like '%HF'")
                    Case Is = "DSC"
                        Filtrar("CLASSIF='DSC' AND ROTA_S like '%HF'")
                End Select
            Case Is = "LCL"
                Select Case tvCausas.SelectedNode.Parent.Name
                    Case Is = "LO"
                        Filtrar("CLASSIF='LO' AND CSP='--' AND (Not ASS_B like '30%' AND Not ASS_B like '50%' AND Not ASS_B like '80%')")
                    Case Is = "NR1"
                        Filtrar("CLASSIF='NR1' AND CSP='--' AND (Not ASS_B like '30%' AND Not ASS_B like '50%' AND Not ASS_B like '80%')")
                    Case Is = "NR5"
                        Filtrar("CLASSIF='NR5' AND CSP='--' AND (Not ASS_B like '30%' AND Not ASS_B like '50%' AND Not ASS_B like '80%')")
                End Select
            Case Is = "LDN"
                Select Case tvCausas.SelectedNode.Parent.Name
                    Case Is = "LO"
                        Filtrar("CLASSIF='LO' AND CSP <> '--'")
                    Case Is = "NR1"
                        Filtrar("CLASSIF='NR1' AND CSP <> '--'")
                    Case Is = "NR5"
                        Filtrar("CLASSIF='NR5' AND CSP <> '--'")
                End Select
            Case Is = "SNG"
                Select Case tvCausas.SelectedNode.Parent.Name
                    Case Is = "LO"
                        Filtrar("CLASSIF='LO' AND (ASS_B like '30%' OR ASS_B like '50%' OR ASS_B like '80%')")
                    Case Is = "NR1"
                        Filtrar("CLASSIF='NR1' AND (ASS_B like '30%' OR ASS_B like '50%' OR ASS_B like '80%')")
                    Case Is = "NR5"
                        Filtrar("CLASSIF='NR5' AND (ASS_B like '30%' OR ASS_B like '50%' OR ASS_B like '80%')")
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

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        If m_Search Is Nothing OrElse m_Search.IsDisposed Then
            Cursor = Cursors.Default
            m_Search = New BalloonSearch()
            m_Search.Owner = Me
            m_Search.Show(sender, False)
        End If

        'ProcessoInicio()
        'ExportToExcel(dGridCdrs, xlsOption.xlsOpen)
        'ProcessoFim()
    End Sub
End Class
