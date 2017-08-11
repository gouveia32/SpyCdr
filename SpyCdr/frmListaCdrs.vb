Imports Dundas.Charting.WinControl
Imports System.Data
Imports System.IO
Imports System.Threading.Thread
Imports System.Globalization

Public Class frmListaCdrs

    Dim IndicadorNome() As String = {"CO0", "CO1", "CO2", "CO3", "DSC", "LO", "NR1", "NR5", "OK1", "OK5", "OU"}
    Dim Operadores() As String = {"=", "<>", ">", ">=", "<", "<=", "LIKE", "NOT LIKE"}
    Dim Campos() As String = {"CLASSIF", "DATA", "DURACAO", "ASS_A", "cli_A.CLIENTE", "R_ENT", "_exrop_E.ROTA", _
                              "J_ENT", "CSP", "ASS_B", "cli_B.CLIENTE", "R_SAI", "_exrop_S.ROTA", "J_SAI", _
                              "NR_DISCADO", "RN2", "RN3", "EOS", "CAT", "FDS", "PT", "ECH", "DUR_RING", "DUR_TOTAL"}

    Private m_Search As BalloonSearch

    Dim tCol As DataColumn
    Dim corStatusBack As Color
    Dim LinhaInicialPesquisaLoop, InicioLIMIT As Integer
    Dim flagAtualizaSQL As Boolean = False

    'Declare a variable to hold the last accessed edit control
    Private CurEditControl As Control
    Const BLOCO_DE_CDRs = 5000
    Dim horaI, horaF As DateTime

    Dim dt As New DataTable("cdrs_sel")
    Private Sub ProcessoInicio()
        horaI = Now
        statusRecCount.Visible = False
        statusTempoGasto.Visible = False
        ToolStripProgressBar1.Style = ProgressBarStyle.Marquee
        ToolStripProgressBar1.Visible = True
        'btnCancelar.Visible = True
        If dt.Rows.Count > 0 Then
            dt.Rows.Clear()
            dGridCdrs.Columns.Clear()
            dGridCdrs.DataSource = Nothing
        End If
        Cursor = Cursors.WaitCursor
    End Sub

    Private Sub ProcessoFim()
        WindowState = FormWindowState.Maximized
        horaF = Now
        statusRecCount.Text = "Registros: " & dGridCdrs.RowCount
        If dGridCdrs.RowCount < 1 And InStr(txtSQL.Text, "LIMIT 0") < 1 Then MsgBox("Nenhum registro foi encontrado!")
        statusTempoGasto.Text = "Tempo: " & Format((horaF - horaI).TotalSeconds, "####") & " segundos  "
        statusRecCount.Visible = True
        statusTempoGasto.Visible = True
        Cursor = Cursors.Default
    End Sub

    Private Sub FormataGrid()

        'formata as colunas de dGrid
        With dGridCdrs
            .Font = New Font("Tahoma", 7.0!, FontStyle.Regular)
            '0        1     2        3      4              5      6              7      8    9      10             11     12            13     14   15   16   17  18   19        20  
            'CLASSIF, Data, DURACAO, ASS_A, cli_A.CLIENTE, R_ENT, _exrop_E.ROTA, J_ENT, CSP, ASS_B, cli_B.CLIENTE, R_SAI, _exrop_S.ROTA,J_SAI, EOS, CAT, FDS, PT, ECH, DUR_RING, DUR_TOTAL 
            .Columns(0).Width = 35  'CLASSIF
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(1).Width = 95  'DATA
            .Columns(1).DefaultCellStyle.BackColor = Color.LightYellow
            .Columns(1).DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"
            .Columns(2).Width = 50  'DUR
            .Columns(2).DefaultCellStyle.BackColor = Color.LightYellow
            .Columns(3).Width = 65  'Ass-A
            .Columns(3).DefaultCellStyle.BackColor = Color.LightBlue
            .Columns(4).Width = 85  'Cliente
            .Columns(4).DefaultCellStyle.BackColor = Color.LightBlue
            .Columns(5).Width = 30  'R_ENT
            .Columns(5).DefaultCellStyle.BackColor = Color.LightBlue
            .Columns(6).Width = 55  'ROTA
            .Columns(6).DefaultCellStyle.BackColor = Color.LightBlue
            .Columns(7).Width = 35  'J_ENT
            .Columns(7).DefaultCellStyle.BackColor = Color.LightBlue
            .Columns(8).Width = 25  'CSP
            .Columns(8).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(9).Width = 65  'ASS_B
            .Columns(9).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(10).Width = 85  'CLIENTE
            .Columns(10).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(11).Width = 30  'R_SAI
            .Columns(11).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(12).Width = 55  'ROTA
            .Columns(12).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(13).Width = 35 'J_SAI
            .Columns(13).DefaultCellStyle.BackColor = Color.PaleGreen

            .Columns(14).Width = 80 'NR_DISCADO
            .Columns(14).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(15).Width = 45 'RN2
            .Columns(15).DefaultCellStyle.BackColor = Color.PaleGreen
            .Columns(16).Width = 25 'RN3
            .Columns(16).DefaultCellStyle.BackColor = Color.PaleGreen

            .Columns(17).Width = 30 'EOS
            .Columns(18).Width = 25 'CAT
            .Columns(19).Width = 25 'FDS
            .Columns(20).Width = 25 'PT
            .Columns(21).Width = 25 'ECH
            .Columns(22).Width = 50 'DUR_RING
            .Columns(22).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(23).Width = 50 'DUR_TOTAL
            .Columns(23).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End With
    End Sub

    Private Sub ExecSQL()

        Try
            dt = MySQL_Select(Conn, txtSQL.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Cursor.Current = System.Windows.Forms.Cursors.Default
            BackgroundWorker1.Dispose()
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
        Else
            Return ""
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

        flagAtualizaSQL = False

        If DateTimePicker1.Text = "" Then Exit Sub
        'btnProximoLoop.Enabled = False

        btnProxLoop.Enabled = False
        If txtSEL.Visible Then
            nomeTabela = "cdrs_SEL"
        Else
            nomeTabela = "cdrs_" & Format(CDate(DateTimePicker1.Value), "yyyyMMdd")
        End If
        If nuDias.Value > 1 And nuDias.Visible Then
            strSELECT = "SELECT CLASSIF, ASS_A, CSP, ASS_B, CAT, FDS, EOS, PT, ECH, J_ENT, J_SAI, R_ENT, R_SAI, DATA, DUR_RING, DURACAO, DUR_TOTAL, TTFILE, NR_DISCADO,RN2,RN3 "
        Else
            strSELECT = "SELECT CLASSIF ,DATA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,_exrop_E.ROTA AS ROTA_E,J_ENT,CSP, " _
                        & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, _exrop_S.ROTA AS ROTA_S,J_SAI, NR_DISCADO, RN2, RN3, EOS, CAT, FDS, PT, ECH, DUR_RING, DUR_TOTAL "
        End If

        strFROM = "FROM " & nomeTabela & " LEFT JOIN _exrop AS _exrop_E ON " & nomeTabela & ".R_ENT = _exrop_E.RIN " _
            & "LEFT JOIN _exrop AS _exrop_S ON " & nomeTabela & ".R_SAI = _exrop_S.RIN  " _
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

        flagAtualizaSQL = True

    End Sub
    Private Sub _TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor5.TextChanged, txtValor4.TextChanged, txtValor3.TextChanged, txtValor2.TextChanged, txtValor1.TextChanged, txtSEL.TextChanged, nudLimite.ValueChanged, nuDias.ValueChanged, DateTimePicker1.ValueChanged, cbParenteseF5.CheckedChanged, cbParenteseF4.CheckedChanged, cbParenteseF3.CheckedChanged, cbParenteseF2.CheckedChanged, cbParenteseF1.CheckedChanged, cbParenteseA5.CheckedChanged, cbParenteseA4.CheckedChanged, cbParenteseA3.CheckedChanged, cbParenteseA2.CheckedChanged, cbParenteseA1.CheckedChanged, cbOrdenar.SelectedIndexChanged, cbOperador5.SelectedIndexChanged, cbOperador4.SelectedIndexChanged, cbOperador3.SelectedIndexChanged, cbOperador2.SelectedIndexChanged, cbOperador1.SelectedIndexChanged, cbLimite.CheckedChanged, cbConector4.SelectedIndexChanged, cbConector3.SelectedIndexChanged, cbConector2.SelectedIndexChanged, cbConector1.SelectedIndexChanged, cbCampo5.SelectedIndexChanged, cbCampo4.SelectedIndexChanged, cbCampo3.SelectedIndexChanged, cbCampo2.SelectedIndexChanged, cbCampo1.SelectedIndexChanged
        If flagAtualizaSQL Then
            Filtro2SQL()
        End If
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
        cbLimite.Checked = True
        btnProxLoop.Enabled = False
    End Sub
    Private Sub dGridCdrs_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGridCdrs.CellDoubleClick
        If Me.cbCampo1.Text = "" Then
            Me.cbCampo1.Text = dGridCdrs.Columns(e.ColumnIndex).Name.ToString()
            Me.txtValor1.Text = dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString()
        ElseIf Me.cbCampo2.Text = "" Then
            Me.cbCampo2.Text = dGridCdrs.Columns(e.ColumnIndex).Name.ToString()
            Me.txtValor2.Text = dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString()
            Me.cbConector1.Text = "E"
        ElseIf Me.cbCampo3.Text = "" Then
            Me.cbCampo3.Text = dGridCdrs.Columns(e.ColumnIndex).Name.ToString()
            Me.txtValor3.Text = dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString()
            Me.cbConector2.Text = "E"
        ElseIf Me.cbCampo4.Text = "" Then
            Me.cbCampo4.Text = dGridCdrs.Columns(e.ColumnIndex).Name.ToString()
            Me.txtValor4.Text = dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString()
            Me.cbConector3.Text = "E"
        Else
            Me.cbCampo5.Text = dGridCdrs.Columns(e.ColumnIndex).Name.ToString()
            Me.txtValor5.Text = dGridCdrs.Item(e.ColumnIndex, e.RowIndex).Value.ToString()
            Me.cbConector4.Text = "E"
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

        If Me.cbCampo1.Text = "DATA" Then Me.txtValor1.Text = Format(CDate(Me.txtValor1.Text), "yyyy-MM-dd HH:mm:ss")
        If Me.cbCampo2.Text = "DATA" Then Me.txtValor2.Text = Format(CDate(Me.txtValor2.Text), "yyyy-MM-dd HH:mm:ss")
        If Me.cbCampo3.Text = "DATA" Then Me.txtValor3.Text = Format(CDate(Me.txtValor3.Text), "yyyy-MM-dd HH:mm:ss")
        If Me.cbCampo4.Text = "DATA" Then Me.txtValor4.Text = Format(CDate(Me.txtValor4.Text), "yyyy-MM-dd HH:mm:ss")
        If Me.cbCampo5.Text = "DATA" Then Me.txtValor5.Text = Format(CDate(Me.txtValor5.Text), "yyyy-MM-dd HH:mm:ss")

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

        Me.ContextMenuStrip1.Items.Add("-")
        Me.ContextMenuStrip1.Items(19).Name = "mnuSeparador4"
        Me.ContextMenuStrip1.Items.Add("Cáculo de Tráfego")
        Me.ContextMenuStrip1.Items(20).Name = "mnuCalcutraTrafego"
        'Me.ContextMenuStrip1.Items(20).Image = My.Resources.eraser

        Me.ContextMenuStrip1.Items.Add("Fechar")
        Me.ContextMenuStrip1.Items(21).Name = "mnuFechar"
        Me.ContextMenuStrip1.Items(21).Image = My.Resources._EXIT
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
        ContextMenuStrip1.Close()
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
            Case "mnuCalcutraTrafego"
                CalculaTrafego()
            Case "mnuFechar"
                ContextMenuStrip1.Close()
        End Select
    End Sub
    Private Sub dGridCdrs_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dGridCdrs.EditingControlShowing
        Me.CurEditControl = e.Control
    End Sub
    Private Sub frmConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim nomeTabela As String

        corStatusBack = Me.statusTempoGasto.BackColor

        Me.Text = "Pesquisa CDRs - " & frmManutencao.cbBilhetador.Text

        If Not My.Settings.strSQL Is Nothing Then
            'SplitContainer1.SplitterDistance = 0
            expandableSplitterSuperior.Expanded = False
            txtSQL.Text = My.Settings.strSQL
            nomeTabela = My.Settings.strTABELA

            SQL2Filtro()
            flagAtualizaSQL = True
            btnProcessar_Click(sender, e)
            Exit Sub
        End If

        flagAtualizaSQL = True

        nomeTabela = Me.statusTabela.Text
        Me.WindowState = FormWindowState.Maximized
        If txtSQL.Text = "" Then
            txtSQL.Text = "SELECT CLASSIF ,DATA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,_exrop_E.ROTA AS ROTA_E,J_ENT,CSP, " _
                        & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, _exrop_S.ROTA AS ROTA_S,J_SAI, NR_DISCADO, RN2, RN3, EOS, CAT, FDS, PT, ECH, DUR_RING, DUR_TOTAL " _
                        & "FROM " & nomeTabela & " LEFT JOIN _exrop AS _exrop_E ON " & nomeTabela & ".R_ENT = _exrop_E.RIN " _
                        & "LEFT JOIN _exrop AS _exrop_S ON " & nomeTabela & ".R_SAI = _exrop_S.RIN  " _
                        & "LEFT JOIN cliente_terminal AS term_A ON " & nomeTabela & ".ASS_A = term_A.TERMINAL " _
                        & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                        & "LEFT JOIN cliente_terminal AS term_B ON " & nomeTabela & ".ASS_B = term_B.TERMINAL " _
                        & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI LIMIT 0;"
            'SplitContainer1.SplitterDistance = 140
            expandableSplitterSuperior.Expanded = True
        Else
            'SplitContainer1.SplitterDistance = 0
            expandableSplitterSuperior.Expanded = False
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
            If Not dGridCdrs.Item(dGridCdrs.Columns("CLASSIF").Index, r).Value Is Nothing Then
                Select Case dGridCdrs.Item(dGridCdrs.Columns("CLASSIF").Index, r).Value.ToString
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
            End If
        Next r
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

    Private Sub ExecSQLf()

        Try
            Dim dt As New DataTable

            dt = MySQL_Select(Conn, txtSQL.Text)
            dGridCdrs.DataSource = dt.DefaultView
            '---fecha a Conn---
            Conn.Close()
            'Chart1.DataSource = ds
            FormataGrid()
            GeraPizza()

        Catch ex As Exception
            'MsgBox(ex.Message)
        End Try
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

        Dim l, cCO1_XF, cCO1_QF, cCO1_HF, cCO1_OU, cCO2_XF, cCO2_QF, cCO2_HF, cCO2_OU, cLO_LCL, cLO_LDN, cLO_SNG, cNR1_LCL, _
            cNR1_LDN, cNR1_SNG, cNR5_LCL, cNR5_LDN, cNR5_SNG, cNR, cPAB, cDSC_XF, cDSC_QF, cDSC_HF, cDSC_OU, cOK, cNOK, cCO, cCO0, _
            cCO1, cCO2, cCO3, cDSC, cLO, cNR1, cNR5, cOK1, cOK5, cOU As Integer
        Dim pCO1_XF, pCO1_QF, pCO1_HF, pCO1_OU, pCO2_XF, pCO2_QF, pCO2_HF, pCO2_OU, pLO_LCL, pLO_LDN, pLO_SNG, pNR1_LCL, pNR1_LDN, pNR1_SNG, pNR5_LCL, pNR5_LDN, pNR5_SNG, pNR, pPAB, _
            pDSC_XF, pDSC_QF, pDSC_HF, pDSC_OU, pOK, pNOK, pCO, pOk1, pOk5, pCO0, pCO1, pCO2, pCO3, pDSC, pLO, pNR1, pNR5, pOU As Double

        'ProcessoInicio()

        'tvCausas.Nodes.Clear()
        cCO1_XF = 0 : cCO1_QF = 0 : cCO1_HF = 0 : cCO1_OU = 0 : cCO2_XF = 0 : cCO2_QF = 0 : cCO2_HF = 0 : cCO2_OU = 0 : cLO_LCL = 0
        cLO_LDN = 0 : cLO_SNG = 0 : cNR1_LCL = 0 : cNR1_LDN = 0 : cNR1_SNG = 0 : cNR5_LCL = 0
        cNR5_LDN = 0 : cNR1_SNG = 0 : cNR = 0 : cPAB = 0 : cCO = 0 : cCO0 = 0 : cCO1 = 0 : cCO2 = 0 : cCO3 = 0
        cDSC_XF = 0 : cDSC_QF = 0 : cDSC_HF = 0 : cDSC_OU = 0 : cDSC = 0 : cLO = 0 : cNR1 = 0 : cNR5 = 0 : cOK1 = 0 : cOK5 = 0 : cOU = 0

        pCO1_XF = 0 : pCO1_QF = 0 : pCO1_HF = 0 : pCO1_OU = 0 : pCO2_XF = 0 : pCO2_QF = 0 : pCO2_HF = 0 : pCO2_OU = 0 : pLO_LCL = 0 : pLO_LDN = 0
        pLO_SNG = 0 : pNR1_LCL = 0 : pNR1_LDN = 0 : pNR1_SNG = 0 : pNR5_LCL = 0
        pNR5_LDN = 0 : pNR5_SNG = 0 : pNR = 0 : pPAB = 0 : pCO = 0 : pCO0 = 0 : pCO1 = 0 : pCO2 = 0 : pCO3 = 0
        cDSC_XF = 0 : cDSC_QF = 0 : cDSC_HF = 0 : cDSC_OU = 0 : pDSC = 0 : pLO = 0 : pNR1 = 0 : pNR5 = 0 : pOk1 = 0 : pOk5 = 0 : pOU = 0

        For l = 0 To dGridCdrs.Rows.Count - 1
            Dim tmp As String
            If dGridCdrs.Rows(l).Cells("ROTA_S").Value.ToString = "" Then
                tmp = ""
            Else
                tmp = dGridCdrs.Rows(l).Cells("ROTA_S").Value.ToString.Substring(dGridCdrs.Rows(l).Cells("ROTA_S").Value.ToString.Length - 2, 2)
            End If

            Select Case dGridCdrs.Rows(l).Cells("CLASSIF").Value
                Case "CO0"
                    cCO0 += 1
                Case "CO1"
                    cCO1 += 1
                    Select Case tmp
                        Case "XF"
                            cCO1_XF += 1
                        Case "QF"
                            cCO1_QF += 1
                        Case "HF"
                            cCO1_HF += 1
                        Case Else
                            cCO1_OU += 1
                    End Select
                Case "CO2"
                    cCO2 += 1
                    Select Case tmp
                        Case "XF"
                            cCO2_XF += 1
                        Case "QF"
                            cCO2_QF += 1
                        Case "HF"
                            cCO2_HF += 1
                        Case Else
                            cCO2_OU += 1
                    End Select
                Case "CO3"
                    cCO3 += 1
                Case "DSC"
                    cDSC += 1
                    Select Case tmp
                        Case "XF"
                            cDSC_XF += 1
                        Case "QF"
                            cDSC_QF += 1
                        Case "HF"
                            cDSC_HF += 1
                        Case Else
                            cDSC_OU += 1
                    End Select

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
        If cCO1 > 0 Then
            pCO1_XF = cCO1_XF / cCO1 * 100
            pCO1_QF = cCO1_QF / cCO1 * 100
            pCO1_HF = cCO1_HF / cCO1 * 100
            pCO1_OU = cCO1_OU / cCO1 * 100
        End If
        If cCO2 > 0 Then
            pCO2_XF = cCO2_XF / cCO2 * 100
            pCO2_QF = cCO2_QF / cCO2 * 100
            pCO2_HF = cCO2_HF / cCO2 * 100
            pCO2_OU = cCO2_OU / cCO2 * 100
        End If

        If cDSC > 0 Then
            pDSC_XF = cDSC_XF / cDSC * 100
            pDSC_QF = cDSC_QF / cDSC * 100
            pDSC_HF = cDSC_HF / cDSC * 100
            pDSC_OU = cDSC_OU / cDSC * 100
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
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO1").Nodes("XF").Text = String.Format("XF:{0,6:#,##0;(#,##0);0}", cCO1_XF) & String.Format("({0,3:f1}%) ", pCO1_XF)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO1").Nodes("QF").Text = String.Format("QF:{0,6:#,##0;(#,##0);0}", cCO1_QF) & String.Format("({0,3:f1}%) ", pCO1_QF)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO1").Nodes("HF").Text = String.Format("HF:{0,6:#,##0;(#,##0);0}", cCO1_HF) & String.Format("({0,3:f1}%) ", pCO1_HF)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO1").Nodes("OU").Text = String.Format("OU:{0,6:#,##0;(#,##0);0}", cCO1_OU) & String.Format("({0,3:f1}%) ", pCO1_OU)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO2").Text = String.Format("CO2:{0,6:#,##0;(#,##0);0}", cCO2) & String.Format("({0,3:f1}%) ", pCO2)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO2").Nodes("XF").Text = String.Format("XF:{0,6:#,##0;(#,##0);0}", cCO2_XF) & String.Format("({0,3:f1}%) ", pCO2_XF)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO2").Nodes("QF").Text = String.Format("QF:{0,6:#,##0;(#,##0);0}", cCO2_QF) & String.Format("({0,3:f1}%) ", pCO2_QF)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO2").Nodes("HF").Text = String.Format("HF:{0,6:#,##0;(#,##0);0}", cCO2_HF) & String.Format("({0,3:f1}%) ", pCO2_HF)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO2").Nodes("OU").Text = String.Format("OU:{0,6:#,##0;(#,##0);0}", cCO2_OU) & String.Format("({0,3:f1}%) ", pCO2_OU)

        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("CO").Nodes("CO3").Text = String.Format("CO3:{0,6:#,##0;(#,##0);0}", cCO3) & String.Format("({0,3:f1}%) ", pCO3)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("DSC").Text = String.Format("DSC:{0,6:#,##0;(#,##0);0}", cDSC) & String.Format("({0,3:f1}%) ", pDSC)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("DSC").Nodes("XF").Text = String.Format("XF:{0,6:#,##0;(#,##0);0}", cDSC_XF) & String.Format("({0,3:f1}%) ", pDSC_XF)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("DSC").Nodes("QF").Text = String.Format("QF:{0,6:#,##0;(#,##0);0}", cDSC_QF) & String.Format("({0,3:f1}%) ", pDSC_QF)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("DSC").Nodes("HF").Text = String.Format("HF:{0,6:#,##0;(#,##0);0}", cDSC_HF) & String.Format("({0,3:f1}%) ", pDSC_HF)
        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("DSC").Nodes("OU").Text = String.Format("OU:{0,6:#,##0;(#,##0);0}", cDSC_OU) & String.Format("({0,3:f1}%) ", pDSC_OU)

        tvCausas.Nodes("Todos CDRs").Nodes("NOK").Nodes("OU").Text = String.Format(" OU:{0,6:#,##0;(#,##0);0}", cOU) & String.Format("({0,3:f1}%) ", pOU)

        tvCausas.EndUpdate()
        'ProcessoFim()

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

    Private Sub expandableSplitter1_ExpandedChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.ExpandedChangeEventArgs)
        Dim i As Integer

        i = SplitContainer2.SplitterDistance
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            statusRecCount.Text = "Preenchendo Grade..."
            Me.StatusStrip1.Refresh()
            dGridCdrs.DataSource = dt.DefaultView
            FormataGrid()
            GeraPizza()
            ProcessoFim()
            ToolStripProgressBar1.Visible = False
            'btnCancelar.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            ExecSQL()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub btnProcessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessar.Click
        Dim i As Integer
        Dim dt1 As Date
        tbcGrafico.SelectedIndex = 0
        If nuDias.Value > 1 Then
            ProcessoInicio()
            dt1 = Me.DateTimePicker1.Value
            Try
                MySQL_cmd(Conn, "DELETE FROM `cdrs_sel`")
                For i = 0 To nuDias.Value - 1
                    statusRecCount.Text = "Selecionando em: " & Me.DateTimePicker1.Value.ToShortTimeString
                    MySQL_cmd(Conn, txtSQL.Text)
                    Me.DateTimePicker1.Value = Me.DateTimePicker1.Value.AddDays(1)  'incrementa 1 dia
                    Me.statusTabela.Text = "cdrs_" & Format(CDate(DateTimePicker1.Text), "yyyyMMdd")
                    Me.StatusStrip1.Refresh()
                    'Filtro2SQL()
                Next i
            Finally
                DateTimePicker1.Text = dt1
            End Try
            DateTimePicker1.Visible = False
            nuDias.Visible = False
            lblDias.Visible = False
            txtSEL.Visible = True
            cbLimite.Checked = False
            btnSEL.Text = "DIA"
            txtSQL.Text = "SELECT CLASSIF ,DATA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,_exrop_E.ROTA AS ROTA_E,J_ENT,CSP, " _
            & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, _exrop_S.ROTA AS ROTA_S,J_SAI, NR_DISCADO, RN2, RN3, EOS, CAT, FDS, PT, ECH, DUR_RING, DUR_TOTAL " _
            & "FROM CDRs_Sel LEFT JOIN _exrop AS _exrop_E ON CDRs_Sel.R_ENT = _exrop_E.RIN " _
            & "LEFT JOIN _exrop AS _exrop_S ON CDRs_Sel.R_SAI = _exrop_S.RIN  " _
            & "LEFT JOIN cliente_terminal AS term_A ON CDRs_Sel.ASS_A = term_A.TERMINAL " _
            & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
            & "LEFT JOIN cliente_terminal AS term_B ON CDRs_Sel.ASS_B = term_B.TERMINAL " _
            & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI;"
            Try
                ProcessoInicio()
                statusRecCount.Text = "Executando Query..."
                statusRecCount.Visible = True
                BackgroundWorker1.RunWorkerAsync()
            Catch ex As Exception
                ToolStripProgressBar1.Visible = False
                'btnCancelar.Visible = False
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                ProcessoInicio()
                statusRecCount.Text = "Executando Query..."
                statusRecCount.Visible = True
                BackgroundWorker1.RunWorkerAsync()
            Catch ex As Exception
                ToolStripProgressBar1.Visible = False
                'btnCancelar.Visible = False
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Private Sub ExecuteWordpad(ByVal arquivo As String)
        Dim myProcess As Process = New Process()
        myProcess.StartInfo.FileName = "notepad"
        myProcess.StartInfo.Arguments = arquivo
        myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        myProcess.EnableRaisingEvents = True
        myProcess.Start()
    End Sub

    Public Sub ExportaCSV(ByVal nomeArquivo As String, ByVal AbreNoNotepad As Boolean)
        'define as variáveis usadas no projeto
        Dim I As Integer = 0
        Dim j As Integer = 0
        Dim valorCelula As String = ""
        Dim linha As String = ""

        'verifica se o arquivo existe e exclui o arquivo ja existente
        Try
            If File.Exists(nomeArquivo) = True Then
                File.Delete(nomeArquivo)
                'MsgBox("Arquivo " & nomeArquivo & " excluido...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'define um objeto do tipo StreamWriter
        Try
            Dim objWriter As New StreamWriter(nomeArquivo, True)

            'Monta cabecalho
            linha = ""
            For I = 0 To (dGridCdrs.Columns.Count - 1)
                valorCelula = dGridCdrs.Columns(I).Name
                linha = linha + valorCelula + ","
            Next
            'escreve a linha no arquivo 
            objWriter.WriteLine(linha)
            linha = ""
            'percorre o datagridview obtendo o valor de cada célula e montando a linha 
            For j = 0 To (dGridCdrs.Rows.Count - 1)
                For I = 0 To (dGridCdrs.Columns.Count - 1)
                    If Not dGridCdrs.Rows(j).Cells(I).Value Is DBNull.Value Then
                        If Not dGridCdrs.Rows(j).Cells(I).Value Is DBNull.Value Then
                            If dGridCdrs.Columns(I).Name = "DATA" Then
                                valorCelula = Format(dGridCdrs.Item(I, j).Value, "yyyy-MM-dd HH:mm:ss")
                            Else
                                valorCelula = dGridCdrs.Item(I, j).Value
                            End If
                        End If
                    Else
                        valorCelula = ""
                    End If

                    linha = linha + valorCelula + ","
                Next I
                'escreve a linha no arquivo 
                objWriter.WriteLine(linha)
                linha = ""
            Next j
            'fecha o arquivo texto
            objWriter.Close()
            If AbreNoNotepad Then
                ExecuteWordpad(nomeArquivo)
            Else
                MsgBox("O arquivo [" & nomeArquivo & "] em texto foi gerado com sucesso. ")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro durante a escrita no arquivo.  " + ex.ToString())
        Finally
            'fecha o arquivo
            FileClose(1)
            m_Search.Close()
            Cursor = Cursors.Default
        End Try

    End Sub

    Public Sub ExportaTXT(ByVal nomeArquivo As String, ByVal AbreNoNotepad As Boolean)
        'define as variáveis usadas no projeto
        Dim I As Integer = 0
        Dim j As Integer = 0
        Dim valorCelula As String = ""
        Dim linha As String = ""

        'verifica se o arquivo existe e exclui o arquivo ja existente
        Try
            If File.Exists(nomeArquivo) = True Then
                File.Delete(nomeArquivo)
                'MsgBox("Arquivo " & nomeArquivo & " excluido...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

        'define um objeto do tipo StreamWriter
        Try
            Dim objWriter As New StreamWriter(nomeArquivo, True)

            'Monta cabecalho
            linha = ""
            For I = 0 To (dGridCdrs.Columns.Count - 1)
                valorCelula = dGridCdrs.Columns(I).Name
                linha &= valorCelula + Chr(9)
                If dGridCdrs.Columns(I).Name = "DATA" Then
                    linha &= Space(15)
                End If
                'linha = linha + valorCelula + " "
            Next
            'escreve a linha no arquivo 
            objWriter.WriteLine(linha)
            linha = ""
            'percorre o datagridview obtendo o valor de cada célula e montando a linha 
            For j = 0 To (dGridCdrs.Rows.Count - 1)
                For I = 0 To (dGridCdrs.Columns.Count - 1)
                    If Not dGridCdrs.Rows(j).Cells(I).Value Is DBNull.Value Then
                        If Not dGridCdrs.Rows(j).Cells(I).Value Is DBNull.Value Then
                            If dGridCdrs.Columns(I).Name = "DATA" Then
                                valorCelula = Format(dGridCdrs.Item(I, j).Value, "yyyy-MM-dd HH:mm:ss")
                            Else
                                valorCelula = dGridCdrs.Item(I, j).Value
                            End If
                        End If
                    Else
                        valorCelula = ""
                    End If

                    linha = linha + valorCelula + Chr(9)
                    'linha = linha + valorCelula + " "
                Next I
                'escreve a linha no arquivo 
                objWriter.WriteLine(linha)
                linha = ""
            Next j
            'fecha o arquivo texto
            objWriter.Close()
            If AbreNoNotepad Then
                ExecuteWordpad(nomeArquivo)
            Else
                MsgBox("O arquivo [" & nomeArquivo & "] em texto foi gerado com sucesso. ")
            End If
        Catch ex As Exception
            MessageBox.Show("Ocorreu um erro durante a escrita no arquivo.  " + ex.ToString())
        Finally
            'fecha o arquivo
            FileClose(1)
            m_Search.Close()
            Cursor = Cursors.Default
        End Try

    End Sub
    Private Sub CloseSearch()
        If (Not m_Search Is Nothing) Then
            m_Search.Close()
            'm_Search.Dispose()
            'm_Search = Nothing
            Cursor = Cursors.Default
        End If
    End Sub

    Private Sub frmListaCdrs_Move(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Move
        CloseSearch()
    End Sub

    Private Sub btnExportar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        If m_Search Is Nothing OrElse m_Search.IsDisposed Then
            Cursor = Cursors.Default
            m_Search = New BalloonSearch()
            m_Search.Owner = Me
            m_Search.Show(sender, False)
        End If
    End Sub

    Private Function LocalizaLoop(ByVal LinhaInicial As Integer) As Integer
        Dim i, j, c As Integer
        Dim vASS_B, vASS_A, vDATA As String
        Dim Coincidencias As Integer

        If dt.Rows.Count <= 0 Then Exit Function

        Coincidencias = 0

        vASS_B = dt.Rows(LinhaInicial).Item("ASS_B").ToString
        vASS_A = dt.Rows(LinhaInicial).Item("ASS_A").ToString
        vDATA = dt.Rows(LinhaInicial).Item("DATA").ToString
        statusRecCount.Text = "Procurando Loop a partir do registro " & InicioLIMIT + LinhaInicial
        StatusStrip1.Refresh()
        For i = LinhaInicial + 1 To Me.dt.Rows.Count - 1
            If vASS_B = dt.Rows(i).Item("ASS_B").ToString And _
                vASS_A = dt.Rows(i).Item("ASS_A").ToString And _
                vDATA = dt.Rows(i).Item("DATA").ToString Then
                Coincidencias += 1
            Else
                vASS_B = dt.Rows(i).Item("ASS_B").ToString
                vASS_A = dt.Rows(i).Item("ASS_A").ToString
                vDATA = dt.Rows(i).Item("DATA").ToString
                Coincidencias = 0
            End If
            If Coincidencias > 2 Then  'possivel loop encontrado
                dGridCdrs.Columns.Clear()
                dGridCdrs.DataSource = Nothing
                dGridCdrs.Columns.Add("CLASSIF", "CLASSIF")
                dGridCdrs.Columns.Add("DATA", "DATA")
                dGridCdrs.Columns.Add("DURACAO", "DURACAO")
                dGridCdrs.Columns.Add("ASS_A", "ASS_A")
                dGridCdrs.Columns.Add("CLIENTE_A", "CLIENTE_A")
                dGridCdrs.Columns.Add("R_ENT", "R_ENT")
                dGridCdrs.Columns.Add("ROTA_E", "ROTA_E")
                dGridCdrs.Columns.Add("J_ENT", "J_ENT")
                dGridCdrs.Columns.Add("CSP", "CSP")
                dGridCdrs.Columns.Add("ASS_B", "ASS_B")
                dGridCdrs.Columns.Add("CLIENTE_B", "CLIENTE_B")
                dGridCdrs.Columns.Add("R_SAI", "R_SAI")
                dGridCdrs.Columns.Add("ROTA_S", "ROTA_S")
                dGridCdrs.Columns.Add("J_SAI", "J_SAI")
                dGridCdrs.Columns.Add("NR_DISCADO", "NR_DISCADO")
                dGridCdrs.Columns.Add("RN2", "RN2")
                dGridCdrs.Columns.Add("RN3", "RN3")
                dGridCdrs.Columns.Add("EOS", "EOS")
                dGridCdrs.Columns.Add("CAT", "CAT")
                dGridCdrs.Columns.Add("FDS", "FDS")
                dGridCdrs.Columns.Add("PT", "PT")
                dGridCdrs.Columns.Add("ECH", "ECH")
                dGridCdrs.Columns.Add("DUR_RING", "DUR_RING")
                dGridCdrs.Columns.Add("DUR_TOTAL", "DUR_TOTAL")
                dGridCdrs.Rows.Clear()
                FormataGrid()
                For j = i - Coincidencias To dt.Rows.Count - 1
                    If vASS_B = dt.Rows(j).Item("ASS_B").ToString And _
                        vASS_A = dt.Rows(j).Item("ASS_A").ToString Then
                        dGridCdrs.Rows.Add()
                        For c = 0 To dt.Columns.Count - 1
                            dGridCdrs.Item(c, j - i + Coincidencias).Value = dt.Rows(j).Item(c).ToString
                        Next c
                        LocalizaLoop = j
                    Else
                        Exit For
                    End If
                Next j

                Me.statusTempoGasto.BackColor = Color.Aqua
                StatusStrip1.Refresh()

                statusRecCount.Text = "Registros: " & dGridCdrs.RowCount
                horaF = Now
                statusTempoGasto.Text = "Tempo: " & Format((horaF - horaI).TotalSeconds, "####") & " segundos  "
                LocalizaLoop = i + dGridCdrs.RowCount
                btnProxLoop.Enabled = True
                Cursor = Cursors.Default
                Exit Function
            End If
        Next i
        LocalizaLoop = 0
    End Function
    Private Sub btnLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoop.Click
        Dim TeveLoop As Boolean

        Call btnLimpar_Click(sender, e) 'Limpar campos
        nudLimite.Value = 0
        cbLimite.Checked = True
        ExecSQLf()
        dGridCdrs.Refresh()
        nudLimite.Value = 500
        cbCampo1.Text = "CLASSIF"
        cbOperador2.Text = "="
        txtValor1.Text = "DSC"

        InicioLIMIT = 0
        TeveLoop = False
        statusRecCount.Text = "Procurando Loop a partir do registro 0"
        StatusStrip1.Refresh()
        LinhaInicialPesquisaLoop = 0
        horaI = Now
        Do
            Cursor = Cursors.WaitCursor
            cbLimite.Checked = True
            cbLimite.Checked = False 'forcar a retirada da clausula LIMIT
            txtSQL.Text &= " LIMIT " & InicioLIMIT + 1 & "," & BLOCO_DE_CDRs
            'Preparar SQL
            dt = MySQL_Select(Conn, txtSQL.Text)
            If dt.Rows.Count <= 0 Then Continue Do
            LinhaInicialPesquisaLoop = LocalizaLoop(LinhaInicialPesquisaLoop)
            If LinhaInicialPesquisaLoop = -1 Then
                Exit Sub
            End If
            If LinhaInicialPesquisaLoop <> 0 Then
                TeveLoop = True
            Else
                InicioLIMIT += BLOCO_DE_CDRs
            End If
        Loop While (dt.Rows.Count > 0 And (Not TeveLoop))
        Cursor = Cursors.Default
        If Not TeveLoop Then
            nudLimite.Value = 0
            cbLimite.Checked = True
            ExecSQLf()
            statusRecCount.Text = ""
            StatusStrip1.Refresh()
            MsgBox("Parabéns! Não encontrei indícios de LOOP.")
            nudLimite.Value = 500
        End If
    End Sub

    Private Sub btnProxLoop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProxLoop.Click
        Dim TeveLoop As Boolean

        'InicioLIMIT = 0
        horaI = Now
        TeveLoop = False
        statusRecCount.Text = "Procurando Loop a partir do registro " & LinhaInicialPesquisaLoop + InicioLIMIT
        StatusStrip1.Refresh()
        Do
            Cursor = Cursors.WaitCursor
            cbLimite.Checked = True
            cbLimite.Checked = False 'forcar a retirada da clausula LIMIT
            txtSQL.Text &= " LIMIT " & InicioLIMIT + 1 & "," & BLOCO_DE_CDRs
            'Preparar SQL
            dt = MySQL_Select(Conn, txtSQL.Text)
            If dt.Rows.Count <= 0 Then Continue Do
            LinhaInicialPesquisaLoop = LocalizaLoop(LinhaInicialPesquisaLoop)
            If LinhaInicialPesquisaLoop = -1 Then
                Exit Sub
            End If
            If LinhaInicialPesquisaLoop <> 0 Then
                TeveLoop = True
            Else
                InicioLIMIT += BLOCO_DE_CDRs
            End If
        Loop While (dt.Rows.Count > 0 And (Not TeveLoop))
        Cursor = Cursors.Default
        If Not TeveLoop Then
            nudLimite.Value = 0
            cbLimite.Checked = True
            ExecSQLf()
            statusRecCount.Text = ""
            StatusStrip1.Refresh()
            MsgBox("Fim do Arquivo.")
            nudLimite.Value = 500
        End If
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
    Private Sub CalculaTrafego()
        Dim r, tch As Integer
        Dim DurTotal As Double
        Dim MenorData, MaiorData As Date

        If dGridCdrs.Rows.Count < 1 Then Exit Sub
        DurTotal = 0.0
        tch = 0
        MenorData = dGridCdrs.Item(dGridCdrs.Columns("DATA").Index, 0).Value
        MaiorData = MenorData
        For r = 0 To dGridCdrs.Rows.Count - 1

            DurTotal += dGridCdrs.Item(dGridCdrs.Columns("DUR_TOTAL").Index, r).Value
            If dGridCdrs.Item(dGridCdrs.Columns("DATA").Index, r).Value < MenorData Then
                MenorData = CDate(dGridCdrs.Item(dGridCdrs.Columns("DATA").Index, r).Value)
            End If
            If dGridCdrs.Item(dGridCdrs.Columns("DATA").Index, r).Value > MaiorData Then
                MaiorData = CDate(dGridCdrs.Item(dGridCdrs.Columns("DATA").Index, r).Value)
            End If
        Next r

        Dim Intervalo As Integer = DateDiff(DateInterval.Second, MenorData, MaiorData)
        MsgBox(String.Format("Duração Total: {0:N0}s.", DurTotal) & vbCrLf _
             & String.Format("TMR: {0:N2}s.", DurTotal / dGridCdrs.Rows.Count) & vbCrLf _
             & String.Format("Menor Data: {0:dd/MM/yyyy HH:mm:ss}", MenorData) & vbCrLf _
             & String.Format("Maior Data: {0:dd/MM/yyyy HH:mm:ss}", MaiorData) & vbCrLf _
             & String.Format("Intervalo: {0:N0}s.", Intervalo) & vbCrLf _
             & String.Format("Tráfego : {0:N1} erl.", DurTotal / Intervalo) & vbCrLf _
             , MsgBoxStyle.Information)
    End Sub

End Class