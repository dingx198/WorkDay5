﻿Option Strict On

Public Class Form1

    Private Sub btnDetermine_Click(sender As System.Object, e As System.EventArgs) Handles btnDetermine.Click
        Dim name As String
        name = txtFullName.Text
        txtFirstName.Text = FirstName(name)
        MessageBox.Show("lalalala")

    End Sub

    Function FirstName(ByVal name As String) As String
        Return "Not Implemented Yet"
    End Function

End Class
