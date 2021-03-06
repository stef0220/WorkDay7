﻿Option Strict On

Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Read the input and check if the user typed in numbers
        Dim amountSt As String = txtAmount.Text
        If Not IsNumeric(amountSt) Then
            MessageBox.Show("Please type the numbers!")
            Return
        End If

        ' Convert into a number 
        Dim balance, r As Double, numYears As Integer = 0
        balance = CDbl(amountSt)

        ' Compute the time it takes to reach the balance of a million
        Do While balance < 1000000
            balance += 0.06 * balance
            numYears += 1

            If numYears < 10 Then
                r += 0.005
            End If
        Loop

        txtWhen.Text = "In " & numYears & " years you will have a million dollars."
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
