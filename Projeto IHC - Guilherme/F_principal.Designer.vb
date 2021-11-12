<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_principal))
        Me.btnCadClientes = New System.Windows.Forms.Button()
        Me.btnLocacao = New System.Windows.Forms.Button()
        Me.btnCadFerramentas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCadClientes
        '
        Me.btnCadClientes.Location = New System.Drawing.Point(59, 133)
        Me.btnCadClientes.Name = "btnCadClientes"
        Me.btnCadClientes.Size = New System.Drawing.Size(124, 65)
        Me.btnCadClientes.TabIndex = 1
        Me.btnCadClientes.Text = "Cadastrar morador"
        Me.btnCadClientes.UseVisualStyleBackColor = True
        '
        'btnLocacao
        '
        Me.btnLocacao.Location = New System.Drawing.Point(243, 133)
        Me.btnLocacao.Name = "btnLocacao"
        Me.btnLocacao.Size = New System.Drawing.Size(124, 65)
        Me.btnLocacao.TabIndex = 2
        Me.btnLocacao.Text = "Realizar Locação"
        Me.btnLocacao.UseVisualStyleBackColor = True
        '
        'btnCadFerramentas
        '
        Me.btnCadFerramentas.Location = New System.Drawing.Point(420, 133)
        Me.btnCadFerramentas.Name = "btnCadFerramentas"
        Me.btnCadFerramentas.Size = New System.Drawing.Size(124, 65)
        Me.btnCadFerramentas.TabIndex = 3
        Me.btnCadFerramentas.Text = "Cadastrar Ferramenta"
        Me.btnCadFerramentas.UseVisualStyleBackColor = True
        '
        'F_principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 435)
        Me.Controls.Add(Me.btnCadFerramentas)
        Me.Controls.Add(Me.btnLocacao)
        Me.Controls.Add(Me.btnCadClientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "F_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu principal"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCadClientes As Button
    Friend WithEvents btnLocacao As Button
    Friend WithEvents btnCadFerramentas As Button
End Class
