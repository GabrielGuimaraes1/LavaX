<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbxPrecoServ = New System.Windows.Forms.TextBox()
        Me.tbxServico = New System.Windows.Forms.TextBox()
        Me.CLIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAVAJATODataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LAVAJATODataSet = New LavaJato.LAVAJATODataSet()
        Me.CLIENTETableAdapter = New LavaJato.LAVAJATODataSetTableAdapters.CLIENTETableAdapter()
        Me.ClienteXservicoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New LavaJato.LAVAJATODataSetTableAdapters.TableAdapterManager()
        Me.SERVICOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SERVICOTableAdapter = New LavaJato.LAVAJATODataSetTableAdapters.SERVICOTableAdapter()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._1_TableAdapter = New LavaJato.LAVAJATODataSetTableAdapters._1_TableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAVAJATODataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LAVAJATODataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteXservicoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SERVICOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalvarCli
        '
        Me.btnSalvarCli.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSalvarCli.BackColor = System.Drawing.SystemColors.Info
        Me.btnSalvarCli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvarCli.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSalvarCli.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.btnSalvarCli.Location = New System.Drawing.Point(999, 51)
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
        Me.btnDeletar.Location = New System.Drawing.Point(999, 6)
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
        Me.tbxTelefoneCli.Location = New System.Drawing.Point(650, 59)
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
        Me.Label7.Location = New System.Drawing.Point(574, 69)
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
        Me.tbxNumeroCli.Location = New System.Drawing.Point(359, 59)
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
        Me.Label3.Location = New System.Drawing.Point(325, 69)
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
        Me.tbxEnderecoCli.Location = New System.Drawing.Point(84, 45)
        Me.tbxEnderecoCli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxEnderecoCli.Multiline = True
        Me.tbxEnderecoCli.Name = "tbxEnderecoCli"
        Me.tbxEnderecoCli.Size = New System.Drawing.Size(158, 41)
        Me.tbxEnderecoCli.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label6.Location = New System.Drawing.Point(4, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Endereço"
        '
        'tbxIdentidadeCli
        '
        Me.tbxIdentidadeCli.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbxIdentidadeCli.BackColor = System.Drawing.SystemColors.Info
        Me.tbxIdentidadeCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbxIdentidadeCli.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxIdentidadeCli.Location = New System.Drawing.Point(650, 14)
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
        Me.Label2.Location = New System.Drawing.Point(560, 24)
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
        Me.tbxNomeCli.Location = New System.Drawing.Point(84, 14)
        Me.tbxNomeCli.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxNomeCli.Name = "tbxNomeCli"
        Me.tbxNomeCli.Size = New System.Drawing.Size(158, 27)
        Me.tbxNomeCli.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label5.Location = New System.Drawing.Point(263, 24)
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
        Me.Label1.Location = New System.Drawing.Point(27, 24)
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
        Me.tbxSobrenomeCli.Location = New System.Drawing.Point(359, 14)
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
        Me.TableLayoutPanel1.ColumnCount = 9
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.17409!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.82591!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbxSobrenomeCli, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
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
        Me.TableLayoutPanel1.Controls.Add(Me.btnDeletar, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnSalvarCli, 8, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 6, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxPrecoServ, 7, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxServico, 7, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 14)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.01961!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.98039!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1088, 88)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.MenuBar
        Me.Label4.Location = New System.Drawing.Point(771, 24)
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
        Me.Label8.Location = New System.Drawing.Point(783, 69)
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
        Me.tbxPrecoServ.Location = New System.Drawing.Point(837, 59)
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
        Me.tbxServico.Location = New System.Drawing.Point(837, 14)
        Me.tbxServico.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tbxServico.Name = "tbxServico"
        Me.tbxServico.Size = New System.Drawing.Size(108, 27)
        Me.tbxServico.TabIndex = 4
        '
        'CLIENTEBindingSource
        '
        Me.CLIENTEBindingSource.DataMember = "CLIENTE"
        Me.CLIENTEBindingSource.DataSource = Me.LAVAJATODataSetBindingSource
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
        'CLIENTETableAdapter
        '
        Me.CLIENTETableAdapter.ClearBeforeFill = True
        '
        'ClienteXservicoBindingSource
        '
        Me.ClienteXservicoBindingSource.DataSource = Me.LAVAJATODataSet
        Me.ClienteXservicoBindingSource.Position = 0
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.SERVICOTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = LavaJato.LAVAJATODataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SERVICOBindingSource
        '
        Me.SERVICOBindingSource.DataMember = "SERVICO"
        Me.SERVICOBindingSource.DataSource = Me.LAVAJATODataSet
        '
        'SERVICOTableAdapter
        '
        Me.SERVICOTableAdapter.ClearBeforeFill = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "1,"
        Me.BindingSource1.DataSource = Me.LAVAJATODataSetBindingSource
        '
        '_1_TableAdapter
        '
        Me._1_TableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 107)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(945, 455)
        Me.DataGridView1.TabIndex = 3
        '
        'Principal
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
        Me.Name = "Principal"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Lava Jato"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.CLIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAVAJATODataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LAVAJATODataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteXservicoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SERVICOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LAVAJATODataSetBindingSource As BindingSource
    Friend WithEvents LAVAJATODataSet As LAVAJATODataSet
    Friend WithEvents CLIENTETableAdapter As LAVAJATODataSetTableAdapters.CLIENTETableAdapter
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
    Friend WithEvents CLIENTEBindingSource As BindingSource
    Friend WithEvents ClienteXservicoBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As LAVAJATODataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbxPrecoServ As TextBox
    Friend WithEvents tbxServico As TextBox
    Friend WithEvents SERVICOBindingSource As BindingSource
    Friend WithEvents SERVICOTableAdapter As LAVAJATODataSetTableAdapters.SERVICOTableAdapter
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents _1_TableAdapter As LAVAJATODataSetTableAdapters._1_TableAdapter
    Friend WithEvents DataGridView1 As DataGridView
End Class
