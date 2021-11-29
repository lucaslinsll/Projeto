<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro_Ferramentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro_Ferramentas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbmTipo = New System.Windows.Forms.ComboBox()
        Me.cbmEstado = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbmDisp = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCod_morador = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCod_estoque = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(160, 233)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ferramenta:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Enabled = False
        Me.txtDescricao.Font = New System.Drawing.Font("Humanst521 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.Location = New System.Drawing.Point(276, 232)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(115, 23)
        Me.txtDescricao.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(489, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Buscar:"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(565, 260)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(115, 20)
        Me.txtBuscar.TabIndex = 3
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Humanst521 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(276, 204)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(44, 23)
        Me.txtCodigo.TabIndex = 4
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.White
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg.DefaultCellStyle = DataGridViewCellStyle1
        Me.dg.Location = New System.Drawing.Point(97, 372)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(595, 150)
        Me.dg.TabIndex = 5
        '
        'btnSalvar
        '
        Me.btnSalvar.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvar.BackgroundImage = Global.SistemaDeFerramentas.My.Resources.Resources.SALVAR
        Me.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Enabled = False
        Me.btnSalvar.FlatAppearance.BorderSize = 0
        Me.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvar.Location = New System.Drawing.Point(311, 560)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(106, 91)
        Me.btnSalvar.TabIndex = 6
        Me.btnSalvar.UseVisualStyleBackColor = False
        '
        'btnNovo
        '
        Me.btnNovo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovo.BackgroundImage = Global.SistemaDeFerramentas.My.Resources.Resources.ADICIONAR
        Me.btnNovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.FlatAppearance.BorderSize = 0
        Me.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovo.Location = New System.Drawing.Point(206, 560)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(106, 91)
        Me.btnNovo.TabIndex = 7
        Me.btnNovo.UseVisualStyleBackColor = False
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Transparent
        Me.btnEditar.BackgroundImage = Global.SistemaDeFerramentas.My.Resources.Resources.EDITAR
        Me.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Enabled = False
        Me.btnEditar.FlatAppearance.BorderSize = 0
        Me.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Location = New System.Drawing.Point(412, 560)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(106, 91)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.UseVisualStyleBackColor = False
        '
        'btnExcluir
        '
        Me.btnExcluir.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluir.BackgroundImage = Global.SistemaDeFerramentas.My.Resources.Resources.LIXO
        Me.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Enabled = False
        Me.btnExcluir.FlatAppearance.BorderSize = 0
        Me.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Location = New System.Drawing.Point(517, 560)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(106, 91)
        Me.btnExcluir.TabIndex = 9
        Me.btnExcluir.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Humanst521 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(624, 525)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Registros:"
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = True
        Me.lblRegistros.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistros.Font = New System.Drawing.Font("Humanst521 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.Location = New System.Drawing.Point(688, 525)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(13, 18)
        Me.lblRegistros.TabIndex = 11
        Me.lblRegistros.Text = "-"
        '
        'txtMarca
        '
        Me.txtMarca.Enabled = False
        Me.txtMarca.Font = New System.Drawing.Font("Humanst521 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(276, 258)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(115, 23)
        Me.txtMarca.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(202, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Marca:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(212, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 22)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Tipo:"
        '
        'cbmTipo
        '
        Me.cbmTipo.Font = New System.Drawing.Font("Humanst521 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbmTipo.FormattingEnabled = True
        Me.cbmTipo.Items.AddRange(New Object() {"Manual", "Elétrica"})
        Me.cbmTipo.Location = New System.Drawing.Point(276, 284)
        Me.cbmTipo.Name = "cbmTipo"
        Me.cbmTipo.Size = New System.Drawing.Size(121, 23)
        Me.cbmTipo.TabIndex = 16
        '
        'cbmEstado
        '
        Me.cbmEstado.Font = New System.Drawing.Font("Humanst521 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbmEstado.FormattingEnabled = True
        Me.cbmEstado.Items.AddRange(New Object() {"Nova ", "Conservada ", "Desgastada"})
        Me.cbmEstado.Location = New System.Drawing.Point(276, 309)
        Me.cbmEstado.Name = "cbmEstado"
        Me.cbmEstado.Size = New System.Drawing.Size(121, 23)
        Me.cbmEstado.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(197, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 22)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Estado:"
        '
        'cbmDisp
        '
        Me.cbmDisp.Font = New System.Drawing.Font("Humanst521 BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbmDisp.FormattingEnabled = True
        Me.cbmDisp.Items.AddRange(New Object() {"Disponível", "Indisponível"})
        Me.cbmDisp.Location = New System.Drawing.Point(276, 335)
        Me.cbmDisp.Name = "cbmDisp"
        Me.cbmDisp.Size = New System.Drawing.Size(121, 23)
        Me.cbmDisp.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(131, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 22)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Disponibilidade:"
        '
        'txtCod_morador
        '
        Me.txtCod_morador.Enabled = False
        Me.txtCod_morador.Location = New System.Drawing.Point(565, 286)
        Me.txtCod_morador.Name = "txtCod_morador"
        Me.txtCod_morador.Size = New System.Drawing.Size(115, 20)
        Me.txtCod_morador.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(419, 282)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 22)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Código morador:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(424, 306)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 22)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Código estoque:"
        '
        'txtCod_estoque
        '
        Me.txtCod_estoque.Enabled = False
        Me.txtCod_estoque.Location = New System.Drawing.Point(565, 310)
        Me.txtCod_estoque.Name = "txtCod_estoque"
        Me.txtCod_estoque.Size = New System.Drawing.Size(115, 20)
        Me.txtCod_estoque.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(129, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 22)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Item selecionado:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Humanst521 BT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Crimson
        Me.Label11.Location = New System.Drawing.Point(148, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(540, 42)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "CADASTRO DE FERRAMENTAS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SistemaDeFerramentas.My.Resources.Resources.linha
        Me.PictureBox1.Location = New System.Drawing.Point(164, -97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(480, 270)
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'Cadastro_Ferramentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.SistemaDeFerramentas.My.Resources.Resources.Fundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 749)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCod_estoque)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCod_morador)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbmDisp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbmEstado)
        Me.Controls.Add(Me.cbmTipo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnNovo)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Cadastro_Ferramentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Ferramentas"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents dg As DataGridView
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnNovo As Button
    Friend WithEvents btnEditar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblRegistros As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbmTipo As ComboBox
    Friend WithEvents cbmEstado As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbmDisp As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCod_morador As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCod_estoque As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
