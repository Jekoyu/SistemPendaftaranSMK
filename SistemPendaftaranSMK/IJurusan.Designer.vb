<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IJurusan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LblNamaJurusan = New System.Windows.Forms.Label()
        Me.LblDeskripsi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblKapasitas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblNamaJurusan
        '
        Me.LblNamaJurusan.AutoSize = True
        Me.LblNamaJurusan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblNamaJurusan.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold)
        Me.LblNamaJurusan.ForeColor = System.Drawing.Color.White
        Me.LblNamaJurusan.Location = New System.Drawing.Point(235, 81)
        Me.LblNamaJurusan.Name = "LblNamaJurusan"
        Me.LblNamaJurusan.Size = New System.Drawing.Size(207, 54)
        Me.LblNamaJurusan.TabIndex = 3
        Me.LblNamaJurusan.Text = "JURUSAN"
        '
        'LblDeskripsi
        '
        Me.LblDeskripsi.AutoSize = True
        Me.LblDeskripsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblDeskripsi.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.LblDeskripsi.ForeColor = System.Drawing.Color.White
        Me.LblDeskripsi.Location = New System.Drawing.Point(79, 186)
        Me.LblDeskripsi.Name = "LblDeskripsi"
        Me.LblDeskripsi.Size = New System.Drawing.Size(520, 46)
        Me.LblDeskripsi.TabIndex = 4
        Me.LblDeskripsi.Text = "REKAYASA PERANGKAT LUNAK"
        '
        'Label1
        '
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 410)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(299, 46)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kapasitas Siswa :"
        '
        'LblKapasitas
        '
        Me.LblKapasitas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LblKapasitas.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Bold)
        Me.LblKapasitas.ForeColor = System.Drawing.Color.White
        Me.LblKapasitas.Location = New System.Drawing.Point(315, 410)
        Me.LblKapasitas.Name = "LblKapasitas"
        Me.LblKapasitas.Size = New System.Drawing.Size(70, 46)
        Me.LblKapasitas.TabIndex = 6
        Me.LblKapasitas.Text = "64"
        '
        'IJurusan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 800)
        Me.Controls.Add(Me.LblKapasitas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblDeskripsi)
        Me.Controls.Add(Me.LblNamaJurusan)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.Name = "IJurusan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNamaJurusan As Label
    Friend WithEvents LblDeskripsi As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblKapasitas As Label
End Class
