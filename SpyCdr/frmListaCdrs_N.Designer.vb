<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaCdrs_N
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
        Me.components = New System.ComponentModel.Container
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("OK1")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("OK5")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode(" OK", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LCL")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LDN")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SNG")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LO", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5, TreeNode6})
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LCL")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LDN")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SNG")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("NR1", New System.Windows.Forms.TreeNode() {TreeNode8, TreeNode9, TreeNode10})
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LCL")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LDN")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SNG")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("NR5", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("NR", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode15})
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PAB", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CO0")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CO1")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CO2")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CO3")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode(" CO", New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19, TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DSC")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode(" OU")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("NOK", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode22, TreeNode23, TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Todos CDRs", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode25})
        Dim ChartArea2 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend2 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series2 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim Title2 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnCarregar = New System.Windows.Forms.Button
        Me.btnGravar = New System.Windows.Forms.Button
        Me.nuDias = New System.Windows.Forms.NumericUpDown
        Me.lblDias = New System.Windows.Forms.Label
        Me.txtSEL = New System.Windows.Forms.TextBox
        Me.btnSEL = New System.Windows.Forms.Button
        Me.tbcGrafico = New System.Windows.Forms.TabControl
        Me.tpTorta = New System.Windows.Forms.TabPage
        Me.chartPizza = New Dundas.Charting.WinControl.Chart
        Me.tpDiagrama = New System.Windows.Forms.TabPage
        Me.tvCausas = New System.Windows.Forms.TreeView
        Me.btnProcessar = New System.Windows.Forms.Button
        Me.chartBarra = New Dundas.Charting.WinControl.Chart
        Me.btnProximoLoop = New System.Windows.Forms.Button
        Me.btnLoop = New System.Windows.Forms.Button
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
        Me.cbOrdenar = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dGridCdrs = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuFechar = New System.Windows.Forms.ToolStripMenuItem
        Me.nudLimite = New System.Windows.Forms.NumericUpDown
        Me.cbLimite = New System.Windows.Forms.CheckBox
        Me.cbParenteseA5 = New System.Windows.Forms.CheckBox
        Me.cbParenteseF5 = New System.Windows.Forms.CheckBox
        Me.cbOperador5 = New System.Windows.Forms.ComboBox
        Me.cbConector4 = New System.Windows.Forms.ComboBox
        Me.txtValor5 = New System.Windows.Forms.TextBox
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbCampo5 = New System.Windows.Forms.ComboBox
        Me.cbParenteseA4 = New System.Windows.Forms.CheckBox
        Me.cbParenteseF4 = New System.Windows.Forms.CheckBox
        Me.txtSQL = New System.Windows.Forms.TextBox
        Me.cbOperador4 = New System.Windows.Forms.ComboBox
        Me.cbConector3 = New System.Windows.Forms.ComboBox
        Me.txtValor4 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cbCampo4 = New System.Windows.Forms.ComboBox
        Me.cbParenteseF1 = New System.Windows.Forms.CheckBox
        Me.cbParenteseA3 = New System.Windows.Forms.CheckBox
        Me.cbParenteseA2 = New System.Windows.Forms.CheckBox
        Me.cbParenteseA1 = New System.Windows.Forms.CheckBox
        Me.cbParenteseF2 = New System.Windows.Forms.CheckBox
        Me.cbParenteseF3 = New System.Windows.Forms.CheckBox
        Me.btnLimpar = New System.Windows.Forms.Button
        Me.cbOperador3 = New System.Windows.Forms.ComboBox
        Me.cbOperador2 = New System.Windows.Forms.ComboBox
        Me.cbOperador1 = New System.Windows.Forms.ComboBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.btnExcel = New System.Windows.Forms.Button
        Me.cbConector2 = New System.Windows.Forms.ComboBox
        Me.txtValor3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbCampo3 = New System.Windows.Forms.ComboBox
        Me.cbConector1 = New System.Windows.Forms.ComboBox
        Me.txtValor2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbCampo2 = New System.Windows.Forms.ComboBox
        Me.txtValor1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbCampo1 = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.expandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter
        Me.panelExSuperior = New DevComponents.DotNetBar.PanelEx
        Me.panel1 = New System.Windows.Forms.Panel
        Me.panelEx3 = New DevComponents.DotNetBar.PanelEx
        Me.expandableSplitter2 = New DevComponents.DotNetBar.ExpandableSplitter
        Me.panelExEsquerdo = New DevComponents.DotNetBar.PanelEx
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.statusRecCount = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusSeparador = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusTabela = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusSeparador2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusTempoGasto = New System.Windows.Forms.ToolStripStatusLabel
        Me.statusSeparador3 = New System.Windows.Forms.ToolStripStatusLabel
        CType(Me.nuDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcGrafico.SuspendLayout()
        Me.tpTorta.SuspendLayout()
        CType(Me.chartPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDiagrama.SuspendLayout()
        CType(Me.chartBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        CType(Me.dGridCdrs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.nudLimite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.panelExSuperior.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panelEx3.SuspendLayout()
        Me.panelExEsquerdo.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCarregar
        '
        Me.btnCarregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCarregar.Image = Global.SpyCdr.My.Resources.Resources._3D_Folders_Open_Folder
        Me.btnCarregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCarregar.Location = New System.Drawing.Point(530, 84)
        Me.btnCarregar.Name = "btnCarregar"
        Me.btnCarregar.Size = New System.Drawing.Size(90, 30)
        Me.btnCarregar.TabIndex = 87
        Me.btnCarregar.Text = "&Carregar"
        Me.btnCarregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCarregar.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGravar.Image = Global.SpyCdr.My.Resources.Resources.Floppy
        Me.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGravar.Location = New System.Drawing.Point(530, 55)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(90, 30)
        Me.btnGravar.TabIndex = 86
        Me.btnGravar.Text = "&Gravar"
        Me.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'nuDias
        '
        Me.nuDias.Location = New System.Drawing.Point(200, 4)
        Me.nuDias.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.nuDias.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nuDias.Name = "nuDias"
        Me.nuDias.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nuDias.Size = New System.Drawing.Size(41, 20)
        Me.nuDias.TabIndex = 84
        Me.nuDias.TabStop = False
        Me.nuDias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lblDias
        '
        Me.lblDias.AutoSize = True
        Me.lblDias.Location = New System.Drawing.Point(247, 9)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(32, 13)
        Me.lblDias.TabIndex = 85
        Me.lblDias.Text = "dia(s)"
        '
        'txtSEL
        '
        Me.txtSEL.Location = New System.Drawing.Point(43, 5)
        Me.txtSEL.Name = "txtSEL"
        Me.txtSEL.Size = New System.Drawing.Size(97, 20)
        Me.txtSEL.TabIndex = 83
        Me.txtSEL.Text = "CDRs_SEL"
        Me.txtSEL.Visible = False
        '
        'btnSEL
        '
        Me.btnSEL.Location = New System.Drawing.Point(147, 4)
        Me.btnSEL.Name = "btnSEL"
        Me.btnSEL.Size = New System.Drawing.Size(36, 22)
        Me.btnSEL.TabIndex = 82
        Me.btnSEL.Text = "SEL"
        Me.btnSEL.UseVisualStyleBackColor = True
        '
        'tbcGrafico
        '
        Me.tbcGrafico.Controls.Add(Me.tpTorta)
        Me.tbcGrafico.Controls.Add(Me.tpDiagrama)
        Me.tbcGrafico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcGrafico.Location = New System.Drawing.Point(0, 0)
        Me.tbcGrafico.Name = "tbcGrafico"
        Me.tbcGrafico.SelectedIndex = 0
        Me.tbcGrafico.Size = New System.Drawing.Size(246, 184)
        Me.tbcGrafico.TabIndex = 0
        '
        'tpTorta
        '
        Me.tpTorta.Controls.Add(Me.chartPizza)
        Me.tpTorta.Location = New System.Drawing.Point(4, 22)
        Me.tpTorta.Name = "tpTorta"
        Me.tpTorta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTorta.Size = New System.Drawing.Size(238, 158)
        Me.tpTorta.TabIndex = 0
        Me.tpTorta.Text = "Torta"
        Me.tpTorta.UseVisualStyleBackColor = True
        '
        'chartPizza
        '
        Me.chartPizza.BackColor = System.Drawing.Color.LightSteelBlue
        Me.chartPizza.BackGradientEndColor = System.Drawing.Color.White
        Me.chartPizza.BackGradientType = Dundas.Charting.WinControl.GradientType.LeftRight
        Me.chartPizza.BorderLineColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.chartPizza.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        Me.chartPizza.BorderSkin.FrameBackColor = System.Drawing.Color.CornflowerBlue
        Me.chartPizza.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.CornflowerBlue
        Me.chartPizza.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.Area3DStyle.Light = Dundas.Charting.WinControl.LightStyle.Realistic
        ChartArea1.AxisX.LabelStyle.Format = "G"
        ChartArea1.AxisX.LabelStyle.Interval = 0
        ChartArea1.AxisX.LabelStyle.IntervalOffset = 0
        ChartArea1.AxisX.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.Interval = 0
        ChartArea1.AxisX.MajorGrid.IntervalOffset = 0
        ChartArea1.AxisX.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX.MajorTickMark.Interval = 0
        ChartArea1.AxisX.MajorTickMark.IntervalOffset = 0
        ChartArea1.AxisX.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX2.LabelStyle.Interval = 0
        ChartArea1.AxisX2.LabelStyle.IntervalOffset = 0
        ChartArea1.AxisX2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorGrid.Interval = 0
        ChartArea1.AxisX2.MajorGrid.IntervalOffset = 0
        ChartArea1.AxisX2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisX2.MajorTickMark.Interval = 0
        ChartArea1.AxisX2.MajorTickMark.IntervalOffset = 0
        ChartArea1.AxisX2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.LabelStyle.Interval = 0
        ChartArea1.AxisY.LabelStyle.IntervalOffset = 0
        ChartArea1.AxisY.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorGrid.Interval = 0
        ChartArea1.AxisY.MajorGrid.IntervalOffset = 0
        ChartArea1.AxisY.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.MajorTickMark.Interval = 0
        ChartArea1.AxisY.MajorTickMark.IntervalOffset = 0
        ChartArea1.AxisY.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.Title = "chamada"
        ChartArea1.AxisY2.LabelStyle.Interval = 0
        ChartArea1.AxisY2.LabelStyle.IntervalOffset = 0
        ChartArea1.AxisY2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorGrid.Interval = 0
        ChartArea1.AxisY2.MajorGrid.IntervalOffset = 0
        ChartArea1.AxisY2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.AxisY2.MajorTickMark.Interval = 0
        ChartArea1.AxisY2.MajorTickMark.IntervalOffset = 0
        ChartArea1.AxisY2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.Empty
        ChartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        ChartArea1.Name = "Default"
        Me.chartPizza.ChartAreas.Add(ChartArea1)
        Me.chartPizza.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.BackColor = System.Drawing.Color.White
        Legend1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend1.Docking = Dundas.Charting.WinControl.LegendDocking.Left
        Legend1.LegendStyle = Dundas.Charting.WinControl.LegendStyle.Column
        Legend1.Name = "Default"
        Legend1.ShadowOffset = 2
        Me.chartPizza.Legends.Add(Legend1)
        Me.chartPizza.Location = New System.Drawing.Point(3, 3)
        Me.chartPizza.Name = "chartPizza"
        Me.chartPizza.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Series1.ChartType = "Pie"
        Series1.CustomAttributes = "PieLabelStyle=Inside"
        Series1.Name = "Series1"
        Series1.ShadowOffset = 2
        Series1.ShowLabelAsValue = True
        Me.chartPizza.Series.Add(Series1)
        Me.chartPizza.Size = New System.Drawing.Size(232, 152)
        Me.chartPizza.TabIndex = 34
        Me.chartPizza.Text = "Chart2"
        Title1.Name = "Principal"
        Me.chartPizza.Titles.Add(Title1)
        '
        'tpDiagrama
        '
        Me.tpDiagrama.Controls.Add(Me.tvCausas)
        Me.tpDiagrama.Location = New System.Drawing.Point(4, 22)
        Me.tpDiagrama.Name = "tpDiagrama"
        Me.tpDiagrama.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDiagrama.Size = New System.Drawing.Size(238, 158)
        Me.tpDiagrama.TabIndex = 1
        Me.tpDiagrama.Text = "Diagrama"
        Me.tpDiagrama.UseVisualStyleBackColor = True
        '
        'tvCausas
        '
        Me.tvCausas.AllowDrop = True
        Me.tvCausas.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.tvCausas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvCausas.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvCausas.Location = New System.Drawing.Point(3, 3)
        Me.tvCausas.Name = "tvCausas"
        TreeNode1.Name = "OK1"
        TreeNode1.Text = "OK1"
        TreeNode2.Name = "OK5"
        TreeNode2.Text = "OK5"
        TreeNode3.Name = "OK"
        TreeNode3.Text = " OK"
        TreeNode4.Name = "LCL"
        TreeNode4.Text = "LCL"
        TreeNode5.Name = "LDN"
        TreeNode5.Text = "LDN"
        TreeNode6.Name = "SNG"
        TreeNode6.Text = "SNG"
        TreeNode7.Name = "LO"
        TreeNode7.Text = "LO"
        TreeNode8.Name = "LCL"
        TreeNode8.Text = "LCL"
        TreeNode9.Name = "LDN"
        TreeNode9.Text = "LDN"
        TreeNode10.Name = "SNG"
        TreeNode10.Text = "SNG"
        TreeNode11.Name = "NR1"
        TreeNode11.Text = "NR1"
        TreeNode12.Name = "LCL"
        TreeNode12.Text = "LCL"
        TreeNode13.Name = "LDN"
        TreeNode13.Text = "LDN"
        TreeNode14.Name = "SNG"
        TreeNode14.Text = "SNG"
        TreeNode15.Name = "NR5"
        TreeNode15.Text = "NR5"
        TreeNode16.Name = "NR"
        TreeNode16.Text = "NR"
        TreeNode17.Name = "PAB"
        TreeNode17.Text = "PAB"
        TreeNode18.Name = "CO0"
        TreeNode18.Text = "CO0"
        TreeNode19.Name = "CO1"
        TreeNode19.Text = "CO1"
        TreeNode20.Name = "CO2"
        TreeNode20.Text = "CO2"
        TreeNode21.Name = "CO3"
        TreeNode21.Text = "CO3"
        TreeNode22.Name = "CO"
        TreeNode22.Text = " CO"
        TreeNode23.Name = "DSC"
        TreeNode23.Text = "DSC"
        TreeNode24.Name = "OU"
        TreeNode24.Text = " OU"
        TreeNode25.Name = "NOK"
        TreeNode25.Text = "NOK"
        TreeNode26.Name = "Todos CDRs"
        TreeNode26.Text = "Todos CDRs"
        Me.tvCausas.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode26})
        Me.tvCausas.Size = New System.Drawing.Size(232, 152)
        Me.tvCausas.TabIndex = 38
        '
        'btnProcessar
        '
        Me.btnProcessar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcessar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnProcessar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnProcessar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessar.Image = Global.SpyCdr.My.Resources.Resources.Icon_299
        Me.btnProcessar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcessar.Location = New System.Drawing.Point(530, 117)
        Me.btnProcessar.Name = "btnProcessar"
        Me.btnProcessar.Size = New System.Drawing.Size(181, 39)
        Me.btnProcessar.TabIndex = 81
        Me.btnProcessar.Text = "&Processar"
        Me.btnProcessar.UseVisualStyleBackColor = False
        '
        'chartBarra
        '
        Me.chartBarra.BackColor = System.Drawing.Color.LightSteelBlue
        Me.chartBarra.BorderLineColor = System.Drawing.Color.LightSlateGray
        Me.chartBarra.BorderSkin.FrameBackColor = System.Drawing.Color.SteelBlue
        Me.chartBarra.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue
        ChartArea2.AxisX.LabelStyle.Interval = 0
        ChartArea2.AxisX.LabelStyle.IntervalOffset = 0
        ChartArea2.AxisX.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.MajorGrid.Interval = 0
        ChartArea2.AxisX.MajorGrid.IntervalOffset = 0
        ChartArea2.AxisX.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightSteelBlue
        ChartArea2.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea2.AxisX.MajorTickMark.Interval = 0
        ChartArea2.AxisX.MajorTickMark.IntervalOffset = 0
        ChartArea2.AxisX.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea2.AxisX2.LabelStyle.Interval = 0
        ChartArea2.AxisX2.LabelStyle.IntervalOffset = 0
        ChartArea2.AxisX2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX2.MajorGrid.Interval = 0
        ChartArea2.AxisX2.MajorGrid.IntervalOffset = 0
        ChartArea2.AxisX2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX2.MajorTickMark.Interval = 0
        ChartArea2.AxisX2.MajorTickMark.IntervalOffset = 0
        ChartArea2.AxisX2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.LabelStyle.Interval = 0
        ChartArea2.AxisY.LabelStyle.IntervalOffset = 0
        ChartArea2.AxisY.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.MajorGrid.Interval = 0
        ChartArea2.AxisY.MajorGrid.IntervalOffset = 0
        ChartArea2.AxisY.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightSteelBlue
        ChartArea2.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea2.AxisY.MajorTickMark.Interval = 0
        ChartArea2.AxisY.MajorTickMark.IntervalOffset = 0
        ChartArea2.AxisY.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea2.AxisY2.LabelStyle.Interval = 0
        ChartArea2.AxisY2.LabelStyle.IntervalOffset = 0
        ChartArea2.AxisY2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY2.MajorGrid.Interval = 0
        ChartArea2.AxisY2.MajorGrid.IntervalOffset = 0
        ChartArea2.AxisY2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY2.MajorTickMark.Interval = 0
        ChartArea2.AxisY2.MajorTickMark.IntervalOffset = 0
        ChartArea2.AxisY2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.BackColor = System.Drawing.Color.Lavender
        ChartArea2.BorderColor = System.Drawing.Color.Empty
        ChartArea2.Name = "Default"
        ChartArea2.ShadowOffset = 2
        Me.chartBarra.ChartAreas.Add(ChartArea2)
        Me.chartBarra.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.BackColor = System.Drawing.Color.Lavender
        Legend2.BorderColor = System.Drawing.Color.Gray
        Legend2.Enabled = False
        Legend2.Name = "Default"
        Legend2.ShadowOffset = 2
        Me.chartBarra.Legends.Add(Legend2)
        Me.chartBarra.Location = New System.Drawing.Point(0, 0)
        Me.chartBarra.Name = "chartBarra"
        Me.chartBarra.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series2.CustomAttributes = "LabelStyle=Top"
        Series2.Name = "Series1"
        Series2.ShadowOffset = 2
        Series2.ShowLabelAsValue = True
        Me.chartBarra.Series.Add(Series2)
        Me.chartBarra.Size = New System.Drawing.Size(246, 191)
        Me.chartBarra.TabIndex = 33
        Me.chartBarra.Text = "Chart1"
        Title2.Name = "Principal"
        Me.chartBarra.Titles.Add(Title2)
        '
        'btnProximoLoop
        '
        Me.btnProximoLoop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProximoLoop.Enabled = False
        Me.btnProximoLoop.Location = New System.Drawing.Point(622, 56)
        Me.btnProximoLoop.Name = "btnProximoLoop"
        Me.btnProximoLoop.Size = New System.Drawing.Size(90, 29)
        Me.btnProximoLoop.TabIndex = 80
        Me.btnProximoLoop.Text = "Próximo LOOP"
        Me.btnProximoLoop.UseVisualStyleBackColor = True
        '
        'btnLoop
        '
        Me.btnLoop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoop.Location = New System.Drawing.Point(622, 27)
        Me.btnLoop.Name = "btnLoop"
        Me.btnLoop.Size = New System.Drawing.Size(90, 28)
        Me.btnLoop.TabIndex = 79
        Me.btnLoop.Text = "Procura LOOP"
        Me.btnLoop.UseVisualStyleBackColor = True
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.tbcGrafico)
        Me.SplitContainer4.Panel1MinSize = 0
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.chartBarra)
        Me.SplitContainer4.Panel2MinSize = 0
        Me.SplitContainer4.Size = New System.Drawing.Size(250, 387)
        Me.SplitContainer4.SplitterDistance = 188
        Me.SplitContainer4.TabIndex = 36
        '
        'cbOrdenar
        '
        Me.cbOrdenar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbOrdenar.FormattingEnabled = True
        Me.cbOrdenar.Items.AddRange(New Object() {"Sem Ordenação", "ASS_B, ASS_A, DATA", "ASS_A, R_ENT", "ASS_B, R_SAI"})
        Me.cbOrdenar.Location = New System.Drawing.Point(530, 5)
        Me.cbOrdenar.Name = "cbOrdenar"
        Me.cbOrdenar.Size = New System.Drawing.Size(181, 21)
        Me.cbOrdenar.TabIndex = 77
        Me.cbOrdenar.Text = "Sem Ordenação"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(461, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Ordenação:"
        '
        'dGridCdrs
        '
        Me.dGridCdrs.AllowUserToAddRows = False
        Me.dGridCdrs.AllowUserToDeleteRows = False
        Me.dGridCdrs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGridCdrs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dGridCdrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGridCdrs.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dGridCdrs.DefaultCellStyle = DataGridViewCellStyle1
        Me.dGridCdrs.Location = New System.Drawing.Point(0, 0)
        Me.dGridCdrs.Name = "dGridCdrs"
        Me.dGridCdrs.ReadOnly = True
        Me.dGridCdrs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dGridCdrs.RowHeadersWidth = 25
        Me.dGridCdrs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGridCdrs.Size = New System.Drawing.Size(927, 364)
        Me.dGridCdrs.TabIndex = 37
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFechar})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(119, 26)
        '
        'mnuFechar
        '
        Me.mnuFechar.Image = Global.SpyCdr.My.Resources.Resources.down
        Me.mnuFechar.Name = "mnuFechar"
        Me.mnuFechar.Size = New System.Drawing.Size(118, 22)
        Me.mnuFechar.Text = "Fechar"
        '
        'nudLimite
        '
        Me.nudLimite.Location = New System.Drawing.Point(386, 5)
        Me.nudLimite.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.nudLimite.Name = "nudLimite"
        Me.nudLimite.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nudLimite.Size = New System.Drawing.Size(69, 20)
        Me.nudLimite.TabIndex = 76
        Me.nudLimite.TabStop = False
        '
        'cbLimite
        '
        Me.cbLimite.AutoSize = True
        Me.cbLimite.Checked = True
        Me.cbLimite.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbLimite.Location = New System.Drawing.Point(326, 6)
        Me.cbLimite.Name = "cbLimite"
        Me.cbLimite.Size = New System.Drawing.Size(54, 17)
        Me.cbLimite.TabIndex = 75
        Me.cbLimite.Text = "LIMIT"
        Me.cbLimite.UseVisualStyleBackColor = True
        '
        'cbParenteseA5
        '
        Me.cbParenteseA5.AutoSize = True
        Me.cbParenteseA5.Location = New System.Drawing.Point(56, 138)
        Me.cbParenteseA5.Name = "cbParenteseA5"
        Me.cbParenteseA5.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseA5.TabIndex = 74
        Me.cbParenteseA5.Text = "("
        Me.cbParenteseA5.UseVisualStyleBackColor = True
        '
        'cbParenteseF5
        '
        Me.cbParenteseF5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbParenteseF5.AutoSize = True
        Me.cbParenteseF5.Location = New System.Drawing.Point(503, 139)
        Me.cbParenteseF5.Name = "cbParenteseF5"
        Me.cbParenteseF5.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseF5.TabIndex = 73
        Me.cbParenteseF5.Text = ")"
        Me.cbParenteseF5.UseVisualStyleBackColor = True
        '
        'cbOperador5
        '
        Me.cbOperador5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperador5.FormattingEnabled = True
        Me.cbOperador5.Items.AddRange(New Object() {"=", "<>", ">", ">=", "<", "<=", "LIKE", "NOT LIKE"})
        Me.cbOperador5.Location = New System.Drawing.Point(244, 134)
        Me.cbOperador5.Name = "cbOperador5"
        Me.cbOperador5.Size = New System.Drawing.Size(70, 20)
        Me.cbOperador5.TabIndex = 72
        Me.cbOperador5.Text = "="
        '
        'cbConector4
        '
        Me.cbConector4.FormattingEnabled = True
        Me.cbConector4.Items.AddRange(New Object() {"E", "OU"})
        Me.cbConector4.Location = New System.Drawing.Point(8, 133)
        Me.cbConector4.Name = "cbConector4"
        Me.cbConector4.Size = New System.Drawing.Size(42, 21)
        Me.cbConector4.TabIndex = 71
        Me.cbConector4.Text = "E"
        '
        'txtValor5
        '
        Me.txtValor5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor5.Location = New System.Drawing.Point(317, 134)
        Me.txtValor5.Name = "txtValor5"
        Me.txtValor5.Size = New System.Drawing.Size(180, 18)
        Me.txtValor5.TabIndex = 70
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Campo5:"
        '
        'cbCampo5
        '
        Me.cbCampo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCampo5.FormattingEnabled = True
        Me.cbCampo5.Items.AddRange(New Object() {"ASS_A", "ASS_B", "R_ENT", "R_SAI", "CAT", "FDS", "EOS"})
        Me.cbCampo5.Location = New System.Drawing.Point(139, 134)
        Me.cbCampo5.Name = "cbCampo5"
        Me.cbCampo5.Size = New System.Drawing.Size(102, 20)
        Me.cbCampo5.TabIndex = 68
        '
        'cbParenteseA4
        '
        Me.cbParenteseA4.AutoSize = True
        Me.cbParenteseA4.Location = New System.Drawing.Point(56, 111)
        Me.cbParenteseA4.Name = "cbParenteseA4"
        Me.cbParenteseA4.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseA4.TabIndex = 67
        Me.cbParenteseA4.Text = "("
        Me.cbParenteseA4.UseVisualStyleBackColor = True
        '
        'cbParenteseF4
        '
        Me.cbParenteseF4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbParenteseF4.AutoSize = True
        Me.cbParenteseF4.Location = New System.Drawing.Point(503, 112)
        Me.cbParenteseF4.Name = "cbParenteseF4"
        Me.cbParenteseF4.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseF4.TabIndex = 66
        Me.cbParenteseF4.Text = ")"
        Me.cbParenteseF4.UseVisualStyleBackColor = True
        '
        'txtSQL
        '
        Me.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQL.Location = New System.Drawing.Point(0, 0)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Size = New System.Drawing.Size(211, 160)
        Me.txtSQL.TabIndex = 40
        '
        'cbOperador4
        '
        Me.cbOperador4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperador4.FormattingEnabled = True
        Me.cbOperador4.Items.AddRange(New Object() {"=", "<>", ">", ">=", "<", "<=", "LIKE", "NOT LIKE"})
        Me.cbOperador4.Location = New System.Drawing.Point(244, 108)
        Me.cbOperador4.Name = "cbOperador4"
        Me.cbOperador4.Size = New System.Drawing.Size(70, 20)
        Me.cbOperador4.TabIndex = 65
        Me.cbOperador4.Text = "="
        '
        'cbConector3
        '
        Me.cbConector3.FormattingEnabled = True
        Me.cbConector3.Items.AddRange(New Object() {"E", "OU"})
        Me.cbConector3.Location = New System.Drawing.Point(8, 106)
        Me.cbConector3.Name = "cbConector3"
        Me.cbConector3.Size = New System.Drawing.Size(42, 21)
        Me.cbConector3.TabIndex = 64
        Me.cbConector3.Text = "E"
        '
        'txtValor4
        '
        Me.txtValor4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor4.Location = New System.Drawing.Point(317, 108)
        Me.txtValor4.Name = "txtValor4"
        Me.txtValor4.Size = New System.Drawing.Size(180, 18)
        Me.txtValor4.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Campo4:"
        '
        'cbCampo4
        '
        Me.cbCampo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCampo4.FormattingEnabled = True
        Me.cbCampo4.Items.AddRange(New Object() {"ASS_A", "ASS_B", "R_ENT", "R_SAI", "CAT", "FDS", "EOS"})
        Me.cbCampo4.Location = New System.Drawing.Point(139, 108)
        Me.cbCampo4.Name = "cbCampo4"
        Me.cbCampo4.Size = New System.Drawing.Size(102, 20)
        Me.cbCampo4.TabIndex = 61
        '
        'cbParenteseF1
        '
        Me.cbParenteseF1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbParenteseF1.AutoSize = True
        Me.cbParenteseF1.Location = New System.Drawing.Point(503, 32)
        Me.cbParenteseF1.Name = "cbParenteseF1"
        Me.cbParenteseF1.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseF1.TabIndex = 60
        Me.cbParenteseF1.Text = ")"
        Me.cbParenteseF1.UseVisualStyleBackColor = True
        '
        'cbParenteseA3
        '
        Me.cbParenteseA3.AutoSize = True
        Me.cbParenteseA3.Location = New System.Drawing.Point(56, 84)
        Me.cbParenteseA3.Name = "cbParenteseA3"
        Me.cbParenteseA3.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseA3.TabIndex = 59
        Me.cbParenteseA3.Text = "("
        Me.cbParenteseA3.UseVisualStyleBackColor = True
        '
        'cbParenteseA2
        '
        Me.cbParenteseA2.AutoSize = True
        Me.cbParenteseA2.Location = New System.Drawing.Point(56, 58)
        Me.cbParenteseA2.Name = "cbParenteseA2"
        Me.cbParenteseA2.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseA2.TabIndex = 58
        Me.cbParenteseA2.Text = "("
        Me.cbParenteseA2.UseVisualStyleBackColor = True
        '
        'cbParenteseA1
        '
        Me.cbParenteseA1.AutoSize = True
        Me.cbParenteseA1.Location = New System.Drawing.Point(56, 32)
        Me.cbParenteseA1.Name = "cbParenteseA1"
        Me.cbParenteseA1.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseA1.TabIndex = 56
        Me.cbParenteseA1.Text = "("
        Me.cbParenteseA1.UseVisualStyleBackColor = True
        '
        'cbParenteseF2
        '
        Me.cbParenteseF2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbParenteseF2.AutoSize = True
        Me.cbParenteseF2.Location = New System.Drawing.Point(503, 60)
        Me.cbParenteseF2.Name = "cbParenteseF2"
        Me.cbParenteseF2.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseF2.TabIndex = 55
        Me.cbParenteseF2.Text = ")"
        Me.cbParenteseF2.UseVisualStyleBackColor = True
        '
        'cbParenteseF3
        '
        Me.cbParenteseF3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbParenteseF3.AutoSize = True
        Me.cbParenteseF3.Location = New System.Drawing.Point(503, 85)
        Me.cbParenteseF3.Name = "cbParenteseF3"
        Me.cbParenteseF3.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseF3.TabIndex = 54
        Me.cbParenteseF3.Text = ")"
        Me.cbParenteseF3.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLimpar.Image = Global.SpyCdr.My.Resources.Resources.eraser
        Me.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpar.Location = New System.Drawing.Point(530, 27)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(90, 30)
        Me.btnLimpar.TabIndex = 53
        Me.btnLimpar.Text = "&Limpar"
        Me.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'cbOperador3
        '
        Me.cbOperador3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperador3.FormattingEnabled = True
        Me.cbOperador3.Items.AddRange(New Object() {"=", "<>", ">", ">=", "<", "<=", "LIKE", "NOT LIKE"})
        Me.cbOperador3.Location = New System.Drawing.Point(244, 82)
        Me.cbOperador3.Name = "cbOperador3"
        Me.cbOperador3.Size = New System.Drawing.Size(70, 20)
        Me.cbOperador3.TabIndex = 52
        Me.cbOperador3.Text = "="
        '
        'cbOperador2
        '
        Me.cbOperador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperador2.FormattingEnabled = True
        Me.cbOperador2.Items.AddRange(New Object() {"=", "<>", ">", ">=", "<", "<=", "LIKE", "NOT LIKE"})
        Me.cbOperador2.Location = New System.Drawing.Point(244, 56)
        Me.cbOperador2.Name = "cbOperador2"
        Me.cbOperador2.Size = New System.Drawing.Size(70, 20)
        Me.cbOperador2.TabIndex = 51
        Me.cbOperador2.Text = "="
        '
        'cbOperador1
        '
        Me.cbOperador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperador1.FormattingEnabled = True
        Me.cbOperador1.Items.AddRange(New Object() {"=", "<>", ">", ">=", "<", "<=", "LIKE", "NOT LIKE"})
        Me.cbOperador1.Location = New System.Drawing.Point(244, 30)
        Me.cbOperador1.Name = "cbOperador1"
        Me.cbOperador1.Size = New System.Drawing.Size(70, 20)
        Me.cbOperador1.TabIndex = 50
        Me.cbOperador1.Text = "="
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnExcel)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnCarregar)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnGravar)
        Me.SplitContainer2.Panel1.Controls.Add(Me.nuDias)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lblDias)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtSEL)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnSEL)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnProcessar)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnProximoLoop)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnLoop)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbOrdenar)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer2.Panel1.Controls.Add(Me.nudLimite)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbLimite)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbParenteseA5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbParenteseF5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbOperador5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbConector4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtValor5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbCampo5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbParenteseA4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbParenteseF4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbOperador4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbConector3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtValor4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbCampo4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbParenteseF1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbParenteseA3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbParenteseA2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbParenteseA1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbParenteseF2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbParenteseF3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.btnLimpar)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbOperador3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbOperador2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbOperador1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbConector2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtValor3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbCampo3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbConector1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtValor2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbCampo2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.txtValor1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbCampo1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtSQL)
        Me.SplitContainer2.Size = New System.Drawing.Size(932, 160)
        Me.SplitContainer2.SplitterDistance = 717
        Me.SplitContainer2.TabIndex = 0
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.SpyCdr.My.Resources.Resources.excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(621, 84)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(90, 30)
        Me.btnExcel.TabIndex = 109
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'cbConector2
        '
        Me.cbConector2.FormattingEnabled = True
        Me.cbConector2.Items.AddRange(New Object() {"E", "OU"})
        Me.cbConector2.Location = New System.Drawing.Point(8, 79)
        Me.cbConector2.Name = "cbConector2"
        Me.cbConector2.Size = New System.Drawing.Size(42, 21)
        Me.cbConector2.TabIndex = 49
        Me.cbConector2.Text = "E"
        '
        'txtValor3
        '
        Me.txtValor3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor3.Location = New System.Drawing.Point(317, 82)
        Me.txtValor3.Name = "txtValor3"
        Me.txtValor3.Size = New System.Drawing.Size(180, 18)
        Me.txtValor3.TabIndex = 48
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Campo3:"
        '
        'cbCampo3
        '
        Me.cbCampo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCampo3.FormattingEnabled = True
        Me.cbCampo3.Items.AddRange(New Object() {"ASS_A", "ASS_B", "R_ENT", "R_SAI", "CAT", "FDS", "EOS"})
        Me.cbCampo3.Location = New System.Drawing.Point(139, 82)
        Me.cbCampo3.Name = "cbCampo3"
        Me.cbCampo3.Size = New System.Drawing.Size(102, 20)
        Me.cbCampo3.TabIndex = 46
        '
        'cbConector1
        '
        Me.cbConector1.FormattingEnabled = True
        Me.cbConector1.Items.AddRange(New Object() {"E", "OU"})
        Me.cbConector1.Location = New System.Drawing.Point(8, 55)
        Me.cbConector1.Name = "cbConector1"
        Me.cbConector1.Size = New System.Drawing.Size(42, 21)
        Me.cbConector1.TabIndex = 45
        Me.cbConector1.Text = "E"
        '
        'txtValor2
        '
        Me.txtValor2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor2.Location = New System.Drawing.Point(317, 56)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(180, 18)
        Me.txtValor2.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Campo2:"
        '
        'cbCampo2
        '
        Me.cbCampo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCampo2.FormattingEnabled = True
        Me.cbCampo2.Items.AddRange(New Object() {"ASS_A", "ASS_B", "R_ENT", "R_SAI", "CAT", "FDS", "EOS"})
        Me.cbCampo2.Location = New System.Drawing.Point(139, 56)
        Me.cbCampo2.Name = "cbCampo2"
        Me.cbCampo2.Size = New System.Drawing.Size(102, 20)
        Me.cbCampo2.TabIndex = 42
        '
        'txtValor1
        '
        Me.txtValor1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtValor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor1.Location = New System.Drawing.Point(317, 30)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(180, 18)
        Me.txtValor1.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Campo1:"
        '
        'cbCampo1
        '
        Me.cbCampo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCampo1.FormattingEnabled = True
        Me.cbCampo1.Items.AddRange(New Object() {"ASS_A", "ASS_B", "R_ENT", "R_SAI", "CAT", "FDS", "EOS"})
        Me.cbCampo1.Location = New System.Drawing.Point(139, 30)
        Me.cbCampo1.Name = "cbCampo1"
        Me.cbCampo1.Size = New System.Drawing.Size(102, 20)
        Me.cbCampo1.TabIndex = 39
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(44, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePicker1.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Data:"
        '
        'expandableSplitter1
        '
        Me.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.expandableSplitter1.ExpandableControl = Me.panelExSuperior
        Me.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.expandableSplitter1.Location = New System.Drawing.Point(0, 160)
        Me.expandableSplitter1.Name = "expandableSplitter1"
        Me.expandableSplitter1.Shortcut = DevComponents.DotNetBar.eShortcut.CtrlF2
        Me.expandableSplitter1.Size = New System.Drawing.Size(932, 5)
        Me.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.expandableSplitter1.TabIndex = 54
        Me.expandableSplitter1.TabStop = False
        '
        'panelExSuperior
        '
        Me.panelExSuperior.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.panelExSuperior.Controls.Add(Me.SplitContainer2)
        Me.panelExSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelExSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelExSuperior.Name = "panelExSuperior"
        Me.panelExSuperior.Size = New System.Drawing.Size(932, 160)
        Me.panelExSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelExSuperior.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panelExSuperior.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.panelExSuperior.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.panelExSuperior.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.panelExSuperior.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.panelExSuperior.Style.GradientAngle = 90
        Me.panelExSuperior.Style.WordWrap = True
        Me.panelExSuperior.TabIndex = 53
        Me.panelExSuperior.Text = "Click to collapse"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.panel1.Controls.Add(Me.panelEx3)
        Me.panel1.Controls.Add(Me.expandableSplitter2)
        Me.panel1.Controls.Add(Me.panelExEsquerdo)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 165)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(932, 387)
        Me.panel1.TabIndex = 55
        '
        'panelEx3
        '
        Me.panelEx3.Controls.Add(Me.dGridCdrs)
        Me.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEx3.Location = New System.Drawing.Point(5, 0)
        Me.panelEx3.Name = "panelEx3"
        Me.panelEx3.Size = New System.Drawing.Size(927, 387)
        Me.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.panelEx3.Style.BackgroundImagePosition = DevComponents.DotNetBar.eBackgroundImagePosition.Tile
        Me.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.panelEx3.Style.GradientAngle = 90
        Me.panelEx3.TabIndex = 2
        Me.panelEx3.Text = "Fill Panel"
        '
        'expandableSplitter2
        '
        Me.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.expandableSplitter2.ExpandableControl = Me.panelExEsquerdo
        Me.expandableSplitter2.Expanded = False
        Me.expandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.expandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.expandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.expandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.expandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.expandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.expandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.expandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.expandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.expandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.expandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.expandableSplitter2.Location = New System.Drawing.Point(0, 0)
        Me.expandableSplitter2.Name = "expandableSplitter2"
        Me.expandableSplitter2.Size = New System.Drawing.Size(5, 387)
        Me.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.expandableSplitter2.TabIndex = 1
        Me.expandableSplitter2.TabStop = False
        '
        'panelExEsquerdo
        '
        Me.panelExEsquerdo.Controls.Add(Me.SplitContainer4)
        Me.panelExEsquerdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelExEsquerdo.Location = New System.Drawing.Point(0, 0)
        Me.panelExEsquerdo.Name = "panelExEsquerdo"
        Me.panelExEsquerdo.Size = New System.Drawing.Size(250, 387)
        Me.panelExEsquerdo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelExEsquerdo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelExEsquerdo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelExEsquerdo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelExEsquerdo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelExEsquerdo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelExEsquerdo.Style.GradientAngle = 90
        Me.panelExEsquerdo.TabIndex = 0
        Me.panelExEsquerdo.Text = "Click to collapse"
        Me.panelExEsquerdo.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusRecCount, Me.statusSeparador, Me.statusTabela, Me.statusSeparador2, Me.statusTempoGasto, Me.statusSeparador3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 530)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(932, 22)
        Me.StatusStrip1.TabIndex = 56
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusRecCount
        '
        Me.statusRecCount.Name = "statusRecCount"
        Me.statusRecCount.Size = New System.Drawing.Size(52, 17)
        Me.statusRecCount.Text = "Registros"
        '
        'statusSeparador
        '
        Me.statusSeparador.Name = "statusSeparador"
        Me.statusSeparador.Size = New System.Drawing.Size(82, 17)
        Me.statusSeparador.Text = "                         "
        '
        'statusTabela
        '
        Me.statusTabela.Name = "statusTabela"
        Me.statusTabela.Size = New System.Drawing.Size(0, 17)
        Me.statusTabela.Visible = False
        '
        'statusSeparador2
        '
        Me.statusSeparador2.Name = "statusSeparador2"
        Me.statusSeparador2.Size = New System.Drawing.Size(55, 17)
        Me.statusSeparador2.Text = "                "
        '
        'statusTempoGasto
        '
        Me.statusTempoGasto.Name = "statusTempoGasto"
        Me.statusTempoGasto.Size = New System.Drawing.Size(72, 17)
        Me.statusTempoGasto.Text = "Tempo: 0 seg"
        '
        'statusSeparador3
        '
        Me.statusSeparador3.Name = "statusSeparador3"
        Me.statusSeparador3.Size = New System.Drawing.Size(517, 17)
        Me.statusSeparador3.Text = "                                                                                 " & _
            "                                                                                " & _
            "         "
        '
        'frmListaCdrs_N
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(932, 552)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.expandableSplitter1)
        Me.Controls.Add(Me.panelExSuperior)
        Me.Name = "frmListaCdrs_N"
        Me.ShowIcon = False
        Me.Text = "Pesquisa Cdrs"
        CType(Me.nuDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcGrafico.ResumeLayout(False)
        Me.tpTorta.ResumeLayout(False)
        CType(Me.chartPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpDiagrama.ResumeLayout(False)
        CType(Me.chartBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        CType(Me.dGridCdrs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.nudLimite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.panelExSuperior.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panelEx3.ResumeLayout(False)
        Me.panelExEsquerdo.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCarregar As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents nuDias As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblDias As System.Windows.Forms.Label
    Friend WithEvents txtSEL As System.Windows.Forms.TextBox
    Friend WithEvents btnSEL As System.Windows.Forms.Button
    Friend WithEvents tbcGrafico As System.Windows.Forms.TabControl
    Friend WithEvents tpTorta As System.Windows.Forms.TabPage
    Friend WithEvents chartPizza As Dundas.Charting.WinControl.Chart
    Friend WithEvents tpDiagrama As System.Windows.Forms.TabPage
    Friend WithEvents tvCausas As System.Windows.Forms.TreeView
    Friend WithEvents btnProcessar As System.Windows.Forms.Button
    Friend WithEvents chartBarra As Dundas.Charting.WinControl.Chart
    Friend WithEvents btnProximoLoop As System.Windows.Forms.Button
    Friend WithEvents btnLoop As System.Windows.Forms.Button
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents cbOrdenar As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dGridCdrs As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuFechar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nudLimite As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbLimite As System.Windows.Forms.CheckBox
    Friend WithEvents cbParenteseA5 As System.Windows.Forms.CheckBox
    Friend WithEvents cbParenteseF5 As System.Windows.Forms.CheckBox
    Friend WithEvents cbOperador5 As System.Windows.Forms.ComboBox
    Friend WithEvents cbConector4 As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor5 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbCampo5 As System.Windows.Forms.ComboBox
    Friend WithEvents cbParenteseA4 As System.Windows.Forms.CheckBox
    Friend WithEvents cbParenteseF4 As System.Windows.Forms.CheckBox
    Friend WithEvents txtSQL As System.Windows.Forms.TextBox
    Friend WithEvents cbOperador4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbConector3 As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbCampo4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbParenteseF1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbParenteseA3 As System.Windows.Forms.CheckBox
    Friend WithEvents cbParenteseA2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbParenteseA1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbParenteseF2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbParenteseF3 As System.Windows.Forms.CheckBox
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents cbOperador3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbOperador2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbOperador1 As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents cbConector2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbCampo3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbConector1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCampo2 As System.Windows.Forms.ComboBox
    Friend WithEvents txtValor1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbCampo1 As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents expandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents panelExSuperior As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents panelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents expandableSplitter2 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents panelExEsquerdo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents statusRecCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusSeparador As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusTabela As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusSeparador2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusTempoGasto As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents statusSeparador3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnExcel As System.Windows.Forms.Button
End Class
