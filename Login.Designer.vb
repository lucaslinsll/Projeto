﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.TB_usuario = New System.Windows.Forms.TextBox()
        Me.TB_senha = New System.Windows.Forms.TextBox()
        Me.BTN_login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(21, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(26, 216)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Senha"
        '
        'LB_login
        '
        Me.LB_login.AutoSize = True
        Me.LB_login.BackColor = System.Drawing.Color.Transparent
        Me.LB_login.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LB_login.Location = New System.Drawing.Point(26, 381)
        Me.LB_login.Name = "LB_login"
        Me.LB_login.Size = New System.Drawing.Size(24, 13)
        Me.LB_login.TabIndex = 1
        Me.LB_login.Text = "info"
        '
        'TB_usuario
        '
        Me.TB_usuario.Location = New System.Drawing.Point(84, 144)
        Me.TB_usuario.Name = "TB_usuario"
        Me.TB_usuario.Size = New System.Drawing.Size(147, 20)
        Me.TB_usuario.TabIndex = 2
        '
        'TB_senha
        '
        Me.TB_senha.Location = New System.Drawing.Point(84, 209)
        Me.TB_senha.Name = "TB_senha"
        Me.TB_senha.Size = New System.Drawing.Size(147, 20)
        Me.TB_senha.TabIndex = 3
        '
        'BTN_login
        '
        Me.BTN_login.BackColor = System.Drawing.Color.Transparent
        Me.BTN_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_login.FlatAppearance.BorderSize = 0
        Me.BTN_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BTN_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BTN_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_login.Location = New System.Drawing.Point(77, 288)
        Me.BTN_login.Name = "BTN_login"
        Me.BTN_login.Size = New System.Drawing.Size(154, 32)
        Me.BTN_login.TabIndex = 4
        Me.BTN_login.UseVisualStyleBackColor = False
        '
        'F_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(508, 403)
        Me.Controls.Add(Me.BTN_login)
        Me.Controls.Add(Me.TB_senha)
        Me.Controls.Add(Me.TB_usuario)
        Me.Controls.Add(Me.LB_login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "F_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents LB_login As Label
	Friend WithEvents TB_usuario As TextBox
	Friend WithEvents TB_senha As TextBox
	Friend WithEvents BTN_login As Button
End Class