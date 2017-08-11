<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeraHistorico
    Inherits frmModelo

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
        Me.Label1 = New System.Windows.Forms.Label
        Me.DateTimePickerI = New System.Windows.Forms.DateTimePicker
        Me.btnProcessar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ckbX_PPI = New System.Windows.Forms.CheckBox
        Me.btnGravar = New System.Windows.Forms.Button
        Me.btnMarcaTodos = New System.Windows.Forms.Button
        Me.btnDesmarcarTodos = New System.Windows.Forms.Button
        Me.ckbX_EOS = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ckbX_ASS_A = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.numLimiteTCH = New System.Windows.Forms.NumericUpDown
        Me.ckbX_ASS_B = New System.Windows.Forms.CheckBox
        Me.ckbX_Grupo = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePickerF = New System.Windows.Forms.DateTimePicker
        Me.ckbX_Cliente_Destinado = New System.Windows.Forms.CheckBox
        Me.ckbX_Rota_Entrada = New System.Windows.Forms.CheckBox
        Me.ckbX_Cliente_Originado = New System.Windows.Forms.CheckBox
        Me.ckbX_Rota_Saida = New System.Windows.Forms.CheckBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.cbFiltro = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lvLogAtividade = New System.Windows.Forms.ListView
        Me.GroupBox1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numLimiteTCH, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Size = New System.Drawing.Size(1015, 582)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 14)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Dia Inicial:"
        '
        'DateTimePickerI
        '
        Me.DateTimePickerI.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerI.Location = New System.Drawing.Point(78, 21)
        Me.DateTimePickerI.Name = "DateTimePickerI"
        Me.DateTimePickerI.Size = New System.Drawing.Size(110, 22)
        Me.DateTimePickerI.TabIndex = 29
        '
        'btnProcessar
        '
        Me.btnProcessar.Location = New System.Drawing.Point(103, 88)
        Me.btnProcessar.Name = "btnProcessar"
        Me.btnProcessar.Size = New System.Drawing.Size(85, 23)
        Me.btnProcessar.TabIndex = 19
        Me.btnProcessar.Text = "&Processar"
        Me.btnProcessar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 14)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Histórico:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 18)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SplitContainer1.Panel1.Controls.Add(Me.ckbX_PPI)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnGravar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnMarcaTodos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnDesmarcarTodos)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ckbX_EOS)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ckbX_Grupo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnProcessar)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePickerF)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ckbX_Cliente_Destinado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ckbX_Rota_Entrada)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ckbX_Cliente_Originado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DateTimePickerI)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ckbX_Rota_Saida)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1009, 561)
        Me.SplitContainer1.SplitterDistance = 200
        Me.SplitContainer1.TabIndex = 0
        '
        'ckbX_PPI
        '
        Me.ckbX_PPI.AutoSize = True
        Me.ckbX_PPI.Checked = True
        Me.ckbX_PPI.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbX_PPI.Location = New System.Drawing.Point(34, 298)
        Me.ckbX_PPI.Name = "ckbX_PPI"
        Me.ckbX_PPI.Size = New System.Drawing.Size(63, 18)
        Me.ckbX_PPI.TabIndex = 41
        Me.ckbX_PPI.Text = "X_PPI"
        Me.ckbX_PPI.UseVisualStyleBackColor = True
        '
        'btnGravar
        '
        Me.btnGravar.Location = New System.Drawing.Point(100, 506)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(85, 23)
        Me.btnGravar.TabIndex = 40
        Me.btnGravar.Text = "&Gravar"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnMarcaTodos
        '
        Me.btnMarcaTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarcaTodos.Location = New System.Drawing.Point(25, 448)
        Me.btnMarcaTodos.Name = "btnMarcaTodos"
        Me.btnMarcaTodos.Size = New System.Drawing.Size(160, 23)
        Me.btnMarcaTodos.TabIndex = 39
        Me.btnMarcaTodos.Text = "&Marcar Todos"
        Me.btnMarcaTodos.UseVisualStyleBackColor = True
        '
        'btnDesmarcarTodos
        '
        Me.btnDesmarcarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesmarcarTodos.Location = New System.Drawing.Point(25, 477)
        Me.btnDesmarcarTodos.Name = "btnDesmarcarTodos"
        Me.btnDesmarcarTodos.Size = New System.Drawing.Size(160, 23)
        Me.btnDesmarcarTodos.TabIndex = 38
        Me.btnDesmarcarTodos.Text = "&Desmarcar Todos"
        Me.btnDesmarcarTodos.UseVisualStyleBackColor = True
        '
        'ckbX_EOS
        '
        Me.ckbX_EOS.AutoSize = True
        Me.ckbX_EOS.Checked = True
        Me.ckbX_EOS.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbX_EOS.Location = New System.Drawing.Point(34, 274)
        Me.ckbX_EOS.Name = "ckbX_EOS"
        Me.ckbX_EOS.Size = New System.Drawing.Size(66, 18)
        Me.ckbX_EOS.TabIndex = 37
        Me.ckbX_EOS.Text = "X_EOS"
        Me.ckbX_EOS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckbX_ASS_A)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.numLimiteTCH)
        Me.GroupBox2.Controls.Add(Me.ckbX_ASS_B)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 332)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(160, 100)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'ckbX_ASS_A
        '
        Me.ckbX_ASS_A.AutoSize = True
        Me.ckbX_ASS_A.Checked = True
        Me.ckbX_ASS_A.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbX_ASS_A.Location = New System.Drawing.Point(19, 21)
        Me.ckbX_ASS_A.Name = "ckbX_ASS_A"
        Me.ckbX_ASS_A.Size = New System.Drawing.Size(84, 18)
        Me.ckbX_ASS_A.TabIndex = 38
        Me.ckbX_ASS_A.Text = "X_ASS_A"
        Me.ckbX_ASS_A.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 14)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "TCH  > "
        '
        'numLimiteTCH
        '
        Me.numLimiteTCH.Location = New System.Drawing.Point(77, 69)
        Me.numLimiteTCH.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.numLimiteTCH.Name = "numLimiteTCH"
        Me.numLimiteTCH.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.numLimiteTCH.Size = New System.Drawing.Size(70, 22)
        Me.numLimiteTCH.TabIndex = 35
        Me.numLimiteTCH.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'ckbX_ASS_B
        '
        Me.ckbX_ASS_B.AutoSize = True
        Me.ckbX_ASS_B.Checked = True
        Me.ckbX_ASS_B.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbX_ASS_B.Location = New System.Drawing.Point(19, 45)
        Me.ckbX_ASS_B.Name = "ckbX_ASS_B"
        Me.ckbX_ASS_B.Size = New System.Drawing.Size(83, 18)
        Me.ckbX_ASS_B.TabIndex = 34
        Me.ckbX_ASS_B.Text = "X_ASS_B"
        Me.ckbX_ASS_B.UseVisualStyleBackColor = True
        '
        'ckbX_Grupo
        '
        Me.ckbX_Grupo.AutoSize = True
        Me.ckbX_Grupo.Checked = True
        Me.ckbX_Grupo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbX_Grupo.Location = New System.Drawing.Point(34, 250)
        Me.ckbX_Grupo.Name = "ckbX_Grupo"
        Me.ckbX_Grupo.Size = New System.Drawing.Size(79, 18)
        Me.ckbX_Grupo.TabIndex = 33
        Me.ckbX_Grupo.Text = "X_Grupo"
        Me.ckbX_Grupo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 14)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Dia Final:"
        '
        'DateTimePickerF
        '
        Me.DateTimePickerF.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerF.Location = New System.Drawing.Point(78, 49)
        Me.DateTimePickerF.Name = "DateTimePickerF"
        Me.DateTimePickerF.Size = New System.Drawing.Size(110, 22)
        Me.DateTimePickerF.TabIndex = 31
        '
        'ckbX_Cliente_Destinado
        '
        Me.ckbX_Cliente_Destinado.AutoSize = True
        Me.ckbX_Cliente_Destinado.Checked = True
        Me.ckbX_Cliente_Destinado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbX_Cliente_Destinado.Location = New System.Drawing.Point(34, 226)
        Me.ckbX_Cliente_Destinado.Name = "ckbX_Cliente_Destinado"
        Me.ckbX_Cliente_Destinado.Size = New System.Drawing.Size(154, 18)
        Me.ckbX_Cliente_Destinado.TabIndex = 32
        Me.ckbX_Cliente_Destinado.Text = "X_Cliente_Destinado"
        Me.ckbX_Cliente_Destinado.UseVisualStyleBackColor = True
        '
        'ckbX_Rota_Entrada
        '
        Me.ckbX_Rota_Entrada.AutoSize = True
        Me.ckbX_Rota_Entrada.Checked = True
        Me.ckbX_Rota_Entrada.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbX_Rota_Entrada.Location = New System.Drawing.Point(34, 154)
        Me.ckbX_Rota_Entrada.Name = "ckbX_Rota_Entrada"
        Me.ckbX_Rota_Entrada.Size = New System.Drawing.Size(128, 18)
        Me.ckbX_Rota_Entrada.TabIndex = 29
        Me.ckbX_Rota_Entrada.Text = "X_Rota_Entrada"
        Me.ckbX_Rota_Entrada.UseVisualStyleBackColor = True
        '
        'ckbX_Cliente_Originado
        '
        Me.ckbX_Cliente_Originado.AutoSize = True
        Me.ckbX_Cliente_Originado.Checked = True
        Me.ckbX_Cliente_Originado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbX_Cliente_Originado.Location = New System.Drawing.Point(34, 202)
        Me.ckbX_Cliente_Originado.Name = "ckbX_Cliente_Originado"
        Me.ckbX_Cliente_Originado.Size = New System.Drawing.Size(151, 18)
        Me.ckbX_Cliente_Originado.TabIndex = 31
        Me.ckbX_Cliente_Originado.Text = "X_Cliente_Originado"
        Me.ckbX_Cliente_Originado.UseVisualStyleBackColor = True
        '
        'ckbX_Rota_Saida
        '
        Me.ckbX_Rota_Saida.AutoSize = True
        Me.ckbX_Rota_Saida.Checked = True
        Me.ckbX_Rota_Saida.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckbX_Rota_Saida.Location = New System.Drawing.Point(34, 178)
        Me.ckbX_Rota_Saida.Name = "ckbX_Rota_Saida"
        Me.ckbX_Rota_Saida.Size = New System.Drawing.Size(113, 18)
        Me.ckbX_Rota_Saida.TabIndex = 30
        Me.ckbX_Rota_Saida.Text = "X_Rota_Saida"
        Me.ckbX_Rota_Saida.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.cbFiltro)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lvLogAtividade)
        Me.SplitContainer2.Size = New System.Drawing.Size(805, 561)
        Me.SplitContainer2.SplitterDistance = 31
        Me.SplitContainer2.TabIndex = 2
        '
        'cbFiltro
        '
        Me.cbFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbFiltro.FormatString = "yyyy-MM-dd"
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Location = New System.Drawing.Point(271, 3)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(121, 22)
        Me.cbFiltro.TabIndex = 32
        Me.cbFiltro.Text = "Todos"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(233, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 14)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Filtro:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "LOG DE ATIVIDADES"
        '
        'lvLogAtividade
        '
        Me.lvLogAtividade.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvLogAtividade.Location = New System.Drawing.Point(0, 0)
        Me.lvLogAtividade.Name = "lvLogAtividade"
        Me.lvLogAtividade.Size = New System.Drawing.Size(805, 526)
        Me.lvLogAtividade.TabIndex = 1
        Me.lvLogAtividade.UseCompatibleStateImageBehavior = False
        '
        'frmGeraHistorico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 582)
        Me.ControlBox = True
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "frmGeraHistorico"
        Me.ShowIcon = False
        Me.Text = "Gera Histórico"
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numLimiteTCH, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Chart1 As Dundas.Charting.WinControl.Chart
    Friend WithEvents btnProcessar As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerI As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbX_Rota_Saida As System.Windows.Forms.CheckBox
    Friend WithEvents ckbX_Rota_Entrada As System.Windows.Forms.CheckBox
    Friend WithEvents ckbX_Cliente_Destinado As System.Windows.Forms.CheckBox
    Friend WithEvents ckbX_Cliente_Originado As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerF As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbX_Grupo As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents cbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lvLogAtividade As System.Windows.Forms.ListView
    Friend WithEvents ckbX_ASS_B As System.Windows.Forms.CheckBox
    Friend WithEvents numLimiteTCH As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ckbX_ASS_A As System.Windows.Forms.CheckBox
    Friend WithEvents ckbX_EOS As System.Windows.Forms.CheckBox
    Friend WithEvents btnDesmarcarTodos As System.Windows.Forms.Button
    Friend WithEvents btnMarcaTodos As System.Windows.Forms.Button
    Friend WithEvents btnGravar As System.Windows.Forms.Button
    Friend WithEvents ckbX_PPI As System.Windows.Forms.CheckBox
End Class
