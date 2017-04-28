Public Class Form4
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
         Dim oForm As Form3
        oForm = New Form3()
        oForm.Show ()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
         Dim oForm As Form1
        oForm = New Form1()
        oForm.Show ()
        oForm = Nothing
        Me.Hide()
    End Sub
End Class