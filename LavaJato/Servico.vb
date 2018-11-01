Imports System.Data.SqlClient

Public Class FrmServico
    Dim str As New SqlConnection("Server= DESKTOP-U61K189\SQLEXPRESS; Database= LAVAJATO; Integrated Security= True")

    Private Sub Servico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'LAVAJATODataSet.SERVICO'. Você pode movê-la ou removê-la conforme necessário.
        Me.SERVICOTableAdapter.Fill(Me.LAVAJATODataSet.SERVICO)
        tbxServico.Focus()
        Dim str As String = "Data Source= DESKTOP-U61K189\SQLEXPRESS;database=LAVAJATO; Integrated Security= True"
        Dim con As New SqlConnection(str)
        Dim com As String = "SELECT * FROM SERVICO ORDER BY dataUltimo DESC"
        Dim Adpt As New SqlDataAdapter(com, con)
        Dim ds As New DataSet()
        Adpt.Fill(ds, "SERVICO")
        DataGridView1.DataSource = ds.Tables("SERVICO")
    End Sub

    Public Sub MyNonQuery(ByVal SQCommand As String)
        Dim str As New SqlConnection("Data Source= DESKTOP-U61K189\SQLEXPRESS;database=LAVAJATO; Integrated Security= True")
        Dim sqlcmd As New SqlCommand(SQCommand, str)
        Dim com As String = "SELECT * FROM SERVICO ORDER BY dataUltimo DESC"
        Dim Adpt As New SqlDataAdapter(com, str)
        Dim ds As New DataSet()
        str.Open()
        sqlcmd.ExecuteNonQuery()
        Adpt.Fill(ds, "SERVICO")
        DataGridView1.DataSource = ds.Tables("SERVICO")
        str.Close()
    End Sub
    Private Sub btnSalvarCli_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSalvarCli.Click
        Dim txtServico As Decimal = Val(tbxServico.Text)
        Dim txtPreco As Decimal = Val(tbxPrecoServ.Text)
        If (tbxServico.Text.Trim.Length Or tbxPrecoServ.Text.Trim.Length) = 0 Then
            MessageBox.Show("Todos os campos devem ser preenchidos.")
        Else
            MyNonQuery("INSERT INTO SERVICO (nome,sobrenome,docIdentidade,endereco,numero,telefone,dataCadastro)" &
            "VALUES ('" & tbxServico.Text & "','" & tbxPrecoServ.Text & "', GETDATE())")
            MessageBox.Show("Produto cadastrado!")
        End If
    End Sub
    Private Sub pbtnDeletar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeletar.Click
        'If DataGridView1.SelectedRows(0).Cells(0).Value Is Nothing Then --> outra opçao de achar os valores das células da linha selecionada
        If IsDBNull(DataGridView1.SelectedRows(0).Cells(0).Value) Then
            MessageBox.Show("Para excluir, selecione um cadastro na lista")
        Else
            Dim servico As String = DataGridView1.SelectedRows(0).Cells(1).Value
            Dim preco As String = DataGridView1.SelectedRows(0).Cells(2).Value
            Dim result As Integer = MessageBox.Show("Tem certeza que deseja excluir " & servico & " " & preco & "?", " ", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
            ElseIf result = DialogResult.Yes Then
                MyNonQuery("DELETE FROM SERVICO WHERE nome = '" & servico & "'")
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