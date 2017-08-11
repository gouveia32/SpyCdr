Public Class frmApagaRegistros
    Dim dt As DataTable


    Dim IndicadorNome() As String = {"CO0", "CO1", "CO2", "CO3", "DSC", "LO", "NR1", "NR5", "OK1", "OK5", "OU"}

    Dim SQL As String
    'define a string de Conn
    'define os objetos connecton, command e dataadapter
    Dim formatado As Boolean 'indica se ja formatou o grid alguma vez

    'define o dataset
    Dim ds As DataSet = New DataSet()
    Private Sub btnProcessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessar.Click
        Dim d, df As Date

        d = Me.DateTimePickerI.Text
        df = Me.DateTimePickerF.Text

        If d > df Then
            MsgBox("Data Final > Data Inicial!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'Open Conn
        'Conn = MySQL_Conn(frmManutencao.cbServidorMySql.Text, frmManutencao.txtBancoMySql.Text, frmManutencao.cbUsuarioMySql.Text, frmManutencao.cbSenhaMySql.Text)
        While d <= df
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If Me.ckbCdrs.Checked Then
                'Excluir CDRs
                MySQL_cmd(conn, "DROP TABLE cdrs_" & Format(d, "yyyyMMdd"))
                GravaLOG("Apagar Registro", "(cdrs_" & Format(d, "yyyyMMdd") & ") Data: " & Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            If Me.ckbX_Rota_Entrada.Checked Then
                'Excluir CDRs
                MySQL_cmd(conn, "DELETE FROM X_Rota_Entrada WHERE DATA='" & Format(d, "yyyy-MM-dd") & "'")
                GravaLOG("Apagar Registro", "(X_Rota_Entrada) Data: " & Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            If Me.ckbX_Rota_Saida.Checked Then
                MySQL_cmd(conn, "DELETE FROM X_Rota_Saida WHERE DATA='" & Format(d, "yyyy-MM-dd") & "'")
                GravaLOG("Apagar Registro", "(X_Rota_Saida) Data: " & Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            If Me.ckbX_Cliente_Originado.Checked Then
                MySQL_cmd(conn, "DELETE FROM X_Cliente_Originado WHERE DATA='" & Format(d, "yyyy-MM-dd") & "'")

                GravaLOG("Apagar Registro", "(X_Cliente_Originado) Data: " & Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            If Me.ckbX_Cliente_Destinado.Checked Then
                MySQL_cmd(conn, "DELETE FROM X_Cliente_Destinado WHERE DATA='" & Format(d, "yyyy-MM-dd") & "'")

                GravaLOG("Apagar Registro", "(X_Cliente_Destinado) Data: " & Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            If Me.ckbX_Grupo.Checked Then
                MySQL_cmd(conn, "DELETE FROM X_Grupo WHERE DATA='" & Format(d, "yyyy-MM-dd") & "'")

                GravaLOG("Apagar Registro", "(X_Grupo) Data: " & Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            d = d.AddDays(1)
        End While

        Me.RefreshCdrs()
        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("Concluído [Apagar Registros],")
    End Sub
    Private Sub RefreshCdrs()
        'Reload listview
        Dim tabela As New DataTable
        Dim criterioSQL As String

        criterioSQL = "SELECT TABLE_NAME AS TABELA, TABLE_ROWS AS REGISTROS " _
                    & "FROM INFORMATION_SCHEMA.TABLES AS Tabelas " _
                    & "WHERE TABLE_SCHEMA = '" & frmManutencao.txtBancoMySql.Text _
                    & "' AND TABLE_NAME like 'cdrs%'" _
                    & " ORDER BY TABLE_NAME"
        Try
            tabela = MySQL_Select(Conn, criterioSQL)

            Me.lvTabelasCdrs.Items.Clear()
            Dim LviItem As ListViewItem
            Dim LsiSubItem As ListViewItem.ListViewSubItem

            lvTabelasCdrs.FullRowSelect = True
            lvTabelasCdrs.View = View.Details
            If lvTabelasCdrs.Columns.Count <= 0 Then
                lvTabelasCdrs.Columns.Add("TABELA", 125, HorizontalAlignment.Left)
                lvTabelasCdrs.Columns.Add("Qtde.CDRs", 110, HorizontalAlignment.Right)
            End If
            lvTabelasCdrs.BeginUpdate()

            For Each dr As DataRow In tabela.Rows
                LviItem = lvTabelasCdrs.Items.Add(dr("TABELA").ToString)
                LsiSubItem = LviItem.SubItems.Add(dr("REGISTROS").ToString)
            Next
            lvTabelasCdrs.EndUpdate()
        Catch ex As Exception
            MessageBox.Show("ERRO " & ex.Message, "Lista tabelas CDRs")
        End Try


    End Sub

    Private Sub RefreshList()
        'Reload listview
        If Me.cbFiltro.Text.Substring(0, 3) = "Não" Then
            dt = MySQL_Select(Conn, "SELECT * FROM LogAtividade ORDER BY DATA DESC")
        Else
            dt = MySQL_Select(Conn, "SELECT * FROM LogAtividade WHERE date(DATA)='" & Me.cbFiltro.Text & "' ORDER BY DATA DESC")
        End If


        If Not (dt.Rows.Count > 0) Then
            Me.lvLogAtividade.Items.Clear()
            Exit Sub
        End If

        Dim LviItem As ListViewItem
        Dim LsiSubItem As ListViewItem.ListViewSubItem

        Me.lvLogAtividade.Items.Clear()

        lvLogAtividade.FullRowSelect = True
        lvLogAtividade.View = View.Details
        If lvLogAtividade.Columns.Count <= 0 Then
            lvLogAtividade.Columns.Add("DATA", 150, HorizontalAlignment.Left)
            lvLogAtividade.Columns.Add("GRUPO", 120, HorizontalAlignment.Left)
            lvLogAtividade.Columns.Add("DETALHE", 450, HorizontalAlignment.Left)
        End If

        lvLogAtividade.BeginUpdate()

        If (dt.Rows.Count > 0) Then
            For Each dr As DataRow In dt.Rows
                LviItem = lvLogAtividade.Items.Add(dr("DATA").ToString)
                LsiSubItem = LviItem.SubItems.Add(dr("GRUPO").ToString)
                LsiSubItem = LviItem.SubItems.Add(dr("DETALHE").ToString)
            Next
            lvLogAtividade.EndUpdate()
        End If
    End Sub

    Private Sub cbFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFiltro.SelectedIndexChanged
        Me.RefreshList()
    End Sub

    Private Sub frmApagaRegistros_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Text = "Apaga Registros - " & frmManutencao.cbBilhetador.Text
    End Sub

    Private Sub frmApagaRegistros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Open Conn
        'Conn = MySQL_Conn(frmManutencao.cbServidorMySql.Text, frmManutencao.txtBancoMySql.Text, frmManutencao.cbUsuarioMySql.Text, frmManutencao.cbSenhaMySql.Text)

        Dim i As Integer
        Dim data As Date
        data = Now()
        Me.cbFiltro.Text = Format(data, "yyyy-MM-dd")
        Me.cbFiltro.Items.Add("Não Filtrado")
        For i = 1 To 15
            Me.cbFiltro.Items.Add(Format(data, "yyyy-MM-dd"))
            data = Now.AddDays(-i)
        Next i

        Me.RefreshList()
        Me.RefreshCdrs()

    End Sub

End Class