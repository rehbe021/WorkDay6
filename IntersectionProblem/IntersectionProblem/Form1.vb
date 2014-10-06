﻿Option Strict On

Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Ast, Bst, Cst, Dst As String
        Dim A, B, C, D As Double

        ' Read the input from the user
        Ast = txtA.Text
        Bst = txtB.Text
        Cst = txtC.Text
        Dst = txtD.Text

        ' All input must be numbers
        If Not (IsNumeric(Ast) And IsNumeric(Bst) And IsNumeric(Cst) _
                And IsNumeric(Dst)) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
            Return
        End If
        
        ' Convert to double
        A = CDbl(Ast)
        B = CDbl(Bst)
        C = CDbl(Cst)
        D = CDbl(Dst)

        If (B < A) Or (D < C) Then
            MessageBox.Show("Please enter valid numbers")
            Return
        End If

        txtResult.Text = FindIntersection(A, B, C, D)

    End Sub
    Function FindIntersection(a As Double, b As Double, c As Double, d As Double) As String
        Dim result As String
        Dim int1, int2 As Double
        If (b < c) Or (d < a) Then
            result = "No intersection"
        Else
            If a < c Then
                int1 = c
            Else
                int1 = a
            End If
            If d < b Then
                int2 = d
            Else
                int2 = b
            End If
            result = "There is an intersection from " & int1 & " to " & int2
        End If

        Return result

    End Function
End Class
