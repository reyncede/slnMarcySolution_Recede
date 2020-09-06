Option Explicit On
Option Infer Off
Option Strict On
Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim price1 As Double = Val(txtPrice1.Text)
        Dim price2 As Double = Val(txtPrice2.Text)
        Dim savedAmount As Double

        If price1 > price2 Then
            savedAmount = price2
            price2 /= 2
            savedAmount -= price2
        Else
            savedAmount = price1
            price1 /= 2
            savedAmount -= price1
        End If

        txtTotal.Text = (price1 + price2).ToString("C2")

        MessageBox.Show("Amount Saved: " & savedAmount.ToString("C2"))
        toggleAmount(True)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub txtPrice1_Enter_Click(sender As Object, e As EventArgs) Handles txtPrice1.Enter, txtPrice1.Click
        txtPrice1.SelectAll()
    End Sub

    Private Sub txtPrice2_Enter_Click(sender As Object, e As EventArgs) Handles txtPrice2.Enter, txtPrice2.Click
        txtPrice2.SelectAll()
    End Sub

    Private Sub txtPrice1or2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice1.KeyPress, txtPrice2.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Asc(e.KeyChar) = 8 Or e.KeyChar = ".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrice1or2_TextChanged(sender As Object, e As EventArgs) Handles txtPrice1.TextChanged, txtPrice2.TextChanged
        toggleAmount(False)
    End Sub

    Private Sub toggleAmount(b As Boolean)
        lblTotal.Visible = b
        txtTotal.Visible = b
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toggleAmount(True)
    End Sub
End Class




