Public Class frmGrupos

    Dim DataId As String
    Dim dt As DataTable
    Dim dtTerminais As DataTable

    Private Sub frmGrupos_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Text = "Grupos - " & frmManutencao.cbBilhetador.Text
    End Sub

    Private Sub Ds_Close()
        If Not (dt Is Nothing) Then
            dt = Nothing
        End If
        If Not (dtTerminais Is Nothing) Then
            dtTerminais = Nothing
        End If
    End Sub

    Private Sub RefreshList()
        If Not (dt.Rows.Count > 0) Then
            Me.dgGrupos.Rows.Clear()
            Exit Sub
        End If
        Me.dgGrupos.DataSource = dt

        txtQtdeClientes.Text = Me.dgGrupos.Rows.Count
    End Sub
    Private Sub cmdAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddNew.Click
        'If text fields are empty then exit sub
        If Me.txtDestino.Text = "" Then Exit Sub

        'Add new row
        MySQL_cmd(Conn, "INSERT INTO grupos (GRUPO, MASCARA_ASS_A,MASCARA_CSP,MASCARA_ASS_B,MASCARA_ROTA_E,MASCARA_ROTA_S) VALUES('" & txtNovoGrupo.Text & "','" & txtNovaMascaraAssA.Text & "','" & txtNovaMascaraCSP.Text & "','" & txtNovaMascaraAssB.Text & "','" & txtNovaMascaraRotaE.Text & "','" & txtNovaMascaraRotaS.Text & "')")

        'Clear text fields
        txtNovoGrupo.Text = ""
        txtNovaMascaraAssA.Text = ""
        txtNovaMascaraCSP.Text = ""
        txtNovaMascaraAssB.Text = ""
        txtNovaMascaraRotaE.Text = ""
        txtNovaMascaraRotaS.Text = ""

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT * FROM grupos ORDER BY GRUPO, MASCARA_ASS_A,MASCARA_CSP,MASCARA_ASS_B,MASCARA_ROTA_E,MASCARA_ROTA_S")
        Me.RefreshList()
    End Sub
    Private Sub Localiza(ByVal filtro As String, ByVal filtroValor As String)
        Dim i As Integer
        Dim txt As String

        dgGrupos.Rows(dgGrupos.CurrentCell.RowIndex).Selected = False
        For i = 0 To Me.dgGrupos.Rows.Count - 1
            txt = dgGrupos.Item(dgGrupos.Columns(filtro).Index, i).Value.ToString.ToUpper
            If txt.Contains(filtroValor) Then
                dgGrupos.Rows(i).Selected = True
                dgGrupos.CurrentCell = dgGrupos(0, i)
                Exit Sub
            End If
        Next
        MsgBox("Não encontrei: [" & filtroValor & "].")
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim id As String
        'If no row selectet then exit sub
        If txtDestino.Text = "" Then Exit Sub

        id = Me.txtID.Text
        'Update row
        MySQL_cmd(Conn, "UPDATE `grupos` SET GRUPO='" & txtDestino.Text _
                                     & "',MASCARA_ASS_A='" & txtMascaraAssA.Text _
                                     & "',MASCARA_CSP='" & txtMascaraCSP.Text _
                                     & "',MASCARA_ASS_B='" & txtMascaraAssB.Text _
                                     & "',MASCARA_ROTA_E='" & txtMascaraRotaE.Text _
                                     & "',MASCARA_ROTA_S='" & txtMascaraRotaS.Text _
                                     & "' WHERE ID='" & txtID.Text & "'")
        'clear text fields
        txtDestino.Text = ""
        txtMascaraAssA.Text = ""

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT * FROM grupos ORDER BY GRUPO, MASCARA_ASS_A,MASCARA_CSP,MASCARA_ASS_B,MASCARA_ROTA_E,MASCARA_ROTA_S")
        Me.RefreshList()
        Localiza("ID", id)

    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim id As String
        'If no row selected thenexit sub
        If txtDestino.Text = "" Then Exit Sub

        id = Me.txtID.Text
        'Apaga Cliente
        MySQL_cmd(Conn, "DELETE FROM grupos WHERE ID='" & txtID.Text & "'")

        'Clear text fields
        txtDestino.Text = ""
        txtMascaraAssA.Text = ""
        txtMascaraCSP.Text = ""
        txtMascaraAssB.Text = ""
        txtMascaraRotaE.Text = ""
        txtMascaraRotaS.Text = ""

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT * FROM grupos ORDER BY GRUPO, MASCARA_ASS_A,MASCARA_CSP,MASCARA_ASS_B,MASCARA_ROTA_E,MASCARA_ROTA_S")
        Me.RefreshList()
    End Sub

    Private Sub dgGrupos_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGrupos.RowEnter
        'If no rows selected then exit sub
        If Me.dgGrupos.SelectedRows Is Nothing Then Exit Sub

        'Get the selected row Data Id
        DataId = dgGrupos.Item(0, e.RowIndex).Value

        'Do the select
        dt = MySQL_Select(Conn, "SELECT * FROM grupos WHERE ID='" & DataId & "'")

        'Show selected data in the text fields
        txtID.Text = dt.Rows(0).Item("ID").ToString
        txtDestino.Text = dt.Rows(0).Item("GRUPO").ToString
        txtMascaraAssA.Text = dt.Rows(0).Item("MASCARA_ASS_A").ToString
        txtMascaraCSP.Text = dt.Rows(0).Item("MASCARA_CSP").ToString
        txtMascaraAssB.Text = dt.Rows(0).Item("MASCARA_ASS_B").ToString
        txtMascaraRotaE.Text = dt.Rows(0).Item("MASCARA_ROTA_E").ToString
        txtMascaraRotaS.Text = dt.Rows(0).Item("MASCARA_ROTA_S").ToString

    End Sub

    Private Sub frmGrupos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Close recordset
        Ds_Close()
    End Sub

    Private Sub frmGrupos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case frmManutencao.cbTipoCentral.Text
            Case "E"
                lblAdRota_E.Text = "RIN_E"
                lblAdRota_S.Text = "RIN_S"
                lblAltRota_E.Text = "RIN_E"
                lblAltRota_S.Text = "RIN_S"
            Case "H"
                lblAdRota_E.Text = "TG_E"
                lblAdRota_S.Text = "TG_S"
                lblAltRota_E.Text = "TG_E"
                lblAltRota_S.Text = "TG_S"
            Case "N"
                lblAdRota_E.Text = "ROTA_E"
                lblAdRota_S.Text = "ROTA_S"
                lblAltRota_E.Text = "ROTA_E"
                lblAltRota_S.Text = "ROTA_S"
        End Select
        'Open Conn
        'Conn = MySQL_Conn(frmManutencao.cbServidorMySql.Text, frmManutencao.txtBancoMySql.Text, frmManutencao.cbUsuarioMySql.Text, frmManutencao.cbSenhaMySql.Text)

        'Add new table
        'MySQL_NewTable(Conn, "NewTable", "id int primary key auto_increment,name varchar(20),phone varchar(20)")

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT * FROM grupos ORDER BY GRUPO, MASCARA_ASS_A,MASCARA_CSP,MASCARA_ASS_B,MASCARA_ROTA_E,MASCARA_ROTA_S")
        Me.RefreshList()
        If dt.Rows.Count > 0 Then
            Me.dgGrupos.Columns(0).Width = 35
            Me.dgGrupos.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Me.dgGrupos.Columns(1).Width = 110
            Me.dgGrupos.Columns(2).Width = 100
            Me.dgGrupos.Columns(3).Width = 100
            Me.dgGrupos.Columns(4).Width = 100
            Me.dgGrupos.Columns(5).Width = 110
            Me.dgGrupos.Columns(6).Width = 110
        End If
    End Sub
End Class