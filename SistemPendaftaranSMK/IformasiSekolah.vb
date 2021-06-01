Public Class InformasiSekolah
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not ComboBox1.Text = "" Then
            Dim dl = ComboBox1.Text.Substring(0, 2)
            q = "select * from tb_jurusan where kode_jurusan = '" & dl & "'"
            Cari(q)
            If dr.HasRows Then
                IJurusan.LblNamaJurusan.Text = dr.Item("nama")
                IJurusan.LblDeskripsi.Text = dr.Item("deskripsi")
                IJurusan.LblKapasitas.Text = dr.Item("kapasitas")
                IJurusan.Show()
            End If
        End If
    End Sub

    Private Sub InformasiSekolah_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class