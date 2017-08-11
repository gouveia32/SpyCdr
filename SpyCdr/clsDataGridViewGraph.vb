Imports System
Imports System.Configuration
Imports System.Collections

Public Class BarGraphDataGridView
    Inherits DataGridViewTextBoxColumn

    'Constructor
    Public Sub New()
        Me.CellTemplate = New BarGraphDataGridViewrCell()
    End Sub
    'CellTemplateAcquisition it sets
    Public Overrides Property CellTemplate() As DataGridViewCell
        Get
            Return MyBase.CellTemplate
        End Get
        Set(ByVal value As DataGridViewCell)
            'DataGridViewProgressBarCellThe host it does not do other than
            If Not TypeOf value Is BarGraphDataGridViewrCell Then
                Throw New InvalidCastException( _
                    "BarGraphDataGridViewrCellObject" + _
                    "Aponte por favor.")
            End If
            MyBase.CellTemplate = value
        End Set
    End Property

    ''' <summary>
    ''' ProgressBarMaximo
    ''' </summary>
    Public Property Maximo() As Integer
        Get
            Return CType(Me.CellTemplate, BarGraphDataGridViewrCell).Maximo
        End Get
        Set(ByVal value As Integer)
            If Me.Maximo = value Then
                Return
            End If
            'Value of the cell templet is modified
            CType(Me.CellTemplate, BarGraphDataGridViewrCell).Maximo = value
            'DataGridViewValue of the cell which has been added already is modified
            If Me.DataGridView Is Nothing Then
                Return
            End If
            Dim rowCount As Integer = Me.DataGridView.RowCount
            Dim i As Integer
            For i = 0 To rowCount - 1
                Dim r As DataGridViewRow = Me.DataGridView.Rows.SharedRow(i)
                CType(r.Cells(Me.Index), BarGraphDataGridViewrCell).Maximo = _
                    value
            Next i
        End Set
    End Property

    ''' <summary>
    ''' ProgressBarMinimum
    ''' </summary>
    Public Property Cores() As List(Of Color)
        Get
            Return CType(Me.CellTemplate, BarGraphDataGridViewrCell).Cores
        End Get
        Set(ByVal value As List(Of Color))
            'Value of the cell templet is modified
            CType(Me.CellTemplate, BarGraphDataGridViewrCell).Cores = value
            'DataGridViewValue of the cell which has been added already is modified
            If Me.DataGridView Is Nothing Then
                Return
            End If
            Dim rowCount As Integer = Me.DataGridView.RowCount
            Dim i As Integer
            For i = 0 To rowCount - 1
                Dim r As DataGridViewRow = Me.DataGridView.Rows.SharedRow(i)
                CType(r.Cells(Me.Index), BarGraphDataGridViewrCell).Cores = _
                    value
            Next i
        End Set
    End Property

    Public Property indicador() As List(Of String)
        Get
            Return CType(Me.CellTemplate, BarGraphDataGridViewrCell).indicador
        End Get
        Set(ByVal value As List(Of String))
            'Value of the cell templet is modified
            CType(Me.CellTemplate, BarGraphDataGridViewrCell).indicador = value
            'DataGridViewValue of the cell which has been added already is modified
            If Me.DataGridView Is Nothing Then
                Return
            End If
            Dim rowCount As Integer = Me.DataGridView.RowCount
            Dim i As Integer
            For i = 0 To rowCount - 1
                Dim r As DataGridViewRow = Me.DataGridView.Rows.SharedRow(i)
                CType(r.Cells(Me.Index), BarGraphDataGridViewrCell).indicador = _
                    value
            Next i
        End Set
    End Property
