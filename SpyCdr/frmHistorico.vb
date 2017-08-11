Imports Dundas.Charting.WinControl
Imports System.Data
Imports System.Threading.Thread
Imports System.Globalization

Public Class frmHistorico

    'define os objetos connecton, command e dataadapter
    Dim dt As DataTable

    Dim registrosAfetados As Integer
    Dim IndicadorNome() As String = {"CO0", "CO1", "CO2", "CO3", "DSC", "LO", "NR1", "NR5", "OK1", "OK5", "OU"}
    Dim mTipos(32), mEventos(32) As String
    Dim ArvoreCarregada, GradePreenchida, GraficoGerado As Boolean
    Dim Graf1Escolhido, Graf2Escolhido As Integer
    Public flCarga As Boolean = False
    Public TreeSelect As String = ""

    Private Sub ProcessoInicio(ByVal msg As String)
        Cursor = Cursors.WaitCursor
        lblAguarde.Text = "Processando, Aguarde...     (" & msg & ")"
        lblAguarde.Visible = True
        lblAguarde.Refresh()
    End Sub

    Private Sub ProcessoFim()
        lblAguarde.Visible = False
        lblAguarde.Refresh()
        Cursor = Cursors.Default
        TreeView1.Select()
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub CarregaGrupo()
        Dim strSQL As String

        'carrega cbGrupo
        If Conn Is Nothing Then Exit Sub
        ProcessoInicio("  carregando grupo  ")
        Conn.Close()
        Select Case Me.cbHistorico.Text
            Case Is = "X_Rota_Entrada"
                Select Case frmManutencao.cbTipoCentral.Text
                    Case "E"
                        strSQL = "SELECT DISTINCT R_ENT, ROTA " _
                                     & "FROM X_Rota_Entrada JOIN _exrop ON R_ENT = _exrop.RIN ORDER BY ROTA ASC"
                    Case "H"
                        strSQL = "SELECT DISTINCT R_ENT, LST_TG.`tg_name` AS ROTA " _
                                     & "FROM X_Rota_Entrada JOIN LST_TG ON TRUNCATE(R_ENT,0) = LST_TG.`tg_number` ORDER BY ROTA ASC"
                    Case "N"
                        strSQL = "SELECT DISTINCT R_ENT AS ROTA, R_ENT AS ROTA2 " _
                                     & "FROM X_Rota_Entrada ORDER BY R_ENT ASC"
                End Select
                lblGrupo.Text = "Rota:"
            Case Is = "X_Rota_Saida"
                Select Case frmManutencao.cbTipoCentral.Text
                    Case "E"
                        strSQL = "SELECT DISTINCT R_SAI, ROTA " _
                                     & "FROM X_Rota_Saida JOIN _exrop ON R_SAI = _exrop.RIN ORDER BY ROTA ASC"
                    Case "H"
                        strSQL = "SELECT DISTINCT R_SAI, LST_TG.`tg_name` AS ROTA " _
                                     & "FROM X_Rota_Saida JOIN LST_TG ON TRUNCATE(R_SAI,0) = LST_TG.`tg_number` ORDER BY ROTA ASC"
                    Case "N"
                        strSQL = "SELECT DISTINCT R_SAI AS ROTA, R_SAI AS ROTA2 " _
                                     & "FROM X_Rota_Saida ORDER BY R_SAI ASC"
                End Select

                lblGrupo.Text = "Rota:"
            Case Is = "X_Cliente_Originado"
                strSQL = "SELECT DISTINCT X_Cliente_Originado.COD_CLI, clientes.CLIENTE " _
                             & "FROM X_Cliente_Originado JOIN clientes ON X_Cliente_Originado.COD_CLI = clientes.COD_CLI ORDER BY clientes.CLIENTE ASC"
                lblGrupo.Text = "Cliente:"
            Case Is = "X_Cliente_Destinado"
                strSQL = "SELECT DISTINCT X_Cliente_Destinado.COD_CLI, clientes.CLIENTE " _
                             & "FROM X_Cliente_Destinado JOIN clientes ON X_Cliente_Destinado.COD_CLI = clientes.COD_CLI ORDER BY clientes.CLIENTE ASC"
                lblGrupo.Text = "Cliente:"
            Case Is = "X_Grupo"
                strSQL = "SELECT DISTINCT GRUPO, GRUPO " _
                             & "FROM X_Grupo ORDER BY GRUPO ASC"
                lblGrupo.Text = "Grupo:"
            Case Is = "X_ASS_A"
                strSQL = "SELECT DISTINCT ASS_A, ASS_A " _
                             & "FROM X_ASS_A ORDER BY ASS_A ASC"
                lblGrupo.Text = "Ass_A:"
            Case Is = "X_ASS_B"
                strSQL = "SELECT DISTINCT ASS_B, ASS_B " _
                             & "FROM X_ASS_B ORDER BY ASS_B ASC"
                lblGrupo.Text = "Ass_B:"
            Case Is = "X_EOS"
                strSQL = "SELECT DISTINCT EOS, EOS " _
                             & "FROM X_EOS ORDER BY EOS ASC"
                lblGrupo.Text = "EOS:"
        End Select
        dt = MySQL_Select(Conn, strSQL)
        cbGrupo.DataSource = dt
        cbGrupo.Items.Add("Tudo")
        ProcessoFim()

    End Sub
    Private Sub CarregaArvore()
        Dim noAno As TreeNode
        Dim i, j As Integer
        Dim a, m, d As Integer

        ProcessoInicio("  montando  árvore  ")

        TreeView1.BeginUpdate()
        TreeView1.Nodes.Clear()

        Try
            dt = MySQL_Select(Conn, "SELECT DISTINCT year(data) as ANO, month(data) as MES, day(data) as DIA FROM " & Me.cbHistorico.Text)

            a = m = d = i = j = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item(0) <> a Then 'criar no do ANO
                    a = dt.Rows(i).Item(0)
                    j = 0
                    noAno = New TreeNode
                    With noAno
                        .ImageIndex = 1
                        .Tag = dt.Rows(i).Item(0)
                        .Text = dt.Rows(i).Item(0)
                    End With
                    TreeView1.Nodes.Add(noAno)
                    i += 1
                End If
                If dt.Rows(i).Item(1) <> m Then 'criar no do MES
                    m = dt.Rows(i).Item(1)
                    noAno = New TreeNode
                    With noAno
                        .ImageIndex = 1
                        .Tag = dt.Rows(i).Item(1)
                        .Text = dt.Rows(i).Item(1)
                    End With
                    TreeView1.Nodes(i - 1).Nodes.Add(noAno)
                    j += 1
                End If
                If Me.cbHistorico.Text <> "X_ASS_A" And Me.cbHistorico.Text <> "X_ASS_B" Then
                    If dt.Rows(i).Item(2) <> d Then 'criar no do DIA
                        d = dt.Rows(i).Item(2)
                        noAno = New TreeNode
                        With noAno
                            .ImageIndex = 1
                            .Tag = dt.Rows(i).Item(2)
                            .Text = dt.Rows(i).Item(2)
                        End With
                        TreeView1.Nodes(i - 1).Nodes(j - 1).Nodes.Add(noAno)
                    End If
                    cbIntervalo.Enabled = True
                Else
                    cbIntervalo.Enabled = False
                End If
            Next i
            TreeView1.EndUpdate()

            'CarregaGrupo()

            Conn.Close()

        Catch ex As Exception
            MessageBox.Show("ERRO " & ex.Message, "Verifica tabela")
        Finally
            'If Not GradePreenchida Then PreencheGrid()
            ArvoreCarregada = True
            ProcessoFim()
        End Try

    End Sub
    Private Sub PreencheGrid()
        Dim no As TreeNode
        Dim sqlSelect As String
        Dim sqlWhere As String
        Dim sqlGroupBy As String
        Dim sql As String
        Dim data As Date
        Dim c As Integer
        'If Not ArvoreCarregada Then Exit Sub
        ProcessoInicio("preenchendo grade")

        Dim mIndicador() As String = {"sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU) AS TCH", _
                                      "sum(CO0) AS `CO0_ch`", _
                                      "sum(CO1) AS `CO1_ch`", _
                                      "sum(CO2) AS `CO2_ch`", _
                                      "sum(CO3) AS `CO3_ch`", _
                                      "sum(DSC) AS `DSC_ch`", _
                                      "sum(LO) AS `LO_ch`", _
                                      "sum(NR1) AS `NR1_ch`", _
                                      "sum(NR5) AS `NR5_ch`", _
                                      "sum(OK1) AS `OK1_ch`", _
                                      "sum(OK5) AS `OK5_ch`", _
                                      "sum(OU) AS `OU_ch`", _
                                      "sum(OK1+OK5) AS `OK_ch`", _
                                      "sum(NR1+NR5+LO) AS `PAB_ch`", _
                                      "sum(CO0+CO1+CO2+CO3) AS `CO_ch`", _
                                      "sum(CO0+CO1+CO2+CO3+NR1+NR5+LO+DSC+OU) AS `NOK_ch`", _
                                      "round(sum(CO0)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `CO0_%`", _
                                      "round(sum(CO1)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `CO1_%`", _
                                      "round(sum(CO2)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `CO2_%`", _
                                      "round(sum(CO3)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `CO3_%`", _
                                      "round(sum(DSC)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `DSC_%`", _
                                      "round(sum(LO)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `LO_%`", _
                                      "round(sum(NR1)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `NR1_%`", _
                                      "round(sum(NR5)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `NR5_%`", _
                                      "round(sum(OK1)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `OK1_%`", _
                                      "round(sum(OK5)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `OK5_%`", _
                                      "round(sum(OU)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `OU_%`", _
                                      "round(sum(OK1+OK5)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `OK_ %`", _
                                      "round(sum(OK1+OK5)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+OU)*100,1) AS `OKa_ %`", _
                                      "round(sum(NR1+NR5+LO)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `PAB_%`", _
                                      "round(sum(CO0+CO1+CO2+CO3)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `CO_%`", _
                                      "round(sum(CO0+CO1+CO2+CO3+NR1+NR5+LO+DSC+OU)/sum(CO0+CO1+CO2+CO3+OK1+OK5+NR1+NR5+LO+DSC+OU)*100,1) AS `NOK_%`"}

        'define o dataset
        Dim ds As DataSet = New DataSet()

        If tcArvore.SelectedTabIndex = 0 Then 'Periodo
            If Conn Is Nothing Then Exit Sub
            conn.Close()
            Me.lblData.Text = "Universo: Período"
            Me.Chart1.Titles(0).Text = "Universo:" & Format(CDate(dtpDataInicial.Value), "yyyy-MM-dd") & "-" & Format(CDate(dtpDataFinal.Value), "yyyy-MM-dd") & " | " & lblGrupo.Text & sql & " | Intervalo:" & Me.cbIntervalo.Text
            sqlSelect = "SELECT CONCAT_WS('-', SubStr('01020304050607080910111213141516171819202122232425262728293031',Day(Data)* 2-1,2), SubStr('010203040506070809101112',Month(Data)* 2-1,2), SubStr('DomSegTerQuaQuiSexSab',DayOfWeek(Data)*3-2,3) ) as DIA"
            For c = 0 To 31
                sqlSelect &= ", " & mIndicador(c)
            Next
            sqlWhere = " WHERE Date(DATA)>='" & Format(CDate(dtpDataInicial.Value), "yyyy-MM-dd") & "'" _
                     & " AND  Date(DATA)<='" & Format(CDate(dtpDataFinal.Value), "yyyy-MM-dd") & "'"
            sqlGroupBy = " GROUP BY DIA ORDER BY DATA "
            'monta matriz com os eventos do mes um por dia
            dt = MySQL_Select(Conn, "SELECT DISTINCT day(data) as DIA, TIPO, EVENTO FROM eventos " & sqlWhere & " ORDER BY day(DATA)")
            For c = 0 To 31
                mEventos(c) = ""
                mTipos(c) = ""
            Next
            For c = 0 To dt.Rows.Count - 1
                mTipos(dt.Rows(c).Item(0)) = dt.Rows(c).Item(1)
                mEventos(dt.Rows(c).Item(0)) = dt.Rows(c).Item(2)
            Next c
        Else
            If Not ArvoreCarregada Then
                CarregaArvore()
            End If
            no = Me.TreeView1.SelectedNode

            If Me.TreeView1.SelectedNode Is Nothing Then
                Me.TreeView1.Select()
            End If
            no = Me.TreeView1.SelectedNode
            If no Is Nothing Then
                ProcessoFim()
                Exit Sub
            End If
            Me.lblData.Text = "Universo: " & no.FullPath
            sql = cbGrupo.Text 'usa sql temporariamente
            If sql.LastIndexOf("(") > 0 Then sql = sql.Substring(0, sql.LastIndexOf("(") - 1).Trim

            Me.Chart1.Titles(0).Text = "Universo:" & no.FullPath & " | " & lblGrupo.Text & sql & " | Intervalo:" & Me.cbIntervalo.Text

            Select Case no.Level
                Case Is = 0
                    sqlSelect = "SELECT month(Data) as MES"
                    For c = 0 To 31
                        sqlSelect &= ", " & mIndicador(c)
                    Next c
                    sqlWhere = " WHERE substr(DATA,1,4)='" & no.Text & "'"
                    sqlGroupBy = " GROUP BY month(Data)"
                Case Is = 1
                    'data = no.Parent.Text & "-" & no.SelectedCell.Text & "-01"
                    data = no.Parent.Text & "-" & no.Text & "-01"
                    sqlSelect = "SELECT CONCAT_WS('-', SubStr('01020304050607080910111213141516171819202122232425262728293031',Day(Data)* 2-1,2), SubStr('DomSegTerQuaQuiSexSab',DayOfWeek(Data)* 3-2,3) ) as DIA"
                    For c = 0 To 31
                        sqlSelect &= ", " & mIndicador(c)
                    Next
                    sqlWhere = " WHERE year(DATA)=" & data.Year _
                             & " AND month(DATA)=" & data.Month
                    sqlGroupBy = " GROUP BY Day(Data)"
                    'monta matriz com os eventos do mes um por dia
                    dt = MySQL_Select(Conn, "SELECT DISTINCT day(data) as DIA, TIPO, EVENTO FROM eventos WHERE month(DATA)=" & data.Month & " AND year(DATA)=" & data.Year & " ORDER BY day(DATA)")
                    For c = 0 To 31
                        mEventos(c) = ""
                        mTipos(c) = ""
                    Next

                    For c = 0 To dt.Rows.Count - 1
                        mTipos(dt.Rows(c).Item(0)) = dt.Rows(c).Item(1)
                        mEventos(dt.Rows(c).Item(0)) = dt.Rows(c).Item(2)
                    Next c

                Case Is = 2
                    'data = no.Parent.Parent.Text & "-" & no.Parent.Text & "-" & no.SelectedCell.Text
                    data = no.Parent.Parent.Text & "-" & no.Parent.Text & "-" & no.Text
                    sqlSelect = "SELECT HORA"
                    For c = 0 To 31
                        sqlSelect &= ", " & mIndicador(c)
                    Next c

                    sqlWhere = " WHERE year(DATA)=" & data.Year _
                             & " AND month(DATA)=" & data.Month _
                             & " AND day(DATA)=" & data.Day

                    sqlGroupBy = " GROUP BY HORA "
                    'monta matriz com os eventos do mes um por hora
                    dt = MySQL_Select(Conn, "SELECT DISTINCT hour(data) as HORA, TIPO, EVENTO FROM eventos " & sqlWhere & " ORDER BY day(DATA)")
                    For c = 0 To 31
                        mEventos(c) = ""
                        mTipos(c) = ""
                    Next
                    For c = 0 To dt.Rows.Count - 1
                        mTipos(dt.Rows(c).Item(0)) = dt.Rows(c).Item(1)
                        mEventos(dt.Rows(c).Item(0)) = dt.Rows(c).Item(2)
                    Next c
            End Select
        End If

        'Filtra Grupo
        If Me.cbGrupo.Text <> "Tudo" Then
            ' Find the first match for the typed value.
            c = Me.cbGrupo.FindString(Me.cbGrupo.Text)
            If c > 0 Then
                Me.cbGrupo.SelectedIndex = c
                sql = CType(Me.cbGrupo.SelectedItem, ValueDescriptionPair).Value 'usa sql provisoriamente
            End If

            Select Case Me.cbHistorico.Text
                Case Is = "X_Rota_Entrada"
                    sqlWhere += " AND R_ENT='" & sql & "'"
                Case Is = "X_Rota_Saida"
                    sqlWhere += " AND R_SAI='" & sql & "'"
                Case Is = "X_Cliente_Originado"
                    sqlWhere += " AND COD_CLI=" & sql
                Case Is = "X_Cliente_Destinado"
                    sqlWhere += " AND COD_CLI=" & sql
                Case Is = "X_Grupo"
                    sqlWhere += " AND GRUPO='" & sql & "'"
                Case Is = "X_ASS_A"
                    sqlWhere += " AND ASS_A='" & sql & "'"
                Case Is = "X_ASS_B"
                    sqlWhere += " AND ASS_B='" & sql & "'"
                Case Is = "X_EOS"
                    sqlWhere += " AND EOS='" & sql & "'"
            End Select
        End If
        'Filtra Hora
        If Me.cbIntervalo.Text.Substring(0, 2) <> "24" Then
            If Me.cbIntervalo.Text.Substring(0, 2) <> "PM" Then
                sqlWhere += " AND HORA=" & Val(Me.cbIntervalo.Text)
            Else
                Dim hi, hf As Integer
                hi = Me.cbIntervalo.Text.Substring(Me.cbIntervalo.Text.IndexOf("(") + 1, 2)
                hf = Me.cbIntervalo.Text.Substring(Me.cbIntervalo.Text.IndexOf(")") - 2, 2)
                sqlWhere += " AND HORA >= " & hi & " AND HORA < " & hf
            End If
        End If

        sql = sqlSelect & " FROM " & Me.cbHistorico.Text & sqlWhere & sqlGroupBy


        Try
            '---abre a Conn---
            conn.Open()

            dt = MySQL_Select(Conn, sql)
            dGridDDX.DataSource = dt.DefaultView

            With dGridDDX
                .Font = New Font("Tahoma", 7.0!, FontStyle.Regular)
                For c = 0 To .Columns.Count - 1
                    .Columns(c).Width = 40
                    .Columns(c).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                Next
                .Columns(0).Width = 45
            End With

        Catch ex As Exception
            ProcessoFim()
            MsgBox(ex.Message)
        Finally
            'If Not GraficoGerado Then AtualizaGrafico()
            GradePreenchida = True
            ProcessoFim()
        End Try
    End Sub
    Private Sub AtualizaGrafico1(ByVal ci As Integer, ByVal cf As Integer, ByVal TipoGrafico As SeriesChartType)
        Dim c, r, d, cnt As Integer
        Dim s As String
        Dim cores(12) As Color

        Try
            cores(1) = Color.Brown
            cores(2) = Color.Red
            cores(3) = Color.DarkRed
            cores(4) = Color.Purple
            cores(5) = Color.Magenta
            cores(6) = Color.Aqua
            cores(7) = Color.Blue
            cores(8) = Color.DarkBlue
            cores(9) = Color.Green
            cores(10) = Color.DarkGreen
            cores(11) = Color.Yellow

            Chart1.ChartAreas("Chart Area 1").Visible = True
            Chart1.Annotations.Clear()
            cnt = 0
            For c = ci To cf
                s = dGridDDX.Columns(c).Name
                ' for each Col, add a new series
                Chart1.Series.Add(s)
                Chart1.Series(s).Type = TipoGrafico
                ' Attach the second series to a chart area.
                Chart1.Series(s).ChartArea = "Chart Area 1"
                Me.Chart1.Series(s).FontAngle = 45
                Chart1.Series(s).Color = Color.FromArgb(110, 0, 145, 185)

                If Me.cbIndGraf1.Text = "Tudo_ch" Or Me.cbIndGraf1.Text = "Tudo_%" Then
                    Chart1.Series(s).Color = cores(c - ci + 1)
                    ' Set Cylinder drawing style
                    Chart1.Series(s)("DrawingStyle") = "Cylinder"
                    ' Set Rotation angles
                    Chart1.ChartAreas("Chart Area 1").Area3DStyle.YAngle = 6
                    Chart1.ChartAreas("Chart Area 1").Area3DStyle.XAngle = 4
                    ' Set Bar chart type
                    Chart1.Series(dGridDDX.Columns(c).Name).Type = SeriesChartType.StackedColumn
                    ' Enable 3D charts
                    Chart1.ChartAreas("Chart Area 1").Area3DStyle.Enable3D = True
                    Me.chbValores.Checked = False
                    Me.chbEventos.Checked = False
                Else
                    If Me.cbIndGraf2.Text <> "Tudo_ch" And Me.cbIndGraf2.Text <> "Tudo_%" Then
                        Me.chbValores.Checked = True
                        Me.chbEventos.Checked = True
                    End If
                    ' Set Y axis labels format
                    Chart1.ChartAreas("Chart Area 1").AxisY.LabelStyle.Format = "d"
                    Me.Chart1.Series(s).BorderColor = Color.DarkOliveGreen
                    Me.Chart1.Series(s).BorderWidth = 1
                    Chart1.Series(s).Color = Color.FromArgb(120, 0, 155, 155)
                    Chart1.ChartAreas("Chart Area 1").Area3DStyle.Enable3D = False
                End If
                Me.Chart1.Series(s).ShowLabelAsValue = Me.chbValores.Checked

                For r = 0 To dGridDDX.Rows.Count - 1
                    ' for each row (column 1 and onward), add the value as a point
                    Chart1.Series(s).Points.AddXY(dGridDDX.Item(0, r).Value, _
                           dGridDDX.Item(c, r).Value)
                    Select Case dGridDDX.Columns(0).Name.ToString
                        Case "DIA"
                            d = Me.dGridDDX.Item(0, r).Value.ToString.Substring(0, 2)
                            If mEventos(d) <> "" Then
                                ' Create a callout annotation
                                Dim Ocorrencia As New CalloutAnnotation()
                                ' Setup visual attributes
                                Ocorrencia.AnchorDataPoint = Chart1.Series(s).Points(r)
                                Ocorrencia.Text = mTipos(d)
                                Ocorrencia.BackColor = Color.FromArgb(120, 255, 255, 128)
                                Ocorrencia.ClipToChartArea = "Chart Area 1"
                                Ocorrencia.ToolTip = mEventos(d)
                                ' Prevent moving or selecting
                                Ocorrencia.AllowMoving = True
                                Ocorrencia.AllowAnchorMoving = False
                                Ocorrencia.AllowSelecting = False

                                'Ocorrencia.AnchorY = Chart1.ChartAreas("Chart Area 1").AxisY.Maximum
                                ' Add the annotation to the collection
                                Chart1.Annotations.Add(Ocorrencia)
                                Me.Chart1.Annotations(cnt).Visible = Me.chbEventos.Checked
                                cnt += 1
                            End If
                        Case "HORA"
                            d = Me.dGridDDX.Item(0, r).Value
                            If mEventos(d) <> "" Then
                                ' Create a callout annotation
                                Dim Ocorrencia As New CalloutAnnotation()
                                ' Setup visual attributes
                                Ocorrencia.AnchorDataPoint = Chart1.Series(s).Points(r)
                                Ocorrencia.Text = mTipos(d)
                                Ocorrencia.BackColor = Color.FromArgb(120, 255, 255, 128)
                                Ocorrencia.ClipToChartArea = "Chart Area 1"
                                Ocorrencia.ToolTip = mEventos(d)
                                ' Prevent moving or selecting
                                Ocorrencia.AllowMoving = True
                                Ocorrencia.AllowAnchorMoving = False
                                Ocorrencia.AllowSelecting = False
                                'Ocorrencia.AnchorY = 2
                                ' Add the annotation to the collection
                                Chart1.Annotations.Add(Ocorrencia)
                                Me.Chart1.Annotations(cnt).Visible = Me.chbEventos.Checked
                                cnt += 1
                            End If
                    End Select
                Next r
                If dGridDDX.Columns(c).Name.Contains("%") Then
                    Me.Chart1.Series(s).LabelFormat = "p1"
                    Me.Chart1.ChartAreas("Chart Area 1").AxisY.Title = "porcentual"
                Else
                    Me.Chart1.Series(s).LabelFormat = "d"
                    Me.Chart1.ChartAreas("Chart Area 1").AxisY.Title = "chamada"
                End If
            Next c
            Me.Chart1.ChartAreas("Chart Area 1").AxisY.StartFromZero = False
            Me.Chart1.ChartAreas("Chart Area 1").AxisX.Margin = False
            Me.Chart1.ChartAreas("Chart Area 1").AxisX.LabelStyle.Format = "d"
            Me.Chart1.ChartAreas("Chart Area 1").AxisX.LabelStyle.Font = New Font("Tahoma", 8.0!, FontStyle.Regular)
            ' Set Grid lines and tick marks interval
            Chart1.ChartAreas("Chart Area 1").AxisX.MajorGrid.Interval = 1
            Chart1.ChartAreas("Chart Area 1").AxisX.MajorTickMark.Interval = 1
            Chart1.ChartAreas("Chart Area 1").AxisX.MinorGrid.Interval = 1
            Chart1.ChartAreas("Chart Area 1").AxisX.MinorTickMark.Interval = 1
            ' Set Line Color
            Chart1.ChartAreas("Chart Area 1").AxisX.MinorGrid.LineColor = Color.Blue
            ' Set axis labels angle
            Chart1.ChartAreas("Chart Area 1").AxisX.LabelStyle.FontAngle = 60
            ' Set axis labels angle
            Chart1.ChartAreas("Chart Area 1").AxisX.LabelStyle.Interval = 1

            Chart1.Visible = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub AtualizaGrafico2(ByVal ci As Integer, ByVal cf As Integer, ByVal TipoGrafico As SeriesChartType)
        Dim c, r As Integer
        Dim s As String
        Dim cores(12) As Color

        Try
            cores(1) = Color.Brown
            cores(2) = Color.Red
            cores(3) = Color.DarkRed
            cores(4) = Color.Purple
            cores(5) = Color.Magenta
            cores(6) = Color.Aqua
            cores(7) = Color.Blue
            cores(8) = Color.DarkBlue
            cores(9) = Color.Green
            cores(10) = Color.DarkGreen
            cores(11) = Color.Yellow

            Chart1.ChartAreas("Chart Area 2").Visible = True
            For c = ci To cf
                s = dGridDDX.Columns(c).Name
                ' for each Col, add a new series
                Chart1.Series.Add(s)
                Chart1.Series(s).Type = TipoGrafico
                ' Attach the second series to a chart area.
                Chart1.Series(s).ChartArea = "Chart Area 2"
                Me.Chart1.Series(s).FontAngle = 45

                If Me.cbIndGraf2.Text = "Tudo_ch" Or Me.cbIndGraf2.Text = "Tudo_%" Then
                    Chart1.Series(s).Color = cores(c - ci + 1)
                    ' Set Cylinder drawing style
                    Chart1.Series(s)("DrawingStyle") = "Cylinder"
                    ' Set Rotation angles
                    Chart1.ChartAreas("Chart Area 2").Area3DStyle.YAngle = 6
                    Chart1.ChartAreas("Chart Area 2").Area3DStyle.XAngle = 4
                    ' Set Bar chart type
                    Chart1.Series(s).Type = SeriesChartType.StackedColumn
                    ' Enable 3D charts
                    Chart1.ChartAreas("Chart Area 2").Area3DStyle.Enable3D = True
                    Me.chbValores.Checked = False
                    Me.chbEventos.Checked = False
                Else
                    If Me.cbIndGraf1.Text <> "Tudo_ch" And Me.cbIndGraf1.Text <> "Tudo_%" Then
                        Me.chbValores.Checked = True
                        Me.chbEventos.Checked = True
                    End If

                    Me.Chart1.Series(s).BorderColor = Color.DarkOliveGreen
                    Me.Chart1.Series(s).BorderWidth = 2
                    Chart1.Series(s).Color = Color.FromArgb(120, 0, 155, 155)
                    Chart1.ChartAreas("Chart Area 2").Area3DStyle.Enable3D = False
                End If

                Me.Chart1.Series(s).ShowLabelAsValue = Me.chbValores.Checked

                For r = 0 To dGridDDX.Rows.Count - 1
                    ' for each row (column 1 and onward), add the value as a point
                    Chart1.Series(dGridDDX.Columns(c).Name).Points.AddXY(dGridDDX.Item(0, r).Value, _
                           dGridDDX.Item(c, r).Value)
                Next r
                If dGridDDX.Columns(c).Name.Contains("%") Then
                    Me.Chart1.Series(dGridDDX.Columns(c).Name).LabelFormat = "p1"
                    Me.Chart1.ChartAreas("Chart Area 2").AxisY.Title = "porcentual"
                Else
                    Me.Chart1.Series(dGridDDX.Columns(c).Name).LabelFormat = "d"
                    Me.Chart1.ChartAreas("Chart Area 2").AxisY.Title = "chamada"
                End If
            Next c
            Me.Chart1.ChartAreas("Chart Area 2").AxisY.StartFromZero = False
            Me.Chart1.ChartAreas("Chart Area 2").AxisX.Margin = False
            Me.Chart1.ChartAreas("Chart Area 2").AxisX.LabelStyle.Format = "d"
            Me.Chart1.ChartAreas("Chart Area 2").AxisX.LabelStyle.Font = New Font("Tahoma", 8.0!, FontStyle.Regular)
            ' Set Grid lines and tick marks interval
            Chart1.ChartAreas("Chart Area 2").AxisX.MajorGrid.Interval = 1
            Chart1.ChartAreas("Chart Area 2").AxisX.MajorTickMark.Interval = 1
            Chart1.ChartAreas("Chart Area 2").AxisX.MinorGrid.Interval = 1
            Chart1.ChartAreas("Chart Area 2").AxisX.MinorTickMark.Interval = 1
            ' Set Line Color
            Chart1.ChartAreas("Chart Area 2").AxisX.MinorGrid.LineColor = Color.Blue
            ' Set axis labels angle
            Chart1.ChartAreas("Chart Area 2").AxisX.LabelStyle.FontAngle = 60
            ' Set axis labels angle
            Chart1.ChartAreas("Chart Area 2").AxisX.LabelStyle.Interval = 1

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AtualizaGrafico()
        If Not GradePreenchida Then Exit Sub
        If Me.cbGrupo.Text = "" Then Me.cbGrupo.Text = "Tudo"

        ProcessoInicio(" gerando   gráfico  ")

        ' Remove all series
        Chart1.Series.Clear()

        'Me.Chart1.Legends("Default").BackColor = Color.FromArgb(120, 0, 200, 255)

        Me.Chart1.Legends("Default").Enabled = False
        If Me.cbIndGraf1.Text = "Tudo_ch" Then
            AtualizaGrafico1(2, 12, SeriesChartType.StackedColumn)
            Me.Chart1.Legends("Default").Enabled = True
        ElseIf Me.cbIndGraf1.Text = "Tudo_%" Then
            AtualizaGrafico1(16, 26, SeriesChartType.StackedColumn)
            Me.Chart1.Legends("Default").Enabled = True
        Else
            AtualizaGrafico1(Me.cbIndGraf1.SelectedIndex + 1, Me.cbIndGraf1.SelectedIndex + 1, SeriesChartType.SplineArea)
        End If

        If Me.cbIndGraf2.Text = "Tudo_ch" Then
            AtualizaGrafico2(2, 12, SeriesChartType.StackedColumn)
            Me.Chart1.Legends("Default").Enabled = True
        ElseIf Me.cbIndGraf2.Text = "Tudo_%" Then
            AtualizaGrafico2(16, 26, SeriesChartType.StackedColumn)
            Me.Chart1.Legends("Default").Enabled = True
        Else
            AtualizaGrafico2(Me.cbIndGraf2.SelectedIndex + 1, Me.cbIndGraf2.SelectedIndex + 1, SeriesChartType.SplineArea)
        End If

        ' Enable SmartLabels for all Annotation objects
        ' Hide all Annotation objects that cannot be repositioned 
        Dim annotation As Annotation
        For Each annotation In Chart1.Annotations
            annotation.SmartLabels.Enabled = True
            annotation.SmartLabels.HideOverlapped = True
        Next annotation

        ' Make Chart Area 2 align to Chart Area 1
        Chart1.ChartAreas("Chart Area 2").AlignWithChartArea = "Chart Area 1"
        Me.Chart1.Legends(0).Font = New Font("Tahoma", 8.0!, FontStyle.Regular)
        Me.Chart1.ChartAreas("Chart Area 2").AxisX.LabelStyle.Enabled = False
        Me.Chart1.ChartAreas("Chart Area 2").AxisX.Title = dGridDDX.Columns(0).Name

        Me.Chart1.ChartAreas("Chart Area 1").ReCalc()
        Me.Chart1.ChartAreas("Chart Area 2").ReCalc()
        GraficoGerado = True
        ProcessoFim()

    End Sub

    Private Sub TreeView1_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs)
        Chart1.Visible = False
        Me.lblData.Text = "Universo: " & e.Node.FullPath
        'PreencheGrid()
        'AtualizaGrafico()
    End Sub

    Private Sub cbRota_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not GradePreenchida Then
            PreencheGrid()
            Me.TreeView1.Select()
        End If
    End Sub

    Private Sub chbValores_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not GradePreenchida Then
            PreencheGrid()
            Me.TreeView1.Select()
        End If
    End Sub

    Private Sub cbHistorico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbHistorico.SelectedIndexChanged
        If Me.cbHistorico.Text = "X_EOS" And frmManutencao.cbTipoCentral.Text = "N" Then
            MsgBox("O Histórico X_EOS Não está dosponível para centrais NEC.", MsgBoxStyle.Critical)
            Me.cbHistorico.Text = "X_Grupo"
            Exit Sub
        End If
        Chart1.Visible = False
        CarregaGrupo()
        'CarregaArvore()
        cbGrupo.Text = "Tudo"
        'PreencheGrid()
        'AtualizaGrafico()
    End Sub

    Private Sub Chart1_GetToolTipText(ByVal sender As System.Object, ByVal e As Dundas.Charting.WinControl.ToolTipEventArgs)
        ' Check selected chart element and set tooltip text
        Select Case e.HitTestResult.ChartElementType
            Case ChartElementType.DataPoint
                Dim i As Integer
                i = e.HitTestResult.PointIndex + Me.dGridDDX.Item(0, 0).Value.ToString.Substring(0, 2) - 1
                If mEventos(i) = "" Then
                    e.Text = ""
                Else
                    e.Text = "Evento: " & mEventos(i).ToString
                End If
        End Select

    End Sub

    Private Sub chbValores_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbValores.CheckedChanged
        Dim i As Integer

        For i = 0 To Me.Chart1.Series.Count - 1
            Me.Chart1.Series(i).ShowLabelAsValue = Me.chbValores.Checked
        Next
    End Sub
    Private Sub cbIntervalo_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIntervalo.SelectedIndexChanged
        'PreencheGrid()
        'AtualizaGrafico()
        Chart1.Visible = False
    End Sub

    Private Sub cbGrupo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbGrupo.SelectedIndexChanged
        'PreencheGrid()
        'AtualizaGrafico()
        Chart1.Visible = False
    End Sub

    Private Sub chbEventos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbEventos.CheckedChanged
        Dim i As Integer

        For i = 0 To Me.Chart1.Annotations.Count - 1
            Me.Chart1.Annotations(i).Visible = Me.chbEventos.Checked
        Next
    End Sub
    Private Sub cbIndGraf1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIndGraf1.SelectedIndexChanged
        Dim c As Integer
        If (cbIndGraf1.Items(cbIndGraf1.SelectedIndex).ToString = "Tudo_ch" And _
            "CO0_ch,CO1_ch,CO2_ch,CO3_ch,DSC_ch,LO_ch,NR1_ch,NR5_ch,OK1_ch,OK5_ch,OU_ch".Contains(cbIndGraf2.Text)) Or _
           (cbIndGraf1.Items(cbIndGraf1.SelectedIndex).ToString = "Tudo_%" And _
            "CO0_%,CO1_%,CO2_%,CO3_%,DSC_%,LO_%,NR1_%,NR5_%,OK1_%,OK5_%,OU_%".Contains(cbIndGraf2.Text)) Then
            MsgBox("Você Não pode escolher este indicador porque ele está presente no outro gráfico.")
            Me.cbIndGraf1.SelectedIndex = Graf1Escolhido
            Exit Sub
        End If

        For c = 0 To Me.Chart1.Series.Count - 1
            If Chart1.Series(c).ChartArea = "Chart Area 2" Then
                If cbIndGraf1.Items(cbIndGraf1.SelectedIndex).ToString = Me.Chart1.Series(c).Name.ToString Then
                    MsgBox("Você Não pode escolher este indicador porque ele está presente no outro gráfico.")
                    Me.cbIndGraf1.SelectedIndex = Graf1Escolhido
                    Exit Sub
                End If
            End If
        Next c
        AtualizaGrafico()
        Graf1Escolhido = Me.cbIndGraf1.SelectedIndex

    End Sub
    Private Sub cbIndGraf2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbIndGraf2.SelectedIndexChanged
        Dim c As Integer
        If (cbIndGraf2.Items(cbIndGraf2.SelectedIndex).ToString = "Tudo_ch" And _
            "CO0_ch,CO1_ch,CO2_ch,CO3_ch,DSC_ch,LO_ch,NR1_ch,NR5_ch,OK1_ch,OK5_ch,OU_ch".Contains(cbIndGraf1.Text)) Or _
           (cbIndGraf2.Items(cbIndGraf2.SelectedIndex).ToString = "Tudo_%" And _
            "CO0_%,CO1_%,CO2_%,CO3_%,DSC_%,LO_%,NR1_%,NR5_%,OK1_%,OK5_%,OU_%".Contains(cbIndGraf1.Text)) Then
            MsgBox("Você Não pode escolher este indicador porque ele está presente no outro gráfico.")
            Me.cbIndGraf2.SelectedIndex = Graf2Escolhido
            Exit Sub
        End If

        For c = 0 To Me.Chart1.Series.Count - 1
            If Chart1.Series(c).ChartArea = "Chart Area 1" Then
                If cbIndGraf1.Items(cbIndGraf2.SelectedIndex).ToString = Me.Chart1.Series(c).Name.ToString Then
                    MsgBox("Você Não pode escolher este indicador porque ele está presente no outro gráfico.")
                    Me.cbIndGraf2.SelectedIndex = Graf2Escolhido
                    Exit Sub
                End If
            End If
        Next c
        AtualizaGrafico()
        Graf2Escolhido = Me.cbIndGraf2.SelectedIndex

    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        Me.Text = "Histórico - " & frmManutencao.cbBilhetador.Text
        If cbHistorico.Text = "" Then
            MsgBox("Selecione um histórico primeiro.")
            Exit Sub
        End If
        Graf1Escolhido = Me.cbIndGraf1.SelectedIndex
        Graf2Escolhido = Me.cbIndGraf2.SelectedIndex
        GradePreenchida = False
        GraficoGerado = False
        PreencheGrid()
        AtualizaGrafico()
    End Sub

    Private Sub frmHistorico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Histórico - " & frmManutencao.cbBilhetador.Text

        mcaData.DisplayMonth = Today()

        Graf1Escolhido = Me.cbIndGraf1.SelectedIndex
        Graf2Escolhido = Me.cbIndGraf2.SelectedIndex
        ArvoreCarregada = False
        GradePreenchida = False
        GraficoGerado = False
        'Me.cbGrupo.Text = "Tudo"
        'mcaData.MinDate = CDate("01/01/2007")
        dtpDataInicial.Value = Now.Date.AddDays(-(Now.Day - 1))
        mcaData.SelectionEnd = Now.Date
        mcaData.SelectionStart = dtpDataInicial.Value
        mcaData.SelectionEnd = dtpDataFinal.Value
        mcaData.MaxDate = dtpDataFinal.Value

        'CarregaArvore()
        CarregaGrupo()
        'btnAtualizar_Click(sender, e)
        flCarga = True
    End Sub

    Private Sub frmHistorico_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Dim mUniverso() As String
        'TreeView1.Nodes(0).Expand()
        If Me.cbGrupo.Text <> "" Then
            If Me.cbGrupo.Text.Substring(0, 1) = "=" Then
                Me.cbGrupo.Text = Me.cbGrupo.Text.Substring(2, Me.cbGrupo.Text.Length - 2)
                mUniverso = TreeSelect.Split("\")
                SelecionaNo(mUniverso)
                btnAtualizar_Click(sender, e)
            Else
                TreeSelect = Year(Now).ToString & "\" & Month(Now).ToString
                mUniverso = TreeSelect.Split("\")
                SelecionaNo(mUniverso)
                'If flCarga Then btnAtualizar_Click(sender, e)
                'Me.cbGrupo.SelectedIndex = 0 'Todos
            End If
        End If
        flCarga = False
    End Sub

    Private Sub SelecionaNo(ByVal mUniverso() As String)
        Dim a, m, d As Integer

        If TreeView1.Nodes.Count < 1 Or mUniverso.Length < 1 Then Exit Sub
        For a = 0 To TreeView1.Nodes.Count - 1
            If TreeView1.Nodes(a).Tag = mUniverso(0) Then
                If mUniverso.Length > 1 Then 'Tem mes
                    For m = 0 To TreeView1.Nodes(a).Nodes.Count - 1
                        If TreeView1.Nodes(a).Nodes(m).Tag = mUniverso(1) Then
                            If mUniverso.Length > 2 Then 'Tem dia
                                For d = 0 To TreeView1.Nodes(a).Nodes(m).Nodes.Count - 1
                                    If TreeView1.Nodes(a).Nodes(m).Nodes(d).Tag = mUniverso(2) Then
                                        TreeView1.SelectedNode = TreeView1.Nodes(a).Nodes(m).Nodes(d)
                                    End If
                                Next
                            Else
                                TreeView1.Nodes(a).Nodes(m).ExpandAll()
                                TreeView1.SelectedNode = TreeView1.Nodes(a).Nodes(m)
                                Exit Sub
                            End If
                        End If
                    Next m
                Else
                    'TreeView1.Nodes(a).ExpandAll()
                    TreeView1.SelectedNode = TreeView1.Nodes(a)
                End If
            End If
        Next a
        TreeView1.Select()

    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        ProcessoInicio("Exportando para o Excel")
        ExportToExcel(dGridDDX, xlsOption.xlsOpen)
        ProcessoFim()
    End Sub

    Private Sub dtpDataInicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDataInicial.ValueChanged
        Chart1.Visible = False
        mcaData.SelectionStart = dtpDataInicial.Value
    End Sub

    Private Sub dtpDataFinal_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDataFinal.ValueChanged
        Chart1.Visible = False
        mcaData.SelectionEnd = dtpDataFinal.Value
    End Sub

    Private Sub mcaData_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles mcaData.DateSelected
        If mcaData.SelectionStart < dtpDataInicial.MinDate Then Exit Sub
        Chart1.Visible = False
        dtpDataInicial.Value = mcaData.SelectionStart
        dtpDataFinal.Value = mcaData.SelectionEnd
    End Sub

    Private Sub tcArvore_SelectedTabChanged(ByVal sender As System.Object, ByVal e As DevComponents.DotNetBar.TabStripTabChangedEventArgs) Handles tcArvore.SelectedTabChanged
        Chart1.Visible = False
        If tcArvore.SelectedTabIndex = 1 And (Not ArvoreCarregada) Then
            CarregaArvore()
        End If
    End Sub
End Class