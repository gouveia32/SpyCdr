<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrupos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGrupos))
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblAdRota_S = New System.Windows.Forms.Label
        Me.lblAdRota_E = New System.Windows.Forms.Label
        Me.txtNovaMascaraRotaS = New System.Windows.Forms.TextBox
        Me.txtNovaMascaraRotaE = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNovaMascaraAssB = New System.Windows.Forms.TextBox
        Me.txtNovaMascaraCSP = New System.Windows.Forms.TextBox
        Me.cmdAddNew = New System.Windows.Forms.Button
        Me.txtNovaMascaraAssA = New System.Windows.Forms.TextBox
        Me.txtNovoGrupo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMascaraAssA = New System.Windows.Forms.TextBox
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dgGrupos = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuFechar = New System.Windows.Forms.ToolStripMenuItem
        Me.txtQtdeClientes = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblAltRota_S = New System.Windows.Forms.Label
        Me.lblAltRota_E = New System.Windows.Forms.Label
        Me.txtMascaraRotaS = New System.Windows.Forms.TextBox
        Me.txtMascaraRotaE = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMascaraAssB = New System.Windows.Forms.TextBox
        Me.txtMascaraCSP = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtDestino = New System.Windows.Forms.TextBox
        Me.cmdSave = New System.Windows.Forms.Button
        Me.TextBoxDescription = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Ass_A"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblAdRota_S)
        Me.GroupBox1.Controls.Add(Me.lblAdRota_E)
        Me.GroupBox1.Controls.Add(Me.txtNovaMascaraRotaS)
        Me.GroupBox1.Controls.Add(Me.txtNovaMascaraRotaE)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNovaMascaraAssB)
        Me.GroupBox1.Controls.Add(Me.txtNovaMascaraCSP)
        Me.GroupBox1.Controls.Add(Me.cmdAddNew)
        Me.GroupBox1.Controls.Add(Me.txtNovaMascaraAssA)
        Me.GroupBox1.Controls.Add(Me.txtNovoGrupo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 458)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(617, 89)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adicionar Novo GRUPO"
        '
        'lblAdRota_S
        '
        Me.lblAdRota_S.AutoSize = True
        Me.lblAdRota_S.Location = New System.Drawing.Point(532, 43)
        Me.lblAdRota_S.Name = "lblAdRota_S"
        Me.lblAdRota_S.Size = New System.Drawing.Size(43, 13)
        Me.lblAdRota_S.TabIndex = 51
        Me.lblAdRota_S.Text = "Rota_S"
        '
        'lblAdRota_E
        '
        Me.lblAdRota_E.AutoSize = True
        Me.lblAdRota_E.Location = New System.Drawing.Point(446, 43)
        Me.lblAdRota_E.Name = "lblAdRota_E"
        Me.lblAdRota_E.Size = New System.Drawing.Size(43, 13)
        Me.lblAdRota_E.TabIndex = 50
        Me.lblAdRota_E.Text = "Rota_E"
        '
        'txtNovaMascaraRotaS
        '
        Me.txtNovaMascaraRotaS.Location = New System.Drawing.Point(535, 59)
        Me.txtNovaMascaraRotaS.MaxLength = 16
        Me.txtNovaMascaraRotaS.Name = "txtNovaMascaraRotaS"
        Me.txtNovaMascaraRotaS.Size = New System.Drawing.Size(80, 20)
        Me.txtNovaMascaraRotaS.TabIndex = 49
        '
        'txtNovaMascaraRotaE
        '
        Me.txtNovaMascaraRotaE.Location = New System.Drawing.Point(449, 59)
        Me.txtNovaMascaraRotaE.MaxLength = 16
        Me.txtNovaMascaraRotaE.Name = "txtNovaMascaraRotaE"
        Me.txtNovaMascaraRotaE.Size = New System.Drawing.Size(80, 20)
        Me.txtNovaMascaraRotaE.TabIndex = 48
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(270, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Ass_B"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(218, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "CSP"
        '
        'txtNovaMascaraAssB
        '
        Me.txtNovaMascaraAssB.Location = New System.Drawing.Point(273, 59)
        Me.txtNovaMascaraAssB.MaxLength = 16
        Me.txtNovaMascaraAssB.Name = "txtNovaMascaraAssB"
        Me.txtNovaMascaraAssB.Size = New System.Drawing.Size(170, 20)
        Me.txtNovaMascaraAssB.TabIndex = 45
        '
        'txtNovaMascaraCSP
        '
        Me.txtNovaMascaraCSP.Location = New System.Drawing.Point(221, 59)
        Me.txtNovaMascaraCSP.MaxLength = 16
        Me.txtNovaMascaraCSP.Name = "txtNovaMascaraCSP"
        Me.txtNovaMascaraCSP.Size = New System.Drawing.Size(46, 20)
        Me.txtNovaMascaraCSP.TabIndex = 44
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdAddNew.Location = New System.Drawing.Point(522, 13)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(95, 25)
        Me.cmdAddNew.TabIndex = 21
        Me.cmdAddNew.Text = "Adicionar"
        Me.cmdAddNew.UseVisualStyleBackColor = True
        '
        'txtNovaMascaraAssA
        '
        Me.txtNovaMascaraAssA.Location = New System.Drawing.Point(45, 59)
        Me.txtNovaMascaraAssA.MaxLength = 16
        Me.txtNovaMascaraAssA.Name = "txtNovaMascaraAssA"
        Me.txtNovaMascaraAssA.Size = New System.Drawing.Size(170, 20)
        Me.txtNovaMascaraAssA.TabIndex = 37
        '
        'txtNovoGrupo
        '
        Me.txtNovoGrupo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNovoGrupo.Location = New System.Drawing.Point(45, 17)
        Me.txtNovoGrupo.MaxLength = 25
        Me.txtNovoGrupo.Name = "txtNovoGrupo"
        Me.txtNovoGrupo.Size = New System.Drawing.Size(286, 20)
        Me.txtNovoGrupo.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Ass_A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Grupo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Grupo"
        '
        'txtMascaraAssA
        '
        Me.txtMascaraAssA.Location = New System.Drawing.Point(45, 64)
        Me.txtMascaraAssA.MaxLength = 16
        Me.txtMascaraAssA.Name = "txtMascaraAssA"
        Me.txtMascaraAssA.Size = New System.Drawing.Size(170, 20)
        Me.txtMascaraAssA.TabIndex = 35
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Location = New System.Drawing.Point(544, 17)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(67, 23)
        Me.cmdDelete.TabIndex = 20
        Me.cmdDelete.Text = "Excluir"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.SplitContainer1.Location = New System.Drawing.Point(-52, -15)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgGrupos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtQtdeClientes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1MinSize = 2
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxDescription)
        Me.SplitContainer1.Panel2MinSize = 2
        Me.SplitContainer1.Size = New System.Drawing.Size(977, 564)
        Me.SplitContainer1.SplitterDistance = 676
        Me.SplitContainer1.TabIndex = 44
        '
        'dgGrupos
        '
        Me.dgGrupos.AllowUserToAddRows = False
        Me.dgGrupos.AllowUserToDeleteRows = False
        Me.dgGrupos.AllowUserToOrderColumns = True
        Me.dgGrupos.AllowUserToResizeColumns = False
        Me.dgGrupos.AllowUserToResizeRows = False
        Me.dgGrupos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgGrupos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGrupos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgGrupos.Location = New System.Drawing.Point(55, 115)
        Me.dgGrupos.Name = "dgGrupos"
        Me.dgGrupos.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgGrupos.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgGrupos.RowHeadersWidth = 20
        Me.dgGrupos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGrupos.Size = New System.Drawing.Size(616, 321)
        Me.dgGrupos.TabIndex = 51
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
        'txtQtdeClientes
        '
        Me.txtQtdeClientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtQtdeClientes.Location = New System.Drawing.Point(616, 442)
        Me.txtQtdeClientes.Name = "txtQtdeClientes"
        Me.txtQtdeClientes.Size = New System.Drawing.Size(57, 20)
        Me.txtQtdeClientes.TabIndex = 51
        Me.txtQtdeClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(563, 445)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Grupos:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.lblAltRota_S)
        Me.GroupBox3.Controls.Add(Me.lblAltRota_E)
        Me.GroupBox3.Controls.Add(Me.txtMascaraRotaS)
        Me.GroupBox3.Controls.Add(Me.txtMascaraRotaE)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtMascaraAssB)
        Me.GroupBox3.Controls.Add(Me.txtMascaraCSP)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txtID)
        Me.GroupBox3.Controls.Add(Me.cmdDelete)
        Me.GroupBox3.Controls.Add(Me.txtDestino)
        Me.GroupBox3.Controls.Add(Me.cmdSave)
        Me.GroupBox3.Controls.Add(Me.txtMascaraAssA)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(56, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(617, 96)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Alterar/Excluir Grupo"
        '
        'lblAltRota_S
        '
        Me.lblAltRota_S.AutoSize = True
        Me.lblAltRota_S.Location = New System.Drawing.Point(532, 48)
        Me.lblAltRota_S.Name = "lblAltRota_S"
        Me.lblAltRota_S.Size = New System.Drawing.Size(43, 13)
        Me.lblAltRota_S.TabIndex = 52
        Me.lblAltRota_S.Text = "Rota_S"
        '
        'lblAltRota_E
        '
        Me.lblAltRota_E.AutoSize = True
        Me.lblAltRota_E.Location = New System.Drawing.Point(446, 48)
        Me.lblAltRota_E.Name = "lblAltRota_E"
        Me.lblAltRota_E.Size = New System.Drawing.Size(43, 13)
        Me.lblAltRota_E.TabIndex = 51
        Me.lblAltRota_E.Text = "Rota_E"
        '
        'txtMascaraRotaS
        '
        Me.txtMascaraRotaS.Location = New System.Drawing.Point(535, 64)
        Me.txtMascaraRotaS.MaxLength = 16
        Me.txtMascaraRotaS.Name = "txtMascaraRotaS"
        Me.txtMascaraRotaS.Size = New System.Drawing.Size(80, 20)
        Me.txtMascaraRotaS.TabIndex = 50
        '
        'txtMascaraRotaE
        '
        Me.txtMascaraRotaE.Location = New System.Drawing.Point(449, 64)
        Me.txtMascaraRotaE.MaxLength = 16
        Me.txtMascaraRotaE.Name = "txtMascaraRotaE"
        Me.txtMascaraRotaE.Size = New System.Drawing.Size(80, 20)
        Me.txtMascaraRotaE.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(270, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Ass_B"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(218, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "CSP"
        '
        'txtMascaraAssB
        '
        Me.txtMascaraAssB.Location = New System.Drawing.Point(273, 64)
        Me.txtMascaraAssB.MaxLength = 16
        Me.txtMascaraAssB.Name = "txtMascaraAssB"
        Me.txtMascaraAssB.Size = New System.Drawing.Size(170, 20)
        Me.txtMascaraAssB.TabIndex = 45
        '
        'txtMascaraCSP
        '
        Me.txtMascaraCSP.Location = New System.Drawing.Point(221, 64)
        Me.txtMascaraCSP.MaxLength = 16
        Me.txtMascaraCSP.Name = "txtMascaraCSP"
        Me.txtMascaraCSP.Size = New System.Drawing.Size(46, 20)
        Me.txtMascaraCSP.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(371, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(395, 19)
        Me.txtID.Name = "txtID"
        Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtID.Size = New System.Drawing.Size(51, 20)
        Me.txtID.TabIndex = 42
        '
        'txtDestino
        '
        Me.txtDestino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDestino.Location = New System.Drawing.Point(45, 20)
        Me.txtDestino.MaxLength = 25
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(286, 20)
        Me.txtDestino.TabIndex = 34
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Location = New System.Drawing.Point(473, 17)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(65, 23)
        Me.cmdSave.TabIndex = 19
        Me.cmdSave.Text = "Gravar"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'TextBoxDescription
        '
        Me.TextBoxDescription.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDescription.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBoxDescription.Location = New System.Drawing.Point(2, 13)
        Me.TextBoxDescription.Margin = New System.Windows.Forms.Padding(6, 3, 3, 3)
        Me.TextBoxDescription.Multiline = True
        Me.TextBoxDescription.Name = "TextBoxDescription"
        Me.TextBoxDescription.ReadOnly = True
        Me.TextBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBoxDescription.Size = New System.Drawing.Size(246, 534)
        Me.TextBoxDescription.TabIndex = 2
        Me.TextBoxDescription.TabStop = False
        Me.TextBoxDescription.Text = resources.GetString("TextBoxDescription.Text")
        '
        'frmGrupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(874, 534)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmGrupos"
        Me.ShowIcon = False
        Me.Text = "Grupos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdAddNew As System.Windows.Forms.Button
    Friend WithEvents txtNovaMascaraAssA As System.Windows.Forms.TextBox
    Friend WithEvents txtNovoGrupo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMascaraAssA As System.Windows.Forms.TextBox
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgGrupos As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuFechar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtQtdeClientes As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNovaMascaraAssB As System.Windows.Forms.TextBox
    Friend WithEvents txtNovaMascaraCSP As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMascaraAssB As System.Windows.Forms.TextBox
    Friend WithEvents txtMascaraCSP As System.Windows.Forms.TextBox
    Friend WithEvents lblAdRota_S As System.Windows.Forms.Label
    Friend WithEvents lblAdRota_E As System.Windows.Forms.Label
    Friend WithEvents txtNovaMascaraRotaS As System.Windows.Forms.TextBox
    Friend WithEvents txtNovaMascaraRotaE As System.Windows.Forms.TextBox
    Friend WithEvents lblAltRota_S As System.Windows.Forms.Label
    Friend WithEvents lblAltRota_E As System.Windows.Forms.Label
    Friend WithEvents txtMascaraRotaS As System.Windows.Forms.TextBox
    Friend WithEvents txtMascaraRotaE As System.Windows.Forms.TextBox
End Class
