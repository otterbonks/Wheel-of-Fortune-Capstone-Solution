' Name:         Wheel of Fortune Capstone
' Purpose:
' Programmers:  Phillip Nguyen and David Garrison on 4/25/2023
Option Strict On
Option Explicit On
Option Infer Off
Imports System.IO

Public Class frmMain
    Dim seconds As Integer
    Dim wheelstate As Integer = 1
    Dim wheelspin As Integer
    Dim result As Integer
    Dim wheelspeed As Integer = 20

    Dim ranIndex As Integer
    Dim ranWord As String
    Dim tempWord As String
    Dim outputWord As String

    Dim play1Score As Integer
    Dim play2Score As Integer
    Dim ActivePlayer As Integer
    Dim intScoreCurrent1 As Integer
    Dim intScoreCounter As Integer


    Dim intScoreCounterTwo As Integer
    Dim intScoreCounterThree As Integer
    Dim intScoreCounterFour As Integer
    Dim intScoreCounterTotal As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picWheel.Image = WheelImages.Images(0)
        lblRandWord.Text = String.Empty

        radInactive.Checked = True
        radInactiveTwo.Checked = True
        radInactiveThree.Checked = True
        radInactiveFour.Checked = True
    End Sub

    Private Async Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        Randomize()
        result = CInt((24 * Rnd()) + 1)
        Timer1.Start()
        wheelspeed = 20
        lblPlay1Score.Text = String.Empty
        intScoreCurrent1 = 0
    End Sub

    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        seconds += 1
        Timer1.Interval = wheelspeed
        If seconds = 1 Then
            If wheelstate <= 24 Then
                picWheel.Image = WheelImages.Images(wheelstate)
                wheelstate += 1
            ElseIf wheelstate > 24 Then
                picWheel.Image = WheelImages.Images(0)
                wheelstate = 0
                wheelspin += 1
                wheelspeed += 40
            End If
            seconds = 0
            If wheelspin = 2 AndAlso wheelstate = result Then
                Timer1.Stop()
                wheelspin = 0
                For Each ctrl As Control In grpLetters.Controls
                    ctrl.Enabled = True
                Next
                Select Case result
                    Case Is = 1
                        intScoreCurrent1 += 10000
                    Case Is = 0, 2
                        intScoreCurrent1 = 0
                    Case Is = 8, 18
                        intScoreCurrent1 += 5000
                    Case Is = 5, 12, 15, 21, 22
                        intScoreCurrent1 += 2000
                    Case Is = 19, 17, 7, 9, 13
                        If radActive.Checked = True Then
                            radInactive.Checked = True
                        End If

                        If radActiveTwo.Checked Then
                            radInactiveTwo.Checked = True
                        End If

                    Case Else
                        intScoreCurrent1 += 1000
                End Select
                lblPlay1Score.Text = intScoreCurrent1.ToString

            End If



        End If

    End Sub

    Private Sub menuLoad_Click(sender As Object, e As EventArgs) Handles menuLoad.Click
        lblRandWord.Text = String.Empty
        ranWord = String.Empty
        tempWord = String.Empty
        outputWord = String.Empty
        lstRandWords.Items.Clear()

        Dim Open As New OpenFileDialog()
        Dim myStreamReader As System.IO.StreamReader
        Open.Filter = "Text [*.txt*]|*.txt|All Files [*.*]|*.*"
        Open.CheckFileExists = True
        Open.Title = "OpenFile"
        Open.ShowDialog(Me)

        Try
            Open.OpenFile()

            myStreamReader = System.IO.File.OpenText(Open.FileName)

            For Each line As String In File.ReadAllLines(Open.FileName)
                lstRandWords.Items.Add(line)
            Next

            ranIndex = CInt(lstRandWords.Items.Count * Rnd())
            ranWord = lstRandWords.Items(ranIndex).ToString.Trim.ToUpper

            For Each c As Char In ranWord
                tempWord += c + " "
                outputWord += "- "
            Next
            lblRandWord.Text = outputWord
            btnSpin.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        If ranWord.Contains(txtPlay1Guess.Text.ToUpper) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = txtPlay1Guess.Text.ToUpper Then
                    outputWord = outputWord.Insert(intIndex, txtPlay1Guess.Text.ToUpper)
                    outputWord = outputWord.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, " ")
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
        End If
        lblRandWord.Text = outputWord
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click, btnB.Click, btnC.Click, btnD.Click, btnE.Click, btnF.Click, btnG.Click, btnH.Click, btnI.Click, btnJ.Click, btnK.Click, btnL.Click, btnM.Click, btnN.Click, btnO.Click, btnP.Click, btnQ.Click, btnR.Click, btnS.Click, btnT.Click, btnU.Click, btnV.Click, btnW.Click, btnX.Click, btnY.Click, btnZ.Click
        Dim guessedLetter As Button = DirectCast(sender, Button)


        If ranWord.Contains(guessedLetter.Text) Then
            For intIndex As Integer = 0 To tempWord.Length - 1
                If tempWord(intIndex) = guessedLetter.Text Then
                    outputWord = outputWord.Insert(intIndex, guessedLetter.Text)
                    outputWord = outputWord.Remove(intIndex + 1, 1)

                    tempWord = tempWord.Insert(intIndex, " ")
                    tempWord = tempWord.Remove(intIndex + 1, 1)
                End If
            Next
            guessedLetter.BackColor = Color.Lime


        Else

            guessedLetter.BackColor = Color.Red
            For Each ctrl As Control In grpLetters.Controls
                ctrl.Enabled = False
            Next
        End If
        guessedLetter.Enabled = False
        lblRandWord.Text = outputWord



        'Player One Score Tracker 
        If radActive.Checked = True AndAlso guessedLetter.BackColor = Color.Lime Then
            intScoreCounter += intScoreCurrent1
            lblPlayerOneScore.Text = intScoreCounter.ToString


        ElseIf radInactive.Checked = True AndAlso guessedLetter.BackColor = Color.Red Then
            intScoreCounter += 0
            lblPlayerOneScore.Text = intScoreCounter.ToString
        End If

        ''Player Two Score Tracker
        If radActiveTwo.Checked = True AndAlso guessedLetter.BackColor = Color.Lime Then
            intScoreCounterTwo += intScoreCurrent1

            lblPlayerTwoScore.Text = intScoreCounterTwo.ToString


        ElseIf radInactiveTwo.Checked = True AndAlso guessedLetter.BackColor = Color.Red Then
            intScoreCounterTwo += 0
            lblPlayerTwoScore.Text = intScoreCounterTwo.ToString

        End If


        '''Player Three Score Tracker
        ''If radActiveThree.Checked = True AndAlso guessedLetter.BackColor = Color.Lime Then
        'intScoreCounterThree += intScoreCurrent1
        '    lblPlayerThreeScore.Text = intScoreCounterThree.ToString
        '    MsgBox("Player Three Active")

        'ElseIf guessedLetter.BackColor = Color.Red Then
        '    radInactiveThree.Checked = True
        '    intScoreCounterThree += 0
        '    lblPlayerThreeScore.Text = intScoreCounterThree.ToString

        'End If
        'intScoreCounter = 0

        ''Player Four Score Tracker
        'If radActiveFour.Checked = True AndAlso guessedLetter.BackColor = Color.Lime Then
        '    intScoreCounterFour += intScoreCurrent1
        '    lblPlayerFourScore.Text = intScoreCounterFour.ToString
        '    MsgBox("Player Four Active")

        'ElseIf guessedLetter.BackColor = Color.Red Then
        '    radInactiveFour.Checked = True
        '    intScoreCounterFour += 0
        '    lblPlayerFourScore.Text = intScoreCounterFour.ToString

        'End If
        'intScoreCounter = 0

    End Sub

End Class