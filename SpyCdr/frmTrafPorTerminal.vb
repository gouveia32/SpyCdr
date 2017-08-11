Imports System.io
Imports System.Math
Imports System.Data
Imports System.Globalization


Public Class frmTrafPorTerminal

    Dim SQL As String
    'define a string de Conn
    'define os objetos connecton, command e dataadapter
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
    Private Sub ContabilizaChamadas(ByVal ArqCdrs As String)
        Dim sqlSelect As String
        Dim sqlWhere As String
        Dim sqlGroupBy As String
        Dim dt As DataTable
        Dim i As Integer
        sqlGroupBy = " GROUP by TERMINAL"

        If cbClientes.Text <> "Todos" Then
            sqlWhere = " WHERE cliente_terminal.COD_CLI=" & CType(Me.cbClientes.SelectedItem, ValueDescriptionPair).Value 'usa sql provisoriamente
        Else
            sqlWhere = ""
        End If

        'originados
        Try
            sqlSelect = "SELECT TERMINAL, Count(TERMINAL) as Nr_CH " _
                      & "FROM  cliente_terminal JOIN " & ArqCdrs _
                      & " ON TERMINAL = " & ArqCdrs & ".ASS_A "
            SQL = sqlSelect & sqlWhere & sqlGroupBy

            dt = MySQL_Select(Conn, SQL)
        Catch e As DataException
            Dim s As String = e.Message
        End Try

        Dim PosReg As Integer
        PosReg = 0
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                'If PosReg > dgvxResumo.RowCount Then
                Do While dt.Rows(i).Item(0) <> dgvxResumo.Item(0, PosReg).Value.ToString()
                    PosReg += 1
                Loop
                'End If
                dgvxResumo.Item(1, PosReg).Value = dt.Rows(i).Item(1)
            Next i
        End If

        'destinados
        conn.Close()
        sqlSelect = "SELECT TERMINAL, Count(TERMINAL) as Nr_CH " _
                  & "FROM  cliente_terminal JOIN " & ArqCdrs _
                  & " ON TERMINAL = " & ArqCdrs & ".ASS_B "
        SQL = sqlSelect & sqlWhere & sqlGroupBy

        dt = MySQL_Select(Conn, SQL)

        PosReg = 0
        If dt.Rows.Count > 0 Then
            For i = 0 To dt.Rows.Count - 1
                'If PosReg < dgvxResumo.RowCount - 1 Then
                Do While dt.Rows(i).Item(0) <> dgvxResumo.Item(0, PosReg).Value.ToString()
                    PosReg += 1
                Loop
                'End If
                dgvxResumo.Item(2, PosReg).Value = dt.Rows(i).Item(1)
            Next i
        End If

        For PosReg = 0 To dgvxResumo.Rows.Count - 1
            If dgvxResumo.Item(1, PosReg).Value Is Nothing _
                AndAlso dgvxResumo.Item(2, PosReg).Value Is Nothing Then
                dgvxResumo.Rows(PosReg).DefaultCellStyle.BackColor = Color.Yellow
            End If
        Next PosReg

        ProcessoFim()
    End Sub

    Private Sub frmTrafPPI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CarregaClientes()


        With dgvxResumo
            .Font = New Font("Tahoma", 7.0!, FontStyle.Regular)
            '0        1     2        3      4              5      6              7      8    9      10             11     12            13     14   15   16   17  18   19        20  
            'CLASSIF, Data, DURACAO, ASS_A, cli_A.CLIENTE, R_ENT, _exrop_E.ROTA, J_ENT, CSP, ASS_B, cli_B.CLIENTE, R_SAI, _exrop_S.ROTA,J_SAI, EOS, CAT, FDS, PT, ECH, DUR_RING, DUR_TOTAL 
            .Columns(0).Width = 100  'TERMINAL
            .Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .Columns(1).Width = 100  'ORIGINADA
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            .Columns(2).Width = 100  'TERMINADA
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        End With

    End Sub
    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Dim sqlWhere As String
        Dim ArqCdrs As String

        If Conn Is Nothing Then Exit Sub
        ProcessoInicio()

        ArqCdrs = "cdrs_" & Format(CDate(dtpInicio.Text), "yyyyMMdd")

        If cbClientes.Text <> "Todos" Then
            sqlWhere = " WHERE cliente_terminal.COD_CLI=" & CType(Me.cbClientes.SelectedItem, ValueDescriptionPair).Value 'usa sql provisoriamente
        Else
            sqlWhere = ""
        End If
        'listar todos terminais

        'Montar Resumo
        dt = MySQL_Select(Conn, "SELECT TERMINAL FROM cliente_terminal " & sqlWhere)

        dgvxResumo.DataSource = dt

        If dtpInicio.Value.Date = dtpFim.Value.Date Then
            ContabilizaChamadas(ArqCdrs)
        Else
            'limpa Ccdrs_sel
            MySQL_cmd(Conn, "DELETE FROM `cdrs_sel`")
            'seleciona CDRs do periodo
            Dim dt As Date

            dt = dtpInicio.Value
            While (dt <= dtpFim.Value)
                ArqCdrs = "cdrs_" & Format(CDate(dt), "yyyyMMdd")
                lblAguarde.Text = "Processando (" & Format(dt, "yyyy/MM/dd") & "). Aguarde..."
                Application.DoEvents()
                SQL = "INSERT INTO CDRs_SEL SELECT CLASSIF, ASS_A, CSP, ASS_B, CAT, FDS, EOS, PT, ECH, J_ENT, J_SAI, R_ENT, R_SAI, DATA, DUR_RING, DURACAO, DUR_TOTAL, TTFILE, NR_DISCADO,RN2,RN3 " _
                    & "FROM " & ArqCdrs & " LEFT JOIN _exrop AS _exrop_E ON " & ArqCdrs & ".R_ENT = _exrop_E.RIN " _
                    & "LEFT JOIN _exrop AS _exrop_S ON " & ArqCdrs & ".R_SAI = _exrop_S.RIN  " _
                    & "LEFT JOIN cliente_terminal AS term_A ON " & ArqCdrs & ".ASS_A = term_A.TERMINAL " _
                    & "LEFT JOIN clientes AS cli_A ON cli_A.COD_CLI = term_A.COD_CLI " _
                    & "LEFT JOIN cliente_terminal AS term_B ON " & ArqCdrs & ".ASS_B = term_B.TERMINAL " _
                    & "LEFT JOIN clientes AS cli_B ON cli_B.COD_CLI = term_B.COD_CLI "
                Try
                    MySQL_cmd(Conn, SQL)
                Catch x As Exception
                    Dim s As String = x.Message
                End Try

                dt = dt.AddDays(1)
            End While
            ContabilizaChamadas("cdrs_sel")
        End If

    End Sub
    Private Sub CarregaClientes()
        'carrega cbPPI
        If Conn Is Nothing Then Exit Sub

        dt = MySQL_Select(Conn, "SELECT 0, 'Todos' UNION SELECT DISTINCT COD_CLI, CLIENTE FROM Clientes ORDER BY COD_CLI ASC")
        cbClientes.DataSource = dt

    End Sub

    Private Sub dtpInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpInicio.ValueChanged
        'dtpFim.Text = dtpInicio.Text
    End Sub

    Private Sub cbClientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbClientes.SelectedIndexChanged
        If dgvxResumo.Rows.Count > 0 Then
            dgvxResumo.Rows.Clear()
            dgvxResumo.Refresh()
        End If
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        ExportToExcel(dgvxResumo, xlsOption.xlsOpen, , cbClientes.Text)
    End Sub
End Class
