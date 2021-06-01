Public Class PendaftaranSiswa
    Dim id As String


    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbNoTelp.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub
    Sub Token()
        Dim token = Guid.NewGuid.ToString.ToUpper.Substring(0, 8)
        LblToken.Text = token
    End Sub
    Sub Kosongkan()
        TbNama.Clear()
        TbAlamat.Clear()
        TbNoTelp.Clear()
        TbAsalSekolah.Clear()
        CbJK.ResetText()
        CBJurusan1.Text = ""
        CBJurusan2.Text = ""
        CBJurusan3.Text = ""
        TbToken.Clear()
        CBJurusan3.ResetText()
        DTPTgl.ResetText()
    End Sub
    Sub Combo()
        q = "select * from tb_jurusan order by kode_jurusan asc"
        cmd = New SqlClient.SqlCommand(q, conn)

        dr = cmd.ExecuteReader
        CBJurusan1.ResetText()
        CBJurusan2.ResetText()
        CBJurusan3.ResetText()
        While dr.Read
            CBJurusan1.Items.Add(dr.Item("kode_jurusan") + ". " + dr.Item("deskripsi") + " (" + dr.Item("nama") + ")")
            CBJurusan2.Items.Add(dr.Item("kode_jurusan") + ". " + dr.Item("deskripsi") + " (" + dr.Item("nama") + ")")
            CBJurusan3.Items.Add(dr.Item("kode_jurusan") + ". " + dr.Item("deskripsi") + " (" + dr.Item("nama") + ")")
        End While

    End Sub

    Private Sub PendaftaranSiswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Koneksi()
        Kosongkan()
        Combo()
        Token()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TbToken.Text = LblToken.Text Then
            Dim N As String
            If CbJK.Text = "Laki-Laki" Then
                N = "L"
            Else
                N = "P"
            End If
            If TbNama.Text = "" Or TbAlamat.Text = "" Or TbAsalSekolah.Text = "" Or TbNoTelp.Text = "" Or TbToken.Text = "" Or CbJK.Text = "" Or CBJurusan1.Text = "" Then
            Else
                Dim pwd = Guid.NewGuid.ToString.ToUpper.Substring(0, 6)
                q = "select * from tb_calon_siswa order by id_pendaftaran desc"
                Cari(q)
                If dr.HasRows Then
                    id = N + Format(Now, "ddMMyy") + Format(Microsoft.VisualBasic.Right(dr.Item("id_pendaftaran"), 4) + 1, "0000")
                Else
                    id = N + Format(Now, "ddMMyy").ToString + "0001"
                End If

                RegConfirm.LblNama.Text = TbNama.Text
                RegConfirm.LblNo.Text = id
                RegConfirm.LblPassword.Text = pwd

                If CBJurusan1.Text = "" Then
                Else
                    q = "select * from tb_jurusan where kode_jurusan = '" & CBJurusan1.Text.Substring(0, 2) & "'"
                    Cari(q)
                    If dr.HasRows Then
                        RegConfirm.LblJurusan1.Text = dr.Item("deskripsi")
                    End If
                End If

                If CBJurusan2.Text = "" Then
                Else
                    q = "select * from tb_jurusan where kode_jurusan = '" & CBJurusan2.Text.Substring(0, 2) & "'"
                    Cari(q)
                    If dr.HasRows Then
                        RegConfirm.LblJururusan2.Text = dr.Item("deskripsi")
                    End If
                End If

                If CBJurusan3.Text = "" Then
                Else

                    q = "select * from tb_jurusan where kode_jurusan = '" & CBJurusan3.Text.Substring(0, 2) & "'"
                    Cari(q)
                    If dr.HasRows Then
                        RegConfirm.LblJurursan3.Text = dr.Item("deskripsi")
                    End If
                End If
                q = "insert into tb_calon_siswa values('" & id & "','" & pwd & "','" & TbNama.Text & "','" & Format(DTPTgl.Value, "dd/MM/yyyy") & "','" & TbAlamat.Text & "','','','" & CbJK.Text.Substring(0, 1) & "','','','')"
                ENQ(q)
                'MsgBox(q)
                RegConfirm.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Kosongkan()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim token = Guid.NewGuid.ToString.ToUpper.Substring(0, 8)
        LblToken.Text = token

    End Sub
End Class