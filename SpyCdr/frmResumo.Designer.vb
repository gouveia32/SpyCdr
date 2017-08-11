<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmResumo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title
        Dim ChartArea2 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea
        Dim Legend2 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend
        Dim Series2 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series
        Dim Title2 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResumo))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnExcel = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbIntervalo = New System.Windows.Forms.ComboBox
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.lblAguarde = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cbHistorico = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.lblFiltrado = New System.Windows.Forms.Label
        Me.dGridDDX = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.chartPizza = New Dundas.Charting.WinControl.Chart
        Me.chartBarra = New Dundas.Charting.WinControl.Chart
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.panelEx3 = New DevComponents.DotNetBar.PanelEx
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.dGridTotais = New System.Windows.Forms.DataGridView
        Me.expandableSplitter2 = New DevComponents.DotNetBar.ExpandableSplitter
        Me.panelEx2 = New DevComponents.DotNetBar.PanelEx
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.dGridDDX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.chartPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.panelEx3.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.dGridTotais, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelEx2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnExcel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbIntervalo)
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Controls.Add(Me.lblAguarde)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbHistorico)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.lblFiltrado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1015, 29)
        Me.Panel1.TabIndex = 31
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Image = Global.SpyCdr.My.Resources.Resources.excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(939, 1)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(73, 29)
        Me.btnExcel.TabIndex = 41
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(402, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Intervalo:"
        '
        'cbIntervalo
        '
        Me.cbIntervalo.FormattingEnabled = True
        Me.cbIntervalo.Items.AddRange(New Object() {"24 Horas", "PMM1 (09-11)", "PMM2 (14-16)", "PMM3 (20-22)", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbIntervalo.Location = New System.Drawing.Point(459, 4)
        Me.cbIntervalo.Name = "cbIntervalo"
        Me.cbIntervalo.Size = New System.Drawing.Size(98, 21)
        Me.cbIntervalo.TabIndex = 39
        Me.cbIntervalo.Text = "24 Horas"
        Me.ToolTip1.SetToolTip(Me.cbIntervalo, "Selecione uma hora, um PMM ou 24Horas.")
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Image = Global.SpyCdr.My.Resources.Resources.arrow_refresh
        Me.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtualizar.Location = New System.Drawing.Point(0, 0)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(27, 28)
        Me.btnAtualizar.TabIndex = 38
        Me.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnAtualizar, "Atualizar")
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'lblAguarde
        '
        Me.lblAguarde.AutoSize = True
        Me.lblAguarde.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblAguarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAguarde.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAguarde.Location = New System.Drawing.Point(644, 1)
        Me.lblAguarde.Name = "lblAguarde"
        Me.lblAguarde.Size = New System.Drawing.Size(272, 25)
        Me.lblAguarde.TabIndex = 32
        Me.lblAguarde.Text = "Processando, Aguarde..."
        Me.lblAguarde.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(185, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Histórico:"
        '
        'cbHistorico
        '
        Me.cbHistorico.FormattingEnabled = True
        Me.cbHistorico.Items.AddRange(New Object() {"X_Rota_Entrada", "X_Rota_Saida", "X_Cliente_Originado", "X_Cliente_Destinado", "X_Grupo", "X_ASS_A", "X_ASS_B", "X_EOS", "X_PPI"})
        Me.cbHistorico.Location = New System.Drawing.Point(242, 4)
        Me.cbHistorico.Name = "cbHistorico"
        Me.cbHistorico.Size = New System.Drawing.Size(151, 21)
        Me.cbHistorico.TabIndex = 28
        Me.cbHistorico.Text = "X_Grupo"
        Me.ToolTip1.SetToolTip(Me.cbHistorico, "Escolha aqui o Histórico desejado")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Data:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(72, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(97, 20)
        Me.DateTimePicker1.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.DateTimePicker1, "Selecione o dia que deseja analisar.")
        '
        'lblFiltrado
        '
        Me.lblFiltrado.AutoSize = True
        Me.lblFiltrado.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lblFiltrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltrado.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFiltrado.Location = New System.Drawing.Point(563, 4)
        Me.lblFiltrado.Name = "lblFiltrado"
        Me.lblFiltrado.Size = New System.Drawing.Size(75, 20)
        Me.lblFiltrado.TabIndex = 33
        Me.lblFiltrado.Text = "Filtrado:"
        Me.lblFiltrado.Visible = False
        '
        'dGridDDX
        '
        Me.dGridDDX.AllowUserToAddRows = False
        Me.dGridDDX.AllowUserToDeleteRows = False
        Me.dGridDDX.AllowUserToOrderColumns = True
        Me.dGridDDX.AllowUserToResizeColumns = False
        Me.dGridDDX.AllowUserToResizeRows = False
        Me.dGridDDX.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dGridDDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGridDDX.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dGridDDX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dGridDDX.Location = New System.Drawing.Point(0, 0)
        Me.dGridDDX.Name = "dGridDDX"
        Me.dGridDDX.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dGridDDX.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dGridDDX.RowHeadersWidth = 20
        Me.dGridDDX.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGridDDX.Size = New System.Drawing.Size(736, 523)
        Me.dGridDDX.TabIndex = 31
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.SplitContainer2.Panel1.Controls.Add(Me.chartPizza)
        Me.SplitContainer2.Panel1MinSize = 0
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.chartBarra)
        Me.SplitContainer2.Panel2MinSize = 0
        Me.SplitContainer2.Size = New System.Drawing.Size(274, 553)
        Me.SplitContainer2.SplitterDistance = 275
        Me.SplitContainer2.SplitterWidth = 2
        Me.SplitContainer2.TabIndex = 35
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
        Me.chartPizza.Location = New System.Drawing.Point(0, 0)
        Me.chartPizza.Name = "chartPizza"
        Me.chartPizza.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Series1.ChartType = "Pie"
        Series1.CustomAttributes = "PieLabelStyle=Inside"
        Series1.Name = "Series1"
        Series1.ShadowOffset = 2
        Series1.ShowLabelAsValue = True
        Me.chartPizza.Series.Add(Series1)
        Me.chartPizza.Size = New System.Drawing.Size(270, 271)
        Me.chartPizza.TabIndex = 34
        Me.chartPizza.Text = "Chart2"
        Title1.Name = "Principal"
        Me.chartPizza.Titles.Add(Title1)
        Me.chartPizza.Visible = False
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
        Me.chartBarra.Size = New System.Drawing.Size(270, 272)
        Me.chartBarra.TabIndex = 33
        Me.chartBarra.Text = "Chart1"
        Title2.Name = "Principal"
        Me.chartBarra.Titles.Add(Title2)
        Me.chartBarra.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.F1)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlC)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlA)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlV)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlX)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlY)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Del)
        Me.DotNetBarManager1.AutoDispatchShortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins)
        Me.DotNetBarManager1.BottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.DefinitionName = ""
        Me.DotNetBarManager1.EnableFullSizeDock = False
        Me.DotNetBarManager1.LeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.ParentForm = Nothing
        Me.DotNetBarManager1.RightDockSite = Me.DockSite2
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite8
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite5
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite6
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite7
        Me.DotNetBarManager1.TopDockSite = Me.DockSite3
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer
        Me.DockSite4.Location = New System.Drawing.Point(0, 582)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(1015, 0)
        Me.DockSite4.TabIndex = 47
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer
        Me.DockSite1.Location = New System.Drawing.Point(0, 0)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 582)
        Me.DockSite1.TabIndex = 44
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer
        Me.DockSite2.Location = New System.Drawing.Point(1015, 0)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 582)
        Me.DockSite2.TabIndex = 45
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 582)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(1015, 0)
        Me.DockSite8.TabIndex = 52
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 0)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 582)
        Me.DockSite5.TabIndex = 49
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(1015, 0)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 582)
        Me.DockSite6.TabIndex = 50
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(1015, 0)
        Me.DockSite7.TabIndex = 51
        Me.DockSite7.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer
        Me.DockSite3.Location = New System.Drawing.Point(0, 0)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(1015, 0)
        Me.DockSite3.TabIndex = 46
        Me.DockSite3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.panelEx3)
        Me.Panel2.Controls.Add(Me.expandableSplitter2)
        Me.Panel2.Controls.Add(Me.panelEx2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1015, 553)
        Me.Panel2.TabIndex = 48
        '
        'panelEx3
        '
        Me.panelEx3.Controls.Add(Me.SplitContainer3)
        Me.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEx3.Location = New System.Drawing.Point(0, 0)
        Me.panelEx3.Name = "panelEx3"
        Me.panelEx3.Size = New System.Drawing.Size(736, 553)
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
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.dGridDDX)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.dGridTotais)
        Me.SplitContainer3.Size = New System.Drawing.Size(736, 553)
        Me.SplitContainer3.SplitterDistance = 523
        Me.SplitContainer3.TabIndex = 35
        '
        'dGridTotais
        '
        Me.dGridTotais.AllowUserToAddRows = False
        Me.dGridTotais.AllowUserToDeleteRows = False
        Me.dGridTotais.AllowUserToOrderColumns = True
        Me.dGridTotais.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dGridTotais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGridTotais.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dGridTotais.EnableHeadersVisualStyles = False
        Me.dGridTotais.Location = New System.Drawing.Point(0, 0)
        Me.dGridTotais.Name = "dGridTotais"
        Me.dGridTotais.ReadOnly = True
        Me.dGridTotais.RowHeadersWidth = 20
        Me.dGridTotais.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dGridTotais.Size = New System.Drawing.Size(736, 26)
        Me.dGridTotais.TabIndex = 32
        '
        'expandableSplitter2
        '
        Me.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.expandableSplitter2.Dock = System.Windows.Forms.DockStyle.Right
        Me.expandableSplitter2.ExpandableControl = Me.panelEx2
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
        Me.expandableSplitter2.Location = New System.Drawing.Point(736, 0)
        Me.expandableSplitter2.Name = "expandableSplitter2"
        Me.expandableSplitter2.Size = New System.Drawing.Size(5, 553)
        Me.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.expandableSplitter2.TabIndex = 1
        Me.expandableSplitter2.TabStop = False
        '
        'panelEx2
        '
        Me.panelEx2.Controls.Add(Me.SplitContainer2)
        Me.panelEx2.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelEx2.Location = New System.Drawing.Point(741, 0)
        Me.panelEx2.Name = "panelEx2"
        Me.panelEx2.Size = New System.Drawing.Size(274, 553)
        Me.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelEx2.Style.GradientAngle = 90
        Me.panelEx2.TabIndex = 0
        Me.panelEx2.Text = "Click to collapse"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "CO0"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "CO1"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.Width = 50
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "CO2"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "CO3"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "DSC"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn5.Width = 50
        '
        'frmResumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1015, 582)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmResumo"
        Me.Text = "Resumo Diário"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dGridDDX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.chartPizza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.panelEx3.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.dGridTotais, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelEx2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dGridDDX As System.Windows.Forms.DataGridView
    Friend WithEvents chartBarra As Dundas.Charting.WinControl.Chart
    Friend WithEvents chartPizza As Dundas.Charting.WinControl.Chart
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblAguarde As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents lblFiltrado As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents panelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents expandableSplitter2 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents panelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents dGridTotais As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbIntervalo As System.Windows.Forms.ComboBox
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents cbHistorico As System.Windows.Forms.ComboBox
End Class
