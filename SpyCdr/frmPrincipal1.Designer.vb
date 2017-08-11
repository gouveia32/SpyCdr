<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesquisaCDRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoricoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistóricoEmÁrvoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TráfegoNoPPIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminaisSemTráfegoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeraMaioresOfenssoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DumpShadowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FtpTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraçõesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDeEventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApagaRegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DestinosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroDePPIsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JanelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusAguarde = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GeraDDXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeraMaioresOfensoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.rtbNovidades = New System.Windows.Forms.RichTextBox()
        Me.lnkNovidades = New System.Windows.Forms.LinkLabel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtMensagemPrincipal = New System.Windows.Forms.TextBox()
        Me.lblUltimoTTFILE = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.MenuStrip1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem, Me.ProcessamentosToolStripMenuItem, Me.ConfiguraçõesToolStripMenuItem, Me.JanelasToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(850, 40)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PesquisaCDRToolStripMenuItem, Me.HistoricoToolStripMenuItem, Me.HistóricoEmÁrvoreToolStripMenuItem, Me.TráfegoNoPPIToolStripMenuItem, Me.TerminaisSemTráfegoToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ConsultasToolStripMenuItem.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_14
        Me.ConsultasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(111, 36)
        Me.ConsultasToolStripMenuItem.Text = "&Consultas"
        '
        'PesquisaCDRToolStripMenuItem
        '
        Me.PesquisaCDRToolStripMenuItem.Image = Global.SpyCdr.My.Resources.Resources._32_find
        Me.PesquisaCDRToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PesquisaCDRToolStripMenuItem.Name = "PesquisaCDRToolStripMenuItem"
        Me.PesquisaCDRToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.PesquisaCDRToolStripMenuItem.Size = New System.Drawing.Size(217, 38)
        Me.PesquisaCDRToolStripMenuItem.Text = "Pesquisa CDRs"
        '
        'HistoricoToolStripMenuItem
        '
        Me.HistoricoToolStripMenuItem.Image = Global.SpyCdr.My.Resources.Resources.folder_doc
        Me.HistoricoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HistoricoToolStripMenuItem.Name = "HistoricoToolStripMenuItem"
        Me.HistoricoToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.HistoricoToolStripMenuItem.Size = New System.Drawing.Size(217, 38)
        Me.HistoricoToolStripMenuItem.Text = "Resumo Diário"
        '
        'HistóricoEmÁrvoreToolStripMenuItem
        '
        Me.HistóricoEmÁrvoreToolStripMenuItem.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_68
        Me.HistóricoEmÁrvoreToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HistóricoEmÁrvoreToolStripMenuItem.Name = "HistóricoEmÁrvoreToolStripMenuItem"
        Me.HistóricoEmÁrvoreToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.HistóricoEmÁrvoreToolStripMenuItem.Size = New System.Drawing.Size(217, 38)
        Me.HistóricoEmÁrvoreToolStripMenuItem.Text = "Histórico"
        '
        'TráfegoNoPPIToolStripMenuItem
        '
        Me.TráfegoNoPPIToolStripMenuItem.Name = "TráfegoNoPPIToolStripMenuItem"
        Me.TráfegoNoPPIToolStripMenuItem.Size = New System.Drawing.Size(217, 38)
        Me.TráfegoNoPPIToolStripMenuItem.Text = "Tráfego no PPI"
        '
        'TerminaisSemTráfegoToolStripMenuItem
        '
        Me.TerminaisSemTráfegoToolStripMenuItem.Name = "TerminaisSemTráfegoToolStripMenuItem"
        Me.TerminaisSemTráfegoToolStripMenuItem.Size = New System.Drawing.Size(217, 38)
        Me.TerminaisSemTráfegoToolStripMenuItem.Text = "Tráfego por Terminal"
        '
        'ProcessamentosToolStripMenuItem
        '
        Me.ProcessamentosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeraMaioresOfenssoresToolStripMenuItem, Me.DumpShadowToolStripMenuItem, Me.FtpTToolStripMenuItem})
        Me.ProcessamentosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ProcessamentosToolStripMenuItem.Image = CType(resources.GetObject("ProcessamentosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProcessamentosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProcessamentosToolStripMenuItem.Name = "ProcessamentosToolStripMenuItem"
        Me.ProcessamentosToolStripMenuItem.Size = New System.Drawing.Size(150, 36)
        Me.ProcessamentosToolStripMenuItem.Text = "&Processamentos"
        '
        'GeraMaioresOfenssoresToolStripMenuItem
        '
        Me.GeraMaioresOfenssoresToolStripMenuItem.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_48
        Me.GeraMaioresOfenssoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GeraMaioresOfenssoresToolStripMenuItem.Name = "GeraMaioresOfenssoresToolStripMenuItem"
        Me.GeraMaioresOfenssoresToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.GeraMaioresOfenssoresToolStripMenuItem.Size = New System.Drawing.Size(202, 38)
        Me.GeraMaioresOfenssoresToolStripMenuItem.Text = "Gera Históricos"
        '
        'DumpShadowToolStripMenuItem
        '
        Me.DumpShadowToolStripMenuItem.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_03
        Me.DumpShadowToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DumpShadowToolStripMenuItem.Name = "DumpShadowToolStripMenuItem"
        Me.DumpShadowToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.DumpShadowToolStripMenuItem.Size = New System.Drawing.Size(202, 38)
        Me.DumpShadowToolStripMenuItem.Text = "EXROP/LST TG"
        '
        'FtpTToolStripMenuItem
        '
        Me.FtpTToolStripMenuItem.Enabled = False
        Me.FtpTToolStripMenuItem.Name = "FtpTToolStripMenuItem"
        Me.FtpTToolStripMenuItem.Size = New System.Drawing.Size(202, 38)
        Me.FtpTToolStripMenuItem.Text = "ftpT"
        '
        'ConfiguraçõesToolStripMenuItem
        '
        Me.ConfiguraçõesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConfiguraçõesToolStripMenuItem1, Me.CadastroDeClientesToolStripMenuItem, Me.CadastroDeEventosToolStripMenuItem, Me.ApagaRegistrosToolStripMenuItem, Me.DestinosToolStripMenuItem, Me.CadastroDePPIsToolStripMenuItem})
        Me.ConfiguraçõesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ConfiguraçõesToolStripMenuItem.Image = Global.SpyCdr.My.Resources.Resources.Mouse_Tools
        Me.ConfiguraçõesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConfiguraçõesToolStripMenuItem.Name = "ConfiguraçõesToolStripMenuItem"
        Me.ConfiguraçõesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.ConfiguraçõesToolStripMenuItem.Size = New System.Drawing.Size(133, 36)
        Me.ConfiguraçõesToolStripMenuItem.Text = "Manutenções"
        '
        'ConfiguraçõesToolStripMenuItem1
        '
        Me.ConfiguraçõesToolStripMenuItem1.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_38
        Me.ConfiguraçõesToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ConfiguraçõesToolStripMenuItem1.Name = "ConfiguraçõesToolStripMenuItem1"
        Me.ConfiguraçõesToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.ConfiguraçõesToolStripMenuItem1.Size = New System.Drawing.Size(238, 38)
        Me.ConfiguraçõesToolStripMenuItem1.Text = "Configurações"
        '
        'CadastroDeClientesToolStripMenuItem
        '
        Me.CadastroDeClientesToolStripMenuItem.Image = Global.SpyCdr.My.Resources.Resources.user_32
        Me.CadastroDeClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CadastroDeClientesToolStripMenuItem.Name = "CadastroDeClientesToolStripMenuItem"
        Me.CadastroDeClientesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.CadastroDeClientesToolStripMenuItem.Size = New System.Drawing.Size(238, 38)
        Me.CadastroDeClientesToolStripMenuItem.Text = "Cadastro de Clientes"
        '
        'CadastroDeEventosToolStripMenuItem
        '
        Me.CadastroDeEventosToolStripMenuItem.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_04
        Me.CadastroDeEventosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CadastroDeEventosToolStripMenuItem.Name = "CadastroDeEventosToolStripMenuItem"
        Me.CadastroDeEventosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9
        Me.CadastroDeEventosToolStripMenuItem.Size = New System.Drawing.Size(238, 38)
        Me.CadastroDeEventosToolStripMenuItem.Text = "Cadastro de Eventos"
        '
        'ApagaRegistrosToolStripMenuItem
        '
        Me.ApagaRegistrosToolStripMenuItem.Image = Global.SpyCdr.My.Resources.Resources.FauxS_XP__Oynx__V2_Icon_07
        Me.ApagaRegistrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ApagaRegistrosToolStripMenuItem.Name = "ApagaRegistrosToolStripMenuItem"
        Me.ApagaRegistrosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.ApagaRegistrosToolStripMenuItem.Size = New System.Drawing.Size(238, 38)
        Me.ApagaRegistrosToolStripMenuItem.Text = "Apaga Registros"
        '
        'DestinosToolStripMenuItem
        '
        Me.DestinosToolStripMenuItem.Image = Global.SpyCdr.My.Resources.Resources._03_HiTech_World_Dialup
        Me.DestinosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DestinosToolStripMenuItem.Name = "DestinosToolStripMenuItem"
        Me.DestinosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11
        Me.DestinosToolStripMenuItem.Size = New System.Drawing.Size(238, 38)
        Me.DestinosToolStripMenuItem.Text = "Grupos"
        '
        'CadastroDePPIsToolStripMenuItem
        '
        Me.CadastroDePPIsToolStripMenuItem.Name = "CadastroDePPIsToolStripMenuItem"
        Me.CadastroDePPIsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12
        Me.CadastroDePPIsToolStripMenuItem.Size = New System.Drawing.Size(238, 38)
        Me.CadastroDePPIsToolStripMenuItem.Text = "Cadastro de PPIs"
        '
        'JanelasToolStripMenuItem
        '
        Me.JanelasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HorizontalToolStripMenuItem, Me.VerticalToolStripMenuItem, Me.CascataToolStripMenuItem})
        Me.JanelasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window
        Me.JanelasToolStripMenuItem.Image = Global.SpyCdr.My.Resources.Resources.Clear_Windows
        Me.JanelasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.JanelasToolStripMenuItem.Name = "JanelasToolStripMenuItem"
        Me.JanelasToolStripMenuItem.Size = New System.Drawing.Size(95, 36)
        Me.JanelasToolStripMenuItem.Text = "&Janelas"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'CascataToolStripMenuItem
        '
        Me.CascataToolStripMenuItem.Name = "CascataToolStripMenuItem"
        Me.CascataToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.CascataToolStripMenuItem.Text = "Cascata"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SobreToolStripMenuItem})
        Me.AjudaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.AjudaToolStripMenuItem.Image = Global.SpyCdr.My.Resources.Resources.Question
        Me.AjudaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(87, 36)
        Me.AjudaToolStripMenuItem.Text = "&Ajuda"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SobreToolStripMenuItem.Text = "&Sobre..."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusAguarde})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 600)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(850, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusAguarde
        '
        Me.ToolStripStatusAguarde.BackColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripStatusAguarde.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusAguarde.ForeColor = System.Drawing.SystemColors.Window
        Me.ToolStripStatusAguarde.Name = "ToolStripStatusAguarde"
        Me.ToolStripStatusAguarde.Size = New System.Drawing.Size(196, 17)
        Me.ToolStripStatusAguarde.Text = "Carregando Formulário..."
        Me.ToolStripStatusAguarde.Visible = False
        '
        'GeraDDXToolStripMenuItem
        '
        Me.GeraDDXToolStripMenuItem.Name = "GeraDDXToolStripMenuItem"
        Me.GeraDDXToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.GeraDDXToolStripMenuItem.Text = "Gera DDX do Dia"
        '
        'GeraMaioresOfensoresToolStripMenuItem
        '
        Me.GeraMaioresOfensoresToolStripMenuItem.Name = "GeraMaioresOfensoresToolStripMenuItem"
        Me.GeraMaioresOfensoresToolStripMenuItem.Size = New System.Drawing.Size(229, 22)
        Me.GeraMaioresOfensoresToolStripMenuItem.Text = "Gera Maiores Ofensores"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "SpyCdr"
        '
        'rtbNovidades
        '
        Me.rtbNovidades.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbNovidades.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.rtbNovidades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbNovidades.Location = New System.Drawing.Point(12, 237)
        Me.rtbNovidades.Name = "rtbNovidades"
        Me.rtbNovidades.ReadOnly = True
        Me.rtbNovidades.Size = New System.Drawing.Size(826, 326)
        Me.rtbNovidades.TabIndex = 9
        Me.rtbNovidades.Text = resources.GetString("rtbNovidades.Text")
        Me.rtbNovidades.Visible = False
        '
        'lnkNovidades
        '
        Me.lnkNovidades.AutoSize = True
        Me.lnkNovidades.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lnkNovidades.ForeColor = System.Drawing.Color.Transparent
        Me.lnkNovidades.LinkColor = System.Drawing.Color.Crimson
        Me.lnkNovidades.Location = New System.Drawing.Point(309, 211)
        Me.lnkNovidades.Name = "lnkNovidades"
        Me.lnkNovidades.Size = New System.Drawing.Size(58, 13)
        Me.lnkNovidades.TabIndex = 8
        Me.lnkNovidades.TabStop = True
        Me.lnkNovidades.Text = "Novidades"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(166, 57)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(424, 31)
        Me.lblTitulo.TabIndex = 10
        Me.lblTitulo.Text = "SpyCdr - Investigador de CDRs"
        '
        'txtMensagemPrincipal
        '
        Me.txtMensagemPrincipal.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtMensagemPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMensagemPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensagemPrincipal.Location = New System.Drawing.Point(15, 97)
        Me.txtMensagemPrincipal.Multiline = True
        Me.txtMensagemPrincipal.Name = "txtMensagemPrincipal"
        Me.txtMensagemPrincipal.ReadOnly = True
        Me.txtMensagemPrincipal.Size = New System.Drawing.Size(823, 134)
        Me.txtMensagemPrincipal.TabIndex = 11
        Me.txtMensagemPrincipal.Text = resources.GetString("txtMensagemPrincipal.Text")
        '
        'lblUltimoTTFILE
        '
        Me.lblUltimoTTFILE.AutoSize = True
        Me.lblUltimoTTFILE.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblUltimoTTFILE.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimoTTFILE.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblUltimoTTFILE.Location = New System.Drawing.Point(186, 175)
        Me.lblUltimoTTFILE.Name = "lblUltimoTTFILE"
        Me.lblUltimoTTFILE.Size = New System.Drawing.Size(23, 18)
        Me.lblUltimoTTFILE.TabIndex = 14
        Me.lblUltimoTTFILE.Text = "..."
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 622)
        Me.Controls.Add(Me.lblUltimoTTFILE)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.rtbNovidades)
        Me.Controls.Add(Me.lnkNovidades)
        Me.Controls.Add(Me.txtMensagemPrincipal)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "SpyCdr - Investigador de CDR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConfiguraçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessamentosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PesquisaCDRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoricoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents GeraDDXToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeraMaioresOfensoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeraMaioresOfenssoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DumpShadowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FtpTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents HistóricoEmÁrvoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraçõesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ApagaRegistrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroDeEventosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusAguarde As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents JanelasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DestinosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents rtbNovidades As System.Windows.Forms.RichTextBox
    Friend WithEvents lnkNovidades As System.Windows.Forms.LinkLabel
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents txtMensagemPrincipal As System.Windows.Forms.TextBox
    Friend WithEvents lblUltimoTTFILE As System.Windows.Forms.Label
    Friend WithEvents CadastroDePPIsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TráfegoNoPPIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TerminaisSemTráfegoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
