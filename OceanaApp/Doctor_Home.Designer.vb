<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Doctor_Home
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TxtPID = New System.Windows.Forms.TextBox()
        Me.BtnViewT = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtPName = New System.Windows.Forms.TextBox()
        Me.GridPR = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridPR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(787, 625)
        Me.TabControl1.TabIndex = 90
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TxtPID)
        Me.TabPage2.Controls.Add(Me.BtnViewT)
        Me.TabPage2.Controls.Add(Me.BtnSearch)
        Me.TabPage2.Controls.Add(Me.TxtPName)
        Me.TabPage2.Controls.Add(Me.GridPR)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(779, 596)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Patient Record"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TxtPID
        '
        Me.TxtPID.Location = New System.Drawing.Point(26, 542)
        Me.TxtPID.Name = "TxtPID"
        Me.TxtPID.Size = New System.Drawing.Size(68, 22)
        Me.TxtPID.TabIndex = 0
        '
        'BtnViewT
        '
        Me.BtnViewT.Location = New System.Drawing.Point(633, 539)
        Me.BtnViewT.Name = "BtnViewT"
        Me.BtnViewT.Size = New System.Drawing.Size(117, 28)
        Me.BtnViewT.TabIndex = 3
        Me.BtnViewT.Text = "View Treatment"
        Me.BtnViewT.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(220, 539)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 28)
        Me.BtnSearch.TabIndex = 2
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TxtPName
        '
        Me.TxtPName.Location = New System.Drawing.Point(100, 542)
        Me.TxtPName.Name = "TxtPName"
        Me.TxtPName.Size = New System.Drawing.Size(114, 22)
        Me.TxtPName.TabIndex = 1
        '
        'GridPR
        '
        Me.GridPR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridPR.Location = New System.Drawing.Point(26, 69)
        Me.GridPR.Name = "GridPR"
        Me.GridPR.Size = New System.Drawing.Size(724, 448)
        Me.GridPR.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PATIENT RECORD"
        '
        'Doctor_Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 649)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Doctor_Home"
        Me.Text = "Oceana - Home (Doctor)"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.GridPR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtPName As TextBox
    Friend WithEvents GridPR As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnViewT As Button
    Friend WithEvents TxtPID As TextBox
End Class
