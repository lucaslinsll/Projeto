<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class F_login
	Inherits System.Windows.Forms.Form

	'Descartar substituições de formulário para limpar a lista de componentes.
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

	'Exigido pelo Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
	'Pode ser modificado usando o Windows Form Designer.  
	'Não o modifique usando o editor de códigos.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LB_login = New System.Windows.Forms.Label()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.BTN_login = New System.Windows.Forms.Button()
        Me.linkCadUsuario = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(277, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digite seu usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(277, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Digite sua senha"
        '
        'LB_login
        '
        Me.LB_login.AutoSize = True
        Me.LB_login.BackColor = System.Drawing.Color.Transparent
        Me.LB_login.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_login.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LB_login.Location = New System.Drawing.Point(98, 633)
        Me.LB_login.Name = "LB_login"
        Me.LB_login.Size = New System.Drawing.Size(38, 22)
        Me.LB_login.TabIndex = 1
        Me.LB_login.Text = "info"
        '
        'txtLogin
        '
        Me.txtLogin.Font = New System.Drawing.Font("Humanst521 BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogin.Location = New System.Drawing.Point(281, 261)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(297, 33)
        Me.txtLogin.TabIndex = 2
        '
        'txtSenha
        '
        Me.txtSenha.Font = New System.Drawing.Font("Humanst521 BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenha.Location = New System.Drawing.Point(281, 365)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(297, 33)
        Me.txtSenha.TabIndex = 3
        '
        'BTN_login
        '
        Me.BTN_login.BackColor = System.Drawing.Color.Crimson
        Me.BTN_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_login.FlatAppearance.BorderSize = 0
        Me.BTN_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BTN_login.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_login.ForeColor = System.Drawing.Color.White
        Me.BTN_login.Location = New System.Drawing.Point(281, 472)
        Me.BTN_login.Name = "BTN_login"
        Me.BTN_login.Size = New System.Drawing.Size(297, 29)
        Me.BTN_login.TabIndex = 4
        Me.BTN_login.Text = "LOGAR"
        Me.BTN_login.UseVisualStyleBackColor = False
        '
        'linkCadUsuario
        '
        Me.linkCadUsuario.AutoSize = True
        Me.linkCadUsuario.BackColor = System.Drawing.Color.Crimson
        Me.linkCadUsuario.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkCadUsuario.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.linkCadUsuario.LinkColor = System.Drawing.Color.White
        Me.linkCadUsuario.Location = New System.Drawing.Point(451, 587)
        Me.linkCadUsuario.Name = "linkCadUsuario"
        Me.linkCadUsuario.Size = New System.Drawing.Size(100, 22)
        Me.linkCadUsuario.TabIndex = 5
        Me.linkCadUsuario.TabStop = True
        Me.linkCadUsuario.Text = "Cadastre-se"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Humanst521 BT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(365, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 42)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "LOGIN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SistemaDeFerramentas.My.Resources.Resources.linha
        Me.PictureBox1.Location = New System.Drawing.Point(172, -99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(480, 270)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Humanst521 BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label4.Location = New System.Drawing.Point(314, 590)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Não tem cadastro?"
        '
        'F_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaDeFerramentas.My.Resources.Resources.Fundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(808, 749)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.linkCadUsuario)
        Me.Controls.Add(Me.BTN_login)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.LB_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents LB_login As Label
	Friend WithEvents txtLogin As TextBox
	Friend WithEvents txtSenha As TextBox
	Friend WithEvents BTN_login As Button
    Friend WithEvents linkCadUsuario As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
End Class
