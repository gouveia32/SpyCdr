Public Class frmEventos
    Dim DataId As String
    Dim dt As DataTable
    Dim dtTerminais As DataTable

    Private Sub frmEventos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Text = "Eventos - " & frmManutencao.cbBilhetador.Text
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
        dt = MySQL_Select(Conn, "SELECT * FROM eventos ORDER BY DATA")
        Me.RefreshList()
        If dt.Rows.Count > 0 Then SelRegistro(dt.Rows(0).Item("DATA"))

    End Sub
    Private Sub RefreshList()
        If Not (dt.Rows.Count > 0) Then
            Me.lvEventos.Items.Clear()
            Exit Sub
        End If

        Dim LviItem As ListViewItem
        Dim LsiSubItem As ListViewItem.ListViewSubItem

        Me.lvEventos.Items.Clear()

        lvEventos.FullRowSelect = True
        lvEventos.View = View.Details
        If lvEventos.Columns.Count <= 0 Then
            lvEventos.Columns.Add("DATA", 120, HorizontalAlignment.Left)
            lvEventos.Columns.Add("EVENTO", 400, HorizontalAlignment.Left)
        End If

        lvEventos.BeginUpdate()

        If (dt.Rows.Count > 0) Then
            For Each dr As DataRow In dt.Rows
                LviItem = lvEventos.Items.Add(Format(dr("DATA"), "yyyy-MM-dd HH:mm:ss"))
                LsiSubItem = LviItem.SubItems.Add(dr("EVENTO").ToString)
            Next
            lvEventos.EndUpdate()
        End If
        txtQtdeEventos.Text = lvEventos.Items.Count

    End Sub
    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        'If text fields are empty then exit sub
        If DateTimePickerNova.Text = "" Then Exit Sub

        'Add new row
        MySQL_cmd(Conn, "INSERT INTO eventos (DATA, TIPO, EVENTO) VALUES('" & DateTimePickerNova.Text & "','" & txtNovoTipo.Text & "','" & txtNovoEvento.Text & "')")

        'Clear text fields
        txtNovoEvento.Text = ""
        DateTimePickerNova.Text = ""

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT * FROM eventos ORDER BY DATA")
        Me.RefreshList()
    End Sub
    Private Sub SelRegistro(ByVal id As String)
        Dim l As ListViewItem

        'Get the selected row Data Id
        For Each l In lvEventos.Items
            If l.Text = id Then
                lvEventos.Items(l.Index).Selected = True
                lvEventos.Select()
                Exit Sub
            End If
        Next

    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim id As String
        'If no row selectet then exit sub
        If txtEvento.Text = "" Then Exit Sub

        id = Me.txtEvento.Text
        'Update row
        MySQL_cmd(Conn, "UPDATE `eventos` SET DATA='" & DateTimePicker.Text _
                                      & "',TIPO='" & txtTipo.Text _
                                      & "',EVENTO='" & txtEvento.Text _
                                      & "' WHERE DATA='" & DateTimePicker.Text & "'")

        'clear text fields
        DateTimePicker.Text = ""
        txtEvento.Text = ""
        DateTimePicker.Text = ""

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT * FROM eventos ORDER BY DATA")
        Me.RefreshList()
        SelRegistro(id)

    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim id As String
        'If no row selected thenexit sub
        If DateTimePicker.Text = "" Then Exit Sub

        id = Me.DateTimePicker.Text
        'Apaga Cliente
        MySQL_cmd(Conn, "DELETE FROM eventos WHERE DATA='" & DateTimePicker.Text & "'")

        'Clear text fields
        txtEvento.Text = ""
        DateTimePicker.Text = ""

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT * FROM eventos ORDER BY DATA")
        Me.RefreshList()
        SelRegistro(id)
    End Sub

    Private Sub lvEventos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvEventos.SelectedIndexChanged
        'If no rows selected then exit sub
        If Me.lvEventos.SelectedItems Is Nothing Then Exit Sub

        Dim x As Integer

        'Get the selected row Data Id
        For Each x In lvEventos.SelectedIndices
            DataId = "'" & Format(CDate(lvEventos.Items(x).Text), "yyyy-MM-dd HH:mm:ss") & "'"
        Next

        'Do the select
        dt = MySQL_Select(Conn, "SELECT * FROM eventos WHERE DATA=" & DataId & " ORDER BY DATA")

        If dt.Rows.Count > 0 Then
            'Show selected data in the text fields
            Me.DateTimePicker.Text = dt.Rows(0).Item("DATA").ToString
            Me.txtTipo.Text = dt.Rows(0).Item("TIPO").ToString
            Me.txtEvento.Text = dt.Rows(0).Item("EVENTO").ToString

        End If
    End Sub
End Class