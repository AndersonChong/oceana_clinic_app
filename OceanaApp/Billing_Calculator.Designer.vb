<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing_Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPID = New System.Windows.Forms.TextBox()
        Me.TxtServices = New System.Windows.Forms.TextBox()
        Me.TxtPName = New System.Windows.Forms.TextBox()
        Me.TxtMed = New System.Windows.Forms.TextBox()
        Me.TxtConsult = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtPaid = New System.Windows.Forms.TextBox()
        Me.TxtChange = New System.Windows.Forms.TextBox()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtDate = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 16)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Patient ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 29)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "BILLING SERVICE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Patient Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Medication:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 225)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Services:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 257)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Consultation:"
        '
        'TxtPID
        '
        Me.TxtPID.Location = New System.Drawing.Point(141, 126)
        Me.TxtPID.Name = "TxtPID"
        Me.TxtPID.ReadOnly = True
        Me.TxtPID.Size = New System.Drawing.Size(240, 22)
        Me.TxtPID.TabIndex = 90
        '
        'TxtServices
        '
        Me.TxtServices.Location = New System.Drawing.Point(141, 222)
        Me.TxtServices.Name = "TxtServices"
        Me.TxtServices.ReadOnly = True
        Me.TxtServices.Size = New System.Drawing.Size(240, 22)
        Me.TxtServices.TabIndex = 90
        '
        'TxtPName
        '
        Me.TxtPName.Location = New System.Drawing.Point(141, 158)
        Me.TxtPName.Name = "TxtPName"
        Me.TxtPName.ReadOnly = True
        Me.TxtPName.Size = New System.Drawing.Size(240, 22)
        Me.TxtPName.TabIndex = 90
        '
        'TxtMed
        '
        Me.TxtMed.Location = New System.Drawing.Point(141, 190)
        Me.TxtMed.Name = "TxtMed"
        Me.TxtMed.ReadOnly = True
        Me.TxtMed.Size = New System.Drawing.Size(240, 22)
        Me.TxtMed.TabIndex = 90
        '
        'TxtConsult
        '
        Me.TxtConsult.Location = New System.Drawing.Point(141, 251)
        Me.TxtConsult.Name = "TxtConsult"
        Me.TxtConsult.ReadOnly = True
        Me.TxtConsult.Size = New System.Drawing.Size(240, 22)
        Me.TxtConsult.TabIndex = 90
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 16)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Total:"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(141, 286)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(240, 22)
        Me.TxtTotal.TabIndex = 90
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 321)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Paid:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 353)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 16)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Change:"
        '
        'TxtPaid
        '
        Me.TxtPaid.Location = New System.Drawing.Point(141, 318)
        Me.TxtPaid.Name = "TxtPaid"
        Me.TxtPaid.Size = New System.Drawing.Size(240, 22)
        Me.TxtPaid.TabIndex = 0
        '
        'TxtChange
        '
        Me.TxtChange.Location = New System.Drawing.Point(141, 350)
        Me.TxtChange.Name = "TxtChange"
        Me.TxtChange.ReadOnly = True
        Me.TxtChange.Size = New System.Drawing.Size(240, 22)
        Me.TxtChange.TabIndex = 90
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Location = New System.Drawing.Point(306, 404)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(75, 28)
        Me.BtnConfirm.TabIndex = 2
        Me.BtnConfirm.Text = "Confirm"
        Me.BtnConfirm.UseVisualStyleBackColor = True
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(225, 404)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(75, 28)
        Me.BtnCalculate.TabIndex = 1
        Me.BtnCalculate.Text = "Calculate"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(39, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 90
        Me.Label11.Text = "Date:"
        '
        'TxtDate
        '
        Me.TxtDate.Location = New System.Drawing.Point(141, 98)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.ReadOnly = True
        Me.TxtDate.Size = New System.Drawing.Size(240, 22)
        Me.TxtDate.TabIndex = 90
        '
        'Billing_Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 471)
        Me.Controls.Add(Me.TxtDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.TxtChange)
        Me.Controls.Add(Me.TxtPaid)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtConsult)
        Me.Controls.Add(Me.TxtMed)
        Me.Controls.Add(Me.TxtPName)
        Me.Controls.Add(Me.TxtServices)
        Me.Controls.Add(Me.TxtPID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Billing_Calculator"
        Me.Text = "Oceana - Thank You!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPID As TextBox
    Friend WithEvents TxtServices As TextBox
    Friend WithEvents TxtPName As TextBox
    Friend WithEvents TxtMed As TextBox
    Friend WithEvents TxtConsult As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtPaid As TextBox
    Friend WithEvents TxtChange As TextBox
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents BtnCalculate As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtDate As TextBox
End Class
