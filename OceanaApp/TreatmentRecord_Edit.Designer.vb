<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TreatmentRecord_Edit
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
        Me.NumY = New System.Windows.Forms.NumericUpDown()
        Me.NumM = New System.Windows.Forms.NumericUpDown()
        Me.NumD = New System.Windows.Forms.NumericUpDown()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtDos = New System.Windows.Forms.TextBox()
        Me.TxtMed = New System.Windows.Forms.TextBox()
        Me.TxtDiag = New System.Windows.Forms.TextBox()
        Me.TxtNotes = New System.Windows.Forms.TextBox()
        Me.TxtROV = New System.Windows.Forms.TextBox()
        Me.TxtTime = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.NumY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(757, 510)
        Me.TabControl1.TabIndex = 90
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.NumY)
        Me.TabPage1.Controls.Add(Me.NumM)
        Me.TabPage1.Controls.Add(Me.NumD)
        Me.TabPage1.Controls.Add(Me.BtnCancel)
        Me.TabPage1.Controls.Add(Me.BtnSave)
        Me.TabPage1.Controls.Add(Me.TxtDos)
        Me.TabPage1.Controls.Add(Me.TxtMed)
        Me.TabPage1.Controls.Add(Me.TxtDiag)
        Me.TabPage1.Controls.Add(Me.TxtNotes)
        Me.TabPage1.Controls.Add(Me.TxtROV)
        Me.TabPage1.Controls.Add(Me.TxtTime)
        Me.TabPage1.Controls.Add(Me.Label22)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(749, 481)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Treatment"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'NumY
        '
        Me.NumY.Location = New System.Drawing.Point(259, 123)
        Me.NumY.Name = "NumY"
        Me.NumY.Size = New System.Drawing.Size(76, 22)
        Me.NumY.TabIndex = 2
        '
        'NumM
        '
        Me.NumM.Location = New System.Drawing.Point(209, 123)
        Me.NumM.Name = "NumM"
        Me.NumM.Size = New System.Drawing.Size(40, 22)
        Me.NumM.TabIndex = 1
        '
        'NumD
        '
        Me.NumD.Location = New System.Drawing.Point(159, 123)
        Me.NumD.Name = "NumD"
        Me.NumD.Size = New System.Drawing.Size(40, 22)
        Me.NumD.TabIndex = 0
        '
        'BtnCancel
        '
        Me.BtnCancel.Location = New System.Drawing.Point(533, 412)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 28)
        Me.BtnCancel.TabIndex = 9
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(614, 412)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 28)
        Me.BtnSave.TabIndex = 10
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtDos
        '
        Me.TxtDos.Location = New System.Drawing.Point(513, 186)
        Me.TxtDos.Name = "TxtDos"
        Me.TxtDos.Size = New System.Drawing.Size(176, 22)
        Me.TxtDos.TabIndex = 7
        '
        'TxtMed
        '
        Me.TxtMed.Location = New System.Drawing.Point(513, 154)
        Me.TxtMed.Name = "TxtMed"
        Me.TxtMed.Size = New System.Drawing.Size(176, 22)
        Me.TxtMed.TabIndex = 6
        '
        'TxtDiag
        '
        Me.TxtDiag.Location = New System.Drawing.Point(513, 122)
        Me.TxtDiag.Name = "TxtDiag"
        Me.TxtDiag.Size = New System.Drawing.Size(176, 22)
        Me.TxtDiag.TabIndex = 5
        '
        'TxtNotes
        '
        Me.TxtNotes.Location = New System.Drawing.Point(159, 218)
        Me.TxtNotes.Multiline = True
        Me.TxtNotes.Name = "TxtNotes"
        Me.TxtNotes.Size = New System.Drawing.Size(530, 150)
        Me.TxtNotes.TabIndex = 8
        '
        'TxtROV
        '
        Me.TxtROV.Location = New System.Drawing.Point(159, 186)
        Me.TxtROV.Name = "TxtROV"
        Me.TxtROV.Size = New System.Drawing.Size(176, 22)
        Me.TxtROV.TabIndex = 4
        '
        'TxtTime
        '
        Me.TxtTime.Location = New System.Drawing.Point(159, 154)
        Me.TxtTime.Name = "TxtTime"
        Me.TxtTime.Size = New System.Drawing.Size(176, 22)
        Me.TxtTime.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(403, 189)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 16)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "Dosage:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(403, 157)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 16)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Medication:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(49, 221)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 16)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Notes:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(403, 125)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Diagnosis:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(49, 189)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(105, 16)
        Me.Label18.TabIndex = 3
        Me.Label18.Text = "Reason for Visit:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(49, 157)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 16)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Time:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(49, 125)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 16)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Date:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(47, 41)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(288, 29)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "TREATMENT RECORD"
        '
        'TreatmentRecord_Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 534)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "TreatmentRecord_Edit"
        Me.Text = "Treatment Record"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.NumY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents TxtDos As TextBox
    Friend WithEvents TxtMed As TextBox
    Friend WithEvents TxtDiag As TextBox
    Friend WithEvents TxtNotes As TextBox
    Friend WithEvents TxtROV As TextBox
    Friend WithEvents TxtTime As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents NumY As NumericUpDown
    Friend WithEvents NumM As NumericUpDown
    Friend WithEvents NumD As NumericUpDown
End Class
