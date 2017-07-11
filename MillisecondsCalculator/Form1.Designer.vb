<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.rdioDateTime = New System.Windows.Forms.RadioButton()
        Me.mtbMilliseconds = New System.Windows.Forms.MaskedTextBox()
        Me.rdioMilliseconds = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.CustomFormat = "yyyy/MM/dd HH:mm:ss"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(99, 64)
        Me.DateTimePicker1.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(272, 26)
        Me.DateTimePicker1.TabIndex = 0
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(96, 241)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(66, 18)
        Me.lblResult.TabIndex = 1
        Me.lblResult.Text = "lblResult"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(132, 178)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(128, 35)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'rdioDateTime
        '
        Me.rdioDateTime.AutoSize = True
        Me.rdioDateTime.Location = New System.Drawing.Point(79, 73)
        Me.rdioDateTime.Name = "rdioDateTime"
        Me.rdioDateTime.Size = New System.Drawing.Size(14, 13)
        Me.rdioDateTime.TabIndex = 3
        Me.rdioDateTime.TabStop = True
        Me.rdioDateTime.UseVisualStyleBackColor = True
        '
        'mtbMilliseconds
        '
        Me.mtbMilliseconds.Location = New System.Drawing.Point(99, 111)
        Me.mtbMilliseconds.Mask = "0000000000000"
        Me.mtbMilliseconds.Name = "mtbMilliseconds"
        Me.mtbMilliseconds.PromptChar = Global.Microsoft.VisualBasic.ChrW(120)
        Me.mtbMilliseconds.Size = New System.Drawing.Size(272, 26)
        Me.mtbMilliseconds.TabIndex = 4
        '
        'rdioMilliseconds
        '
        Me.rdioMilliseconds.AutoSize = True
        Me.rdioMilliseconds.Location = New System.Drawing.Point(79, 117)
        Me.rdioMilliseconds.Name = "rdioMilliseconds"
        Me.rdioMilliseconds.Size = New System.Drawing.Size(14, 13)
        Me.rdioMilliseconds.TabIndex = 3
        Me.rdioMilliseconds.TabStop = True
        Me.rdioMilliseconds.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 361)
        Me.Controls.Add(Me.mtbMilliseconds)
        Me.Controls.Add(Me.rdioMilliseconds)
        Me.Controls.Add(Me.rdioDateTime)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblResult As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents rdioDateTime As RadioButton
    Friend WithEvents mtbMilliseconds As MaskedTextBox
    Friend WithEvents rdioMilliseconds As RadioButton
End Class
