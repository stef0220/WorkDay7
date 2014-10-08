Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim Pop As Double, Year As Integer
        Pop = 7000000
        Year = 2014
        Do While Pop >= 6000000
            Year -= 50
            Pop = Pop / 2
        Loop


        MessageBox.Show("The year was " & Year)


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
