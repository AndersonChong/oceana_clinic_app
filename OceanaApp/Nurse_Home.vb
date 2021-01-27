Imports System.Data.OleDb

Public Class Nurse_Home

    'DEFINING VARIABLE
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim drOLEDB As OleDbDataReader
    Dim daOLEDB As New OleDbDataAdapter
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = C:OceanaData.mdb"

    Dim patient_table, billing_table, billingD_table, p_search_table, b_search_table, bd_search_table As New DataTable
    Dim row, count, DataVar2, DataVar3 As Integer
    Dim p_record(14), TransOR As String



    'FORM LOAD EVENT
    Private Sub Nurse_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        P_Data_Table()
        B_Data_Table()
    End Sub



    'SAVE DATABASE RECORD INTO VARIABLE
    'Variable brings saved data to another form
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridPR.CellContentClick

        DataVar2 = 1
        If e.RowIndex >= 0 Then
            row = GridPR.CurrentRow.Index

            For count = 0 To 14
                p_record(count) = GridPR.Rows(row).Cells(count).Value.ToString()
            Next
        End If
        TransID = p_record(0)

    End Sub

    'SAVE DATABASE RECORD INTO VARIABLE
    'Activate record details grid when cell is clicked
    Private Sub GridBR_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridBR.CellContentClick

        DataVar3 = 1
        If e.RowIndex >= 0 Then
            row = GridBR.CurrentRow.Index
            TransOR = GridBR.Rows(row).Cells(0).Value
            BD_Data_Table()
        End If

    End Sub



    'DISABLE PATIENT NAME
    Private Sub TxtPID_TextChanged(sender As Object, e As EventArgs) Handles TxtPID.TextChanged
        If TxtPID.Text <> "" Then
            TxtPName.Enabled = False
        Else
            TxtPName.Enabled = True
        End If
    End Sub

    'DISABLE PATIENT ID
    Private Sub TxtPName_TextChanged(sender As Object, e As EventArgs) Handles TxtPName.TextChanged
        If TxtPName.Text <> "" Then
            TxtPID.Enabled = False
        Else
            TxtPID.Enabled = True
        End If
    End Sub



    'DISABLE PATIENT ID
    Private Sub TxtOR_TextChanged(sender As Object, e As EventArgs) Handles TxtOR.TextChanged
        If TxtOR.Text <> "" Then
            TxtPID2.Enabled = False
        Else
            TxtPID2.Enabled = True
        End If
    End Sub

    'DISABLE ORDER ID
    Private Sub TxtPID2_TextChanged(sender As Object, e As EventArgs) Handles TxtPID2.TextChanged
        If TxtPID2.Text <> "" Then
            TxtOR.Enabled = False
        Else
            TxtOR.Enabled = True
        End If
    End Sub



    'SEARCH FUNCTION FOR PATIENT
    Private Sub BtnSearch1_Click(sender As Object, e As EventArgs) Handles BtnSearch1.Click

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

    'SEARCH FUNCTION FOR BILLING RECORD
    Private Sub BtnSearch3_Click(sender As Object, e As EventArgs) Handles BtnSearch3.Click

        If TxtOR.Text <> "" And TxtPID2.Text = "" Then

            cnnOLEDB.Open()

            'SQL Command for ID
            cmdOLEDB.CommandText = "SELECT * FROM [Billing] WHERE [OrderID] LIKE '%" + TxtOR.Text + "%';"
            cmdOLEDB.CommandType = CommandType.Text
            cmdOLEDB.Connection = cnnOLEDB

            'EXECUTE Reader
            drOLEDB = cmdOLEDB.ExecuteReader()

            If drOLEDB.Read = True Then

                'CLOSE Reader
                drOLEDB.Close()

                'Fill selected database table into grid
                b_search_table.Clear()
                daOLEDB.SelectCommand = cmdOLEDB
                daOLEDB.Fill(b_search_table)
                GridBR.DataSource = b_search_table
            Else
                'CLOSE Reader
                drOLEDB.Close()

                MessageBox.Show("Record not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            cnnOLEDB.Close()

        ElseIf TxtOR.Text = "" And TxtPID2.Text <> "" Then

            cnnOLEDB.Open()

            'SQL Command for ID
            cmdOLEDB.CommandText = "SELECT * FROM [Billing] WHERE [PatientID] LIKE '%" + TxtPID2.Text + "%';"
            cmdOLEDB.CommandType = CommandType.Text
            cmdOLEDB.Connection = cnnOLEDB

            'EXECUTE Reader
            drOLEDB = cmdOLEDB.ExecuteReader()

            If drOLEDB.Read = True Then

                'CLOSE Reader
                drOLEDB.Close()

                'Fill selected database table into grid
                b_search_table.Clear()
                daOLEDB.SelectCommand = cmdOLEDB
                daOLEDB.Fill(b_search_table)
                GridBR.DataSource = b_search_table
            Else
                'CLOSE Reader
                drOLEDB.Close()

                MessageBox.Show("Record not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            cnnOLEDB.Close()
        Else
            'Refer below
            B_Data_Table()
        End If

        TxtOR.Clear()
        TxtPID2.Clear()
        TxtOR.Focus()

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

    'ESTABLICH CONNECTION TO BILING RECORD TABLE
    Private Sub B_Data_Table()

        cnnOLEDB.Open()

        'SQL Command
        cmdOLEDB.CommandText = "SELECT * FROM [Billing];"
        cmdOLEDB.CommandType = CommandType.Text
        cmdOLEDB.Connection = cnnOLEDB

        'Fill all database table into grid
        daOLEDB.SelectCommand = cmdOLEDB
        billing_table.Clear()
        daOLEDB.Fill(billing_table)
        GridBR.DataSource = billing_table

        cnnOLEDB.Close()

    End Sub

    'ESTABLICH CONNECTION TO BILING RECORD DETAILS TABLE
    Private Sub BD_Data_Table()

        cnnOLEDB.Open()

        'SQL Command
        cmdOLEDB.CommandText = "SELECT * FROM [Billing_Details] WHERE OrderID = '" + TransOR + "';"
        cmdOLEDB.CommandType = CommandType.Text
        cmdOLEDB.Connection = cnnOLEDB

        'Fill all database table into grid
        daOLEDB.SelectCommand = cmdOLEDB
        billingD_table.Clear()
        daOLEDB.Fill(billingD_table)
        GridBRD.DataSource = billingD_table

        cnnOLEDB.Close()

    End Sub



    'CREATE NEW PATIENT RECORD
    Private Sub BtnNewPR_Click(sender As Object, e As EventArgs) Handles BtnNewPR.Click
        'Open New form
        Dim PatientRecord_New As New PatientRecord_New
        PatientRecord_New.ShowDialog()
        'Refresh database table
        P_Data_Table()
    End Sub

    'CREATE NEW BILLING RECORD
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        'Open New form
        Dim Billing_New As New Billing_New
        Billing_New.ShowDialog()
        'Refresh database table

        B_Data_Table()
        GridBRD.DataSource = ""
    End Sub



    'EDIT EXISTING PATIENT RECORD
    Private Sub BtnEditPR_Click(sender As Object, e As EventArgs) Handles BtnEditPR.Click

        Dim PatientRecord_Edit As New PatientRecord_Edit

        If DataVar2 = 1 Then
            With PatientRecord_Edit
                .TxtFName.Text = p_record(1)
                .TxtLName.Text = p_record(2)
                .NumY.Value = p_record(3)
                .NumM.Value = p_record(4)
                .NumD.Value = p_record(5)
                .TxtICPass.Text = p_record(6)
                .TxtAddress1.Text = p_record(7)
                .TxtAddress2.Text = p_record(8)
                .TxtMNumber.Text = p_record(9)
                .TxtEmail.Text = p_record(10)
                .TxtWeight.Text = p_record(11)
                .TxtHeight.Text = p_record(12)
                .CBoxBlood.Text = p_record(13)
                .TxtAllergies.Text = p_record(14)
                .ShowDialog()
            End With
            P_Data_Table()
        Else
            MessageBox.Show("Please select a record in the data grid view to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        DataVar2 = Nothing

    End Sub



    'DELETE EXISTING PATIENT RECORD
    Private Sub BtnDelPR_Click(sender As Object, e As EventArgs) Handles BtnDelPR.Click

        cnnOLEDB.Open()

        If DataVar2 = 1 Then
            Select Case MessageBox.Show("Confirm delete patient record " & p_record(0) & "?", "Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Case MsgBoxResult.Yes
                    'SQL Command
                    cmdOLEDB.CommandText = "DELETE FROM [Patient] WHERE PatientID = '" + p_record(0) + "';"
                    cmdOLEDB.CommandType = CommandType.Text
                    cmdOLEDB.Connection = cnnOLEDB

                    'Execute command
                    cmdOLEDB.ExecuteNonQuery()
            End Select
        Else
            MessageBox.Show("Please select a record in the data grid view to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        DataVar2 = Nothing
        cnnOLEDB.Close()
        P_Data_Table()

    End Sub

    'DELETE EXISTING BILLING RECORD
    Private Sub BtnDelBR_Click(sender As Object, e As EventArgs) Handles BtnDelBR.Click

        If DataVar3 = 1 Then
            Select Case MessageBox.Show("Confirm delete staff record " & TransOR & "?", "Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Case MsgBoxResult.Yes
                    cnnOLEDB.Open()

                    'SQL Command
                    cmdOLEDB.CommandText = "DELETE FROM [Billing] WHERE OrderID = '" + TransOR + "';"
                    cmdOLEDB.CommandType = CommandType.Text
                    cmdOLEDB.Connection = cnnOLEDB

                    'Execute command
                    cmdOLEDB.ExecuteNonQuery()

                    cnnOLEDB.Close()
                    cnnOLEDB.Open()

                    'SQL Command
                    cmdOLEDB.CommandText = "DELETE FROM [Billing_Details] WHERE OrderID = '" + TransOR + "';"
                    cmdOLEDB.CommandType = CommandType.Text
                    cmdOLEDB.Connection = cnnOLEDB

                    'Execute command
                    cmdOLEDB.ExecuteNonQuery()

                    cnnOLEDB.Close()
            End Select
        Else
            MessageBox.Show("Please select a record in the data grid view to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        DataVar3 = Nothing
        GridBRD.DataSource = ""
        B_Data_Table()

    End Sub



    'FORM CLOSING EVENT
    Private Sub Nurse_Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Select Case MessageBox.Show("Do you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            Case MsgBoxResult.Yes
                e.Cancel = False
            Case MsgBoxResult.No
                e.Cancel = True
        End Select
    End Sub

End Class