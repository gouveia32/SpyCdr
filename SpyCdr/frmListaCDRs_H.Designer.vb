<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaCDRs_H
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
        Dim ChartArea9 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend9 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series9 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title9 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Dim ChartArea10 As Dundas.Charting.WinControl.ChartArea = New Dundas.Charting.WinControl.ChartArea()
        Dim Legend10 As Dundas.Charting.WinControl.Legend = New Dundas.Charting.WinControl.Legend()
        Dim Series10 As Dundas.Charting.WinControl.Series = New Dundas.Charting.WinControl.Series()
        Dim Title10 As Dundas.Charting.WinControl.Title = New Dundas.Charting.WinControl.Title()
        Dim TreeNode141 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("OK1")
        Dim TreeNode142 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("OK5")
        Dim TreeNode143 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode(" OK", New System.Windows.Forms.TreeNode() {TreeNode141, TreeNode142})
        Dim TreeNode144 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LCL")
        Dim TreeNode145 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LDN")
        Dim TreeNode146 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SNG")
        Dim TreeNode147 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LO", New System.Windows.Forms.TreeNode() {TreeNode144, TreeNode145, TreeNode146})
        Dim TreeNode148 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LCL")
        Dim TreeNode149 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LDN")
        Dim TreeNode150 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SNG")
        Dim TreeNode151 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("NR1", New System.Windows.Forms.TreeNode() {TreeNode148, TreeNode149, TreeNode150})
        Dim TreeNode152 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LCL")
        Dim TreeNode153 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("LDN")
        Dim TreeNode154 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SNG")
        Dim TreeNode155 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("NR5", New System.Windows.Forms.TreeNode() {TreeNode152, TreeNode153, TreeNode154})
        Dim TreeNode156 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("NR", New System.Windows.Forms.TreeNode() {TreeNode151, TreeNode155})
        Dim TreeNode157 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PAB", New System.Windows.Forms.TreeNode() {TreeNode147, TreeNode156})
        Dim TreeNode158 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CO0")
        Dim TreeNode159 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RTBI")
        Dim TreeNode160 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RTBE")
        Dim TreeNode161 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RTDC")
        Dim TreeNode162 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CO1", New System.Windows.Forms.TreeNode() {TreeNode159, TreeNode160, TreeNode161})
        Dim TreeNode163 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RTBI")
        Dim TreeNode164 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RTBE")
        Dim TreeNode165 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RTC")
        Dim TreeNode166 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CO2", New System.Windows.Forms.TreeNode() {TreeNode163, TreeNode164, TreeNode165})
        Dim TreeNode167 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("CO3")
        Dim TreeNode168 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode(" CO", New System.Windows.Forms.TreeNode() {TreeNode158, TreeNode162, TreeNode166, TreeNode167})
        Dim TreeNode169 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RTBI")
        Dim TreeNode170 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RTBE")
        Dim TreeNode171 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("RTDC")
        Dim TreeNode172 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DSC", New System.Windows.Forms.TreeNode() {TreeNode169, TreeNode170, TreeNode171})
        Dim TreeNode173 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode(" OU")
        Dim TreeNode174 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("NOK", New System.Windows.Forms.TreeNode() {TreeNode157, TreeNode168, TreeNode172, TreeNode173})
        Dim TreeNode175 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Todos CDRs", New System.Windows.Forms.TreeNode() {TreeNode143, TreeNode174})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaCDRs_H))
        Me.cbOperador3 = New System.Windows.Forms.ComboBox()
        Me.cbOperador2 = New System.Windows.Forms.ComboBox()
        Me.cbOperador1 = New System.Windows.Forms.ComboBox()
        Me.cbConector2 = New System.Windows.Forms.ComboBox()
        Me.cbCampo3 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCampo2 = New System.Windows.Forms.ComboBox()
        Me.chartBarra = New Dundas.Charting.WinControl.Chart()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbCampo1 = New System.Windows.Forms.ComboBox()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.tbcGrafico = New System.Windows.Forms.TabControl()
        Me.tpTorta = New System.Windows.Forms.TabPage()
        Me.chartPizza = New Dundas.Charting.WinControl.Chart()
        Me.tpDiagrama = New System.Windows.Forms.TabPage()
        Me.tvCausas = New System.Windows.Forms.TreeView()
        Me.txtSQL = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip()
        Me.mnuFechar = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbParenteseA2 = New System.Windows.Forms.CheckBox()
        Me.cbParenteseA5 = New System.Windows.Forms.CheckBox()
        Me.cbOperador5 = New System.Windows.Forms.ComboBox()
        Me.cbConector4 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbCampo5 = New System.Windows.Forms.ComboBox()
        Me.cbParenteseA4 = New System.Windows.Forms.CheckBox()
        Me.cbOperador4 = New System.Windows.Forms.ComboBox()
        Me.cbConector3 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbCampo4 = New System.Windows.Forms.ComboBox()
        Me.cbParenteseF5 = New System.Windows.Forms.CheckBox()
        Me.txtValor5 = New System.Windows.Forms.TextBox()
        Me.cbParenteseF4 = New System.Windows.Forms.CheckBox()
        Me.txtValor4 = New System.Windows.Forms.TextBox()
        Me.cbParenteseF1 = New System.Windows.Forms.CheckBox()
        Me.cbParenteseF2 = New System.Windows.Forms.CheckBox()
        Me.cbParenteseF3 = New System.Windows.Forms.CheckBox()
        Me.txtValor3 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.pb1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager()
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite8 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite5 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite6 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite7 = New DevComponents.DotNetBar.DockSite()
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite()
        Me.expandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.panelExSuperior = New DevComponents.DotNetBar.PanelEx()
        Me.tbcPainelSuperior = New DevComponents.DotNetBar.TabControl()
        Me.TabControlPanel1 = New DevComponents.DotNetBar.TabControlPanel()
        Me.cbConector1 = New System.Windows.Forms.ComboBox()
        Me.nuDias = New System.Windows.Forms.NumericUpDown()
        Me.txtSEL = New System.Windows.Forms.TextBox()
        Me.btnSEL = New System.Windows.Forms.Button()
        Me.tbiCriterios = New DevComponents.DotNetBar.TabItem()
        Me.TabControlPanel2 = New DevComponents.DotNetBar.TabControlPanel()
        Me.tbiSQL = New DevComponents.DotNetBar.TabItem()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.panelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.gcCDRs = New DevExpress.XtraGrid.GridControl()
        Me.gvCDRs = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CLASSIF = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DATA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DURACAO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Ass_A = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENTE_A = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R_ENT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ROTA_E = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CSP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ASS_B = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CLIENTE_B = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.R_SAI = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ROTA_S = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RN2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RN3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PT = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Dialed_Number = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Caller_Category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Bill_Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Free_Ind = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Charged_Party_Ind = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Call_Type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GSVN = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Failure_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Termination_Code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Bearer_Service = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Tele_Service = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RxFlus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TxFlus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Caller_GK_Address = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Caller_GW_Address = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Called_GK_Address = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Called_GW_Address = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.expandableSplitter2 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.panelExEsquerdo = New DevComponents.DotNetBar.PanelEx()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager()
        Me.cbParenteseA1 = New DevComponents.DotNetBar.Controls.CheckBoxX()
        CType(Me.chartBarra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.tbcGrafico.SuspendLayout()
        Me.tpTorta.SuspendLayout()
        CType(Me.chartPizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDiagrama.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.panelExSuperior.SuspendLayout()
        CType(Me.tbcPainelSuperior, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbcPainelSuperior.SuspendLayout()
        Me.TabControlPanel1.SuspendLayout()
        CType(Me.nuDias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlPanel2.SuspendLayout()
        Me.panel1.SuspendLayout()
        Me.panelEx3.SuspendLayout()
        CType(Me.gcCDRs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCDRs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelExEsquerdo.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbOperador3
        '
        Me.cbOperador3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperador3.FormattingEnabled = True
        Me.cbOperador3.Items.AddRange(New Object() {"=", "<>", ">", ">=", "<", "<=", "LIKE", "NOT LIKE"})
        Me.cbOperador3.Location = New System.Drawing.Point(205, 27)
        Me.cbOperador3.Name = "cbOperador3"
        Me.cbOperador3.Size = New System.Drawing.Size(54, 20)
        Me.cbOperador3.TabIndex = 52
        Me.cbOperador3.Text = "="
        '
        'cbOperador2
        '
        Me.cbOperador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperador2.FormattingEnabled = True
        Me.cbOperador2.Items.AddRange(New Object() {"=", "<>", ">", ">=", "<", "<=", "LIKE", "NOT LIKE"})
        Me.cbOperador2.Location = New System.Drawing.Point(739, 6)
        Me.cbOperador2.Name = "cbOperador2"
        Me.cbOperador2.Size = New System.Drawing.Size(54, 20)
        Me.cbOperador2.TabIndex = 51
        Me.cbOperador2.Text = "="
        '
        'cbOperador1
        '
        Me.cbOperador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperador1.FormattingEnabled = True
        Me.cbOperador1.Items.AddRange(New Object() {"=", "<>", ">", ">=", "<", "<=", "LIKE", "NOT LIKE"})
        Me.cbOperador1.Location = New System.Drawing.Point(205, 6)
        Me.cbOperador1.Name = "cbOperador1"
        Me.cbOperador1.Size = New System.Drawing.Size(54, 20)
        Me.cbOperador1.TabIndex = 50
        Me.cbOperador1.Text = "="
        '
        'cbConector2
        '
        Me.cbConector2.FormattingEnabled = True
        Me.cbConector2.Items.AddRange(New Object() {"E", "OU"})
        Me.cbConector2.Location = New System.Drawing.Point(6, 27)
        Me.cbConector2.Name = "cbConector2"
        Me.cbConector2.Size = New System.Drawing.Size(42, 21)
        Me.cbConector2.TabIndex = 49
        Me.cbConector2.Text = "E"
        '
        'cbCampo3
        '
        Me.cbCampo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCampo3.FormattingEnabled = True
        Me.cbCampo3.Items.AddRange(New Object() {"ASS_A", "ASS_B", "R_ENT", "R_SAI", "CAT", "FDS", "EOS"})
        Me.cbCampo3.Location = New System.Drawing.Point(125, 27)
        Me.cbCampo3.Name = "cbCampo3"
        Me.cbCampo3.Size = New System.Drawing.Size(79, 20)
        Me.cbCampo3.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(613, 6)
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
        Me.cbCampo2.Location = New System.Drawing.Point(659, 6)
        Me.cbCampo2.Name = "cbCampo2"
        Me.cbCampo2.Size = New System.Drawing.Size(79, 20)
        Me.cbCampo2.TabIndex = 42
        '
        'chartBarra
        '
        Me.chartBarra.BackColor = System.Drawing.Color.LightSteelBlue
        Me.chartBarra.BorderLineColor = System.Drawing.Color.LightSlateGray
        Me.chartBarra.BorderSkin.FrameBackColor = System.Drawing.Color.SteelBlue
        Me.chartBarra.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.LightBlue
        ChartArea9.AxisX.LabelStyle.Interval = 0.0R
        ChartArea9.AxisX.LabelStyle.IntervalOffset = 0.0R
        ChartArea9.AxisX.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisX.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisX.MajorGrid.Interval = 0.0R
        ChartArea9.AxisX.MajorGrid.IntervalOffset = 0.0R
        ChartArea9.AxisX.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisX.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightSteelBlue
        ChartArea9.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea9.AxisX.MajorTickMark.Interval = 0.0R
        ChartArea9.AxisX.MajorTickMark.IntervalOffset = 0.0R
        ChartArea9.AxisX.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisX.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea9.AxisX2.LabelStyle.Interval = 0.0R
        ChartArea9.AxisX2.LabelStyle.IntervalOffset = 0.0R
        ChartArea9.AxisX2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisX2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisX2.MajorGrid.Interval = 0.0R
        ChartArea9.AxisX2.MajorGrid.IntervalOffset = 0.0R
        ChartArea9.AxisX2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisX2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisX2.MajorTickMark.Interval = 0.0R
        ChartArea9.AxisX2.MajorTickMark.IntervalOffset = 0.0R
        ChartArea9.AxisX2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisX2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisY.LabelStyle.Interval = 0.0R
        ChartArea9.AxisY.LabelStyle.IntervalOffset = 0.0R
        ChartArea9.AxisY.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisY.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisY.MajorGrid.Interval = 0.0R
        ChartArea9.AxisY.MajorGrid.IntervalOffset = 0.0R
        ChartArea9.AxisY.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisY.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisY.MajorGrid.LineColor = System.Drawing.Color.LightSteelBlue
        ChartArea9.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dash
        ChartArea9.AxisY.MajorTickMark.Interval = 0.0R
        ChartArea9.AxisY.MajorTickMark.IntervalOffset = 0.0R
        ChartArea9.AxisY.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisY.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisY.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea9.AxisY2.LabelStyle.Interval = 0.0R
        ChartArea9.AxisY2.LabelStyle.IntervalOffset = 0.0R
        ChartArea9.AxisY2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisY2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisY2.MajorGrid.Interval = 0.0R
        ChartArea9.AxisY2.MajorGrid.IntervalOffset = 0.0R
        ChartArea9.AxisY2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisY2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisY2.MajorTickMark.Interval = 0.0R
        ChartArea9.AxisY2.MajorTickMark.IntervalOffset = 0.0R
        ChartArea9.AxisY2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.AxisY2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea9.BackColor = System.Drawing.Color.Lavender
        ChartArea9.BorderColor = System.Drawing.Color.Empty
        ChartArea9.Name = "Default"
        ChartArea9.ShadowOffset = 2
        Me.chartBarra.ChartAreas.Add(ChartArea9)
        Me.chartBarra.Dock = System.Windows.Forms.DockStyle.Fill
        Legend9.BackColor = System.Drawing.Color.Lavender
        Legend9.BorderColor = System.Drawing.Color.Gray
        Legend9.Enabled = False
        Legend9.Name = "Default"
        Legend9.ShadowOffset = 2
        Me.chartBarra.Legends.Add(Legend9)
        Me.chartBarra.Location = New System.Drawing.Point(0, 0)
        Me.chartBarra.Name = "chartBarra"
        Me.chartBarra.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel
        Series9.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Series9.CustomAttributes = "LabelStyle=Top"
        Series9.Name = "Series1"
        Series9.ShadowOffset = 2
        Series9.ShowLabelAsValue = True
        Me.chartBarra.Series.Add(Series9)
        Me.chartBarra.Size = New System.Drawing.Size(246, 176)
        Me.chartBarra.TabIndex = 33
        Me.chartBarra.Text = "Chart1"
        Title9.Name = "Principal"
        Me.chartBarra.Titles.Add(Title9)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(79, 6)
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
        Me.cbCampo1.Location = New System.Drawing.Point(125, 6)
        Me.cbCampo1.Name = "cbCampo1"
        Me.cbCampo1.Size = New System.Drawing.Size(79, 20)
        Me.cbCampo1.TabIndex = 39
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
        Me.SplitContainer4.SplitterDistance = 203
        Me.SplitContainer4.TabIndex = 36
        '
        'tbcGrafico
        '
        Me.tbcGrafico.Controls.Add(Me.tpTorta)
        Me.tbcGrafico.Controls.Add(Me.tpDiagrama)
        Me.tbcGrafico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcGrafico.Location = New System.Drawing.Point(0, 0)
        Me.tbcGrafico.Name = "tbcGrafico"
        Me.tbcGrafico.SelectedIndex = 0
        Me.tbcGrafico.Size = New System.Drawing.Size(246, 199)
        Me.tbcGrafico.TabIndex = 1
        '
        'tpTorta
        '
        Me.tpTorta.Controls.Add(Me.chartPizza)
        Me.tpTorta.Location = New System.Drawing.Point(4, 22)
        Me.tpTorta.Name = "tpTorta"
        Me.tpTorta.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTorta.Size = New System.Drawing.Size(238, 173)
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
        ChartArea10.Area3DStyle.Light = Dundas.Charting.WinControl.LightStyle.Realistic
        ChartArea10.AxisX.LabelStyle.Format = "G"
        ChartArea10.AxisX.LabelStyle.Interval = 0.0R
        ChartArea10.AxisX.LabelStyle.IntervalOffset = 0.0R
        ChartArea10.AxisX.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisX.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisX.MajorGrid.Interval = 0.0R
        ChartArea10.AxisX.MajorGrid.IntervalOffset = 0.0R
        ChartArea10.AxisX.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisX.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea10.AxisX.MajorTickMark.Interval = 0.0R
        ChartArea10.AxisX.MajorTickMark.IntervalOffset = 0.0R
        ChartArea10.AxisX.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisX.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisX.MajorTickMark.Style = Dundas.Charting.WinControl.TickMarkStyle.Cross
        ChartArea10.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea10.AxisX2.LabelStyle.Interval = 0.0R
        ChartArea10.AxisX2.LabelStyle.IntervalOffset = 0.0R
        ChartArea10.AxisX2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisX2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisX2.MajorGrid.Interval = 0.0R
        ChartArea10.AxisX2.MajorGrid.IntervalOffset = 0.0R
        ChartArea10.AxisX2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisX2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea10.AxisX2.MajorTickMark.Interval = 0.0R
        ChartArea10.AxisX2.MajorTickMark.IntervalOffset = 0.0R
        ChartArea10.AxisX2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisX2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea10.AxisY.LabelStyle.Interval = 0.0R
        ChartArea10.AxisY.LabelStyle.IntervalOffset = 0.0R
        ChartArea10.AxisY.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisY.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisY.MajorGrid.Interval = 0.0R
        ChartArea10.AxisY.MajorGrid.IntervalOffset = 0.0R
        ChartArea10.AxisY.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisY.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea10.AxisY.MajorTickMark.Interval = 0.0R
        ChartArea10.AxisY.MajorTickMark.IntervalOffset = 0.0R
        ChartArea10.AxisY.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisY.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea10.AxisY.Title = "chamada"
        ChartArea10.AxisY2.LabelStyle.Interval = 0.0R
        ChartArea10.AxisY2.LabelStyle.IntervalOffset = 0.0R
        ChartArea10.AxisY2.LabelStyle.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisY2.LabelStyle.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisY2.MajorGrid.Interval = 0.0R
        ChartArea10.AxisY2.MajorGrid.IntervalOffset = 0.0R
        ChartArea10.AxisY2.MajorGrid.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisY2.MajorGrid.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea10.AxisY2.MajorTickMark.Interval = 0.0R
        ChartArea10.AxisY2.MajorTickMark.IntervalOffset = 0.0R
        ChartArea10.AxisY2.MajorTickMark.IntervalOffsetType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisY2.MajorTickMark.IntervalType = Dundas.Charting.WinControl.DateTimeIntervalType.[Auto]
        ChartArea10.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Silver
        ChartArea10.BackColor = System.Drawing.Color.Transparent
        ChartArea10.BorderColor = System.Drawing.Color.Empty
        ChartArea10.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid
        ChartArea10.Name = "Default"
        Me.chartPizza.ChartAreas.Add(ChartArea10)
        Me.chartPizza.Dock = System.Windows.Forms.DockStyle.Fill
        Legend10.Alignment = System.Drawing.StringAlignment.Center
        Legend10.BackColor = System.Drawing.Color.White
        Legend10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Legend10.Docking = Dundas.Charting.WinControl.LegendDocking.Left
        Legend10.LegendStyle = Dundas.Charting.WinControl.LegendStyle.Column
        Legend10.Name = "Default"
        Legend10.ShadowOffset = 2
        Me.chartPizza.Legends.Add(Legend10)
        Me.chartPizza.Location = New System.Drawing.Point(3, 3)
        Me.chartPizza.Name = "chartPizza"
        Me.chartPizza.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas
        Series10.BorderColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(105, Byte), Integer))
        Series10.ChartType = "Pie"
        Series10.CustomAttributes = "PieLabelStyle=Inside"
        Series10.Name = "Series1"
        Series10.ShadowOffset = 2
        Series10.ShowLabelAsValue = True
        Me.chartPizza.Series.Add(Series10)
        Me.chartPizza.Size = New System.Drawing.Size(232, 167)
        Me.chartPizza.TabIndex = 34
        Me.chartPizza.Text = "Chart2"
        Title10.Name = "Principal"
        Me.chartPizza.Titles.Add(Title10)
        '
        'tpDiagrama
        '
        Me.tpDiagrama.Controls.Add(Me.tvCausas)
        Me.tpDiagrama.Location = New System.Drawing.Point(4, 22)
        Me.tpDiagrama.Name = "tpDiagrama"
        Me.tpDiagrama.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDiagrama.Size = New System.Drawing.Size(238, 173)
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
        TreeNode141.Name = "OK1"
        TreeNode141.Text = "OK1"
        TreeNode142.Name = "OK5"
        TreeNode142.Text = "OK5"
        TreeNode143.Name = "OK"
        TreeNode143.Text = " OK"
        TreeNode144.Name = "LCL"
        TreeNode144.Text = "LCL"
        TreeNode145.Name = "LDN"
        TreeNode145.Text = "LDN"
        TreeNode146.Name = "SNG"
        TreeNode146.Text = "SNG"
        TreeNode147.Name = "LO"
        TreeNode147.Text = "LO"
        TreeNode148.Name = "LCL"
        TreeNode148.Text = "LCL"
        TreeNode149.Name = "LDN"
        TreeNode149.Text = "LDN"
        TreeNode150.Name = "SNG"
        TreeNode150.Text = "SNG"
        TreeNode151.Name = "NR1"
        TreeNode151.Text = "NR1"
        TreeNode152.Name = "LCL"
        TreeNode152.Text = "LCL"
        TreeNode153.Name = "LDN"
        TreeNode153.Text = "LDN"
        TreeNode154.Name = "SNG"
        TreeNode154.Text = "SNG"
        TreeNode155.Name = "NR5"
        TreeNode155.Text = "NR5"
        TreeNode156.Name = "NR"
        TreeNode156.Text = "NR"
        TreeNode157.Name = "PAB"
        TreeNode157.Text = "PAB"
        TreeNode158.Name = "CO0"
        TreeNode158.Text = "CO0"
        TreeNode159.Name = "RTBI"
        TreeNode159.Text = "RTBI"
        TreeNode160.Name = "RTBE"
        TreeNode160.Text = "RTBE"
        TreeNode161.Name = "RTDC"
        TreeNode161.Text = "RTDC"
        TreeNode162.Name = "CO1"
        TreeNode162.Text = "CO1"
        TreeNode163.Name = "RTBI"
        TreeNode163.Text = "RTBI"
        TreeNode164.Name = "RTBE"
        TreeNode164.Text = "RTBE"
        TreeNode165.Name = "RTDC"
        TreeNode165.Text = "RTC"
        TreeNode166.Name = "CO2"
        TreeNode166.Text = "CO2"
        TreeNode167.Name = "CO3"
        TreeNode167.Text = "CO3"
        TreeNode168.Name = "CO"
        TreeNode168.Text = " CO"
        TreeNode169.Name = "RTBI"
        TreeNode169.Text = "RTBI"
        TreeNode170.Name = "RTBE"
        TreeNode170.Text = "RTBE"
        TreeNode171.Name = "RTDC"
        TreeNode171.Text = "RTDC"
        TreeNode172.Name = "DSC"
        TreeNode172.Text = "DSC"
        TreeNode173.Name = "OU"
        TreeNode173.Text = " OU"
        TreeNode174.Name = "NOK"
        TreeNode174.Text = "NOK"
        TreeNode175.Name = "Todos CDRs"
        TreeNode175.Text = "Todos CDRs"
        Me.tvCausas.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode175})
        Me.tvCausas.Size = New System.Drawing.Size(232, 167)
        Me.tvCausas.TabIndex = 38
        '
        'txtSQL
        '
        Me.txtSQL.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSQL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQL.Location = New System.Drawing.Point(1, 1)
        Me.txtSQL.Multiline = True
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSQL.Size = New System.Drawing.Size(1075, 75)
        Me.txtSQL.TabIndex = 40
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFechar})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(110, 26)
        '
        'mnuFechar
        '
        Me.mnuFechar.Image = Global.SpyCdr.My.Resources.Resources.down
        Me.mnuFechar.Name = "mnuFechar"
        Me.mnuFechar.Size = New System.Drawing.Size(109, 22)
        Me.mnuFechar.Text = "Fechar"
        '
        'cbParenteseA2
        '
        Me.cbParenteseA2.AutoSize = True
        Me.cbParenteseA2.BackColor = System.Drawing.Color.Transparent
        Me.cbParenteseA2.Location = New System.Drawing.Point(589, 6)
        Me.cbParenteseA2.Name = "cbParenteseA2"
        Me.cbParenteseA2.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseA2.TabIndex = 58
        Me.cbParenteseA2.Text = "("
        Me.cbParenteseA2.UseVisualStyleBackColor = False
        '
        'cbParenteseA5
        '
        Me.cbParenteseA5.AutoSize = True
        Me.cbParenteseA5.BackColor = System.Drawing.Color.Transparent
        Me.cbParenteseA5.Location = New System.Drawing.Point(55, 49)
        Me.cbParenteseA5.Name = "cbParenteseA5"
        Me.cbParenteseA5.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseA5.TabIndex = 74
        Me.cbParenteseA5.Text = "("
        Me.cbParenteseA5.UseVisualStyleBackColor = False
        '
        'cbOperador5
        '
        Me.cbOperador5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperador5.FormattingEnabled = True
        Me.cbOperador5.Items.AddRange(New Object() {"=", "<>", ">", ">=", "<", "<=", "LIKE", "NOT LIKE"})
        Me.cbOperador5.Location = New System.Drawing.Point(206, 49)
        Me.cbOperador5.Name = "cbOperador5"
        Me.cbOperador5.Size = New System.Drawing.Size(54, 20)
        Me.cbOperador5.TabIndex = 72
        Me.cbOperador5.Text = "="
        '
        'cbConector4
        '
        Me.cbConector4.FormattingEnabled = True
        Me.cbConector4.Items.AddRange(New Object() {"E", "OU"})
        Me.cbConector4.Location = New System.Drawing.Point(7, 49)
        Me.cbConector4.Name = "cbConector4"
        Me.cbConector4.Size = New System.Drawing.Size(42, 21)
        Me.cbConector4.TabIndex = 71
        Me.cbConector4.Text = "E"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(80, 49)
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
        Me.cbCampo5.Location = New System.Drawing.Point(126, 49)
        Me.cbCampo5.Name = "cbCampo5"
        Me.cbCampo5.Size = New System.Drawing.Size(79, 20)
        Me.cbCampo5.TabIndex = 68
        '
        'cbParenteseA4
        '
        Me.cbParenteseA4.AutoSize = True
        Me.cbParenteseA4.BackColor = System.Drawing.Color.Transparent
        Me.cbParenteseA4.Location = New System.Drawing.Point(588, 27)
        Me.cbParenteseA4.Name = "cbParenteseA4"
        Me.cbParenteseA4.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseA4.TabIndex = 67
        Me.cbParenteseA4.Text = "("
        Me.cbParenteseA4.UseVisualStyleBackColor = False
        '
        'cbOperador4
        '
        Me.cbOperador4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbOperador4.FormattingEnabled = True
        Me.cbOperador4.Items.AddRange(New Object() {"=", "<>", ">", ">=", "<", "<=", "LIKE", "NOT LIKE"})
        Me.cbOperador4.Location = New System.Drawing.Point(739, 27)
        Me.cbOperador4.Name = "cbOperador4"
        Me.cbOperador4.Size = New System.Drawing.Size(54, 20)
        Me.cbOperador4.TabIndex = 65
        Me.cbOperador4.Text = "="
        '
        'cbConector3
        '
        Me.cbConector3.FormattingEnabled = True
        Me.cbConector3.Items.AddRange(New Object() {"E", "OU"})
        Me.cbConector3.Location = New System.Drawing.Point(539, 27)
        Me.cbConector3.Name = "cbConector3"
        Me.cbConector3.Size = New System.Drawing.Size(44, 21)
        Me.cbConector3.TabIndex = 64
        Me.cbConector3.Text = "E"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(613, 27)
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
        Me.cbCampo4.Location = New System.Drawing.Point(659, 27)
        Me.cbCampo4.Name = "cbCampo4"
        Me.cbCampo4.Size = New System.Drawing.Size(79, 20)
        Me.cbCampo4.TabIndex = 61
        '
        'cbParenteseF5
        '
        Me.cbParenteseF5.AutoSize = True
        Me.cbParenteseF5.BackColor = System.Drawing.Color.Transparent
        Me.cbParenteseF5.Location = New System.Drawing.Point(506, 49)
        Me.cbParenteseF5.Name = "cbParenteseF5"
        Me.cbParenteseF5.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseF5.TabIndex = 98
        Me.cbParenteseF5.Text = ")"
        Me.cbParenteseF5.UseVisualStyleBackColor = False
        '
        'txtValor5
        '
        Me.txtValor5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor5.Location = New System.Drawing.Point(263, 49)
        Me.txtValor5.Name = "txtValor5"
        Me.txtValor5.Size = New System.Drawing.Size(238, 18)
        Me.txtValor5.TabIndex = 97
        '
        'cbParenteseF4
        '
        Me.cbParenteseF4.AutoSize = True
        Me.cbParenteseF4.BackColor = System.Drawing.Color.Transparent
        Me.cbParenteseF4.Location = New System.Drawing.Point(1039, 27)
        Me.cbParenteseF4.Name = "cbParenteseF4"
        Me.cbParenteseF4.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseF4.TabIndex = 96
        Me.cbParenteseF4.Text = ")"
        Me.cbParenteseF4.UseVisualStyleBackColor = False
        '
        'txtValor4
        '
        Me.txtValor4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor4.Location = New System.Drawing.Point(796, 27)
        Me.txtValor4.Name = "txtValor4"
        Me.txtValor4.Size = New System.Drawing.Size(238, 18)
        Me.txtValor4.TabIndex = 95
        '
        'cbParenteseF1
        '
        Me.cbParenteseF1.AutoSize = True
        Me.cbParenteseF1.BackColor = System.Drawing.Color.Transparent
        Me.cbParenteseF1.Location = New System.Drawing.Point(505, 6)
        Me.cbParenteseF1.Name = "cbParenteseF1"
        Me.cbParenteseF1.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseF1.TabIndex = 94
        Me.cbParenteseF1.Text = ")"
        Me.cbParenteseF1.UseVisualStyleBackColor = False
        '
        'cbParenteseF2
        '
        Me.cbParenteseF2.AutoSize = True
        Me.cbParenteseF2.BackColor = System.Drawing.Color.Transparent
        Me.cbParenteseF2.Location = New System.Drawing.Point(1039, 6)
        Me.cbParenteseF2.Name = "cbParenteseF2"
        Me.cbParenteseF2.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseF2.TabIndex = 93
        Me.cbParenteseF2.Text = ")"
        Me.cbParenteseF2.UseVisualStyleBackColor = False
        '
        'cbParenteseF3
        '
        Me.cbParenteseF3.AutoSize = True
        Me.cbParenteseF3.BackColor = System.Drawing.Color.Transparent
        Me.cbParenteseF3.Location = New System.Drawing.Point(505, 27)
        Me.cbParenteseF3.Name = "cbParenteseF3"
        Me.cbParenteseF3.Size = New System.Drawing.Size(29, 17)
        Me.cbParenteseF3.TabIndex = 92
        Me.cbParenteseF3.Text = ")"
        Me.cbParenteseF3.UseVisualStyleBackColor = False
        '
        'txtValor3
        '
        Me.txtValor3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor3.Location = New System.Drawing.Point(262, 27)
        Me.txtValor3.Name = "txtValor3"
        Me.txtValor3.Size = New System.Drawing.Size(238, 18)
        Me.txtValor3.TabIndex = 90
        '
        'txtValor2
        '
        Me.txtValor2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor2.Location = New System.Drawing.Point(796, 6)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(238, 18)
        Me.txtValor2.TabIndex = 89
        '
        'txtValor1
        '
        Me.txtValor1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor1.Location = New System.Drawing.Point(262, 6)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(238, 18)
        Me.txtValor1.TabIndex = 88
        '
        'pb1
        '
        '
        '
        '
        Me.pb1.BackgroundStyle.Class = ""
        Me.pb1.Location = New System.Drawing.Point(0, 0)
        Me.pb1.Name = "pb1"
        Me.pb1.Size = New System.Drawing.Size(239, 20)
        Me.pb1.TabIndex = 117
        Me.pb1.TextVisible = True
        Me.pb1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DotNetBarManager1
        '
        Me.DotNetBarManager1.BottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.EnableFullSizeDock = False
        Me.DotNetBarManager1.LeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.ParentForm = Me
        Me.DotNetBarManager1.RightDockSite = Me.DockSite2
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
        Me.DockSite4.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite4.Location = New System.Drawing.Point(0, 552)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(1077, 0)
        Me.DockSite4.TabIndex = 43
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite1.Location = New System.Drawing.Point(0, 0)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 552)
        Me.DockSite1.TabIndex = 40
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite2.Location = New System.Drawing.Point(1077, 0)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 552)
        Me.DockSite2.TabIndex = 41
        Me.DockSite2.TabStop = False
        '
        'DockSite8
        '
        Me.DockSite8.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite8.Location = New System.Drawing.Point(0, 552)
        Me.DockSite8.Name = "DockSite8"
        Me.DockSite8.Size = New System.Drawing.Size(1077, 0)
        Me.DockSite8.TabIndex = 47
        Me.DockSite8.TabStop = False
        '
        'DockSite5
        '
        Me.DockSite5.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite5.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite5.Location = New System.Drawing.Point(0, 0)
        Me.DockSite5.Name = "DockSite5"
        Me.DockSite5.Size = New System.Drawing.Size(0, 552)
        Me.DockSite5.TabIndex = 44
        Me.DockSite5.TabStop = False
        '
        'DockSite6
        '
        Me.DockSite6.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite6.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite6.Location = New System.Drawing.Point(1077, 0)
        Me.DockSite6.Name = "DockSite6"
        Me.DockSite6.Size = New System.Drawing.Size(0, 552)
        Me.DockSite6.TabIndex = 45
        Me.DockSite6.TabStop = False
        '
        'DockSite7
        '
        Me.DockSite7.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite7.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite7.Location = New System.Drawing.Point(0, 0)
        Me.DockSite7.Name = "DockSite7"
        Me.DockSite7.Size = New System.Drawing.Size(1077, 0)
        Me.DockSite7.TabIndex = 46
        Me.DockSite7.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.DocumentDockContainer = New DevComponents.DotNetBar.DocumentDockContainer()
        Me.DockSite3.Location = New System.Drawing.Point(0, 0)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(1077, 0)
        Me.DockSite3.TabIndex = 42
        Me.DockSite3.TabStop = False
        '
        'expandableSplitter1
        '
        Me.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.expandableSplitter1.ExpandableControl = Me.panelExSuperior
        Me.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.expandableSplitter1.Location = New System.Drawing.Point(0, 99)
        Me.expandableSplitter1.Name = "expandableSplitter1"
        Me.expandableSplitter1.Size = New System.Drawing.Size(1077, 5)
        Me.expandableSplitter1.TabIndex = 54
        Me.expandableSplitter1.TabStop = False
        '
        'panelExSuperior
        '
        Me.panelExSuperior.Controls.Add(Me.tbcPainelSuperior)
        Me.panelExSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelExSuperior.Location = New System.Drawing.Point(0, 0)
        Me.panelExSuperior.Name = "panelExSuperior"
        Me.panelExSuperior.Size = New System.Drawing.Size(1077, 99)
        Me.panelExSuperior.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelExSuperior.Style.GradientAngle = 90
        Me.panelExSuperior.Style.WordWrap = True
        Me.panelExSuperior.TabIndex = 53
        Me.panelExSuperior.Text = "Click to collapse"
        '
        'tbcPainelSuperior
        '
        Me.tbcPainelSuperior.BackColor = System.Drawing.Color.Transparent
        Me.tbcPainelSuperior.CanReorderTabs = False
        Me.tbcPainelSuperior.Controls.Add(Me.TabControlPanel1)
        Me.tbcPainelSuperior.Controls.Add(Me.TabControlPanel2)
        Me.tbcPainelSuperior.Location = New System.Drawing.Point(12, 5)
        Me.tbcPainelSuperior.Name = "tbcPainelSuperior"
        Me.tbcPainelSuperior.SelectedTabFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tbcPainelSuperior.SelectedTabIndex = 0
        Me.tbcPainelSuperior.Size = New System.Drawing.Size(1077, 99)
        Me.tbcPainelSuperior.TabIndex = 0
        Me.tbcPainelSuperior.Tabs.Add(Me.tbiCriterios)
        Me.tbcPainelSuperior.Tabs.Add(Me.tbiSQL)
        Me.tbcPainelSuperior.ThemeAware = True
        '
        'TabControlPanel1
        '
        Me.TabControlPanel1.Controls.Add(Me.cbParenteseA1)
        Me.TabControlPanel1.Controls.Add(Me.cbConector1)
        Me.TabControlPanel1.Controls.Add(Me.cbCampo1)
        Me.TabControlPanel1.Controls.Add(Me.cbCampo3)
        Me.TabControlPanel1.Controls.Add(Me.cbCampo5)
        Me.TabControlPanel1.Controls.Add(Me.Label6)
        Me.TabControlPanel1.Controls.Add(Me.nuDias)
        Me.TabControlPanel1.Controls.Add(Me.txtSEL)
        Me.TabControlPanel1.Controls.Add(Me.cbParenteseF5)
        Me.TabControlPanel1.Controls.Add(Me.btnSEL)
        Me.TabControlPanel1.Controls.Add(Me.txtValor1)
        Me.TabControlPanel1.Controls.Add(Me.txtValor5)
        Me.TabControlPanel1.Controls.Add(Me.cbParenteseF4)
        Me.TabControlPanel1.Controls.Add(Me.Label2)
        Me.TabControlPanel1.Controls.Add(Me.txtValor4)
        Me.TabControlPanel1.Controls.Add(Me.cbCampo2)
        Me.TabControlPanel1.Controls.Add(Me.cbParenteseF1)
        Me.TabControlPanel1.Controls.Add(Me.Label3)
        Me.TabControlPanel1.Controls.Add(Me.cbParenteseF2)
        Me.TabControlPanel1.Controls.Add(Me.cbParenteseF3)
        Me.TabControlPanel1.Controls.Add(Me.txtValor3)
        Me.TabControlPanel1.Controls.Add(Me.txtValor2)
        Me.TabControlPanel1.Controls.Add(Me.cbConector2)
        Me.TabControlPanel1.Controls.Add(Me.cbOperador1)
        Me.TabControlPanel1.Controls.Add(Me.cbOperador2)
        Me.TabControlPanel1.Controls.Add(Me.cbOperador3)
        Me.TabControlPanel1.Controls.Add(Me.cbParenteseA2)
        Me.TabControlPanel1.Controls.Add(Me.cbParenteseA5)
        Me.TabControlPanel1.Controls.Add(Me.cbOperador5)
        Me.TabControlPanel1.Controls.Add(Me.cbCampo4)
        Me.TabControlPanel1.Controls.Add(Me.cbConector4)
        Me.TabControlPanel1.Controls.Add(Me.Label5)
        Me.TabControlPanel1.Controls.Add(Me.cbConector3)
        Me.TabControlPanel1.Controls.Add(Me.cbOperador4)
        Me.TabControlPanel1.Controls.Add(Me.cbParenteseA4)
        Me.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel1.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel1.Name = "TabControlPanel1"
        Me.TabControlPanel1.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel1.Size = New System.Drawing.Size(1077, 77)
        Me.TabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabControlPanel1.Style.GradientAngle = 90
        Me.TabControlPanel1.TabIndex = 1
        Me.TabControlPanel1.TabItem = Me.tbiCriterios
        '
        'cbConector1
        '
        Me.cbConector1.FormattingEnabled = True
        Me.cbConector1.Items.AddRange(New Object() {"E", "OU"})
        Me.cbConector1.Location = New System.Drawing.Point(539, 3)
        Me.cbConector1.Name = "cbConector1"
        Me.cbConector1.Size = New System.Drawing.Size(44, 21)
        Me.cbConector1.TabIndex = 99
        Me.cbConector1.Text = "E"
        '
        'nuDias
        '
        Me.nuDias.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nuDias.Location = New System.Drawing.Point(852, 58)
        Me.nuDias.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.nuDias.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nuDias.Name = "nuDias"
        Me.nuDias.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.nuDias.Size = New System.Drawing.Size(41, 20)
        Me.nuDias.TabIndex = 84
        Me.nuDias.TabStop = False
        Me.nuDias.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nuDias.Visible = False
        '
        'txtSEL
        '
        Me.txtSEL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSEL.Location = New System.Drawing.Point(755, 57)
        Me.txtSEL.Name = "txtSEL"
        Me.txtSEL.Size = New System.Drawing.Size(81, 20)
        Me.txtSEL.TabIndex = 83
        Me.txtSEL.Text = "CDRs_SEL"
        Me.txtSEL.Visible = False
        '
        'btnSEL
        '
        Me.btnSEL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSEL.Location = New System.Drawing.Point(899, 55)
        Me.btnSEL.Name = "btnSEL"
        Me.btnSEL.Size = New System.Drawing.Size(36, 22)
        Me.btnSEL.TabIndex = 82
        Me.btnSEL.Text = "SEL"
        Me.btnSEL.UseVisualStyleBackColor = True
        Me.btnSEL.Visible = False
        '
        'tbiCriterios
        '
        Me.tbiCriterios.AttachedControl = Me.TabControlPanel1
        Me.tbiCriterios.Name = "tbiCriterios"
        Me.tbiCriterios.Text = "Critérios"
        '
        'TabControlPanel2
        '
        Me.TabControlPanel2.Controls.Add(Me.txtSQL)
        Me.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlPanel2.Location = New System.Drawing.Point(0, 22)
        Me.TabControlPanel2.Name = "TabControlPanel2"
        Me.TabControlPanel2.Padding = New System.Windows.Forms.Padding(1)
        Me.TabControlPanel2.Size = New System.Drawing.Size(1077, 77)
        Me.TabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.TabControlPanel2.Style.GradientAngle = 90
        Me.TabControlPanel2.TabIndex = 2
        Me.TabControlPanel2.TabItem = Me.tbiSQL
        '
        'tbiSQL
        '
        Me.tbiSQL.AttachedControl = Me.TabControlPanel2
        Me.tbiSQL.Name = "tbiSQL"
        Me.tbiSQL.Text = "SQL"
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.panel1.Controls.Add(Me.panelEx3)
        Me.panel1.Controls.Add(Me.expandableSplitter2)
        Me.panel1.Controls.Add(Me.panelExEsquerdo)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 104)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(1077, 448)
        Me.panel1.TabIndex = 55
        '
        'panelEx3
        '
        Me.panelEx3.Controls.Add(Me.pb1)
        Me.panelEx3.Controls.Add(Me.gcCDRs)
        Me.panelEx3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelEx3.Location = New System.Drawing.Point(5, 0)
        Me.panelEx3.Name = "panelEx3"
        Me.panelEx3.Size = New System.Drawing.Size(1072, 448)
        Me.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.panelEx3.Style.GradientAngle = 90
        Me.panelEx3.TabIndex = 2
        Me.panelEx3.Text = "Fill Panel"
        '
        'gcCDRs
        '
        Me.gcCDRs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCDRs.Location = New System.Drawing.Point(0, 0)
        Me.gcCDRs.MainView = Me.gvCDRs
        Me.gcCDRs.Name = "gcCDRs"
        Me.gcCDRs.Size = New System.Drawing.Size(1072, 448)
        Me.gcCDRs.TabIndex = 52
        Me.gcCDRs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCDRs})
        '
        'gvCDRs
        '
        Me.gvCDRs.Appearance.EvenRow.Options.UseFont = True
        Me.gvCDRs.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 6.75!)
        Me.gvCDRs.Appearance.HeaderPanel.Options.UseFont = True
        Me.gvCDRs.Appearance.OddRow.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.gvCDRs.Appearance.OddRow.Options.UseFont = True
        Me.gvCDRs.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 7.0!)
        Me.gvCDRs.Appearance.Row.Options.UseFont = True
        Me.gvCDRs.Appearance.Row.Options.UseTextOptions = True
        Me.gvCDRs.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.gvCDRs.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.CLASSIF, Me.DATA, Me.DURACAO, Me.Ass_A, Me.CLIENTE_A, Me.R_ENT, Me.ROTA_E, Me.CSP, Me.ASS_B, Me.CLIENTE_B, Me.R_SAI, Me.ROTA_S, Me.RN2, Me.RN3, Me.PT, Me.Dialed_Number, Me.Caller_Category, Me.Bill_Type, Me.Free_Ind, Me.Charged_Party_Ind, Me.Call_Type, Me.GSVN, Me.Failure_Code, Me.Termination_Code, Me.Bearer_Service, Me.Tele_Service, Me.RxFlus, Me.TxFlus, Me.Caller_GK_Address, Me.Caller_GW_Address, Me.Called_GK_Address, Me.Called_GW_Address})
        Me.gvCDRs.FixedLineWidth = 1
        Me.gvCDRs.FooterPanelHeight = 20
        Me.gvCDRs.GridControl = Me.gcCDRs
        Me.gvCDRs.GroupFormat = "{0}: [#imagem]{1} {2}"
        Me.gvCDRs.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", Nothing, "({0:d} reg)"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "DURACAO", Nothing, "[TMR:{0:n0}]")})
        Me.gvCDRs.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never
        Me.gvCDRs.Name = "gvCDRs"
        Me.gvCDRs.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvCDRs.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.gvCDRs.OptionsBehavior.AllowIncrementalSearch = True
        Me.gvCDRs.OptionsBehavior.AutoSelectAllInEditor = False
        Me.gvCDRs.OptionsBehavior.Editable = False
        Me.gvCDRs.OptionsBehavior.ReadOnly = True
        Me.gvCDRs.OptionsDetail.SmartDetailHeight = True
        Me.gvCDRs.OptionsView.ColumnAutoWidth = False
        Me.gvCDRs.OptionsView.ShowFooter = True
        Me.gvCDRs.OptionsView.ShowGroupPanel = False
        Me.gvCDRs.RowHeight = 20
        '
        'CLASSIF
        '
        Me.CLASSIF.Caption = "Classif"
        Me.CLASSIF.FieldName = "CLASSIF"
        Me.CLASSIF.Name = "CLASSIF"
        Me.CLASSIF.Visible = True
        Me.CLASSIF.VisibleIndex = 0
        Me.CLASSIF.Width = 51
        '
        'DATA
        '
        Me.DATA.Caption = "Data"
        Me.DATA.DisplayFormat.FormatString = "{0:yyyy-MM-dd hh:mm:ss}"
        Me.DATA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.DATA.FieldName = "DATA"
        Me.DATA.Name = "DATA"
        Me.DATA.SummaryItem.DisplayFormat = "{0:n0} registros"
        Me.DATA.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.DATA.Visible = True
        Me.DATA.VisibleIndex = 1
        Me.DATA.Width = 100
        '
        'DURACAO
        '
        Me.DURACAO.Caption = "Duração"
        Me.DURACAO.FieldName = "DURACAO"
        Me.DURACAO.Name = "DURACAO"
        Me.DURACAO.SummaryItem.DisplayFormat = "TMR:{0:n0}"
        Me.DURACAO.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Average
        Me.DURACAO.Visible = True
        Me.DURACAO.VisibleIndex = 2
        Me.DURACAO.Width = 70
        '
        'Ass_A
        '
        Me.Ass_A.AppearanceCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Ass_A.AppearanceCell.Options.UseBackColor = True
        Me.Ass_A.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Ass_A.AppearanceHeader.Options.UseBackColor = True
        Me.Ass_A.Caption = "Ass_A"
        Me.Ass_A.FieldName = "ASS_A"
        Me.Ass_A.Name = "Ass_A"
        Me.Ass_A.Visible = True
        Me.Ass_A.VisibleIndex = 3
        Me.Ass_A.Width = 84
        '
        'CLIENTE_A
        '
        Me.CLIENTE_A.AppearanceCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CLIENTE_A.AppearanceCell.Options.UseBackColor = True
        Me.CLIENTE_A.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CLIENTE_A.AppearanceHeader.Options.UseBackColor = True
        Me.CLIENTE_A.Caption = "Cliente_A"
        Me.CLIENTE_A.FieldName = "CLIENTE_A"
        Me.CLIENTE_A.Name = "CLIENTE_A"
        Me.CLIENTE_A.Visible = True
        Me.CLIENTE_A.VisibleIndex = 4
        Me.CLIENTE_A.Width = 96
        '
        'R_ENT
        '
        Me.R_ENT.AppearanceCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.R_ENT.AppearanceCell.Options.UseBackColor = True
        Me.R_ENT.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.R_ENT.AppearanceHeader.Options.UseBackColor = True
        Me.R_ENT.Caption = "TG_E"
        Me.R_ENT.FieldName = "R_ENT"
        Me.R_ENT.Name = "R_ENT"
        Me.R_ENT.Visible = True
        Me.R_ENT.VisibleIndex = 5
        Me.R_ENT.Width = 46
        '
        'ROTA_E
        '
        Me.ROTA_E.AppearanceCell.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ROTA_E.AppearanceCell.Options.UseBackColor = True
        Me.ROTA_E.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ROTA_E.AppearanceHeader.Options.UseBackColor = True
        Me.ROTA_E.Caption = "Nome_TG_E"
        Me.ROTA_E.FieldName = "ROTA_E"
        Me.ROTA_E.Name = "ROTA_E"
        Me.ROTA_E.Visible = True
        Me.ROTA_E.VisibleIndex = 6
        Me.ROTA_E.Width = 66
        '
        'CSP
        '
        Me.CSP.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CSP.AppearanceCell.Options.UseBackColor = True
        Me.CSP.AppearanceCell.Options.UseTextOptions = True
        Me.CSP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CSP.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CSP.AppearanceHeader.Options.UseBackColor = True
        Me.CSP.AppearanceHeader.Options.UseTextOptions = True
        Me.CSP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.CSP.Caption = "CSP"
        Me.CSP.FieldName = "CSP"
        Me.CSP.Name = "CSP"
        Me.CSP.Visible = True
        Me.CSP.VisibleIndex = 7
        Me.CSP.Width = 36
        '
        'ASS_B
        '
        Me.ASS_B.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ASS_B.AppearanceCell.Options.UseBackColor = True
        Me.ASS_B.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ASS_B.AppearanceHeader.Options.UseBackColor = True
        Me.ASS_B.Caption = "Ass_B"
        Me.ASS_B.FieldName = "ASS_B"
        Me.ASS_B.Name = "ASS_B"
        Me.ASS_B.Visible = True
        Me.ASS_B.VisibleIndex = 8
        Me.ASS_B.Width = 79
        '
        'CLIENTE_B
        '
        Me.CLIENTE_B.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CLIENTE_B.AppearanceCell.Options.UseBackColor = True
        Me.CLIENTE_B.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CLIENTE_B.AppearanceHeader.Options.UseBackColor = True
        Me.CLIENTE_B.Caption = "Cliente_B"
        Me.CLIENTE_B.FieldName = "CLIENTE_B"
        Me.CLIENTE_B.Name = "CLIENTE_B"
        Me.CLIENTE_B.Visible = True
        Me.CLIENTE_B.VisibleIndex = 9
        Me.CLIENTE_B.Width = 87
        '
        'R_SAI
        '
        Me.R_SAI.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.R_SAI.AppearanceCell.Options.UseBackColor = True
        Me.R_SAI.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.R_SAI.AppearanceHeader.Options.UseBackColor = True
        Me.R_SAI.Caption = "TG_S"
        Me.R_SAI.FieldName = "R_SAI"
        Me.R_SAI.Name = "R_SAI"
        Me.R_SAI.Visible = True
        Me.R_SAI.VisibleIndex = 10
        Me.R_SAI.Width = 48
        '
        'ROTA_S
        '
        Me.ROTA_S.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ROTA_S.AppearanceCell.Options.UseBackColor = True
        Me.ROTA_S.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ROTA_S.AppearanceHeader.Options.UseBackColor = True
        Me.ROTA_S.Caption = "Nome_TG_S"
        Me.ROTA_S.FieldName = "ROTA_S"
        Me.ROTA_S.Name = "ROTA_S"
        Me.ROTA_S.Visible = True
        Me.ROTA_S.VisibleIndex = 11
        Me.ROTA_S.Width = 78
        '
        'RN2
        '
        Me.RN2.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RN2.AppearanceCell.Options.UseBackColor = True
        Me.RN2.Caption = "RN2"
        Me.RN2.FieldName = "RN2"
        Me.RN2.Name = "RN2"
        Me.RN2.Visible = True
        Me.RN2.VisibleIndex = 12
        Me.RN2.Width = 56
        '
        'RN3
        '
        Me.RN3.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RN3.AppearanceCell.Options.UseBackColor = True
        Me.RN3.Caption = "RN3"
        Me.RN3.FieldName = "RN3"
        Me.RN3.Name = "RN3"
        Me.RN3.Visible = True
        Me.RN3.VisibleIndex = 13
        Me.RN3.Width = 34
        '
        'PT
        '
        Me.PT.AppearanceCell.Options.UseTextOptions = True
        Me.PT.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PT.AppearanceHeader.Options.UseTextOptions = True
        Me.PT.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PT.Caption = "PT"
        Me.PT.FieldName = "PT"
        Me.PT.Name = "PT"
        Me.PT.Visible = True
        Me.PT.VisibleIndex = 14
        Me.PT.Width = 38
        '
        'Dialed_Number
        '
        Me.Dialed_Number.Caption = "Dialed_Number"
        Me.Dialed_Number.FieldName = "Dialed_Number"
        Me.Dialed_Number.Name = "Dialed_Number"
        Me.Dialed_Number.Visible = True
        Me.Dialed_Number.VisibleIndex = 15
        Me.Dialed_Number.Width = 66
        '
        'Caller_Category
        '
        Me.Caller_Category.Caption = "Caller_Category"
        Me.Caller_Category.FieldName = "Caller_Category"
        Me.Caller_Category.Name = "Caller_Category"
        Me.Caller_Category.Visible = True
        Me.Caller_Category.VisibleIndex = 16
        Me.Caller_Category.Width = 35
        '
        'Bill_Type
        '
        Me.Bill_Type.Caption = "Bill_Type"
        Me.Bill_Type.FieldName = "Bill_Type"
        Me.Bill_Type.Name = "Bill_Type"
        Me.Bill_Type.Visible = True
        Me.Bill_Type.VisibleIndex = 17
        Me.Bill_Type.Width = 36
        '
        'Free_Ind
        '
        Me.Free_Ind.Caption = "Free_Ind"
        Me.Free_Ind.FieldName = "Free_Ind"
        Me.Free_Ind.Name = "Free_Ind"
        Me.Free_Ind.Visible = True
        Me.Free_Ind.VisibleIndex = 18
        Me.Free_Ind.Width = 51
        '
        'Charged_Party_Ind
        '
        Me.Charged_Party_Ind.Caption = "Charged_Party_Ind"
        Me.Charged_Party_Ind.FieldName = "Charged_Party_Ind"
        Me.Charged_Party_Ind.Name = "Charged_Party_Ind"
        Me.Charged_Party_Ind.Visible = True
        Me.Charged_Party_Ind.VisibleIndex = 19
        Me.Charged_Party_Ind.Width = 39
        '
        'Call_Type
        '
        Me.Call_Type.Caption = "Call_Type"
        Me.Call_Type.FieldName = "Call_Type"
        Me.Call_Type.Name = "Call_Type"
        Me.Call_Type.Visible = True
        Me.Call_Type.VisibleIndex = 20
        Me.Call_Type.Width = 38
        '
        'GSVN
        '
        Me.GSVN.Caption = "GSVN"
        Me.GSVN.FieldName = "GSVN"
        Me.GSVN.Name = "GSVN"
        Me.GSVN.Visible = True
        Me.GSVN.VisibleIndex = 21
        Me.GSVN.Width = 35
        '
        'Failure_Code
        '
        Me.Failure_Code.Caption = "Failure_Code"
        Me.Failure_Code.FieldName = "Failure_Code"
        Me.Failure_Code.Name = "Failure_Code"
        Me.Failure_Code.Visible = True
        Me.Failure_Code.VisibleIndex = 22
        Me.Failure_Code.Width = 38
        '
        'Termination_Code
        '
        Me.Termination_Code.Caption = "Termination_Code"
        Me.Termination_Code.FieldName = "Termination_Code"
        Me.Termination_Code.Name = "Termination_Code"
        Me.Termination_Code.Visible = True
        Me.Termination_Code.VisibleIndex = 23
        Me.Termination_Code.Width = 33
        '
        'Bearer_Service
        '
        Me.Bearer_Service.Caption = "Bearer_Service"
        Me.Bearer_Service.FieldName = "Bearer_Service"
        Me.Bearer_Service.Name = "Bearer_Service"
        Me.Bearer_Service.Visible = True
        Me.Bearer_Service.VisibleIndex = 24
        '
        'Tele_Service
        '
        Me.Tele_Service.Caption = "Tele_Service"
        Me.Tele_Service.FieldName = "Tele_Service"
        Me.Tele_Service.Name = "Tele_Service"
        Me.Tele_Service.Visible = True
        Me.Tele_Service.VisibleIndex = 25
        '
        'RxFlus
        '
        Me.RxFlus.Caption = "RxFlus"
        Me.RxFlus.FieldName = "RxFlus"
        Me.RxFlus.Name = "RxFlus"
        Me.RxFlus.Visible = True
        Me.RxFlus.VisibleIndex = 26
        Me.RxFlus.Width = 47
        '
        'TxFlus
        '
        Me.TxFlus.Caption = "TxFlus"
        Me.TxFlus.FieldName = "TxFlus"
        Me.TxFlus.Name = "TxFlus"
        Me.TxFlus.Visible = True
        Me.TxFlus.VisibleIndex = 27
        Me.TxFlus.Width = 41
        '
        'Caller_GK_Address
        '
        Me.Caller_GK_Address.Caption = "Caller_GK_Address"
        Me.Caller_GK_Address.FieldName = "Caller_GK_Address"
        Me.Caller_GK_Address.Name = "Caller_GK_Address"
        Me.Caller_GK_Address.Visible = True
        Me.Caller_GK_Address.VisibleIndex = 28
        '
        'Caller_GW_Address
        '
        Me.Caller_GW_Address.Caption = "Caller_GW_Address"
        Me.Caller_GW_Address.FieldName = "Caller_GW_Address"
        Me.Caller_GW_Address.Name = "Caller_GW_Address"
        Me.Caller_GW_Address.Visible = True
        Me.Caller_GW_Address.VisibleIndex = 29
        '
        'Called_GK_Address
        '
        Me.Called_GK_Address.Caption = "Called_GK_Address"
        Me.Called_GK_Address.FieldName = "Called_GK_Address"
        Me.Called_GK_Address.Name = "Called_GK_Address"
        Me.Called_GK_Address.Visible = True
        Me.Called_GK_Address.VisibleIndex = 30
        '
        'Called_GW_Address
        '
        Me.Called_GW_Address.Caption = "Called_GW_Address"
        Me.Called_GW_Address.FieldName = "Called_GW_Address"
        Me.Called_GW_Address.Name = "Called_GW_Address"
        Me.Called_GW_Address.Visible = True
        Me.Called_GW_Address.VisibleIndex = 31
        '
        'expandableSplitter2
        '
        Me.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.expandableSplitter2.ExpandableControl = Me.panelExEsquerdo
        Me.expandableSplitter2.Expanded = False
        Me.expandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.expandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.expandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.expandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.expandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.expandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.expandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.expandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(201, Byte), Integer))
        Me.expandableSplitter2.Location = New System.Drawing.Point(0, 0)
        Me.expandableSplitter2.Name = "expandableSplitter2"
        Me.expandableSplitter2.Size = New System.Drawing.Size(5, 448)
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
        Me.panelExEsquerdo.Style.GradientAngle = 90
        Me.panelExEsquerdo.TabIndex = 0
        Me.panelExEsquerdo.Text = "Click to collapse"
        Me.panelExEsquerdo.Visible = False
        '
        'cbParenteseA1
        '
        '
        '
        '
        Me.cbParenteseA1.BackgroundStyle.Class = ""
        Me.cbParenteseA1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbParenteseA1.Location = New System.Drawing.Point(55, 21)
        Me.cbParenteseA1.Name = "cbParenteseA1"
        Me.cbParenteseA1.Size = New System.Drawing.Size(41, 23)
        Me.cbParenteseA1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbParenteseA1.TabIndex = 100
        Me.cbParenteseA1.Text = "("
        '
        'frmListaCDRs_H
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(1077, 552)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.expandableSplitter1)
        Me.Controls.Add(Me.panelExSuperior)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Controls.Add(Me.DockSite5)
        Me.Controls.Add(Me.DockSite6)
        Me.Controls.Add(Me.DockSite7)
        Me.Controls.Add(Me.DockSite8)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaCDRs_H"
        Me.ShowIcon = False
        Me.Text = "Pesquisa CDRs - Huawei"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.chartBarra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.tbcGrafico.ResumeLayout(False)
        Me.tpTorta.ResumeLayout(False)
        CType(Me.chartPizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpDiagrama.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.panelExSuperior.ResumeLayout(False)
        CType(Me.tbcPainelSuperior, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbcPainelSuperior.ResumeLayout(False)
        Me.TabControlPanel1.ResumeLayout(False)
        Me.TabControlPanel1.PerformLayout()
        CType(Me.nuDias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlPanel2.ResumeLayout(False)
        Me.TabControlPanel2.PerformLayout()
        Me.panel1.ResumeLayout(False)
        Me.panelEx3.ResumeLayout(False)
        CType(Me.gcCDRs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCDRs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelExEsquerdo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbOperador3 As System.Windows.Forms.ComboBox
    Friend WithEvents cbOperador2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbOperador1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbConector2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbCampo3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbCampo2 As System.Windows.Forms.ComboBox
    Friend WithEvents chartBarra As Dundas.Charting.WinControl.Chart
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbCampo1 As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents txtSQL As System.Windows.Forms.TextBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuFechar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbParenteseA2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbParenteseA5 As System.Windows.Forms.CheckBox
    Friend WithEvents cbOperador5 As System.Windows.Forms.ComboBox
    Friend WithEvents cbConector4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbCampo5 As System.Windows.Forms.ComboBox
    Friend WithEvents cbParenteseA4 As System.Windows.Forms.CheckBox
    Friend WithEvents cbOperador4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbConector3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbCampo4 As System.Windows.Forms.ComboBox
    Friend WithEvents cbParenteseF5 As System.Windows.Forms.CheckBox
    Friend WithEvents txtValor5 As System.Windows.Forms.TextBox
    Friend WithEvents cbParenteseF4 As System.Windows.Forms.CheckBox
    Friend WithEvents txtValor4 As System.Windows.Forms.TextBox
    Friend WithEvents cbParenteseF1 As System.Windows.Forms.CheckBox
    Friend WithEvents cbParenteseF2 As System.Windows.Forms.CheckBox
    Friend WithEvents cbParenteseF3 As System.Windows.Forms.CheckBox
    Friend WithEvents txtValor3 As System.Windows.Forms.TextBox
    Friend WithEvents txtValor2 As System.Windows.Forms.TextBox
    Friend WithEvents txtValor1 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents tbcGrafico As System.Windows.Forms.TabControl
    Friend WithEvents tpTorta As System.Windows.Forms.TabPage
    Friend WithEvents chartPizza As Dundas.Charting.WinControl.Chart
    Friend WithEvents tpDiagrama As System.Windows.Forms.TabPage
    Friend WithEvents tvCausas As System.Windows.Forms.TreeView
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents expandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents panelExSuperior As DevComponents.DotNetBar.PanelEx
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents panelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents expandableSplitter2 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents panelExEsquerdo As DevComponents.DotNetBar.PanelEx
    Friend WithEvents gcCDRs As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCDRs As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CLASSIF As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DATA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DURACAO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ass_A As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENTE_A As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R_ENT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ROTA_E As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CSP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ASS_B As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CLIENTE_B As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents R_SAI As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ROTA_S As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RN2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PT As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Dialed_Number As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Bill_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Free_Ind As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Charged_Party_Ind As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Call_Type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GSVN As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Failure_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Termination_Code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Bearer_Service As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tele_Service As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RxFlus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxFlus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Caller_GK_Address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Caller_GW_Address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Called_GK_Address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Called_GW_Address As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RN3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Caller_Category As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents pb1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents txtSEL As System.Windows.Forms.TextBox
    Friend WithEvents btnSEL As System.Windows.Forms.Button
    Friend WithEvents nuDias As System.Windows.Forms.NumericUpDown
    Friend WithEvents tbcPainelSuperior As DevComponents.DotNetBar.TabControl
    Friend WithEvents TabControlPanel1 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tbiCriterios As DevComponents.DotNetBar.TabItem
    Friend WithEvents TabControlPanel2 As DevComponents.DotNetBar.TabControlPanel
    Friend WithEvents tbiSQL As DevComponents.DotNetBar.TabItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents cbConector1 As System.Windows.Forms.ComboBox
    Friend WithEvents cbParenteseA1 As DevComponents.DotNetBar.Controls.CheckBoxX
End Class
