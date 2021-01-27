Imports System.Data.OleDb

Public Class TreatmentRecord

    'DEFINING VARIABLE
    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim drOLEDB As OleDbDataReader
    Dim daOLEDB As New OleDbDataAdapter
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = C:OceanaData.mdb"

    Dim Treatment_table As New DataTable
    Dim row, count, DataVar1 As Integer
    Dim var, var2, var3, var4, var5, t_record(10) As String



    'FORM LOAD EVENT
    Private Sub TreatmentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con
        T_Data_Table()

        NumD.Text = ""
        NumM.Text = ""
        NumY.Text = ""
    End Sub



    'DELETE RECORD
    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click

        cnnOLEDB.Open()

        If DataVar1 = 1 Then
            Select Case MessageBox.Show("Confirm delete staff record " & t_record(0) & "?", "Successful", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                Case MsgBoxResult.Yes
                    'SQL Command
                    cmdOLEDB.CommandText = "DELETE FROM [treatment] WHERE TreatmentID = '" + t_record(0) + "';"
                    cmdOLEDB.CommandType = CommandType.Text
                    cmdOLEDB.Connection = cnnOLEDB

                    'Execute command
                    cmdOLEDB.ExecuteNonQuery()
            End Select
        Else
            MessageBox.Show("Please select a record in the data grid view to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        cnnOLEDB.Close()
        DataVar1 = Nothing
        T_Data_Table()

    End Sub



    'SAVE DATABASE RECORD INTO VARIABLE
    'Variable brings saved data to another form
    Private Sub GridTR_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridTR.CellClick

        DataVar1 = 1
        If e.RowIndex >= 0 Then
            row = GridTR.CurrentRow.Index

            For count = 0 To 10
                t_record(count) = GridTR.Rows(row).Cells(count).Value.ToString()
            Next
        End If

    End Sub



    'NEW BUTTON
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Dim TreatmentRecord_New As New TreatmentRecord_New
        TreatmentRecord_New.ShowDialog()
        T_Data_Table()
    End Sub



    'EDIT BUTTON
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        If DataVar1 = 1 Then
            With TreatmentRecord_Edit
                TransTID = t_record(0)
                .NumY.Value = t_record(2)
                .NumM.Value = t_record(3)
                .NumD.Value = t_record(4)
                .TxtTime.Text = t_record(5)
                .TxtROV.Text = t_record(6)
                .TxtDiag.Text = t_record(7)
                .TxtMed.Text = t_record(8)
                .TxtDos.Text = t_record(9)
                .TxtNotes.Text = t_record(10)
                .ShowDialog()
            End With
            T_Data_Table()
        Else
            MessageBox.Show("Please select a record in the data grid view to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        DataVar1 = Nothing

    End Sub



    'SEARCH BUTTON
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        'To determine which SQL Command to execute
        'Each condition determine which variable to be used
        If NumD.Text <> "" Then
            If NumM.Text <> "" Then
                If NumY.Text <> "" Then
                    var = "[DateD] LIKE '" + NumD.Text + "'" 'All present
                    var3 = "AND [DateM] LIKE '" + NumM.Text + "'"
                    var5 = "AND [DateY] LIKE '" + NumY.Text + "'"
                    STreatment()
                Else
                    var = "[DateD] LIKE '" + NumD.Text + "'" '1st and 2nd present
                    var3 = "AND [DateM] LIKE '" + NumM.Text + "'"
                    STreatment()
                End If
            Else
                If NumY.Text <> "" Then
                    var = "[DateD] LIKE '" + NumD.Text + "'" '1st and 3rd present
                    var5 = "AND [DateY] LIKE '" + NumY.Text + "'"
                    STreatment()
                Else
                    var = "[DateD] LIKE '" + NumD.Text + "'" '1st present
                    STreatment()
                End If
            End If
        Else
            If NumM.Text <> "" Then
                If NumY.Text <> "" Then
                    var2 = "[DateM] LIKE '" + NumM.Text + "'" '2nd and 3rd present
                    var5 = "AND [DateY] LIKE '" + NumY.Text + "'"
                    STreatment()
                Else
                    var2 = "[DateM] LIKE '" + NumM.Text + "'" '2nd present
                    STreatment()
                End If
            Else
                If NumY.Text <> "" Then
                    var4 = "[DateY] LIKE '" + NumY.Text + "'" '3rd present
                    STreatment()
                Else
                    T_Data_Table() 'All not present
                End If
            End If
        End If

        'Clear combobox
        NumD.Text = ""
        NumM.Text = ""
        NumY.Text = ""

        'clear variable
        var = ""
        var2 = ""
        var3 = ""
        var4 = ""
        var5 = ""

    End Sub



    'ESTABLISH CONNECTION TO STAFF TABLE
    Private Sub T_Data_Table()

        cnnOLEDB.Open()

        'SQL Command
        cmdOLEDB.CommandText = "SELECT * FROM [Treatment] WHERE [PatientID] = '" + TransID + "';"
        cmdOLEDB.CommandType = CommandType.Text
        cmdOLEDB.Connection = cnnOLEDB

        'Fill all database table into grid
        daOLEDB.SelectCommand = cmdOLEDB
        treatment_table.Clear()
        daOLEDB.Fill(treatment_table)
        GridTR.DataSource = treatment_table

        cnnOLEDB.Close()

    End Sub



    'SEARCH FUNCTION
    Private Sub STreatment()

        cnnOLEDB.Open()

        'SQL Command for ID
        cmdOLEDB.CommandText = "SELECT * FROM [Treatment] WHERE [PatientID] = '" + TransID + "' AND " & var & var2 & var3 & var4 & var5 & ";"
        cmdOLEDB.CommandType = CommandType.Text
        cmdOLEDB.Connection = cnnOLEDB

        'EXECUTE Reader
        drOLEDB = cmdOLEDB.ExecuteReader()

        If drOLEDB.Read = True Then

            'CLOSE Reader
            drOLEDB.Close()

            'Fill selected database table into grid
            Treatment_table.Clear()
            daOLEDB.SelectCommand = cmdOLEDB
            daOLEDB.Fill(Treatment_table)
            GridTR.DataSource = Treatment_table
        Else
            'CLOSE Reader
            drOLEDB.Close()

            MessageBox.Show("Record not found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        cnnOLEDB.Close()

    End Sub

End Class