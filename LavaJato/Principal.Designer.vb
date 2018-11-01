<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCliente
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSalvarCli = New System.Windows.Forms.Button()
        Me.btnDeletar = New System.Windows.Forms.Button()
        Me.tbxTelefoneCli = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbxNumeroCli = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxEnderecoCli = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbxIdentidadeCli = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxNomeCli = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxSobrenomeCli = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIENTEBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAVAJATODataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAVAJATODataSet = New LavaJato.LAVAJATODataSet()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CLIENTETableAdapter = New LavaJato.LAVAJATODataSetTableAdapters.CLIENTETableAdapter()
        Me.CLIENTEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAVAJATODataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAVAJATODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalvarCli
        '
        Me.btnSalvarCli.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSalvarCli.BackColor = System.Drawing.SystemColors.Info
        Me.btnSalvarCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvarCli.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalvarCli.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnSalvarCli.Location = New System.Drawing.Point(837, 51)
        Me.btnSalvarCli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSalvarCli.Name = "btnSalvarCli"
        Me.btnSalvarCli.Size = New System.Drawing.Size(85, 35)
        Me.btnSalvarCli.TabIndex = 9
        Me.btnSalvarCli.Text = "Cadastrar"
        Me.btnSalvarCli.UseVisualStyleBackColor = False
        '
        'btnDeletar
        '
        Me.btnDeletar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDeletar.BackColor = System.Drawing.SystemColors.Info
        Me.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnDeletar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnDeletar.Location = New System.Drawing.Point(837, 6)
        Me.btnDeletar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeletar.Name = "btnDeletar"
        Me.btnDeletar.Size = New System.Drawing.Size(85, 35)
        Me.btnDeletar.TabIndex = 11
        Me.btnDeletar.Text = "Excluir"
        Me.btnDeletar.UseVisualStyleBackColor = False
        '
        'tbxTelefoneCli
        '
        Me.tbxTelefoneCli.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbxTelefoneCli.BackColor = System.Drawing.SystemColors.Info
        Me.tbxTelefoneCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxTelefoneCli.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxTelefoneCli.Location = New System.Drawing.Point(697, 59)
        Me.tbxTelefoneCli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxTelefoneCli.Name = "tbxTelefoneCli"
        Me.tbxTelefoneCli.Size = New System.Drawing.Size(108, 27)
        Me.tbxTelefoneCli.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label7.Location = New System.Drawing.Point(621, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Telefone"
        '
        'tbxNumeroCli
        '
        Me.tbxNumeroCli.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbxNumeroCli.BackColor = System.Drawing.SystemColors.Info
        Me.tbxNumeroCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxNumeroCli.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNumeroCli.Location = New System.Drawing.Point(398, 59)
        Me.tbxNumeroCli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxNumeroCli.Name = "tbxNumeroCli"
        Me.tbxNumeroCli.Size = New System.Drawing.Size(89, 27)
        Me.tbxNumeroCli.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label3.Location = New System.Drawing.Point(364, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nº"
        '
        'tbxEnderecoCli
        '
        Me.tbxEnderecoCli.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbxEnderecoCli.BackColor = System.Drawing.SystemColors.Info
        Me.tbxEnderecoCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxEnderecoCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxEnderecoCli.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxEnderecoCli.Location = New System.Drawing.Point(81, 45)
        Me.tbxEnderecoCli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxEnderecoCli.Multiline = True
        Me.tbxEnderecoCli.Name = "tbxEnderecoCli"
        Me.tbxEnderecoCli.Size = New System.Drawing.Size(166, 41)
        Me.tbxEnderecoCli.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label6.Location = New System.Drawing.Point(10, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 38)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Endereço"
        '
        'tbxIdentidadeCli
        '
        Me.tbxIdentidadeCli.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbxIdentidadeCli.BackColor = System.Drawing.SystemColors.Info
        Me.tbxIdentidadeCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxIdentidadeCli.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxIdentidadeCli.Location = New System.Drawing.Point(697, 14)
        Me.tbxIdentidadeCli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxIdentidadeCli.Name = "tbxIdentidadeCli"
        Me.tbxIdentidadeCli.Size = New System.Drawing.Size(108, 27)
        Me.tbxIdentidadeCli.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label2.Location = New System.Drawing.Point(607, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Identidade"
        '
        'tbxNomeCli
        '
        Me.tbxNomeCli.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbxNomeCli.BackColor = System.Drawing.SystemColors.Info
        Me.tbxNomeCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxNomeCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxNomeCli.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxNomeCli.Location = New System.Drawing.Point(81, 14)
        Me.tbxNomeCli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxNomeCli.Name = "tbxNomeCli"
        Me.tbxNomeCli.Size = New System.Drawing.Size(166, 27)
        Me.tbxNomeCli.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label5.Location = New System.Drawing.Point(302, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sobrenome"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'tbxSobrenomeCli
        '
        Me.tbxSobrenomeCli.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbxSobrenomeCli.BackColor = System.Drawing.SystemColors.Info
        Me.tbxSobrenomeCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxSobrenomeCli.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbxSobrenomeCli.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxSobrenomeCli.Location = New System.Drawing.Point(398, 14)
        Me.tbxSobrenomeCli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxSobrenomeCli.Name = "tbxSobrenomeCli"
        Me.tbxSobrenomeCli.Size = New System.Drawing.Size(194, 27)
        Me.tbxSobrenomeCli.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 7
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.17409!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.82591!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbxSobrenomeCli, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSalvarCli, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxNomeCli, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxIdentidadeCli, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxEnderecoCli, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxNumeroCli, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxTelefoneCli, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnDeletar, 6, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 14)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.01961!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.98039!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(945, 88)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.DataGridView1.DataSource = Me.CLIENTEBindingSource2
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DataGridView1.Location = New System.Drawing.Point(11, 122)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(945, 390)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 3
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "sobrenome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Sobrenome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "docIdentidade"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Identidade"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "endereco"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Endereco"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "numero"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Número"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "telefone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Contato"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "dataCadastro"
        Me.DataGridViewTextBoxColumn7.HeaderText = "dataCadastro"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'CLIENTEBindingSource2
        '
        Me.CLIENTEBindingSource2.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource2.DataSource = Me.LAVAJATODataSetBindingSource
        '
        'LAVAJATODataSetBindingSource
        '
        Me.LAVAJATODataSetBindingSource.DataSource = Me.LAVAJATODataSet
        Me.LAVAJATODataSetBindingSource.Position = 0
        '
        'LAVAJATODataSet
        '
        Me.LAVAJATODataSet.DataSetName = "LAVAJATODataSet"
        Me.LAVAJATODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.LAVAJATODataSet
        '
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'CLIENTEBindingSource1
        '
        Me.CLIENTEBindingSource1.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource1.DataSource = Me.LAVAJATODataSetBindingSource
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 574)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Tahoma", 7.5!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmCliente"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Lava Jato"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAVAJATODataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAVAJATODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SobrenomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DocIdentidadeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnderecoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataCadastroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnSalvarCli As Button
    Friend WithEvents btnDeletar As Button
    Friend WithEvents tbxTelefoneCli As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbxNumeroCli As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxEnderecoCli As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbxIdentidadeCli As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxNomeCli As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbxSobrenomeCli As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SERVICOTableAdapter As LAVAJATODataSetTableAdapters.SERVICOTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LAVAJATODataSet As LAVAJATODataSet
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents CLIENTETableAdapter As LAVAJATODataSetTableAdapters.CLIENTETableAdapter
    Friend WithEvents CLIENTEBindingSource1 As BindingSource
    Friend WithEvents LAVAJATODataSetBindingSource As BindingSource
    Friend WithEvents CLIENTEBindingSource2 As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
