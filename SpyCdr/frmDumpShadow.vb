Imports System.io
Imports System.Text

Public Class frmDumpShadow
    Dim PaginasBaixadas As Integer

    Private Sub frmDumpShadow_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Text = "Dump Shadow - " & frmManutencao.cbBilhetador.Text
    End Sub

    Private Sub frmDumpShadow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PaginasBaixadas = 0
        Select Case frmManutencao.cbTipoCentral.Text
            Case "E"
                Me.WebBrowser1.Url = New System.Uri(frmManutencao.txtDumpshadowURL.Text & frmManutencao.cbBilDumpShadow.Text & "/", System.UriKind.Absolute)
            Case "H"
                txtURL.Text = "file://" & frmManutencao.txtPastaDeTrabalho.Text & "/LST_TG.txt"
                'WebBrowser1.Url = New System.Uri(txtURL.Text, System.UriKind.Absolute)
                WebBrowser1.Navigate(txtURL.Text)
        End Select

    End Sub
    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Dim url As String
        Dim p As Integer

        PaginasBaixadas += 1
        btnImportar.Enabled = True
        If PaginasBaixadas = 1 Then
            'http://wprjo002/DumpShadow/AJB/EXROP_1308.AJB
            p = InStr(Me.WebBrowser1.Document.Body.InnerHtml, "EXROP")
            If p > 0 Then
                url = Me.WebBrowser1.Url.ToString & Mid(Me.WebBrowser1.Document.Body.InnerHtml.ToString, p, 11 + frmManutencao.cbBilDumpShadow.Text.Length)
                Me.WebBrowser1.Url = New System.Uri(url, System.UriKind.Absolute)
            End If
        End If
        If My.Settings.Param1 = "EXROP" And PaginasBaixadas = 2 Then
            ImportaEXROP(Me.WebBrowser1.Document.Body.OuterText)
        End If

        txtURL.Text = Me.WebBrowser1.Url.ToString
    End Sub

    Private Sub WebBrowser1_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        btnImportar.Enabled = False
    End Sub
    Private Sub ImportaEXROP(ByVal texto As String)
        'Importar a Listagem atualmente carregada
        Dim Linha As String
        Dim P, P1, MargemEsq As Integer
        Dim vDATA, vROTA, vDETY, vDPC, vMA, vR, vR1, vRIN, vDATA_DUMP, vdescFNC As String
        Dim vPRI, vEO, vEC, vFNC, vBO, vCO As Double
        Dim ContReg, ContRegSai As Double
        Dim txtSQL As String
        Dim Descarregar, inicio As Boolean
        'define os objetos connecton, command e dataadapter
        Dim nomeArquivo = frmManutencao.txtPastaDeTrabalho.Text & "\temp.csv"

        Dim registrosAfetados As Integer

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'verifica se o arquivo existe e exclui o arquivo ja existente
        Try
            If File.Exists(nomeArquivo) = True Then
                File.Delete(nomeArquivo)
                'MsgBox("Arquivo " & nomeArquivo & " excluido...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End Try

        Dim strReader As New StringReader(texto)

        Descarregar = False
        ContReg = 0
        vROTA = ""
        vDATA = ""
        vDETY = ""
        vPRI = 0
        vEO = 0
        vEC = 0
        vFNC = 0
        vDPC = ""
        vMA = ""
        vR = ""
        vR1 = ""
        vRIN = 0
        vBO = 0
        vCO = 0
        vdescFNC = ""

        Linha = strReader.ReadLine() 'Le linha
        If Linha Is Nothing Then
            Exit Sub
        End If

        'Apaga registros
        Dim objWriter As New StreamWriter(nomeArquivo, True)

        MySQL_cmd(Conn, "DELETE FROM _exrop WHERE BILHETADOR = '" & frmManutencao.cbBilDumpShadow.Text & "'")

        While True
            If (Linha Is Nothing) Or (Linha.IndexOf("END") = MargemEsq) Then
                Exit While
            Else
                P = InStr(Linha, "$$") 'Linha com data do dump
                If P <> 0 Then
                    vDATA_DUMP = Mid(Trim(Linha), 1, 21)
                End If
                ContReg = ContReg + 1
                P = InStr(Linha, "DETY")
                If P <> 0 Then    ' Nova ROTA
                    If Descarregar Then
                        If inicio Then
                            ContRegSai = ContRegSai + 1
                            txtSQL = frmManutencao.cbBilDumpShadow.Text & "," _
                                    & vROTA & "," _
                                    & vMA & "," _
                                    & Format(Val(vBO), "000") & "," _
                                    & Format(Val(vRIN), "0000") & "," _
                                    & Format(vCO, "000") & "," _
                                    & Format(Val(vEO), "000") & "," _
                                    & vDETY & "," _
                                    & Format(Val(vPRI), "00") & "," _
                                    & Format(Val(vEC), "00") & "," _
                                    & Format(Val(vFNC), "0") & "," _
                                    & vDPC & "," _
                                    & vR & "," _
                                    & vR1 & "," _
                                    & vdescFNC
                            objWriter.WriteLine(txtSQL)
                        End If
                        vROTA = ""
                        vDATA = ""
                        vDETY = ""
                        vPRI = 0
                        vEO = 0
                        vEC = 0
                        vFNC = 0
                        vDPC = ""
                        vMA = ""
                        vR = ""
                        vR1 = ""
                        vRIN = 0
                        vBO = 0
                        vCO = 0
                        vdescFNC = ""
                    End If
                    Descarregar = True
                    vDATA = FormatDateTime(Now(), 2)
                    vROTA = Trim(Mid(Linha, P - 9, 7))
                    vDETY = Trim(Mid(Linha, P + 5, 8))
                End If
                P = InStr(Linha, "R        ROUTE PARAMETERS")
                If P <> 0 Then
                    inicio = True
                    MargemEsq = P
                End If
                P = InStr(Linha, "PRI=")
                If P <> 0 Then
                    vPRI = Val(Mid(Linha, P + 4, 3))
                End If
                P = InStr(Linha, "EO=")
                If P <> 0 Then
                    vEO = Val(Mid(Linha, P + 3, 3))
                End If
                P = InStr(Linha, "EC=")
                If P <> 0 Then
                    vEC = Val(Mid(Linha, P + 3, 3))
                End If
                P = InStr(Linha, "FNC=")
                If P <> 0 Then
                    vFNC = Val(Mid(Linha, P + 4, 1))
                    vdescFNC = "---"
                    If vFNC = 1 Then
                        vdescFNC = "ENT"
                    ElseIf vFNC = 2 Then
                        vdescFNC = "SAI"
                    Else
                        Select Case Mid(vROTA, 1, 1)
                            Case "I", "E", "Y", "K", "H"
                                vdescFNC = "ENT"
                            Case "O", "S", "U", "W", "Z"
                                vdescFNC = "SAI"
                        End Select
                    End If
                End If
                P = InStr(Linha, "BO=")
                If P <> 0 Then
                    vBO = Val(Mid(Linha, P + 3, 3))
                End If
                P = InStr(Linha, "DPC=")
                If P <> 0 Then
                    vDPC = Trim(Mid(Linha, P + 4, 4))
                End If
                P = InStr(Linha, "SP=")
                If P <> 0 Then
                    vDPC = Trim(Mid(Linha, P + 5, 4))
                End If
                P = InStr(Linha, "MA=")
                If P <> 0 Then
                    P1 = InStr(Mid(Linha, P, 20), " ")
                    vMA = Trim(Mid(Linha, P + 3, P1 - 1))
                    P1 = InStr(Mid(Linha, P, 20), "#15")
                    If P1 > 0 Then
                        vMA = Mid(vMA, 1, P1)
                    End If
                End If
                P = InStr(Linha, " R=")
                If P <> 0 Then
                    vR = Trim(Mid(Linha, P + 3, 7))
                End If
                P = InStr(Linha, "R1=")
                If P <> 0 Then
                    vR1 = Trim(Mid(Linha, P + 3, 7))
                End If
                P = InStr(Linha, "RIN=")
                If P <> 0 Then
                    vRIN = Trim(Mid(Linha, P + 4, 7))
                End If
                P = InStr(Linha, "CO=")
                If P <> 0 Then
                    vCO = Val(Mid(Linha, P + 3, 7))
                End If
            End If
            Linha = strReader.ReadLine() 'Le linha
            If Linha Is Nothing Then
                Exit While
            End If
        End While
        If Descarregar Then
            ContRegSai = ContRegSai + 1
            txtSQL = frmManutencao.cbBilDumpShadow.Text & "," _
                    & vROTA & "," _
                    & vMA & "," _
                    & Format(Val(vBO), "000") & "," _
                    & Format(Val(vRIN), "0000") & "," _
                    & Format(vCO, "000") & "," _
                    & Format(Val(vEO), "000") & "," _
                    & vDETY & "," _
                    & Format(Val(vPRI), "00") & "," _
                    & Format(Val(vEC), "00") & "," _
                    & Format(Val(vFNC), "0") & "," _
                    & vDPC & "," _
                    & vR & "," _
                    & vR1 & "," _
                    & vdescFNC
            objWriter.WriteLine(txtSQL)
        End If
        objWriter.Close()
        nomeArquivo = nomeArquivo.ToString.Replace("\", "\\")
        txtSQL = "LOAD DATA INFILE '" & nomeArquivo & "' INTO TABLE _exrop FIELDS TERMINATED BY ',' LINES TERMINATED BY '\n';"
        MySQL_cmd(Conn, txtSQL)
        GravaLOG("Atualiza Listagem", "(EXROP) Registros: " & ContRegSai.ToString)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        If My.Settings.Param1 = "EXROP" Then
            frmPrincipal1.Close()
        Else
            MsgBox("CONCLUÍDO!")
        End If
    End Sub

    Private Sub btnImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportar.Click
        'define os objetos connecton, command e dataadapter

        Select Case frmManutencao.cbTipoCentral.Text
            Case "E"
                'Importar a Listagem atualmente carregada
                Dim aLine As String

                Dim strReader As New StringReader(WebBrowser1.Document.Body.OuterText)
                aLine = strReader.ReadLine() 'Le primeira linha

                If WebBrowser1.Document.Body.OuterText.ToUpper.IndexOf("EXROP:R=") > -1 Then
                    ImportaEXROP(Me.WebBrowser1.Document.Body.OuterText)
                Else
                    MsgBox("Não encontrei a palavra EXROP na página. A listagem não será importada.", MsgBoxStyle.Exclamation)
                End If
            Case "H"
                Dim texto() As String = Me.WebBrowser1.Document.Body.OuterText.ToString.Split(Chr(13))
                FormataListagem(texto)

                MsgBox("Importação Concluída.")

        End Select

    End Sub

    Private Sub btnCarregarManualmente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregarManualmente.Click
        With OpenFileDialog1
            .Filter = "Arquivos Texto (*.txt)|*.txt|Todos (*.*)|*.*"
            .FilterIndex = 1
            .InitialDirectory = "c:\temp\"
            .Title = "Escolhe o arquivo que contem a listagem"
            .FileName = ""
            .ShowDialog()
            txtURL.Text = .FileName
            If txtURL.Text = "" Then Exit Sub
            Select Case frmManutencao.cbTipoCentral.Text
                Case "E"
                    Me.WebBrowser1.Url = New System.Uri(txtURL.Text, System.UriKind.Absolute)
                Case "H"
                    txtURL.Text = txtURL.Text
                    'WebBrowser1.Url = New System.Uri(txtURL.Text, System.UriKind.Absolute)
                    WebBrowser1.Navigate(txtURL.Text)
            End Select

        End With
    End Sub

    Private Sub FormataListagem(ByVal texto() As String)
        Dim l, j, P, MargemEsq, ColunaInicial As Integer
        Dim linha, vTG_NUMBER, vTG_NAME, txtSQL As String
        Dim flListagem As Integer


        'define os objetos connecton, command e dataadapter
        Dim nomeArquivo = frmManutencao.txtPastaDeTrabalho.Text & "\temp.csv"

        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        'verifica se o arquivo existe e exclui o arquivo ja existente
        Try
            If File.Exists(nomeArquivo) = True Then
                File.Delete(nomeArquivo)
                'MsgBox("Arquivo " & nomeArquivo & " excluido...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End Try

        Dim objWriter As New StreamWriter(nomeArquivo, True)


        Dim registrosAfetados As Integer

        MySQL_cmd(Conn, "DELETE FROM LST_TG")

        '+++    SX SDR RC        2009-05-21 11:38:25
        'O&M    #538786
        '%%LST TG:SSR=NO;%%
        'RETCODE = 0  Operation succeeded

        'No7 Trunk Group   1
        '---------------
        ' Trunk group number  OPC       DPC       Network indicator       Trunk group name  MSF    
        '012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789
        ' 20                  0017E6    0037E6    National network        PTA UMG PL        Master 
        ' 23                  0017E6    0017EE    National network        SDR LC A          Master 

        'No7 Trunk Group Continued   2
        '-------------------------
        ' Trunk group number  Circuit type             Group direction       Sub-tg_number  MSF    

        ' 20                  ISUP                     Bi-directional trunk  20                Master 
        ' 23                  ISUP                     Bi-directional trunk  23                Master 

        'Other Trunk Group Info    3
        '----------------------
        ' Trunk group number  Trunk group name  Circuit type             Group direction       Sub-tg_number  MSF    
        '012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789
        ' 68                  TSAAN_AUDIPER     R2                       Bi-directional trunk  68                Master 
        ' 79                  SIP_TG_SPO_LP     SIP                      Bi-directional trunk  105               Master 

        For l = 0 To texto.Length - 1
            If texto(l).IndexOf("%%LST TG:") > -1 Then
                'MsgBox("Encontrei (%%LST TKC:).")
                flListagem = 0 '0=nenhuma  1=No7 Trunk Group 
                MargemEsq = 0
                For j = l To texto.Length - 1
                    Select Case flListagem
                        Case 1 'No7 Trunk Group 
                            ColunaInicial = MargemEsq
                            vTG_NUMBER = RetornaParametro(texto(j), ColunaInicial)
                            If Val(vTG_NUMBER) <> 0 Then 'Linha valida
                                vTG_NAME = RetornaParametro(texto(j), ColunaInicial)
                                vTG_NAME = RetornaParametro(texto(j), ColunaInicial)
                                vTG_NAME = RetornaParametro(texto(j), ColunaInicial)
                                vTG_NAME = RetornaParametro(texto(j), ColunaInicial)
                                txtSQL = Format(Val(vTG_NUMBER), "000") & "," & vTG_NAME & ","
                                objWriter.WriteLine(txtSQL)
                            End If
                        Case 2 'No7 Trunk Group Continued

                        Case 3 'Other Trunk Group Info
                            ColunaInicial = MargemEsq
                            vTG_NUMBER = RetornaParametro(texto(j), ColunaInicial)
                            If Val(vTG_NUMBER) <> 0 Then 'Linha valida
                                vTG_NAME = RetornaParametro(texto(j), ColunaInicial)
                                txtSQL = Format(Val(vTG_NUMBER), "000") & "," & vTG_NAME & ","
                                objWriter.WriteLine(txtSQL)
                            End If

                    End Select
                    linha = texto(j)

                    P = texto(j).IndexOf("No7 Trunk Group")
                    If P > -1 Then
                        MargemEsq = P
                        flListagem = 1
                    End If
                    P = texto(j).IndexOf("No7 Trunk Group Continued")
                    If P > -1 Then
                        MargemEsq = P
                        flListagem = 2
                    End If
                    P = texto(j).IndexOf("Other Trunk Group Info")
                    If P > -1 Then
                        MargemEsq = P
                        flListagem = 3
                    End If
                Next j
                objWriter.Close()

                txtSQL = "LOAD DATA INFILE 'c:\\temp\\temp.csv' INTO TABLE `LST_TG` FIELDS TERMINATED BY ',' LINES TERMINATED BY '\n';"
                MySQL_cmd(Conn, txtSQL)
                Exit Sub
            End If
        Next l

        MsgBox("Não foi encontrado (%%LST RT:).")
        Me.Cursor = System.Windows.Forms.Cursors.Default

    End Sub
    Private Function RetornaParametro(ByVal linha As String, ByRef P As Integer) As String
        Dim T, D As Integer
        Dim s As String

        D = linha.Length
        If D < P Then Exit Function

        s = linha.Substring(P, linha.Length - P).TrimStart
        T = s.IndexOf(",")
        If T < 0 Then
            T = s.IndexOf("  ")
            If T < 0 Then
                RetornaParametro = s.Substring(0, s.Length)
            Else
                RetornaParametro = s.Substring(0, T)
                D = (D - s.Length) + T
            End If
        Else
            RetornaParametro = s.Substring(0, T)
            D = (D - s.Length) + T
        End If
        P = D
    End Function

End Class