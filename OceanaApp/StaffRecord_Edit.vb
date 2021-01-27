Imports System.Data.OleDb

Public Class StaffRecord_Edit

    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = C:OceanaData.mdb"
    Dim CloseVar As Integer



    'SAVE BUTTON
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If TxtFName.Text <> "" And TxtLName.Text <> "" And NumY.Text <> "" And NumM.Text <> "" And NumD.Text <> "" And TxtICPass.Text <> "" And TxtAddress1.Text <> "" And TxtAddress2.Text <> "" And TxtMNumber.Text <> "" And TxtEmail.Text <> "" And CBoxPos.Text <> "" And CBoxAvai.Text <> "" And TxtPass.Text <> "" Then

            If IsNumeric(NumY.Text) = True And IsNumeric(NumM.Text) = True And IsNumeric(NumD.Text) = True Then
                Try
                    'OPEN Connection
                    cnnOLEDB.Open()

                    'SQL Command
                    cmdOLEDB.CommandText = "UPDATE [Staff] SET StaffFName = '" + TxtFName.Text + "', StaffLName = '" + TxtLName.Text + "', SAgeY = " + NumY.Text + ", SAgeM = " + NumM.Text + ", SAgeD = " + NumD.Text + ", ICPassword = '" + TxtICPass.Text + "', AddressLine1 = '" + TxtAddress1.Text + "', AddressLine2 = '" + TxtAddress2.Text + "', MobileNo = '" + TxtMNumber.Text + "', Email = '" + TxtEmail.Text + "', [Position] = '" + CBoxPos.Text + "', Availability = '" + CBoxAvai.Text + "', [Password] = '" + TxtPass.Text + "' WHERE [StaffID] = '" + TransSID + "';"
                    cmdOLEDB.CommandType = CommandType.Text
                    cmdOLEDB.Connection = cnnOLEDB

                    'Execute command
                    cmdOLEDB.ExecuteNonQuery()
                    MessageBox.Show("Record updated successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    'Open admin home page
                    Administrator_Home.Show()

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



    'FORM LOAD EVENT
    'ESTABLISH CONNECTION
    Private Sub StaffRecord_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cnnOLEDB.ConnectionString = con 'OPEN Connection
        CloseVar = 1 'Set value to close variable

    End Sub



    'CANCEL BUTTON
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub



    'CLOSE FORM EVENT
    Private Sub StaffRecord_Edit_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

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

End Class