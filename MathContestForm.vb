
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
        Else
            SubmitButton.Enabled = False
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

        If AddRadioButton.Enabled Then
            CorrectAnswer = CInt(CDec(FirstNumberBox.Text)) + CInt(CDec(SecondNumberBox.Text))
        ElseIf SubtractButton.Enabled Then
            CorrectAnswer = CInt(FirstNumberBox.Text) - CInt(SecondNumberBox.Text)
        ElseIf MultiplyButton.Enabled Then
            CorrectAnswer = CInt(FirstNumberBox.Text) * CInt(SecondNumberBox.Text)
        ElseIf divideButtton.Enabled Then
            CorrectAnswer = CInt(CInt(CDec(FirstNumberBox.Text)) / CInt(CDec(SecondNumberBox.Text)))

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

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        If StudentAnswerBox.Text = ($"{CorrectAnswer}") Then
            CorrectRunningTotal = CorrectRunningTotal + 1
        End If

        NumberOfAttempts = NumberOfAttempts + 1
        StudentAnswerBox.Clear()

        RandomizeQuestions()

    End Sub

    Private Sub SummeryButton_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click
        MsgBox($"{NameBox.Text} has Answered {CorrectRunningTotal} out of {NumberOfAttempts} Correct")
    End Sub

    Private Sub StudentAnswerBox_TextChanged(sender As Object, e As EventArgs) Handles StudentAnswerBox.TextChanged
        SubmitButton.Enabled = True
    End Sub











    'Private Sub Namebox_TextChanged(sender As Object, e As EventArgs) Handles NameBox.TextChanged
    '    Static nameCheck As Boolean
    '    nameCheck = True
    'End Sub


    'Private Sub AgeBox_TextChanged(sender As Object, e As EventArgs) Handles AgeBox.TextChanged
    '    Static ageCheck As Boolean
    '    ageCheck = True
    'End Sub

    'Private Sub GradeBox_TextChanged(sender As Object, e As EventArgs) Handles GradeBox.TextChanged
    '    Static ageCheck As Boolean
    '    ageCheck = True
    'End Sub

    'Sub EvaluateTextBoxes()
    '    If NameBox.Text <> "" Or AgeBox.Text <> "" Then
    '        SubmitButton.Enabled = True
    '    Else
    '        SubmitButton.Enabled = False



    '    End If


    'End Sub

    'Private Sub TextBoxEvents_Leave(sender As Object, e As EventArgs) Handles GradeBox.Leave, NameBox.Leave, AgeBox.Leave
    '    EvaluateTextBoxes()


    'End Sub

End Class
