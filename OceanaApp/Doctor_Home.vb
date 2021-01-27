Imports System.Data.OleDb

Public Class Doctor_Home

    'DEFINING VARIABLE
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim drOLEDB As OleDbDataReader
    Dim daOLEDB As New OleDbDataAdapter
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = C:OceanaData.mdb"

    Dim patient_table, p_search_table As New DataTable
    Dim row, count, DataVar2 As Integer
    Dim p_record(14) As String

    Private Sub Doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        'Refer below
        P_Data_Table()
    End Sub



    'ESTABLICH CONNECTION TO PATIENT TABLE
    Private Sub P_Data_Table()

        cnnOLEDB.Open()

        'SQL Command
        cmdOLEDB.CommandText = "SELECT * FROM [Patient];"
        cmdOLEDB.CommandType = CommandType.Text
        cmdOLEDB.Connection = cnnOLEDB

        'Fill all database table into grid
        daOLEDB.SelectCommand = cmdOLEDB
        patient_table.Clear()
        daOLEDB.Fill(patient_table)
        GridPR.DataSource = patient_table

        cnnOLEDB.Close()

    End Sub



    'SAVE DATABASE RECORD INTO VARIABLE
    'Variable brings saved data to another form
    Private Sub GridPR_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridPR.CellClick

        DataVar2 = 1
        If e.RowIndex >= 0 Then
            row = GridPR.CurrentRow.Index

            For count = 0 To 14
                p_record(count) = GridPR.Rows(row).Cells(count).Value.ToString()
            Next
        End If
        TransID = p_record(0)

    End Sub



    'DISABLE TEXTBOX PATIENT ID
    Private Sub TxtPName_TextChanged(sender As Object, e As EventArgs) Handles TxtPName.TextChanged
        If TxtPName.Text <> "" Then
            TxtPID.Enabled = False
        Else
            TxtPID.Enabled = True
        End If
    End Sub



    'DISABLE TEXTBOX PATIENT NAME
    Private Sub TxtPID_TextChanged(sender As Object, e As EventArgs) Handles TxtPID.TextChanged
        If TxtPID.Text <> "" Then
            TxtPName.Enabled = False
        Else
            TxtPName.Enabled = True
        End If
    End Sub



    'SEARCH FUNCTION FOR PATIENT
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        If TxtPID.Text <> "" And TxtPName.Text = "" Then

            cnnOLEDB.Open()

            'SQL Command for ID
            cmdOLEDB.CommandText = "SELECT * FROM [Patient] WHERE [PatientID] LIKE '%" + TxtPID.Text + "%';"
            cmdOLEDB.CommandType = CommandType.Text
            cmdOLEDB.Connection = cnnOLEDB

            'EXECUTE Reader
            drOLEDB = cmdOLEDB.ExecuteReader()

            If drOLEDB.Read = True Then

                'CLOSE Reader
                drOLEDB.Close()

                'Fill selected database table into grid
                p_search_table.Clear()
                daOLEDB.SelectCommand = cmdOLEDB
                daOLEDB.Fill(p_search_table)
                GridPR.DataSource = p_search_table
            Else
                'CLOSE Reader
                drOLEDB.Close()

                MessageBox.Show("Record not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            cnnOLEDB.Close()

        ElseIf TxtPName.Text <> "" And TxtPID.Text = "" Then

            cnnOLEDB.Open()

            'SQL Command for Name
            cmdOLEDB.CommandText = "SELECT * FROM [Patient] WHERE [PatientFName] LIKE '%" + TxtPName.Text + "%' OR [PatientLName] LIKE '%" + TxtPName.Text + "%';"
            cmdOLEDB.CommandType = CommandType.Text
            cmdOLEDB.Connection = cnnOLEDB

            'EXECUTE Reader
            drOLEDB = cmdOLEDB.ExecuteReader()

            If drOLEDB.Read = True Then

                'CLOSE Reader
                drOLEDB.Close()

                'Fill selected database table into grid
                p_search_table.Clear()
                daOLEDB.SelectCommand = cmdOLEDB
                daOLEDB.Fill(p_search_table)
                GridPR.DataSource = p_search_table
            Else
                'CLOSE Reader
                drOLEDB.Close()

                MessageBox.Show("Record not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            cnnOLEDB.Close()

        ElseIf TxtPName.Text = "" And TxtPID.Text = "" Then

            'Refer below
            P_Data_Table()

        End If

        TxtPID.Clear()
        TxtPName.Clear()
        TxtPID.Focus()

    End Sub



    'VIEW TREATMENT BUTTON  
    Private Sub BtnViewT_Click(sender As Object, e As EventArgs) Handles BtnViewT.Click

        If DataVar2 = 1 Then
            'Store patient ID in public variable to be accessed by treatment form
            Dim TreatmentRecord As New TreatmentRecord
            TreatmentRecord.ShowDialog()
        Else
            MessageBox.Show("Please select a record in the data grid view to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        DataVar2 = Nothing

    End Sub



    'FORM CLOSING EVENT
    Private Sub Doctor_Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case MessageBox.Show("Do you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            Case MsgBoxResult.Yes
                e.Cancel = False
            Case MsgBoxResult.No
                e.Cancel = True
        End Select
    End Sub

End Class