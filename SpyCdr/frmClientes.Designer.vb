<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
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
        Me.cmdAddNew = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNovoFabricante = New System.Windows.Forms.TextBox
        Me.txtNovoNome = New System.Windows.Forms.TextBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dgClientes = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuFechar = New System.Windows.Forms.ToolStripMenuItem
        Me.txtQtdeClientes = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ckbVIP = New System.Windows.Forms.CheckBox
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txtFabricante = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ckbNovoVIP = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtLocalizar = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmdApagarTerminal = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmdGeraNrIsolado = New System.Windows.Forms.Button
        Me.txtNrIsolado = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdGeraFaixa = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtInicial = New System.Windows.Forms.TextBox
        Me.txtFinal = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtQtdeTerminais = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lvTerminais = New System.Windows.Forms.ListView
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAddNew
        '
        Me.cmdAddNew.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmdAddNew.Location = New System.Drawing.Point(253, 43)
        Me.cmdAddNew.Name = "cmdAddNew"
        Me.cmdAddNew.Size = New System.Drawing.Size(95, 25)
        Me.cmdAddNew.TabIndex = 21
        Me.cmdAddNew.Text = "Adicionar"
        Me.cmdAddNew.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Nr Chave"
        '
        'cmdDelete
        '
        Me.cmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDelete.Location = New System.Drawing.Point(264, 71)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(80, 23)
        Me.cmdDelete.TabIndex = 20
        Me.cmdDelete.Text = "Excluir"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Cliente"
        '
        'txtNovoFabricante
        '
        Me.txtNovoFabricante.Location = New System.Drawing.Point(61, 45)
        Me.txtNovoFabricante.Name = "txtNovoFabricante"
        Me.txtNovoFabricante.Size = New System.Drawing.Size(102, 20)
        Me.txtNovoFabricante.TabIndex = 37
        '
        'txtNovoNome
        '
        Me.txtNovoNome.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNovoNome.Location = New System.Drawing.Point(61, 19)
        Me.txtNovoNome.Name = "txtNovoNome"
        Me.txtNovoNome.Size = New System.Drawing.Size(287, 20)
        Me.txtNovoNome.TabIndex = 36
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.SplitContainer1.Location = New System.Drawing.Point(-50, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgClientes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtQtdeClientes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Panel1MinSize = 2
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cmdApagarTerminal)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtQtdeTerminais)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lvTerminais)
        Me.SplitContainer1.Panel2MinSize = 2
        Me.SplitContainer1.Size = New System.Drawing.Size(922, 564)
        Me.SplitContainer1.SplitterDistance = 409
        Me.SplitContainer1.TabIndex = 43
        '
        'dgClientes
        '
        Me.dgClientes.AllowUserToAddRows = False
        Me.dgClientes.AllowUserToDeleteRows = False
        Me.dgClientes.AllowUserToOrderColumns = True
        Me.dgClientes.AllowUserToResizeColumns = False
        Me.dgClientes.AllowUserToResizeRows = False
        Me.dgClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgClientes.Location = New System.Drawing.Point(55, 107)
        Me.dgClientes.Name = "dgClientes"
        Me.dgClientes.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgClientes.RowHeadersWidth = 20
        Me.dgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgClientes.Size = New System.Drawing.Size(349, 329)
        Me.dgClientes.TabIndex = 51
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
        Me.txtQtdeClientes.Location = New System.Drawing.Point(349, 442)
        Me.txtQtdeClientes.Name = "txtQtdeClientes"
        Me.txtQtdeClientes.Size = New System.Drawing.Size(57, 20)
        Me.txtQtdeClientes.TabIndex = 51
        Me.txtQtdeClientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(296, 445)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(47, 13)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Clientes:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtCodigo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.ckbVIP)
        Me.GroupBox3.Controls.Add(Me.cmdDelete)
        Me.GroupBox3.Controls.Add(Me.txtNome)
        Me.GroupBox3.Controls.Add(Me.cmdSave)
        Me.GroupBox3.Controls.Add(Me.txtFabricante)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(56, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(350, 101)
        Me.GroupBox3.TabIndex = 49
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Alterar/Excluir Cliente"
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(57, 19)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(50, 20)
        Me.txtCodigo.TabIndex = 38
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Codigo"
        '
        'ckbVIP
        '
        Me.ckbVIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckbVIP.AutoSize = True
        Me.ckbVIP.Location = New System.Drawing.Point(295, 17)
        Me.ckbVIP.Name = "ckbVIP"
        Me.ckbVIP.Size = New System.Drawing.Size(49, 17)
        Me.ckbVIP.TabIndex = 45
        Me.ckbVIP.Text = "VIP?"
        Me.ckbVIP.UseVisualStyleBackColor = True
        '
        'txtNome
        '
        Me.txtNome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNome.Location = New System.Drawing.Point(57, 45)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(287, 20)
        Me.txtNome.TabIndex = 34
        '
        'cmdSave
        '
        Me.cmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdSave.Location = New System.Drawing.Point(178, 71)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(80, 23)
        Me.cmdSave.TabIndex = 19
        Me.cmdSave.Text = "Gravar"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtFabricante
        '
        Me.txtFabricante.Location = New System.Drawing.Point(57, 71)
        Me.txtFabricante.Name = "txtFabricante"
        Me.txtFabricante.Size = New System.Drawing.Size(102, 20)
        Me.txtFabricante.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(0, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Nr Chave"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Cliente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.ckbNovoVIP)
        Me.GroupBox1.Controls.Add(Me.cmdAddNew)
        Me.GroupBox1.Controls.Add(Me.txtNovoFabricante)
        Me.GroupBox1.Controls.Add(Me.txtNovoNome)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(56, 458)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 71)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Adicionar Novo Cliente"
        '
        'ckbNovoVIP
        '
        Me.ckbNovoVIP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ckbNovoVIP.AutoSize = True
        Me.ckbNovoVIP.Location = New System.Drawing.Point(182, 45)
        Me.ckbNovoVIP.Name = "ckbNovoVIP"
        Me.ckbNovoVIP.Size = New System.Drawing.Size(49, 17)
        Me.ckbNovoVIP.TabIndex = 46
        Me.ckbNovoVIP.Text = "VIP?"
        Me.ckbNovoVIP.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button1)
        Me.GroupBox5.Controls.Add(Me.txtLocalizar)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 101)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(145, 70)
        Me.GroupBox5.TabIndex = 51
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Localizar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 25)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Procurar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtLocalizar
        '
        Me.txtLocalizar.Location = New System.Drawing.Point(53, 14)
        Me.txtLocalizar.Name = "txtLocalizar"
        Me.txtLocalizar.Size = New System.Drawing.Size(85, 20)
        Me.txtLocalizar.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Número:"
        '
        'cmdApagarTerminal
        '
        Me.cmdApagarTerminal.Location = New System.Drawing.Point(3, 170)
        Me.cmdApagarTerminal.Name = "cmdApagarTerminal"
        Me.cmdApagarTerminal.Size = New System.Drawing.Size(145, 41)
        Me.cmdApagarTerminal.TabIndex = 50
        Me.cmdApagarTerminal.Text = "Excluir Terminal Selecionado"
        Me.cmdApagarTerminal.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdGeraNrIsolado)
        Me.GroupBox4.Controls.Add(Me.txtNrIsolado)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Location = New System.Drawing.Point(154, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(145, 92)
        Me.GroupBox4.TabIndex = 49
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Inserir Número Isolado"
        '
        'cmdGeraNrIsolado
        '
        Me.cmdGeraNrIsolado.Location = New System.Drawing.Point(9, 40)
        Me.cmdGeraNrIsolado.Name = "cmdGeraNrIsolado"
        Me.cmdGeraNrIsolado.Size = New System.Drawing.Size(129, 25)
        Me.cmdGeraNrIsolado.TabIndex = 21
        Me.cmdGeraNrIsolado.Text = "Inserir"
        Me.cmdGeraNrIsolado.UseVisualStyleBackColor = True
        '
        'txtNrIsolado
        '
        Me.txtNrIsolado.Location = New System.Drawing.Point(53, 14)
        Me.txtNrIsolado.Name = "txtNrIsolado"
        Me.txtNrIsolado.Size = New System.Drawing.Size(85, 20)
        Me.txtNrIsolado.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Número:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdGeraFaixa)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtInicial)
        Me.GroupBox2.Controls.Add(Me.txtFinal)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 92)
        Me.GroupBox2.TabIndex = 48
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gerar Faixa de Ramais"
        '
        'cmdGeraFaixa
        '
        Me.cmdGeraFaixa.Location = New System.Drawing.Point(9, 62)
        Me.cmdGeraFaixa.Name = "cmdGeraFaixa"
        Me.cmdGeraFaixa.Size = New System.Drawing.Size(129, 25)
        Me.cmdGeraFaixa.TabIndex = 21
        Me.cmdGeraFaixa.Text = "Gerar"
        Me.cmdGeraFaixa.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Nr Final:"
        '
        'txtInicial
        '
        Me.txtInicial.Location = New System.Drawing.Point(53, 14)
        Me.txtInicial.Name = "txtInicial"
        Me.txtInicial.Size = New System.Drawing.Size(85, 20)
        Me.txtInicial.TabIndex = 44
        '
        'txtFinal
        '
        Me.txtFinal.Location = New System.Drawing.Point(53, 36)
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Size = New System.Drawing.Size(85, 20)
        Me.txtFinal.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Nr. Inial:"
        '
        'txtQtdeTerminais
        '
        Me.txtQtdeTerminais.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtQtdeTerminais.Location = New System.Drawing.Point(57, 513)
        Me.txtQtdeTerminais.Name = "txtQtdeTerminais"
        Me.txtQtdeTerminais.Size = New System.Drawing.Size(91, 20)
        Me.txtQtdeTerminais.TabIndex = 41
        Me.txtQtdeTerminais.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 516)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Terminais:"
        '
        'lvTerminais
        '
        Me.lvTerminais.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvTerminais.Location = New System.Drawing.Point(3, 217)
        Me.lvTerminais.Name = "lvTerminais"
        Me.lvTerminais.Size = New System.Drawing.Size(145, 289)
        Me.lvTerminais.TabIndex = 34
        Me.lvTerminais.UseCompatibleStateImageBehavior = False
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 534)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmClientes"
        Me.ShowIcon = False
        Me.Text = "Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents cmdAddNew As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtNovoNome As System.Windows.Forms.TextBox
    Friend WithEvents txtNovoFabricante As System.Windows.Forms.TextBox
    Friend WithEvents txtFabricante As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lvTerminais As System.Windows.Forms.ListView
    Friend WithEvents txtQtdeTerminais As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ckbVIP As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFinal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtInicial As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGeraFaixa As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGeraNrIsolado As System.Windows.Forms.Button
    Friend WithEvents txtNrIsolado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtQtdeClientes As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmdApagarTerminal As System.Windows.Forms.Button
    Friend WithEvents ckbNovoVIP As System.Windows.Forms.CheckBox
    Friend WithEvents dgClientes As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuFechar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtLocalizar As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
