Imports DevComponents.DotNetBar
Imports System.IO

Public Class BalloonSearch
    Inherits DevComponents.DotNetBar.Balloon

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents rbCSV As System.Windows.Forms.RadioButton
    Friend WithEvents rbExcel As System.Windows.Forms.RadioButton
    Friend WithEvents rbNotepad As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents rbTXT As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel
        Me.rbNotepad = New System.Windows.Forms.RadioButton
        Me.rbExcel = New System.Windows.Forms.RadioButton
        Me.rbCSV = New System.Windows.Forms.RadioButton
        Me.rbTXT = New System.Windows.Forms.RadioButton
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GroupPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.rbNotepad)
        Me.GroupPanel1.Controls.Add(Me.rbExcel)
        Me.GroupPanel1.Controls.Add(Me.rbCSV)
        Me.GroupPanel1.Controls.Add(Me.rbTXT)
        Me.GroupPanel1.IsShadowEnabled = True
        Me.GroupPanel1.Location = New System.Drawing.Point(22, 31)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(102, 113)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        Me.GroupPanel1.TabIndex = 9
        Me.GroupPanel1.Text = "Formato"
        '
        'rbNotepad
        '
        Me.rbNotepad.AutoSize = True
        Me.rbNotepad.Checked = True
        Me.rbNotepad.Location = New System.Drawing.Point(16, 3)
        Me.rbNotepad.Name = "rbNotepad"
        Me.rbNotepad.Size = New System.Drawing.Size(66, 17)
        Me.rbNotepad.TabIndex = 8
        Me.rbNotepad.TabStop = True
        Me.rbNotepad.Text = "Notepad"
        Me.rbNotepad.UseVisualStyleBackColor = True
        '
        'rbExcel
        '
        Me.rbExcel.AutoSize = True
        Me.rbExcel.Location = New System.Drawing.Point(16, 26)
        Me.rbExcel.Name = "rbExcel"
        Me.rbExcel.Size = New System.Drawing.Size(51, 17)
        Me.rbExcel.TabIndex = 8
        Me.rbExcel.Text = "Excel"
        Me.rbExcel.UseVisualStyleBackColor = True
        '
        'rbCSV
        '
        Me.rbCSV.AutoSize = True
        Me.rbCSV.Location = New System.Drawing.Point(16, 72)
        Me.rbCSV.Name = "rbCSV"
        Me.rbCSV.Size = New System.Drawing.Size(46, 17)
        Me.rbCSV.TabIndex = 1
        Me.rbCSV.Text = "CSV"
        Me.rbCSV.UseVisualStyleBackColor = True
        '
        'rbTXT
        '
        Me.rbTXT.AutoSize = True
        Me.rbTXT.Location = New System.Drawing.Point(16, 49)
        Me.rbTXT.Name = "rbTXT"
        Me.rbTXT.Size = New System.Drawing.Size(46, 17)
        Me.rbTXT.TabIndex = 0
        Me.rbTXT.Text = "TXT"
        Me.rbTXT.UseVisualStyleBackColor = True
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(22, 150)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(102, 23)
        Me.ButtonX1.TabIndex = 10
        Me.ButtonX1.Text = "Executar"
        '
        'BalloonSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(147, 185)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Name = "BalloonSearch"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub BalloonSearch_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.Opacity = 1
    End Sub

    Private Sub BalloonSearch_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Deactivate
        Me.Opacity = 0.9
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim sArqTemp As String = Path.GetTempFileName()

        If rbNotepad.Checked Then
            sArqTemp &= ".txt"
            Cursor = Cursors.WaitCursor
            frmListaCdrs.ExportaTXT(sArqTemp, True)
            'Me.Close()
        End If
        If rbExcel.Checked Then
            Cursor = Cursors.WaitCursor
            ExportToExcel(frmListaCdrs.dGridCdrs, xlsOption.xlsOpen)
            'frmListaCdrs.ExportaCSV(sArqTemp)
            'Me.Close()
        End If
        If rbTXT.Checked Then
            SaveFileDialog1.DefaultExt = "txt"
            If SaveFileDialog1.ShowDialog Then
                Cursor = Cursors.WaitCursor
                sArqTemp = SaveFileDialog1.FileName
                frmListaCdrs.ExportaTXT(sArqTemp, False)
            End If
        End If
        If rbCSV.Checked Then
            SaveFileDialog1.DefaultExt = "csv"
            If SaveFileDialog1.ShowDialog Then
                Cursor = Cursors.WaitCursor
                sArqTemp = SaveFileDialog1.FileName
                frmListaCdrs.ExportaCSV(sArqTemp, False)
            End If
        End If

    End Sub
End Class
