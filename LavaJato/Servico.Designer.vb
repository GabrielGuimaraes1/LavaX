<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmServico
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.btnSalvarCli = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxPrecoServ = New System.Windows.Forms.TextBox()
        Me.tbxServico = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SERVICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAVAJATODataSet = New LavaJato.LAVAJATODataSet()
        Me.SERVICOTableAdapter = New LavaJato.LAVAJATODataSetTableAdapters.SERVICOTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataUltimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERVICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAVAJATODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnDeletar, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSalvarCli, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxPrecoServ, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxServico, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 11)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.01961!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.98039!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(378, 88)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'btnDeletar
        '
        Me.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDeletar.BackColor = System.Drawing.SystemColors.Info
        Me.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDeletar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnDeletar.Location = New System.Drawing.Point(262, 6)
        Me.btnDeletar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(85, 35)
        Me.btnDeletar.TabIndex = 11
        Me.btnDeletar.Text = "Excluir"
        Me.btnDeletar.UseVisualStyleBackColor = False
        '
        'btnSalvarCli
        '
        Me.btnSalvarCli.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSalvarCli.BackColor = System.Drawing.SystemColors.Info
        Me.btnSalvarCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvarCli.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalvarCli.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnSalvarCli.Location = New System.Drawing.Point(262, 51)
        Me.btnSalvarCli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalvarCli.Name = "btnSalvarCli"
        Me.btnSalvarCli.Size = New System.Drawing.Size(85, 35)
        Me.btnSalvarCli.TabIndex = 9
        Me.btnSalvarCli.Text = "Cadastrar"
        Me.btnSalvarCli.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label4.Location = New System.Drawing.Point(7, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Serviço"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label8.Location = New System.Drawing.Point(19, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Preço"
        '
        'tbxPrecoServ
        '
        Me.tbxPrecoServ.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbxPrecoServ.BackColor = System.Drawing.SystemColors.Info
        Me.tbxPrecoServ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxPrecoServ.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPrecoServ.Location = New System.Drawing.Point(73, 59)
        Me.tbxPrecoServ.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxPrecoServ.Name = "tbxPrecoServ"
        Me.tbxPrecoServ.Size = New System.Drawing.Size(108, 27)
        Me.tbxPrecoServ.TabIndex = 8
        '
        'tbxServico
        '
        Me.tbxServico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbxServico.BackColor = System.Drawing.SystemColors.Info
        Me.tbxServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxServico.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxServico.Location = New System.Drawing.Point(73, 14)
        Me.tbxServico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxServico.Name = "tbxServico"
        Me.tbxServico.Size = New System.Drawing.Size(108, 27)
        Me.tbxServico.TabIndex = 4
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.PrecoDataGridViewTextBoxColumn, Me.DataUltimoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SERVICOBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 117)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(347, 150)
        Me.DataGridView1.TabIndex = 4
        '
        'SERVICOBindingSource
        '
        Me.SERVICOBindingSource.DataMember = "SERVICO"
        Me.SERVICOBindingSource.DataSource = Me.LAVAJATODataSet
        '
        'LAVAJATODataSet
        '
        Me.LAVAJATODataSet.DataSetName = "LAVAJATODataSet"
        Me.LAVAJATODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SERVICOTableAdapter
        '
        Me.SERVICOTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Serviço"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.Width = 101
        '
        'PrecoDataGridViewTextBoxColumn
        '
        Me.PrecoDataGridViewTextBoxColumn.DataPropertyName = "preco"
        Me.PrecoDataGridViewTextBoxColumn.HeaderText = "Preço"
        Me.PrecoDataGridViewTextBoxColumn.Name = "PrecoDataGridViewTextBoxColumn"
        Me.PrecoDataGridViewTextBoxColumn.Width = 102
        '
        'DataUltimoDataGridViewTextBoxColumn
        '
        Me.DataUltimoDataGridViewTextBoxColumn.DataPropertyName = "dataUltimo"
        Me.DataUltimoDataGridViewTextBoxColumn.HeaderText = "Data Último"
        Me.DataUltimoDataGridViewTextBoxColumn.Name = "DataUltimoDataGridViewTextBoxColumn"
        Me.DataUltimoDataGridViewTextBoxColumn.Width = 101
        '
        'FrmServico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1111, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FrmServico"
        Me.Text = "Servico"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERVICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAVAJATODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnSalvarCli As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxPrecoServ As TextBox
    Friend WithEvents btnDeletar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents tbxServico As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LAVAJATODataSet As LAVAJATODataSet
    Friend WithEvents SERVICOBindingSource As BindingSource
    Friend WithEvents SERVICOTableAdapter As LAVAJATODataSetTableAdapters.SERVICOTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataUltimoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
