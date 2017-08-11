Imports System.Deployment.Application
Imports System.Collections.Specialized
Imports System.Web
Public Class frmPrincipal1
    Public Sub ProcessoInicio()
        rtbNovidades.Visible = False
        txtMensagemPrincipal.Visible = False
        lblTitulo.Visible = False
        lnkNovidades.Visible = False
        lblUltimoTTFILE.Visible = False
        Me.Text = "SpyCdr - Investigador de CDR"

        Me.ToolStripStatusAguarde.Visible = True
        Me.StatusStrip1.Refresh()
        Cursor = Cursors.WaitCursor
    End Sub

    Public Sub ProcessoFim()
        Me.ToolStripStatusAguarde.Visible = False
        Me.StatusStrip1.Refresh()
        Cursor = Cursors.Default
    End Sub

    Private Sub PesquisaCDRToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PesquisaCDRToolStripMenuItem.Click
        ProcessoInicio()
        My.Settings.strSQL = Nothing
        Select Case frmManutencao.cbTipoCentral.Text
            Case "E"
                frmListaCdrs.statusTabela.Text = "cdrs_" & Format(Now, "yyyyMMdd")
                frmListaCdrs.MdiParent = Me
                frmListaCdrs.Show()
                frmListaCdrs.Activate()
            Case "H"
                'frmListaCDRs_H.DateTimePicker1.Value = Now
                frmListaCDRs_H.MdiParent = Me
                frmListaCDRs_H.Show()
                frmListaCDRs_H.Activate()
            Case "N"
                frmListaCdrs_N.statusTabela.Text = "cdrs_" & Format(Now, "yyyyMMdd")
                frmListaCdrs_N.MdiParent = Me
                My.Forms.frmListaCdrs_N.Show()
                frmListaCdrs_N.Activate()
        End Select
        ProcessoFim()
        'My.Forms.frmListaCdrs.MdiParent = Me
        'My.Forms.frmListaCdrs.Show()
        'My.Forms.frmListaCdrs.Activate()
    End Sub
    Private Sub MaioresOfensoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoricoToolStripMenuItem.Click
        ProcessoInicio()
        My.Forms.frmResumo.MdiParent = Me
        My.Forms.frmResumo.Show()
        My.Forms.frmResumo.Activate()
        ProcessoFim()
    End Sub

    Private Sub frmPrincipal_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated

        If Me.MdiChildren.GetUpperBound(0) <> -1 Or lblTitulo.Visible Then Exit Sub

        If My.Settings.Param1 <> "" Then
            Me.Text = "SpyCdr-Investigador de CDR (" & My.Settings.Param1 & ") [" & frmManutencao.cbBilhetador.Text & "]"
        Else
            Me.Text = "SpyCdr-Investigador de CDR [" & frmManutencao.cbBilhetador.Text & "]"
        End If
        'rtbNovidades.Visible = True
        txtMensagemPrincipal.Visible = True
        lblTitulo.Visible = True
        lnkNovidades.Visible = True
        lblUltimoTTFILE.Visible = True
        Me.Refresh()
        lblUltimoTTFILE.Refresh()
    End Sub
    Private Sub frmPrincipal_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        SplashSpyCdr.Dispose()
    End Sub

    Private Function GetQueryStringParameters() As NameValueCollection
        Dim NameValueTable As New NameValueCollection()

        Dim QueryString As String = ApplicationDeployment.CurrentDeployment.ActivationUri.Query
        NameValueTable = HttpUtility.ParseQueryString(QueryString)

        GetQueryStringParameters = NameValueTable
    End Function

    Private Sub frmPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.NotifyIcon1.Visible = False

        frmManutencao.CarregaINI("")

        Conn = MySQL_Conn()

        My.Settings.Param1 = ""
        My.Settings.Param2 = ""
        'Se estiver executando do servidor
        Try
            If System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed Then
                My.Settings.Param1 = GetQueryStringParameters().Item("Param1").ToUpper
                My.Settings.Param2 = GetQueryStringParameters().Item("Param2").ToUpper
            Else
                If My.Application.CommandLineArgs.Count > 0 Then
                    My.Settings.Param1 = My.Application.CommandLineArgs(0).ToString.ToUpper
                    If My.Application.CommandLineArgs.Count > 1 Then My.Settings.Param2 = My.Application.CommandLineArgs(1).ToString.ToUpper
                End If
            End If
        Catch ex As Exception
        End Try

        If My.Settings.Param1 <> "" Then
            SplashSpyCdr.WindowState = FormWindowState.Minimized
            Me.NotifyIcon1.Visible = True
            'Hide()
            Me.Text &= " (" & My.Settings.Param1 & ") [" & frmManutencao.cbBilhetador.Text & "]"
        Else
            Me.Text &= " [" & frmManutencao.cbBilhetador.Text & "]"
        End If
        'StatusStrip1.Items(0).Text = "SpyCdr"

        If My.Settings.Param1 = "EXROP" Then
            rtbNovidades.Visible = False
            txtMensagemPrincipal.Visible = False
            lblTitulo.Visible = False
            lnkNovidades.Visible = False
            lblUltimoTTFILE.Visible = False
            My.Forms.frmDumpShadow.MdiParent = Me
            My.Forms.frmDumpShadow.Show()
            My.Forms.frmDumpShadow.Activate()
        End If

        If My.Settings.Param1 = "GERADDX" Then
            Dim Data As Date
            If My.Settings.Param2 <> "" Then
                Data = Now().AddDays(-My.Settings.Param2)
            Else
                Data = Now()
            End If
            If frmGeraHistorico.ckbX_Rota_Entrada.Checked Then
                StatusStrip1.Items(0).Text = "Gera_X_rota_entrada"
                Gera_X_rota_entrada(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_Rota_Saida.Checked Then
                StatusStrip1.Items(0).Text = "Gera_X_rota_saida"
                Gera_X_rota_saida(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_Cliente_Originado.Checked Then
                StatusStrip1.Items(0).Text = "Gera_X_Cliente_Originado"
                Gera_X_Cliente_Originado(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_Cliente_Destinado.Checked Then
                StatusStrip1.Items(0).Text = "Gera_X_Cliente_Destinado"
                Gera_X_Cliente_Destinado(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_Grupo.Checked Then
                StatusStrip1.Items(0).Text = "Gera_X_Grupo"
                Gera_X_Grupo(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_ASS_A.Checked Then
                StatusStrip1.Items(0).Text = "Gera_X_ASS_A"
                Gera_X_ASS_A(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_ASS_B.Checked Then
                StatusStrip1.Items(0).Text = "Gera_X_ASS_B"
                Gera_X_ASS_B(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_EOS.Checked Then
                StatusStrip1.Items(0).Text = "Gera_X_EOS"
                Gera_X_EOS(Format(Data, "yyyy-MM-dd"))
            End If
            If frmGeraHistorico.ckbX_EOS.Checked Then
                StatusStrip1.Items(0).Text = "Gera_X_PPI"
                Gera_X_PPI(Format(Data, "yyyy-MM-dd"))
            End If

            Me.Close()
        End If
        Dim dt As New DataTable("log")
        dt = MySQL_Select(Conn, "select TTFILE, DATA_BMP, HORA_BMP from log order BY data_baixa DESC, hora_baixa DESC LIMIT 1")
        If dt.Rows.Count = 1 Then
            lblUltimoTTFILE.Text = dt.Rows(0).Item("TTFILE").ToString & " " _
                                 & Format(dt.Rows(0).Item("DATA_BMP"), "dd/MM/yyyy") & " " _
                                 & dt.Rows(0).Item("HORA_BMP").ToString
        Else
            lblUltimoTTFILE.Text = "..."
        End If
        dt = Nothing
    End Sub

    Private Sub GeraMaioresOfenssoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeraMaioresOfenssoresToolStripMenuItem.Click
        ProcessoInicio()
        My.Forms.frmGeraHistorico.MdiParent = Me
        My.Forms.frmGeraHistorico.Show()
        My.Forms.frmGeraHistorico.Activate()
        ProcessoFim()
    End Sub

    Private Sub DumpShadowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DumpShadowToolStripMenuItem.Click
        ProcessoInicio()
        My.Forms.frmDumpShadow.MdiParent = Me
        My.Forms.frmDumpShadow.Show()
        My.Forms.frmDumpShadow.Activate()
        ProcessoFim()
    End Sub

    Private Sub FtpTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.frmListaCDRs_H.MdiParent = Me
        My.Forms.frmListaCDRs_H.Show()
        My.Forms.frmListaCDRs_H.Activate()
    End Sub

    Public Sub HistóricoEmÁrvoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistóricoEmÁrvoreToolStripMenuItem.Click
        ProcessoInicio()
        My.Forms.frmHistorico.MdiParent = Me
        My.Forms.frmHistorico.Show()
        My.Forms.frmHistorico.Activate()
        ProcessoFim()
    End Sub

    Private Sub ConfiguraçõesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraçõesToolStripMenuItem1.Click
        'Dim iLp As Integer

        'For iLp = 0 To Me.MdiChildren.GetUpperBound(0)
        ' If TypeOf Me.MdiChildren(iLp) Is frmManutencao Then Exit Sub
        ' Next iLp
        ProcessoInicio()
        My.Forms.frmManutencao.MdiParent = Me
        My.Forms.frmManutencao.Show()
        My.Forms.frmManutencao.Activate()
        ProcessoFim()
    End Sub

    Private Sub CadastroDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeClientesToolStripMenuItem.Click
        ProcessoInicio()
        My.Forms.frmClientes.MdiParent = Me
        My.Forms.frmClientes.Show()
        My.Forms.frmClientes.Activate()
        ProcessoFim()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Show()
        WindowState = FormWindowState.Maximized
        Me.NotifyIcon1.Visible = False
    End Sub

    Private Sub ApagaRegistrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApagaRegistrosToolStripMenuItem.Click
        ProcessoInicio()
        My.Forms.frmApagaRegistros.MdiParent = Me
        My.Forms.frmApagaRegistros.Show()
        My.Forms.frmApagaRegistros.Activate()
        ProcessoFim()

    End Sub
    Private Sub SeparaCdrsPorDiaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDeEventosToolStripMenuItem.Click
        ProcessoInicio()
        My.Forms.frmEventos.MdiParent = Me
        My.Forms.frmEventos.Show()
        My.Forms.frmEventos.Activate()
        ProcessoFim()
    End Sub

    Private Sub SobreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreToolStripMenuItem.Click
        My.Forms.frmSobre.ShowDialog()
    End Sub

    Private Sub HorizontalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub VerticalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub CascataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CascataToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub DestinosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DestinosToolStripMenuItem.Click
        ProcessoInicio()
        My.Forms.frmGrupos.MdiParent = Me
        My.Forms.frmGrupos.Show()
        My.Forms.frmGrupos.Activate()
        ProcessoFim()
    End Sub
    Private Sub lnkNovidades_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkNovidades.LinkClicked
        rtbNovidades.Visible = Not rtbNovidades.Visible
    End Sub

    Private Sub CadastroDePPIsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroDePPIsToolStripMenuItem.Click
        ProcessoInicio()
        My.Forms.frmPPIs.MdiParent = Me
        My.Forms.frmPPIs.Show()
        My.Forms.frmPPIs.Activate()
        ProcessoFim()
    End Sub

    Private Sub TráfegoNoPPIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TráfegoNoPPIToolStripMenuItem.Click
        ProcessoInicio()
        My.Forms.frmTrafPPI.MdiParent = Me
        My.Forms.frmTrafPPI.Show()
        My.Forms.frmTrafPPI.Activate()
        ProcessoFim()
    End Sub

    Private Sub TerminaisSemTráfegoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerminaisSemTráfegoToolStripMenuItem.Click
        ProcessoInicio()
        My.Forms.frmTrafPorTerminal.MdiParent = Me
        My.Forms.frmTrafPorTerminal.Show()
        My.Forms.frmTrafPorTerminal.Activate()
        ProcessoFim()
    End Sub

    Private Sub FtpTToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles FtpTToolStripMenuItem.Click

    End Sub
End Class