End Class
''' <summary>
''' ProgressBar is indicated in DataGridView
''' </summary>
Public Class BarGraphDataGridViewrCell
    Inherits DataGridViewTextBoxCell

    Private _RequireClear As Boolean = False

    'Constructor
    Public Sub New()
        Me.MaximoValue = 1000
        Dim i As Integer
        Dim cores() = {Color.Brown, Color.Red, Color.DarkRed, Color.Purple, Color.Magenta, Color.Aqua, Color.Blue, Color.DarkBlue, Color.Green, Color.DarkGreen, Color.Yellow}
        Dim Indicadores() = {"CO0", "CO1", "CO2", "CO3", "DSC", "LO", "NR1", "NR5", "OK1", "OK5", "OU"}

        For i = 0 To 10
            myInd.Add(Indicadores(i))
            myCor.Add(cores(i))
        Next
    End Sub

    Private myInd As New List(Of String)
    Public Property indicador() As List(Of String)
        Get
            Return Me.myInd
        End Get
        Set(ByVal value As List(Of String))
            Me.myInd = value
        End Set
    End Property
    Private MaximoValue As Integer
    Public Property Maximo() As Integer
        Get
            Return Me.MaximoValue
        End Get
        Set(ByVal value As Integer)
            Me.MaximoValue = value
        End Set
    End Property

    Private myCor As New List(Of Color)

    Public Property Cores() As List(Of Color)
        Get
            Return Me.myCor
        End Get
        Set(ByVal value As List(Of Color))
            Me.myCor = value
        End Set
    End Property
    'Data type of value of the cell is appointed
    'Here, it makes integer type
    Public Overrides ReadOnly Property ValueType() As Type
        Get
            Return GetType(Integer)
        End Get
    End Property

    'Established value of the cell of new record line is appointed
    Public Overrides ReadOnly Property DefaultNewRowValue() As Object
        Get
            Return 0
        End Get
    End Property
    'Because the new property has been added,
    ' It is necessary to override Clone method
    Public Overrides Function Clone() As Object
        Dim cell As BarGraphDataGridViewrCell = _
            CType(MyBase.Clone(), BarGraphDataGridViewrCell)
        cell.Maximo = Me.Maximo
        cell.Cores = Me.Cores
        cell.indicador = Me.indicador
        'cell.Value = Me.Value
        Return cell
    End Function

    Protected Overrides Sub Paint(ByVal graphics As Graphics, _
        ByVal clipBounds As Rectangle, _
        ByVal cellBounds As Rectangle, _
        ByVal rowIndex As Integer, _
        ByVal cellState As DataGridViewElementStates, _
        ByVal value As Object, _
        ByVal formattedValue As Object, _
        ByVal errorText As String, _
        ByVal cellStyle As DataGridViewCellStyle, _
        ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, _
        ByVal paintParts As DataGridViewPaintParts)

        'Value is decided
        Dim intValue As Integer = 0
        If TypeOf value Is Integer Then
            intValue = CInt(value)
        End If
        If intValue > Me.MaximoValue Then
            intValue = Me.MaximoValue
        End If
        'Ratio is calculated
        Dim rate As Double = CDbl(intValue) / (Me.MaximoValue)

        'The boundary line of the cell (the framework) it draws
        If (paintParts And DataGridViewPaintParts.Border) = _
                DataGridViewPaintParts.Border Then
            Me.PaintBorder(graphics, clipBounds, cellBounds, _
                cellStyle, advancedBorderStyle)
        End If

        'The range is acquired inside the boundary line
        Dim borderRect As Rectangle = Me.BorderWidths(advancedBorderStyle)
        Dim paintRect As New Rectangle(cellBounds.Left + borderRect.Left, _
            cellBounds.Top + borderRect.Top, _
            cellBounds.Width - borderRect.Right, _
            cellBounds.Height - borderRect.Bottom)

        'Background color is decided
        'When being selected, when being done, color is changed
        Dim isSelected As Boolean = _
            ((cellState And DataGridViewElementStates.Selected) = _
                DataGridViewElementStates.Selected)
        Dim bkColor As Color
        If isSelected AndAlso _
            (paintParts And DataGridViewPaintParts.SelectionBackground) = _
                DataGridViewPaintParts.SelectionBackground Then
            bkColor = cellStyle.SelectionBackColor
        Else
            bkColor = cellStyle.BackColor
        End If

        'Padding is deducted
        paintRect.Offset(cellStyle.Padding.Right, cellStyle.Padding.Top)
        paintRect.Width -= cellStyle.Padding.Horizontal
        paintRect.Height -= cellStyle.Padding.Vertical

        'ProgressBar is drawn
        If (paintParts And DataGridViewPaintParts.ContentForeground) = _
            DataGridViewPaintParts.ContentForeground Then
            If ProgressBarRenderer.IsSupported Then
                'It draws with visual style

                'The framework of ProgressBar is drawn
                ProgressBarRenderer.DrawHorizontalBar(graphics, paintRect)
                DrawBackGround(graphics, paintRect, value) 'Incluir aqui

                'The bar of ProgressBar is drawn
                Dim barBounds As New Rectangle(paintRect.Left + 3, _
                    paintRect.Top + 3, _
                    paintRect.Width - 4, _
                    paintRect.Height - 6)
                barBounds.Width = CInt(Math.Round((barBounds.Width * rate)))
                'ProgressBarRenderer.DrawHorizontalChunks(graphics, barBounds)
                'DrawBackGround(graphics, cellBounds) 'Incluir aqui
            Else
                'When drawing with visual style,
                graphics.FillRectangle(Brushes.White, paintRect)
                graphics.DrawRectangle(Pens.Black, paintRect)
                Dim barBounds As New Rectangle(paintRect.Left + 1, _
                    paintRect.Top + 1, _
                    paintRect.Width - 1, _
                    paintRect.Height - 1)
                barBounds.Width = CInt(Math.Round((barBounds.Width * rate)))
                'graphics.FillRectangle(Brushes.Blue, barBounds)
            End If
        End If

        'The framework of focusing is indicated
        If Me.DataGridView.CurrentCellAddress.X = Me.ColumnIndex AndAlso _
            Me.DataGridView.CurrentCellAddress.Y = Me.RowIndex AndAlso _
            (paintParts And DataGridViewPaintParts.Focus) = _
                DataGridViewPaintParts.Focus AndAlso _
            Me.DataGridView.Focused Then

            'Size of the focusing framework is decided suitably
            Dim focusRect As Rectangle = paintRect
            focusRect.Inflate(-3, -3)
            ControlPaint.DrawFocusRectangle(graphics, focusRect)
            'Appointing background color, when drawing the focusing framework,
            'ControlPaint.DrawFocusRectangle(
            '    graphics, focusRect, Color.Empty, bkColor);
        End If

        'Indication of error idea contest
        If (paintParts And DataGridViewPaintParts.ErrorIcon) = _
                DataGridViewPaintParts.ErrorIcon AndAlso _
            Me.DataGridView.ShowCellErrors AndAlso _
            Not String.IsNullOrEmpty(errorText) Then

            'Acquiring the territory where the error idea contest is made to indicate
            Dim iconBounds As Rectangle = _
                Me.GetErrorIconBounds(graphics, cellStyle, rowIndex)
            iconBounds.Offset(cellBounds.X, cellBounds.Y)
            'Drawing the error idea contest
            'Me.PaintErrorIcon(graphics, iconBounds, cellBounds, errorText)
        End If
    End Sub
    Private Sub DrawBackGround(ByVal graphics As Graphics, ByVal r As Rectangle, ByVal Valor As Object)
        graphics.DrawRectangle(New Pen(SystemColors.ActiveBorder), New Rectangle(0, 0, r.Width - 1, r.Height - 1))
        Dim iBoxSize As Integer = r.Height * 0.75
        Dim tch, vt, i, margem_esq As Integer
        Dim mCores(11) As Color

        If Valor.ToString = "0" Then Exit Sub

        tch = 0

        For i = 0 To Me.Value.Count - 1
            tch += Valor(i)
            mCores(i) = myCor.Item(i)
        Next

        'vt = Me.MaximoValue * 100 / r.Width 'porcentual máximo
        vt = tch * 100 / r.Width 'porcentual máximo

        If iBoxSize > 3 Then
            'entire area Rectangle for the background image
            Dim R0 As New Rectangle(r.Left, r.Top, r.Height, r.Height)
            margem_esq = R0.Left
            For i = 0 To Me.Value.Count - 1
                Dim R1 As New Rectangle(margem_esq, R0.Top, Valor(i) / vt * 100, R0.Height)
                margem_esq += R1.Width
                'Desenha a barra do Indicador1
                Dim Brocha As New Drawing2D.LinearGradientBrush(R0, mCores(i), Color.LightBlue, 90)
                'graphics.FillRectangle(New SolidBrush(mCores(i)), R1)
                graphics.FillRectangle(Brocha, R1)
            Next i
        End If
    End Sub
End Class

