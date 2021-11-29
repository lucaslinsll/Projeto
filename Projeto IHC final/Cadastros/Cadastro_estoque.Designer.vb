<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cadastro_estoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cadastro_estoque))
        Me.lblRegistros = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgg = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExcluirr = New System.Windows.Forms.Button()
        Me.btnEditarr = New System.Windows.Forms.Button()
        Me.btnNovoo = New System.Windows.Forms.Button()
        Me.btnSalvarr = New System.Windows.Forms.Button()
        Me.txtNAp = New System.Windows.Forms.TextBox()
        Me.txtCodBloco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblRegistros
        '
        Me.lblRegistros.AutoSize = True
        Me.lblRegistros.BackColor = System.Drawing.Color.Transparent
        Me.lblRegistros.Font = New System.Drawing.Font("Humanst521 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistros.ForeColor = System.Drawing.Color.Gray
        Me.lblRegistros.Location = New System.Drawing.Point(683, 589)
        Me.lblRegistros.Name = "lblRegistros"
        Me.lblRegistros.Size = New System.Drawing.Size(13, 18)
        Me.lblRegistros.TabIndex = 78
        Me.lblRegistros.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Humanst521 BT", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Gray
        Me.Label9.Location = New System.Drawing.Point(618, 589)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 18)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Registros:"
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
        Me.dgg.Location = New System.Drawing.Point(131, 436)
        Me.dgg.Name = "dgg"
        Me.dgg.ReadOnly = True
        Me.dgg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgg.Size = New System.Drawing.Size(518, 124)
        Me.dgg.TabIndex = 76
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Humanst521 BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(217, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 25)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Local selecionado:"
        '
        'txtCod
        '
        Me.txtCod.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCod.Location = New System.Drawing.Point(414, 235)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(118, 30)
        Me.txtCod.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Humanst521 BT", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(201, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 42)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "CADASTRO DE ESTOQUE"
        '
        'btnExcluirr
        '
        Me.btnExcluirr.BackColor = System.Drawing.Color.Transparent
        Me.btnExcluirr.BackgroundImage = Global.SistemaDeFerramentas.My.Resources.Resources.LIXO
        Me.btnExcluirr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExcluirr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluirr.Enabled = False
        Me.btnExcluirr.FlatAppearance.BorderSize = 0
        Me.btnExcluirr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.btnExcluirr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnExcluirr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluirr.Location = New System.Drawing.Point(541, 589)
        Me.btnExcluirr.Name = "btnExcluirr"
        Me.btnExcluirr.Size = New System.Drawing.Size(60, 60)
        Me.btnExcluirr.TabIndex = 75
        Me.btnExcluirr.UseVisualStyleBackColor = False
        '
        'btnEditarr
        '
        Me.btnEditarr.BackColor = System.Drawing.Color.Transparent
        Me.btnEditarr.BackgroundImage = Global.SistemaDeFerramentas.My.Resources.Resources.EDITAR
        Me.btnEditarr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEditarr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditarr.Enabled = False
        Me.btnEditarr.FlatAppearance.BorderSize = 0
        Me.btnEditarr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.btnEditarr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnEditarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditarr.Location = New System.Drawing.Point(432, 589)
        Me.btnEditarr.Name = "btnEditarr"
        Me.btnEditarr.Size = New System.Drawing.Size(60, 60)
        Me.btnEditarr.TabIndex = 74
        Me.btnEditarr.UseVisualStyleBackColor = False
        '
        'btnNovoo
        '
        Me.btnNovoo.BackColor = System.Drawing.Color.Transparent
        Me.btnNovoo.BackgroundImage = Global.SistemaDeFerramentas.My.Resources.Resources.ADICIONAR
        Me.btnNovoo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNovoo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovoo.FlatAppearance.BorderSize = 0
        Me.btnNovoo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.btnNovoo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnNovoo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNovoo.Location = New System.Drawing.Point(208, 589)
        Me.btnNovoo.Name = "btnNovoo"
        Me.btnNovoo.Size = New System.Drawing.Size(60, 60)
        Me.btnNovoo.TabIndex = 73
        Me.btnNovoo.UseVisualStyleBackColor = False
        '
        'btnSalvarr
        '
        Me.btnSalvarr.BackColor = System.Drawing.Color.Transparent
        Me.btnSalvarr.BackgroundImage = Global.SistemaDeFerramentas.My.Resources.Resources.SALVAR
        Me.btnSalvarr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalvarr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvarr.Enabled = False
        Me.btnSalvarr.FlatAppearance.BorderSize = 0
        Me.btnSalvarr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki
        Me.btnSalvarr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki
        Me.btnSalvarr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalvarr.Location = New System.Drawing.Point(320, 589)
        Me.btnSalvarr.Name = "btnSalvarr"
        Me.btnSalvarr.Size = New System.Drawing.Size(60, 60)
        Me.btnSalvarr.TabIndex = 72
        Me.btnSalvarr.UseVisualStyleBackColor = False
        '
        'txtNAp
        '
        Me.txtNAp.Enabled = False
        Me.txtNAp.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNAp.Location = New System.Drawing.Point(414, 310)
        Me.txtNAp.Name = "txtNAp"
        Me.txtNAp.Size = New System.Drawing.Size(187, 30)
        Me.txtNAp.TabIndex = 82
        '
        'txtCodBloco
        '
        Me.txtCodBloco.Enabled = False
        Me.txtCodBloco.Font = New System.Drawing.Font("Humanst521 BT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodBloco.Location = New System.Drawing.Point(414, 382)
        Me.txtCodBloco.Name = "txtCodBloco"
        Me.txtCodBloco.Size = New System.Drawing.Size(187, 30)
        Me.txtCodBloco.TabIndex = 81
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Humanst521 BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(167, 310)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 25)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Código do condomínio :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Humanst521 BT", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(235, 383)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 25)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Nome do local :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.SistemaDeFerramentas.My.Resources.Resources.linha
        Me.PictureBox1.Location = New System.Drawing.Point(172, -99)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(480, 270)
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'Cadastro_estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaDeFerramentas.My.Resources.Resources.Fundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 749)
        Me.Controls.Add(Me.txtNAp)
        Me.Controls.Add(Me.txtCodBloco)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblRegistros)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgg)
        Me.Controls.Add(Me.btnExcluirr)
        Me.Controls.Add(Me.btnEditarr)
        Me.Controls.Add(Me.btnNovoo)
        Me.Controls.Add(Me.btnSalvarr)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cadastro_estoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de estoque"
        CType(Me.dgg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblRegistros As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgg As DataGridView
    Friend WithEvents btnExcluirr As Button
    Friend WithEvents btnEditarr As Button
    Friend WithEvents btnNovoo As Button
    Friend WithEvents btnSalvarr As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNAp As TextBox
    Friend WithEvents txtCodBloco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
