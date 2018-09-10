Imports System.Data.SqlClient

Public Class Principal
    Dim str As New SqlConnection("Server= DESKTOP-U61K189\SQLEXPRESS; Database= LAVAJATO; Integrated Security= True")

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'LAVAJATODataSet._1_'. Você pode movê-la ou removê-la conforme necessário.
        Me._1_TableAdapter.Fill(Me.LAVAJATODataSet._1_)
        tbxNomeCli.Focus()
        Dim str As String = "Data Source= DESKTOP-U61K189\SQLEXPRESS;database=LAVAJATO; Integrated Security= True"
        Dim con As New SqlConnection(str)
        Dim com As String = "SELECT * FROM clienteXservico ORDER BY ultimaVisita DESC"
        Dim Adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "clienteXservico")
        DataGridView1.DataSource = ds.Tables("clienteXservico")
    End Sub
    Public Sub MyNonQuery(ByVal SQCommand As String)
        Dim str As New SqlConnection("Data Source= DESKTOP-U61K189\SQLEXPRESS;database=LAVAJATO; Integrated Security= True")
        Dim sqlcmd As New SqlCommand(SQCommand, str)
        Dim com As String = "SELECT * FROM clienteXservico ORDER BY ultimaVisita DESC"
        Dim Adpt As New SqlDataAdapter(com, str)
        Dim ds As New DataSet()
        str.Open()
        sqlcmd.ExecuteNonQuery()
        Adpt.Fill(ds, "clienteXservico")
        DataGridView1.DataSource = ds.Tables("clienteXservico")
        str.Close()
    End Sub
    Private Sub btnSalvarCli_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalvarCli.Click
        Dim txtTelefoneCli As Decimal = Val(tbxTelefoneCli.Text)
        Dim txtNumeroCli As Decimal = Val(tbxNumeroCli.Text)
        If (tbxNomeCli.Text.Trim.Length Or tbxSobrenomeCli.Text.Trim.Length Or tbxIdentidadeCli.Text.Trim.Length Or tbxTelefoneCli.Text.Trim.Length) = 0 Then
            MessageBox.Show("Apenas 'Endereço' e 'Número' não necessitam ser preenchidos.")
        Else
            MyNonQuery("INSERT INTO CLIENTE (nome,sobrenome,docIdentidade,endereco,numero,telefone,dataCadastro)" &
            "VALUES ('" & tbxNomeCli.Text & "','" & tbxSobrenomeCli.Text & "','" & tbxIdentidadeCli.Text & "','" & tbxEnderecoCli.Text & "','" & txtNumeroCli & "','" & txtTelefoneCli & "', GETDATE())")
            MyNonQuery("INSERT INTO SERVICO (nome,preco,dataUltimo)" &
            "VALUES ('" & tbxServico.Text & "','" & tbxPrecoServ.Text & "',GETDATE())")
            MessageBox.Show("Produto cadastrado!")
        End If
    End Sub
    Private Sub pbtnDeletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletar.Click
        If DataGridView1.SelectedRows(0).Cells(0).Value Is Nothing Then
            MessageBox.Show("Para excluir, selecione um cadastro na lista")
        Else
            Dim nome As String = DataGridView1.SelectedRows(0).Cells(0).Value
            Dim sobrenome As String = DataGridView1.SelectedRows(0).Cells(1).Value
            Dim result As Integer = MessageBox.Show("Tem certeza que deseja excluir " & nome & " " & sobrenome & "?", " ", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            ElseIf result = DialogResult.Yes Then
                MyNonQuery("DELETE FROM CLIENTE WHERE nome = '" & nome & "'AND sobrenome = '" & sobrenome & "'")
                MyNonQuery("DELETE FROM SERVICO WHERE nome = '" & nome & "'AND sobrenome = '" & sobrenome & "'")
            End If
        End If
    End Sub
    Public Sub ExecuteQuery(query As String)
        Dim command As New SqlCommand(query, str)
        str.Open()
        command.ExecuteNonQuery()
        str.Close()
    End Sub
End Class