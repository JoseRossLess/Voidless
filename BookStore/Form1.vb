﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Texto As String
        Texto = Me.TextBox1.Text
        MsgBox("Hola" & Texto, MsgBoxStyle.Information, "Mensaje de Saludo")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
