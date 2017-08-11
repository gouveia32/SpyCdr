Imports System.io
Imports System.Math
Imports System.Data

Public Class frmResumo

    Dim IndicadorNome() As String = {"CO0", "CO1", "CO2", "CO3", "DSC", "LO", "NR1", "NR5", "OK1", "OK5", "OU"}

    Dim SQL As String
    'define a string de Conn
    Dim formatado As Boolean 'indica se ja formatou o grid alguma vez

    'define o dataset
    Dim dt As DataTable
    Private Sub ProcessoInicio()
        lblAguarde.Visible = True
        lblAguarde.Refresh()
        Cursor = Cursors.WaitCursor
    End Sub

    Private Sub ProcessoFim()
        lblAguarde.Visible = False
        lblAguarde.Refresh()
        Cursor = Cursors.Default
    End Sub

    Private Sub CarregaGrid()
        Dim sqlSelect As String
        Dim sqlWhere As String
        Dim sqlGroupBy As String
        'SQL = "SELECT HORA, R_SAI, (CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU) AS TCH, CO0, CO1, CO2, CO3, DSC, LO, NR1, NR5, OK1, OK5, OU FROM x_rota_saida " _
        '& " WHERE date(DATA) = '" & DateTimePicker1.Text & "';"
        'Parte do SQL inicalmente
        ProcessoInicio()
        sqlSelect = ""
        sqlWhere = ""
        sqlGroupBy = ""
        SQL = "round(sum(OK1+OK5)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) as pOK, round(sum(LO+NR1+NR5)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) as pPAB, round(sum(CO0+CO1+CO2+CO3)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) as pCO, round(sum(DSC)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) as pDSC, round(sum(OU)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) as pOU, sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU) AS TCH, sum(CO0) as CO0, sum(CO1) AS CO1, sum(CO2) as CO2, sum(CO3) as CO3, sum(DSC) AS DSC, sum(LO) as LO, sum(NR1) as NR1, sum(NR5) as NR5, sum(OK1) as OK1, sum(OK5) as OK5, sum(OU) as OU "
        Select Case Me.cbHistorico.Text
            Case Is = "X_Rota_Entrada"
                Select Case frmManutencao.cbTipoCentral.Text
                    Case "E"
                        sqlSelect = "SELECT _exrop.ROTA, R_ENT, " & SQL _
                            & "FROM  X_Rota_Entrada LEFT JOIN _exrop ON R_ENT = _exrop.RIN "
                        sqlWhere = " WHERE date(DATA) = '" & DateTimePicker1.Text & "' "
                        sqlGroupBy = " GROUP BY R_ENT;"
                    Case "H"
                        sqlSelect = "SELECT lst_tg.`tg_name` AS ROTA, R_ENT, " & SQL _
                            & "FROM  X_Rota_Entrada LEFT JOIN lst_tg ON TRUNCATE(R_ENT,0) = lst_tg.`tg_number` "
                        sqlWhere = " WHERE date(DATA) = '" & DateTimePicker1.Text & "'"
                        sqlGroupBy = " GROUP BY R_ENT;"
                    Case "N"
                        sqlSelect = "SELECT R_ENT AS ROTA, " & SQL _
                            & "FROM X_Rota_Entrada "
                        sqlWhere = " WHERE date(DATA) = '" & DateTimePicker1.Text & "'"
                        sqlGroupBy = " GROUP BY R_ENT;"
                End Select

            Case Is = "X_Rota_Saida"
                Select Case frmManutencao.cbTipoCentral.Text
                    Case "E"
                        sqlSelect = "SELECT _exrop.ROTA, R_SAI, " & SQL _
                                & "FROM  X_Rota_Saida LEFT JOIN _exrop ON R_SAI = _exrop.RIN "
                        sqlWhere = " WHERE date(DATA) = '" & DateTimePicker1.Text & "'"
                        sqlGroupBy = " GROUP BY R_SAI;"
                    Case "H"
                        sqlSelect = "SELECT lst_tg.`tg_name` AS ROTA, R_SAI, " & SQL _
                                & "FROM  X_Rota_Saida LEFT JOIN lst_tg ON TRUNCATE(R_SAI,0) = lst_tg.`tg_number` "
                        sqlWhere = " WHERE date(DATA) = '" & DateTimePicker1.Text & "'"
                        sqlGroupBy = " GROUP BY R_SAI;"
                    Case "N"
                        sqlSelect = "SELECT R_SAI AS ROTA, " & SQL _
                            & "FROM X_Rota_Saida "
                        sqlWhere = " WHERE date(DATA) = '" & DateTimePicker1.Text & "'"
                        sqlGroupBy = " GROUP BY R_SAI;"
                End Select
            Case Is = "X_Cliente_Originado"
                sqlSelect = "SELECT clientes.CLIENTE, " & SQL _
                    & "FROM  X_Cliente_Originado  LEFT JOIN clientes ON X_Cliente_Originado.COD_CLI = clientes.COD_CLI "
                sqlWhere = " WHERE date(DATA) = '" & DateTimePicker1.Text & "' "
                sqlGroupBy = " GROUP BY X_Cliente_Originado.COD_CLI"
            Case Is = "X_Cliente_Destinado"
                sqlSelect = "SELECT clientes.CLIENTE, " & SQL _
                    & "FROM  X_Cliente_Destinado  LEFT JOIN clientes ON X_Cliente_Destinado.COD_CLI = clientes.COD_CLI "
                sqlWhere = " WHERE date(DATA) = '" & DateTimePicker1.Text & "' "
                sqlGroupBy = "  GROUP BY X_Cliente_Destinado.COD_CLI"
            Case Is = "X_Grupo"
                sqlSelect = "SELECT X_Grupo.GRUPO, " & SQL _
                    & "FROM  X_Grupo "
                sqlWhere = " WHERE date(DATA) = '" & DateTimePicker1.Text & "' "
                sqlGroupBy = " GROUP BY X_Grupo.GRUPO;"

            Case Is = "X_EOS"
                sqlSelect = "SELECT EOS, " & SQL _
                    & "FROM  X_EOS "
                sqlWhere = " WHERE date(DATA) = '" & DateTimePicker1.Text & "'"
                sqlGroupBy = " GROUP BY EOS;"
            Case Is = "X_ASS_A"
                sqlSelect = "SELECT ASS_A, " & SQL _
                    & "FROM  X_ASS_A "
                sqlWhere = " WHERE date(DATA) = '" & DateTimePicker1.Text & "'"
                sqlGroupBy = " GROUP BY ASS_A;"
            Case Is = "X_ASS_B"
                sqlSelect = "SELECT ASS_B, " & SQL _
                    & "FROM  X_ASS_B "
                sqlWhere = " WHERE date(DATA) = '" & DateTimePicker1.Text & "'"
                sqlGroupBy = " GROUP BY ASS_B;"
            Case Is = "X_PPI"
                sqlSelect = "select ppis.PPI, (`NA ROTA` +`FORA DA ROTA`) AS TCH, `NA ROTA`, `FORA DA ROTA`  " _
                    & "FROM x_ppi JOIN ppis ON ppis.id = x_ppi.COD_PPI "
                sqlWhere = " WHERE date(DATA) = '" & DateTimePicker1.Text & "'"
        End Select

        If cbHistorico.Text <> "X_ASS_A" And cbHistorico.Text <> "X_ASS_B" Then
            'Filtra Hora
            If Me.cbIntervalo.Text.Substring(0, 2) <> "24" Then
                If Me.cbIntervalo.Text.Substring(0, 2) <> "PM" Then
                    sqlWhere += " AND HORA=" & Val(Me.cbIntervalo.Text)
                Else
                    Dim hi, hf As Integer
                    hi = Me.cbIntervalo.Text.Substring(Me.cbIntervalo.Text.IndexOf("(") + 1, 2)
                    hf = Me.cbIntervalo.Text.Substring(Me.cbIntervalo.Text.IndexOf(")") - 2, 2)
                    sqlWhere += " AND HORA >= " & hi & " AND HORA < " & hf
                End If
            End If
        End If

        SQL = sqlSelect & sqlWhere & sqlGroupBy

        Try
            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor


            dt = MySQL_Select(Conn, SQL)
            ' vincula a tabela ao datagrid
            dGridDDX.DataSource = dt.DefaultView
            '---fecha a Conn---
            Conn.Close()

            FormataGrid()
            CalculaTotais()
            If formatado And Me.cbHistorico.Text <> "X_PPI" Then GeraPizza(dGridTotais, 0, dGridDDX.Columns("TCH").Index)
            formatado = True
            '-=-=-=-=

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ProcessoFim()
        End Try
    End Sub

    Private Sub frmResumo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Cursor = Cursors.Default
        Me.Text = "Resumo - " & frmManutencao.cbBilhetador.Text
    End Sub
    Private Sub frmConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        formatado = False
        CarregaGrid()
    End Sub
    Private Sub FormataGrid()
        Dim c As Integer

        'formata as colunas de dGrid
        With dGridDDX
            If .ColumnCount <= 0 Then
                Exit Sub
            End If
            .Font = New Font("Tahoma", 7.0!, FontStyle.Regular)
            dGridTotais.ColumnCount = .ColumnCount
            For c = 0 To .Columns.Count - 1
                .Columns(c).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Select Case .Columns(c).Name
                    Case "TCH"
                        .Columns(c).Width = 55
                    Case "CLIENTE"
                        .Columns(c).Width = 100
                        .Columns(c).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    Case "ROTA"
                        .Columns(c).Width = 60
                        .Columns(c).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    Case "ASS_A", "ASS_B", "GRUPO", "EOS", "PPI"
                        .Columns(c).Width = 70
                        .Columns(c).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Columns(c).DefaultCellStyle.Format = "s"
                    Case "FORA DA ROTA", "NA ROTA"
                        .Columns(c).Width = 70
                        .Columns(c).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Case Else
                        .Columns(c).Width = 40
                End Select
            Next

        End With
        'Formata dGridTotais
        dGridTotais.Font = New Font("Tahoma", 7.0!, FontStyle.Bold)

        For c = 0 To dGridDDX.ColumnCount - 1
            dGridTotais.Columns(c).Width = dGridDDX.Columns(c).Width
            dGridTotais.Columns(c).DefaultCellStyle.Alignment = dGridDDX.Columns(c).DefaultCellStyle.Alignment

        Next
    End Sub
    Private Sub CalculaTotais()
        Dim r, c As Integer

        'Calcula totais
        With dGridTotais
            If .ColumnCount <= 0 Then
                Exit Sub
            End If
            .RowCount = 1
            .ColumnCount = dGridDDX.ColumnCount

            .ColumnHeadersVisible = False
            'Zera totais
            For c = 0 To dGridDDX.Columns.Count - 1
                If Array.IndexOf(IndicadorNome, dGridDDX.Columns(c).Name) >= 0 Or dGridDDX.Columns(c).Name = "TCH" Then
                    .Item(c, 0).Value = 0
                Else
                    .Item(c, 0).Value = 0
                End If
            Next

            .Item(0, 0).Value = "Total: " & dGridDDX.Rows.Count.ToString
            For r = 0 To dGridDDX.RowCount - 1
                For c = 0 To dGridDDX.ColumnCount - 1
                    If Array.IndexOf(IndicadorNome, dGridDDX.Columns(c).Name) >= 0 Or _
                       dGridDDX.Columns(c).Name = "TCH" Or _
                       dGridDDX.Columns(c).Name = "NA ROTA" Or _
                       dGridDDX.Columns(c).Name = "FORA DA ROTA" Then
                        .Item(c, 0).Value += Val(dGridDDX.Item(c, r).Value)
                    End If
                Next
            Next
            If Me.cbHistorico.Text <> "X_PPI" Then
                'Calcula(porcentuais)
                .Item(dGridDDX.Columns("pOK").Index, 0).Value = Round((.Item(dGridDDX.Columns("OK1").Index, 0).Value _
                                                                + .Item(dGridDDX.Columns("OK5").Index, 0).Value) _
                                                                / .Item(dGridDDX.Columns("TCH").Index, 0).Value * 100, 1)
                .Item(dGridDDX.Columns("pPAB").Index, 0).Value = Round((.Item(dGridDDX.Columns("LO").Index, 0).Value _
                                                                + .Item(dGridDDX.Columns("NR1").Index, 0).Value _
                                                                + .Item(dGridDDX.Columns("NR5").Index, 0).Value) _
                                                                / .Item(dGridDDX.Columns("TCH").Index, 0).Value * 100, 1)
                .Item(dGridDDX.Columns("pCO").Index, 0).Value = Round((.Item(dGridDDX.Columns("CO0").Index, 0).Value _
                                                                + .Item(dGridDDX.Columns("CO1").Index, 0).Value _
                                                                + .Item(dGridDDX.Columns("CO2").Index, 0).Value _
                                                                + .Item(dGridDDX.Columns("CO3").Index, 0).Value) _
                                                                / .Item(dGridDDX.Columns("TCH").Index, 0).Value * 100, 1)
                .Item(dGridDDX.Columns("pDSC").Index, 0).Value = Round(.Item(dGridDDX.Columns("DSC").Index, 0).Value _
                                                                / .Item(dGridDDX.Columns("TCH").Index, 0).Value * 100, 1)
                .Item(dGridDDX.Columns("pOU").Index, 0).Value = Round(.Item(dGridDDX.Columns("OU").Index, 0).Value _
                                                                / .Item(dGridDDX.Columns("TCH").Index, 0).Value * 100, 1)
            End If
        End With

        formatado = True

    End Sub
    Private Sub GeraPizza(ByVal grid As System.Windows.Forms.DataGridView, ByVal RowIndex As Integer, ByVal tch As Integer)
        Dim c As Integer

        'Dim IndicadorNomeA(grid.Columns.Count - 4) As String
        Dim IndPorcentual(10) As Double
        Dim IndQuantidade(10) As Integer

        If RowIndex < 0 Or grid.ColumnCount < 1 Then
            Exit Sub
        End If

        'Calcula Quantidades
        For c = tch + 1 To grid.Columns.Count - 1
            IndQuantidade(c - (tch + 1)) = grid.Item(c, RowIndex).Value
        Next

        'Calcula porcentuais
        For c = tch + 1 To grid.Columns.Count - 1
            If grid.Item(tch, RowIndex).Value > 0 Then
                IndPorcentual(c - (tch + 1)) = grid.Item(c, RowIndex).Value / (grid.Item(tch, RowIndex).Value) * 100
            Else
                IndPorcentual(c - (tch + 1)) = 0
            End If
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
            If formatado Then
                If Me.cbHistorico.Text = "X_Rota_Entrada" Or _
                       Me.cbHistorico.Text = "X_Rota_Saida" Or _
                       Me.cbHistorico.Text = "X_Cliente_Originado" Or _
                       Me.cbHistorico.Text = "X_Cliente_Destinado" Then
                    .Titles("Principal").Text = Me.dGridDDX.Columns(1).Name & ": " & grid.Item(0, RowIndex).Value.ToString 'Hora
                Else
                    .Titles("Principal").Text = Me.dGridDDX.Columns(0).Name & ": " & grid.Item(0, RowIndex).Value.ToString 'Hora
                End If
            End If

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
            If formatado Then
                If Me.cbHistorico.Text = "X_Rota_Entrada" Or _
                       Me.cbHistorico.Text = "X_Rota_Saida" Or _
                       Me.cbHistorico.Text = "X_Cliente_Originado" Or _
                       Me.cbHistorico.Text = "X_Cliente_Destinado" Then
                    .Titles("Principal").Text = Me.dGridDDX.Columns(1).Name & ": " & grid.Item(0, RowIndex).Value.ToString 'Hora
                Else
                    .Titles("Principal").Text = Me.dGridDDX.Columns(0).Name & ": " & grid.Item(0, RowIndex).Value.ToString 'Hora
                End If
            End If
            .ChartAreas("Default").ReCalc()
        End With
        chartPizza.Visible = True
        chartBarra.Visible = True

    End Sub

    Private Sub dGridDDX_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGridDDX.RowEnter
        If formatado Then
            If cbHistorico.Text <> "X_PPI" Then Call GeraPizza(dGridDDX, e.RowIndex, dGridDDX.Columns("TCH").Index)
        End If

    End Sub
    Private Sub dGridTotais_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGridTotais.RowEnter
        If formatado Then Call GeraPizza(dGridTotais, e.RowIndex, dGridDDX.Columns("TCH").Index)
    End Sub
    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        dGridDDX.Columns.Clear()
        dGridTotais.Columns.Clear()
        chartPizza.Visible = False
        chartBarra.Visible = False

        'CarregaGrid()
    End Sub
    Private Sub dGridDDX_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGridDDX.CellDoubleClick
        Dim strSELECT As String
        Dim strWHERE As String
        Dim tabela As String

        tabela = "cdrs_" & Format(CDate(DateTimePicker1.Text), "yyyyMMdd")
        'If Not oSpyCdr.TabelaExiste(conn, frmManutencao.txtBancoMySql.Text, tabela) Then
        'MsgBox("Neste dia não temos os CDRs!!")
        'Exit Sub
        'End If

        Select Case frmManutencao.cbTipoCentral.Text
            Case "E"
                strSELECT = "SELECT CLASSIF ,DATA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,_exrop_E.ROTA AS ROTA_E,J_ENT,CSP, " _
                            & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, _exrop_S.ROTA AS ROTA_S,J_SAI, NR_DISCADO, RN2, RN3, EOS, CAT, FDS, PT, ECH, DUR_RING, DUR_TOTAL " _
                            & "FROM " & tabela & " LEFT JOIN _exrop AS _exrop_E ON " & tabela & ".R_ENT = _exrop_E.RIN " _
                            & "LEFT JOIN _exrop AS _exrop_S ON " & tabela & ".R_SAI = _exrop_S.RIN  " _
                            & "LEFT JOIN cliente_terminal AS term_A ON " & tabela & ".ASS_A = term_A.TERMINAL " _
                            & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                            & "LEFT JOIN cliente_terminal AS term_B ON " & tabela & ".ASS_B = term_B.TERMINAL " _
                            & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI "
            Case "H"
                strSELECT = "SELECT CLASSIF ,DATA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,LST_TG_E.`tg_name` AS ROTA_E,CSP, " _
                        & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, LST_TG_S.`tg_name` AS ROTA_S,  PT,Dialed_Number, Caller_Category, Bill_Type, Free_Ind, Charged_Party_Ind, " _
                        & "Call_Type, GSVN, Failure_Code, Termination_code, Bearer_Service, Tele_Service, RxFlus, TxFlus, Caller_GK_Address, Caller_GW_Address, Called_GK_Address, Called_GW_Address " _
                        & "FROM " & tabela & " LEFT JOIN LST_TG AS LST_TG_E ON " & tabela & ".R_ENT = LST_TG_E.`tg_number` " _
                        & "LEFT JOIN LST_TG AS LST_TG_S ON " & tabela & ".R_SAI = LST_TG_S.`tg_number`  " _
                        & "LEFT JOIN cliente_terminal AS term_A ON " & tabela & ".ASS_A = term_A.TERMINAL " _
                        & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                        & "LEFT JOIN cliente_terminal AS term_B ON " & tabela & ".ASS_B = term_B.TERMINAL " _
                        & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI "
            Case "N"
                strSELECT = "SELECT CLASSIF ,DATA, HORA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,ICT,CSP, " _
                            & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, OGT, CAUSA, CAT, FDS, PT, CL, OCUP_INICIO, OCUP_FIM " _
                            & "FROM " & tabela & " " _
                            & "LEFT JOIN cliente_terminal AS term_A ON " & tabela & ".ASS_A = term_A.TERMINAL " _
                            & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                            & "LEFT JOIN cliente_terminal AS term_B ON " & tabela & ".ASS_B = term_B.TERMINAL " _
                            & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI "
        End Select

        'Me.dGridDDX.Columns("TCH").Index, e.RowIndex).Value
        If Me.cbHistorico.Text = "X_Grupo" Then
            Select Case frmManutencao.cbTipoCentral.Text
                Case "E"
                    strSELECT = "SELECT CLASSIF ,DATA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,_exrop_E.ROTA AS ROTA_E,J_ENT,CSP, " _
                              & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, _exrop_S.ROTA AS ROTA_S,J_SAI, NR_DISCADO, RN2, RN3, EOS, CAT, FDS, PT, ECH, DUR_RING, DUR_TOTAL " _
                                & "FROM " & tabela & " LEFT JOIN _exrop AS _exrop_E ON " & tabela & ".R_ENT = _exrop_E.RIN " _
                                & "LEFT JOIN _exrop AS _exrop_S ON " & tabela & ".R_SAI = _exrop_S.RIN  " _
                                & "LEFT JOIN cliente_terminal AS term_A ON " & tabela & ".ASS_A = term_A.TERMINAL " _
                                & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                                & "LEFT JOIN cliente_terminal AS term_B ON " & tabela & ".ASS_B = term_B.TERMINAL " _
                                & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI " _
                                & "      JOIN grupos ON (" & tabela & ".ASS_A like grupos.MASCARA_ASS_A AND" _
                                & "                        " & tabela & ".CSP like grupos.MASCARA_CSP AND" _
                                & "                      " & tabela & ".ASS_B like grupos.MASCARA_ASS_B AND" _
                                & "                      " & tabela & ".R_ENT like grupos.MASCARA_ROTA_E AND" _
                                & "                      " & tabela & ".R_SAI like grupos.MASCARA_ROTA_S) "

                Case "H"
                    strSELECT = "SELECT CLASSIF ,DATA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,LST_TG_E.`tg_name` AS ROTA_E,CSP, " _
                                & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, LST_TG_S.`tg_name` AS ROTA_S,  PT,Dialed_Number, Caller_Category, Bill_Type, Free_Ind, Charged_Party_Ind, " _
                                & "Call_Type, GSVN, Failure_Code, Termination_code, Bearer_Service, Tele_Service, RxFlus, TxFlus, Caller_GK_Address, Caller_GW_Address, Called_GK_Address, Called_GW_Address " _
                                & "FROM " & tabela & " LEFT JOIN LST_TG AS LST_TG_E ON " & tabela & ".R_ENT = LST_TG_E.`tg_number` " _
                                & "LEFT JOIN LST_TG AS LST_TG_S ON " & tabela & ".R_SAI = LST_TG_S.`tg_number`  " _
                                & "LEFT JOIN cliente_terminal AS term_A ON " & tabela & ".ASS_A = term_A.TERMINAL " _
                                & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                                & "LEFT JOIN cliente_terminal AS term_B ON " & tabela & ".ASS_B = term_B.TERMINAL " _
                                & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI " _
                                & "      JOIN grupos ON (" & tabela & ".ASS_A like grupos.MASCARA_ASS_A AND" _
                                & "                        " & tabela & ".CSP like grupos.MASCARA_CSP AND" _
                                & "                      " & tabela & ".ASS_B like grupos.MASCARA_ASS_B AND" _
                                & "                      " & tabela & ".R_ENT like grupos.MASCARA_ROTA_E AND" _
                                & "                      " & tabela & ".R_SAI like grupos.MASCARA_ROTA_S) "
                    '& "LEFT JOIN grupos ON (ASS_A like grupos.MASCARA_ASS_A AND CSP like grupos.MASCARA_CSP AND ASS_B like grupos.MASCARA_ASS_B AND LST_TG_E.`tg_number` like grupos.MASCARA_ROTA_E AND LST_TG_S.`tg_number` like grupos.MASCARA_ROTA_S)"
                Case "N"
                    strSELECT = "SELECT CLASSIF ,DATA, HORA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,ICT,CSP, " _
                                & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, OGT, CAUSA, CAT, FDS, PT, CL, OCUP_INICIO, OCUP_FIM " _
                                & "FROM " & tabela & " " _
                                & "LEFT JOIN cliente_terminal AS term_A ON " & tabela & ".ASS_A = term_A.TERMINAL " _
                                & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                                & "LEFT JOIN cliente_terminal AS term_B ON " & tabela & ".ASS_B = term_B.TERMINAL " _
                                & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI " _
                                & "LEFT JOIN grupos ON (ASS_A like grupos.MASCARA_ASS_A AND CSP like grupos.MASCARA_CSP AND ASS_B like grupos.MASCARA_ASS_B AND R_ENT like grupos.MASCARA_ROTA_E AND R_SAI like grupos.MASCARA_ROTA_S)"
            End Select
        End If
        If Me.cbHistorico.Text = "X_PPI" Then
            Select Case frmManutencao.cbTipoCentral.Text
                Case "E"
                    strSELECT = "SELECT CLASSIF ,DATA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,_exrop_E.ROTA AS ROTA_E,J_ENT,CSP, " _
                              & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, _exrop_S.ROTA AS ROTA_S,J_SAI, NR_DISCADO, RN2, RN3, EOS, CAT, FDS, PT, ECH, DUR_RING, DUR_TOTAL " _
                                & "FROM " & tabela & " LEFT JOIN _exrop AS _exrop_E ON " & tabela & ".R_ENT = _exrop_E.RIN " _
                                & "LEFT JOIN _exrop AS _exrop_S ON " & tabela & ".R_SAI = _exrop_S.RIN  " _
                                & "LEFT JOIN cliente_terminal AS term_A ON " & tabela & ".ASS_A = term_A.TERMINAL " _
                                & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                                & "LEFT JOIN cliente_terminal AS term_B ON " & tabela & ".ASS_B = term_B.TERMINAL " _
                                & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI " _
                                & "      JOIN ppi_prefixo ON " & tabela & ".ASS_A  like CONCAT(ppi_prefixo.prefixo,'%') JOIN  ppis ON ppi_prefixo.cod_ppi = ppis.ID "
                                
                Case "H"
                    strSELECT = "SELECT CLASSIF ,DATA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,LST_TG_E.`tg_name` AS ROTA_E,CSP, " _
                                & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, LST_TG_S.`tg_name` AS ROTA_S,  PT,Dialed_Number, Caller_Category, Bill_Type, Free_Ind, Charged_Party_Ind, " _
                                & "Call_Type, GSVN, Failure_Code, Termination_code, Bearer_Service, Tele_Service, RxFlus, TxFlus, Caller_GK_Address, Caller_GW_Address, Called_GK_Address, Called_GW_Address " _
                                & "FROM " & tabela & " LEFT JOIN LST_TG AS LST_TG_E ON " & tabela & ".R_ENT = LST_TG_E.`tg_number` " _
                                & "LEFT JOIN LST_TG AS LST_TG_S ON " & tabela & ".R_SAI = LST_TG_S.`tg_number`  " _
                                & "LEFT JOIN cliente_terminal AS term_A ON " & tabela & ".ASS_A = term_A.TERMINAL " _
                                & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                                & "LEFT JOIN cliente_terminal AS term_B ON " & tabela & ".ASS_B = term_B.TERMINAL " _
                                & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI " _
                                & "      JOIN ppi_prefixo ON " & tabela & ".ASS_A  like CONCAT(ppi_prefixo.prefixo,'%') JOIN  ppis ON ppi_prefixo.cod_ppi = ppis.ID "
                    '& "LEFT JOIN grupos ON (ASS_A like grupos.MASCARA_ASS_A AND CSP like grupos.MASCARA_CSP AND ASS_B like grupos.MASCARA_ASS_B AND LST_TG_E.`tg_number` like grupos.MASCARA_ROTA_E AND LST_TG_S.`tg_number` like grupos.MASCARA_ROTA_S)"
                Case "N"
                    strSELECT = "SELECT CLASSIF ,DATA, HORA, DURACAO,ASS_A, cli_A.CLIENTE AS CLIENTE_A,R_ENT,ICT,CSP, " _
                                & "ASS_B, cli_B.CLIENTE AS CLIENTE_B, R_SAI, OGT, CAUSA, CAT, FDS, PT, CL, OCUP_INICIO, OCUP_FIM " _
                                & "FROM " & tabela & " " _
                                & "LEFT JOIN cliente_terminal AS term_A ON " & tabela & ".ASS_A = term_A.TERMINAL " _
                                & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                                & "LEFT JOIN cliente_terminal AS term_B ON " & tabela & ".ASS_B = term_B.TERMINAL " _
                                & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI " _
                                & "      JOIN ppi_prefixo ON " & tabela & ".ASS_A  like CONCAT(ppi_prefixo.prefixo,'%') JOIN  ppis ON ppi_prefixo.cod_ppi = ppis.ID "

            End Select
        End If

        Select Case dGridDDX.Columns(0).Name
            Case "CLIENTE"
                If Me.cbHistorico.Text = "X_Cliente_Destinado" Then
                    strWHERE = "  WHERE cli_B.CLIENTE='" & dGridDDX.Item(0, e.RowIndex).Value.ToString & "' "
                Else
                    strWHERE = "  WHERE cli_A.CLIENTE='" & dGridDDX.Item(0, e.RowIndex).Value.ToString & "' "
                End If
            Case "ROTA"
                If Me.cbHistorico.Text = "X_Rota_Saida" Then
                    strWHERE = "  WHERE R_SAI='" & dGridDDX.Item(0, e.RowIndex).Value.ToString & "' "
                Else
                    strWHERE = "  WHERE R_ENT='" & dGridDDX.Item(1, e.RowIndex).Value.ToString & "' "
                End If
            Case Else
                strWHERE = "  WHERE " & dGridDDX.Columns(0).Name & " = '" & dGridDDX.Item(0, e.RowIndex).Value.ToString & "' "
        End Select

        Select Case dGridDDX.Columns(e.ColumnIndex).Name
            Case "TCH", "CLIENTE"
            Case "pOK"
                strWHERE &= "AND (CLASSIF = 'OK1' OR CLASSIF = 'OK5') "
            Case "pPAB"
                strWHERE &= "AND (CLASSIF = 'LO' OR CLASSIF = 'NR1' OR CLASSIF = 'NR5') "
            Case "pCO"
                strWHERE &= "AND (CLASSIF = 'CO0' OR CLASSIF = 'CO1' OR CLASSIF = 'CO2' OR CLASSIF = 'CO3') "
            Case "pDSC"
                strWHERE &= "AND CLASSIF = 'DSC' "
            Case "pOU"
                strWHERE &= "AND CLASSIF = 'OU' "
            Case "NA ROTA"
                strWHERE &= "AND NOT(" & tabela & ".R_ENT <> ppis.RIN_E And " & tabela & ".R_ENT < 300 And " & tabela & ".CSP = 21)"
            Case "FORA DA ROTA"
                strWHERE &= "AND " & tabela & ".R_ENT <> ppis.RIN_E And " & tabela & ".R_ENT < 300 And " & tabela & ".CSP = 21"
            Case "R_ENT", "R_SAI", "GRUPO", "ROTA"
            Case Else
                strWHERE &= "AND CLASSIF = '" & dGridDDX.Columns(e.ColumnIndex).Name & "' "
        End Select

        If cbHistorico.Text <> "X_ASS_A" And cbHistorico.Text <> "X_ASS_B" Then
            'Filtra Hora
            If Me.cbIntervalo.Text.Substring(0, 2) <> "24" Then
                If Me.cbIntervalo.Text.Substring(0, 2) <> "PM" Then
                    strWHERE += "AND hour(DATA)=" & Val(Me.cbIntervalo.Text)
                Else
                    Dim hi, hf As Integer
                    hi = Me.cbIntervalo.Text.Substring(Me.cbIntervalo.Text.IndexOf("(") + 1, 2)
                    hf = Me.cbIntervalo.Text.Substring(Me.cbIntervalo.Text.IndexOf(")") - 2, 2)
                    strWHERE += "AND hour(DATA) >= " & hi & " AND hour(DATA) < " & hf
                End If
            End If
        End If


        Select Case frmManutencao.cbTipoCentral.Text
            Case "E"

                frmListaCdrs.Close()
                'frmListaCdrs.statusTabela.Text = tabela
                My.Settings.strSQL = strSELECT & strWHERE
                My.Settings.strTABELA = tabela

                frmListaCdrs.MdiParent = Me.MdiParent
                frmListaCdrs.Show()
                frmListaCdrs.Activate()
            Case "H"
                frmListaCDRs_H.Close()
                'frmListaCDRs_H.txtSQL.Text = strSELECT & strWHERE
                'frmListaCDRs_H.statusTabela.Text = tabela
                My.Settings.strSQL = strSELECT & strWHERE
                My.Settings.strTABELA = tabela

                frmListaCDRs_H.MdiParent = Me.MdiParent
                frmListaCDRs_H.Show()
                frmListaCDRs_H.Activate()
            Case "N"
                frmListaCdrs_N.Close()
                frmListaCdrs_N.txtSQL.Text = strSELECT & strWHERE
                frmListaCdrs_N.statusTabela.Text = tabela

                frmListaCdrs_N.MdiParent = Me.MdiParent
                frmListaCdrs_N.Show()
                frmListaCdrs_N.Activate()
        End Select


        'My.Forms.frmListaCdrs.Show()
    End Sub

    Private Sub cbHistorico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbHistorico.SelectedIndexChanged
        If Me.cbHistorico.Text = "X_EOS" And frmManutencao.cbTipoCentral.Text = "N" Then
            MsgBox("O Histórico X_EOS Não está dosponível para centrais NEC.", MsgBoxStyle.Critical)
            Me.cbHistorico.Text = "X_Grupo"
            Exit Sub
        End If
        If cbHistorico.Text.Substring(0, 4) = "X_AS" Or cbHistorico.Text.Substring(0, 4) = "X_PP" Then
            cbIntervalo.Enabled = False
        Else
            cbIntervalo.Enabled = True
        End If
        dGridDDX.Columns.Clear()
        dGridTotais.Columns.Clear()
        chartPizza.Visible = False
        chartBarra.Visible = False
        'CarregaGrid()
    End Sub

    Private Sub SplitContainer2_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles SplitContainer2.DoubleClick
        If SplitContainer2.SplitterDistance = 0 Then
            SplitContainer2.SplitterDistance = 270
        Else
            SplitContainer2.SplitterDistance = 0
        End If
    End Sub
    Private Sub dGridDDX_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dGridDDX.CellPainting
        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Select Case Me.dGridDDX.Columns(e.ColumnIndex).Name
                Case "pOK"
                    If Val(Me.dGridDDX.Item(Me.dGridDDX.Columns("pOK").Index, e.RowIndex).Value.ToString) < frmManutencao.nudLimite1OK.Value Then
                        Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel1OKCor.BackColor
                    Else
                        If Me.dGridDDX.Item(Me.dGridDDX.Columns("pOK").Index, e.RowIndex).Value > frmManutencao.nudLimite2OK.Value Then
                            Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel3OKCor.BackColor
                        Else
                            Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel2OKCor.BackColor
                        End If
                    End If
                Case "pPAB"
                    If Val(Me.dGridDDX.Item(Me.dGridDDX.Columns("pPAB").Index, e.RowIndex).Value.ToString) > frmManutencao.nudLimite1PAB.Value Then
                        Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel1PABCor.BackColor
                    Else
                        If Val(Me.dGridDDX.Item(Me.dGridDDX.Columns("pPAB").Index, e.RowIndex).Value.ToString) < frmManutencao.nudLimite2PAB.Value Then
                            Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel3PABCor.BackColor
                        Else
                            Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel2PABCor.BackColor
                        End If
                    End If
                Case "pCO"
                    If Val(Me.dGridDDX.Item(Me.dGridDDX.Columns("pCO").Index, e.RowIndex).Value.ToString) > frmManutencao.nudLimite1CO.Value Then
                        Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel1COCor.BackColor
                    Else
                        If Val(Me.dGridDDX.Item(Me.dGridDDX.Columns("pCO").Index, e.RowIndex).Value.ToString) < frmManutencao.nudLimite2CO.Value Then
                            Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel3COCor.BackColor
                        Else
                            Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel2COCor.BackColor
                        End If
                    End If
                Case "pDSC"
                    If Val(Me.dGridDDX.Item(Me.dGridDDX.Columns("pDSC").Index, e.RowIndex).Value.ToString) > frmManutencao.nudLimite1DSC.Value Then
                        Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel1DSCCor.BackColor
                    Else
                        If Val(Me.dGridDDX.Item(Me.dGridDDX.Columns("pDSC").Index, e.RowIndex).Value.ToString) < frmManutencao.nudLimite2CO.Value Then
                            Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel3DSCCor.BackColor
                        Else
                            Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel2DSCCor.BackColor
                        End If
                    End If
                Case "pOU"
                    If Val(Me.dGridDDX.Item(Me.dGridDDX.Columns("pOU").Index, e.RowIndex).Value.ToString) > frmManutencao.nudLimite1OU.Value Then
                        Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel1OUCor.BackColor
                    Else
                        If Val(Me.dGridDDX.Item(Me.dGridDDX.Columns("pOU").Index, e.RowIndex).Value.ToString) < frmManutencao.nudLimite2CO.Value Then
                            Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel3OUCor.BackColor
                        Else
                            Me.dGridDDX.Item(e.ColumnIndex, e.RowIndex).Style.BackColor = frmManutencao.Panel2OUCor.BackColor
                        End If
                    End If

            End Select
        End If
    End Sub

    Private Sub dGridDDX_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles dGridDDX.Scroll
        If e.ScrollOrientation = ScrollOrientation.HorizontalScroll Then Me.dGridTotais.HorizontalScrollingOffset = Me.dGridDDX.HorizontalScrollingOffset
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Hide the print button
        'btnImprimir.Visible = False
        ' Set the PrintAction to display a Print Preview dialog
        'PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview

        'PrintForm1.PrinterSettings.DefaultPageSettings.Landscape = True
        'PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 65
        'PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 30
        'PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Right = 5
        ' Print a copy of the form
        'PrintForm1.Print()
        ' Restore the print button
        'btnImprimir.Visible = True

    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked
        Dim i As Integer
        Dim txt As String
        Select Case e.ClickedItem.Name
            Case "mnuFiltrar1", "mnuFiltrar2", "mnuFiltrar3", "mnuFiltrar4", "mnuFiltrar5", "mnuFiltrar6"
                Dim filtroValor, filtro As String
                filtro = e.ClickedItem.Text.Substring(0, e.ClickedItem.Text.IndexOf("'") + 1)
                filtroValor = InputBox(filtro, "Digite o valor do filtro:", "")
                ProcessoInicio()
                If e.ClickedItem.Name = "mnuFiltrar5" Then 'LIKE
                    filtro &= "%" & filtroValor & "%'"
                Else
                    filtro &= filtroValor & "'"
                End If

                Dim dt As DataTable = CType(dGridDDX.DataSource, DataView).Table
                Dim drc As DataRow() = dt.Select(filtro)
                Dim dv As New DataView(dt)

                dv.RowFilter = filtro
                dGridDDX.DataSource = dv

                CalculaTotais()
                If formatado Then GeraPizza(dGridTotais, 0, dGridDDX.Columns("TCH").Index)
                Me.lblFiltrado.Text = "Filtrado: " & filtro
                Me.lblFiltrado.Visible = True
                Me.ContextMenuStrip1.Items(9).Enabled = Me.lblFiltrado.Visible
                ProcessoFim()

            Case "mnuLocalizar"
                Dim filtroValor, filtro As String
                filtro = e.ClickedItem.Text.Substring(11, e.ClickedItem.Text.IndexOf("'") - 14)
                filtroValor = InputBox(filtro, "Digite o valor para Localizar:", "").ToUpper
                If filtroValor <> "" Then
                    dGridDDX.Rows(dGridDDX.CurrentCell.RowIndex).Selected = False
                    For i = 0 To Me.dGridDDX.Rows.Count - 1
                        txt = dGridDDX.Item(dGridDDX.Columns(filtro).Index, i).Value.ToString.ToUpper
                        If txt.Contains(filtroValor) Then
                            dGridDDX.Rows(i).Selected = True
                            dGridDDX.CurrentCell = dGridDDX(0, i)
                            Exit Sub
                        End If
                    Next
                    MsgBox("Não encontrei: [" & filtroValor & "].")
                End If
            Case "mnuLiberarFiltro"
                ProcessoInicio()
                Dim dt As DataTable = CType(dGridDDX.DataSource, DataView).Table

                Dim drc As DataRow() = dt.Select("")
                Dim dv As New DataView(dt)

                dv.RowFilter = ""
                dGridDDX.DataSource = dv

                CalculaTotais()
                If formatado Then GeraPizza(dGridTotais, 0, dGridDDX.Columns("TCH").Index)
                Me.lblFiltrado.Visible = False
                Me.ContextMenuStrip1.Items(9).Enabled = Me.lblFiltrado.Visible
                ProcessoFim()
            Case "mnuHistorico"
                'frmHistorico.Close()

                frmHistorico.MdiParent = Me.MdiParent
                frmHistorico.cbHistorico.Text = Me.cbHistorico.Text
                i = e.ClickedItem.Text.IndexOf(" = ")
                frmHistorico.cbGrupo.Text = e.ClickedItem.Text.Substring(i + 1, e.ClickedItem.Text.Length - i - 1)
                ContextMenuStrip1.Visible = False
                If Me.cbHistorico.Text <> "X_ASS_A" And Me.cbHistorico.Text <> "X_ASS_B" Then
                    frmHistorico.TreeSelect = DateTimePicker1.Text.Replace("-", "\")
                Else
                    frmHistorico.TreeSelect = Year(DateTimePicker1.Text) & "\" & Month(DateTimePicker1.Text)
                End If
                frmHistorico.flCarga = True
                frmHistorico.Show()
                frmHistorico.Activate()

            Case "mnuFechar"
                Me.Close()
        End Select

    End Sub

    Private Sub dGridDDX_CellContextMenuStripNeeded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventArgs) Handles dGridDDX.CellContextMenuStripNeeded

        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then Exit Sub
        Me.ContextMenuStrip1.Items.Clear()
        Me.ContextMenuStrip1.Items.Add(dGridDDX.Columns(e.ColumnIndex).Name & " = '...'")
        Me.ContextMenuStrip1.Items(0).Name = "mnuFiltrar1"
        Me.ContextMenuStrip1.Items.Add(dGridDDX.Columns(e.ColumnIndex).Name & " <> '...'")
        Me.ContextMenuStrip1.Items(1).Name = "mnuFiltrar2"
        Me.ContextMenuStrip1.Items.Add(dGridDDX.Columns(e.ColumnIndex).Name & " > '...'")
        Me.ContextMenuStrip1.Items(2).Name = "mnuFiltrar3"
        Me.ContextMenuStrip1.Items.Add(dGridDDX.Columns(e.ColumnIndex).Name & " < '...'")
        Me.ContextMenuStrip1.Items(3).Name = "mnuFiltrar4"
        Me.ContextMenuStrip1.Items.Add(dGridDDX.Columns(e.ColumnIndex).Name & " LIKE '%...%'")
        Me.ContextMenuStrip1.Items(4).Name = "mnuFiltrar5"
        Me.ContextMenuStrip1.Items.Add(dGridDDX.Columns(e.ColumnIndex).Name & " LIKE '...'")
        Me.ContextMenuStrip1.Items(5).Name = "mnuFiltrar6"
        Me.ContextMenuStrip1.Items.Add("-")
        Me.ContextMenuStrip1.Items(6).Name = "mnuSeparador1"

        Me.ContextMenuStrip1.Items.Add("Localizar: " & dGridDDX.Columns(e.ColumnIndex).Name & " = '...'")
        Me.ContextMenuStrip1.Items(7).Name = "mnuLocalizar"
        Me.ContextMenuStrip1.Items(7).Image = My.Resources.Aussichten
        Me.ContextMenuStrip1.Items.Add("-")
        Me.ContextMenuStrip1.Items(8).Name = "mnuSeparador2"
        Me.ContextMenuStrip1.Items.Add("Limpar Filtro")
        Me.ContextMenuStrip1.Items(9).Name = "mnuLiberarFiltro"
        Me.ContextMenuStrip1.Items(9).Image = My.Resources.eraser
        Me.ContextMenuStrip1.Items(9).Enabled = Me.lblFiltrado.Visible
        Me.ContextMenuStrip1.Items.Add("Histórico:" & dGridDDX.Columns(0).Name & " = " & dGridDDX.Item(0, e.RowIndex).Value)
        Me.ContextMenuStrip1.Items(10).Name = "mnuHistorico"
        Me.ContextMenuStrip1.Items.Add("Fechar")
        Me.ContextMenuStrip1.Items(11).Name = "mnuFechar"
        Me.ContextMenuStrip1.Items(11).Image = My.Resources._EXIT

    End Sub

    Private Sub cbLimite_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CarregaGrid()
    End Sub

    Private Sub nudLimite_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CarregaGrid()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        formatado = False
        CarregaGrid()
    End Sub

    Private Sub cbIntervalo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIntervalo.SelectedIndexChanged
        dGridDDX.Columns.Clear()
        dGridTotais.Columns.Clear()
        chartPizza.Visible = False
        chartBarra.Visible = False
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        ProcessoInicio()
        ExportToExcel(dGridDDX, xlsOption.xlsOpen)
        ProcessoFim()
    End Sub
End Class
