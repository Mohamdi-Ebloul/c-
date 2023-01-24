Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim basePrix As Decimal
        Dim pwss As Integer
        Dim TVA As Decimal
        Dim TVAMontant As Decimal
        Dim totalPrix As Decimal

        basePrix = Decimal.Parse(TextBox1.Text)
        pwss = Integer.Parse(TextBox2.Text)

        If pwss < 115 Then
            TVA = 0.25D
        Else
            TVA = 0.33D
        End If

        TVAMontant = basePrix * TVA
        totalPrix = basePrix + TVAMontant

        Label1.Text = TVA * 100 & "%"
        Label2.Text = TVAMontant
        Label3.Text = totalPrix
    End Sub
End Class