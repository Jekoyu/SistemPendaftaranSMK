Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosongkan

    End Sub
    Sub Kosongkan()
        TbUsername.Clear()
        TbPasssword.Clear()
        CbRole.ResetText()
        Combo
    End Sub
    Sub Combo()
        Koneksi()
        q = "select * from tb_role order by id asc"
        cmd = New SqlClient.SqlCommand(q, conn)
        CbRole.ResetText()
        dr = cmd.ExecuteReader
        While dr.Read
            CbRole.Items.Add(dr.Item("id") + ". " + dr.Item("role").ToString.ToUpper)
        End While
    End Sub
    Sub Staf()
        q = "select * from tb_staf where nip ='" & TbUsername.Text & "' and password = '" & TbPasssword.Text & "'"
        Cari(q)
        If dr.HasRows Then
            Master.Staff()
            Master.Show()
            Form1.Visible = False
        Else
            MsgBox("Username/Password Salah", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub Guru()
        q = "select * from tb_staf where nip ='" & TbUsername.Text & "' and password = '" & TbPasssword.Text & "'"
        Cari(q)
        If dr.HasRows Then
            Master.Guru()
            Master.Show()
            Form1.Visible = False
        Else
            MsgBox("Username/Password Salah", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub Siswa()
        q = "select * from tb_calon_siswa where id_pendaftaran = '" & TbUsername.Text & "' and password = '" & TbPasssword.Text & "'"
        Cari(q)
        If dr.HasRows Then
            Master.Siswa()
            Master.Show()
            Form1.Visible = False
        Else
            MsgBox("Username/Password Salah", MsgBoxStyle.Critical)
        End If
    End Sub
    Sub Login()
        If CbRole.Text.Substring(0, 1) = 1 Then
            Guru()
        ElseIf CbRole.Text.Substring(0, 1) = 2 Then
            Staf()
        Else
            Siswa()
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TbUsername.Text = "" Or TbPasssword.Text = "" Or CbRole.Text = "" Then
            MsgBox("Data Kosong", MsgBoxStyle.Critical)
        Else
            If CbRole.Text = CbRole.SelectedItem Then
                Login()
                Me.Visible = False
            Else
                MsgBox("Role Error", MsgBoxStyle.Critical)
            End If
        End If

    End Sub
End Class