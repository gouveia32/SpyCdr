Imports System.io
Imports System.Math
Imports System.Data

Public Class frmTrafPPI

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

    Private Sub frmResumo_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Cursor = Cursors.Default
        Me.Text = "Tráfego no PPI - " & frmManutencao.cbBilhetador.Text
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Dim sqlSelect As String
        Dim sqlWhere As String
        Dim sqlGroupBy As String
        Dim ArqCdrs As String

        ProcessoInicio()
        sqlSelect = ""
        sqlWhere = ""
        sqlGroupBy = ""
        ArqCdrs = "cdrs_" & Format(CDate(DateTimePicker1.Text), "yyyyMMdd")
        Select Case frmManutencao.cbTipoCentral.Text
            Case "E"
                sqlSelect = "select ppis.PPI, count(*) as TCH," _
                          & "SUM(IF(" & ArqCdrs & ".R_ENT <> ppis.RIN_E AND " & ArqCdrs & ".R_ENT < 300 AND " & ArqCdrs & ".CSP = 21,0,1)) AS 'NA ROTA',  " _
                          & "SUM(IF(" & ArqCdrs & ".R_ENT <> ppis.RIN_E AND " & ArqCdrs & ".R_ENT < 300 AND " & ArqCdrs & ".CSP = 21,1,0)) AS 'FORA DA ROTA' " _
                          & "FROM " & ArqCdrs & " JOIN ppi_prefixo ON  " & ArqCdrs & ".ASS_A  like CONCAT(ppi_prefixo.prefixo,'%') JOIN  ppis ON ppi_prefixo.cod_ppi = ppis.id  "
                If cbPPI.Text <> "Todos" Then
                    sqlWhere = " WHERE ID=" & CType(Me.cbPPI.SelectedItem, ValueDescriptionPair).Value 'usa sql provisoriamente
                Else
                    sqlWhere = ""
                End If
                sqlGroupBy = " group by ppis.PPI;"
            Case "H"
                sqlSelect = "select ppis.PPI, " _
                          & "SUM(IF(" & ArqCdrs & ".R_ENT <> ppis.RIN_E AND " & ArqCdrs & ".R_ENT < 300 AND " & ArqCdrs & ".CSP = 21,0,1)) AS 'FORA',  " _
                          & "SUM(IF(" & ArqCdrs & ".R_ENT <> ppis.RIN_E AND " & ArqCdrs & ".R_ENT < 300 AND " & ArqCdrs & ".CSP = 21,1,0)) AS 'NO PPI' " _
                          & "FROM " & ArqCdrs & " JOIN ppi_prefixo ON  " & ArqCdrs & ".ASS_A  like CONCAT(ppi_prefixo.prefixo,'%') JOIN  ppis ON ppi_prefixo.cod_ppi = ppis.id  "
                sqlWhere = ""
                sqlGroupBy = " group by ppis.PPI;"
            Case "N"
                sqlSelect = "select ppis.PPI, " _
                          & "SUM(IF(" & ArqCdrs & ".R_ENT <> ppis.RIN_E AND " & ArqCdrs & ".R_ENT < 300 AND " & ArqCdrs & ".CSP = 21,0,1)) AS 'FORA',  " _
                          & "SUM(IF(" & ArqCdrs & ".R_ENT <> ppis.RIN_E AND " & ArqCdrs & ".R_ENT < 300 AND " & ArqCdrs & ".CSP = 21,1,0)) AS 'NO PPI' " _
                          & "FROM " & ArqCdrs & " JOIN ppi_prefixo ON  " & ArqCdrs & ".ASS_A  like CONCAT(ppi_prefixo.prefixo,'%') JOIN  ppis ON ppi_prefixo.cod_ppi = ppis.id  "
                sqlWhere = ""
                sqlGroupBy = " group by ppis.PPI;"
        End Select

        SQL = sqlSelect & sqlWhere & sqlGroupBy

        '-=-=-=-=
        'define os objetos connecton, command e dataadapter
        Try
            Cursor.Current = System.Windows.Forms.Cursors.WaitCursor


            dt = MySQL_Select(Conn, SQL)
            ' vincula a tabela ao datagrid
            dGridPPI.DataSource = dt

            formatado = True
            '-=-=-=-=

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            ProcessoFim()
        End Try

    End Sub

    Private Sub frmTrafPPI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaPPIs()
    End Sub
    Private Sub CarregaPPIs()
        'carrega cbPPI
        If Conn Is Nothing Then Exit Sub

        dt = MySQL_Select(Conn, "SELECT 0, 'Todos' UNION SELECT DISTINCT ID, PPI FROM PPIs ORDER BY PPI ASC")
        cbPPI.DataSource = dt

    End Sub

    Private Sub dGridPPI_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dGridPPI.CellDoubleClick
        Dim strSELECT As String
        Dim strWHERE As String
        Dim tabela As String

        tabela = "cdrs_" & Format(CDate(DateTimePicker1.Text), "yyyyMMdd")

        'Me.dGridDDX.Columns("TCH").Index, e.RowIndex).Value
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
                strWHERE = "  WHERE " & dGridPPI.Columns(0).Name & " = '" & dGridPPI.Item(0, e.RowIndex).Value.ToString & "' "

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

        Select Case dGridPPI.Columns(e.ColumnIndex).Name
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
                strWHERE &= "AND CLASSIF = '" & dGridPPI.Columns(e.ColumnIndex).Name & "' "
        End Select

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
                frmListaCDRs_H.txtSQL.Text = strSELECT & strWHERE
                'frmListaCDRs_H.DateTimePicker1.Value = DateTimePicker1.Value

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

    End Sub
End Class
