<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
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
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerBox = New System.Windows.Forms.TextBox()
        Me.StudentInformationBox = New System.Windows.Forms.GroupBox()
        Me.ageBox = New System.Windows.Forms.NumericUpDown()
        Me.gradeBox = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CurrentMathProblemBox = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractButton = New System.Windows.Forms.RadioButton()
        Me.MultiplyButton = New System.Windows.Forms.RadioButton()
        Me.divideButtton = New System.Windows.Forms.RadioButton()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SummeryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MathProblemTypeBox = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.StudentInformationBox.SuspendLayout()
        CType(Me.ageBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gradeBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CurrentMathProblemBox.SuspendLayout()
        Me.MathProblemTypeBox.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameBox
        '
        Me.NameBox.Location = New System.Drawing.Point(40, 87)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(250, 31)
        Me.NameBox.TabIndex = 0
        '
        'FirstNumberBox
        '
        Me.FirstNumberBox.Location = New System.Drawing.Point(29, 65)
        Me.FirstNumberBox.Name = "FirstNumberBox"
        Me.FirstNumberBox.ReadOnly = True
        Me.FirstNumberBox.Size = New System.Drawing.Size(250, 31)
        Me.FirstNumberBox.TabIndex = 50
        Me.FirstNumberBox.TabStop = False
        '
        'SecondNumberBox
        '
        Me.SecondNumberBox.Location = New System.Drawing.Point(29, 167)
        Me.SecondNumberBox.Name = "SecondNumberBox"
        Me.SecondNumberBox.ReadOnly = True
        Me.SecondNumberBox.Size = New System.Drawing.Size(250, 31)
        Me.SecondNumberBox.TabIndex = 51
        Me.SecondNumberBox.TabStop = False
        '
        'StudentAnswerBox
        '
        Me.StudentAnswerBox.Location = New System.Drawing.Point(29, 264)
        Me.StudentAnswerBox.Name = "StudentAnswerBox"
        Me.StudentAnswerBox.Size = New System.Drawing.Size(250, 31)
        Me.StudentAnswerBox.TabIndex = 7
        '
        'StudentInformationBox
        '
        Me.StudentInformationBox.Controls.Add(Me.ageBox)
        Me.StudentInformationBox.Controls.Add(Me.gradeBox)
        Me.StudentInformationBox.Controls.Add(Me.Label6)
        Me.StudentInformationBox.Controls.Add(Me.Label5)
        Me.StudentInformationBox.Controls.Add(Me.Label4)
        Me.StudentInformationBox.Controls.Add(Me.NameBox)
        Me.StudentInformationBox.Location = New System.Drawing.Point(1, 12)
        Me.StudentInformationBox.Name = "StudentInformationBox"
        Me.StudentInformationBox.Size = New System.Drawing.Size(579, 172)
        Me.StudentInformationBox.TabIndex = 4
        Me.StudentInformationBox.TabStop = False
        Me.StudentInformationBox.Text = "Student Information"
        '
        'ageBox
        '
        Me.ageBox.Location = New System.Drawing.Point(335, 87)
        Me.ageBox.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.ageBox.Name = "ageBox"
        Me.ageBox.Size = New System.Drawing.Size(110, 31)
        Me.ageBox.TabIndex = 1
        '
        'gradeBox
        '
        Me.gradeBox.Location = New System.Drawing.Point(463, 88)
        Me.gradeBox.Name = "gradeBox"
        Me.gradeBox.Size = New System.Drawing.Size(110, 31)
        Me.gradeBox.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(458, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Grade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(362, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 25)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Age"
        '
        'CurrentMathProblemBox
        '
        Me.CurrentMathProblemBox.Controls.Add(Me.Label3)
        Me.CurrentMathProblemBox.Controls.Add(Me.Label2)
        Me.CurrentMathProblemBox.Controls.Add(Me.Label1)
        Me.CurrentMathProblemBox.Controls.Add(Me.GroupBox3)
        Me.CurrentMathProblemBox.Controls.Add(Me.StudentAnswerBox)
        Me.CurrentMathProblemBox.Controls.Add(Me.SecondNumberBox)
        Me.CurrentMathProblemBox.Controls.Add(Me.FirstNumberBox)
        Me.CurrentMathProblemBox.Location = New System.Drawing.Point(12, 190)
        Me.CurrentMathProblemBox.Name = "CurrentMathProblemBox"
        Me.CurrentMathProblemBox.Size = New System.Drawing.Size(326, 337)
        Me.CurrentMathProblemBox.TabIndex = 5
        Me.CurrentMathProblemBox.TabStop = False
        Me.CurrentMathProblemBox.Text = "Current Math Problem"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Student Answer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Second Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "First Number"
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(371, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(223, 208)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Location = New System.Drawing.Point(39, 27)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(81, 29)
        Me.AddRadioButton.TabIndex = 3
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractButton
        '
        Me.SubtractButton.AutoSize = True
        Me.SubtractButton.Location = New System.Drawing.Point(39, 87)
        Me.SubtractButton.Name = "SubtractButton"
        Me.SubtractButton.Size = New System.Drawing.Size(123, 29)
        Me.SubtractButton.TabIndex = 4
        Me.SubtractButton.TabStop = True
        Me.SubtractButton.Text = "Subtract"
        Me.SubtractButton.UseVisualStyleBackColor = True
        '
        'MultiplyButton
        '
        Me.MultiplyButton.AutoSize = True
        Me.MultiplyButton.Location = New System.Drawing.Point(39, 156)
        Me.MultiplyButton.Name = "MultiplyButton"
        Me.MultiplyButton.Size = New System.Drawing.Size(117, 29)
        Me.MultiplyButton.TabIndex = 5
        Me.MultiplyButton.TabStop = True
        Me.MultiplyButton.Text = "Multiply"
        Me.MultiplyButton.UseVisualStyleBackColor = True
        '
        'divideButtton
        '
        Me.divideButtton.AutoSize = True
        Me.divideButtton.Location = New System.Drawing.Point(39, 219)
        Me.divideButtton.Name = "divideButtton"
        Me.divideButtton.Size = New System.Drawing.Size(103, 29)
        Me.divideButtton.TabIndex = 6
        Me.divideButtton.TabStop = True
        Me.divideButtton.Text = "Divide"
        Me.divideButtton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(795, 99)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(240, 93)
        Me.SubmitButton.TabIndex = 8
        Me.SubmitButton.Text = "Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(795, 215)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(240, 93)
        Me.ClearButton.TabIndex = 9
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'SummeryButton
        '
        Me.SummeryButton.Location = New System.Drawing.Point(795, 357)
        Me.SummeryButton.Name = "SummeryButton"
        Me.SummeryButton.Size = New System.Drawing.Size(240, 93)
        Me.SummeryButton.TabIndex = 10
        Me.SummeryButton.Text = "SummeryButton"
        Me.SummeryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(795, 487)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(240, 93)
        Me.ExitButton.TabIndex = 11
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MathProblemTypeBox
        '
        Me.MathProblemTypeBox.Controls.Add(Me.GroupBox5)
        Me.MathProblemTypeBox.Controls.Add(Me.AddRadioButton)
        Me.MathProblemTypeBox.Controls.Add(Me.divideButtton)
        Me.MathProblemTypeBox.Controls.Add(Me.MultiplyButton)
        Me.MathProblemTypeBox.Controls.Add(Me.SubtractButton)
        Me.MathProblemTypeBox.Location = New System.Drawing.Point(406, 230)
        Me.MathProblemTypeBox.Name = "MathProblemTypeBox"
        Me.MathProblemTypeBox.Size = New System.Drawing.Size(238, 312)
        Me.MathProblemTypeBox.TabIndex = 14
        Me.MathProblemTypeBox.TabStop = False
        Me.MathProblemTypeBox.Text = "Math Problem Type"
        '
        'GroupBox5
        '
        Me.GroupBox5.Location = New System.Drawing.Point(371, 40)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(223, 208)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.GroupBox7)
        Me.GroupBox6.Location = New System.Drawing.Point(724, 39)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(365, 581)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Location = New System.Drawing.Point(371, 40)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(223, 208)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "GroupBox7"
        '
        'MathContestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 859)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.SummeryButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Controls.Add(Me.StudentInformationBox)
        Me.Controls.Add(Me.CurrentMathProblemBox)
        Me.Controls.Add(Me.MathProblemTypeBox)
        Me.Controls.Add(Me.GroupBox6)
        Me.Name = "MathContestForm"
        Me.Text = "Form1"
        Me.StudentInformationBox.ResumeLayout(False)
        Me.StudentInformationBox.PerformLayout()
        CType(Me.ageBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gradeBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CurrentMathProblemBox.ResumeLayout(False)
        Me.CurrentMathProblemBox.PerformLayout()
        Me.MathProblemTypeBox.ResumeLayout(False)
        Me.MathProblemTypeBox.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NameBox As TextBox
    Friend WithEvents FirstNumberBox As TextBox
    Friend WithEvents SecondNumberBox As TextBox
    Friend WithEvents StudentAnswerBox As TextBox
    Friend WithEvents StudentInformationBox As GroupBox
    Friend WithEvents CurrentMathProblemBox As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SubtractButton As RadioButton
    Friend WithEvents MultiplyButton As RadioButton
    Friend WithEvents divideButtton As RadioButton
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents SummeryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents MathProblemTypeBox As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents gradeBox As NumericUpDown
    Friend WithEvents ageBox As NumericUpDown
End Class
