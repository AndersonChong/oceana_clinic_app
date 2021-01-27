Imports System.Data.OleDb

Public Class PatientRecord_New

    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = C:OceanaData.mdb"
    Dim CloseVar As Integer

    Dim StoreID As String
    Dim IDNum As Integer



    'ESTABLISH CONNECTION
    Private Sub PatientRecord_New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con 'OPEN Connection
        IncrementID()
        CloseVar = 1
    End Sub



    'CREATE NEW RECORD
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If TxtFName.Text <> "" And TxtLName.Text <> "" And NumY.Text <> "" And NumM.Text <> "" And NumD.Text <> "" And TxtICPass.Text <> "" And TxtAddress1.Text <> "" And TxtAddress2.Text <> "" And TxtMNumber.Text <> "" And TxtEmail.Text <> "" And TxtWeight.Text <> "" And TxtHeight.Text <> "" And CBoxBlood.Text <> "" And TxtAllergies.Text <> "" Then

            If IsNumeric(NumY.Text) = True And IsNumeric(NumM.Text) = True And IsNumeric(NumD.Text) = True Then
                Try
                    'OPEN Connection
                    cnnOLEDB.Open()

                    'SQL Command
                    cmdOLEDB.CommandText = "INSERT INTO [PATIENT] VALUES ('" + StoreID + "','" + TxtFName.Text + "','" + TxtLName.Text + "'," + NumY.Text + "," + NumM.Text + "," + NumD.Text + ",'" + TxtICPass.Text + "','" + TxtAddress1.Text + "','" + TxtAddress2.Text + "','" + TxtMNumber.Text + "','" + TxtEmail.Text + "','" + TxtWeight.Text + "','" + TxtHeight.Text + "','" + CBoxBlood.Text + "','" + TxtAllergies.Text + "');"
                    cmdOLEDB.CommandType = CommandType.Text
                    cmdOLEDB.Connection = cnnOLEDB

                    'Execute command
                    cmdOLEDB.ExecuteNonQuery()
                    MessageBox.Show("New record created successfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    CloseVar = 0
                    Me.Close()

                Catch ex As Exception
                    'Error message if create unsuccessful
                    MessageBox.Show("Unsuccessful, error in code", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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



    'CANCEL BUTTON
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub



    'CLOSE FORM EVENT
    Private Sub PatientRecord_New_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If CloseVar = 1 Then
            Select Case MessageBox.Show("confirm close mou", "close?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                Case MsgBoxResult.Ok
                    'CLOSE Connection
                    cnnOLEDB.Close()
                    e.Cancel = False
                Case MsgBoxResult.Cancel
                    e.Cancel = True
            End Select
        Else
            'CLOSE Connection
            cnnOLEDB.Close()
        End If

    End Sub



    'AUTO INCREMENT PRIMARY KEYS
    Private Sub IncrementID()

        'OPEN Connection
        cnnOLEDB.Open()

        'SQL Command
        cmdOLEDB.CommandText = "SELECT MAX (PatientID) FROM [Patient];"
        cmdOLEDB.CommandType = CommandType.Text
        cmdOLEDB.Connection = cnnOLEDB

        StoreID = cmdOLEDB.ExecuteScalar()
        IDNum = CInt(StoreID.Substring(1))
        IDNum += 1
        StoreID = "P" & IDNum.ToString("D3")

        cnnOLEDB.Close()

    End Sub

End Class