' Name:         Wheel of Fortune Capstone
' Purpose:
' Programmers:  Phillip Nguyen and David Garrison on 4/25/2023

Option Strict On
Option Explicit On
Option Infer Off

Public Class frmMain
    Dim seconds As Integer
    Dim wheelstate As Integer = 1
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picWheel.Image = WheelImages.Images(0)
        Timer1.Interval = 50
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wheelspin As Integer
        Timer1.Start()

    End Sub

    Private Async Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        seconds += 1

        If seconds = 1 Then
            If wheelstate < 24 Then
                picWheel.Image = WheelImages.Images(wheelstate)
                wheelstate += 1
            Else
                wheelstate = 0
                picWheel.Image = WheelImages.Images(wheelstate)
            End If
            seconds = 0
        End If
    End Sub
End Class