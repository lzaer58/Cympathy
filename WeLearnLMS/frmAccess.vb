﻿Public Class frmAccess

    Private _Ok As Boolean

    Public Sub New(ByVal State As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._Ok = State
    End Sub

    Private Sub frmAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()
        Console.WriteLine(Label1.Text)
    End Sub

    Private Sub Colourme()
        If _Ok Then
            Label1.Text = "ACCESS GRANTED"
            Label1.ForeColor = Color.Blue
            Exit Sub
        End If
        Label1.Text = "ACCESS DENIED"
        Label1.ForeColor = Color.Red

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub

End Class