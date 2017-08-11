<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracao
    Inherits frmModelo

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtServidorMySql = New System.Windows.Forms.TextBox
        Me.txtUsuarioMySql = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSenhaMySql = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtBancoMySql = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPastaDeTrabalho = New System.Windows.Forms.TextBox
        Me.btnCriarTabelas = New System.Windows.Forms.Button
        Me.lstMsg = New System.Windows.Forms.ListBox
        Me.cbBilhetador = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtPastaRemotaFTP = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtSenhaFTP = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtUsuarioFTP = New System.Windows.Forms.TextBox
        Me.txtServidorFTP = New System.Windows.Forms.TextBox
        Me.cbBilDumpShadow = New System.Windows.Forms.ComboBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtBancoMySql)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSenhaMySql)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtUsuarioMySql)
        Me.GroupBox1.Controls.Add(Me.txtServidorMySql)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Size = New System.Drawing.Size(186, 168)
        Me.GroupBox1.Text = "MySQL"
        '
        'txtServidorMySql
        '
        Me.txtServidorMySql.Location = New System.Drawing.Point(80, 29)
        Me.txtServidorMySql.Name = "txtServidorMySql"
        Me.txtServidorMySql.Size = New System.Drawing.Size(100, 22)
        Me.txtServidorMySql.TabIndex = 0
        Me.txtServidorMySql.Text = "10.14.83.164"
        '
        'txtUsuarioMySql
        '
        Me.txtUsuarioMySql.Location = New System.Drawing.Point(80, 57)
        Me.txtUsuarioMySql.Name = "txtUsuarioMySql"
        Me.txtUsuarioMySql.Size = New System.Drawing.Size(100, 22)
        Me.txtUsuarioMySql.TabIndex = 1
        Me.txtUsuarioMySql.Text = "root"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Servidor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Usuário:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Senha:"
        '
        'txtSenhaMySql
        '
        Me.txtSenhaMySql.Location = New System.Drawing.Point(80, 85)
        Me.txtSenhaMySql.Name = "txtSenhaMySql"
        Me.txtSenhaMySql.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaMySql.Size = New System.Drawing.Size(100, 22)
        Me.txtSenhaMySql.TabIndex = 5
        Me.txtSenhaMySql.Text = "ebtaju"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(18, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Banco:"
        '
        'txtBancoMySql
        '
        Me.txtBancoMySql.Location = New System.Drawing.Point(80, 113)
        Me.txtBancoMySql.Name = "txtBancoMySql"
        Me.txtBancoMySql.Size = New System.Drawing.Size(100, 22)
        Me.txtBancoMySql.TabIndex = 9
        Me.txtBancoMySql.Text = "SpyCdr"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 14)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Pasta de Trabalho:"
        '
        'txtPastaDeTrabalho
        '
        Me.txtPastaDeTrabalho.Location = New System.Drawing.Point(145, 200)
        Me.txtPastaDeTrabalho.Name = "txtPastaDeTrabalho"
        Me.txtPastaDeTrabalho.Size = New System.Drawing.Size(100, 22)
        Me.txtPastaDeTrabalho.TabIndex = 11
        Me.txtPastaDeTrabalho.Text = "c:\temp"
        '
        'btnCriarTabelas
        '
        Me.btnCriarTabelas.Location = New System.Drawing.Point(21, 233)
        Me.btnCriarTabelas.Name = "btnCriarTabelas"
        Me.btnCriarTabelas.Size = New System.Drawing.Size(100, 23)
        Me.btnCriarTabelas.TabIndex = 13
        Me.btnCriarTabelas.Text = "Criar Tabelas"
        Me.btnCriarTabelas.UseVisualStyleBackColor = True
        '
        'lstMsg
        '
        Me.lstMsg.FormattingEnabled = True
        Me.lstMsg.ItemHeight = 14
        Me.lstMsg.Location = New System.Drawing.Point(21, 262)
        Me.lstMsg.Name = "lstMsg"
        Me.lstMsg.Size = New System.Drawing.Size(768, 186)
        Me.lstMsg.TabIndex = 14
        '
        'cbBilhetador
        '
        Me.cbBilhetador.FormattingEnabled = True
        Me.cbBilhetador.Location = New System.Drawing.Point(345, 200)
        Me.cbBilhetador.Name = "cbBilhetador"
        Me.cbBilhetador.Size = New System.Drawing.Size(63, 22)
        Me.cbBilhetador.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(274, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 14)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Bilhetador:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtPastaRemotaFTP)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtSenhaFTP)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtUsuarioFTP)
        Me.GroupBox2.Controls.Add(Me.txtServidorFTP)
        Me.GroupBox2.Location = New System.Drawing.Point(226, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 168)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FTP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 14)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Pasta Remota"
        '
        'txtPastaRemotaFTP
        '
        Me.txtPastaRemotaFTP.Location = New System.Drawing.Point(104, 111)
        Me.txtPastaRemotaFTP.Name = "txtPastaRemotaFTP"
        Me.txtPastaRemotaFTP.Size = New System.Drawing.Size(200, 22)
        Me.txtPastaRemotaFTP.TabIndex = 17
        Me.txtPastaRemotaFTP.Text = "/bmp/coletados/AJUB/"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 14)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Senha:"
        '
        'txtSenhaFTP
        '
        Me.txtSenhaFTP.Location = New System.Drawing.Point(104, 80)
        Me.txtSenhaFTP.Name = "txtSenhaFTP"
        Me.txtSenhaFTP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenhaFTP.Size = New System.Drawing.Size(100, 22)
        Me.txtSenhaFTP.TabIndex = 15
        Me.txtSenhaFTP.Text = "ebtaju"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 14)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Usuário:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(36, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 14)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Servidor:"
        '
        'txtUsuarioFTP
        '
        Me.txtUsuarioFTP.Location = New System.Drawing.Point(104, 52)
        Me.txtUsuarioFTP.Name = "txtUsuarioFTP"
        Me.txtUsuarioFTP.Size = New System.Drawing.Size(100, 22)
        Me.txtUsuarioFTP.TabIndex = 12
        Me.txtUsuarioFTP.Text = "root"
        '
        'txtServidorFTP
        '
        Me.txtServidorFTP.Location = New System.Drawing.Point(104, 24)
        Me.txtServidorFTP.Name = "txtServidorFTP"
        Me.txtServidorFTP.Size = New System.Drawing.Size(100, 22)
        Me.txtServidorFTP.TabIndex = 11
        Me.txtServidorFTP.Text = "10.14.83.164"
        '
        'cbBilDumpShadow
        '
        Me.cbBilDumpShadow.FormattingEnabled = True
        Me.cbBilDumpShadow.Location = New System.Drawing.Point(414, 200)
        Me.cbBilDumpShadow.Name = "cbBilDumpShadow"
        Me.cbBilDumpShadow.Size = New System.Drawing.Size(63, 22)
        Me.cbBilDumpShadow.TabIndex = 18
        Me.cbBilDumpShadow.Visible = False
        '
        'frmConfiguracao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 472)
        Me.Controls.Add(Me.cbBilDumpShadow)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cbBilhetador)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lstMsg)
        Me.Controls.Add(Me.btnCriarTabelas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPastaDeTrabalho)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmConfiguracao"
        Me.Text = "Configuracao"
        Me.Controls.SetChildIndex(Me.txtPastaDeTrabalho, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.btnCriarTabelas, 0)
        Me.Controls.SetChildIndex(Me.lstMsg, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.cbBilhetador, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.cbBilDumpShadow, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtUsuarioMySql As System.Windows.Forms.TextBox
    Public WithEvents txtServidorMySql As System.Windows.Forms.TextBox
    Public WithEvents txtSenhaMySql As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents txtBancoMySql As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents txtPastaDeTrabalho As System.Windows.Forms.TextBox
    Friend WithEvents btnCriarTabelas As System.Windows.Forms.Button
    Friend WithEvents lstMsg As System.Windows.Forms.ListBox
    Friend WithEvents cbBilhetador As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents txtSenhaFTP As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents txtUsuarioFTP As System.Windows.Forms.TextBox
    Public WithEvents txtServidorFTP As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txtPastaRemotaFTP As System.Windows.Forms.TextBox
    Friend WithEvents cbBilDumpShadow As System.Windows.Forms.ComboBox
End Class
