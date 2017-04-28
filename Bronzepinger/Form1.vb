Public Class Form1
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim oForm As Form2
        oForm = New Form2 ()
        oForm.Show ()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
         Dim oForm As Form4
        oForm = New Form4 ()
        oForm.Show ()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start ("https://bartlewpaulineg.wixsite.com/progam")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       Dim oForm As Form5
        oForm = New Form5 ()
        oForm.Show ()
        oForm = Nothing
        Me.Hide()
    End Sub
End Class

