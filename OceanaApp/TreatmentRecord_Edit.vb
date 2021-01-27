Imports System.Data.OleDb

Public Class TreatmentRecord_Edit

    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = C:OceanaData.mdb"
    Dim StoreID As String
    Dim CloseVar As Integer



    'FORM LOAD EVENT
    'ESTABLISH CONNECTION
    Private Sub TreatmentRecord_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con 'OPEN Connection

        CloseVar = 1 'Set value to close variable
    End Sub



    'SAVE BUTTON
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If NumD.Text <> "" And NumM.Text <> "" And NumY.Text <> "" And TxtTime.Text <> "" And TxtROV.Text <> "" And TxtDiag.Text <> "" And TxtMed.Text <> "" And TxtDos.Text <> "" And TxtNotes.Text <> "" Then

            If IsNumeric(NumD.Text) = True And IsNumeric(NumM.Text) = True And IsNumeric(NumY.Text) = True Then
                Try
                    'OPEN Connection
                    cnnOLEDB.Open()

                    'SQL Command
                    cmdOLEDB.CommandText = "UPDATE [Treatment] SET DateY = " + NumY.Text + ", DateM = " + NumM.Text + ", DateD = " + NumD.Text + ", [Time] = '" + TxtTime.Text + "', ROV = '" + TxtROV.Text + "', Diagnosis = '" + TxtDiag.Text + "', Medication = '" + TxtMed.Text + "', Dosage = '" + TxtDos.Text + "', Notes = '" + TxtNotes.Text + "' WHERE [TreatmentID] = '" + TransTID + "';"
                    cmdOLEDB.CommandType = CommandType.Text
                    cmdOLEDB.Connection = cnnOLEDB

                    'Execute command
                    cmdOLEDB.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    CloseVar = 0
                    Me.Close()

                Catch ex As Exception
                    'Error message if create unsuccessful (either code error or duplication of primary key)
                    MessageBox.Show("Unsuccessful", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End Try
            Else
                'Error message if date is not number
                MessageBox.Show("Please insert number values only in DOB", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            'Error message if all textboxes are not filled in
            MessageBox.Show("Please fill in all information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub



    'FORM CLOSING EVENT
    Private Sub TreatmentRecord_Edit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If CloseVar = 1 Then
            Select Case MessageBox.Show("Do you want to cancel this procedure?", "Cancel procedure", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                Case MsgBoxResult.Yes
                    'CLOSE Connection
                    cnnOLEDB.Close()
                    e.Cancel = False
                Case MsgBoxResult.No
                    e.Cancel = True
            End Select
        Else
            'CLOSE Connection
            cnnOLEDB.Close()
        End If

    End Sub



    'CANCEL BUTTON
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class