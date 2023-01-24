Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim N As Integer
        Dim sommeimp As Integer
        Dim sommepair As Integer

        N = Integer.Parse(TextBox1.Text)

        Dim nbimp As New List(Of Integer)
        Dim nbpair As New List(Of Integer)
        For i As Integer = 1 To N
            If i Mod 2 = 0 Then
                nbimp.Add(i)
                sommeimp += i
            Else
                nbpair.Add(i)
                sommepair += i
            End If
        Next
        TextBox2.Text = String.Join(",", nbimp)
        TextBox3.Text = String.Join(",", nbpair)
        Label1.Text = sommeimp
        Label2.Text = sommepair
    End Sub
End Class