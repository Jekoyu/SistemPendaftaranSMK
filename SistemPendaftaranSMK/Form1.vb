Public Class Form1
    Dim tkn As String
    Sub SP(ByVal p As Form)
        Panel3.Controls.Clear()
        p.TopLevel = False
        Panel3.Controls.Add(p)
        p.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        InformasiSekolah.Show()
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PendaftaranSiswa.ShowDialog()
        'Me.Visible = False

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateToken()
    End Sub
    Sub UpdateToken()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Login.ShowDialog()

    End Sub
End Class
