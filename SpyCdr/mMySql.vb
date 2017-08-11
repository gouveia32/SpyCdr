Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Imports System.Threading.Thread
Imports System.Globalization

Module mMySql
    Public Conn As MySqlConnection

    Public Function MySQL_Conn() As MySqlConnection
        If Not Conn Is Nothing Then Return Conn
        Try
            'Connect to database
            MySQL_Conn = New MySqlConnection
            MySQL_Conn.ConnectionString = My.Settings.ConnectionString
            MySQL_Conn = New MySqlConnection(MySQL_Conn.ConnectionString)

            MySQL_Conn.Open()
            My.Settings.conectado = True
        Catch e As Exception

            My.Settings.conectado = False
            MySQL_Conn = Nothing
        End Try
    End Function

    Public Function MySQL_Select(ByRef MySQL_Conn As MySqlConnection, ByVal strSQL As String) As DataTable

        Dim da As New MySqlDataAdapter(strSQL, Conn)

        MySQL_Select = New DataTable
        '---preenche o dataset--
        da.Fill(MySQL_Select)
        '---fecha a Conn---
        'MySQL_Conn.Close()
    End Function

    Public Sub MySQL_cmd(ByRef MySQL_Conn As MySqlConnection, ByVal strSQL As String)
        'Update data
        Dim comm As MySqlCommand = New MySqlCommand()

        With comm
            .CommandType = CommandType.Text
            .CommandText = strSQL
            .Connection = MySQL_Conn
        End With
        'MySQL_Conn.Open()
        comm.ExecuteNonQuery() 'Executa SQL
        'MySQL_Conn.Close()

    End Sub

    Public Enum xlsOption
        xlsSaveAs
        xlsOpen
    End Enum

    Public Sub ExportToExcel(ByVal dgvName As DataGridView, ByVal [option] As xlsOption, Optional ByVal fileName As String = "", Optional ByVal titulo As String = "")
        Dim objExcelApp As New Excel.Application()
        Dim objExcelBook As Excel.Workbook
        Dim objExcelSheet As Excel.Worksheet

        Try
            ' Verifica se foi seleccionada a opção xlsSaveAs e não foi indicado ficheiro
            If [option] = xlsOption.xlsSaveAs And fileName = String.Empty Then
                MessageBox.Show("É necessário indicar um nome para o ficheiro a gravar ...")
                Exit Sub
            End If

            ' Altera o tipo/localização para Inglês. Existe incompatibilidade 
            ' entre algumas versões de Excel vs Sistema Operativo
            Dim oldCI As CultureInfo = CurrentThread.CurrentCulture
            CurrentThread.CurrentCulture = New CultureInfo("en-US")

            ' Adiciona um workbook e activa a worksheet corrente
            objExcelBook = objExcelApp.Workbooks.Add
            objExcelSheet = CType(objExcelBook.Worksheets(1), Excel.Worksheet)

            objExcelSheet.Name = titulo

            ' Ciclo nos cabeçalhos para escrever os títulos a bold/negrito
            Dim dgvColumnIndex As Int16 = 1
            For Each col As DataGridViewColumn In dgvName.Columns
                objExcelSheet.Cells(1, dgvColumnIndex) = col.HeaderText
                objExcelSheet.Cells(1, dgvColumnIndex).Font.Bold = True
                dgvColumnIndex += 1
            Next

            ' Ciclo nas linhas/células
            Dim dgvRowIndex As Integer = 2
            For Each row As DataGridViewRow In dgvName.Rows

                Dim dgvCellIndex As Integer = 1
                For Each cell As DataGridViewCell In row.Cells
                    If Not cell.Value Is Nothing Then
                        objExcelSheet.Cells(dgvRowIndex, dgvCellIndex) = cell.Value.ToString
                    End If
                    dgvCellIndex += 1
                Next

                dgvRowIndex += 1
            Next

            ' Ajusta o largura das colunas automáticamente
            objExcelSheet.Columns.AutoFit()

            ' Caso a opção seja gravar (xlsSaveAs) grava o ficheiro e fecha
            ' o Workbook/Excel. Caso contrário (xlsOpen) abre o Excel
            If [option] = xlsOption.xlsSaveAs Then
                objExcelBook.SaveAs(fileName)
                objExcelBook.Close()
                objExcelApp.Quit()

                MessageBox.Show("Ficheiro exportado com sucesso para: " + fileName)
            Else
                objExcelApp.Visible = True
            End If

            ' Altera a tipo/localização para actual
            CurrentThread.CurrentCulture = oldCI

        Catch ex As Exception
            MessageBox.Show("Erro não identificado. Mensagem original:" + vbNewLine + ex.Message)

        Finally
            objExcelSheet = Nothing
            objExcelBook = Nothing
            objExcelApp = Nothing

            ' O GC(garbage collector) recolhe a memória não usada pelo sistema. 
            ' O método Collect() força a recolha e a opção WaitForPendingFinalizers 
            ' espera até estar completo. Desta forma o EXCEL.EXE não fica no 
            ' task manager(gestor tarefas) ocupando memória desnecessáriamente
            GC.Collect()
            GC.WaitForPendingFinalizers()
            'm_Search.Close()
            'Cursor = Cursors.Default
        End Try

    End Sub

    'define os objetos connecton, command e dataadapter
    Dim strsql As String

    Dim registrosAfetados As Integer
    Dim IndicadorNome() As String = {"CO0", "CO1", "CO2", "CO3", "DSC", "LO", "NR1", "NR5", "OK1", "OK5", "OU"}
    Public Function TabelaExiste(ByVal conexaoSQL As MySqlConnection, ByVal nomeBanco As String, ByVal nomeTabela As String) As Boolean
        Dim tabela As New DataTable
        Dim criterioSQL As String

        criterioSQL = "SELECT * " _
                    & "FROM INFORMATION_SCHEMA.TABLES " _
                    & "WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA = '" & nomeBanco _
                    & "' ORDER BY TABLE_TYPE"
        Try
            tabela = MySQL_Select(conexaoSQL, criterioSQL)

            For Each dr As DataRow In tabela.Rows
                criterioSQL = dr("TABLE_NAME").ToString
                If dr("TABLE_NAME").ToString.ToUpper = nomeTabela.ToUpper Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            MessageBox.Show("ERRO " & ex.Message, "Verifica tabela")
            Return False
        End Try

    End Function

    Public Function BancoExiste(ByVal conexaoSQL As MySqlConnection, ByVal nomeBanco As String) As Boolean
        Dim tabela As New DataTable
        Dim criterioSQL As String

        criterioSQL = "SELECT * " _
                    & "FROM INFORMATION_SCHEMA.TABLES " _
                    & "WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_SCHEMA = '" & nomeBanco _
                    & "';"
        Try

            tabela = MySQL_Select(conexaoSQL, criterioSQL)

            If tabela.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("ERRO " & ex.Message, "Verifica banco")
            Return False
        End Try

    End Function

    Public Sub CriarBanco(ByVal conexaoSQL As MySqlConnection, ByVal Bilhetador As String)
        Dim NomeBanco As String = "SpyCdr_" & Bilhetador
        Dim Sql = "CREATE DATABASE " & NomeBanco & ";"

        Try
            MySQL_cmd(Conn, Sql)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub CriarTabela(ByVal Bilhetador As String, ByVal Tabela As String, ByVal cmdTXT As String, ByVal Saida As ListBox)

        Dim Sql = "select * from cdrs where (false);"

        'define os objetos connecton, command e dataadapter

        Try
            If Not TabelaExiste(Conn, frmManutencao.txtBancoMySql.Text, "" & Tabela & "") Then
                MySQL_Select(Conn, cmdTXT)
                Saida.Items.Add(" ->Criado [" & Tabela & "]")
                GravaLOG("Criar Tabelas", "(CREATE TABLE " & Tabela & ")")
            Else
                Saida.Items.Add(" ->A tabela [" & Tabela & "] já existia")
            End If

        Catch ex As Exception
            MsgBox(" Erro : " & ex.InnerException.ToString & " - " & ex.Message)
        Finally
            'Conn.Close()
        End Try

    End Sub

    Public Sub Gera_X_rota_entrada(ByVal Data As String)
        Dim registrosAfetados As Integer
        frmPrincipal1.NotifyIcon1.Text = "Gerando: X_Rota_Entrada"

        Try
            GravaLOG("Gerar Histórico", "(INÍCIO:Gera_X_rota_entrada) Data: " & Data)
            MySQL_cmd(Conn, "DELETE FROM x_rota_entrada WHERE date(DATA) = '" & Data & "';")
            'Gera SQL
            Select Case frmManutencao.cbTipoCentral.Text
                Case Is = "E", "H"
                    MySQL_cmd(Conn, "INSERT INTO x_rota_entrada " _
                         & " select  Date(Data) AS DATA, Hour(DATA)AS HORA, R_ENT, " _
                         & " SUM(IF(CLASSIF='CO0',1,0)) AS 'CO0'," _
                         & " SUM(IF(CLASSIF='CO1',1,0)) AS 'CO1'," _
                         & " SUM(IF(CLASSIF='CO2',1,0)) AS 'CO2'," _
                         & " SUM(IF(CLASSIF='CO3',1,0)) AS 'CO3'," _
                         & " SUM(IF(CLASSIF='DSC',1,0)) AS 'DSC'," _
                         & " SUM(IF(CLASSIF='LO',1,0)) AS 'LO'," _
                         & " SUM(IF(CLASSIF='NR1',1,0)) AS 'NR1'," _
                         & " SUM(IF(CLASSIF='NR5',1,0)) AS 'NR5'," _
                         & " SUM(IF(CLASSIF='OK1',1,0)) AS 'OK1'," _
                         & " SUM(IF(CLASSIF='OK5',1,0)) AS 'OK5'," _
                         & " SUM(IF(CLASSIF='OU',1,0)) AS 'OU'" _
                         & " FROM cdrs_" & Format(CDate(Data), "yyyyMMdd") _
                         & " GROUP BY HORA, R_ENT;")
                Case Is = "N"
                    MySQL_cmd(Conn, "INSERT INTO x_rota_entrada " _
                         & " select  Date(Data) AS DATA, LEFT(HORA,2) AS HORA, R_ENT, " _
                         & " SUM(IF(CLASSIF='CO0',1,0)) AS 'CO0'," _
                         & " SUM(IF(CLASSIF='CO1',1,0)) AS 'CO1'," _
                         & " SUM(IF(CLASSIF='CO2',1,0)) AS 'CO2'," _
                         & " SUM(IF(CLASSIF='CO3',1,0)) AS 'CO3'," _
                         & " SUM(IF(CLASSIF='DSC',1,0)) AS 'DSC'," _
                         & " SUM(IF(CLASSIF='LO',1,0)) AS 'LO'," _
                         & " SUM(IF(CLASSIF='NR1',1,0)) AS 'NR1'," _
                         & " SUM(IF(CLASSIF='NR5',1,0)) AS 'NR5'," _
                         & " SUM(IF(CLASSIF='OK1',1,0)) AS 'OK1'," _
                         & " SUM(IF(CLASSIF='OK5',1,0)) AS 'OK5'," _
                         & " SUM(IF(CLASSIF='OU',1,0)) AS 'OU'" _
                         & " FROM cdrs_" & Format(CDate(Data), "yyyyMMdd") _
                         & " GROUP BY LEFT(HORA,2), R_ENT;")
            End Select


        Catch ex As Exception
            MsgBox(" Erro : " & ex.Message)
        Finally
            'Conn.Close()
            GravaLOG("Gerar Histórico", "(FIM:Gera_X_rota_entrada) Registros : " & registrosAfetados & " Data: " & Data)
        End Try

    End Sub
    Public Sub Gera_X_rota_saida(ByVal Data As String)
        Dim registrosAfetados As Integer
        frmPrincipal1.NotifyIcon1.Text = "Gerando: X_Rota_Saída"

        Try
            GravaLOG("Gerar Histórico", "(INÍCIO:Gera_X_rota_saida) Data: " & Data)

            MySQL_cmd(Conn, "DELETE FROM x_rota_saida WHERE date(DATA) = '" & Data & "';")

            'Gera SQL
            Select Case frmManutencao.cbTipoCentral.Text
                Case Is = "E", "H"
                    MySQL_cmd(Conn, "INSERT INTO x_rota_saida " _
                         & " select  Date(Data) AS DATA, Hour(DATA)AS HORA, R_SAI, " _
                         & " SUM(IF(CLASSIF='CO0',1,0)) AS 'CO0'," _
                         & " SUM(IF(CLASSIF='CO1',1,0)) AS 'CO1'," _
                         & " SUM(IF(CLASSIF='CO2',1,0)) AS 'CO2'," _
                         & " SUM(IF(CLASSIF='CO3',1,0)) AS 'CO3'," _
                         & " SUM(IF(CLASSIF='DSC',1,0)) AS 'DSC'," _
                         & " SUM(IF(CLASSIF='LO',1,0)) AS 'LO'," _
                         & " SUM(IF(CLASSIF='NR1',1,0)) AS 'NR1'," _
                         & " SUM(IF(CLASSIF='NR5',1,0)) AS 'NR5'," _
                         & " SUM(IF(CLASSIF='OK1',1,0)) AS 'OK1'," _
                         & " SUM(IF(CLASSIF='OK5',1,0)) AS 'OK5'," _
                         & " SUM(IF(CLASSIF='OU',1,0)) AS 'OU'" _
                         & " FROM cdrs_" & Format(CDate(Data), "yyyyMMdd") _
                         & " GROUP BY HORA, R_SAI;")
                Case Is = "N"
                    MySQL_cmd(Conn, "INSERT INTO x_rota_saida " _
                         & " select  Date(Data) AS DATA, LEFT(HORA,2) AS HORA, R_SAI, " _
                         & " SUM(IF(CLASSIF='CO0',1,0)) AS 'CO0'," _
                         & " SUM(IF(CLASSIF='CO1',1,0)) AS 'CO1'," _
                         & " SUM(IF(CLASSIF='CO2',1,0)) AS 'CO2'," _
                         & " SUM(IF(CLASSIF='CO3',1,0)) AS 'CO3'," _
                         & " SUM(IF(CLASSIF='DSC',1,0)) AS 'DSC'," _
                         & " SUM(IF(CLASSIF='LO',1,0)) AS 'LO'," _
                         & " SUM(IF(CLASSIF='NR1',1,0)) AS 'NR1'," _
                         & " SUM(IF(CLASSIF='NR5',1,0)) AS 'NR5'," _
                         & " SUM(IF(CLASSIF='OK1',1,0)) AS 'OK1'," _
                         & " SUM(IF(CLASSIF='OK5',1,0)) AS 'OK5'," _
                         & " SUM(IF(CLASSIF='OU',1,0)) AS 'OU'" _
                         & " FROM cdrs_" & Format(CDate(Data), "yyyyMMdd") _
                         & " GROUP BY LEFT(HORA,2), R_SAI;")
            End Select
        Catch ex As Exception
            MsgBox(" Erro : " & ex.Message)
        Finally
            'Conn.Close()
            GravaLOG("Gerar Histórico", "(FIM:Gera_X_rota_saida) Registros : " & registrosAfetados & " Data: " & Data)
        End Try

    End Sub
    Public Sub Gera_X_Cliente_Destinado(ByVal Data As String)
        Dim registrosAfetados As Integer
        frmPrincipal1.NotifyIcon1.Text = "Gerando: X_Cliente_Destinado"

        Try
            GravaLOG("Gerar Histórico", "(INÍCIO:Gera_X_Cliente_Destinado) Data: " & Data)
            MySQL_cmd(Conn, "DELETE FROM x_cliente_destinado WHERE date(DATA) = '" & Data & "';")

            'Gera SQL
            MySQL_cmd(Conn, "INSERT INTO x_cliente_destinado " _
                 & " select  Date(Data) AS DATA, Hour(DATA)AS HORA, clientes.COD_CLI, " _
                 & " SUM(IF(CLASSIF='CO0',1,0)) AS 'CO0'," _
                 & " SUM(IF(CLASSIF='CO1',1,0)) AS 'CO1'," _
                 & " SUM(IF(CLASSIF='CO2',1,0)) AS 'CO2'," _
                 & " SUM(IF(CLASSIF='CO3',1,0)) AS 'CO3'," _
                 & " SUM(IF(CLASSIF='DSC',1,0)) AS 'DSC'," _
                 & " SUM(IF(CLASSIF='LO',1,0)) AS 'LO'," _
                 & " SUM(IF(CLASSIF='NR1',1,0)) AS 'NR1'," _
                 & " SUM(IF(CLASSIF='NR5',1,0)) AS 'NR5'," _
                 & " SUM(IF(CLASSIF='OK1',1,0)) AS 'OK1'," _
                 & " SUM(IF(CLASSIF='OK5',1,0)) AS 'OK5'," _
                 & " SUM(IF(CLASSIF='OU',1,0)) AS 'OU'" _
                 & " FROM (cdrs_" & Format(CDate(Data), "yyyyMMdd") & " JOIN cliente_terminal ON cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".ASS_B = cliente_terminal.TERMINAL) " _
                 & " JOIN clientes ON cliente_terminal.COD_CLI = clientes.COD_CLI " _
                 & " GROUP BY HORA, clientes.COD_CLI;")


        Catch ex As Exception
            MsgBox(" Erro : " & ex.Message)
        Finally
            'Conn.Close()
            GravaLOG("Gerar Histórico", "(FIM:Gera_X_Cliente_Destinado) Registros : " & registrosAfetados & " Data: " & Data)
        End Try

    End Sub
    Public Sub Gera_X_Cliente_Originado(ByVal Data As String)
        Dim registrosAfetados As Integer
        frmPrincipal1.NotifyIcon1.Text = "Gerando: X_Cliente_Originado"

        Try
            GravaLOG("Gerar Histórico", "(INÍCIO:Gera_X_Cliente_Originado) Data: " & Data)
            MySQL_cmd(Conn, "DELETE FROM X_Cliente_Originado WHERE date(DATA) = '" & Data & "';")


            'Gera SQL
            MySQL_cmd(Conn, "INSERT INTO X_Cliente_Originado " _
                 & " select  Date(Data) AS DATA, Hour(DATA)AS HORA, clientes.COD_CLI, " _
                 & " SUM(IF(CLASSIF='CO0',1,0)) AS 'CO0'," _
                 & " SUM(IF(CLASSIF='CO1',1,0)) AS 'CO1'," _
                 & " SUM(IF(CLASSIF='CO2',1,0)) AS 'CO2'," _
                 & " SUM(IF(CLASSIF='CO3',1,0)) AS 'CO3'," _
                 & " SUM(IF(CLASSIF='DSC',1,0)) AS 'DSC'," _
                 & " SUM(IF(CLASSIF='LO',1,0)) AS 'LO'," _
                 & " SUM(IF(CLASSIF='NR1',1,0)) AS 'NR1'," _
                 & " SUM(IF(CLASSIF='NR5',1,0)) AS 'NR5'," _
                 & " SUM(IF(CLASSIF='OK1',1,0)) AS 'OK1'," _
                 & " SUM(IF(CLASSIF='OK5',1,0)) AS 'OK5'," _
                 & " SUM(IF(CLASSIF='OU',1,0)) AS 'OU'" _
                 & " FROM (cdrs_" & Format(CDate(Data), "yyyyMMdd") & " JOIN cliente_terminal ON cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".ASS_A = cliente_terminal.TERMINAL) " _
                 & " JOIN clientes ON cliente_terminal.COD_CLI = clientes.COD_CLI " _
                 & " GROUP BY HORA, clientes.COD_CLI;")

        Catch ex As Exception
            MsgBox(" Erro : " & ex.Message)
        Finally
            'Conn.Close()
            GravaLOG("Gerar Histórico", "(FIM:Gera_X_Cliente_Originado) Registros : " & registrosAfetados & " Data: " & Data)
        End Try

    End Sub
    Public Sub Gera_X_Grupo(ByVal Data As String)
        Dim registrosAfetados As Integer
        frmPrincipal1.NotifyIcon1.Text = "Gerando: X_Grupo"

        Try
            GravaLOG("Gerar Histórico", "(INÍCIO:Gera_X_Grupo) Data: " & Data)
            MySQL_cmd(Conn, "DELETE FROM x_Grupo WHERE date(DATA) = '" & Data & "';")

            'Gera SQL
            Select Case frmManutencao.cbTipoCentral.Text
                Case "E"
                    MySQL_cmd(Conn, "INSERT INTO x_Grupo " _
                          & " select  Date(Data) AS DATA, Hour(DATA)AS HORA, grupos.GRUPO, " _
                          & " SUM(IF(CLASSIF='CO0',1,0)) AS 'CO0'," _
                          & " SUM(IF(CLASSIF='CO1',1,0)) AS 'CO1'," _
                          & " SUM(IF(CLASSIF='CO2',1,0)) AS 'CO2'," _
                          & " SUM(IF(CLASSIF='CO3',1,0)) AS 'CO3'," _
                          & " SUM(IF(CLASSIF='DSC',1,0)) AS 'DSC'," _
                          & " SUM(IF(CLASSIF='LO',1,0)) AS 'LO'," _
                          & " SUM(IF(CLASSIF='NR1',1,0)) AS 'NR1'," _
                          & " SUM(IF(CLASSIF='NR5',1,0)) AS 'NR5'," _
                          & " SUM(IF(CLASSIF='OK1',1,0)) AS 'OK1'," _
                          & " SUM(IF(CLASSIF='OK5',1,0)) AS 'OK5'," _
                          & " SUM(IF(CLASSIF='OU',1,0)) AS 'OU'" _
                          & " FROM cdrs_" & Format(CDate(Data), "yyyyMMdd") _
                          & "      JOIN grupos ON (cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".ASS_A like grupos.MASCARA_ASS_A AND" _
                          & "                cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".CSP like grupos.MASCARA_CSP AND" _
                          & "                cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".ASS_B like grupos.MASCARA_ASS_B AND" _
                          & "                cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".R_ENT like grupos.MASCARA_ROTA_E AND" _
                          & "                cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".R_SAI like grupos.MASCARA_ROTA_S)" _
                          & " GROUP BY HORA, grupos.GRUPO;")
                Case "H"
                    MySQL_cmd(Conn, "INSERT INTO x_Grupo " _
                         & " select  Date(Data) AS DATA, Hour(DATA)AS HORA, grupos.GRUPO, " _
                         & " SUM(IF(CLASSIF='CO0',1,0)) AS 'CO0'," _
                         & " SUM(IF(CLASSIF='CO1',1,0)) AS 'CO1'," _
                         & " SUM(IF(CLASSIF='CO2',1,0)) AS 'CO2'," _
                         & " SUM(IF(CLASSIF='CO3',1,0)) AS 'CO3'," _
                         & " SUM(IF(CLASSIF='DSC',1,0)) AS 'DSC'," _
                         & " SUM(IF(CLASSIF='LO',1,0)) AS 'LO'," _
                         & " SUM(IF(CLASSIF='NR1',1,0)) AS 'NR1'," _
                         & " SUM(IF(CLASSIF='NR5',1,0)) AS 'NR5'," _
                         & " SUM(IF(CLASSIF='OK1',1,0)) AS 'OK1'," _
                         & " SUM(IF(CLASSIF='OK5',1,0)) AS 'OK5'," _
                         & " SUM(IF(CLASSIF='OU',1,0)) AS 'OU'" _
                         & " FROM cdrs_" & Format(CDate(Data), "yyyyMMdd") _
                         & "      JOIN grupos ON (cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".ASS_A like grupos.MASCARA_ASS_A AND" _
                         & "                        cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".CSP like grupos.MASCARA_CSP AND" _
                         & "                      cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".ASS_B like grupos.MASCARA_ASS_B AND" _
                         & "                      cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".R_ENT like grupos.MASCARA_ROTA_E AND" _
                         & "                      cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".R_SAI like grupos.MASCARA_ROTA_S) " _
                         & " GROUP BY HORA, grupos.GRUPO;")

                Case "N"
                    MySQL_cmd(Conn, "INSERT INTO x_Grupo " _
                         & " select  Date(Data) AS DATA, LEFT(HORA,2) AS HORA, grupos.GRUPO, " _
                         & " SUM(IF(CLASSIF='CO0',1,0)) AS 'CO0'," _
                         & " SUM(IF(CLASSIF='CO1',1,0)) AS 'CO1'," _
                         & " SUM(IF(CLASSIF='CO2',1,0)) AS 'CO2'," _
                         & " SUM(IF(CLASSIF='CO3',1,0)) AS 'CO3'," _
                         & " SUM(IF(CLASSIF='DSC',1,0)) AS 'DSC'," _
                         & " SUM(IF(CLASSIF='LO',1,0)) AS 'LO'," _
                         & " SUM(IF(CLASSIF='NR1',1,0)) AS 'NR1'," _
                         & " SUM(IF(CLASSIF='NR5',1,0)) AS 'NR5'," _
                         & " SUM(IF(CLASSIF='OK1',1,0)) AS 'OK1'," _
                         & " SUM(IF(CLASSIF='OK5',1,0)) AS 'OK5'," _
                         & " SUM(IF(CLASSIF='OU',1,0)) AS 'OU'" _
                         & " FROM (cdrs_" & Format(CDate(Data), "yyyyMMdd") _
                         & " JOIN grupos ON (cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".ASS_A like grupos.MASCARA_ASS_A) AND" _
                         & "                (cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".CSP like grupos.MASCARA_CSP) AND" _
                         & "                (cdrs_" & Format(CDate(Data), "yyyyMMdd") & ".ASS_B like grupos.MASCARA_ASS_B) AND" _
                         & "                (R_ENT like grupos.MASCARA_ROTA_E) AND" _
                         & "                (R_SAI like grupos.MASCARA_ROTA_S))" _
                         & " GROUP BY LEFT(HORA,2), grupos.GRUPO;")
            End Select

            'FROM cdrs_20080109 INNER JOIN grupos ON (cdrs_20080109.ASS_A like grupos.Mascara_Ass_A) AND (cdrs_20080109.CSP like grupos.Mascara_CSP) AND (cdrs_20080109.ASS_B like grupos.Mascara_Ass_B)

        Catch ex As Exception
            MsgBox(" Erro : " & ex.Message)
        Finally
            'conn.Close()
            GravaLOG("Gerar Histórico", "(FIM:Gera_X_Grupo) Registros : " & registrosAfetados & " Data: " & Data)
        End Try

    End Sub
    Public Sub Gera_X_ASS_A(ByVal Data As String)
        Dim registrosAfetados As Integer
        frmPrincipal1.NotifyIcon1.Text = "Gerando: X_ASS_A"

        Try
            GravaLOG("Gerar Histórico", "(INÍCIO:Gera_X_ASS_A) Data: " & Data)
            MySQL_cmd(Conn, "DELETE FROM X_ASS_A WHERE date(DATA) = '" & Data & "';")


            'Gera SQL
            MySQL_cmd(Conn, "INSERT INTO X_ASS_A " _
                 & " select  Date(Data) AS DATA, ASS_A, Count(*) AS 'TCH', " _
                 & " SUM(IF(CLASSIF='CO0',1,0)) AS 'CO0'," _
                 & " SUM(IF(CLASSIF='CO1',1,0)) AS 'CO1'," _
                 & " SUM(IF(CLASSIF='CO2',1,0)) AS 'CO2'," _
                 & " SUM(IF(CLASSIF='CO3',1,0)) AS 'CO3'," _
                 & " SUM(IF(CLASSIF='DSC',1,0)) AS 'DSC'," _
                 & " SUM(IF(CLASSIF='LO',1,0)) AS 'LO'," _
                 & " SUM(IF(CLASSIF='NR1',1,0)) AS 'NR1'," _
                 & " SUM(IF(CLASSIF='NR5',1,0)) AS 'NR5'," _
                 & " SUM(IF(CLASSIF='OK1',1,0)) AS 'OK1'," _
                 & " SUM(IF(CLASSIF='OK5',1,0)) AS 'OK5'," _
                 & " SUM(IF(CLASSIF='OU',1,0)) AS 'OU'" _
                 & " FROM cdrs_" & Format(CDate(Data), "yyyyMMdd") _
                 & " GROUP BY ASS_A " _
                 & " having TCH > " & frmGeraHistorico.numLimiteTCH.Value & ";")

        Catch ex As Exception
            MsgBox(" Erro : " & ex.Message)
        Finally
            'Conn.Close()
            GravaLOG("Gerar Histórico", "(FIM:Gera_X_ASS_A) Registros : " & registrosAfetados & " Data: " & Data)
        End Try

    End Sub

    Public Sub Gera_X_ASS_B(ByVal Data As String)
        Dim registrosAfetados As Integer
        frmPrincipal1.NotifyIcon1.Text = "Gerando: X_ASS_B"

        Try
            GravaLOG("Gerar Histórico", "(INÍCIO:Gera_X_ASS_B) Data: " & Data)
            MySQL_cmd(Conn, "DELETE FROM X_ASS_B WHERE date(DATA) = '" & Data & "';")

            'Gera SQL
            MySQL_cmd(Conn, "INSERT INTO X_ASS_B " _
                 & " select  Date(Data) AS DATA, ASS_B, Count(*) AS 'TCH', " _
                 & " SUM(IF(CLASSIF='CO0',1,0)) AS 'CO0'," _
                 & " SUM(IF(CLASSIF='CO1',1,0)) AS 'CO1'," _
                 & " SUM(IF(CLASSIF='CO2',1,0)) AS 'CO2'," _
                 & " SUM(IF(CLASSIF='CO3',1,0)) AS 'CO3'," _
                 & " SUM(IF(CLASSIF='DSC',1,0)) AS 'DSC'," _
                 & " SUM(IF(CLASSIF='LO',1,0)) AS 'LO'," _
                 & " SUM(IF(CLASSIF='NR1',1,0)) AS 'NR1'," _
                 & " SUM(IF(CLASSIF='NR5',1,0)) AS 'NR5'," _
                 & " SUM(IF(CLASSIF='OK1',1,0)) AS 'OK1'," _
                 & " SUM(IF(CLASSIF='OK5',1,0)) AS 'OK5'," _
                 & " SUM(IF(CLASSIF='OU',1,0)) AS 'OU'" _
                 & " FROM cdrs_" & Format(CDate(Data), "yyyyMMdd") _
                 & " GROUP BY ASS_B " _
                 & " having TCH > " & frmGeraHistorico.numLimiteTCH.Value & ";")

        Catch ex As Exception
            MsgBox(" Erro : " & ex.Message)
        Finally
            'Conn.Close()
            GravaLOG("Gerar Histórico", "(FIM:Gera_X_ASS_B) Registros : " & registrosAfetados & " Data: " & Data)
        End Try

    End Sub
    Public Sub Gera_X_EOS(ByVal Data As String)
        Dim registrosAfetados As Integer
        frmPrincipal1.NotifyIcon1.Text = "Gerando: X_EOS"

        Try
            GravaLOG("Gerar Histórico", "(INÍCIO:Gera_X_EOS) Data: " & Data)
            MySQL_cmd(Conn, "DELETE FROM X_EOS WHERE date(DATA) = '" & Data & "';")

            Select Case frmManutencao.cbTipoCentral.Text
                Case "E"
                    'Gera SQL
                    MySQL_cmd(Conn, "INSERT INTO X_EOS " _
                         & " select  Date(Data) AS DATA, Hour(DATA) AS HORA, EOS, Count(*) AS 'TCH', " _
                         & " SUM(IF(CLASSIF='CO0',1,0)) AS 'CO0'," _
                         & " SUM(IF(CLASSIF='CO1',1,0)) AS 'CO1'," _
                         & " SUM(IF(CLASSIF='CO2',1,0)) AS 'CO2'," _
                         & " SUM(IF(CLASSIF='CO3',1,0)) AS 'CO3'," _
                         & " SUM(IF(CLASSIF='DSC',1,0)) AS 'DSC'," _
                         & " SUM(IF(CLASSIF='LO',1,0)) AS 'LO'," _
                         & " SUM(IF(CLASSIF='NR1',1,0)) AS 'NR1'," _
                         & " SUM(IF(CLASSIF='NR5',1,0)) AS 'NR5'," _
                         & " SUM(IF(CLASSIF='OK1',1,0)) AS 'OK1'," _
                         & " SUM(IF(CLASSIF='OK5',1,0)) AS 'OK5'," _
                         & " SUM(IF(CLASSIF='OU',1,0)) AS 'OU'" _
                         & " FROM cdrs_" & Format(CDate(Data), "yyyyMMdd") _
                         & " GROUP BY EOS;")
                Case "H"
                    MySQL_cmd(Conn, "INSERT INTO X_EOS " _
                         & " select  Date(Data) AS DATA, Hour(DATA) AS HORA, Failure_Code, Count(*) AS 'TCH', " _
                         & " SUM(IF(CLASSIF='CO0',1,0)) AS 'CO0'," _
                         & " SUM(IF(CLASSIF='CO1',1,0)) AS 'CO1'," _
                         & " SUM(IF(CLASSIF='CO2',1,0)) AS 'CO2'," _
                         & " SUM(IF(CLASSIF='CO3',1,0)) AS 'CO3'," _
                         & " SUM(IF(CLASSIF='DSC',1,0)) AS 'DSC'," _
                         & " SUM(IF(CLASSIF='LO',1,0)) AS 'LO'," _
                         & " SUM(IF(CLASSIF='NR1',1,0)) AS 'NR1'," _
                         & " SUM(IF(CLASSIF='NR5',1,0)) AS 'NR5'," _
                         & " SUM(IF(CLASSIF='OK1',1,0)) AS 'OK1'," _
                         & " SUM(IF(CLASSIF='OK5',1,0)) AS 'OK5'," _
                         & " SUM(IF(CLASSIF='OU',1,0)) AS 'OU'" _
                         & " FROM cdrs_" & Format(CDate(Data), "yyyyMMdd") _
                         & " GROUP BY Failure_Code;")
            End Select

        Catch ex As Exception
            MsgBox(" Erro : " & ex.Message)
        Finally
            'Conn.Close()
            GravaLOG("Gerar Histórico", "(FIM:Gera_X_EOS) Registros : " & registrosAfetados & " Data: " & Data)
        End Try

    End Sub

    Public Sub Gera_X_PPI(ByVal Data As String)
        Dim registrosAfetados As Integer
        Dim ArqCdrs As String = "cdrs_" & Format(CDate(Data), "yyyyMMdd")
        frmPrincipal1.NotifyIcon1.Text = "Gerando: X_EOS"

        Try
            GravaLOG("Gerar Histórico", "(INÍCIO:Gera_X_PPI) Data: " & Data)
            MySQL_cmd(Conn, "DELETE FROM X_PPI WHERE date(DATA) = '" & Data & "'") 'Apaga registros do dia

            Select Case frmManutencao.cbTipoCentral.Text
                Case "E"
                    'Gera SQL
                    MySQL_cmd(Conn, "INSERT INTO X_PPI " _
                         & " select  Date(Data) AS DATA, ppis.id AS COD_PPI, " _
                         & " SUM(IF(" & ArqCdrs & ".R_ENT <> ppis.RIN_E AND " & ArqCdrs & ".R_ENT < 300 AND " & ArqCdrs & ".CSP = 21,0,1)) AS 'NA ROTA', " _
                         & " SUM(IF(" & ArqCdrs & ".R_ENT <> ppis.RIN_E AND " & ArqCdrs & ".R_ENT < 300 AND " & ArqCdrs & ".CSP = 21,1,0)) AS 'FORA DA ROTA'" _
                         & " FROM " & ArqCdrs & " JOIN ppi_prefixo ON  " & ArqCdrs & ".ASS_A  like CONCAT(ppi_prefixo.prefixo,'%') " _
                         & "                      JOIN  ppis ON ppi_prefixo.cod_ppi = ppis.id " _
                         & " GROUP BY ppis.id;")
                Case "H"
                    MySQL_cmd(Conn, "INSERT INTO X_PPI " _
                         & " select  Date(Data) AS DATA, ppis.id AS COD_PPI, " _
                         & " SUM(IF(" & ArqCdrs & ".R_ENT <> ppis.RIN_E AND " & ArqCdrs & ".R_ENT < 300 AND " & ArqCdrs & ".CSP = 21,0,1)) AS 'NA ROTA', " _
                         & " SUM(IF(" & ArqCdrs & ".R_ENT <> ppis.RIN_E AND " & ArqCdrs & ".R_ENT < 300 AND " & ArqCdrs & ".CSP = 21,1,0)) AS 'FORA DA ROTA'" _
                         & " FROM " & ArqCdrs & " JOIN ppi_prefixo ON  " & ArqCdrs & ".ASS_A  like CONCAT(ppi_prefixo.prefixo,'%') " _
                         & "                      JOIN  ppis ON ppi_prefixo.cod_ppi = ppis.id " _
                         & " GROUP BY ppis.id;")
            End Select

        Catch ex As Exception
            MsgBox(" Erro : " & ex.Message)
        Finally
            'Conn.Close()
            GravaLOG("Gerar Histórico", "(FIM:Gera_X_PPI) Registros : " & registrosAfetados & " Data: " & Data)
        End Try

    End Sub
    Public Sub GravaLOG(ByVal grupo As String, ByVal detalhe As String)
        Dim criterioSQL As String

        criterioSQL = "INSERT INTO logAtividade (DATA, GRUPO, DETALHE) VALUES ('" _
                    & Format(Now(), "yyyy-MM-dd HH:mm:ss") & "','" _
                    & grupo & "','" _
                    & detalhe & "');"

        MySQL_cmd(Conn, criterioSQL)

    End Sub

End Module
