<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApagaRegistros
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.ckbCdrs = New System.Windows.Forms.CheckBox
        Me.ckbX_Grupo = New System.Windows.Forms.CheckBox
        Me.btnProcessar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePickerF = New System.Windows.Forms.DateTimePicker
        Me.ckbX_Cliente_Destinado = New System.Windows.Forms.CheckBox
        Me.ckbX_Rota_Entrada = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ckbX_Cliente_Originado = New System.Windows.Forms.CheckBox
        Me.DateTimePickerI = New System.Windows.Forms.DateTimePicker
        Me.ckbX_Rota_Saida = New System.Windows.Forms.CheckBox
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Label6 = New System.Windows.Forms.Label
        Me.lvTabelasCdrs = New System.Windows.Forms.ListView
        Me.cbFiltro = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lvLogAtividade = New System.Windows.Forms.ListView
        Me.Label4 = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.SplitContainer1.Panel1.Controls.Add(Me.ckbCdrs)
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
        Me.SplitContainer1.Size = New System.Drawing.Size(889, 510)
        Me.SplitContainer1.SplitterDistance = 190
        Me.SplitContainer1.TabIndex = 1
        '
        'ckbCdrs
        '
        Me.ckbCdrs.AutoSize = True
        Me.ckbCdrs.Location = New System.Drawing.Point(31, 167)
        Me.ckbCdrs.Name = "ckbCdrs"
        Me.ckbCdrs.Size = New System.Drawing.Size(54, 17)
        Me.ckbCdrs.TabIndex = 34
        Me.ckbCdrs.Text = "CDRs"
        Me.ckbCdrs.UseVisualStyleBackColor = True
        '
        'ckbX_Grupo
        '
        Me.ckbX_Grupo.AutoSize = True
        Me.ckbX_Grupo.Location = New System.Drawing.Point(31, 323)
        Me.ckbX_Grupo.Name = "ckbX_Grupo"
        Me.ckbX_Grupo.Size = New System.Drawing.Size(68, 17)
        Me.ckbX_Grupo.TabIndex = 33
        Me.ckbX_Grupo.Text = "X_Grupo"
        Me.ckbX_Grupo.UseVisualStyleBackColor = True
        '
        'btnProcessar
        '
        Me.btnProcessar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessar.ForeColor = System.Drawing.Color.Red
        Me.btnProcessar.Location = New System.Drawing.Point(90, 90)
        Me.btnProcessar.Name = "btnProcessar"
        Me.btnProcessar.Size = New System.Drawing.Size(85, 23)
        Me.btnProcessar.TabIndex = 19
        Me.btnProcessar.Text = "&Apagar"
        Me.btnProcessar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Dia Final:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 210)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Histórico:"
        '
        'DateTimePickerF
        '
        Me.DateTimePickerF.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerF.Location = New System.Drawing.Point(65, 49)
        Me.DateTimePickerF.Name = "DateTimePickerF"
        Me.DateTimePickerF.Size = New System.Drawing.Size(110, 20)
        Me.DateTimePickerF.TabIndex = 31
        '
        'ckbX_Cliente_Destinado
        '
        Me.ckbX_Cliente_Destinado.AutoSize = True
        Me.ckbX_Cliente_Destinado.Location = New System.Drawing.Point(31, 299)
        Me.ckbX_Cliente_Destinado.Name = "ckbX_Cliente_Destinado"
        Me.ckbX_Cliente_Destinado.Size = New System.Drawing.Size(125, 17)
        Me.ckbX_Cliente_Destinado.TabIndex = 32
        Me.ckbX_Cliente_Destinado.Text = "X_Cliente_Destinado"
        Me.ckbX_Cliente_Destinado.UseVisualStyleBackColor = True
        '
        'ckbX_Rota_Entrada
        '
        Me.ckbX_Rota_Entrada.AutoSize = True
        Me.ckbX_Rota_Entrada.Location = New System.Drawing.Point(31, 227)
        Me.ckbX_Rota_Entrada.Name = "ckbX_Rota_Entrada"
        Me.ckbX_Rota_Entrada.Size = New System.Drawing.Size(105, 17)
        Me.ckbX_Rota_Entrada.TabIndex = 29
        Me.ckbX_Rota_Entrada.Text = "X_Rota_Entrada"
        Me.ckbX_Rota_Entrada.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Dia Inicial:"
        '
        'ckbX_Cliente_Originado
        '
        Me.ckbX_Cliente_Originado.AutoSize = True
        Me.ckbX_Cliente_Originado.Location = New System.Drawing.Point(31, 275)
        Me.ckbX_Cliente_Originado.Name = "ckbX_Cliente_Originado"
        Me.ckbX_Cliente_Originado.Size = New System.Drawing.Size(122, 17)
        Me.ckbX_Cliente_Originado.TabIndex = 31
        Me.ckbX_Cliente_Originado.Text = "X_Cliente_Originado"
        Me.ckbX_Cliente_Originado.UseVisualStyleBackColor = True
        '
        'DateTimePickerI
        '
        Me.DateTimePickerI.CustomFormat = "yyyy-MM-dd"
        Me.DateTimePickerI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerI.Location = New System.Drawing.Point(65, 21)
        Me.DateTimePickerI.Name = "DateTimePickerI"
        Me.DateTimePickerI.Size = New System.Drawing.Size(110, 20)
        Me.DateTimePickerI.TabIndex = 29
        '
        'ckbX_Rota_Saida
        '
        Me.ckbX_Rota_Saida.AutoSize = True
        Me.ckbX_Rota_Saida.Location = New System.Drawing.Point(31, 251)
        Me.ckbX_Rota_Saida.Name = "ckbX_Rota_Saida"
        Me.ckbX_Rota_Saida.Size = New System.Drawing.Size(95, 17)
        Me.ckbX_Rota_Saida.TabIndex = 30
        Me.ckbX_Rota_Saida.Text = "X_Rota_Saida"
        Me.ckbX_Rota_Saida.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel1.Controls.Add(Me.lvTabelasCdrs)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.cbFiltro)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel2.Controls.Add(Me.lvLogAtividade)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer2.Size = New System.Drawing.Size(695, 510)
        Me.SplitContainer2.SplitterDistance = 246
        Me.SplitContainer2.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "LISTA DE TABELAS CDRs"
        '
        'lvTabelasCdrs
        '
        Me.lvTabelasCdrs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvTabelasCdrs.Location = New System.Drawing.Point(1, 25)
        Me.lvTabelasCdrs.Name = "lvTabelasCdrs"
        Me.lvTabelasCdrs.Size = New System.Drawing.Size(242, 482)
        Me.lvTabelasCdrs.TabIndex = 3
        Me.lvTabelasCdrs.UseCompatibleStateImageBehavior = False
        '
        'cbFiltro
        '
        Me.cbFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbFiltro.FormatString = "yyyy-MM-dd"
        Me.cbFiltro.FormattingEnabled = True
        Me.cbFiltro.Location = New System.Drawing.Point(192, 3)
        Me.cbFiltro.Name = "cbFiltro"
        Me.cbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cbFiltro.TabIndex = 32
        Me.cbFiltro.Text = "Todos"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(154, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Filtro:"
        '
        'lvLogAtividade
        '
        Me.lvLogAtividade.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvLogAtividade.Location = New System.Drawing.Point(0, 26)
        Me.lvLogAtividade.Name = "lvLogAtividade"
        Me.lvLogAtividade.Size = New System.Drawing.Size(445, 708)
        Me.lvLogAtividade.TabIndex = 1
        Me.lvLogAtividade.UseCompatibleStateImageBehavior = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "LOG DE ATIVIDADES"
        '
        'frmApagaRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(889, 510)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frmApagaRegistros"
        Me.ShowIcon = False
        Me.Text = "Apaga Registros"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ckbX_Grupo As System.Windows.Forms.CheckBox
    Friend WithEvents btnProcessar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerF As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbX_Cliente_Destinado As System.Windows.Forms.CheckBox
    Friend WithEvents ckbX_Rota_Entrada As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ckbX_Cliente_Originado As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePickerI As System.Windows.Forms.DateTimePicker
    Friend WithEvents ckbX_Rota_Saida As System.Windows.Forms.CheckBox
    Friend WithEvents ckbCdrs As System.Windows.Forms.CheckBox
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lvLogAtividade As System.Windows.Forms.ListView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbFiltro As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lvTabelasCdrs As System.Windows.Forms.ListView
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
