Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ListBox1.Items.Clear()

        Dim a As Integer
        Dim n As Integer = 0
        Dim u As Integer

        a = Integer.Parse(TextBox1.Text)
        u = a

        ListBox1.Items.Add(u)

        Do Until u = 1
            If u Mod 2 = 0 Then
                u = u \ 2
            Else
                u = 3 * u + 1
            End If
            ListBox1.Items.Add(u)
            n += 1
        Loop

        Label1.Text = "N = " & n
    End Sub
End Class