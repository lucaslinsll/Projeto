<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro_moradores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro_moradores))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNascimento = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtCpf = New System.Windows.Forms.TextBox()
        Me.txtBloco = New System.Windows.Forms.TextBox()
        Me.txtAp = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.btnExcluirr = New System.Windows.Forms.Button()
        Me.btnEditarr = New System.Windows.Forms.Button()
        Me.btnNovoo = New System.Windows.Forms.Button()
        Me.btnSalvarr = New System.Windows.Forms.Button()
        Me.dgg = New System.Windows.Forms.DataGridView()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.dgg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(69, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data de nascimento :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(69, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(69, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CPF :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(450, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Bloco :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(444, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Apartamento :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(450, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Telefone"
        '
        'txtNascimento
        '
        Me.txtNascimento.Enabled = False
        Me.txtNascimento.Location = New System.Drawing.Point(223, 122)
        Me.txtNascimento.Name = "txtNascimento"
        Me.txtNascimento.Size = New System.Drawing.Size(112, 20)
        Me.txtNascimento.TabIndex = 6
        '
        'txtNome
        '
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(223, 95)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(112, 20)
        Me.txtNome.TabIndex = 7
        '
        'txtCpf
        '
        Me.txtCpf.Enabled = False
        Me.txtCpf.Location = New System.Drawing.Point(223, 152)
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(112, 20)
        Me.txtCpf.TabIndex = 8
        '
        'txtBloco
        '
        Me.txtBloco.Enabled = False
        Me.txtBloco.Location = New System.Drawing.Point(550, 95)
        Me.txtBloco.Name = "txtBloco"
        Me.txtBloco.Size = New System.Drawing.Size(112, 20)
        Me.txtBloco.TabIndex = 9
        '
        'txtAp
        '
        Me.txtAp.Enabled = False
        Me.txtAp.Location = New System.Drawing.Point(550, 124)
        Me.txtAp.Name = "txtAp"
        Me.txtAp.Size = New System.Drawing.Size(112, 20)
        Me.txtAp.TabIndex = 10
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Location = New System.Drawing.Point(550, 154)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(112, 20)
        Me.txtTel.TabIndex = 11
        '
        'btnExcluirr
        '
        Me.btnExcluirr.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluirr.BackgroundImage = CType(resources.GetObject("btnExcluirr.BackgroundImage"), System.Drawing.Image)
        Me.btnExcluirr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluirr.Enabled = False
        Me.btnExcluirr.FlatAppearance.BorderSize = 0
        Me.btnExcluirr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.btnExcluirr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnExcluirr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluirr.Location = New System.Drawing.Point(453, 483)
        Me.btnExcluirr.Name = "btnExcluirr"
        Me.btnExcluirr.Size = New System.Drawing.Size(60, 60)
        Me.btnExcluirr.TabIndex = 19
        Me.btnExcluirr.UseVisualStyleBackColor = False
        '
        'btnEditarr
        '
        Me.btnEditarr.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarr.BackgroundImage = CType(resources.GetObject("btnEditarr.BackgroundImage"), System.Drawing.Image)
        Me.btnEditarr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarr.Enabled = False
        Me.btnEditarr.FlatAppearance.BorderSize = 0
        Me.btnEditarr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.btnEditarr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnEditarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarr.Location = New System.Drawing.Point(368, 483)
        Me.btnEditarr.Name = "btnEditarr"
        Me.btnEditarr.Size = New System.Drawing.Size(60, 60)
        Me.btnEditarr.TabIndex = 18
        Me.btnEditarr.UseVisualStyleBackColor = False
        '
        'btnNovoo
        '
        Me.btnNovoo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovoo.BackgroundImage = CType(resources.GetObject("btnNovoo.BackgroundImage"), System.Drawing.Image)
        Me.btnNovoo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoo.FlatAppearance.BorderSize = 0
        Me.btnNovoo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.btnNovoo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnNovoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovoo.Location = New System.Drawing.Point(206, 483)
        Me.btnNovoo.Name = "btnNovoo"
        Me.btnNovoo.Size = New System.Drawing.Size(60, 60)
        Me.btnNovoo.TabIndex = 17
        Me.btnNovoo.UseVisualStyleBackColor = False
        '
        'btnSalvarr
        '
        Me.btnSalvarr.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvarr.BackgroundImage = CType(resources.GetObject("btnSalvarr.BackgroundImage"), System.Drawing.Image)
        Me.btnSalvarr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvarr.Enabled = False
        Me.btnSalvarr.FlatAppearance.BorderSize = 0
        Me.btnSalvarr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.btnSalvarr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnSalvarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarr.Location = New System.Drawing.Point(288, 483)
        Me.btnSalvarr.Name = "btnSalvarr"
        Me.btnSalvarr.Size = New System.Drawing.Size(60, 60)
        Me.btnSalvarr.TabIndex = 16
        Me.btnSalvarr.UseVisualStyleBackColor = False
        '
        'dgg
        '
        Me.dgg.AllowUserToAddRows = False
        Me.dgg.AllowUserToDeleteRows = False
        Me.dgg.BackgroundColor = System.Drawing.Color.White
        Me.dgg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgg.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgg.Location = New System.Drawing.Point(25, 279)
        Me.dgg.Name = "dgg"
        Me.dgg.ReadOnly = True
        Me.dgg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgg.Size = New System.Drawing.Size(696, 150)
        Me.dgg.TabIndex = 20
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(223, 69)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(43, 20)
        Me.txtCod.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(69, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 18)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Morador selecionado:"
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(580, 67)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(82, 20)
        Me.txtBusca.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label8.Location = New System.Drawing.Point(450, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 18)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Buscar morador :"
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = True
        Me.lblRegistros.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistros.ForeColor = System.Drawing.Color.White
        Me.lblRegistros.Location = New System.Drawing.Point(677, 442)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(10, 13)
        Me.lblRegistros.TabIndex = 26
        Me.lblRegistros.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(617, 442)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Registros:"
        '
        'Cadastro_moradores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(754, 555)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBusca)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.dgg)
        Me.Controls.Add(Me.btnExcluirr)
        Me.Controls.Add(Me.btnEditarr)
        Me.Controls.Add(Me.btnNovoo)
        Me.Controls.Add(Me.btnSalvarr)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtAp)
        Me.Controls.Add(Me.txtBloco)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtNascimento)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cadastro_moradores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de moradores"
        CType(Me.dgg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNascimento As TextBox
    Friend WithEvents txtNome As TextBox
    Friend WithEvents txtCpf As TextBox
    Friend WithEvents txtBloco As TextBox
    Friend WithEvents txtAp As TextBox
    Friend WithEvents txtTel As TextBox
    Friend WithEvents btnExcluirr As Button
    Friend WithEvents btnEditarr As Button
    Friend WithEvents btnNovoo As Button
    Friend WithEvents btnSalvarr As Button
    Friend WithEvents dgg As DataGridView
    Friend WithEvents txtCod As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBusca As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lblRegistros As Label
    Friend WithEvents Label9 As Label
End Class
