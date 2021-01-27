<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffRecord_Edit
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.CBoxPos = New System.Windows.Forms.ComboBox()
        Me.CBoxAvai = New System.Windows.Forms.ComboBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAddress2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFName = New System.Windows.Forms.TextBox()
        Me.TxtAddress1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtLName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtICPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.NumY = New System.Windows.Forms.NumericUpDown()
        Me.NumM = New System.Windows.Forms.NumericUpDown()
        Me.NumD = New System.Windows.Forms.NumericUpDown()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.NumY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(538, 412)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 28)
        Me.BtnCancel.TabIndex = 13
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(619, 412)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 28)
        Me.BtnSave.TabIndex = 14
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'CBoxPos
        '
        Me.CBoxPos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxPos.FormattingEnabled = True
        Me.CBoxPos.Items.AddRange(New Object() {"Administrator", "Doctor", "Nurse"})
        Me.CBoxPos.Location = New System.Drawing.Point(514, 122)
        Me.CBoxPos.Name = "CBoxPos"
        Me.CBoxPos.Size = New System.Drawing.Size(180, 24)
        Me.CBoxPos.TabIndex = 10
        '
        'CBoxAvai
        '
        Me.CBoxAvai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxAvai.FormattingEnabled = True
        Me.CBoxAvai.Items.AddRange(New Object() {"Yes", "No"})
        Me.CBoxAvai.Location = New System.Drawing.Point(514, 154)
        Me.CBoxAvai.Name = "CBoxAvai"
        Me.CBoxAvai.Size = New System.Drawing.Size(180, 24)
        Me.CBoxAvai.TabIndex = 11
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(514, 186)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(180, 22)
        Me.TxtPass.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.SystemColors.Window
        Me.Label14.Location = New System.Drawing.Point(404, 189)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(71, 16)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "Password:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.SystemColors.Window
        Me.Label13.Location = New System.Drawing.Point(404, 157)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 16)
        Me.Label13.TabIndex = 90
        Me.Label13.Text = "Availabilty:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.SystemColors.Window
        Me.Label12.Location = New System.Drawing.Point(404, 125)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "Position:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.Window
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(402, 41)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 29)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "STAFF INFO"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(159, 346)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(180, 22)
        Me.TxtEmail.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.Window
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(48, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(264, 29)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "PERSONAL DETAILS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(50, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "First Name:"
        '
        'TxtMNumber
        '
        Me.TxtMNumber.Location = New System.Drawing.Point(159, 314)
        Me.TxtMNumber.Name = "TxtMNumber"
        Me.TxtMNumber.Size = New System.Drawing.Size(180, 22)
        Me.TxtMNumber.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(50, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Date of Birth:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(50, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Last Name:"
        '
        'TxtAddress2
        '
        Me.TxtAddress2.Location = New System.Drawing.Point(159, 279)
        Me.TxtAddress2.Name = "TxtAddress2"
        Me.TxtAddress2.Size = New System.Drawing.Size(180, 22)
        Me.TxtAddress2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(50, 253)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Address Line 1:"
        '
        'TxtFName
        '
        Me.TxtFName.Location = New System.Drawing.Point(159, 122)
        Me.TxtFName.Name = "TxtFName"
        Me.TxtFName.Size = New System.Drawing.Size(180, 22)
        Me.TxtFName.TabIndex = 2
        '
        'TxtAddress1
        '
        Me.TxtAddress1.Location = New System.Drawing.Point(159, 250)
        Me.TxtAddress1.Name = "TxtAddress1"
        Me.TxtAddress1.Size = New System.Drawing.Size(180, 22)
        Me.TxtAddress1.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.Window
        Me.Label5.Location = New System.Drawing.Point(50, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Address Line 2:"
        '
        'TxtLName
        '
        Me.TxtLName.Location = New System.Drawing.Point(159, 154)
        Me.TxtLName.Name = "TxtLName"
        Me.TxtLName.Size = New System.Drawing.Size(180, 22)
        Me.TxtLName.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.Window
        Me.Label6.Location = New System.Drawing.Point(50, 317)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Mobile Number:"
        '
        'TxtICPass
        '
        Me.TxtICPass.Location = New System.Drawing.Point(159, 218)
        Me.TxtICPass.Name = "TxtICPass"
        Me.TxtICPass.Size = New System.Drawing.Size(180, 22)
        Me.TxtICPass.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.Window
        Me.Label7.Location = New System.Drawing.Point(50, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "E-mail:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Window
        Me.Label8.Location = New System.Drawing.Point(50, 221)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "IC/ Passport:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(757, 510)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.NumY)
        Me.TabPage1.Controls.Add(Me.NumM)
        Me.TabPage1.Controls.Add(Me.NumD)
        Me.TabPage1.Controls.Add(Me.BtnCancel)
        Me.TabPage1.Controls.Add(Me.BtnSave)
        Me.TabPage1.Controls.Add(Me.CBoxPos)
        Me.TabPage1.Controls.Add(Me.CBoxAvai)
        Me.TabPage1.Controls.Add(Me.TxtPass)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.TxtEmail)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxtMNumber)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.TxtAddress2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TxtFName)
        Me.TabPage1.Controls.Add(Me.TxtAddress1)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TxtLName)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.TxtICPass)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(749, 481)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'NumY
        '
        Me.NumY.Location = New System.Drawing.Point(259, 187)
        Me.NumY.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.NumY.Name = "NumY"
        Me.NumY.Size = New System.Drawing.Size(80, 22)
        Me.NumY.TabIndex = 4
        '
        'NumM
        '
        Me.NumM.Location = New System.Drawing.Point(209, 187)
        Me.NumM.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NumM.Name = "NumM"
        Me.NumM.Size = New System.Drawing.Size(44, 22)
        Me.NumM.TabIndex = 3
        '
        'NumD
        '
        Me.NumD.Location = New System.Drawing.Point(159, 187)
        Me.NumD.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.NumD.Name = "NumD"
        Me.NumD.Size = New System.Drawing.Size(44, 22)
        Me.NumD.TabIndex = 2
        '
        'StaffRecord_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 534)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StaffRecord_Edit"
        Me.Text = "Staff Record"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.NumY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents CBoxPos As ComboBox
    Friend WithEvents CBoxAvai As ComboBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtMNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtAddress2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtFName As TextBox
    Friend WithEvents TxtAddress1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtLName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtICPass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents NumY As NumericUpDown
    Friend WithEvents NumM As NumericUpDown
    Friend WithEvents NumD As NumericUpDown
End Class
