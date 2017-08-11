Imports System.Security.Cryptography
Imports System.IO
Imports System.text

Public Class frmConfiguracao
    Private WithEvents oSpyCdr As cSpyCdr = New cSpyCdr()

    Dim SQL As String
    'define a string de conexao
    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer
    Dim myKey As String
    Dim des As New TripleDESCryptoServiceProvider()
    Dim hashmd5 As New MD5CryptoServiceProvider()
    'define os objetos connecton, command e dataadapter
    Dim strsql As String
    Dim dbConn As OdbcConnection
    Dim cmd As OdbcCommand
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

        strsql = "Driver={MySQL ODBC 3.51 Driver}" _
        & ";Server=" & Me.txtServidorMySql.Text _
        & ";Database=mysql" _
        & ";uid=" & Me.txtUsuarioMySql.Text _
        & ";pwd=" & Me.txtSenhaMySql.Text & ";"

        dbConn = New OdbcConnection(strsql)

        If Not oSpyCdr.BancoExiste(dbConn, Me.txtBancoMySql.Text) Then
            If MsgBox("Não existe banco para o bilhetador [" _
                 & Me.txtBancoMySql.Text & "]. Posso Criá-lo?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                oSpyCdr.CriarBanco(dbConn, Me.cbBilhetador.Text)
                'Preparar para criar tabelas
                strsql = "Driver={MySQL ODBC 3.51 Driver}" _
                        & ";Server=" & Me.txtServidorMySql.Text _
                        & ";Database=" & Me.txtBancoMySql.Text _
                        & ";uid=" & Me.txtUsuarioMySql.Text _
                        & ";pwd=" & Me.txtSenhaMySql.Text & ";"

                dbConn = New OdbcConnection(strsql)
                dbConn.Open()
                oSpyCdr.CriarTabelas(Me.cbBilhetador.Text, Me.lstMsg)
            End If
        End If

    End Sub
    Sub CarregaINI()
        Dim nome_arquivo_ini As String = nomeArquivoINI()
        Dim idxBIL, P1, P2 As Integer
        Dim flBIL As String

        'Carrega Configurações no .INI
        If Not File.Exists(nome_arquivo_ini) Then
            MsgBox("Será carregado os valores padrão do sistema.")
        End If

        'Carregar BILHETADORES
        idxBIL = 1
        flBIL = LeArquivoINI(nome_arquivo_ini, "BILHETADORES", Format(idxBIL, "00"), "No")
        While (flBIL <> "No")
            P1 = flBIL.LastIndexOf("=") + 1
            P2 = flBIL.LastIndexOf("(") - 1
            Me.cbBilhetador.Items.Add(flBIL.Trim.Substring(P1, P2 - P1))
            P1 = flBIL.LastIndexOf("(") + 1
            Me.cbBilDumpShadow.Items.Add(flBIL.Substring(P1, flBIL.Length - P1 - 1))
            idxBIL = idxBIL + 1
            flBIL = LeArquivoINI(nome_arquivo_ini, "BILHETADORES", Format(idxBIL, "00"), "No")
        End While

        Me.cbBilhetador.Text = LeArquivoINI(nome_arquivo_ini, "GERAL", "Bilhetador", "AJB")
        Me.cbBilDumpShadow.Text = LeArquivoINI(nome_arquivo_ini, "GERAL", "BilDumpShadow", "AJUB")
        Me.txtPastaDeTrabalho.Text = LeArquivoINI(nome_arquivo_ini, "GERAL", "PastaDeTrabalho", "c:\temp\")

        Me.txtServidorMySql.Text = LeArquivoINI(nome_arquivo_ini, "MySQL", "Servidor", "10.14.83.164")
        Me.txtUsuarioMySql.Text = LeArquivoINI(nome_arquivo_ini, "MySQL", "Usuario", "root")
        Me.txtSenhaMySql.Text = DeCifra(LeArquivoINI(nome_arquivo_ini, "MySQL", "Senha", "DuwSSJ6fgs8="))
        Me.txtBancoMySql.Text = LeArquivoINI(nome_arquivo_ini, "MySQL", "Banco", "SpyCdr_ajb")

        Me.txtServidorFTP.Text = LeArquivoINI(nome_arquivo_ini, "FTP", "Servidor", "10.13.24.30")
        Me.txtUsuarioFTP.Text = LeArquivoINI(nome_arquivo_ini, "FTP", "Usuario", "gouveia")
        Me.txtSenhaFTP.Text = DeCifra(LeArquivoINI(nome_arquivo_ini, "FTP", "Senha", "DuwSSJ6fgs8="))
        Me.txtPastaRemotaFTP.Text = LeArquivoINI(nome_arquivo_ini, "FTP", "PastaRemota", "/bmp/coletados/AJUB/")

        'Me.txtBancoMySql.Text = NomeBanco & Me.cbBilhetador.Text

        VerificaBanco()

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
            WritePrivateProfileString("BILHETADORES", Format(idxBil, "00"), _
                          Me.cbBilhetador.Items(idxBil - 1) & " (" & Me.cbBilDumpShadow.Items(idxBil - 1) & ")", nome_arquivo_ini)
        Next

        valorSenha = Cifra(Me.txtSenhaMySql.Text)

        WritePrivateProfileString("GERAL", "Bilhetador", Me.cbBilhetador.Text, nome_arquivo_ini)
        WritePrivateProfileString("GERAL", "BilDumpShadow", Me.cbBilDumpShadow.Text, nome_arquivo_ini)
        WritePrivateProfileString("GERAL", "PastaDeTrabalho", Me.txtPastaDeTrabalho.Text, nome_arquivo_ini)

        WritePrivateProfileString("MySQL", "Servidor", Me.txtServidorMySql.Text, nome_arquivo_ini)
        WritePrivateProfileString("MySQL", "Usuario", Me.txtUsuarioMySql.Text, nome_arquivo_ini)
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
        Me.txtBancoMySql.Text = "SpyCdr_" & Me.cbBilhetador.Text
        Me.txtPastaRemotaFTP.Text = "/bmp/coletados/" & Me.cbBilDumpShadow.Text & "/"

        VerificaBanco()

    End Sub
    Private Sub frmConfiguracao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'define o dataset
        Dim ds As DataSet = New DataSet()

        strsql = "Driver={MySQL ODBC 3.51 Driver}" _
                & ";Server=" & Me.txtServidorMySql.Text _
                & ";Database=" & Me.txtBancoMySql.Text _
                & ";uid=" & Me.txtUsuarioMySql.Text _
                & ";pwd=" & Me.txtSenhaMySql.Text & ";"

        dbConn = New OdbcConnection(strsql)

        Try
            dbConn.Open()
        Catch ex As OdbcException
            If ex.ErrorCode = -2146232009 Then

            End If
        End Try

    End Sub

    Private Sub btnCriarTabelas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriarTabelas.Click

        strsql = "Driver={MySQL ODBC 3.51 Driver}" _
                & ";Server=" & Me.txtServidorMySql.Text _
                & ";Database=" & Me.txtBancoMySql.Text _
                & ";uid=" & Me.txtUsuarioMySql.Text _
                & ";pwd=" & Me.txtSenhaMySql.Text & ";"

        dbConn = New OdbcConnection(strsql)

        oSpyCdr = New cSpyCdr()
        oSpyCdr.CriarTabelas(Me.cbBilhetador.Text, Me.lstMsg)
    End Sub
End Class