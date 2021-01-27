<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billing_New
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.NumQuan = New System.Windows.Forms.NumericUpDown()
        Me.NumY = New System.Windows.Forms.NumericUpDown()
        Me.NumM = New System.Windows.Forms.NumericUpDown()
        Me.NumD = New System.Windows.Forms.NumericUpDown()
        Me.ChkPHC = New System.Windows.Forms.CheckBox()
        Me.ChkCHC = New System.Windows.Forms.CheckBox()
        Me.ChkXray = New System.Windows.Forms.CheckBox()
        Me.ChkLab = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GridBS = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.CBoxMed = New System.Windows.Forms.ComboBox()
        Me.BtnChk = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.TxtPName = New System.Windows.Forms.TextBox()
        Me.TxtPID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.NumQuan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(785, 614)
        Me.TabControl1.TabIndex = 90
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.NumQuan)
        Me.TabPage1.Controls.Add(Me.NumY)
        Me.TabPage1.Controls.Add(Me.NumM)
        Me.TabPage1.Controls.Add(Me.NumD)
        Me.TabPage1.Controls.Add(Me.ChkPHC)
        Me.TabPage1.Controls.Add(Me.ChkCHC)
        Me.TabPage1.Controls.Add(Me.ChkXray)
        Me.TabPage1.Controls.Add(Me.ChkLab)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.BtnCancel)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.GridBS)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.BtnReset)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.BtnConfirm)
        Me.TabPage1.Controls.Add(Me.CBoxMed)
        Me.TabPage1.Controls.Add(Me.BtnChk)
        Me.TabPage1.Controls.Add(Me.BtnAdd)
        Me.TabPage1.Controls.Add(Me.TxtPName)
        Me.TabPage1.Controls.Add(Me.TxtPID)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(777, 585)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'NumQuan
        '
        Me.NumQuan.Location = New System.Drawing.Point(128, 277)
        Me.NumQuan.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumQuan.Name = "NumQuan"
        Me.NumQuan.Size = New System.Drawing.Size(121, 22)
        Me.NumQuan.TabIndex = 6
        Me.NumQuan.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumY
        '
        Me.NumY.Location = New System.Drawing.Point(228, 95)
        Me.NumY.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.NumY.Name = "NumY"
        Me.NumY.Size = New System.Drawing.Size(76, 22)
        Me.NumY.TabIndex = 2
        '
        'NumM
        '
        Me.NumM.Location = New System.Drawing.Point(178, 95)
        Me.NumM.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NumM.Name = "NumM"
        Me.NumM.Size = New System.Drawing.Size(40, 22)
        Me.NumM.TabIndex = 1
        '
        'NumD
        '
        Me.NumD.Location = New System.Drawing.Point(128, 95)
        Me.NumD.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.NumD.Name = "NumD"
        Me.NumD.Size = New System.Drawing.Size(40, 22)
        Me.NumD.TabIndex = 0
        '
        'ChkPHC
        '
        Me.ChkPHC.AutoSize = True
        Me.ChkPHC.Location = New System.Drawing.Point(128, 413)
        Me.ChkPHC.Name = "ChkPHC"
        Me.ChkPHC.Size = New System.Drawing.Size(148, 20)
        Me.ChkPHC.TabIndex = 11
        Me.ChkPHC.Text = "Partial Health Check"
        Me.ChkPHC.UseVisualStyleBackColor = True
        '
        'ChkCHC
        '
        Me.ChkCHC.AutoSize = True
        Me.ChkCHC.Location = New System.Drawing.Point(128, 387)
        Me.ChkCHC.Name = "ChkCHC"
        Me.ChkCHC.Size = New System.Drawing.Size(205, 20)
        Me.ChkCHC.TabIndex = 10
        Me.ChkCHC.Text = "Comprehensive Health Check"
        Me.ChkCHC.UseVisualStyleBackColor = True
        '
        'ChkXray
        '
        Me.ChkXray.AutoSize = True
        Me.ChkXray.Location = New System.Drawing.Point(128, 361)
        Me.ChkXray.Name = "ChkXray"
        Me.ChkXray.Size = New System.Drawing.Size(64, 20)
        Me.ChkXray.TabIndex = 9
        Me.ChkXray.Text = "X-Ray"
        Me.ChkXray.UseVisualStyleBackColor = True
        '
        'ChkLab
        '
        Me.ChkLab.AutoSize = True
        Me.ChkLab.Location = New System.Drawing.Point(128, 336)
        Me.ChkLab.Name = "ChkLab"
        Me.ChkLab.Size = New System.Drawing.Size(106, 20)
        Me.ChkLab.TabIndex = 8
        Me.ChkLab.Text = "Lab Services"
        Me.ChkLab.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Date:"
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(105, 522)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 28)
        Me.BtnCancel.TabIndex = 12
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 279)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 90
        Me.Label8.Text = "Quantity:"
        '
        'GridBS
        '
        Me.GridBS.AllowUserToAddRows = False
        Me.GridBS.AllowUserToDeleteRows = False
        Me.GridBS.AllowUserToResizeColumns = False
        Me.GridBS.AllowUserToResizeRows = False
        Me.GridBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBS.Location = New System.Drawing.Point(392, 94)
        Me.GridBS.Name = "GridBS"
        Me.GridBS.Size = New System.Drawing.Size(351, 456)
        Me.GridBS.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(227, 29)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "BILLING SERVICE"
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(186, 522)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(75, 28)
        Me.BtnReset.TabIndex = 13
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Medication:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Services:"
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Location = New System.Drawing.Point(267, 522)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(75, 28)
        Me.BtnConfirm.TabIndex = 14
        Me.BtnConfirm.Text = "Confirm"
        Me.BtnConfirm.UseVisualStyleBackColor = True
        '
        'CBoxMed
        '
        Me.CBoxMed.DropDownHeight = 80
        Me.CBoxMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBoxMed.FormattingEnabled = True
        Me.CBoxMed.IntegralHeight = False
        Me.CBoxMed.Items.AddRange(New Object() {"M001", "M002", "M003", "M004", "M005", "M006", "M007", "M008", "M009", "M010", "M011", "M012", "M013", "M014", "M015", "M016", "M017", "M018", "M019", "M020"})
        Me.CBoxMed.Location = New System.Drawing.Point(128, 245)
        Me.CBoxMed.Name = "CBoxMed"
        Me.CBoxMed.Size = New System.Drawing.Size(121, 24)
        Me.CBoxMed.TabIndex = 5
        '
        'BtnChk
        '
        Me.BtnChk.Location = New System.Drawing.Point(255, 153)
        Me.BtnChk.Name = "BtnChk"
        Me.BtnChk.Size = New System.Drawing.Size(77, 24)
        Me.BtnChk.TabIndex = 4
        Me.BtnChk.Text = "Check"
        Me.BtnChk.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(255, 275)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(77, 24)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtPName
        '
        Me.TxtPName.Location = New System.Drawing.Point(128, 186)
        Me.TxtPName.Name = "TxtPName"
        Me.TxtPName.ReadOnly = True
        Me.TxtPName.Size = New System.Drawing.Size(121, 22)
        Me.TxtPName.TabIndex = 82
        '
        'TxtPID
        '
        Me.TxtPID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPID.Location = New System.Drawing.Point(128, 154)
        Me.TxtPID.Name = "TxtPID"
        Me.TxtPID.Size = New System.Drawing.Size(121, 22)
        Me.TxtPID.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 16)
        Me.Label7.TabIndex = 90
        Me.Label7.Text = "Patient Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Patient ID:"
        '
        'Billing_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 638)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Billing_New"
        Me.Text = "Billing Service"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.NumQuan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents GridBS As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnReset As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents CBoxMed As ComboBox
    Friend WithEvents BtnChk As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtPName As TextBox
    Friend WithEvents TxtPID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ChkPHC As CheckBox
    Friend WithEvents ChkCHC As CheckBox
    Friend WithEvents ChkXray As CheckBox
    Friend WithEvents ChkLab As CheckBox
    Friend WithEvents NumY As NumericUpDown
    Friend WithEvents NumM As NumericUpDown
    Friend WithEvents NumD As NumericUpDown
    Friend WithEvents NumQuan As NumericUpDown
End Class
