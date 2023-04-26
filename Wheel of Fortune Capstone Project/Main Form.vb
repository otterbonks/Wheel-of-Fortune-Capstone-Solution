Option Strict On
Option Explicit On
Option Infer Off
' Name:         Wheel of Fortune Capstone
' Purpose:
' Programmers:  Phillip Nguyen and David Garrison on 4/25/2023
Imports System.Threading

Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picWheel.Image = WheelImages.Images(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wheelstate As Integer
        Dim wheelspin As Integer
        Timer1.Interval = 1000


        Do Until wheelstate = 24
            Timer1.Start()
            Timer1.Stop()
            picWheel.Image = WheelImages.Images(wheelstate)
            wheelstate += 1
        Loop
    End Sub
End Class
