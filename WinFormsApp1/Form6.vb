Public Class Form6


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex <> -1 Then
            Dim selectedCity As String = ListBox1.SelectedItem.ToString()



        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ville As String = TextBox1.Text
        ListBox1.Items.Add(ville)
        textbox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex <> -1 Then
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim indice = Integer.Parse(InputBox("Entrez un indic :",))
        If indice < ListBox1.Items.Count And indice >= 0 Then
            ListBox1.Items.RemoveAt(indice)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nombre As Integer = ListBox1.Items.Count
        MessageBox.Show("Nombre de Villes: " & nombre)
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If ListBox1.SelectedIndex <> -1 Then
            Dim selectedCity As String = ListBox1.SelectedItem.ToString()
            MessageBox.Show(selectedCity)


        End If


    End Sub
End Class