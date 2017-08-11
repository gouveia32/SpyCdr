<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrafPorTerminal
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblGrupo = New System.Windows.Forms.Label
        Me.cbClientes = New System.Windows.Forms.ComboBox
        Me.dtpFim = New System.Windows.Forms.DateTimePicker
        Me.btnAtualizar = New System.Windows.Forms.Button
        Me.lblAguarde = New System.Windows.Forms.Label
        Me.btnExcel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DotNetBarManager1 = New DevComponents.DotNetBar.DotNetBarManager(Me.components)
        Me.DockSite4 = New DevComponents.DotNetBar.DockSite
        Me.DockSite1 = New DevComponents.DotNetBar.DockSite
        Me.DockSite2 = New DevComponents.DotNetBar.DockSite
        Me.DockSite3 = New DevComponents.DotNetBar.DockSite
        Me.dgvxResumo = New DevComponents.DotNetBar.Controls.DataGridViewX
        Me.TERMINAL = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ORIGINADAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TERMINADAS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel1.SuspendLayout()
        CType(Me.dgvxResumo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblGrupo)
        Me.Panel1.Controls.Add(Me.cbClientes)
        Me.Panel1.Controls.Add(Me.dtpFim)
        Me.Panel1.Controls.Add(Me.btnAtualizar)
        Me.Panel1.Controls.Add(Me.lblAguarde)
        Me.Panel1.Controls.Add(Me.btnExcel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtpInicio)
        Me.Panel1.Location = New System.Drawing.Point(2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1015, 61)
        Me.Panel1.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(126, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Data Fim:"
        '
        'lblGrupo
        '
        Me.lblGrupo.Location = New System.Drawing.Point(284, 5)
        Me.lblGrupo.Name = "lblGrupo"
        Me.lblGrupo.Size = New System.Drawing.Size(43, 16)
        Me.lblGrupo.TabIndex = 43
        Me.lblGrupo.Text = "Cliente:"
        Me.lblGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbClientes
        '
        Me.cbClientes.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.Location = New System.Drawing.Point(333, 1)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(228, 22)
        Me.cbClientes.TabIndex = 42
        Me.cbClientes.Text = "Todos"
        Me.ToolTip1.SetToolTip(Me.cbClientes, "Selecione um ítem específico ou 'Todos'.")
        '
        'dtpFim
        '
        Me.dtpFim.CustomFormat = "yyyy-MM-dd"
        Me.dtpFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFim.Location = New System.Drawing.Point(184, 25)
        Me.dtpFim.Name = "dtpFim"
        Me.dtpFim.Size = New System.Drawing.Size(97, 20)
        Me.dtpFim.TabIndex = 44
        Me.ToolTip1.SetToolTip(Me.dtpFim, "Selecione o dia que deseja analisar.")
        '
        'btnAtualizar
        '
        Me.btnAtualizar.Image = Global.SpyCdr.My.Resources.Resources.arrow_refresh
        Me.btnAtualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtualizar.Location = New System.Drawing.Point(3, 1)
        Me.btnAtualizar.Name = "btnAtualizar"
        Me.btnAtualizar.Size = New System.Drawing.Size(91, 28)
        Me.btnAtualizar.TabIndex = 38
        Me.btnAtualizar.Text = "Processar"
        Me.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btnAtualizar, "Processar")
        Me.btnAtualizar.UseVisualStyleBackColor = True
        '
        'lblAguarde
        '
        Me.lblAguarde.AutoSize = True
        Me.lblAguarde.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblAguarde.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAguarde.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblAguarde.Location = New System.Drawing.Point(289, 25)
        Me.lblAguarde.Name = "lblAguarde"
        Me.lblAguarde.Size = New System.Drawing.Size(272, 25)
        Me.lblAguarde.TabIndex = 32
        Me.lblAguarde.Text = "Processando, Aguarde..."
        Me.lblAguarde.Visible = False
        '
        'btnExcel
        '
        Me.btnExcel.Image = Global.SpyCdr.My.Resources.Resources.excel
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(3, 29)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(91, 29)
        Me.btnExcel.TabIndex = 41
        Me.btnExcel.Text = "Excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Data Início:"
        '
        'dtpInicio
        '
        Me.dtpInicio.CustomFormat = "yyyy-MM-dd"
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInicio.Location = New System.Drawing.Point(184, 3)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(97, 20)
        Me.dtpInicio.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.dtpInicio, "Selecione o dia que deseja analisar.")
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
        Me.DotNetBarManager1.BottomDockSite = Nothing
        Me.DotNetBarManager1.DefinitionName = ""
        Me.DotNetBarManager1.EnableFullSizeDock = False
        Me.DotNetBarManager1.LeftDockSite = Nothing
        Me.DotNetBarManager1.ParentForm = Nothing
        Me.DotNetBarManager1.RightDockSite = Nothing
        Me.DotNetBarManager1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.DotNetBarManager1.ToolbarBottomDockSite = Me.DockSite4
        Me.DotNetBarManager1.ToolbarLeftDockSite = Me.DockSite1
        Me.DotNetBarManager1.ToolbarRightDockSite = Me.DockSite2
        Me.DotNetBarManager1.ToolbarTopDockSite = Me.DockSite3
        Me.DotNetBarManager1.TopDockSite = Nothing
        '
        'DockSite4
        '
        Me.DockSite4.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DockSite4.Location = New System.Drawing.Point(0, 582)
        Me.DockSite4.Name = "DockSite4"
        Me.DockSite4.Size = New System.Drawing.Size(1015, 0)
        Me.DockSite4.TabIndex = 57
        Me.DockSite4.TabStop = False
        '
        'DockSite1
        '
        Me.DockSite1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DockSite1.Location = New System.Drawing.Point(0, 0)
        Me.DockSite1.Name = "DockSite1"
        Me.DockSite1.Size = New System.Drawing.Size(0, 582)
        Me.DockSite1.TabIndex = 54
        Me.DockSite1.TabStop = False
        '
        'DockSite2
        '
        Me.DockSite2.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite2.Dock = System.Windows.Forms.DockStyle.Right
        Me.DockSite2.Location = New System.Drawing.Point(1015, 0)
        Me.DockSite2.Name = "DockSite2"
        Me.DockSite2.Size = New System.Drawing.Size(0, 582)
        Me.DockSite2.TabIndex = 55
        Me.DockSite2.TabStop = False
        '
        'DockSite3
        '
        Me.DockSite3.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.DockSite3.Dock = System.Windows.Forms.DockStyle.Top
        Me.DockSite3.Location = New System.Drawing.Point(0, 0)
        Me.DockSite3.Name = "DockSite3"
        Me.DockSite3.Size = New System.Drawing.Size(1015, 0)
        Me.DockSite3.TabIndex = 56
        Me.DockSite3.TabStop = False
        '
        'dgvxResumo
        '
        Me.dgvxResumo.AllowUserToAddRows = False
        Me.dgvxResumo.AllowUserToDeleteRows = False
        Me.dgvxResumo.AllowUserToOrderColumns = True
        Me.dgvxResumo.AllowUserToResizeColumns = False
        Me.dgvxResumo.AllowUserToResizeRows = False
        Me.dgvxResumo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvxResumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvxResumo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TERMINAL, Me.ORIGINADAS, Me.TERMINADAS})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvxResumo.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvxResumo.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.dgvxResumo.Location = New System.Drawing.Point(2, 67)
        Me.dgvxResumo.Name = "dgvxResumo"
        Me.dgvxResumo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvxResumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvxResumo.Size = New System.Drawing.Size(369, 514)
        Me.dgvxResumo.TabIndex = 0
        '
        'TERMINAL
        '
        Me.TERMINAL.HeaderText = "TERMINAL"
        Me.TERMINAL.Name = "TERMINAL"
        '
        'ORIGINADAS
        '
        Me.ORIGINADAS.HeaderText = "ORIGINADAS"
        Me.ORIGINADAS.Name = "ORIGINADAS"
        '
        'TERMINADAS
        '
        Me.TERMINADAS.HeaderText = "TERMINADAS"
        Me.TERMINADAS.Name = "TERMINADAS"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "TERMINAL"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "ORIGINADAS"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "TERMINADAS"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'frmTrafPorTerminal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(1015, 582)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvxResumo)
        Me.Controls.Add(Me.DockSite1)
        Me.Controls.Add(Me.DockSite2)
        Me.Controls.Add(Me.DockSite3)
        Me.Controls.Add(Me.DockSite4)
        Me.Name = "frmTrafPorTerminal"
        Me.Text = "Terminais Sem Tráfego"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvxResumo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAguarde As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents btnAtualizar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DotNetBarManager1 As DevComponents.DotNetBar.DotNetBarManager
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents lblGrupo As System.Windows.Forms.Label
    Friend WithEvents cbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents DockSite4 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite1 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite2 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DockSite3 As DevComponents.DotNetBar.DockSite
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFim As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvxResumo As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents TERMINAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORIGINADAS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TERMINADAS As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
