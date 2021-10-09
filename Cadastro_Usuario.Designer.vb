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
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.txtCadLogin = New System.Windows.Forms.TextBox()
        Me.txtCadSenha = New System.Windows.Forms.TextBox()
        Me.btnCadUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(33, 63)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(36, 13)
        Me.lblLogin.TabIndex = 0
        Me.lblLogin.Text = "Login:"
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(33, 101)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(41, 13)
        Me.lblSenha.TabIndex = 1
        Me.lblSenha.Text = "Senha:"
        '
        'txtCadLogin
        '
        Me.txtCadLogin.Location = New System.Drawing.Point(75, 56)
        Me.txtCadLogin.Name = "txtCadLogin"
        Me.txtCadLogin.Size = New System.Drawing.Size(100, 20)
        Me.txtCadLogin.TabIndex = 2
        '
        'txtCadSenha
        '
        Me.txtCadSenha.Location = New System.Drawing.Point(75, 94)
        Me.txtCadSenha.Name = "txtCadSenha"
        Me.txtCadSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCadSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtCadSenha.TabIndex = 3
        '
        'btnCadUser
        '
        Me.btnCadUser.Location = New System.Drawing.Point(217, 91)
        Me.btnCadUser.Name = "btnCadUser"
        Me.btnCadUser.Size = New System.Drawing.Size(75, 23)
        Me.btnCadUser.TabIndex = 4
        Me.btnCadUser.Text = "Cadastrar"
        Me.btnCadUser.UseVisualStyleBackColor = True
        '
        'Cadastro_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 250)
        Me.Controls.Add(Me.btnCadUser)
        Me.Controls.Add(Me.txtCadSenha)
        Me.Controls.Add(Me.txtCadLogin)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblLogin)
        Me.Name = "Cadastro_Usuario"
        Me.Text = "Cadastrar Usuário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogin As Label
    Friend WithEvents lblSenha As Label
    Friend WithEvents txtCadLogin As TextBox
    Friend WithEvents txtCadSenha As TextBox
    Friend WithEvents btnCadUser As Button
End Class
