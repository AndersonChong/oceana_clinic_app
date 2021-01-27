<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Administrator_Home
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtSID = New System.Windows.Forms.TextBox()
        Me.BtnSearch1 = New System.Windows.Forms.Button()
        Me.TxtSName = New System.Windows.Forms.TextBox()
        Me.BtnNewSR = New System.Windows.Forms.Button()
        Me.BtnEditSR = New System.Windows.Forms.Button()
        Me.BtnDelSR = New System.Windows.Forms.Button()
        Me.GridSR = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BtnViewT = New System.Windows.Forms.Button()
        Me.TxtPID = New System.Windows.Forms.TextBox()
        Me.BtnSearch2 = New System.Windows.Forms.Button()
        Me.TxtPName = New System.Windows.Forms.TextBox()
        Me.BtnNewPR = New System.Windows.Forms.Button()
        Me.BtnEditPR = New System.Windows.Forms.Button()
        Me.BtnDelPR = New System.Windows.Forms.Button()
        Me.GridPR = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GridBRD = New System.Windows.Forms.DataGridView()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnDelBR = New System.Windows.Forms.Button()
        Me.TxtPID2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtOR = New System.Windows.Forms.TextBox()
        Me.BtnSearch3 = New System.Windows.Forms.Button()
        Me.GridBR = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridSR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.GridPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.GridBRD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridBR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(787, 625)
        Me.TabControl1.TabIndex = 90
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TxtSID)
        Me.TabPage2.Controls.Add(Me.BtnSearch1)
        Me.TabPage2.Controls.Add(Me.TxtSName)
        Me.TabPage2.Controls.Add(Me.BtnNewSR)
        Me.TabPage2.Controls.Add(Me.BtnEditSR)
        Me.TabPage2.Controls.Add(Me.BtnDelSR)
        Me.TabPage2.Controls.Add(Me.GridSR)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(779, 596)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Staff Record"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtSID
        '
        Me.TxtSID.Location = New System.Drawing.Point(26, 542)
        Me.TxtSID.Name = "TxtSID"
        Me.TxtSID.Size = New System.Drawing.Size(68, 22)
        Me.TxtSID.TabIndex = 0
        '
        'BtnSearch1
        '
        Me.BtnSearch1.Location = New System.Drawing.Point(220, 539)
        Me.BtnSearch1.Name = "BtnSearch1"
        Me.BtnSearch1.Size = New System.Drawing.Size(75, 28)
        Me.BtnSearch1.TabIndex = 2
        Me.BtnSearch1.Text = "Search"
        Me.BtnSearch1.UseVisualStyleBackColor = True
        '
        'TxtSName
        '
        Me.TxtSName.Location = New System.Drawing.Point(100, 542)
        Me.TxtSName.Name = "TxtSName"
        Me.TxtSName.Size = New System.Drawing.Size(114, 22)
        Me.TxtSName.TabIndex = 1
        '
        'BtnNewSR
        '
        Me.BtnNewSR.Location = New System.Drawing.Point(513, 539)
        Me.BtnNewSR.Name = "BtnNewSR"
        Me.BtnNewSR.Size = New System.Drawing.Size(75, 28)
        Me.BtnNewSR.TabIndex = 3
        Me.BtnNewSR.Text = "New"
        Me.BtnNewSR.UseVisualStyleBackColor = True
        '
        'BtnEditSR
        '
        Me.BtnEditSR.Location = New System.Drawing.Point(594, 539)
        Me.BtnEditSR.Name = "BtnEditSR"
        Me.BtnEditSR.Size = New System.Drawing.Size(75, 28)
        Me.BtnEditSR.TabIndex = 4
        Me.BtnEditSR.Text = "Edit"
        Me.BtnEditSR.UseVisualStyleBackColor = True
        '
        'BtnDelSR
        '
        Me.BtnDelSR.Location = New System.Drawing.Point(675, 539)
        Me.BtnDelSR.Name = "BtnDelSR"
        Me.BtnDelSR.Size = New System.Drawing.Size(75, 28)
        Me.BtnDelSR.TabIndex = 5
        Me.BtnDelSR.Text = "Delete"
        Me.BtnDelSR.UseVisualStyleBackColor = True
        '
        'GridSR
        '
        Me.GridSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSR.Location = New System.Drawing.Point(26, 69)
        Me.GridSR.Name = "GridSR"
        Me.GridSR.ReadOnly = True
        Me.GridSR.Size = New System.Drawing.Size(724, 448)
        Me.GridSR.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "STAFF RECORD"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BtnViewT)
        Me.TabPage1.Controls.Add(Me.TxtPID)
        Me.TabPage1.Controls.Add(Me.BtnSearch2)
        Me.TabPage1.Controls.Add(Me.TxtPName)
        Me.TabPage1.Controls.Add(Me.BtnNewPR)
        Me.TabPage1.Controls.Add(Me.BtnEditPR)
        Me.TabPage1.Controls.Add(Me.BtnDelPR)
        Me.TabPage1.Controls.Add(Me.GridPR)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(779, 596)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Patient Record"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BtnViewT
        '
        Me.BtnViewT.Location = New System.Drawing.Point(390, 539)
        Me.BtnViewT.Name = "BtnViewT"
        Me.BtnViewT.Size = New System.Drawing.Size(117, 28)
        Me.BtnViewT.TabIndex = 11
        Me.BtnViewT.Text = "View Treatment"
        Me.BtnViewT.UseVisualStyleBackColor = True
        '
        'TxtPID
        '
        Me.TxtPID.Location = New System.Drawing.Point(26, 542)
        Me.TxtPID.Name = "TxtPID"
        Me.TxtPID.Size = New System.Drawing.Size(68, 22)
        Me.TxtPID.TabIndex = 8
        '
        'BtnSearch2
        '
        Me.BtnSearch2.Location = New System.Drawing.Point(220, 539)
        Me.BtnSearch2.Name = "BtnSearch2"
        Me.BtnSearch2.Size = New System.Drawing.Size(75, 28)
        Me.BtnSearch2.TabIndex = 10
        Me.BtnSearch2.Text = "Search"
        Me.BtnSearch2.UseVisualStyleBackColor = True
        '
        'TxtPName
        '
        Me.TxtPName.Location = New System.Drawing.Point(100, 542)
        Me.TxtPName.Name = "TxtPName"
        Me.TxtPName.Size = New System.Drawing.Size(114, 22)
        Me.TxtPName.TabIndex = 9
        '
        'BtnNewPR
        '
        Me.BtnNewPR.Location = New System.Drawing.Point(513, 539)
        Me.BtnNewPR.Name = "BtnNewPR"
        Me.BtnNewPR.Size = New System.Drawing.Size(75, 28)
        Me.BtnNewPR.TabIndex = 12
        Me.BtnNewPR.Text = "New"
        Me.BtnNewPR.UseVisualStyleBackColor = True
        '
        'BtnEditPR
        '
        Me.BtnEditPR.Location = New System.Drawing.Point(594, 539)
        Me.BtnEditPR.Name = "BtnEditPR"
        Me.BtnEditPR.Size = New System.Drawing.Size(75, 28)
        Me.BtnEditPR.TabIndex = 13
        Me.BtnEditPR.Text = "Edit"
        Me.BtnEditPR.UseVisualStyleBackColor = True
        '
        'BtnDelPR
        '
        Me.BtnDelPR.Location = New System.Drawing.Point(675, 539)
        Me.BtnDelPR.Name = "BtnDelPR"
        Me.BtnDelPR.Size = New System.Drawing.Size(75, 28)
        Me.BtnDelPR.TabIndex = 14
        Me.BtnDelPR.Text = "Delete"
        Me.BtnDelPR.UseVisualStyleBackColor = True
        '
        'GridPR
        '
        Me.GridPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPR.Location = New System.Drawing.Point(26, 69)
        Me.GridPR.Name = "GridPR"
        Me.GridPR.ReadOnly = True
        Me.GridPR.Size = New System.Drawing.Size(724, 448)
        Me.GridPR.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 29)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "PATIENT RECORD"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GridBRD)
        Me.TabPage3.Controls.Add(Me.BtnNew)
        Me.TabPage3.Controls.Add(Me.BtnDelBR)
        Me.TabPage3.Controls.Add(Me.TxtPID2)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.TxtOR)
        Me.TabPage3.Controls.Add(Me.BtnSearch3)
        Me.TabPage3.Controls.Add(Me.GridBR)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(779, 596)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Billing Record"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GridBRD
        '
        Me.GridBRD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBRD.Location = New System.Drawing.Point(405, 118)
        Me.GridBRD.Name = "GridBRD"
        Me.GridBRD.Size = New System.Drawing.Size(348, 385)
        Me.GridBRD.TabIndex = 22
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(597, 538)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(75, 28)
        Me.BtnNew.TabIndex = 19
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnDelBR
        '
        Me.BtnDelBR.Location = New System.Drawing.Point(678, 538)
        Me.BtnDelBR.Name = "BtnDelBR"
        Me.BtnDelBR.Size = New System.Drawing.Size(75, 28)
        Me.BtnDelBR.TabIndex = 20
        Me.BtnDelBR.Text = "Delete"
        Me.BtnDelBR.UseVisualStyleBackColor = True
        '
        'TxtPID2
        '
        Me.TxtPID2.Location = New System.Drawing.Point(100, 88)
        Me.TxtPID2.Name = "TxtPID2"
        Me.TxtPID2.Size = New System.Drawing.Size(68, 22)
        Me.TxtPID2.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(400, 27)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(235, 29)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "RECORD DETAILS"
        '
        'TxtOR
        '
        Me.TxtOR.Location = New System.Drawing.Point(26, 88)
        Me.TxtOR.Name = "TxtOR"
        Me.TxtOR.Size = New System.Drawing.Size(68, 22)
        Me.TxtOR.TabIndex = 16
        '
        'BtnSearch3
        '
        Me.BtnSearch3.Location = New System.Drawing.Point(174, 88)
        Me.BtnSearch3.Name = "BtnSearch3"
        Me.BtnSearch3.Size = New System.Drawing.Size(75, 23)
        Me.BtnSearch3.TabIndex = 18
        Me.BtnSearch3.Text = "Search"
        Me.BtnSearch3.UseVisualStyleBackColor = True
        '
        'GridBR
        '
        Me.GridBR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBR.Location = New System.Drawing.Point(26, 118)
        Me.GridBR.Name = "GridBR"
        Me.GridBR.Size = New System.Drawing.Size(348, 385)
        Me.GridBR.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(226, 29)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "BILLING RECORD"
        '
        'Administrator_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 649)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Administrator_Home"
        Me.Text = "Oceana - Home (Admin)"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.GridSR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.GridPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.GridBRD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridBR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnSearch1 As Button
    Friend WithEvents TxtSName As TextBox
    Friend WithEvents BtnNewSR As Button
    Friend WithEvents BtnEditSR As Button
    Friend WithEvents BtnDelSR As Button
    Friend WithEvents GridSR As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnSearch2 As Button
    Friend WithEvents TxtPName As TextBox
    Friend WithEvents BtnNewPR As Button
    Friend WithEvents BtnEditPR As Button
    Friend WithEvents BtnDelPR As Button
    Friend WithEvents GridPR As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSID As TextBox
    Friend WithEvents TxtPID As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnDelBR As Button
    Friend WithEvents TxtPID2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtOR As TextBox
    Friend WithEvents BtnSearch3 As Button
    Friend WithEvents GridBR As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnViewT As Button
    Friend WithEvents GridBRD As DataGridView
End Class
