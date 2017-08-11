Option Explicit On

Public Class frmClientes

    Dim DataId As Integer
    Dim dt As DataTable
    Dim dtTerminais As DataTable

    Private Sub frmClientes_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Text = "Clientes - " & frmManutencao.cbBilhetador.Text
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
        'Add new table
        'MySQL_NewTable(Conn, "NewTable", "id int primary key auto_increment,name varchar(20),phone varchar(20)")

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT COD_CLI,CLIENTE,NR_CHAVE FROM clientes ORDER BY CLIENTE")
        Me.RefreshList()
        If dt.Rows.Count > 0 Then
            Me.dgClientes.Columns(0).Width = 55
            Me.dgClientes.Columns(1).Width = 220
            Me.dgClientes.Columns(2).Width = 90
            'Me.dgClientes.Columns(3).Width = 55
        End If

    End Sub
    Private Sub RefreshList()
        If Not (dt.Rows.Count > 0) Then
            Me.dgClientes.Rows.Clear()
            Exit Sub
        End If
        Me.dgClientes.DataSource = dt

        txtQtdeClientes.Text = Me.dgClientes.Rows.Count
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

        If lvTerminais.Columns.Count <= 0 Then lvTerminais.Columns.Add("TERMINAL", 90, HorizontalAlignment.Left)

        lvTerminais.BeginUpdate()

        If (dtTerminais.Rows.Count) Then
            For Each dr As DataRow In dtTerminais.Rows
                LviItem = lvTerminais.Items.Add(dr("TERMINAL").ToString)
            Next
            lvTerminais.EndUpdate()
        End If
        txtQtdeTerminais.Text = lvTerminais.Items.Count

    End Sub

    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        'If text fields are empty then exit sub
        If txtNovoNome.Text = "" And txtNovoFabricante.Text = "" Then Exit Sub

        'Add new row
        MySQL_cmd(Conn, "INSERT INTO clientes (CLIENTE, NR_CHAVE, VIP) VALUES ('" & txtNovoNome.Text & "','" & txtNovoFabricante.Text & "'," & ckbNovoVIP.Checked & ")")

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT COD_CLI,CLIENTE,NR_CHAVE FROM clientes ORDER BY CLIENTE")
        Me.RefreshList()

        Localiza("CLIENTE", txtNovoNome.Text.ToUpper)

        'Clear text fields
        txtNovoNome.Text = ""
        txtNovoFabricante.Text = ""

    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim id As String
        'If no row selectet then exit sub
        If txtCodigo.Text = "" Then Exit Sub

        id = Me.txtCodigo.Text
        'Update row
        MySQL_cmd(Conn, "UPDATE `clientes` SET COD_CLI=" & txtCodigo.Text _
                                      & ",CLIENTE='" & txtNome.Text _
                                      & "',NR_CHAVE='" & txtFabricante.Text _
                                      & "',VIP=" & ckbVIP.Checked _
                                      & " WHERE COD_CLI=" & txtCodigo.Text)
        'clear text fields
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtFabricante.Text = ""
        ckbVIP.Checked = False

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT COD_CLI,CLIENTE,NR_CHAVE FROM clientes ORDER BY CLIENTE")
        Me.RefreshList()
        Localiza("COD_CLI", id)

    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim id As String
        'If no row selected thenexit sub
        If txtCodigo.Text = "" Then Exit Sub

        id = Me.txtCodigo.Text
        'Apaga Terminais do Cliente
        MySQL_cmd(Conn, "DELETE FROM cliente_terminal WHERE COD_CLI=" & txtCodigo.Text)
        'Apaga Cliente
        MySQL_cmd(Conn, "DELETE FROM clientes WHERE COD_CLI=" & txtCodigo.Text)

        'Clear text fields
        txtNome.Text = ""
        txtFabricante.Text = ""

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT COD_CLI,CLIENTE,NR_CHAVE FROM clientes ORDER BY CLIENTE")
        Me.RefreshList()
    End Sub

    Private Sub cmdGeraFaixa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGeraFaixa.Click
        Dim id As String
        Dim i, TermI, TermF As Double

        id = Me.txtCodigo.Text

        TermI = Val(Me.txtInicial.Text)
        TermF = Val(Me.txtFinal.Text)
        If (TermF < TermI) Then
            MsgBox("Erro! O [Nr Final] deve ser maior do que o [Nr Inicial].", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        If (TermF - TermI) > 500 Then
            If MsgBox("Advertência! A quantidade de Terminais GRANDE. Confirma?.", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        'Apaga todos
        'MySQL_Delete(Conn, "cliente_terminal", "COD_CLI", txtCodigo.Text)

        For i = TermI To TermF
            'Adiciona Terminal
            MySQL_cmd(Conn, "INSERT INTO cliente_terminal (TERMINAL,COD_CLI) VALUES ('" & Str(i).Trim & "','" & txtCodigo.Text & "')")
        Next i
        dtTerminais = MySQL_Select(Conn, "SELECT * FROM cliente_terminal WHERE COD_CLI=" & txtCodigo.Text)
        RefreshListTerminais()
    End Sub
    Private Sub cmdGeraNrIsolado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGeraNrIsolado.Click
        Dim id As String
        id = Me.txtCodigo.Text
        'Inserir Nr Isolado
        MySQL_cmd(Conn, "INSERT INTO cliente_terminal (TERMINAL,COD_CLI) VALUES ('" & Me.txtNrIsolado.Text & "','" & txtCodigo.Text & "')")

        dtTerminais = MySQL_Select(Conn, "SELECT * FROM cliente_terminal WHERE COD_CLI=" & txtCodigo.Text)
        RefreshListTerminais()
    End Sub

    Private Sub cmdApagarTerminal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApagarTerminal.Click
        Dim x As Integer
        'Get the selected row Data Id
        For Each x In lvTerminais.SelectedIndices
            'Excluir Terminal
            MySQL_cmd(Conn, "DELETE FROM cliente_terminal WHERE COD_CLI=" & txtCodigo.Text & " AND TERMINAL='" & lvTerminais.Items(x).Text & "'")
        Next
        dtTerminais = MySQL_Select(Conn, "SELECT * FROM cliente_terminal WHERE COD_CLI=" & txtCodigo.Text)
        RefreshListTerminais()
    End Sub

    Private Sub dgClientes_RowEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgClientes.RowEnter
        'If no rows selected then exit sub
        If Me.dgClientes.SelectedRows Is Nothing Then Exit Sub

        'Get the selected row Data Id
        DataId = dgClientes.Item(0, e.RowIndex).Value

        'Do the select
        dt = MySQL_Select(Conn, "SELECT COD_CLI,CLIENTE,NR_CHAVE,VIP FROM clientes WHERE COD_CLI=" & DataId)

        'Show selected data in the text fields
        txtCodigo.Text = dt.Rows(0).Item("COD_CLI").ToString
        txtNome.Text = dt.Rows(0).Item("CLIENTE").ToString
        txtFabricante.Text = dt.Rows(0).Item("NR_CHAVE").ToString
        If dt.Rows(0).Item("VIP") Then
            Me.ckbVIP.Checked = True
        Else
            Me.ckbVIP.Checked = False
        End If

        'Carrega Terminais
        dtTerminais = MySQL_Select(Conn, "SELECT * FROM cliente_terminal WHERE COD_CLI=" & txtCodigo.Text)
        Me.RefreshListTerminais()

    End Sub

    Private Sub dgClientes_CellContextMenuStripNeeded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventArgs) Handles dgClientes.CellContextMenuStripNeeded
        If e.ColumnIndex < 0 Then Exit Sub
        Me.ContextMenuStrip1.Items.Clear()
        Me.ContextMenuStrip1.Items.Add("Localizar: " & dgClientes.Columns(e.ColumnIndex).Name & " = '...'")
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

        dgClientes.Rows(dgClientes.CurrentCell.RowIndex).Selected = False
        For i = 0 To Me.dgClientes.Rows.Count - 1
            txt = dgClientes.Item(dgClientes.Columns(filtro).Index, i).Value.ToString.ToUpper
            If txt.Contains(filtroValor) Then
                dgClientes.Rows(i).Selected = True
                dgClientes.CurrentCell = dgClientes(0, i)
                Exit Sub
            End If
        Next
        MsgBox("Não encontrei: [" & filtroValor & "].")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim txt As String
        'Reload listview
        dtTerminais = MySQL_Select(Conn, "SELECT * FROM cliente_terminal WHERE terminal='" & txtLocalizar.Text & "'")
        If dtTerminais.Rows.Count > 0 Then
            Localiza("COD_CLI", dtTerminais.Rows(0).Item("COD_CLI"))
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
            MsgBox("Não foi encontrado este terminal!")
        End If
    End Sub

End Class