<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login_Form
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
        Me.LblUser = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.TxtUserID = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.Location = New System.Drawing.Point(34, 127)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(56, 16)
        Me.LblUser.TabIndex = 90
        Me.LblUser.Text = "User ID:"
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.Location = New System.Drawing.Point(34, 164)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(71, 16)
        Me.LblPass.TabIndex = 90
        Me.LblPass.Text = "Password:"
        '
        'TxtUserID
        '
        Me.TxtUserID.Location = New System.Drawing.Point(119, 124)
        Me.TxtUserID.Name = "TxtUserID"
        Me.TxtUserID.Size = New System.Drawing.Size(233, 22)
        Me.TxtUserID.TabIndex = 0
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(119, 161)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(233, 22)
        Me.TxtPassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(209, 29)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "OCEANA CLINIC"
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(277, 202)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(75, 28)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'Login_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 286)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUserID)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.LblUser)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login_Form"
        Me.Text = "Oceana Clinic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUser As Label
    Friend WithEvents LblPass As Label
    Friend WithEvents TxtUserID As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnLogin As Button
End Class
