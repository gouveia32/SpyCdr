Imports System.Security.Cryptography
Imports System.IO
Imports System.text

Public Class frmManutencao

    Dim SQL As String
    'define a string de Conn
    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Dim myKey As String
    Dim des As New TripleDESCryptoServiceProvider()
    Dim hashmd5 As New MD5CryptoServiceProvider()
    'define os objetos connecton, command e dataadapter
    Dim strsql As String
    Const NomeBanco = "SpyCdr_"

    Dim registrosAfetados As Integer

    Public Function clsCrypto(ByVal texto As String, ByVal Operacao As Boolean) As String
        If Operacao Then
            clsCrypto = Cifra(texto)
        Else
            clsCrypto = DeCifra(texto)
        End If
    End Function
    Private Function DeCifra(ByVal texto As String) As String
        des.Key = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes("JAlves"))
        des.Mode = CipherMode.ECB
        Dim desdencrypt As ICryptoTransform = des.CreateDecryptor()
        Dim buff() As Byte = Convert.FromBase64String(texto)
        DeCifra = ASCIIEncoding.ASCII.GetString(desdencrypt.TransformFinalBlock(buff, 0, buff.Length))
    End Function
    Private Function Cifra(ByVal texto As String) As String
        des.Key = hashmd5.ComputeHash(ASCIIEncoding.ASCII.GetBytes("JAlves"))
        des.Mode = CipherMode.ECB
        Dim desdencrypt As ICryptoTransform = des.CreateEncryptor()
        Dim MyASCIIEncoding = New ASCIIEncoding()
        Dim buff() As Byte = ASCIIEncoding.ASCII.GetBytes(texto)
        Cifra = Convert.ToBase64String(desdencrypt.TransformFinalBlock(buff, 0, buff.Length))
    End Function
    Sub VerificaBanco()

        If Not BancoExiste(Conn, Me.txtBancoMySql.Text) Then
            If MsgBox("Não existe banco para o bilhetador [" _
                 & Me.txtBancoMySql.Text & "]. Posso Criá-lo?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                CriarBanco(Conn, Me.cbBilhetador.Text)
                'Preparar para criar tabelas

                'oSpyCdr.CriarTabelas(Me.cbBilhetador.Text, Me.lstMsg)
            End If
        End If

    End Sub
    Sub CarregaINI(ByVal ArqINI As String)
        Dim nome_arquivo_ini As String = nomeArquivoINI()
        Dim idxBIL As Integer
        Dim flBIL As String, mBil(6) As String

        If ArqINI <> "" Then nome_arquivo_ini = ArqINI
        'Carrega Configurações no .INI
        If Not File.Exists(nome_arquivo_ini) Then
            MsgBox("Será carregado os valores padrão do sistema.")
        End If

        Me.cbBilhetador.Text = LeArquivoINI(nome_arquivo_ini, "GERAL", "Bilhetador", "AJB")
        My.Settings.Bilhetador = Me.cbBilhetador.Text
        Me.txtPastaDeTrabalho.Text = LeArquivoINI(nome_arquivo_ini, "GERAL", "PastaDeTrabalho", "c:\temp\")
        Me.txtDumpshadowURL.Text = LeArquivoINI(nome_arquivo_ini, "GERAL", "DumpshadowURL", "http://10.13.115.7/dumpshadow/")
        Me.cbBilDumpShadow.Text = LeArquivoINI(nome_arquivo_ini, "GERAL", "BilDumpShadow", "AJB")

        Me.cbServidorMySql.Text = LeArquivoINI(nome_arquivo_ini, "MySQL", "Servidor", "127.0.0.1")
        Me.cbUsuarioMySql.Text = LeArquivoINI(nome_arquivo_ini, "MySQL", "Usuario", "root")
        Me.cbSenhaMySql.Text = DeCifra(LeArquivoINI(nome_arquivo_ini, "MySQL", "Senha", "DuwSSJ6fgs8="))
        Me.txtBancoMySql.Text = LeArquivoINI(nome_arquivo_ini, "MySQL", "Banco", "SpyCdr_ajb")


        'Carregar BILHETADORES
        idxBIL = 1
        flBIL = LeArquivoINI(nome_arquivo_ini, "BILHETADORES", Format(idxBIL, "00"), "No")
        cbBilhetador.Items.Clear()
        While (flBIL <> "No")
            mBil = flBIL.Split(" ")
            Me.cbBilhetador.Items.Add(mBil(0))
            If mBil.Length > 2 Then
                Me.cbBilDumpShadow.Items.Add(mBil(1))
                Me.cbServidorMySql.Items.Add(mBil(2))
                Me.cbUsuarioMySql.Items.Add(mBil(3))
                Me.cbSenhaMySql.Items.Add(DeCifra(mBil(4)))
            Else
                Me.cbBilDumpShadow.Items.Add(mBil(1).Substring(1, mBil(1).Length - 2))
                Me.cbServidorMySql.Items.Add(Me.cbServidorMySql.Text)
                Me.cbUsuarioMySql.Items.Add(Me.cbUsuarioMySql.Text)
                Me.cbSenhaMySql.Items.Add(Me.cbSenhaMySql.Text)
            End If
            If mBil.Length > 5 Then
                Me.cbTipoCentral.Items.Add(mBil(5))
            Else
                Me.cbTipoCentral.Items.Add("E")
            End If

            idxBIL = idxBIL + 1
            flBIL = LeArquivoINI(nome_arquivo_ini, "BILHETADORES", Format(idxBIL, "00"), "No")
        End While

        Me.cbBilhetador.Text = LeArquivoINI(nome_arquivo_ini, "GERAL", "Bilhetador", "AJB")
        Me.nudLimite1OK.Value = LeArquivoINI(nome_arquivo_ini, "CORES", "nudLimite1Ok", 60)
        Me.nudLimite2OK.Value = LeArquivoINI(nome_arquivo_ini, "CORES", "nudLimite2Ok", 60)
        Me.Panel1OKCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel1OKCor", Color.Aqua.ToArgb))
        Me.Panel2OKCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel2OKCor", Color.Aqua.ToArgb))
        Me.Panel3OKCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel3OKCor", Color.Aqua.ToArgb))
        
        Me.nudLimite1PAB.Value = LeArquivoINI(nome_arquivo_ini, "CORES", "nudLimite1PAB", 1)
        Me.nudLimite2PAB.Value = LeArquivoINI(nome_arquivo_ini, "CORES", "nudLimite2PAB", 1)
        Me.Panel1PABCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel1PABCor", Color.Red.ToArgb))
        Me.Panel2PABCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel2PABCor", Color.Red.ToArgb))
        Me.Panel3PABCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel3PABCor", Color.Red.ToArgb))

        Me.nudLimite1CO.Value = LeArquivoINI(nome_arquivo_ini, "CORES", "nudLimite1CO", 1)
        Me.nudLimite2CO.Value = LeArquivoINI(nome_arquivo_ini, "CORES", "nudLimite2CO", 1)
        Me.Panel1COCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel1COCor", Color.Red.ToArgb))
        Me.Panel2COCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel2COCor", Color.Red.ToArgb))
        Me.Panel3COCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel3COCor", Color.Red.ToArgb))

        Me.nudLimite1DSC.Value = LeArquivoINI(nome_arquivo_ini, "CORES", "nudLimite1DSC", 1)
        Me.nudLimite2DSC.Value = LeArquivoINI(nome_arquivo_ini, "CORES", "nudLimite2DSC", 1)
        Me.Panel1DSCCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel1DSCCor", Color.Red.ToArgb))
        Me.Panel2DSCCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel2DSCCor", Color.Red.ToArgb))
        Me.Panel3DSCCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel3DSCCor", Color.Red.ToArgb))

        Me.nudLimite1OU.Value = LeArquivoINI(nome_arquivo_ini, "CORES", "nudLimite1OU", 1)
        Me.nudLimite2OU.Value = LeArquivoINI(nome_arquivo_ini, "CORES", "nudLimite2OU", 1)
        Me.Panel1OUCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel1OUCor", Color.Red.ToArgb))
        Me.Panel2OUCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel2OUCor", Color.Red.ToArgb))
        Me.Panel3OUCor.BackColor = Color.FromArgb(LeArquivoINI(nome_arquivo_ini, "CORES", "Panel3OUCor", Color.Red.ToArgb))

        frmGeraHistorico.ckbX_Cliente_Originado.Checked = LeArquivoINI(nome_arquivo_ini, "PROCESSAMENTO", "ckbX_Cliente_Originado", True)
        frmGeraHistorico.ckbX_Cliente_Destinado.Checked = LeArquivoINI(nome_arquivo_ini, "PROCESSAMENTO", "ckbX_Cliente_Destinado", True)
        frmGeraHistorico.ckbX_Rota_Entrada.Checked = LeArquivoINI(nome_arquivo_ini, "PROCESSAMENTO", "ckbX_Rota_Entrada", True)
        frmGeraHistorico.ckbX_Rota_Saida.Checked = LeArquivoINI(nome_arquivo_ini, "PROCESSAMENTO", "ckbX_Rota_Saida", True)
        frmGeraHistorico.ckbX_Grupo.Checked = LeArquivoINI(nome_arquivo_ini, "PROCESSAMENTO", "ckbX_Grupo", True)
        frmGeraHistorico.ckbX_ASS_A.Checked = LeArquivoINI(nome_arquivo_ini, "PROCESSAMENTO", "ckbX_ASS_A", True)
        frmGeraHistorico.ckbX_ASS_B.Checked = LeArquivoINI(nome_arquivo_ini, "PROCESSAMENTO", "ckbX_ASS_B", True)
        frmGeraHistorico.ckbX_EOS.Checked = LeArquivoINI(nome_arquivo_ini, "PROCESSAMENTO", "ckbX_EOS", True)
        frmGeraHistorico.ckbX_PPI.Checked = LeArquivoINI(nome_arquivo_ini, "PROCESSAMENTO", "ckbX_PPI", True)

        frmGeraHistorico.numLimiteTCH.Value = LeArquivoINI(nome_arquivo_ini, "PROCESSAMENTO", "numLimiteOK", "40")

        'frmHistIndicadores.cbHistorico.Text = LeArquivoINI(nome_arquivo_ini, "CONSULTA", "cbHistorico", "X_Rota_Saida")
        'frmResumo.cbHistorico.Text = LeArquivoINI(nome_arquivo_ini, "CONSULTA", "ResumocbHistorico", "X_Rota_Saida")

        Me.txtServidorFTP.Text = LeArquivoINI(nome_arquivo_ini, "FTP", "Servidor", "10.13.24.30")
        Me.txtUsuarioFTP.Text = LeArquivoINI(nome_arquivo_ini, "FTP", "Usuario", "gouveia")
        Me.txtSenhaFTP.Text = DeCifra(LeArquivoINI(nome_arquivo_ini, "FTP", "Senha", "DuwSSJ6fgs8="))
        Me.txtPastaRemotaFTP.Text = LeArquivoINI(nome_arquivo_ini, "FTP", "PastaRemota", "/bmp/coletados/AJB/")

        'Me.txtBancoMySql.Text = NomeBanco & Me.cbBilhetador.Text

        'VerificaBanco()
        'Conn = MySQL_Conectar()
        My.Settings.TipoCentral = cbTipoCentral.Text
        My.Settings.ConnectionString = String.Format("Server={0:s};Database=spycdr_{1:s};Uid={2:0};Pwd={3:s}", _
                                                     Me.cbServidorMySql.Text, _
                                                     Me.cbBilhetador.Text, _
                                                     Me.cbUsuarioMySql.Text, _
                                                     Me.cbSenhaMySql.Text)

    End Sub

    ' Usa a função GetPrivateProfileString para obter os valores 
    Private Function LeArquivoINI(ByVal file_name As String, ByVal section_name As String, ByVal key_name As String, ByVal default_value As String) As String

        Const MAX_LENGTH As Integer = 500
        Dim string_builder As New StringBuilder(MAX_LENGTH)

        GetPrivateProfileString(section_name, key_name, default_value, string_builder, MAX_LENGTH, file_name)
        Return string_builder.ToString()

    End Function
    Private Function geraHash(ByVal valor As String) As String
        'Crria um objeto encoding para assegurar o encoding padrão para o texto fonte
        Dim Ue As New UnicodeEncoding()

        'Retorna um array de bytes baseado no texto fonte
        Dim ByteSourceText() As Byte = Ue.GetBytes(valor)

        'Instancia um objeto MD5
        Dim Md5 As New MD5CryptoServiceProvider()

        'Calcula o valor do hash para o texto
        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)

        'Converte o valor para o formato string e retorna
        Return Convert.ToBase64String(ByteHash)

    End Function
    Sub gravaArquivoini()
        Dim nome_arquivo_ini As String = nomeArquivoINI()
        Dim valorSenha As String
        Dim idxBil As Integer
        ' grava bilhetadores
        For idxBil = 1 To cbBilhetador.Items.Count
            valorSenha = Cifra(Me.cbSenhaMySql.Items(idxBil - 1))
            WritePrivateProfileString("BILHETADORES", Format(idxBil, "00"), _
                Me.cbBilhetador.Items(idxBil - 1) & " " _
                        & Me.cbBilDumpShadow.Items(idxBil - 1) & " " _
                        & Me.cbServidorMySql.Items(idxBil - 1) & " " _
                        & Me.cbUsuarioMySql.Items(idxBil - 1) & " " _
                        & valorSenha & " " _
                        & Me.cbTipoCentral.Items(idxBil - 1) & " ", nome_arquivo_ini)
        Next

        valorSenha = Cifra(Me.cbSenhaMySql.Text)

        WritePrivateProfileString("GERAL", "Bilhetador", Me.cbBilhetador.Text, nome_arquivo_ini)
        WritePrivateProfileString("GERAL", "BilDumpShadow", Me.cbBilDumpShadow.Text, nome_arquivo_ini)
        WritePrivateProfileString("GERAL", "PastaDeTrabalho", Me.txtPastaDeTrabalho.Text, nome_arquivo_ini)
        WritePrivateProfileString("GERAL", "DumpshadowURL", Me.txtDumpshadowURL.Text, nome_arquivo_ini)

        WritePrivateProfileString("CORES", "nudLimite1OK", Me.nudLimite1OK.Value, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "nudLimite2OK", Me.nudLimite2OK.Value, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel1OKCor", Me.Panel1OKCor.BackColor.ToArgb, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel2OKCor", Me.Panel2OKCor.BackColor.ToArgb, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel3OKCor", Me.Panel3OKCor.BackColor.ToArgb, nome_arquivo_ini)

        WritePrivateProfileString("CORES", "nudLimite1PAB", Me.nudLimite1PAB.Value, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "nudLimite2PAB", Me.nudLimite2PAB.Value, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel1PABCor", Me.Panel1PABCor.BackColor.ToArgb, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel2PABCor", Me.Panel2PABCor.BackColor.ToArgb, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel3PABCor", Me.Panel3PABCor.BackColor.ToArgb, nome_arquivo_ini)

        WritePrivateProfileString("CORES", "nudLimite1CO", Me.nudLimite1CO.Value, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "nudLimite2CO", Me.nudLimite2CO.Value, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel1COCor", Me.Panel1COCor.BackColor.ToArgb, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel2COCor", Me.Panel2COCor.BackColor.ToArgb, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel3COCor", Me.Panel3COCor.BackColor.ToArgb, nome_arquivo_ini)

        WritePrivateProfileString("CORES", "nudLimite1DSC", Me.nudLimite1DSC.Value, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "nudLimite2DSC", Me.nudLimite2DSC.Value, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel1DSCCor", Me.Panel1DSCCor.BackColor.ToArgb, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel2DSCCor", Me.Panel2DSCCor.BackColor.ToArgb, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel3DSCCor", Me.Panel3DSCCor.BackColor.ToArgb, nome_arquivo_ini)

        WritePrivateProfileString("CORES", "nudLimite1OU", Me.nudLimite1OU.Value, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "nudLimite2OU", Me.nudLimite2OU.Value, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel1OUCor", Me.Panel1OUCor.BackColor.ToArgb, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel2OUCor", Me.Panel2OUCor.BackColor.ToArgb, nome_arquivo_ini)
        WritePrivateProfileString("CORES", "Panel3OUCor", Me.Panel3OUCor.BackColor.ToArgb, nome_arquivo_ini)

        WritePrivateProfileString("PROCESSAMENTO", "ckbX_Rota_Entrada", frmGeraHistorico.ckbX_Rota_Entrada.Checked, nome_arquivo_ini)
        WritePrivateProfileString("PROCESSAMENTO", "ckbX_Rota_Saida", frmGeraHistorico.ckbX_Rota_Saida.Checked, nome_arquivo_ini)
        WritePrivateProfileString("PROCESSAMENTO", "ckbX_Cliente_Originado", frmGeraHistorico.ckbX_Cliente_Originado.Checked, nome_arquivo_ini)
        WritePrivateProfileString("PROCESSAMENTO", "ckbX_Cliente_Destinado", frmGeraHistorico.ckbX_Cliente_Destinado.Checked, nome_arquivo_ini)
        WritePrivateProfileString("PROCESSAMENTO", "ckbX_Grupo", frmGeraHistorico.ckbX_Grupo.Checked, nome_arquivo_ini)
        WritePrivateProfileString("PROCESSAMENTO", "ckbX_ASS_A", frmGeraHistorico.ckbX_ASS_A.Checked, nome_arquivo_ini)
        WritePrivateProfileString("PROCESSAMENTO", "ckbX_ASS_B", frmGeraHistorico.ckbX_ASS_B.Checked, nome_arquivo_ini)
        WritePrivateProfileString("PROCESSAMENTO", "ckbX_EOS", frmGeraHistorico.ckbX_EOS.Checked, nome_arquivo_ini)
        WritePrivateProfileString("PROCESSAMENTO", "ckbX_PPI", frmGeraHistorico.ckbX_PPI.Checked, nome_arquivo_ini)
        WritePrivateProfileString("PROCESSAMENTO", "numLimiteOK", frmGeraHistorico.numLimiteTCH.Value, nome_arquivo_ini)

        'WritePrivateProfileString("CONSULTA", "cbHistorico", frmHistIndicadores.cbHistorico.Text, nome_arquivo_ini)
        'WritePrivateProfileString("CONSULTA", "ResumocbHistorico", frmResumo.cbHistorico.Text, nome_arquivo_ini)

        WritePrivateProfileString("MySQL", "Servidor", Me.cbServidorMySql.Text, nome_arquivo_ini)
        WritePrivateProfileString("MySQL", "Usuario", Me.cbUsuarioMySql.Text, nome_arquivo_ini)
        WritePrivateProfileString("MySQL", "Senha", valorSenha, nome_arquivo_ini)
        WritePrivateProfileString("MySQL", "Banco", Me.txtBancoMySql.Text, nome_arquivo_ini)

        valorSenha = Cifra(Me.txtSenhaFTP.Text)
        WritePrivateProfileString("FTP", "Servidor", Me.txtServidorFTP.Text, nome_arquivo_ini)
        WritePrivateProfileString("FTP", "Usuario", Me.txtUsuarioFTP.Text, nome_arquivo_ini)
        WritePrivateProfileString("FTP", "Senha", valorSenha, nome_arquivo_ini)
        WritePrivateProfileString("FTP", "PastaRemota", Me.txtPastaRemotaFTP.Text, nome_arquivo_ini)

    End Sub
    ' Retorna o nome do arquivo INI 
    Private Function nomeArquivoINI() As String
        Dim nome_arquivo_ini As String = Application.StartupPath

        nome_arquivo_ini = nome_arquivo_ini.Substring(0, nome_arquivo_ini.LastIndexOf("\"))

        Return nome_arquivo_ini & "\SpyCdr.ini"

    End Function
    Private Sub cbBilhetador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBilhetador.SelectedIndexChanged
        Me.cbBilDumpShadow.SelectedIndex = Me.cbBilhetador.SelectedIndex
        Me.cbServidorMySql.SelectedIndex = Me.cbBilhetador.SelectedIndex
        Me.cbUsuarioMySql.SelectedIndex = Me.cbBilhetador.SelectedIndex
        Me.cbSenhaMySql.SelectedIndex = Me.cbBilhetador.SelectedIndex
        Me.cbTipoCentral.SelectedIndex = Me.cbBilhetador.SelectedIndex
        Me.txtBancoMySql.Text = "SpyCdr_" & Me.cbBilhetador.Text
        Me.txtPastaRemotaFTP.Text = "/bmp/coletados/" & Me.cbBilDumpShadow.Text & "/"
        'VerificaBanco()

    End Sub

    Private Sub frmManutencao_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Text = "Configuração - " & Me.cbBilhetador.Text
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnCriarTabelas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriarTabelas.Click
        Dim cmdTXT As String

        VerificaBanco()
        lstMsg.Items.Clear()
        lstMsg.Items.Add("Criando TABELAS no Banco [" & txtBancoMySql.Text & "]")

        If Me.cbCriarTabelalogAtividade.Checked Then
            cmdTXT = "CREATE TABLE logAtividade (" _
                   & "CODIGO int(6) NULL auto_increment," _
                   & "DATA datetime NOT NULL," _
                   & "GRUPO varchar(20) default NULL," _
                   & "DETALHE varchar(240) default NULL," _
                   & "KEY Index_CODIGO (CODIGO)" _
                   & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
            CriarTabela(cbBilhetador.Text, "logAtividade", cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelaCDRs_Sel.Checked Then
            Select Case cbTipoCentral.Text
                Case "E"
                    cmdTXT = "CREATE TABLE " & "cdrs_sel (" _
                            & "CLASSIF varchar(3) default NULL," _
                            & "ASS_A varchar(13) default NULL," _
                            & "CSP varchar(2) default NULL," _
                            & "ASS_B varchar(16) default NULL," _
                            & "CAT varchar(2) default NULL," _
                            & "FDS varchar(2) default NULL," _
                            & "EOS varchar(4) default NULL," _
                            & "PT varchar(1) default NULL," _
                            & "ECH varchar(1) default NULL," _
                            & "J_ENT varchar(4) default NULL," _
                            & "J_SAI varchar(4) default NULL," _
                            & "R_ENT varchar(4) default NULL," _
                            & "R_SAI varchar(4) default NULL," _
                            & "DATA datetime default NULL," _
                            & "DUR_RING int(5) default NULL," _
                            & "DURACAO varchar(10) default NULL," _
                            & "DUR_TOTAL int(5) default NULL," _
                            & "TTFILE varchar(4) default NULL," _
                            & "NR_DISCADO varchar(22) default NULL," _
                            & "RN2 varchar(8) default NULL," _
                            & "RN3 varchar(2) default NULL," _
                            & " KEY Data_Index (DATA) " _
                            & ") ENGINE=MyISAM DEFAULT CHARSET=latin1;"
                Case "H"
                    cmdTXT = "CREATE TABLE " & "cdrs_sel (" _
                            & "CLASSIF varchar(3) default NULL," _
                            & "DATA datetime default NULL," _
                            & "DURACAO int(5) default NULL," _
                            & "ASS_A varchar(20) default NULL," _
                            & "CSP varchar(2) default NULL," _
                            & "ASS_B varchar(20) default NULL," _
                            & "Dialed_Number varchar(20) default NULL," _
                            & "PT varchar(1) default NULL," _
                            & "R_ENT varchar(5) default NULL," _
                            & "R_SAI varchar(5) default NULL," _
                            & "Caller_category varchar(6) default NULL," _
                            & "CSN varchar(10) default NULL," _
                            & "Switch_ID varchar(10) default NULL," _
                            & "Bill_Type varchar(3) default NULL," _
                            & "End_Date datetime default NULL," _
                            & "Billed_Party varchar(1) default NULL," _
                            & "Connected_Number varchar(20) default NULL," _
                            & "Charged_Number varchar(20) default NULL," _
                            & "Partial_Record_Ind varchar(2) default NULL," _
                            & "Free_Ind varchar(20) default NULL," _
                            & "Charged_Party_Ind varchar(2) default NULL," _
                            & "Call_Type varchar(2) default NULL," _
                            & "GSVN varchar(2) default NULL," _
                            & "Failure_Code varchar(3) default NULL," _
                            & "Termination_Code varchar(2) default NULL," _
                            & "Bearer_Service varchar(3) default NULL," _
                            & "Tele_Service varchar(2) default NULL," _
                            & "RxFlus varchar(10) default NULL," _
                            & "TxFlus varchar(10) default NULL," _
                            & "Caller_GK_Address varchar(15) default NULL," _
                            & "Caller_GW_Address varchar(15) default NULL," _
                            & "Called_GK_Address varchar(15) default NULL," _
                            & "Called_GW_Address varchar(15) default NULL," _
                            & "Coding_Type varchar(3) default NULL," _
                            & "Centrex_group_number varchar(5) default NULL," _
                            & "Caller_ctx_number varchar(9) default NULL," _
                            & "Called_ctx_number varchar(9) default NULL," _
                            & "Clock_Indicator varchar(1) default NULL," _
                            & "Partial_Counter varchar(6) default NULL," _
                            & "Seizure_Date datetime default NULL," _
                            & "Release_Date datetime default NULL," _
                            & "TTFILE varchar(8) default NULL," _
                            & "RN2 varchar(8) default NULL," _
                            & "RN3 varchar(2) default NULL," _
                            & " KEY Data_Index (DATA) " _
                            & ") ENGINE=MyISAM DEFAULT CHARSET=latin1;"

                Case "N"
                    cmdTXT = "CREATE TABLE " & "cdrs_sel (" _
                                & "CLASSIF varchar(3) default NULL," _
                                & "ASS_A varchar(13) default NULL," _
                                & "CSP varchar(2) default NULL," _
                                & "ASS_B varchar(16) default NULL," _
                                & "CAT varchar(2) default NULL," _
                                & "FDS varchar(2) default NULL," _
                                & "EOS varchar(4) default NULL," _
                                & "PT varchar(1) default NULL," _
                                & "ICT varchar(4) default NULL," _
                                & "OGT varchar(4) default NULL," _
                                & "R_ENT varchar(8) default NULL," _
                                & "R_SAI varchar(8) default NULL," _
                                & "DATA datetime default NULL," _
                                & "DURACAO varchar(8) default NULL," _
                                & "CL varchar(2) default NULL," _
                                & "EXTENSAO varchar(1) default NULL," _
                                & "NR_EXTEN varchar(1) default NULL," _
                                & "CAUSA varchar(1) default NULL," _
                                & "EVENTO varchar(2) default NULL," _
                                & "RELOGIO varchar(1) default NULL," _
                                & "SERV_SUPORTE varchar(3) default NULL," _
                                & "TELESERVICO varchar(3) default NULL," _
                                & "ACESSO varchar(2) default NULL," _
                                & "OCUP_INICIO datetime default NULL," _
                                & "OCUP_FIM datetime default NULL," _
                                & "TTFILE varchar(4) default NULL," _
                                & " KEY Data_Index (DATA) " _
                                & ") ENGINE=MyISAM DEFAULT CHARSET=latin1;"
            End Select
            CriarTabela(cbBilhetador.Text, "cdrs_sel", cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelaCDRs_Hoje.Checked Then
            Select Case cbTipoCentral.Text
                Case "E"
                    cmdTXT = "CREATE TABLE " & "cdrs_" & Format(Now, "yyyyMMdd") & " (" _
                            & "CLASSIF varchar(3) default NULL," _
                            & "ASS_A varchar(13) default NULL," _
                            & "CSP varchar(2) default NULL," _
                            & "ASS_B varchar(16) default NULL," _
                            & "CAT varchar(2) default NULL," _
                            & "FDS varchar(2) default NULL," _
                            & "EOS varchar(4) default NULL," _
                            & "PT varchar(1) default NULL," _
                            & "ECH varchar(1) default NULL," _
                            & "J_ENT varchar(4) default NULL," _
                            & "J_SAI varchar(4) default NULL," _
                            & "R_ENT varchar(4) default NULL," _
                            & "R_SAI varchar(4) default NULL," _
                            & "DATA datetime default NULL," _
                            & "DUR_RING int(5) default NULL," _
                            & "DURACAO varchar(10) default NULL," _
                            & "DUR_TOTAL int(5) default NULL," _
                            & "TTFILE varchar(4) default NULL," _
                            & "NR_DISCADO varchar(22) default NULL," _
                            & "RN2 varchar(8) default NULL," _
                            & "RN3 varchar(2) default NULL," _
                            & " KEY Data_Index (DATA) " _
                            & ") ENGINE=MyISAM DEFAULT CHARSET=latin1;"
                Case "H"
                    cmdTXT = "CREATE TABLE " & "cdrs_" & Format(Now, "yyyyMMdd") & " (" _
                            & "CLASSIF varchar(3) default NULL," _
                            & "DATA datetime default NULL," _
                            & "DURACAO int(5) default NULL," _
                            & "ASS_A varchar(20) default NULL," _
                            & "CSP varchar(2) default NULL," _
                            & "ASS_B varchar(20) default NULL," _
                            & "Dialed_Number varchar(20) default NULL," _
                            & "PT varchar(1) default NULL," _
                            & "R_ENT varchar(5) default NULL," _
                            & "R_SAI varchar(5) default NULL," _
                            & "Caller_category varchar(6) default NULL," _
                            & "CSN varchar(10) default NULL," _
                            & "Switch_ID varchar(10) default NULL," _
                            & "Bill_Type varchar(3) default NULL," _
                            & "End_Date datetime default NULL," _
                            & "Billed_Party varchar(1) default NULL," _
                            & "Connected_Number varchar(20) default NULL," _
                            & "Charged_Number varchar(20) default NULL," _
                            & "Partial_Record_Ind varchar(2) default NULL," _
                            & "Free_Ind varchar(20) default NULL," _
                            & "Charged_Party_Ind varchar(2) default NULL," _
                            & "Call_Type varchar(2) default NULL," _
                            & "GSVN varchar(2) default NULL," _
                            & "Failure_Code varchar(3) default NULL," _
                            & "Termination_Code varchar(2) default NULL," _
                            & "Bearer_Service varchar(3) default NULL," _
                            & "Tele_Service varchar(2) default NULL," _
                            & "RxFlus varchar(10) default NULL," _
                            & "TxFlus varchar(10) default NULL," _
                            & "Caller_GK_Address varchar(15) default NULL," _
                            & "Caller_GW_Address varchar(15) default NULL," _
                            & "Called_GK_Address varchar(15) default NULL," _
                            & "Called_GW_Address varchar(15) default NULL," _
                            & "Coding_Type varchar(3) default NULL," _
                            & "Centrex_group_number varchar(5) default NULL," _
                            & "Caller_ctx_number varchar(9) default NULL," _
                            & "Called_ctx_number varchar(9) default NULL," _
                            & "Clock_Indicator varchar(1) default NULL," _
                            & "Partial_Counter varchar(6) default NULL," _
                            & "Seizure_Date datetime default NULL," _
                            & "Release_Date datetime default NULL," _
                            & "TTFILE varchar(8) default NULL," _
                            & "RN2 varchar(8) default NULL," _
                            & "RN3 varchar(2) default NULL," _
                            & " KEY Data_Index (DATA) " _
                            & ") ENGINE=MyISAM DEFAULT CHARSET=latin1;"

                Case "N"
                    cmdTXT = "CREATE TABLE " & "cdrs_" & Format(Now, "yyyyMMdd") & " (" _
                                & "CLASSIF varchar(3) default NULL," _
                                & "ASS_A varchar(16) default NULL," _
                                & "CSP varchar(2) default NULL," _
                                & "ASS_B varchar(18) default NULL," _
                                & "CAT varchar(2) default NULL," _
                                & "FDS varchar(2) default NULL," _
                                & "PT varchar(1) default NULL," _
                                & "ICT varchar(4) default NULL," _
                                & "OGT varchar(4) default NULL," _
                                & "R_ENT varchar(8) default NULL," _
                                & "R_SAI varchar(8) default NULL," _
                                & "DATA date default NULL," _
                                & "HORA varchar(8) default NULL," _
                                & "DURACAO varchar(8) default NULL," _
                                & "CL varchar(2) default NULL," _
                                & "EXTENSAO varchar(1) default NULL," _
                                & "NR_EXTEN varchar(1) default NULL," _
                                & "CAUSA varchar(1) default NULL," _
                                & "EVENTO varchar(2) default NULL," _
                                & "RELOGIO varchar(1) default NULL," _
                                & "SERV_SUPORTE varchar(3) default NULL," _
                                & "TELESERVICO varchar(3) default NULL," _
                                & "ACESSO varchar(2) default NULL," _
                                & "OCUP_INICIO time default NULL," _
                                & "OCUP_FIM time default NULL," _
                                & "TTFILE varchar(4) default NULL," _
                                & " KEY Data_Index (DATA) " _
                                & ") ENGINE=MyISAM DEFAULT CHARSET=latin1;"

            End Select
            CriarTabela(cbBilhetador.Text, "cdrs_" & Format(Now, "yyyyMMdd"), cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelalog.Checked Then
            Select Case cbTipoCentral.Text
                Case "E"
                    cmdTXT = "CREATE TABLE log (" _
                            & "TTFILE varchar(4) default NULL," _
                            & "DATA_BMP date NOT NULL," _
                            & "HORA_BMP time default NULL," _
                            & "DATA_BAIXA date default NULL," _
                            & "HORA_BAIXA time default NULL," _
                            & "QUANT_CDRs int(6) default NULL, " _
                            & "PRIMARY KEY  (TTFILE,DATA_BMP)"
                    cmdTXT += ") ENGINE=MyISAM DEFAULT CHARSET=latin1;"
                Case "N", "H"
                    cmdTXT = "CREATE TABLE log (" _
                                & "TTFILE varchar(8) default NULL," _
                                & "DATA_BMP date NOT NULL," _
                                & "HORA_BMP time default NULL," _
                                & "DATA_BAIXA date default NULL," _
                                & "HORA_BAIXA time default NULL," _
                                & "QUANT_CDRs int(6) default NULL, " _
                                & "PRIMARY KEY  (TTFILE,DATA_BMP)"
                    cmdTXT += ") ENGINE=MyISAM DEFAULT CHARSET=latin1;"
            End Select
            CriarTabela(cbBilhetador.Text, "log", cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelaclientes.Checked Then
            cmdTXT = "CREATE TABLE clientes (" _
                    & "COD_CLI int(4) NULL auto_increment," _
                    & "CLIENTE varchar(50) default NULL," _
                    & "FAIXA_INICIO varchar(16) default NULL," _
                    & "FAIXA_FIM varchar(16) default NULL," _
                    & "ROTA_FAB varchar(10) default NULL," _
                    & "VIP tinyint(1) default 0," _
                    & "NR_CHAVE varchar(10) default NULL," _
                    & "EMAIL varchar(50) default NULL," _
                    & "PRIMARY KEY  (COD_CLI)," _
                    & "KEY CLIENTE (CLIENTE)" _
                    & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
            CriarTabela(cbBilhetador.Text, "clientes", cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelacliente_terminal.Checked Then
            cmdTXT = "CREATE TABLE cliente_terminal (" _
                    & "TERMINAL varchar(16) NOT NULL," _
                    & "COD_CLI int(11) default 0," _
                    & "PRIMARY KEY  (TERMINAL)" _
                    & ") ENGINE=MyISAM DEFAULT CHARSET=latin1;"
            CriarTabela(cbBilhetador.Text, "cliente_terminal", cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelatabclassificacao.Checked Then
            'dbConn = MySQL_Conn(Me.cbServidorMySql.Text, Me.txtBancoMySql.Text, Me.cbUsuarioMySql.Text, Me.cbSenhaMySql.Text)
            If Not TabelaExiste(Conn, Me.txtBancoMySql.Text, "tabclassificacao") Then
                Select Case cbTipoCentral.Text
                    Case "E"
                        cmdTXT = "CREATE TABLE tabclassificacao (" _
                                & "FDS varchar(2) NOT NULL," _
                                & "ECHO varchar(1) NOT NULL," _
                                & "CLASSIF varchar(5) default NULL," _
                                & "PRIMARY KEY  (FDS,ECHO)" _
                                & ") ENGINE=MyISAM DEFAULT CHARSET=latin1;"
                    Case "N"
                        cmdTXT = "CREATE TABLE tabclassificacao (" _
                                & "CLI varchar(2) NOT NULL," _
                                & "FDS varchar(2) NOT NULL," _
                                & "TemSaida tinyint(1) default 0," _
                                & "CLASSIF varchar(5) default NULL," _
                                & "PRIMARY KEY  (CLI,FDS,TemSaida)" _
                                & ") ENGINE=MyISAM DEFAULT CHARSET=latin1;"
                End Select
                CriarTabela(cbBilhetador.Text, "tabclassificacao", cmdTXT, lstMsg)
                Select Case cbTipoCentral.Text
                    Case "E"
                        cmdTXT = "INSERT INTO tabclassificacao (FDS,ECHO, CLASSIF) VALUES" _
                                    & " ('--','1','DSC')," _
                                    & " ('--','3','OU')," _
                                    & " ('00','1','OU')," _
                                    & " ('01','-','OU')," _
                                    & " ('01','0','OK1')," _
                                    & " ('01','1','NR1')," _
                                    & " ('01','2','OU')," _
                                    & " ('01','3','OU')," _
                                    & " ('01','4','OU')," _
                                    & " ('02','1','LO')," _
                                    & " ('02','3','CO0')," _
                                    & " ('03','1','OU')," _
                                    & " ('05','0','OK5')," _
                                    & " ('05','1','NR5')," _
                                    & " ('05','2','OU')," _
                                    & " ('06','0','OK1')," _
                                    & " ('07','1','OU')," _
                                    & " ('08','1','OU')," _
                                    & " ('12','1','OU')," _
                                    & " ('15','1','OU')," _
                                    & " ('20','1','CO0')," _
                                    & " ('21','1','CO0')," _
                                    & " ('24','1','CO2')," _
                                    & " ('26','1','CO1')," _
                                    & " ('27','1','CO1')," _
                                    & " ('28','1','CO3')," _
                                    & " ('29','1','CO3')," _
                                    & " ('30','1','CO2')," _
                                    & " ('31','1','NR5')," _
                                    & " ('33','1','NR5')," _
                                    & " ('37','1','OU')"
                    Case "N"
                        cmdTXT = "INSERT INTO tabclassificacao (CLI,FDS,TemSaida, CLASSIF) VALUES" _
                                    & " ('10','01','1','OK1')," _
                                    & " ('10','01','0','OK1')," _
                                    & " ('10','05','1','OK5')," _
                                    & " ('10','05','0','OK5')," _
                                    & " ('10','06','1','OK1')," _
                                    & " ('10','06','0','OK1')," _
                                    & " ('20','01','1','OK1')," _
                                    & " ('20','01','0','OK1')," _
                                    & " ('20','05','1','OK5')," _
                                    & " ('20','05','0','OK5')," _
                                    & " ('31','01','1','NR1')," _
                                    & " ('31','01','0','NR1')," _
                                    & " ('31','04','1','OU')," _
                                    & " ('31','04','0','OU')," _
                                    & " ('31','05','1','NR5')," _
                                    & " ('31','05','0','NR5')," _
                                    & " ('31','06','1','NR1')," _
                                    & " ('31','06','0','NR1')," _
                                    & " ('32','01','1','LO')," _
                                    & " ('32','01','0','LO')," _
                                    & " ('32','02','1','LO')," _
                                    & " ('32','02','0','LO')," _
                                    & " ('40','04','1','CO0')," _
                                    & " ('40','04','0','CO0')," _
                                    & " ('41','04','1','CO0')," _
                                    & " ('41','04','0','CO0')," _
                                    & " ('43','01','1','CO0')," _
                                    & " ('43','01','0','CO0')," _
                                    & " ('43','04','1','CO2')," _
                                    & " ('43','04','0','CO2')," _
                                    & " ('44','01','1','CO2')," _
                                    & " ('44','01','0','CO2')," _
                                    & " ('44','04','1','CO2')," _
                                    & " ('44','04','0','CO2')," _
                                    & " ('44','05','1','CO2')," _
                                    & " ('44','05','0','CO2')," _
                                    & " ('46','04','1','CO1')," _
                                    & " ('47','04','0','CO1')," _
                                    & " ('48','01','1','CO3')," _
                                    & " ('48','01','0','CO3')," _
                                    & " ('48','04','1','CO3')," _
                                    & " ('48','04','0','CO3')," _
                                    & " ('48','05','1','CO3')," _
                                    & " ('48','05','0','CO3')," _
                                    & " ('49','01','1','CO3')," _
                                    & " ('49','01','0','CO3')," _
                                    & " ('49','04','1','CO3')," _
                                    & " ('49','04','0','CO3')," _
                                    & " ('49','05','1','CO3')," _
                                    & " ('49','05','0','CO3')," _
                                    & " ('50','--','1','DSC')," _
                                    & " ('50','--','0','DSC')," _
                                    & " ('51','01','1','OU')," _
                                    & " ('51','01','0','OU')," _
                                    & " ('51','03','1','OU')," _
                                    & " ('51','03','0','OU')," _
                                    & " ('51','07','1','OU')," _
                                    & " ('51','07','0','OU')," _
                                    & " ('51','08','1','OU')," _
                                    & " ('51','08','0','OU')," _
                                    & " ('51','09','1','OU')," _
                                    & " ('51','09','0','OU')," _
                                    & " ('52','01','1','OU')," _
                                    & " ('52','01','0','OU')," _
                                    & " ('52','04','1','OU')," _
                                    & " ('52','04','0','OU')," _
                                    & " ('53','05','1','NR5')," _
                                    & " ('53','05','0','NR5')"
                End Select
                MySQL_cmd(Conn, cmdTXT)
            End If
        End If
        Select Case cbTipoCentral.Text
            Case "E"
                If Me.cbCriarTabelaX_rota_saida.Checked Then
                    cmdTXT = "CREATE TABLE X_rota_saida (" _
                            & "DATA datetime NOT NULL," _
                            & "HORA tinyint(2) unsigned NOT NULL default 0," _
                            & "R_SAI char(4) NOT NULL default 0," _
                            & "CO0 int(7) default 0," _
                            & "CO1 int(7) default 0," _
                            & "CO2 int(7) default 0," _
                            & "CO3 int(7) default 0," _
                            & "DSC int(7) default 0," _
                            & "LO int(7) default 0," _
                            & "NR1 int(7) default 0," _
                            & "NR5 int(7) default 0," _
                            & "OK1 int(7) default 0," _
                            & "OK5 int(7) default 0," _
                            & "OU int(7) default 0," _
                            & "PRIMARY KEY  (DATA, HORA, R_SAI)" _
                            & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
                    CriarTabela(cbBilhetador.Text, "X_rota_saida", cmdTXT, lstMsg)
                End If
                If Me.cbCriarTabelaX_rota_entrada.Checked Then
                    cmdTXT = "CREATE TABLE X_rota_entrada (" _
                            & "DATA datetime NOT NULL," _
                            & "HORA tinyint(2) unsigned NOT NULL default 0," _
                            & "R_ENT char(4) NOT NULL default 0," _
                            & "CO0 int(7) default 0," _
                            & "CO1 int(7) default 0," _
                            & "CO2 int(7) default 0," _
                            & "CO3 int(7) default 0," _
                            & "DSC int(7) default 0," _
                            & "LO int(7) default 0," _
                            & "NR1 int(7) default 0," _
                            & "NR5 int(7) default 0," _
                            & "OK1 int(7) default 0," _
                            & "OK5 int(7) default 0," _
                            & "OU int(7) default 0," _
                            & "PRIMARY KEY  (DATA, HORA, R_ENT)" _
                            & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
                    CriarTabela(cbBilhetador.Text, "X_rota_entrada", cmdTXT, lstMsg)
                End If
            Case "H"
                If Me.cbCriarTabelaX_rota_saida.Checked Then
                    cmdTXT = "CREATE TABLE X_rota_saida (" _
                            & "DATA datetime NOT NULL," _
                            & "HORA tinyint(2) unsigned NOT NULL default 0," _
                            & "R_SAI char(6) NOT NULL default 0," _
                            & "CO0 int(7) default 0," _
                            & "CO1 int(7) default 0," _
                            & "CO2 int(7) default 0," _
                            & "CO3 int(7) default 0," _
                            & "DSC int(7) default 0," _
                            & "LO int(7) default 0," _
                            & "NR1 int(7) default 0," _
                            & "NR5 int(7) default 0," _
                            & "OK1 int(7) default 0," _
                            & "OK5 int(7) default 0," _
                            & "OU int(7) default 0," _
                            & "PRIMARY KEY  (DATA, HORA, R_SAI)" _
                            & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
                    CriarTabela(cbBilhetador.Text, "X_rota_saida", cmdTXT, lstMsg)
                End If
                If Me.cbCriarTabelaX_rota_entrada.Checked Then
                    cmdTXT = "CREATE TABLE X_rota_entrada (" _
                            & "DATA datetime NOT NULL," _
                            & "HORA tinyint(2) unsigned NOT NULL default 0," _
                            & "R_ENT char(6) NOT NULL default 0," _
                            & "CO0 int(7) default 0," _
                            & "CO1 int(7) default 0," _
                            & "CO2 int(7) default 0," _
                            & "CO3 int(7) default 0," _
                            & "DSC int(7) default 0," _
                            & "LO int(7) default 0," _
                            & "NR1 int(7) default 0," _
                            & "NR5 int(7) default 0," _
                            & "OK1 int(7) default 0," _
                            & "OK5 int(7) default 0," _
                            & "OU int(7) default 0," _
                            & "PRIMARY KEY  (DATA, HORA, R_ENT)" _
                            & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
                    CriarTabela(cbBilhetador.Text, "X_rota_entrada", cmdTXT, lstMsg)
                End If
            Case "N"
                If Me.cbCriarTabelaX_rota_saida.Checked Then
                    cmdTXT = "CREATE TABLE X_rota_saida (" _
                            & "DATA datetime NOT NULL," _
                            & "HORA tinyint(2) unsigned NOT NULL default 0," _
                            & "R_SAI char(8) NOT NULL default 0," _
                            & "CO0 int(7) default 0," _
                            & "CO1 int(7) default 0," _
                            & "CO2 int(7) default 0," _
                            & "CO3 int(7) default 0," _
                            & "DSC int(7) default 0," _
                            & "LO int(7) default 0," _
                            & "NR1 int(7) default 0," _
                            & "NR5 int(7) default 0," _
                            & "OK1 int(7) default 0," _
                            & "OK5 int(7) default 0," _
                            & "OU int(7) default 0," _
                            & "PRIMARY KEY  (DATA, HORA, R_SAI)" _
                            & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
                    CriarTabela(cbBilhetador.Text, "X_rota_saida", cmdTXT, lstMsg)
                End If
                If Me.cbCriarTabelaX_rota_entrada.Checked Then
                    cmdTXT = "CREATE TABLE X_rota_entrada (" _
                            & "DATA datetime NOT NULL," _
                            & "HORA tinyint(2) unsigned NOT NULL default 0," _
                            & "R_ENT char(8) NOT NULL default 0," _
                            & "CO0 int(7) default 0," _
                            & "CO1 int(7) default 0," _
                            & "CO2 int(7) default 0," _
                            & "CO3 int(7) default 0," _
                            & "DSC int(7) default 0," _
                            & "LO int(7) default 0," _
                            & "NR1 int(7) default 0," _
                            & "NR5 int(7) default 0," _
                            & "OK1 int(7) default 0," _
                            & "OK5 int(7) default 0," _
                            & "OU int(7) default 0," _
                            & "PRIMARY KEY  (DATA, HORA, R_ENT)" _
                            & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
                    CriarTabela(cbBilhetador.Text, "X_rota_entrada", cmdTXT, lstMsg)
                End If
        End Select
        If Me.cbCriarTabelaX_cliente_destinado.Checked Then
            cmdTXT = "CREATE TABLE X_cliente_destinado (" _
                    & "DATA datetime NOT NULL," _
                    & "HORA tinyint(2) unsigned NOT NULL default 0," _
                    & "COD_CLI int(5) NOT NULL default 0," _
                    & "CO0 int(7) default 0," _
                    & "CO1 int(7) default 0," _
                    & "CO2 int(7) default 0," _
                    & "CO3 int(7) default 0," _
                    & "DSC int(7) default 0," _
                    & "LO int(7) default 0," _
                    & "NR1 int(7) default 0," _
                    & "NR5 int(7) default 0," _
                    & "OK1 int(7) default 0," _
                    & "OK5 int(7) default 0," _
                    & "OU int(7) default 0," _
                    & "PRIMARY KEY  (DATA, HORA, COD_CLI)" _
                    & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
            CriarTabela(cbBilhetador.Text, "X_cliente_destinado", cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelaX_cliente_originado.Checked Then
            cmdTXT = "CREATE TABLE X_cliente_originado (" _
                        & "DATA datetime NOT NULL," _
                        & "HORA tinyint(2) unsigned NOT NULL default 0," _
                        & "COD_CLI int(5) NOT NULL default 0," _
                        & "CO0 int(7) default 0," _
                        & "CO1 int(7) default 0," _
                        & "CO2 int(7) default 0," _
                        & "CO3 int(7) default 0," _
                        & "DSC int(7) default 0," _
                        & "LO int(7) default 0," _
                        & "NR1 int(7) default 0," _
                        & "NR5 int(7) default 0," _
                        & "OK1 int(7) default 0," _
                        & "OK5 int(7) default 0," _
                        & "OU int(7) default 0," _
                        & "PRIMARY KEY  (DATA, HORA, COD_CLI)" _
                        & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
            CriarTabela(cbBilhetador.Text, "X_cliente_originado", cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelaX_Grupo.Checked Then
            cmdTXT = "CREATE TABLE X_Grupo (" _
                    & "DATA datetime NOT NULL," _
                    & "HORA tinyint(2) unsigned NOT NULL default 0," _
                    & "GRUPO varchar(25) NOT NULL," _
                    & "CO0 int(7) default 0," _
                    & "CO1 int(7) default 0," _
                    & "CO2 int(7) default 0," _
                    & "CO3 int(7) default 0," _
                    & "DSC int(7) default 0," _
                    & "LO int(7) default 0," _
                    & "NR1 int(7) default 0," _
                    & "NR5 int(7) default 0," _
                    & "OK1 int(7) default 0," _
                    & "OK5 int(7) default 0," _
                    & "OU int(7) default 0," _
                    & "PRIMARY KEY  (DATA, HORA, GRUPO)" _
                    & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
            CriarTabela(cbBilhetador.Text, "X_Grupo", cmdTXT, lstMsg)

        End If
        If Me.cbCriarTabelaX_ASS_A.Checked Then
            cmdTXT = "CREATE TABLE X_ASS_A (" _
                    & "DATA datetime NOT NULL," _
                    & "ASS_A varchar(16) NOT NULL," _
                    & "TCH int(9) default 0," _
                    & "CO0 int(7) default 0," _
                    & "CO1 int(7) default 0," _
                    & "CO2 int(7) default 0," _
                    & "CO3 int(7) default 0," _
                    & "DSC int(7) default 0," _
                    & "LO int(7) default 0," _
                    & "NR1 int(7) default 0," _
                    & "NR5 int(7) default 0," _
                    & "OK1 int(7) default 0," _
                    & "OK5 int(7) default 0," _
                    & "OU int(7) default 0," _
                    & "PRIMARY KEY  (DATA, ASS_A)" _
                    & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
            CriarTabela(cbBilhetador.Text, "X_ASS_A", cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelaX_ASS_B.Checked Then
            cmdTXT = "CREATE TABLE X_ASS_B (" _
                    & "DATA datetime NOT NULL," _
                    & "ASS_B varchar(16) NOT NULL," _
                    & "TCH int(9) default 0," _
                    & "CO0 int(7) default 0," _
                    & "CO1 int(7) default 0," _
                    & "CO2 int(7) default 0," _
                    & "CO3 int(7) default 0," _
                    & "DSC int(7) default 0," _
                    & "LO int(7) default 0," _
                    & "NR1 int(7) default 0," _
                    & "NR5 int(7) default 0," _
                    & "OK1 int(7) default 0," _
                    & "OK5 int(7) default 0," _
                    & "OU int(7) default 0," _
                    & "PRIMARY KEY  (DATA, ASS_B)" _
                    & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
            CriarTabela(cbBilhetador.Text, "X_ASS_B", cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelaX_EOS.Checked Then
            cmdTXT = "CREATE TABLE X_EOS (" _
                    & "DATA datetime NOT NULL," _
                    & "HORA tinyint(2) unsigned NOT NULL default 0," _
                    & "EOS varchar(4) NOT NULL," _
                    & "TCH int(9) default 0," _
                    & "CO0 int(7) default 0," _
                    & "CO1 int(7) default 0," _
                    & "CO2 int(7) default 0," _
                    & "CO3 int(7) default 0," _
                    & "DSC int(7) default 0," _
                    & "LO int(7) default 0," _
                    & "NR1 int(7) default 0," _
                    & "NR5 int(7) default 0," _
                    & "OK1 int(7) default 0," _
                    & "OK5 int(7) default 0," _
                    & "OU int(7) default 0," _
                    & "PRIMARY KEY  (DATA, HORA, EOS)" _
                    & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
            CriarTabela(cbBilhetador.Text, "X_EOS", cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelagrupos.Checked Then
            cmdTXT = "CREATE TABLE grupos (" _
                    & "ID int(10) unsigned NOT NULL auto_increment," _
                    & "GRUPO varchar(25) NOT NULL," _
                    & "MASCARA_ASS_A varchar(13) NOT NULL, " _
                    & "MASCARA_CSP varchar(2) NOT NULL, " _
                    & "MASCARA_ASS_B varchar(16) NOT NULL, " _
                    & "MASCARA_ROTA_E varchar(12) default NULL, " _
                    & "MASCARA_ROTA_S varchar(12) default NULL, " _
                    & "PRIMARY KEY  (ID) " _
                    & ") ENGINE=MyISAM DEFAULT CHARSET=latin1;"

            CriarTabela(cbBilhetador.Text, "grupos", cmdTXT, lstMsg)
        End If

        If Me.cbCriarTabela_exrop.Checked Then
            Select Case cbTipoCentral.Text
                Case "E"
                    cmdTXT = "CREATE TABLE _exrop (" _
                            & "BILHETADOR varchar(5) default NULL," _
                            & "ROTA varchar(10) default NULL," _
                            & "MA varchar(21) default NULL," _
                            & "BO varchar(3) default NULL," _
                            & "RIN varchar(4) default NULL," _
                            & "CO varchar(3) default NULL," _
                            & "EO varchar(3) default NULL," _
                            & "DETY varchar(9) default NULL," _
                            & "PRI varchar(2) default NULL," _
                            & "EC varchar(2) default NULL," _
                            & "FNC varchar(1) default NULL," _
                            & "DPC varchar(6) default NULL," _
                            & "R varchar(9) default NULL," _
                            & "R1 varchar(9) default NULL," _
                            & "descFNC varchar(3) default NULL," _
                            & "KEY Index_RIN (RIN)" _
                            & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
                    CriarTabela(cbBilhetador.Text, "_exrop", cmdTXT, lstMsg)
                Case "H"
                    cmdTXT = "CREATE TABLE LST_TG (" _
                            & "`tg_Number` int(5) unsigned NOT NULL default '0'," _
                            & "`tg_name` varchar(25) default NULL," _
                            & "PRIMARY KEY  (`tg_Number`)" _
                            & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
                    CriarTabela(cbBilhetador.Text, "LST TG", cmdTXT, lstMsg)
            End Select

        End If
        If Me.cbCriarTabelaEventos.Checked Then
            cmdTXT = "CREATE TABLE Eventos (" _
                    & "DATA datetime NOT NULL," _
                    & "TIPO varchar(15) default NULL," _
                    & "EVENTO varchar(2048) default NULL" _
                    & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
            CriarTabela(cbBilhetador.Text, "Eventos", cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelaPpis.Checked Then
            cmdTXT = "CREATE TABLE PPIs (" _
                    & "`ID` int(5) unsigned NOT NULL auto_increment," _
                    & "`PPI` varchar(20) NOT NULL," _
                    & "`RIN_E` varchar(5) NOT NULL," _
                    & "`RIN_S` varchar(5) NOT NULL," _
                    & "PRIMARY KEY  (`ID`)" _
                    & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
            CriarTabela(cbBilhetador.Text, "PPIs", cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelaPrefixos.Checked Then
            cmdTXT = "CREATE TABLE ppi_prefixo (" _
                    & "`prefixo` varchar(16) NOT NULL," _
                    & "`cod_ppi` int(5) default '0'," _
                    & "PRIMARY KEY  (`prefixo`)" _
                    & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
            CriarTabela(cbBilhetador.Text, "PPI_Prefixo", cmdTXT, lstMsg)
        End If
        If Me.cbCriarTabelaX_PPI.Checked Then
            cmdTXT = "CREATE TABLE x_ppi (" _
                    & "DATA datetime NOT NULL," _
                    & "`COD_PPI` int(5)," _
                    & "`NA ROTA` int(5)," _
                    & "`FORA DA ROTA` int(5)," _
                    & "PRIMARY KEY  (`DATA`, `COD_PPI`)" _
                    & ") ENGINE=MyISAM DEFAULT CHARSET=latin1"
            CriarTabela(cbBilhetador.Text, "x_ppi", cmdTXT, lstMsg)
        End If

    End Sub
    Private Sub PanelOK1Cor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1OKCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel1OKCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub PanelCO1Cor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1PABCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel1PABCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub PanelCOCor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1COCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel1COCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub Panel2OKCor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2OKCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel2OKCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub Panel3OKCor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3OKCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel3OKCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub Panel2PABCor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2PABCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel2PABCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub Panel3PABCor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3PABCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel3PABCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub Panel2COCor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2COCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel2COCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub Panel3COCor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3COCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel3COCor.BackColor = Me.ColorDialog1.Color
    End Sub
    Private Sub Panel1DSCCor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1DSCCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel1DSCCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub Panel2DSCCor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2DSCCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel2DSCCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub Panel3DSCCor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3DSCCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel3DSCCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub Panel1OUCor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1OUCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel1OUCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub Panel2OUCor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel2OUCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel2OUCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub Panel3OUCor_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel3OUCor.MouseDoubleClick
        Me.ColorDialog1.ShowDialog()
        Me.Panel3OUCor.BackColor = Me.ColorDialog1.Color
    End Sub

    Private Sub btnReconectar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReconectar.Click
        'Preparar para criar tabelas

        Try
            'Conn = MySQL_Conectar()
            Me.Text = "Manutenção - " & Me.cbBilhetador.Text
            MsgBox(" Conectado com sucesso ao bilhetador: " & Me.cbBilhetador.Text & vbCrLf _
                 & "Todos Formulários serão fechados.", MsgBoxStyle.Information)
            My.Forms.frmApagaRegistros.Close()
            My.Forms.frmClientes.Close()
            My.Forms.frmDumpShadow.Close()
            My.Forms.frmEventos.Close()
            My.Forms.frmGeraHistorico.Close()
            My.Forms.frmGrupos.Close()
            My.Forms.frmHistorico.Close()
            My.Forms.frmListaCdrs.Close()
            My.Forms.frmListaCDRs_H.Close()
            My.Forms.frmListaCdrs_N.Close()
            My.Forms.frmResumo.Close()
            Me.Hide()
        Catch ex As Exception
            MsgBox(" Erro ao conectar ao BD: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnGravar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGravar.Click
        gravaArquivoini()
        MsgBox("Arquivo de Configuração Gravado.")
    End Sub

    Private Sub btnTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodas.Click
        Me.cbCriarTabelalogAtividade.Checked = True
        Me.cbCriarTabelalog.Checked = True
        Me.cbCriarTabelaclientes.Checked = True
        Me.cbCriarTabelacliente_terminal.Checked = True
        Me.cbCriarTabelaCDRs_Sel.Checked = True
        Me.cbCriarTabelaCDRs_Hoje.Checked = True
        Me.cbCriarTabelatabclassificacao.Checked = True
        Me.cbCriarTabelaX_ASS_A.Checked = True
        Me.cbCriarTabelaX_ASS_B.Checked = True
        Me.cbCriarTabelaX_cliente_destinado.Checked = True
        Me.cbCriarTabelaX_cliente_originado.Checked = True
        Me.cbCriarTabelaX_Grupo.Checked = True
        Me.cbCriarTabelaX_EOS.Checked = True
        Me.cbCriarTabelaX_rota_entrada.Checked = True
        Me.cbCriarTabelaX_rota_saida.Checked = True
        Me.cbCriarTabela_exrop.Checked = True
        Me.cbCriarTabelagrupos.Checked = True
        Me.cbCriarTabelaEventos.Checked = True
        Me.cbCriarTabelaPpis.Checked = True
        Me.cbCriarTabelaPrefixos.Checked = True
        Me.cbCriarTabelaX_PPI.Checked = True

    End Sub

    Private Sub btnNenhum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNenhum.Click
        Me.cbCriarTabelalogAtividade.Checked = False
        Me.cbCriarTabelalog.Checked = False
        Me.cbCriarTabelaclientes.Checked = False
        Me.cbCriarTabelacliente_terminal.Checked = False
        Me.cbCriarTabelaCDRs_Sel.Checked = False
        Me.cbCriarTabelaCDRs_Hoje.Checked = False
        Me.cbCriarTabelatabclassificacao.Checked = False
        Me.cbCriarTabelaX_ASS_A.Checked = False
        Me.cbCriarTabelaX_ASS_B.Checked = False
        Me.cbCriarTabelaX_cliente_destinado.Checked = False
        Me.cbCriarTabelaX_cliente_originado.Checked = False
        Me.cbCriarTabelaX_Grupo.Checked = False
        Me.cbCriarTabelaX_EOS.Checked = False
        Me.cbCriarTabelaX_rota_entrada.Checked = False
        Me.cbCriarTabelaX_rota_saida.Checked = False
        Me.cbCriarTabela_exrop.Checked = False
        Me.cbCriarTabelagrupos.Checked = False
        Me.cbCriarTabelaEventos.Checked = False
        Me.cbCriarTabelaPpis.Checked = False
        Me.cbCriarTabelaPrefixos.Checked = False
        Me.cbCriarTabelaX_PPI.Checked = False
    End Sub

    Private Sub cbSenhaMySql_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbSenhaMySql.SelectedIndexChanged
        txtSenhaMySql.Text = cbSenhaMySql.Text
    End Sub

    Private Sub txtSenhaMySql_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSenhaMySql.TextChanged
        cbSenhaMySql.Text = txtSenhaMySql.Text
        If cbBilhetador.SelectedIndex <> -1 Then cbSenhaMySql.Items(cbBilhetador.SelectedIndex) = cbSenhaMySql.Text
    End Sub

    Private Sub cbServidorMySql_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbServidorMySql.TextUpdate
        If cbBilhetador.SelectedIndex <> -1 Then cbServidorMySql.Items(cbBilhetador.SelectedIndex) = cbServidorMySql.Text
    End Sub

    Private Sub cbUsuarioMySql_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbUsuarioMySql.TextUpdate
        If cbBilhetador.SelectedIndex <> -1 Then cbUsuarioMySql.Items(cbBilhetador.SelectedIndex) = cbUsuarioMySql.Text
    End Sub

    Private Sub cbTipoCentral_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbTipoCentral.TextUpdate
        If cbBilhetador.SelectedIndex <> -1 Then cbTipoCentral.Items(cbBilhetador.SelectedIndex) = cbTipoCentral.Text
    End Sub

    Private Sub btnNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNovo.Click
        Me.cbBilhetador.Items.Add(Me.cbBilhetador.Text)
        Me.cbBilDumpShadow.Items.Add(Me.cbBilhetador.Text)
        Me.cbBilDumpShadow.Text = Me.cbBilhetador.Text
        Me.cbServidorMySql.Items.Add("127.0.0.1")
        Me.cbUsuarioMySql.Items.Add("root")
        Me.cbSenhaMySql.Items.Add("xxxxxx")
        Me.cbTipoCentral.Items.Add("E")
    End Sub

    Private Sub btnCarregaINI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregaINI.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            CarregaINI(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub btnCriarNovosCampos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriarNovosCampos.Click
        Dim tabela As String = "cdrs_" & Format(dpCriarNovosCampos.Value, "yyyyMMdd")
        Dim cmdTXT As String

        If Not TabelaExiste(Conn, txtBancoMySql.Text, tabela) Then
            MsgBox("A tabela " & tabela & " não existe.")
            Exit Sub
        End If
        Cursor = Cursors.WaitCursor
        Select Case cbTipoCentral.Text
            Case "E", "N"
                cmdTXT = "ALTER TABLE `" & tabela & "` ADD `NR_DISCADO` VARCHAR(22) NULL"
                MySQL_cmd(Conn, cmdTXT)
                cmdTXT = "ALTER TABLE `" & tabela & "` ADD `RN2` VARCHAR(8) NULL"
                MySQL_cmd(Conn, cmdTXT)
                cmdTXT = "ALTER TABLE `" & tabela & "` ADD `RN3` VARCHAR(2) NULL"
                MySQL_cmd(Conn, cmdTXT)
                MsgBox("Campos criados.")
            Case "H"
                cmdTXT = "ALTER TABLE `" & tabela & "` ADD `RN2` VARCHAR(8) NULL"
                MySQL_cmd(Conn, cmdTXT)
                cmdTXT = "ALTER TABLE `" & tabela & "` ADD `RN3` VARCHAR(2) NULL"
                MySQL_cmd(Conn, cmdTXT)
                MsgBox("Campos criados.")
        End Select
        Cursor = Cursors.Default
    End Sub

    Private Sub frmManutencao_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
        e.Cancel = True
    End Sub
End Class