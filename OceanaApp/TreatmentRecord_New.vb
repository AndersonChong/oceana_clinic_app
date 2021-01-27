Imports System.Data.OleDb

Public Class TreatmentRecord_New

    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = C:OceanaData.mdb"
    Dim CloseVar, IDNum As Integer
    Dim StoreID As String



    'ESTABLISH CONNECTION
    Private Sub TreatmentRecord_New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con 'OPEN Connection
        IncrementID()
        CloseVar = 1
    End Sub



    'SAVE BUTTON
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If NumD.Text <> "" And NumM.Text <> "" And NumY.Text <> "" And TxtTime.Text <> "" And TxtROV.Text <> "" And TxtDiag.Text <> "" And TxtMed.Text <> "" And TxtDos.Text <> "" And TxtNotes.Text <> "" Then

            If IsNumeric(NumD.Text) = True And IsNumeric(NumM.Text) = True And IsNumeric(NumY.Text) = True Then
                Try
                    'OPEN Connection
                    cnnOLEDB.Open()

                    'SQL Command
                    cmdOLEDB.CommandText = "INSERT INTO [Treatment] VALUES ('" + StoreID + "', '" + TransID + "'," + NumY.Text + "," + NumM.Text + "," + NumD.Text + ",'" + TxtTime.Text + "','" + TxtROV.Text + "','" + TxtDiag.Text + "','" + TxtMed.Text + "','" + TxtDos.Text + "','" + TxtNotes.Text + "');"
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



    'FORM CLOSING EVENT
    Private Sub TreatmentRecord_New_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

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
        cmdOLEDB.CommandText = "SELECT MAX (TreatmentID) FROM [Treatment];"
        cmdOLEDB.CommandType = CommandType.Text
        cmdOLEDB.Connection = cnnOLEDB

        StoreID = cmdOLEDB.ExecuteScalar()
        IDNum = CInt(StoreID.Substring(1))
        IDNum += 1
        StoreID = "T" & IDNum.ToString("D3")

        cnnOLEDB.Close()

    End Sub
End Class