
Option Strict On
Option Explicit On
Option Compare Text



Public Class MathContestForm
    Dim nameCheck As Boolean
    Dim ageCheck As Boolean
    Dim gradeCheck As Boolean
    Dim currentAge As String
    Dim ageBuffer As Int16
    Dim CorrectAnswer As Integer
    Dim CorrectRunningTotal As Integer
    Dim NumberOfAttempts As Integer



    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        ChecktextBoxes()
        RandomizeQuestions()


        SubtractButton.Enabled = False
        AddRadioButton.Enabled = False
        MultiplyButton.Enabled = False
        divideButtton.Enabled = False

        AddRadioButton.Checked = True
    End Sub

    'This Part of the program was copied almost exacly from what Tim Rossiter has in his examples
    'Under Combobox examples https://github.com/rosstimo/ComboBoxExample/blob/master/ComboBoxForm.vb

    Public Sub ChecktextBoxes() Handles NameBox.KeyUp, ageBox.KeyUp, gradeBox.KeyUp, ageBox.Click, gradeBox.Click

        If NameBox.Text <> "" And ageBox.Text <> "" And StudentAnswerBox.Text <> "" And gradeBox.Text <> "" Then
            SubmitButton.Enabled = True
            SummeryButton.Enabled = True
        Else
            SubmitButton.Enabled = False
            SummeryButton.Enabled = False
        End If

        'If ageBuffer > 6 Then
        '    SubtractButton.Enabled = False
        '    AddRadioButton.Enabled = False
        '    MultiplyButton.Enabled = False
        '    divideButtton.Enabled = False

        'End If

        'End If
    End Sub
    Private Sub AgeAndGradeCheck() Handles ageBox.Leave
        ageBuffer = CShort(CInt(ageBox.Value))

        Select Case ageBuffer
            Case 0
            Case 1 To 6
                MsgBox("You are too yong to be in this competition ")
                SubtractButton.Enabled = False
                AddRadioButton.Enabled = False
                MultiplyButton.Enabled = False
                divideButtton.Enabled = False


            Case 6 To 8
                SubtractButton.Enabled = True
                AddRadioButton.Enabled = True
                MultiplyButton.Enabled = False
                divideButtton.Enabled = False


            Case 8 To 150
                SubtractButton.Enabled = True
                AddRadioButton.Enabled = True
                MultiplyButton.Enabled = True
                divideButtton.Enabled = True

            Case > 150
                MsgBox("You are WAY to old to be in this competition.")
                SubtractButton.Enabled = False
                AddRadioButton.Enabled = False
                MultiplyButton.Enabled = False
                divideButtton.Enabled = False
            Case < 0
                MsgBox("It seems that you have not been born yet. Please come back when you are 6 or Older")
                SubtractButton.Enabled = False
                AddRadioButton.Enabled = False
                MultiplyButton.Enabled = False
                divideButtton.Enabled = False
            Case Else
                MsgBox("You somehow broke the Program!")

                SubtractButton.Enabled = False
                AddRadioButton.Enabled = False
                MultiplyButton.Enabled = False
                divideButtton.Enabled = False


        End Select
        If gradeBox.Value < 0 Or gradeBox.Value > 12 Then
            MsgBox("This Competition is only for those who are from 1rst to 12th grade")
            gradeBox.Value = 0
            SubtractButton.Enabled = False
            AddRadioButton.Enabled = False
            MultiplyButton.Enabled = False
            divideButtton.Enabled = False
        End If


    End Sub

    Function RandomizeQuestions() As Action
        Randomize()
        FirstNumberBox.Text = CStr(Int((100 - 0 + 1) * Rnd() + 0))
        SecondNumberBox.Text = CStr(Int((100 - 0 + 1) * Rnd() + 0))



    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        If ExitButton.Enabled Then
            Me.Close()
        End If
    End Sub

    Private Sub ageBox_ValueChanged(sender As Object, e As EventArgs) Handles ageBox.ValueChanged
        ageBuffer = CShort(CInt(ageBox.Value))


    End Sub
    'Private Sub EvaluateIfEmptyBoxes()
    '    If NameBox.Text = "" Then
    '        MsgBox("Your Name is Blank. Please Enter the Name of the Contestant")
    '        AgeAndGradeCheck()
    '    End If

    '    If gradeBox.Value < 0 Or gradeBox.Value > 12 Then
    '        MsgBox("This Competition is only for those who are from 1rst to 12th grade")
    '        gradeBox.Value = 0
    '        AgeAndGradeCheck()

    '    End If

    'End Sub
    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        'If AddRadioButton.Enabled Then
        'ElseIf SubtractButton.Enabled Then
        'ElseIf MultiplyButton.Enabled Then
        'ElseIf divideButtton.Enabled Then

        'End If
        EvaluateRadioButtons()
        'EvaluateIfEmptyBoxes()

        If StudentAnswerBox.Text = $"{CorrectAnswer}" Then
            CorrectRunningTotal = CorrectRunningTotal + 1
            MsgBox($"Congradulations {NameBox.Text}! You are Correct!")
        Else
            MsgBox($"Incorrect")
        End If

        NumberOfAttempts = NumberOfAttempts + 1
        StudentAnswerBox.Clear()

        RandomizeQuestions()

    End Sub
    Private Sub EvaluateRadioButtons()
        If MultiplyButton.Checked Then
            CorrectAnswer = CInt(FirstNumberBox.Text) * CInt(SecondNumberBox.Text)
        ElseIf SubtractButton.Checked Then
            CorrectAnswer = CInt(CDec(FirstNumberBox.Text)) - CInt(CDec(SecondNumberBox.Text))
        ElseIf divideButtton.Checked Then
            CorrectAnswer = CInt(CInt(CDec(FirstNumberBox.Text)) \ CInt(CDec(SecondNumberBox.Text)))
        Else
            CorrectAnswer = CInt(CDec(FirstNumberBox.Text)) + CInt(CDec(SecondNumberBox.Text))

        End If


    End Sub
    Private Sub SummeryButton_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click

        MsgBox($"{NameBox.Text} {vbNewLine} Grade {gradeBox.Text} {vbNewLine} Age {ageBox.Text} {vbNewLine} Has Answered {CorrectRunningTotal} out of {NumberOfAttempts} Correct")
        AgeAndGradeCheck()
        ChecktextBoxes()
    End Sub

    Private Sub StudentAnswerBox_TextChanged(sender As Object, e As EventArgs) Handles StudentAnswerBox.TextChanged
        SubmitButton.Enabled = True
        SummeryButton.Enabled = True
    End Sub

    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        CorrectAnswer = CInt(CDec(FirstNumberBox.Text)) + CInt(CDec(SecondNumberBox.Text))

    End Sub

    Private Sub SubtractButton_CheckedChanged(sender As Object, e As EventArgs) Handles SubtractButton.CheckedChanged
        CorrectAnswer = CInt(CDec(FirstNumberBox.Text)) - CInt(CDec(SecondNumberBox.Text))

    End Sub

    Private Sub MultiplyButton_CheckedChanged(sender As Object, e As EventArgs) Handles MultiplyButton.CheckedChanged
        CorrectAnswer = CInt(FirstNumberBox.Text) * CInt(SecondNumberBox.Text)

    End Sub

    Private Sub divideButtton_CheckedChanged(sender As Object, e As EventArgs) Handles divideButtton.CheckedChanged
        CorrectAnswer = CInt(CInt(CDec(FirstNumberBox.Text)) / CInt(CDec(SecondNumberBox.Text)))

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        NameBox.Clear()
        ageBox.Value = 0
        gradeBox.Value = 0
        StudentAnswerBox.Clear()
        NumberOfAttempts = 0
        CorrectRunningTotal = 0
        AgeAndGradeCheck()
        ChecktextBoxes()


    End Sub


End Class
