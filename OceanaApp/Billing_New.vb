Imports System.Data.OleDb

Public Class Billing_New

    Dim cnnOLEDB As New OleDbConnection
    Dim cmdOLEDB As New OleDbCommand
    Dim drOLEDB As OleDbDataReader
    Dim con = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source = C:OceanaData.mdb"
    Dim CloseVar As Integer
    Dim BS_Data_Table As New DataTable
    Dim DataRow As DataRow

    Dim StoreID, FName, LName As String
    Dim IDNum, RCount, CCount, ACount, MPrice, SPrice, TPrice, ChkVar As Integer



    'FORM LOAD EVENT
    Private Sub Billing_New_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cnnOLEDB.ConnectionString = con 'OPEN Connection
        IncrementID()
        CloseVar = 1

        GridLoad()
    End Sub



    'CHECKBOX 1
    Private Sub ChkLab_CheckedChanged(sender As Object, e As EventArgs) Handles ChkLab.CheckedChanged

        If ChkLab.CheckState = 1 Then
            BS_Data_Table.Rows.Add(StoreID, "SV001", "1")
        Else
            If BS_Data_Table.Rows.Contains("SV001") Then
                DataRow = BS_Data_Table.Rows.Find("SV001")
                BS_Data_Table.Rows.Remove(DataRow)
            End If
        End If

    End Sub

    'CHECKBOX 2
    Private Sub ChkXray_CheckedChanged(sender As Object, e As EventArgs) Handles ChkXray.CheckedChanged

        If ChkXray.CheckState = 1 Then
            BS_Data_Table.Rows.Add(StoreID, "SV002", "1")
        Else
            If BS_Data_Table.Rows.Contains("SV002") Then
                DataRow = BS_Data_Table.Rows.Find("SV002")
                BS_Data_Table.Rows.Remove(DataRow)
            End If
        End If

    End Sub

    'CHECKBOX 3
    Private Sub ChkCHC_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCHC.CheckedChanged

        If ChkCHC.CheckState = 1 Then
            BS_Data_Table.Rows.Add(StoreID, "SV003", "1")
        Else
            If BS_Data_Table.Rows.Contains("SV003") Then
                DataRow = BS_Data_Table.Rows.Find("SV003")
                BS_Data_Table.Rows.Remove(DataRow)
            End If
        End If

    End Sub

    'CHECKBOX 4
    Private Sub ChkPHC_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPHC.CheckedChanged

        If ChkPHC.CheckState = 1 Then
            BS_Data_Table.Rows.Add(StoreID, "SV004", "1")
        Else
            If BS_Data_Table.Rows.Contains("SV004") Then
                DataRow = BS_Data_Table.Rows.Find("SV004")
                BS_Data_Table.Rows.Remove(DataRow)
            End If
        End If

    End Sub



    'ADD BUTTON
    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If CBoxMed.Text <> "" And NumQuan.Text <> "" And NumQuan.Value > 0 Then
            If GridBS.Rows.Count = 0 Then
                BS_Data_Table.Rows.Add(StoreID, CBoxMed.Text, NumQuan.Text)
                CBoxMed.Text = ""
                NumQuan.Value = 1
            Else
                For RCount = 0 To GridBS.Rows.Count - 1
                    If CBoxMed.Text = GridBS.Rows(RCount).Cells(1).Value Then
                        ChkVar = 1
                    End If
                Next
                If ChkVar <> 1 Then
                    BS_Data_Table.Rows.Add(StoreID, CBoxMed.Text, NumQuan.Text)
                    CBoxMed.Text = ""
                    NumQuan.Value = 1
                    ChkVar = 0
                Else
                    MessageBox.Show("The selected medication had been chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    ChkVar = 0
                End If
            End If
        Else
            MessageBox.Show("Please select one medication and state it's quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        CBoxMed.SelectedIndex = -1
        NumQuan.Value = 1
    End Sub



    'SAVE DATA TO DATABASE
    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click

        If NumY.Text <> "" And NumM.Text <> "" And NumD.Text <> "" And TxtPID.Text <> "" Then

            Dim bs_record(2) As String

            For RCount = 0 To GridBS.Rows.Count - 1

                For CCount = 0 To 2
                    bs_record(CCount) = GridBS.Rows(RCount).Cells(CCount).Value
                Next

                'OPEN Connection
                cnnOLEDB.Open()

                'SQL Command
                cmdOLEDB.CommandText = "INSERT INTO [Billing_Details] VALUES ('" + bs_record(0) + "', '" + bs_record(1) + "', '" + bs_record(2) + "');"
                cmdOLEDB.CommandType = CommandType.Text
                cmdOLEDB.Connection = cnnOLEDB

                'Execute command
                cmdOLEDB.ExecuteNonQuery()
                cnnOLEDB.Close()

                'Calculate Price
                If bs_record(1).Substring(0, 1) = "M" Then
                    MPrice += 10 * bs_record(2)
                ElseIf bs_record(1) = "SV001" Then
                    SPrice += 100
                ElseIf bs_record(1) = "SV002" Then
                    SPrice += 50
                ElseIf bs_record(1) = "SV003" Then
                    SPrice += 120
                ElseIf bs_record(1) = "SV004" Then
                    SPrice += 75
                End If

            Next

            'VALUE SAVE TO DATABASE
            'OPEN Connection
            cnnOLEDB.Open()

            'SQL Command
            cmdOLEDB.CommandText = "INSERT INTO [Billing] VALUES ('" + StoreID + "', '" + TxtPID.Text + "', '" + NumY.Text + "', '" + NumM.Text + "', '" + NumD.Text + "');"
            cmdOLEDB.CommandType = CommandType.Text
            cmdOLEDB.Connection = cnnOLEDB

            'Execute command
            cmdOLEDB.ExecuteNonQuery()

            cnnOLEDB.Close()

            CloseVar = 0
            'BRING DATA TO NEXT FORM
            With Billing_Calculator
                .TxtDate.Text = NumD.Text & "-" & NumM.Text & "-" & NumY.Text
                .TxtPID.Text = TxtPID.Text
                .TxtPName.Text = TxtPName.Text
                .TxtMed.Text = "RM" & MPrice
                .TxtServices.Text = "RM" & SPrice
                .TxtConsult.Text = "RM30"
                .TxtTotal.Text = "RM" & MPrice + SPrice + 30
                .ShowDialog()
            End With

            Me.Close()
        Else
            MessageBox.Show("Please fill all textbox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub



    'CHECK BUTTON
    Private Sub BtnChk_Click(sender As Object, e As EventArgs) Handles BtnChk.Click

        'OPEN Connection
        cnnOLEDB.Open()

        'SQL Command
        cmdOLEDB.CommandText = "SELECT PatientFName, PatientLName FROM [Patient] WHERE PatientID = '" + TxtPID.Text + "';"
        cmdOLEDB.CommandType = CommandType.Text
        cmdOLEDB.Connection = cnnOLEDB

        'EXECUTE Reader
        drOLEDB = cmdOLEDB.ExecuteReader()

        If drOLEDB.Read = True Then
            FName = drOLEDB.Item(0)
            LName = drOLEDB.Item(1)
            TxtPName.Text = FName & " " & LName
        Else
            MessageBox.Show("Patient ID not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtPID.Clear()
            TxtPName.Clear()
        End If

        drOLEDB.Close()
        cnnOLEDB.Close()

    End Sub



    'CANCEL BUTTON
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub



    'RESET BUTTON
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click

        Select Case MessageBox.Show("Do you want to reset all inseted information?", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            Case MsgBoxResult.Yes
                NumD.Value = 0
                NumM.Value = 0
                NumY.Value = 0
                TxtPID.Clear()
                TxtPName.Clear()
                CBoxMed.SelectedIndex = -1
                NumQuan.Value = 1
                ChkLab.CheckState = 0
                ChkXray.CheckState = 0
                ChkCHC.CheckState = 0
                ChkPHC.CheckState = 0
                BS_Data_Table.Rows.Clear()
            Case MsgBoxResult.No

        End Select
    End Sub



    'AUTO INCREMENT PRIMARY KEYS
    Private Sub IncrementID()

        'OPEN Connection
        cnnOLEDB.Open()

        'SQL Command
        cmdOLEDB.CommandText = "SELECT MAX (OrderID) FROM [Billing];"
        cmdOLEDB.CommandType = CommandType.Text
        cmdOLEDB.Connection = cnnOLEDB

        StoreID = cmdOLEDB.ExecuteScalar()
        IDNum = CInt(StoreID.Substring(2))
        IDNum += 1
        StoreID = "OR" & IDNum.ToString("D3")

        cnnOLEDB.Close()

    End Sub



    'FORM CLOSING EVENT
    Private Sub Billing_New_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If CloseVar = 1 Then
            Select Case MessageBox.Show("Do you want to cancel the procedure?", "close?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                Case MsgBoxResult.Ok
                    'CLOSE Connection
                    cnnOLEDB.Close()
                    e.Cancel = False
                Case MsgBoxResult.Cancel
                    e.Cancel = True
            End Select
        End If

    End Sub

    Private Sub GridLoad()
        GridBS.DataSource = Nothing
        BS_Data_Table.Columns.Add("OrderID")
        BS_Data_Table.Columns.Add("ItemID")
        BS_Data_Table.Columns.Add("Quantity")
        BS_Data_Table.PrimaryKey = New DataColumn() {BS_Data_Table.Columns(1)}
        GridBS.DataSource = BS_Data_Table
    End Sub
End Class