<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistorico
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim ChartArea2 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend1 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series1 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Series2 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title1 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblGrupo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chbValores = New System.Windows.Forms.CheckBox()
        Me.lblData = New System.Windows.Forms.Label()
        Me.cbGrupo = New System.Windows.Forms.ComboBox()
        Me.cbIntervalo = New System.Windows.Forms.ComboBox()
        Me.SplitContainerPrincipal = New System.Windows.Forms.SplitContainer()
        Me.btnAtualizar = New System.Windows.Forms.Button()
        Me.chbEventos = New System.Windows.Forms.CheckBox()
        Me.cbHistorico = New System.Windows.Forms.ComboBox()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.cbIndGraf2 = New System.Windows.Forms.ComboBox()
        Me.lblAguarde = New System.Windows.Forms.Label()
        Me.cbIndGraf1 = New System.Windows.Forms.ComboBox()
        Me.expandableSplitter2 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.panelExEsquerdo = New DevComponents.DotNetBar.PanelEx()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.tcArvore = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.dtpDataFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpDataInicial = New System.Windows.Forms.DateTimePicker()
        Me.lbxDataFinal = New DevComponents.DotNetBar.LabelX()
        Me.mcaData = New DevComponents.Editors.DateTimeAdv.MonthCalendarAdv()
        Me.lbxDataInicial = New DevComponents.DotNetBar.LabelX()
        Me.tbiPeriodo = New DevComponents.DotNetBar.TabItem()
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.tbiArvore = New DevComponents.DotNetBar.TabItem()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.dGridDDX = New System.Windows.Forms.DataGridView()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip()
        Me.ProgressBarX2 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.node15 = New DevComponents.AdvTree.Node()
        Me.node16 = New DevComponents.AdvTree.Node()
        Me.node17 = New DevComponents.AdvTree.Node()
        Me.node18 = New DevComponents.AdvTree.Node()
        Me.cell17 = New DevComponents.AdvTree.Cell()
        Me.node19 = New DevComponents.AdvTree.Node()
        Me.node20 = New DevComponents.AdvTree.Node()
        Me.node21 = New DevComponents.AdvTree.Node()
        Me.node22 = New DevComponents.AdvTree.Node()
        Me.node23 = New DevComponents.AdvTree.Node()
        Me.node24 = New DevComponents.AdvTree.Node()
        Me.cell18 = New DevComponents.AdvTree.Cell()
        Me.node25 = New DevComponents.AdvTree.Node()
        Me.node26 = New DevComponents.AdvTree.Node()
        Me.node27 = New DevComponents.AdvTree.Node()
        Me.node28 = New DevComponents.AdvTree.Node()
        Me.node29 = New DevComponents.AdvTree.Node()
        Me.node30 = New DevComponents.AdvTree.Node()
        Me.Chart1 = New Dundas.Charting.WinControl.Chart()
        Me.SplitContainerPrincipal.Panel1.SuspendLayout()
        Me.SplitContainerPrincipal.Panel2.SuspendLayout()
        Me.SplitContainerPrincipal.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panelEx3.SuspendLayout()
        Me.panelExEsquerdo.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        CType(Me.tcArvore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tcArvore.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        Me.TabControlPanel2.SuspendLayout()
        CType(Me.dGridDDX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(173, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Histórico:"
        '
        'lblGrupo
        '
        Me.lblGrupo.Location = New System.Drawing.Point(357, 10)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(43, 16)
        Me.lblGrupo.TabIndex = 34
        Me.lblGrupo.Text = "Rota:"
        Me.lblGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(605, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Intervalo:"
        '
        'chbValores
        '
        Me.chbValores.AutoSize = True
        Me.chbValores.Checked = True
        Me.chbValores.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbValores.Location = New System.Drawing.Point(780, 1)
        Me.chbValores.Name = "chbValores"
        Me.chbValores.Size = New System.Drawing.Size(98, 17)
        Me.chbValores.TabIndex = 31
        Me.chbValores.Text = "Mostrar valores"
        Me.chbValores.UseVisualStyleBackColor = True
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblData.Location = New System.Drawing.Point(35, 10)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(61, 13)
        Me.lblData.TabIndex = 32
        Me.lblData.Text = "Universo:"
        Me.ToolTip1.SetToolTip(Me.lblData, "Indica o universo selecionado")
        '
        'cbGrupo
        '
        Me.cbGrupo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGrupo.Location = New System.Drawing.Point(406, 6)
        Me.cbGrupo.Name = "cbGrupo"
        Me.cbGrupo.Size = New System.Drawing.Size(193, 22)
        Me.cbGrupo.TabIndex = 30
        Me.cbGrupo.Text = "Tudo"
        Me.ToolTip1.SetToolTip(Me.cbGrupo, "Selecione um ítem específico ou 'Todos'.")
        '
        'cbIntervalo
        '
        Me.cbIntervalo.FormattingEnabled = True
        Me.cbIntervalo.Items.AddRange(New Object() {"24 Horas", "PMM1 (09-11)", "PMM2 (14-16)", "PMM3 (20-22)", "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cbIntervalo.Location = New System.Drawing.Point(662, 5)
        Me.cbIntervalo.Name = "cbIntervalo"
        Me.cbIntervalo.Size = New System.Drawing.Size(98, 21)
        Me.cbIntervalo.TabIndex = 29
        Me.cbIntervalo.Text = "24 Horas"
        Me.ToolTip1.SetToolTip(Me.cbIntervalo, "Selecione uma hora, um PMM ou 24Horas.")
        '
        'SplitContainerPrincipal
        '
        Me.SplitContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerPrincipal.Name = "SplitContainerPrincipal"
        Me.SplitContainerPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerPrincipal.Panel1
        '
        Me.SplitContainerPrincipal.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.btnAtualizar)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.chbEventos)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.lblGrupo)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.chbValores)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.lblData)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.cbGrupo)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.cbIntervalo)
        Me.SplitContainerPrincipal.Panel1.Controls.Add(Me.cbHistorico)
        '
        'SplitContainerPrincipal.Panel2
        '
        Me.SplitContainerPrincipal.Panel2.Controls.Add(Me.panel1)
        Me.SplitContainerPrincipal.Size = New System.Drawing.Size(1015, 582)
        Me.SplitContainerPrincipal.SplitterDistance = 32
        Me.SplitContainerPrincipal.SplitterWidth = 1
        Me.SplitContainerPrincipal.TabIndex = 44
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Image = Global.SpyCdr.My.Resources.Resources.arrow_refresh
        Me.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtualizar.Location = New System.Drawing.Point(2, 3)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(27, 28)
        Me.btnAtualizar.TabIndex = 37
        Me.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnAtualizar, "Atualizar")
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'chbEventos
        '
        Me.chbEventos.AutoSize = True
        Me.chbEventos.Checked = True
        Me.chbEventos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbEventos.Location = New System.Drawing.Point(780, 14)
        Me.chbEventos.Name = "chbEventos"
        Me.chbEventos.Size = New System.Drawing.Size(103, 17)
        Me.chbEventos.TabIndex = 36
        Me.chbEventos.Text = "Mostrar Eventos"
        Me.chbEventos.UseVisualStyleBackColor = True
        '
        'cbHistorico
        '
        Me.cbHistorico.FormattingEnabled = True
        Me.cbHistorico.Items.AddRange(New Object() {"X_Rota_Saida", "X_Rota_Entrada", "X_Cliente_Originado", "X_Cliente_Destinado", "X_Grupo", "X_ASS_A", "X_ASS_B", "X_EOS"})
        Me.cbHistorico.Location = New System.Drawing.Point(230, 7)
        Me.cbHistorico.Name = "cbHistorico"
        Me.cbHistorico.Size = New System.Drawing.Size(121, 21)
        Me.cbHistorico.TabIndex = 28
        Me.cbHistorico.Text = "X_Grupo"
        Me.ToolTip1.SetToolTip(Me.cbHistorico, "Escolha aqui o Histórico desejado")
        '
        'panel1
        '
        Me.panel1.Controls.Add(Me.panelEx3)
        Me.panel1.Controls.Add(Me.expandableSplitter2)
        Me.panel1.Controls.Add(Me.panelExEsquerdo)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1015, 549)
        Me.panel1.TabIndex = 54
        '
        'panelEx3
        '
        Me.panelEx3.Controls.Add(Me.cbIndGraf2)
        Me.panelEx3.Controls.Add(Me.lblAguarde)
        Me.panelEx3.Controls.Add(Me.cbIndGraf1)
        Me.panelEx3.Controls.Add(Me.Chart1)
        Me.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEx3.Location = New System.Drawing.Point(182, 0)
        Me.panelEx3.Name = "panelEx3"
        Me.panelEx3.Size = New System.Drawing.Size(833, 549)
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
        'cbIndGraf2
        '
        Me.cbIndGraf2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbIndGraf2.DropDownHeight = 500
        Me.cbIndGraf2.FormattingEnabled = True
        Me.cbIndGraf2.IntegralHeight = False
        Me.cbIndGraf2.Items.AddRange(New Object() {"TCH", "CO0_ch", "CO1_ch", "CO2_ch", "CO3_ch", "DSC_ch", "LO_ch", "NR1_ch", "NR5_ch", "OK1_ch", "OK5_ch", "OU_ch", "OK_ch", "PAB_ch", "CO_ch", "NOK_ch", "CO0_%", "CO1_%", "CO2_%", "CO3_%", "DSC_%", "LO_%", "NR1_%", "NR5_%", "OK1_%", "OK5_%", "OU_%", "OK_%", "OKa_%", "PAB_%", "CO_%", "NOK_%", "Tudo_ch", "Tudo_%"})
        Me.cbIndGraf2.Location = New System.Drawing.Point(6, 523)
        Me.cbIndGraf2.Name = "cbIndGraf2"
        Me.cbIndGraf2.Size = New System.Drawing.Size(70, 21)
        Me.cbIndGraf2.TabIndex = 38
        Me.cbIndGraf2.Text = "TCH"
        Me.ToolTip1.SetToolTip(Me.cbIndGraf2, "Selecione o Indicador desejado. Deve ser diferente do selecionado no gráfico a ci" & _
        "ma.")
        '
        'lblAguarde
        '
        Me.lblAguarde.AutoSize = True
        Me.lblAguarde.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblAguarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAguarde.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAguarde.Location = New System.Drawing.Point(257, 270)
        Me.lblAguarde.Name = "lblAguarde"
        Me.lblAguarde.Size = New System.Drawing.Size(272, 25)
        Me.lblAguarde.TabIndex = 37
        Me.lblAguarde.Text = "Processando, Aguarde..."
        Me.lblAguarde.Visible = False
        '
        'cbIndGraf1
        '
        Me.cbIndGraf1.DropDownHeight = 500
        Me.cbIndGraf1.DropDownWidth = 70
        Me.cbIndGraf1.FormattingEnabled = True
        Me.cbIndGraf1.IntegralHeight = False
        Me.cbIndGraf1.ItemHeight = 13
        Me.cbIndGraf1.Items.AddRange(New Object() {"TCH", "CO0_ch", "CO1_ch", "CO2_ch", "CO3_ch", "DSC_ch", "LO_ch", "NR1_ch", "NR5_ch", "OK1_ch", "OK5_ch", "OU_ch", "OK_ch", "PAB_ch", "CO_ch", "NOK_ch", "CO0_%", "CO1_%", "CO2_%", "CO3_%", "DSC_%", "LO_%", "NR1_%", "NR5_%", "OK1_%", "OK5_%", "OU_%", "OK_%", "OKa_%", "PAB_%", "CO_%", "NOK_%", "Tudo_ch", "Tudo_%"})
        Me.cbIndGraf1.Location = New System.Drawing.Point(6, 3)
        Me.cbIndGraf1.Name = "cbIndGraf1"
        Me.cbIndGraf1.Size = New System.Drawing.Size(70, 21)
        Me.cbIndGraf1.TabIndex = 35
        Me.cbIndGraf1.Text = "OK_%"
        Me.ToolTip1.SetToolTip(Me.cbIndGraf1, "Selecione o Indicador desejado. Deve ser diferente do selecionado no gráfico a ba" & _
        "ixo.")
        '
        'expandableSplitter2
        '
        Me.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.expandableSplitter2.ExpandableControl = Me.panelExEsquerdo
        Me.expandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.expandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.expandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.expandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.expandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.expandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.expandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.expandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.expandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.expandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(167, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.expandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.expandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.expandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.expandableSplitter2.Location = New System.Drawing.Point(177, 0)
        Me.expandableSplitter2.Name = "expandableSplitter2"
        Me.expandableSplitter2.Size = New System.Drawing.Size(5, 549)
        Me.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.expandableSplitter2.TabIndex = 1
        Me.expandableSplitter2.TabStop = False
        '
        'panelExEsquerdo
        '
        Me.panelExEsquerdo.Controls.Add(Me.SplitContainer3)
        Me.panelExEsquerdo.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelExEsquerdo.Location = New System.Drawing.Point(0, 0)
        Me.panelExEsquerdo.Name = "panelExEsquerdo"
        Me.panelExEsquerdo.Size = New System.Drawing.Size(177, 549)
        Me.panelExEsquerdo.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelExEsquerdo.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.panelExEsquerdo.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.panelExEsquerdo.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.panelExEsquerdo.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.panelExEsquerdo.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.panelExEsquerdo.Style.GradientAngle = 90
        Me.panelExEsquerdo.TabIndex = 0
        Me.panelExEsquerdo.Text = "Click to collapse"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.tcArvore)
        Me.SplitContainer3.Panel1MinSize = 0
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.btnExcel)
        Me.SplitContainer3.Panel2.Controls.Add(Me.dGridDDX)
        Me.SplitContainer3.Panel2MinSize = 0
        Me.SplitContainer3.Size = New System.Drawing.Size(177, 549)
        Me.SplitContainer3.SplitterDistance = 240
        Me.SplitContainer3.SplitterWidth = 2
        Me.SplitContainer3.TabIndex = 24
        '
        'tcArvore
        '
        Me.tcArvore.BackColor = System.Drawing.Color.Transparent
        Me.tcArvore.CanReorderTabs = True
        Me.tcArvore.Controls.Add(Me.TabControlPanel1)
        Me.tcArvore.Controls.Add(Me.TabControlPanel2)
        Me.tcArvore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tcArvore.Location = New System.Drawing.Point(0, 0)
        Me.tcArvore.Name = "tcArvore"
        Me.tcArvore.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tcArvore.SelectedTabIndex = 0
        Me.tcArvore.Size = New System.Drawing.Size(173, 236)
        Me.tcArvore.TabIndex = 40
        Me.tcArvore.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.MultilineNoNavigationBox
        Me.tcArvore.Tabs.Add(Me.tbiPeriodo)
        Me.tcArvore.Tabs.Add(Me.tbiArvore)
        Me.tcArvore.Text = "Árvore"
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.dtpDataFinal)
        Me.TabControlPanel1.Controls.Add(Me.dtpDataInicial)
        Me.TabControlPanel1.Controls.Add(Me.lbxDataFinal)
        Me.TabControlPanel1.Controls.Add(Me.mcaData)
        Me.TabControlPanel1.Controls.Add(Me.lbxDataInicial)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(173, 210)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel1.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.tbiPeriodo
        '
        'dtpDataFinal
        '
        Me.dtpDataFinal.CustomFormat = "yyyy-MM-dd"
        Me.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataFinal.Location = New System.Drawing.Point(85, 44)
        Me.dtpDataFinal.Name = "dtpDataFinal"
        Me.dtpDataFinal.Size = New System.Drawing.Size(84, 20)
        Me.dtpDataFinal.TabIndex = 47
        '
        'dtpDataInicial
        '
        Me.dtpDataInicial.CustomFormat = "yyyy-MM-dd"
        Me.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDataInicial.Location = New System.Drawing.Point(85, 5)
        Me.dtpDataInicial.Name = "dtpDataInicial"
        Me.dtpDataInicial.Size = New System.Drawing.Size(84, 20)
        Me.dtpDataInicial.TabIndex = 46
        '
        'lbxDataFinal
        '
        Me.lbxDataFinal.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.lbxDataFinal.BackgroundStyle.Class = ""
        Me.lbxDataFinal.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbxDataFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxDataFinal.Location = New System.Drawing.Point(0, 39)
        Me.lbxDataFinal.Name = "lbxDataFinal"
        Me.lbxDataFinal.Size = New System.Drawing.Size(171, 31)
        Me.lbxDataFinal.TabIndex = 45
        Me.lbxDataFinal.Text = "Data Final"
        '
        'mcaData
        '
        Me.mcaData.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mcaData.AnnuallyMarkedDates = New Date(-1) {}
        Me.mcaData.AutoSize = True
        '
        '
        '
        Me.mcaData.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.mcaData.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcaData.BackgroundStyle.BorderBottomWidth = 1
        Me.mcaData.BackgroundStyle.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.mcaData.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcaData.BackgroundStyle.BorderLeftWidth = 1
        Me.mcaData.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcaData.BackgroundStyle.BorderRightWidth = 1
        Me.mcaData.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.mcaData.BackgroundStyle.BorderTopWidth = 1
        Me.mcaData.BackgroundStyle.Class = ""
        Me.mcaData.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.mcaData.CommandsBackgroundStyle.Class = ""
        Me.mcaData.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcaData.ContainerControlProcessDialogKey = True
        Me.mcaData.DisplayMonth = New Date(2009, 4, 1, 0, 0, 0, 0)
        Me.mcaData.Location = New System.Drawing.Point(1, 76)
        Me.mcaData.MarkedDates = New Date(-1) {}
        Me.mcaData.MaxSelectionCount = 180
        Me.mcaData.MonthlyMarkedDates = New Date(-1) {}
        Me.mcaData.MultiSelect = True
        Me.mcaData.Name = "mcaData"
        '
        '
        '
        Me.mcaData.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.mcaData.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.mcaData.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.mcaData.NavigationBackgroundStyle.Class = ""
        Me.mcaData.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.mcaData.Size = New System.Drawing.Size(170, 128)
        Me.mcaData.TabIndex = 44
        Me.mcaData.TabStop = False
        Me.mcaData.Text = "Data Inicial"
        Me.ToolTip1.SetToolTip(Me.mcaData, "Clique no primeiro dia e arraste até o útimo para marcar o período.")
        Me.mcaData.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        '
        'lbxDataInicial
        '
        Me.lbxDataInicial.BackColor = System.Drawing.SystemColors.InactiveCaption
        '
        '
        '
        Me.lbxDataInicial.BackgroundStyle.Class = ""
        Me.lbxDataInicial.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lbxDataInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbxDataInicial.Location = New System.Drawing.Point(1, 0)
        Me.lbxDataInicial.Name = "lbxDataInicial"
        Me.lbxDataInicial.Size = New System.Drawing.Size(171, 31)
        Me.lbxDataInicial.TabIndex = 43
        Me.lbxDataInicial.Text = "Data Inicial"
        '
        'tbiPeriodo
        '
        Me.tbiPeriodo.AttachedControl = Me.TabControlPanel1
        Me.tbiPeriodo.Name = "tbiPeriodo"
        Me.tbiPeriodo.Text = "Período"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.TreeView1)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 26)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(173, 210)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.TabControlPanel2.Style.BorderSide = CType(((DevComponents.DotNetBar.eBorderSide.Left Or DevComponents.DotNetBar.eBorderSide.Right) _
            Or DevComponents.DotNetBar.eBorderSide.Bottom), DevComponents.DotNetBar.eBorderSide)
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.tbiArvore
        '
        'TreeView1
        '
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(1, 1)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(171, 208)
        Me.TreeView1.TabIndex = 39
        '
        'tbiArvore
        '
        Me.tbiArvore.AttachedControl = Me.TabControlPanel2
        Me.tbiArvore.Name = "tbiArvore"
        Me.tbiArvore.Text = "Árvore"
        '
        'btnExcel
        '
        Me.btnExcel.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExcel.Image = Global.SpyCdr.My.Resources.Resources.excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(0, 0)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(173, 29)
        Me.btnExcel.TabIndex = 38
        Me.btnExcel.Text = "Exportar p/ Excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'dGridDDX
        '
        Me.dGridDDX.AllowUserToAddRows = False
        Me.dGridDDX.AllowUserToDeleteRows = False
        Me.dGridDDX.AllowUserToOrderColumns = True
        Me.dGridDDX.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dGridDDX.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dGridDDX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGridDDX.Location = New System.Drawing.Point(0, 27)
        Me.dGridDDX.Name = "dGridDDX"
        Me.dGridDDX.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dGridDDX.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dGridDDX.RowHeadersWidth = 20
        Me.dGridDDX.Size = New System.Drawing.Size(173, 276)
        Me.dGridDDX.TabIndex = 22
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        '
        'ProgressBarX2
        '
        '
        '
        '
        Me.ProgressBarX2.BackgroundStyle.Class = ""
        Me.ProgressBarX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ProgressBarX2.ColorTable = DevComponents.DotNetBar.eProgressBarItemColor.Paused
        Me.ProgressBarX2.Location = New System.Drawing.Point(34, 262)
        Me.ProgressBarX2.Name = "ProgressBarX2"
        Me.ProgressBarX2.Size = New System.Drawing.Size(140, 20)
        Me.ProgressBarX2.TabIndex = 4
        Me.ProgressBarX2.Text = "ProgressBarX2"
        Me.ProgressBarX2.Value = 63
        '
        'node15
        '
        Me.node15.Name = "node15"
        Me.node15.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.node16, Me.node17, Me.node18})
        Me.node15.Text = "Check-boxes"
        '
        'node16
        '
        Me.node16.CheckBoxThreeState = True
        Me.node16.CheckBoxVisible = True
        Me.node16.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.node16.Name = "node16"
        Me.node16.Text = "Option 1 with 3-state"
        '
        'node17
        '
        Me.node17.CheckBoxVisible = True
        Me.node17.Name = "node17"
        Me.node17.Text = "Option 2"
        '
        'node18
        '
        Me.node18.Cells.Add(Me.cell17)
        Me.node18.CheckBoxVisible = True
        Me.node18.Name = "node18"
        Me.node18.Text = "Option 3"
        '
        'cell17
        '
        Me.cell17.CheckBoxVisible = True
        Me.cell17.Name = "cell17"
        Me.cell17.StyleMouseOver = Nothing
        Me.cell17.Text = "Option 3"
        '
        'node19
        '
        Me.node19.Name = "node19"
        Me.node19.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.node20, Me.node21, Me.node22})
        Me.node19.Text = "Radio-buttons"
        '
        'node20
        '
        Me.node20.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.node20.CheckBoxVisible = True
        Me.node20.Name = "node20"
        Me.node20.Text = "Option 1"
        '
        'node21
        '
        Me.node21.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.node21.CheckBoxVisible = True
        Me.node21.Name = "node21"
        Me.node21.Text = "Option 2"
        '
        'node22
        '
        Me.node22.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton
        Me.node22.CheckBoxVisible = True
        Me.node22.Name = "node22"
        Me.node22.Text = "Option 3"
        '
        'node23
        '
        Me.node23.Name = "node23"
        Me.node23.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.node24, Me.node25, Me.node26})
        Me.node23.Text = "Images"
        '
        'node24
        '
        Me.node24.Cells.Add(Me.cell18)
        Me.node24.Name = "node24"
        Me.node24.Text = "Multiple images per node"
        '
        'cell18
        '
        Me.cell18.Name = "cell18"
        Me.cell18.StyleMouseOver = Nothing
        '
        'node25
        '
        Me.node25.ImageAlignment = DevComponents.AdvTree.eCellPartAlignment.FarCenter
        Me.node25.Name = "node25"
        Me.node25.Text = "Image/text alignment"
        '
        'node26
        '
        Me.node26.CellPartLayout = DevComponents.AdvTree.eCellPartLayout.Vertical
        Me.node26.ImageAlignment = DevComponents.AdvTree.eCellPartAlignment.CenterTop
        Me.node26.Name = "node26"
        Me.node26.Text = "Orientation"
        '
        'node27
        '
        Me.node27.Name = "node27"
        Me.node27.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.node28})
        Me.node27.Text = "Text-markup support"
        '
        'node28
        '
        Me.node28.Name = "node28"
        Me.node28.Text = "DotNetBar <a href=""textmarkup"">text-markup</a> is fully supported"
        '
        'node29
        '
        Me.node29.Name = "node29"
        Me.node29.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.node30})
        Me.node29.Text = "Windows Forms Control Hosting"
        '
        'node30
        '
        Me.node30.HostedControl = Me.ProgressBarX2
        Me.node30.Name = "node30"
        Me.node30.Text = "Progress bar"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Azure
        Me.Chart1.BackGradientEndColor = System.Drawing.Color.SkyBlue
        Me.Chart1.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chart1.BorderLineColor = System.Drawing.Color.LightGray
        Me.Chart1.BorderSkin.FrameBackColor = System.Drawing.Color.LightSkyBlue
        Me.Chart1.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.DodgerBlue
        Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.AliceBlue
        ChartArea1.AxisX.LabelStyle.Interval = 0.0R
        ChartArea1.AxisX.LabelStyle.IntervalOffset = 0.0R
        ChartArea1.AxisX.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisX.MajorGrid.Interval = 0.0R
        ChartArea1.AxisX.MajorGrid.IntervalOffset = 0.0R
        ChartArea1.AxisX.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea1.AxisX.MajorTickMark.Interval = 0.0R
        ChartArea1.AxisX.MajorTickMark.IntervalOffset = 0.0R
        ChartArea1.AxisX.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisX2.LabelStyle.Interval = 0.0R
        ChartArea1.AxisX2.LabelStyle.IntervalOffset = 0.0R
        ChartArea1.AxisX2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisX2.MajorGrid.Interval = 0.0R
        ChartArea1.AxisX2.MajorGrid.IntervalOffset = 0.0R
        ChartArea1.AxisX2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorTickMark.Interval = 0.0R
        ChartArea1.AxisX2.MajorTickMark.IntervalOffset = 0.0R
        ChartArea1.AxisX2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisX2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.Interlaced = True
        ChartArea1.AxisY.LabelStyle.Interval = 0.0R
        ChartArea1.AxisY.LabelStyle.IntervalOffset = 0.0R
        ChartArea1.AxisY.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisY.MajorGrid.Interval = 0.0R
        ChartArea1.AxisY.MajorGrid.IntervalOffset = 0.0R
        ChartArea1.AxisY.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea1.AxisY.MajorTickMark.Interval = 0.0R
        ChartArea1.AxisY.MajorTickMark.IntervalOffset = 0.0R
        ChartArea1.AxisY.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisY.Title = "chamada"
        ChartArea1.AxisY2.LabelStyle.Interval = 0.0R
        ChartArea1.AxisY2.LabelStyle.IntervalOffset = 0.0R
        ChartArea1.AxisY2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.LineColor = System.Drawing.Color.DimGray
        ChartArea1.AxisY2.MajorGrid.Interval = 0.0R
        ChartArea1.AxisY2.MajorGrid.IntervalOffset = 0.0R
        ChartArea1.AxisY2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorTickMark.Interval = 0.0R
        ChartArea1.AxisY2.MajorTickMark.IntervalOffset = 0.0R
        ChartArea1.AxisY2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.AxisY2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea1.BackColor = System.Drawing.Color.LightCyan
        ChartArea1.BorderColor = System.Drawing.Color.DimGray
        ChartArea1.Name = "Chart Area 1"
        ChartArea1.ShadowOffset = 2
        ChartArea2.AxisX.LabelStyle.Interval = 0.0R
        ChartArea2.AxisX.LabelStyle.IntervalOffset = 0.0R
        ChartArea2.AxisX.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisX.MajorGrid.Interval = 0.0R
        ChartArea2.AxisX.MajorGrid.IntervalOffset = 0.0R
        ChartArea2.AxisX.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea2.AxisX.MajorTickMark.Interval = 0.0R
        ChartArea2.AxisX.MajorTickMark.IntervalOffset = 0.0R
        ChartArea2.AxisX.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisX2.LabelStyle.Interval = 0.0R
        ChartArea2.AxisX2.LabelStyle.IntervalOffset = 0.0R
        ChartArea2.AxisX2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX2.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisX2.MajorGrid.Interval = 0.0R
        ChartArea2.AxisX2.MajorGrid.IntervalOffset = 0.0R
        ChartArea2.AxisX2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX2.MajorTickMark.Interval = 0.0R
        ChartArea2.AxisX2.MajorTickMark.IntervalOffset = 0.0R
        ChartArea2.AxisX2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisX2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.Interlaced = True
        ChartArea2.AxisY.LabelStyle.Interval = 0.0R
        ChartArea2.AxisY.LabelStyle.IntervalOffset = 0.0R
        ChartArea2.AxisY.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY.MajorGrid.Interval = 0.0R
        ChartArea2.AxisY.MajorGrid.IntervalOffset = 0.0R
        ChartArea2.AxisY.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot
        ChartArea2.AxisY.MajorTickMark.Interval = 0.0R
        ChartArea2.AxisY.MajorTickMark.IntervalOffset = 0.0R
        ChartArea2.AxisY.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY.Title = "porcentual"
        ChartArea2.AxisY2.LabelStyle.Interval = 0.0R
        ChartArea2.AxisY2.LabelStyle.IntervalOffset = 0.0R
        ChartArea2.AxisY2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY2.LineColor = System.Drawing.Color.DimGray
        ChartArea2.AxisY2.MajorGrid.Interval = 0.0R
        ChartArea2.AxisY2.MajorGrid.IntervalOffset = 0.0R
        ChartArea2.AxisY2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY2.MajorTickMark.Interval = 0.0R
        ChartArea2.AxisY2.MajorTickMark.IntervalOffset = 0.0R
        ChartArea2.AxisY2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.AxisY2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea2.BackColor = System.Drawing.Color.Azure
        ChartArea2.BorderColor = System.Drawing.Color.DimGray
        ChartArea2.Name = "Chart Area 2"
        ChartArea2.ShadowOffset = 2
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.BackColor = System.Drawing.SystemColors.Window
        Legend1.BorderColor = System.Drawing.Color.AliceBlue
        Legend1.Docking = Dundas.Charting.WinControl.LegendDocking.Left
        Legend1.Name = "Default"
        Legend1.ShadowOffset = 2
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent
        Series1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Series1.BorderWidth = 2
        Series1.ChartArea = "Chart Area 1"
        Series1.ChartType = "StackedColumn"
        Series1.CustomAttributes = "LabelStyle=Top"
        Series1.Name = "Series1"
        Series1.ShowLabelAsValue = True
        Series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series1.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Series2.ChartArea = "Chart Area 2"
        Series2.ChartType = "StackedColumn"
        Series2.CustomAttributes = "LabelStyle=Top"
        Series2.Name = "Series2"
        Series2.XValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Series2.YValueType = Dundas.Charting.WinControl.ChartValueTypes.[Double]
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(833, 549)
        Me.Chart1.TabIndex = 36
        Me.Chart1.Text = "Chart1"
        Title1.Name = "Title1"
        Me.Chart1.Titles.Add(Title1)
        Me.Chart1.Visible = False
        '
        'frmHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(1015, 582)
        Me.Controls.Add(Me.SplitContainerPrincipal)
        Me.Name = "frmHistorico"
        Me.ShowIcon = False
        Me.Text = "Histórico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainerPrincipal.Panel1.ResumeLayout(False)
        Me.SplitContainerPrincipal.Panel1.PerformLayout()
        Me.SplitContainerPrincipal.Panel2.ResumeLayout(False)
        Me.SplitContainerPrincipal.ResumeLayout(False)
        Me.panel1.ResumeLayout(False)
        Me.panelEx3.ResumeLayout(False)
        Me.panelEx3.PerformLayout()
        Me.panelExEsquerdo.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        CType(Me.tcArvore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tcArvore.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        Me.TabControlPanel2.ResumeLayout(False)
        CType(Me.dGridDDX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chbValores As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainerPrincipal As System.Windows.Forms.SplitContainer
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents cbGrupo As System.Windows.Forms.ComboBox
    Friend WithEvents cbIntervalo As System.Windows.Forms.ComboBox
    Friend WithEvents cbHistorico As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents dGridDDX As System.Windows.Forms.DataGridView
    Friend WithEvents chbEventos As System.Windows.Forms.CheckBox
    Friend WithEvents cbIndGraf2 As System.Windows.Forms.ComboBox
    Friend WithEvents lblAguarde As System.Windows.Forms.Label
    Friend WithEvents cbIndGraf1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents panelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents expandableSplitter2 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents panelExEsquerdo As DevComponents.DotNetBar.PanelEx
    Private WithEvents ProgressBarX2 As DevComponents.DotNetBar.Controls.ProgressBarX
    Private WithEvents node15 As DevComponents.AdvTree.Node
    Private WithEvents node16 As DevComponents.AdvTree.Node
    Private WithEvents node17 As DevComponents.AdvTree.Node
    Private WithEvents node18 As DevComponents.AdvTree.Node
    Private WithEvents cell17 As DevComponents.AdvTree.Cell
    Private WithEvents node19 As DevComponents.AdvTree.Node
    Private WithEvents node20 As DevComponents.AdvTree.Node
    Private WithEvents node21 As DevComponents.AdvTree.Node
    Private WithEvents node22 As DevComponents.AdvTree.Node
    Private WithEvents node23 As DevComponents.AdvTree.Node
    Private WithEvents node24 As DevComponents.AdvTree.Node
    Private WithEvents cell18 As DevComponents.AdvTree.Cell
    Private WithEvents node25 As DevComponents.AdvTree.Node
    Private WithEvents node26 As DevComponents.AdvTree.Node
    Private WithEvents node27 As DevComponents.AdvTree.Node
    Private WithEvents node28 As DevComponents.AdvTree.Node
    Private WithEvents node29 As DevComponents.AdvTree.Node
    Private WithEvents node30 As DevComponents.AdvTree.Node
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents tcArvore As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tbiPeriodo As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tbiArvore As DevComponents.DotNetBar.TabItem
    Friend WithEvents mcaData As DevComponents.Editors.DateTimeAdv.MonthCalendarAdv
    Friend WithEvents lbxDataInicial As DevComponents.DotNetBar.LabelX
    Friend WithEvents lbxDataFinal As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpDataInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDataFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Chart1 As Dundas.Charting.WinControl.Chart
End Class
