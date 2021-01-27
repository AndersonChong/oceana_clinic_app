Imports System.Data.OleDb

Public Class Login_Form

    'DEFINING VARIABLES
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim drOLEDB As OleDbDataReader
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = C:OceanaData.mdb"


    'ESTABLISH CONNECTION
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUserID.Focus()
        cnnOLEDB.ConnectionString = con
        cnnOLEDB.Open()
    End Sub


    'LOGIN BUTTON
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If TxtUserID.Text <> "" And TxtPassword.Text <> "" Then

            'SQL Command for ID and Password
            cmdOLEDB.CommandText = "SELECT * FROM [Staff] WHERE [StaffID] = '" + TxtUserID.Text + "' AND Password = '" + TxtPassword.Text + "';"
            cmdOLEDB.CommandType = CommandType.Text
            cmdOLEDB.Connection = cnnOLEDB

            'EXECUTE Reader
            drOLEDB = cmdOLEDB.ExecuteReader()

            'Check if input matches data
            If drOLEDB.Read = True Then

                If drOLEDB.Item(11) = "Administrator" Then
                    Administrator_Home.Show()
                ElseIf drOLEDB.Item(11) = "Doctor" Then
                    Doctor_Home.Show()
                ElseIf drOLEDB.Item(11) = "Nurse" Then
                    Nurse_Home.Show()
                End If

                If Quit() = True Then
                    drOLEDB.Close() 'CLOSE Reader
                    cnnOLEDB.Close() 'CLOSE Connection
                End If

            Else
                drOLEDB.Close() 'CLOSE Reader
                MessageBox.Show("Incorrect User ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TxtUserID.Clear()
                TxtPassword.Clear()
            End If

        Else
            MessageBox.Show("Incorrect User ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TxtUserID.Clear()
            TxtPassword.Clear()
        End If

    End Sub

    'EXIT FUNCTION
    Private Function Quit() As Boolean
        Me.Close()
        Return True
    End Function

End Class
