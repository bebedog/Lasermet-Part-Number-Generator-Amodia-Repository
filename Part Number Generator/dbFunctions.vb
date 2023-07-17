'================================================================================
'FILE        : dbFunctions.vb
'AUTHORS     : Jayson O. Amodia, Elyn Abby Toledo, Kathryn Marie P. Sigaya
'DESCRIPTION : This file contains the database functions of the program.
'COPYRIGHT   : 13 July 2023
'REVISION HISTORY
'Date: 			By: 		Description:
'2023/07/13     Sigaya      Documentation
'================================================================================

Imports System.Data.OleDb
Imports System.Data.Odbc

'================================================================================
'CLASS       : dbFunctions
'DESCRIPTION : Module that contains database-related functions.
'================================================================================
Module dbFunctions

    Public dbProvider As String
    Public dbSource As String

    Public dbPathandFilename As String

    Public con As New OleDb.OleDbConnection
    Public cm As OleDb.OleDbCommand
    Public da As OleDb.OleDbDataAdapter
    Public dr As OleDbDataReader
    Public sql As String

    'For PostgreSQL

    Public pcon As New Odbc.OdbcConnection
    Public pcm As Odbc.OdbcCommand
    Public pda As Odbc.OdbcDataAdapter
    Public pdr As Odbc.OdbcDataReader
    Public psql As String

    Public Sub connectPostGre()

        Try

            Dim pconstring As String = "Driver={PostgreSQL ANSI};
                                        Server=dpg-cfust99mbjsj9amj3vvg-a.oregon-postgres.render.com;
                                        Port=5432;
                                        Database=accounts_9a0n;
                                        Uid=bebedog;
                                        Pwd=SsETyMw5ZrbCGUGXM2SqDZ8lGMENNhq8;
                                        sslmode=require;"
            pcon = New Odbc.OdbcConnection(pconstring)

        Catch ex As Exception



        End Try

    End Sub

    Public Function checkForDuplicates(description As String) As Boolean

        Call connectPostGre()

        'Check final database

        Try

            Dim sqlQuery As String = $"SELECT * FROM ""LasermetPARTS"" WHERE ""description"" LIKE '{description}'"
            pda = New Odbc.OdbcDataAdapter()
            Dim pdcb As New Odbc.OdbcCommandBuilder(pda)
            pda.SelectCommand = New Odbc.OdbcCommand(sqlQuery, pcon)
            Dim dtable As New DataTable()
            pcon.Open()
            pda.Fill(dtable)
            pcon.Close()

            If dtable.Rows.Count <= 0 Then

                'Check fully approved parts in temporary database

                Try

                    Dim _sqlQuery As String = $"SELECT * FROM ""LasermetPARTS_forApproval"" WHERE ""description"" LIKE '{description}' AND ""manager_approval"" = 'Approved' AND ""final_approval"" = 'Approved'"
                    pda = New Odbc.OdbcDataAdapter()
                    Dim _pdcb As New Odbc.OdbcCommandBuilder(pda)
                    pda.SelectCommand = New Odbc.OdbcCommand(_sqlQuery, pcon)
                    Dim _dtable As New DataTable()
                    pcon.Open()
                    pda.Fill(_dtable)
                    pcon.Close()

                    If _dtable.Rows.Count <= 0 Then
                        Return False
                    Else
                        Return True
                    End If

                Catch ex As Exception
                    MessageBox.Show("Exception caught. See console", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Console.WriteLine(ex.Message)
                    pcon.Close()
                End Try

            Else
                Return True
                Exit Function
            End If

        Catch ex As Exception
            MessageBox.Show("Exception caught. See console", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Console.WriteLine(ex.Message)
            pcon.Close()
        End Try

    End Function

End Module
