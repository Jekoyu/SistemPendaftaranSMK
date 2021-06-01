<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.CbRole = New System.Windows.Forms.ComboBox()
        Me.TbPasssword = New System.Windows.Forms.TextBox()
        Me.TbUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(480, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 26)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BtnLogin
        '
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Location = New System.Drawing.Point(218, 503)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(93, 33)
        Me.BtnLogin.TabIndex = 17
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'CbRole
        '
        Me.CbRole.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.CbRole.FormattingEnabled = True
        Me.CbRole.Location = New System.Drawing.Point(241, 403)
        Me.CbRole.Name = "CbRole"
        Me.CbRole.Size = New System.Drawing.Size(197, 36)
        Me.CbRole.TabIndex = 16
        Me.CbRole.Text = "PILIH ROLE"
        '
        'TbPasssword
        '
        Me.TbPasssword.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.TbPasssword.Location = New System.Drawing.Point(241, 325)
        Me.TbPasssword.Name = "TbPasssword"
        Me.TbPasssword.Size = New System.Drawing.Size(197, 34)
        Me.TbPasssword.TabIndex = 15
        '
        'TbUsername
        '
        Me.TbUsername.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.TbUsername.Location = New System.Drawing.Point(241, 250)
        Me.TbUsername.Name = "TbUsername"
        Me.TbUsername.Size = New System.Drawing.Size(197, 34)
        Me.TbUsername.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(64, 403)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 37)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Role"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(64, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 37)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(64, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 37)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(209, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 54)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "LOGIN"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(581, 705)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.CbRole)
        Me.Controls.Add(Me.TbPasssword)
        Me.Controls.Add(Me.TbUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents BtnLogin As Button
    Friend WithEvents CbRole As ComboBox
    Friend WithEvents TbPasssword As TextBox
    Friend WithEvents TbUsername As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
