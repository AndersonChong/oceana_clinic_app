<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TreatmentRecord
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
        Me.NumY = New System.Windows.Forms.NumericUpDown()
        Me.NumM = New System.Windows.Forms.NumericUpDown()
        Me.NumD = New System.Windows.Forms.NumericUpDown()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.GridTR = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.NumY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridTR, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabPage2.Controls.Add(Me.NumY)
        Me.TabPage2.Controls.Add(Me.NumM)
        Me.TabPage2.Controls.Add(Me.NumD)
        Me.TabPage2.Controls.Add(Me.BtnSearch)
        Me.TabPage2.Controls.Add(Me.BtnNew)
        Me.TabPage2.Controls.Add(Me.BtnEdit)
        Me.TabPage2.Controls.Add(Me.BtnDel)
        Me.TabPage2.Controls.Add(Me.GridTR)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(779, 596)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Treatment Record"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'NumY
        '
        Me.NumY.Location = New System.Drawing.Point(125, 543)
        Me.NumY.Maximum = New Decimal(New Integer() {2500, 0, 0, 0})
        Me.NumY.Name = "NumY"
        Me.NumY.Size = New System.Drawing.Size(76, 22)
        Me.NumY.TabIndex = 2
        '
        'NumM
        '
        Me.NumM.Location = New System.Drawing.Point(75, 543)
        Me.NumM.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.NumM.Name = "NumM"
        Me.NumM.Size = New System.Drawing.Size(40, 22)
        Me.NumM.TabIndex = 1
        '
        'NumD
        '
        Me.NumD.Location = New System.Drawing.Point(25, 543)
        Me.NumD.Maximum = New Decimal(New Integer() {31, 0, 0, 0})
        Me.NumD.Name = "NumD"
        Me.NumD.Size = New System.Drawing.Size(40, 22)
        Me.NumD.TabIndex = 0
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(207, 539)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(75, 28)
        Me.BtnSearch.TabIndex = 3
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(512, 539)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(75, 28)
        Me.BtnNew.TabIndex = 4
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(593, 539)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 28)
        Me.BtnEdit.TabIndex = 5
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Location = New System.Drawing.Point(674, 539)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(75, 28)
        Me.BtnDel.TabIndex = 6
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'GridTR
        '
        Me.GridTR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridTR.Location = New System.Drawing.Point(25, 69)
        Me.GridTR.Name = "GridTR"
        Me.GridTR.ReadOnly = True
        Me.GridTR.Size = New System.Drawing.Size(724, 448)
        Me.GridTR.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(288, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TREATMENT RECORD"
        '
        'TreatmentRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 649)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TreatmentRecord"
        Me.Text = "Treatment Record"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NumY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridTR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDel As Button
    Friend WithEvents GridTR As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents NumY As NumericUpDown
    Friend WithEvents NumM As NumericUpDown
    Friend WithEvents NumD As NumericUpDown
End Class
