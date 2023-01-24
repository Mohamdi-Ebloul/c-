Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre As Integer
        Dim count As Integer = 0

        For i As Integer = 1 To 10
            nombre = Integer.Parse(InputBox("Entrez un entier :", "Entrer un entier"))
            ListBox1.Items.Add(nombre)
            If nombre >= 10 Then
                count += 1
            End If
        Next

        MessageBox.Show("Nombre d'entiers supérieur ou égal à 10: " & count)
    End Sub
End Class