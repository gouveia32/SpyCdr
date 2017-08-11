Option Explicit On

Public Class frmPPIs

    Dim DataId As Integer
    Dim dt As DataTable
    Dim dtTerminais As DataTable

    Private Sub frmClientes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Text = "PPIs - " & frmManutencao.cbBilhetador.Text
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Close recordset
        Ds_Close()
    End Sub

    Private Sub Ds_Close()
        If Not (dt Is Nothing) Then
            dt = Nothing
        End If
        If Not (DtTerminais Is Nothing) Then
            DtTerminais = Nothing
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Open Conn
        'Conn = MySQL_Conn(frmManutencao.cbServidorMySql.Text, frmManutencao.txtBancoMySql.Text, frmManutencao.cbUsuarioMySql.Text, frmManutencao.cbSenhaMySql.Text)

        'Add new table
        'MySQL_NewTable(Conn, "NewTable", "id int primary key auto_increment,name varchar(20),phone varchar(20)")

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT ID,PPI,RIN_E,RIN_S FROM ppis ORDER BY PPI")
        Me.RefreshList()
        If dt.Rows.Count > 0 Then
            Me.dgPPIs.Columns(0).Width = 55
            Me.dgPPIs.Columns(1).Width = 220
            Me.dgPPIs.Columns(2).Width = 90
            'Me.dgClientes.Columns(3).Width = 55
        End If

    End Sub
    Private Sub RefreshList()
        If Not (dt.Rows.Count > 0) Then
            Me.dgPPIs.Rows.Clear()
            Exit Sub
        End If
        Me.dgPPIs.DataSource = dt

        txtQtdeClientes.Text = Me.dgPPIs.Rows.Count
    End Sub
    Private Sub RefreshListTerminais()

        If Not (dtTerminais.Rows.Count > 0) Then
            Me.lvTerminais.Items.Clear()
            txtQtdeTerminais.Text = lvTerminais.Items.Count
            Exit Sub
        End If

        Dim LviItem As ListViewItem

        Me.lvTerminais.Items.Clear()

        lvTerminais.FullRowSelect = True
        lvTerminais.View = View.Details

        If lvTerminais.Columns.Count <= 0 Then lvTerminais.Columns.Add("prefixo", 90, HorizontalAlignment.Left)

        lvTerminais.BeginUpdate()

        If (dtTerminais.Rows.Count) Then
            For Each dr As DataRow In dtTerminais.Rows
                LviItem = lvTerminais.Items.Add(dr("prefixo").ToString)
            Next
            lvTerminais.EndUpdate()
        End If
        txtQtdeTerminais.Text = lvTerminais.Items.Count

    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        'If text fields are empty then exit sub
        If txtNovoPPI.Text = "" Then Exit Sub

        'Add new row
        MySQL_cmd(Conn, "INSERT INTO ppis (PPI, RIN_E, RIN_S) VALUES ('" & txtNovoPPI.Text & "','" & txtNovaR_ENT.Text & "'," & txtNovaR_SAI.Text & ")")

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT ID, PPI, RIN_E, RIN_S FROM ppis ORDER BY ppi")
        Me.RefreshList()

        Localiza("PPI", txtNovoPPI.Text.ToUpper)

        'Clear text fields
        txtNovoPPI.Text = ""
        txtNovaR_ENT.Text = ""
        txtNovaR_SAI.Text = ""

    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim id As String
        'If no row selectet then exit sub
        If txtCodigo.Text = "" Then Exit Sub

        id = Me.txtCodigo.Text
        'Update row
        MySQL_cmd(Conn, "UPDATE `ppis` SET id=" & txtCodigo.Text _
                                      & ",ppi='" & txtNome.Text _
                                      & "',RIN_E='" & txtR_ENT.Text _
                                      & "',RIN_S='" & txtR_SAI.Text _
                                      & "' WHERE id=" & txtCodigo.Text)
        'clear text fields
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtR_ENT.Text = ""
        txtR_SAI.Text = ""

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT ID,PPI,RIN_E,RIN_S FROM ppis ORDER BY PPI")
        Me.RefreshList()
        Localiza("id", id)

    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim id As String
        'If no row selected thenexit sub
        If txtCodigo.Text = "" Then Exit Sub

        id = Me.txtCodigo.Text
        'Apaga Terminais do Cliente
        MySQL_cmd(Conn, "DELETE FROM ppi_prefixo WHERE id=" & txtCodigo.Text)
        'Apaga Cliente
        MySQL_cmd(Conn, "DELETE FROM ppis WHERE id=" & txtCodigo.Text)

        'Clear text fields
        txtNome.Text = ""
        txtR_ENT.Text = ""

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT ID,PPI,RIN_E,RIN_S FROM ppis ORDER BY PPI")
        Me.RefreshList()
    End Sub

    Private Sub cmdApagarTerminal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApagarPrefixo.Click
        Dim x As Integer
        'Get the selected row Data Id
        For Each x In lvTerminais.SelectedIndices
            'Excluir Terminal
            MySQL_cmd(Conn, "DELETE FROM ppi_prefixo WHERE cod_ppi=" & txtCodigo.Text & " AND prefixo='" & lvTerminais.Items(x).Text & "'")
        Next
        dtTerminais = MySQL_Select(Conn, "SELECT PREFIXO FROm ppi_prefixo WHERE cod_ppi=" & txtCodigo.Text)
        RefreshListTerminais()
    End Sub

    Private Sub dgClientes_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPPIs.RowEnter
        'If no rows selected then exit sub
        If Me.dgPPIs.SelectedRows Is Nothing Then Exit Sub

        'Get the selected row Data Id
        DataId = dgPPIs.Item(0, e.RowIndex).Value

        'Do the select
        dt = MySQL_Select(Conn, "SELECT ID,PPI,RIN_E,RIN_S FROM ppis WHERE id=" & DataId)

        'Show selected data in the text fields
        txtCodigo.Text = dt.Rows(0).Item("ID").ToString
        txtNome.Text = dt.Rows(0).Item("PPI").ToString
        txtR_ENT.Text = dt.Rows(0).Item("RIN_E").ToString
        txtR_SAI.Text = dt.Rows(0).Item("RIN_S").ToString

        'Carrega Terminais
        dtTerminais = MySQL_Select(Conn, "SELECT PREFIXO FROm ppi_prefixo WHERE cod_ppi=" & txtCodigo.Text)
        Me.RefreshListTerminais()

    End Sub

    Private Sub dgClientes_CellContextMenuStripNeeded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventArgs) Handles dgPPIs.CellContextMenuStripNeeded
        If e.ColumnIndex < 0 Then Exit Sub
        Me.ContextMenuStrip1.Items.Clear()
        Me.ContextMenuStrip1.Items.Add("Localizar: " & dgPPIs.Columns(e.ColumnIndex).Name & " = '...'")
        Me.ContextMenuStrip1.Items(0).Name = "mnuLocalizar"
        Me.ContextMenuStrip1.Items(0).Image = My.Resources.Aussichten
        Me.ContextMenuStrip1.Items.Add("-")
        Me.ContextMenuStrip1.Items(1).Name = "mnuSeparador1"
        Me.ContextMenuStrip1.Items.Add("Fechar")
        Me.ContextMenuStrip1.Items(2).Name = "mnuFechar"
        Me.ContextMenuStrip1.Items(2).Image = My.Resources._EXIT


    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked

        Select Case e.ClickedItem.Name
            Case "mnuLocalizar"
                Dim filtroValor, filtro As String
                filtro = e.ClickedItem.Text.Substring(11, e.ClickedItem.Text.IndexOf("'") - 14)
                filtroValor = InputBox(filtro, "Digite o valor para Localizar:", "")
                If filtroValor <> "" Then
                    Localiza(filtro, filtroValor.ToUpper)
                End If
            Case "mnuFechar"
                Me.Close()
        End Select

    End Sub
    Private Sub Localiza(ByVal filtro As String, ByVal filtroValor As String)
        Dim i As Integer
        Dim txt As String

        dgPPIs.Rows(dgPPIs.CurrentCell.RowIndex).Selected = False
        For i = 0 To Me.dgPPIs.Rows.Count - 1
            txt = dgPPIs.Item(dgPPIs.Columns(filtro).Index, i).Value.ToString.ToUpper
            If txt.Contains(filtroValor) Then
                dgPPIs.Rows(i).Selected = True
                dgPPIs.CurrentCell = dgPPIs(0, i)
                Exit Sub
            End If
        Next
        MsgBox("Não encontrei: [" & filtroValor & "].")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim txt As String
        'Reload listview
        dtTerminais = MySQL_Select(Conn, "SELECT * FROM ppi_prefixo WHERE prefixo='" & txtLocalizar.Text & "'")
        If dtTerminais.Rows.Count > 0 Then
            Localiza("COD_PPI", dtTerminais.Rows(0).Item("COD_PPI"))
            For i = 0 To lvTerminais.Items.Count - 1
                txt = lvTerminais.Items(i).ToString.ToUpper
                If txt.Contains(txtLocalizar.Text) Then
                    lvTerminais.Items(i).Selected = True
                    lvTerminais.Focus()
                    Exit Sub
                End If
            Next
            'dt = MySQL_Select(Conn, "SELECT COD_CLI,CLIENTE,NR_CHAVE,VIP FROM clientes WHERE COD_CLI=" & dtTerminais.Rows(0).Item("COD_CLI"))
            'Me.RefreshList()
        Else
            MsgBox("Não foi encontrado este prefixo!")
        End If
    End Sub

    Private Sub cmdGeraNrIsolado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGeraNrIsolado.Click
        Dim id As String
        id = Me.txtCodigo.Text
        'Inserir Nr Isolado
        MySQL_cmd(Conn, "INSERT INTO ppi_prefixo (prefixo,COD_PPI) VALUES ('" & Me.txtNrIsolado.Text & "','" & txtCodigo.Text & "')")

        dtTerminais = MySQL_Select(Conn, "SELECT * FROM ppi_prefixo WHERE COD_PPI=" & txtCodigo.Text)
        RefreshListTerminais()

    End Sub
End Class