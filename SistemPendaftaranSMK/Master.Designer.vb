<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Master
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnJurusan = New System.Windows.Forms.Button()
        Me.BtnSiswa = New System.Windows.Forms.Button()
        Me.BtnGuru = New System.Windows.Forms.Button()
        Me.BtnHasilTest = New System.Windows.Forms.Button()
        Me.BtnKoreksi = New System.Windows.Forms.Button()
        Me.BtnHasil = New System.Windows.Forms.Button()
        Me.BtnTest = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.BtnJurusan)
        Me.Panel1.Controls.Add(Me.BtnSiswa)
        Me.Panel1.Controls.Add(Me.BtnGuru)
        Me.Panel1.Controls.Add(Me.BtnHasilTest)
        Me.Panel1.Controls.Add(Me.BtnKoreksi)
        Me.Panel1.Controls.Add(Me.BtnHasil)
        Me.Panel1.Controls.Add(Me.BtnTest)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Strikeout)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 800)
        Me.Panel1.TabIndex = 0
        '
        'BtnLogout
        '
        Me.BtnLogout.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnLogout.FlatAppearance.BorderSize = 0
        Me.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogout.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Location = New System.Drawing.Point(0, 571)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(200, 60)
        Me.BtnLogout.TabIndex = 11
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogout.UseVisualStyleBackColor = True
        Me.BtnLogout.Visible = False
        '
        'BtnJurusan
        '
        Me.BtnJurusan.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnJurusan.FlatAppearance.BorderSize = 0
        Me.BtnJurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJurusan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnJurusan.ForeColor = System.Drawing.Color.White
        Me.BtnJurusan.Location = New System.Drawing.Point(0, 511)
        Me.BtnJurusan.Name = "BtnJurusan"
        Me.BtnJurusan.Size = New System.Drawing.Size(200, 60)
        Me.BtnJurusan.TabIndex = 7
        Me.BtnJurusan.Text = "Jurusan"
        Me.BtnJurusan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnJurusan.UseVisualStyleBackColor = True
        Me.BtnJurusan.Visible = False
        '
        'BtnSiswa
        '
        Me.BtnSiswa.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnSiswa.FlatAppearance.BorderSize = 0
        Me.BtnSiswa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiswa.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnSiswa.ForeColor = System.Drawing.Color.White
        Me.BtnSiswa.Location = New System.Drawing.Point(0, 451)
        Me.BtnSiswa.Name = "BtnSiswa"
        Me.BtnSiswa.Size = New System.Drawing.Size(200, 60)
        Me.BtnSiswa.TabIndex = 6
        Me.BtnSiswa.Text = "Calon Siswa"
        Me.BtnSiswa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSiswa.UseVisualStyleBackColor = True
        Me.BtnSiswa.Visible = False
        '
        'BtnGuru
        '
        Me.BtnGuru.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnGuru.FlatAppearance.BorderSize = 0
        Me.BtnGuru.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuru.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnGuru.ForeColor = System.Drawing.Color.White
        Me.BtnGuru.Location = New System.Drawing.Point(0, 391)
        Me.BtnGuru.Name = "BtnGuru"
        Me.BtnGuru.Size = New System.Drawing.Size(200, 60)
        Me.BtnGuru.TabIndex = 5
        Me.BtnGuru.Text = "Guru dan Karyawan"
        Me.BtnGuru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuru.UseVisualStyleBackColor = True
        Me.BtnGuru.Visible = False
        '
        'BtnHasilTest
        '
        Me.BtnHasilTest.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHasilTest.FlatAppearance.BorderSize = 0
        Me.BtnHasilTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHasilTest.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnHasilTest.ForeColor = System.Drawing.Color.White
        Me.BtnHasilTest.Location = New System.Drawing.Point(0, 331)
        Me.BtnHasilTest.Name = "BtnHasilTest"
        Me.BtnHasilTest.Size = New System.Drawing.Size(200, 60)
        Me.BtnHasilTest.TabIndex = 4
        Me.BtnHasilTest.Text = "Hasil Test"
        Me.BtnHasilTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHasilTest.UseVisualStyleBackColor = True
        Me.BtnHasilTest.Visible = False
        '
        'BtnKoreksi
        '
        Me.BtnKoreksi.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnKoreksi.FlatAppearance.BorderSize = 0
        Me.BtnKoreksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKoreksi.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnKoreksi.ForeColor = System.Drawing.Color.White
        Me.BtnKoreksi.Location = New System.Drawing.Point(0, 271)
        Me.BtnKoreksi.Name = "BtnKoreksi"
        Me.BtnKoreksi.Size = New System.Drawing.Size(200, 60)
        Me.BtnKoreksi.TabIndex = 3
        Me.BtnKoreksi.Text = "Koreksi Test"
        Me.BtnKoreksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnKoreksi.UseVisualStyleBackColor = True
        Me.BtnKoreksi.Visible = False
        '
        'BtnHasil
        '
        Me.BtnHasil.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnHasil.FlatAppearance.BorderSize = 0
        Me.BtnHasil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHasil.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnHasil.ForeColor = System.Drawing.Color.White
        Me.BtnHasil.Location = New System.Drawing.Point(0, 211)
        Me.BtnHasil.Name = "BtnHasil"
        Me.BtnHasil.Size = New System.Drawing.Size(200, 60)
        Me.BtnHasil.TabIndex = 2
        Me.BtnHasil.Text = "Hasil"
        Me.BtnHasil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHasil.UseVisualStyleBackColor = True
        Me.BtnHasil.Visible = False
        '
        'BtnTest
        '
        Me.BtnTest.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnTest.FlatAppearance.BorderSize = 0
        Me.BtnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTest.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnTest.ForeColor = System.Drawing.Color.White
        Me.BtnTest.Location = New System.Drawing.Point(0, 151)
        Me.BtnTest.Name = "BtnTest"
        Me.BtnTest.Size = New System.Drawing.Size(200, 60)
        Me.BtnTest.TabIndex = 1
        Me.BtnTest.Text = "Test"
        Me.BtnTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTest.UseVisualStyleBackColor = True
        Me.BtnTest.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 151)
        Me.Panel4.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 74)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SMKN 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PONOROGO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(200, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 34)
        Me.Panel2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(912, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "_"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(956, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PanelContent
        '
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(200, 34)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(1000, 766)
        Me.PanelContent.TabIndex = 2
        '
        'Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelContent As Panel
    Friend WithEvents BtnTest As Button
    Friend WithEvents BtnJurusan As Button
    Friend WithEvents BtnSiswa As Button
    Friend WithEvents BtnGuru As Button
    Friend WithEvents BtnHasilTest As Button
    Friend WithEvents BtnKoreksi As Button
    Friend WithEvents BtnHasil As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
