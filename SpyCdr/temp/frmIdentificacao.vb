Partial Public Class frmIdentificacao
    Inherits Form

    Dim dt As DataTable

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        dt = MySQL_Select(Conn, "SELECT * FROM usuarios WHERE login='" & Me.txtUsuario.Text & "'")
        If dt.Rows.Count > 0 Then

            Me.ErrorProvider1.SetError(txtUsuario, "")
            txtSenha.Focus()
            If dt.Rows(0).Item("senha") <> Me.txtSenha.Text Then
                ErrorProvider1.SetError(txtSenha, "A senha não confere!")
                My.Settings.ConectadoBD = False
            Else
                My.Settings.Nivel = dt.Rows(0).Item("nivel")
                My.Settings.Form_Incicial = dt.Rows(0).Item("form_inicial")
                Me.ErrorProvider1.SetError(txtSenha, "")
                My.Settings.ConectadoBD = True
                My.Settings.Usuario = txtUsuario.Text
                frmPrincipal.lblUsuario.Text = txtUsuario.Text
                'DevExpress.XtraBars.Demos.RibbonSimplePad.frmPrincipal. .Text = dt.Rows(0).Item("login")

                'Grava dados do usuario no registro
                Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\gf")
                Try
                    key.SetValue("Usuario", txtUsuario.Text)
                Finally
                    key.Close()
                End Try

                'frmPrincipal()

                Me.Visible = False
            End If
        Else
            Me.ErrorProvider1.SetError(txtUsuario, "nome não cadastrado!")
        End If

    End Sub
    Private Sub ConectarBD()
        My.Settings.ConnectionString = "Server=" & tbServidor.Text & _
                               ";Database=ccb;Uid=" & tbUsuario.Text & _
                               ";Pwd=" & tbSenha.Text
        Conn = MySQL_Conn()
        If My.Settings.ConectadoMySql Then
            txtUsuario.Enabled = True
            txtSenha.Enabled = True
            expandablePanel1.Expanded = False
            lblTitulo.BackColor = Color.Green
            Me.AcceptButton = btnOK
        Else
            txtUsuario.Enabled = False
            txtSenha.Enabled = False
            expandablePanel1.Expanded = True

            lblTitulo.BackColor = Color.Red

        End If
        'Grava dados do servidor no registro
        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\gf")
        Try
            key.SetValue("MySqlServidor", tbServidor.Text)
            key.SetValue("MySqlUsuario", tbUsuario.Text)
            key.SetValue("MySqlSenha", tbSenha.Text)

        Finally
            key.Close()
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        My.Settings.ConectadoBD = False
        Me.Close()
    End Sub

    Private Sub txtUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = System.Convert.ToChar(13) Then
            ConectarBD()
        End If
    End Sub

    Private Sub txtSenha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSenha.KeyPress
        If e.KeyChar = System.Convert.ToChar(13) Then
            ConectarBD()
        End If
    End Sub

    Private Sub tbServidor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbServidor.KeyPress
        If e.KeyChar = System.Convert.ToChar(13) Then
            ConectarBD()
        End If
    End Sub

    Private Sub tbUsuario_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbUsuario.KeyPress
        If e.KeyChar = System.Convert.ToChar(13) Then
            ConectarBD()
        End If
    End Sub

    Private Sub tbSenha_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbSenha.KeyPress
        If e.KeyChar = System.Convert.ToChar(13) Then
            ConectarBD()
        End If
    End Sub

    Private Sub frmIdentificacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Center


        My.Settings.ConectadoMySql = False
        Me.Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        'Recupera dados do servidor no registro
        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\gf")
        Try
            tbServidor.Text = key.GetValue("MySqlServidor", "localhost")
            tbUsuario.Text = key.GetValue("MySqlUsuario", "root")
            tbSenha.Text = key.GetValue("MySqlSenha", "")
        Finally
            key.Close()
        End Try
        ConectarBD()
    End Sub

    Private Sub btnConectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConectar.Click
        ConectarBD()

    End Sub
End Class
