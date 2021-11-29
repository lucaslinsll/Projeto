<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro_Usuario
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro_Usuario))
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtCadLogin = New System.Windows.Forms.TextBox()
        Me.txtCadSenha = New System.Windows.Forms.TextBox()
        Me.btnCadUser = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblLogin.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(280, 243)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(186, 22)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Digite seu novo usuário"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.BackColor = System.Drawing.Color.Transparent
        Me.lblSenha.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSenha.ForeColor = System.Drawing.Color.White
        Me.lblSenha.Location = New System.Drawing.Point(279, 377)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(172, 22)
        Me.lblSenha.TabIndex = 1
        Me.lblSenha.Text = "Digite sua nova senha"
        '
        'txtCadLogin
        '
        Me.txtCadLogin.Font = New System.Drawing.Font("Humanst521 BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCadLogin.Location = New System.Drawing.Point(278, 268)
        Me.txtCadLogin.Name = "txtCadLogin"
        Me.txtCadLogin.Size = New System.Drawing.Size(308, 33)
        Me.txtCadLogin.TabIndex = 2
        '
        'txtCadSenha
        '
        Me.txtCadSenha.Font = New System.Drawing.Font("Humanst521 BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCadSenha.Location = New System.Drawing.Point(283, 402)
        Me.txtCadSenha.Name = "txtCadSenha"
        Me.txtCadSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCadSenha.Size = New System.Drawing.Size(308, 33)
        Me.txtCadSenha.TabIndex = 3
        '
        'btnCadUser
        '
        Me.btnCadUser.BackColor = System.Drawing.Color.Crimson
        Me.btnCadUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCadUser.Font = New System.Drawing.Font("Humanst521 BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadUser.ForeColor = System.Drawing.Color.White
        Me.btnCadUser.Location = New System.Drawing.Point(283, 527)
        Me.btnCadUser.Name = "btnCadUser"
        Me.btnCadUser.Size = New System.Drawing.Size(308, 33)
        Me.btnCadUser.TabIndex = 4
        Me.btnCadUser.Text = "CADASTRAR"
        Me.btnCadUser.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SistemaDeFerramentas.My.Resources.Resources.linha
        Me.PictureBox1.Location = New System.Drawing.Point(184, -98)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(480, 270)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Humanst521 BT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(331, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 42)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CADASTRO"
        '
        'Cadastro_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaDeFerramentas.My.Resources.Resources.Fundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(862, 749)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCadUser)
        Me.Controls.Add(Me.txtCadSenha)
        Me.Controls.Add(Me.txtCadLogin)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cadastro_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADASTRO"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogin As Label
    Friend WithEvents lblSenha As Label
    Friend WithEvents txtCadLogin As TextBox
    Friend WithEvents txtCadSenha As TextBox
    Friend WithEvents btnCadUser As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
