Public Class Master
    Private Sub Master_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
    Sub SP(ByVal p As Form)
        PanelContent.Controls.Clear()
        p.TopLevel = False
        PanelContent.Controls.Add(p)
        p.Show()
    End Sub
    Sub Siswa()
        BtnTest.Visible = True
        BtnHasil.Visible = True
        BtnLogout.Visible = True
    End Sub
    Sub Guru()
        BtnKoreksi.Visible = True
        BtnHasilTest.Visible = True
        BtnLogout.Visible = True

    End Sub
    Sub Staff()
        BtnGuru.Visible = True
        BtnSiswa.Visible = True
        BtnJurusan.Visible = True
        BtnLogout.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r = MsgBox("Yakin Tutup?", vbYesNo)
        If r = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = WindowState.Minimized
    End Sub


End Class