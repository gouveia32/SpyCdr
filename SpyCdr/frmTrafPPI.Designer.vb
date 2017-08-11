<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrafPPI
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnExcel = New System.Windows.Forms.Button
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.lblAguarde = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.lblFiltrado = New System.Windows.Forms.Label
        Me.dGridPPI = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
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
        Me.lblGrupo = New System.Windows.Forms.Label
        Me.cbPPI = New System.Windows.Forms.ComboBox
        Me.BarGraphDataGridView1 = New SpyCdr.BarGraphDataGridView
        Me.BarGraphDataGridView2 = New SpyCdr.BarGraphDataGridView
        Me.BarGraphDataGridView3 = New SpyCdr.BarGraphDataGridView
        Me.BarGraphDataGridView4 = New SpyCdr.BarGraphDataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.dGridPPI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblGrupo)
        Me.Panel1.Controls.Add(Me.cbPPI)
        Me.Panel1.Controls.Add(Me.btnExcel)
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Controls.Add(Me.lblAguarde)
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
        Me.lblAguarde.Location = New System.Drawing.Point(470, 1)
        Me.lblAguarde.Name = "lblAguarde"
        Me.lblAguarde.Size = New System.Drawing.Size(272, 25)
        Me.lblAguarde.TabIndex = 32
        Me.lblAguarde.Text = "Processando, Aguarde..."
        Me.lblAguarde.Visible = False
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
        Me.lblFiltrado.Location = New System.Drawing.Point(389, 4)
        Me.lblFiltrado.Name = "lblFiltrado"
        Me.lblFiltrado.Size = New System.Drawing.Size(75, 20)
        Me.lblFiltrado.TabIndex = 33
        Me.lblFiltrado.Text = "Filtrado:"
        Me.lblFiltrado.Visible = False
        '
        'dGridPPI
        '
        Me.dGridPPI.AllowUserToAddRows = False
        Me.dGridPPI.AllowUserToDeleteRows = False
        Me.dGridPPI.AllowUserToOrderColumns = True
        Me.dGridPPI.AllowUserToResizeColumns = False
        Me.dGridPPI.AllowUserToResizeRows = False
        Me.dGridPPI.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dGridPPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGridPPI.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dGridPPI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dGridPPI.Location = New System.Drawing.Point(0, 0)
        Me.dGridPPI.Name = "dGridPPI"
        Me.dGridPPI.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dGridPPI.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dGridPPI.RowHeadersWidth = 20
        Me.dGridPPI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGridPPI.Size = New System.Drawing.Size(1015, 553)
        Me.dGridPPI.TabIndex = 31
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
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
        Me.Panel2.Controls.Add(Me.dGridPPI)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 29)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1015, 553)
        Me.Panel2.TabIndex = 48
        '
        'lblGrupo
        '
        Me.lblGrupo.Location = New System.Drawing.Point(173, 6)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(43, 16)
        Me.lblGrupo.TabIndex = 43
        Me.lblGrupo.Text = "PPI:"
        Me.lblGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbPPI
        '
        Me.cbPPI.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPPI.Location = New System.Drawing.Point(222, 2)
        Me.cbPPI.Name = "cbPPI"
        Me.cbPPI.Size = New System.Drawing.Size(161, 22)
        Me.cbPPI.TabIndex = 42
        Me.cbPPI.Text = "Todos"
        Me.ToolTip1.SetToolTip(Me.cbPPI, "Selecione um ítem específico ou 'Todos'.")
        '
        'BarGraphDataGridView1
        '
        Me.BarGraphDataGridView1.Cores = Nothing
        Me.BarGraphDataGridView1.HeaderText = "Indicador"
        Me.BarGraphDataGridView1.indicador = Nothing
        Me.BarGraphDataGridView1.Maximo = 10000
        Me.BarGraphDataGridView1.Name = "BarGraphDataGridView1"
        '
        'BarGraphDataGridView2
        '
        Me.BarGraphDataGridView2.Cores = Nothing
        Me.BarGraphDataGridView2.HeaderText = "Indicador"
        Me.BarGraphDataGridView2.indicador = Nothing
        Me.BarGraphDataGridView2.Maximo = 10000
        Me.BarGraphDataGridView2.Name = "BarGraphDataGridView2"
        Me.BarGraphDataGridView2.ReadOnly = True
        '
        'BarGraphDataGridView3
        '
        Me.BarGraphDataGridView3.Cores = Nothing
        Me.BarGraphDataGridView3.HeaderText = "Indicador"
        Me.BarGraphDataGridView3.indicador = Nothing
        Me.BarGraphDataGridView3.Maximo = 10000
        Me.BarGraphDataGridView3.Name = "BarGraphDataGridView3"
        Me.BarGraphDataGridView3.ReadOnly = True
        '
        'BarGraphDataGridView4
        '
        Me.BarGraphDataGridView4.Cores = Nothing
        Me.BarGraphDataGridView4.HeaderText = "Indicador"
        Me.BarGraphDataGridView4.indicador = Nothing
        Me.BarGraphDataGridView4.Maximo = 10000
        Me.BarGraphDataGridView4.Name = "BarGraphDataGridView4"
        Me.BarGraphDataGridView4.ReadOnly = True
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
        'frmTrafPPI
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
        Me.Name = "frmTrafPPI"
        Me.Text = "Tráfego no PPI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dGridPPI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dGridPPI As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAguarde As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents lblFiltrado As System.Windows.Forms.Label
    Friend WithEvents BarGraphDataGridView1 As SpyCdr.BarGraphDataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BarGraphDataGridView2 As SpyCdr.BarGraphDataGridView
    Friend WithEvents BarGraphDataGridView3 As SpyCdr.BarGraphDataGridView
    Friend WithEvents BarGraphDataGridView4 As SpyCdr.BarGraphDataGridView
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents DockSite5 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite6 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite7 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite8 As DevComponents.DotNetBar.DockSite
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents cbPPI As System.Windows.Forms.ComboBox
End Class
