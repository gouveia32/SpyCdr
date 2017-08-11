<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIdentificacao
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIdentificacao))
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.tbServidor = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.expandablePanel1 = New DevComponents.DotNetBar.ExpandablePanel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.tbSenha = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.tbUsuario = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.Version = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.expandablePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCopyright
        '
        resources.ApplyResources(Me.lblCopyright, "lblCopyright")
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.ErrorProvider1.SetError(Me.lblCopyright, resources.GetString("lblCopyright.Error"))
        Me.lblCopyright.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ErrorProvider1.SetIconAlignment(Me.lblCopyright, CType(resources.GetObject("lblCopyright.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.lblCopyright, CType(resources.GetObject("lblCopyright.IconPadding"), Integer))
        Me.lblCopyright.Name = "lblCopyright"
        '
        'Cancel
        '
        resources.ApplyResources(Me.Cancel, "Cancel")
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ErrorProvider1.SetError(Me.Cancel, resources.GetString("Cancel.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.Cancel, CType(resources.GetObject("Cancel.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Cancel, CType(resources.GetObject("Cancel.IconPadding"), Integer))
        Me.Cancel.Name = "Cancel"
        Me.Cancel.TabStop = False
        '
        'btnOK
        '
        resources.ApplyResources(Me.btnOK, "btnOK")
        Me.ErrorProvider1.SetError(Me.btnOK, resources.GetString("btnOK.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.btnOK, CType(resources.GetObject("btnOK.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.btnOK, CType(resources.GetObject("btnOK.IconPadding"), Integer))
        Me.btnOK.Name = "btnOK"
        Me.btnOK.TabStop = False
        '
        'txtSenha
        '
        resources.ApplyResources(Me.txtSenha, "txtSenha")
        Me.ErrorProvider1.SetError(Me.txtSenha, resources.GetString("txtSenha.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.txtSenha, CType(resources.GetObject("txtSenha.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.txtSenha, CType(resources.GetObject("txtSenha.IconPadding"), Integer))
        Me.txtSenha.Name = "txtSenha"
        '
        'LabelX3
        '
        resources.ApplyResources(Me.LabelX3, "LabelX3")
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ErrorProvider1.SetError(Me.LabelX3, resources.GetString("LabelX3.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.LabelX3, CType(resources.GetObject("LabelX3.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.LabelX3, CType(resources.GetObject("LabelX3.IconPadding"), Integer))
        Me.LabelX3.Name = "LabelX3"
        '
        'txtUsuario
        '
        resources.ApplyResources(Me.txtUsuario, "txtUsuario")
        Me.ErrorProvider1.SetError(Me.txtUsuario, resources.GetString("txtUsuario.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.txtUsuario, CType(resources.GetObject("txtUsuario.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.txtUsuario, CType(resources.GetObject("txtUsuario.IconPadding"), Integer))
        Me.txtUsuario.Name = "txtUsuario"
        '
        'PasswordLabel
        '
        resources.ApplyResources(Me.PasswordLabel, "PasswordLabel")
        Me.PasswordLabel.BackColor = System.Drawing.Color.Transparent
        Me.ErrorProvider1.SetError(Me.PasswordLabel, resources.GetString("PasswordLabel.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.PasswordLabel, CType(resources.GetObject("PasswordLabel.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.PasswordLabel, CType(resources.GetObject("PasswordLabel.IconPadding"), Integer))
        Me.PasswordLabel.Name = "PasswordLabel"
        '
        'UsernameLabel
        '
        resources.ApplyResources(Me.UsernameLabel, "UsernameLabel")
        Me.UsernameLabel.BackColor = System.Drawing.Color.Transparent
        Me.ErrorProvider1.SetError(Me.UsernameLabel, resources.GetString("UsernameLabel.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.UsernameLabel, CType(resources.GetObject("UsernameLabel.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.UsernameLabel, CType(resources.GetObject("UsernameLabel.IconPadding"), Integer))
        Me.UsernameLabel.Name = "UsernameLabel"
        '
        'btnConectar
        '
        resources.ApplyResources(Me.btnConectar, "btnConectar")
        Me.ErrorProvider1.SetError(Me.btnConectar, resources.GetString("btnConectar.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.btnConectar, CType(resources.GetObject("btnConectar.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.btnConectar, CType(resources.GetObject("btnConectar.IconPadding"), Integer))
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.TabStop = False
        '
        'tbServidor
        '
        resources.ApplyResources(Me.tbServidor, "tbServidor")
        '
        '
        '
        Me.tbServidor.Border.Class = "TextBoxBorder"
        Me.tbServidor.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbServidor.ButtonCustom.DisplayPosition = CType(resources.GetObject("tbServidor.ButtonCustom.DisplayPosition"), Integer)
        Me.tbServidor.ButtonCustom.Image = CType(resources.GetObject("tbServidor.ButtonCustom.Image"), System.Drawing.Image)
        Me.tbServidor.ButtonCustom.Text = resources.GetString("tbServidor.ButtonCustom.Text")
        Me.tbServidor.ButtonCustom2.DisplayPosition = CType(resources.GetObject("tbServidor.ButtonCustom2.DisplayPosition"), Integer)
        Me.tbServidor.ButtonCustom2.Image = CType(resources.GetObject("tbServidor.ButtonCustom2.Image"), System.Drawing.Image)
        Me.tbServidor.ButtonCustom2.Text = resources.GetString("tbServidor.ButtonCustom2.Text")
        Me.ErrorProvider1.SetError(Me.tbServidor, resources.GetString("tbServidor.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.tbServidor, CType(resources.GetObject("tbServidor.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.tbServidor, CType(resources.GetObject("tbServidor.IconPadding"), Integer))
        Me.tbServidor.Name = "tbServidor"
        '
        'LabelX2
        '
        resources.ApplyResources(Me.LabelX2, "LabelX2")
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ErrorProvider1.SetError(Me.LabelX2, resources.GetString("LabelX2.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.LabelX2, CType(resources.GetObject("LabelX2.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.LabelX2, CType(resources.GetObject("LabelX2.IconPadding"), Integer))
        Me.LabelX2.Name = "LabelX2"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        resources.ApplyResources(Me.ErrorProvider1, "ErrorProvider1")
        '
        'expandablePanel1
        '
        resources.ApplyResources(Me.expandablePanel1, "expandablePanel1")
        Me.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Info
        Me.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft
        Me.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2010
        Me.expandablePanel1.Controls.Add(Me.btnConectar)
        Me.expandablePanel1.Controls.Add(Me.LabelX3)
        Me.expandablePanel1.Controls.Add(Me.LabelX2)
        Me.expandablePanel1.Controls.Add(Me.tbServidor)
        Me.expandablePanel1.Controls.Add(Me.LabelX1)
        Me.expandablePanel1.Controls.Add(Me.tbSenha)
        Me.expandablePanel1.Controls.Add(Me.tbUsuario)
        Me.ErrorProvider1.SetError(Me.expandablePanel1, resources.GetString("expandablePanel1.Error"))
        Me.expandablePanel1.Expanded = False
        Me.expandablePanel1.ExpandedBounds = New System.Drawing.Rectangle(3, 25, 275, 271)
        Me.ErrorProvider1.SetIconAlignment(Me.expandablePanel1, CType(resources.GetObject("expandablePanel1.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.expandablePanel1, CType(resources.GetObject("expandablePanel1.IconPadding"), Integer))
        Me.expandablePanel1.Name = "expandablePanel1"
        Me.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.expandablePanel1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.expandablePanel1.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.expandablePanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandablePanel1.Style.GradientAngle = 90
        Me.expandablePanel1.Style.WordWrap = True
        Me.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center
        Me.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner
        Me.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandablePanel1.TitleStyle.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom
        Me.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.expandablePanel1.TitleStyle.GradientAngle = 90
        '
        'LabelX1
        '
        resources.ApplyResources(Me.LabelX1, "LabelX1")
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ErrorProvider1.SetError(Me.LabelX1, resources.GetString("LabelX1.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.LabelX1, CType(resources.GetObject("LabelX1.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.LabelX1, CType(resources.GetObject("LabelX1.IconPadding"), Integer))
        Me.LabelX1.Name = "LabelX1"
        '
        'tbSenha
        '
        resources.ApplyResources(Me.tbSenha, "tbSenha")
        '
        '
        '
        Me.tbSenha.Border.Class = "TextBoxBorder"
        Me.tbSenha.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbSenha.ButtonCustom.DisplayPosition = CType(resources.GetObject("tbSenha.ButtonCustom.DisplayPosition"), Integer)
        Me.tbSenha.ButtonCustom.Image = CType(resources.GetObject("tbSenha.ButtonCustom.Image"), System.Drawing.Image)
        Me.tbSenha.ButtonCustom.Text = resources.GetString("tbSenha.ButtonCustom.Text")
        Me.tbSenha.ButtonCustom2.DisplayPosition = CType(resources.GetObject("tbSenha.ButtonCustom2.DisplayPosition"), Integer)
        Me.tbSenha.ButtonCustom2.Image = CType(resources.GetObject("tbSenha.ButtonCustom2.Image"), System.Drawing.Image)
        Me.tbSenha.ButtonCustom2.Text = resources.GetString("tbSenha.ButtonCustom2.Text")
        Me.ErrorProvider1.SetError(Me.tbSenha, resources.GetString("tbSenha.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.tbSenha, CType(resources.GetObject("tbSenha.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.tbSenha, CType(resources.GetObject("tbSenha.IconPadding"), Integer))
        Me.tbSenha.Name = "tbSenha"
        '
        'tbUsuario
        '
        resources.ApplyResources(Me.tbUsuario, "tbUsuario")
        '
        '
        '
        Me.tbUsuario.Border.Class = "TextBoxBorder"
        Me.tbUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.tbUsuario.ButtonCustom.DisplayPosition = CType(resources.GetObject("tbUsuario.ButtonCustom.DisplayPosition"), Integer)
        Me.tbUsuario.ButtonCustom.Image = CType(resources.GetObject("tbUsuario.ButtonCustom.Image"), System.Drawing.Image)
        Me.tbUsuario.ButtonCustom.Text = resources.GetString("tbUsuario.ButtonCustom.Text")
        Me.tbUsuario.ButtonCustom2.DisplayPosition = CType(resources.GetObject("tbUsuario.ButtonCustom2.DisplayPosition"), Integer)
        Me.tbUsuario.ButtonCustom2.Image = CType(resources.GetObject("tbUsuario.ButtonCustom2.Image"), System.Drawing.Image)
        Me.tbUsuario.ButtonCustom2.Text = resources.GetString("tbUsuario.ButtonCustom2.Text")
        Me.ErrorProvider1.SetError(Me.tbUsuario, resources.GetString("tbUsuario.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.tbUsuario, CType(resources.GetObject("tbUsuario.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.tbUsuario, CType(resources.GetObject("tbUsuario.IconPadding"), Integer))
        Me.tbUsuario.Name = "tbUsuario"
        '
        'Version
        '
        resources.ApplyResources(Me.Version, "Version")
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.ErrorProvider1.SetError(Me.Version, resources.GetString("Version.Error"))
        Me.ErrorProvider1.SetIconAlignment(Me.Version, CType(resources.GetObject("Version.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Version, CType(resources.GetObject("Version.IconPadding"), Integer))
        Me.Version.Name = "Version"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.ErrorProvider1.SetError(Me.Label2, resources.GetString("Label2.Error"))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.ErrorProvider1.SetIconAlignment(Me.Label2, CType(resources.GetObject("Label2.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.Label2, CType(resources.GetObject("Label2.IconPadding"), Integer))
        Me.Label2.Name = "Label2"
        '
        'lblTitulo
        '
        resources.ApplyResources(Me.lblTitulo, "lblTitulo")
        Me.lblTitulo.BackColor = System.Drawing.Color.Green
        Me.ErrorProvider1.SetError(Me.lblTitulo, resources.GetString("lblTitulo.Error"))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ErrorProvider1.SetIconAlignment(Me.lblTitulo, CType(resources.GetObject("lblTitulo.IconAlignment"), System.Windows.Forms.ErrorIconAlignment))
        Me.ErrorProvider1.SetIconPadding(Me.lblTitulo, CType(resources.GetObject("lblTitulo.IconPadding"), Integer))
        Me.lblTitulo.Name = "lblTitulo"
        '
        'frmIdentificacao
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.gf.My.Resources.Resources.calculadora
        Me.ControlBox = False
        Me.Controls.Add(Me.expandablePanel1)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIdentificacao"
        Me.TopMost = True
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.expandablePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCopyright As System.Windows.Forms.Label
    Friend WithEvents Cancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Private WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents btnConectar As System.Windows.Forms.Button
    Private WithEvents tbServidor As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Private WithEvents expandablePanel1 As DevComponents.DotNetBar.ExpandablePanel
    Private WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Private WithEvents tbSenha As DevComponents.DotNetBar.Controls.TextBoxX
    Private WithEvents tbUsuario As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
