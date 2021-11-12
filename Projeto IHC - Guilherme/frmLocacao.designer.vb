<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLocacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLocacao))
        Me.btnAlocar = New System.Windows.Forms.Button()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDisp = New System.Windows.Forms.TextBox()
        Me.txtLocador = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtDono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDias = New System.Windows.Forms.TextBox()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAlocar
        '
        Me.btnAlocar.BackColor = System.Drawing.Color.Transparent
        Me.btnAlocar.BackgroundImage = CType(resources.GetObject("btnAlocar.BackgroundImage"), System.Drawing.Image)
        Me.btnAlocar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAlocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlocar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAlocar.Location = New System.Drawing.Point(335, 445)
        Me.btnAlocar.Name = "btnAlocar"
        Me.btnAlocar.Size = New System.Drawing.Size(55, 53)
        Me.btnAlocar.TabIndex = 0
        Me.btnAlocar.UseVisualStyleBackColor = False
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AllowUserToDeleteRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.Bisque
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(12, 231)
        Me.dg.Name = "dg"
        Me.dg.ReadOnly = True
        Me.dg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg.Size = New System.Drawing.Size(718, 208)
        Me.dg.TabIndex = 1
        '
        'cbCategoria
        '
        Me.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(165, 98)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cbCategoria.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(165, 60)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(41, 20)
        Me.txtCodigo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(103, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(115, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Código:"
        '
        'txtDisp
        '
        Me.txtDisp.Enabled = False
        Me.txtDisp.Location = New System.Drawing.Point(422, 12)
        Me.txtDisp.Name = "txtDisp"
        Me.txtDisp.Size = New System.Drawing.Size(101, 20)
        Me.txtDisp.TabIndex = 8
        Me.txtDisp.Visible = False
        '
        'txtLocador
        '
        Me.txtLocador.Location = New System.Drawing.Point(474, 99)
        Me.txtLocador.Name = "txtLocador"
        Me.txtLocador.Size = New System.Drawing.Size(57, 20)
        Me.txtLocador.TabIndex = 9
        '
        'txtValor
        '
        Me.txtValor.Enabled = False
        Me.txtValor.Location = New System.Drawing.Point(165, 175)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(54, 20)
        Me.txtValor.TabIndex = 10
        '
        'txtDono
        '
        Me.txtDono.Enabled = False
        Me.txtDono.Location = New System.Drawing.Point(579, 12)
        Me.txtDono.Name = "txtDono"
        Me.txtDono.Size = New System.Drawing.Size(100, 20)
        Me.txtDono.TabIndex = 11
        Me.txtDono.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Dias:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(405, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "ID Morador:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Valor:"
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(165, 137)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(79, 20)
        Me.txtDias.TabIndex = 16
        '
        'frmLocacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(742, 550)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDono)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.txtLocador)
        Me.Controls.Add(Me.txtDisp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.cbCategoria)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.btnAlocar)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmLocacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locação de Ferramentas"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAlocar As Button
    Friend WithEvents dg As DataGridView
    Friend WithEvents cbCategoria As ComboBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDisp As TextBox
    Friend WithEvents txtLocador As TextBox
    Friend WithEvents txtValor As TextBox
    Friend WithEvents txtDono As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDias As TextBox
End Class
