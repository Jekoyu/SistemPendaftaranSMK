Public Class RegConfirm
    Private Sub RegConfirm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUsername.Text = LblNo.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PendaftaranSiswa.Kosongkan()
        PendaftaranSiswa.Close()
        Me.Close()

    End Sub
End Class