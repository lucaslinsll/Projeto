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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FaturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaGeralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatóriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioGeralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatórioEspecíficoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SairToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCadClientes = New System.Windows.Forms.Button()
        Me.btnLocacao = New System.Windows.Forms.Button()
        Me.btnCadFerramentas = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.RelatóriosToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(611, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.RegistrosToolStripMenuItem, Me.FaturasToolStripMenuItem, Me.UsuáriosToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.CadastrosToolStripMenuItem.Text = "&Cadastros"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'FaturasToolStripMenuItem
        '
        Me.FaturasToolStripMenuItem.Name = "FaturasToolStripMenuItem"
        Me.FaturasToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.FaturasToolStripMenuItem.Text = "Faturas"
        '
        'UsuáriosToolStripMenuItem
        '
        Me.UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        Me.UsuáriosToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.UsuáriosToolStripMenuItem.Text = "Usuários"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultaGeralToolStripMenuItem, Me.ConsultaToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ConsultaGeralToolStripMenuItem
        '
        Me.ConsultaGeralToolStripMenuItem.Name = "ConsultaGeralToolStripMenuItem"
        Me.ConsultaGeralToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ConsultaGeralToolStripMenuItem.Text = "Consulta geral"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consulta específica"
        '
        'RelatóriosToolStripMenuItem
        '
        Me.RelatóriosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatórioGeralToolStripMenuItem, Me.RelatórioEspecíficoToolStripMenuItem})
        Me.RelatóriosToolStripMenuItem.Name = "RelatóriosToolStripMenuItem"
        Me.RelatóriosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.RelatóriosToolStripMenuItem.Text = "Relatórios"
        '
        'RelatórioGeralToolStripMenuItem
        '
        Me.RelatórioGeralToolStripMenuItem.Name = "RelatórioGeralToolStripMenuItem"
        Me.RelatórioGeralToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RelatórioGeralToolStripMenuItem.Text = "Relatório geral"
        '
        'RelatórioEspecíficoToolStripMenuItem
        '
        Me.RelatórioEspecíficoToolStripMenuItem.Name = "RelatórioEspecíficoToolStripMenuItem"
        Me.RelatórioEspecíficoToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.RelatórioEspecíficoToolStripMenuItem.Text = "Relatório específico"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairToolStripMenuItem, Me.ToolStripMenuItem1, Me.SairToolStripMenuItem1})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.SairToolStripMenuItem.Text = "Ajuda"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(102, 6)
        '
        'SairToolStripMenuItem1
        '
        Me.SairToolStripMenuItem1.Name = "SairToolStripMenuItem1"
        Me.SairToolStripMenuItem1.Size = New System.Drawing.Size(105, 22)
        Me.SairToolStripMenuItem1.Text = "Sair"
        '
        'btnCadClientes
        '
        Me.btnCadClientes.Location = New System.Drawing.Point(59, 133)
        Me.btnCadClientes.Name = "btnCadClientes"
        Me.btnCadClientes.Size = New System.Drawing.Size(124, 65)
        Me.btnCadClientes.TabIndex = 1
        Me.btnCadClientes.Text = "Cadastrar Cliente"
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "F_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatóriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FaturasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaGeralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioGeralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RelatórioEspecíficoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SairToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents btnCadClientes As Button
    Friend WithEvents btnLocacao As Button
    Friend WithEvents btnCadFerramentas As Button
End Class
