Imports Dundas.Charting.WinControl
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class frmGeraHistorico
    Dim dt As DataTable

    Dim IndicadorNome() As String = {"CO0", "CO1", "CO2", "CO3", "DSC", "LO", "NR1", "NR5", "OK1", "OK5", "OU"}

    Dim SQL As String
    Dim formatado As Boolean 'indica se ja formatou o grid alguma vez

    'define o dataset
    Dim ds As DataSet = New DataSet()
    Private Sub btnProcessar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcessar.Click
        Dim d, df As Date

        d = Me.DateTimePickerI.Text
        df = Me.DateTimePickerF.Text

        If d > df Then
            MsgBox("Data Final > Data Inicial!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        While d <= df
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If Me.ckbX_Rota_Entrada.Checked Then
                Gera_X_rota_entrada(Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            If Me.ckbX_Rota_Saida.Checked Then
                Gera_X_rota_saida(Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            If Me.ckbX_Cliente_Originado.Checked Then
                Gera_X_Cliente_Originado(Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            If Me.ckbX_Cliente_Destinado.Checked Then
                Gera_X_Cliente_Destinado(Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            If Me.ckbX_Grupo.Checked Then
                Gera_X_Grupo(Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            If Me.ckbX_ASS_A.Checked Then
                Gera_X_ASS_A(Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            If Me.ckbX_ASS_B.Checked Then
                Gera_X_ASS_B(Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            If Me.ckbX_EOS.Checked Then
                Gera_X_EOS(Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If
            If Me.ckbX_PPI.Checked Then
                Gera_X_PPI(Format(d, "yyyy-MM-dd"))
                RefreshList()
            End If

            d = d.AddDays(1)
        End While

        Me.Cursor = System.Windows.Forms.Cursors.Default
        MsgBox("Concluído [Gerar o Processamento],")
    End Sub

    Private Sub frmGeraHistorico_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Text = "Gera Histórico - " & frmManutencao.cbBilhetador.Text
        RefreshList()
    End Sub

    Private Sub frmGeraHistorico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If frmManutencao.cbTipoCentral.Text = "N" Then
            ckbX_EOS.Checked = False
            ckbX_EOS.Enabled = False
        End If
        'Open Conn
        'Conn = MySQL_Conn(frmManutencao.cbServidorMySql.Text, frmManutencao.txtBancoMySql.Text, frmManutencao.cbUsuarioMySql.Text, frmManutencao.cbSenhaMySql.Text)

        Dim i As Integer
        Dim data As Date
        data = Now()
        Me.cbFiltro.Text = Format(data, "yyyy-MM-dd")
        Me.cbFiltro.Items.Add("Não Filtrado")
        For i = 1 To 15
            Me.cbFiltro.Items.Add(Format(data, "yyyy-MM-dd"))
            data = Now.AddDays(-i)
        Next i

        'Reload listview
        dt = MySQL_Select(Conn, "SELECT * FROM LogAtividade ORDER BY DATA DESC")
        'Me.RefreshList()

    End Sub
    Private Sub RefreshList()

        'Reload listview
        If Me.cbFiltro.Text.Substring(0, 3) = "Não" Then
            dt = MySQL_Select(Conn, "SELECT * FROM LogAtividade ORDER BY DATA DESC")
        Else
            dt = MySQL_Select(Conn, "SELECT * FROM LogAtividade WHERE date(DATA)='" & Me.cbFiltro.Text & "' ORDER BY DATA DESC")
        End If

        If Not (dt.Rows.Count > 0) Then
            Me.lvLogAtividade.Items.Clear()
            Exit Sub
        End If

        Dim LviItem As ListViewItem
        Dim LsiSubItem As ListViewItem.ListViewSubItem

        Me.lvLogAtividade.Items.Clear()

        lvLogAtividade.FullRowSelect = True
        lvLogAtividade.View = View.Details
        If lvLogAtividade.Columns.Count <= 0 Then
            lvLogAtividade.Columns.Add("DATA", 150, HorizontalAlignment.Left)
            lvLogAtividade.Columns.Add("GRUPO", 120, HorizontalAlignment.Left)
            lvLogAtividade.Columns.Add("DETALHE", 450, HorizontalAlignment.Left)
        End If

        lvLogAtividade.BeginUpdate()

        If (dt.Rows.Count > 0) Then
            For Each dr As DataRow In dt.Rows
                LviItem = lvLogAtividade.Items.Add(dr("DATA").ToString)
                LsiSubItem = LviItem.SubItems.Add(dr("GRUPO").ToString)
                LsiSubItem = LviItem.SubItems.Add(dr("DETALHE").ToString)
            Next
            lvLogAtividade.EndUpdate()
        End If
    End Sub

    Private Sub cbFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFiltro.SelectedIndexChanged
        RefreshList()
    End Sub

    Private Sub btnDesmarcarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDesmarcarTodos.Click
        ckbX_Rota_Entrada.Checked = False
        ckbX_Rota_Saida.Checked = False
        ckbX_Cliente_Originado.Checked = False
        ckbX_Cliente_Destinado.Checked = False
        ckbX_Grupo.Checked = False
        ckbX_EOS.Checked = False
        ckbX_ASS_A.Checked = False
        ckbX_ASS_B.Checked = False
        ckbX_PPI.Checked = False
    End Sub

    Private Sub btnMarcaTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcaTodos.Click
        ckbX_Rota_Entrada.Checked = True
        ckbX_Rota_Saida.Checked = True
        ckbX_Cliente_Originado.Checked = True
        ckbX_Cliente_Destinado.Checked = True
        ckbX_Grupo.Checked = True
        ckbX_EOS.Checked = True
        ckbX_ASS_A.Checked = True
        ckbX_ASS_B.Checked = True
        ckbX_PPI.Checked = True

    End Sub

    Private Sub btnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravar.Click
        frmManutencao.gravaArquivoini()
        MsgBox("Arquivo de Configuração Gravado.")
    End Sub
End Class