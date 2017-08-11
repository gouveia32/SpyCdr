<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.rtbNovidades = New System.Windows.Forms.RichTextBox()
        Me.txtMensagemPrincipal = New System.Windows.Forms.TextBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rtbNovidades
        '
        Me.rtbNovidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbNovidades.BackColor = System.Drawing.SystemColors.Info
        Me.rtbNovidades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbNovidades.Location = New System.Drawing.Point(12, 54)
        Me.rtbNovidades.Name = "rtbNovidades"
        Me.rtbNovidades.ReadOnly = True
        Me.rtbNovidades.Size = New System.Drawing.Size(795, 468)
        Me.rtbNovidades.TabIndex = 12
        Me.rtbNovidades.Text = resources.GetString("rtbNovidades.Text")
        Me.rtbNovidades.Visible = False
        '
        'txtMensagemPrincipal
        '
        Me.txtMensagemPrincipal.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtMensagemPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensagemPrincipal.Enabled = False
        Me.txtMensagemPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensagemPrincipal.Location = New System.Drawing.Point(38, 54)
        Me.txtMensagemPrincipal.Multiline = True
        Me.txtMensagemPrincipal.Name = "txtMensagemPrincipal"
        Me.txtMensagemPrincipal.ReadOnly = True
        Me.txtMensagemPrincipal.Size = New System.Drawing.Size(756, 125)
        Me.txtMensagemPrincipal.TabIndex = 14
        Me.txtMensagemPrincipal.Text = resources.GetString("txtMensagemPrincipal.Text")
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblTitulo.Enabled = False
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(150, 14)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(424, 31)
        Me.lblTitulo.TabIndex = 13
        Me.lblTitulo.Text = "SpyCdr - Investigador de CDRs"
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(819, 534)
        Me.Controls.Add(Me.rtbNovidades)
        Me.Controls.Add(Me.txtMensagemPrincipal)
        Me.Controls.Add(Me.lblTitulo)
        Me.Name = "frmInicio"
        Me.ShowIcon = False
        Me.Text = "Início"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtbNovidades As System.Windows.Forms.RichTextBox
    Friend WithEvents txtMensagemPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
End Class
