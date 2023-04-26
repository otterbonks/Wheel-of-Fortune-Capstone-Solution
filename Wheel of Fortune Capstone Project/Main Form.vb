﻿Option Strict On
Option Explicit On
Option Infer Off
' Name:         Wheel of Fortune Capstone
' Purpose:
' Programmers:  Phillip Nguyen and David Garrison on 4/25/2023
Imports System.Threading

Public Class frmMain
    Dim seconds As Integer
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picWheel.Image = WheelImages.Images(0)
        Timer1.Interval = 1000
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim wheelspin As Integer
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim wheelstate As Integer = 1
        seconds += 1

        If seconds = 1 Then
            picWheel.Image = WheelImages.Images(wheelstate)
            wheelstate += 1
        End If
        seconds = 0

            Timer1.Stop()
    End Sub
End Class