Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim oForm As Form1
        oForm = New Form1 ()
        oForm.Show ()
        oForm = Nothing
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username , password As String
        Dim bartek1 As String = "bartek1"
        Dim bartek As String = "bartek"
        username = TextBox1.Text
        password = TextBox1.Text
        If String.Compare(username, bartek1) = 0 Then
            If String.Compare (password,bartek)

            

            MsgBox("Panie", 0, "Witam")

             End If
            Else 
            Threading.Thread.CurrentThread.Sleep(2000)
             MsgBox("WROOOONG!",16,"Error")
       End If
    End Sub
End Class