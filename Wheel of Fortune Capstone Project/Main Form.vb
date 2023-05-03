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
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picWheel.Image = WheelImages.Images(0)
        lblRandWord.Text = String.Empty
    End Sub

    Private Async Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        result = CInt((24 * Rnd()) + 1)
        Timer1.Start()
        wheelspeed = 20
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
            End If
        End If

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click


        Dim Open As New OpenFileDialog()
        'it is declared as System input and output Streamreader
        'it reads characters from a byte stream in a particular encoding
        Dim myStreamReader As System.IO.StreamReader
        'in an open dialog box, it will give an opening filter for the current filenames,
        'or the save file types.   
        Open.Filter = "Text [*.txt*]|*.txt|All Files [*.*]|*.*"
        'it checks if the file exists or not
        Open.CheckFileExists = True
        'sets the openfile dialog name as "OpenFile"
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
                tempWord += "- "
            Next

            lblRandWord.Text = tempWord
        Catch ex As Exception
            'it will catch if any errors occurs
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click

        If ranWord.Contains(txtPlay1Guess.Text.ToUpper) Then
            For Each c As Char In tempWord
                If tempWord.IndexOf(c.ToString) = (ranWord.IndexOf(txtPlay1Guess.Text.ToUpper) * 2) Then
                    tempWord = tempWord.Replace(c.ToString, txtPlay1Guess.Text.ToUpper)
                End If
            Next
        Else
            MsgBox("noooo")
        End If

        lblRandWord.Text = tempWord

    End Sub
End Class