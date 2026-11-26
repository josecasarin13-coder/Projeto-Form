using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using __261057___16428_Projeto;

namespace _261057___16428_Projeto.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int idCategoria { get; set; }
        public int idMarca { get; set; }
        public double estoque { get; set; }
        public double valorVenda { get; set; }
        public string foto { get; set; }

        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand(
                    "SELECT p.*, c.categoria, m.marca " +
                    "FROM Produtos p " +
                    "INNER JOIN Categorias c ON c.id = p.idCategoria " +
                    "INNER JOIN Marcas m ON m.id = p.idMarca " +
                    "WHERE p.descricao LIKE @descricao " +
                    "ORDER BY p.descricao",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@descricao", (descricao ?? string.Empty) + "%");

                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);

                Banco.FecharConexao();
                return Banco.datTabela;
            }
            catch (Exception e)
            {
                Banco.FecharConexao();
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand(
                    "INSERT INTO Produtos (descricao, idCategoria, idMarca, estoque, valorVenda, foto) " +
                    "VALUES (@descricao, @idCategoria, @idMarca, @estoque, @valorVenda, @foto)",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@descricao", (object)descricao ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@foto", (object)foto ?? DBNull.Value);

                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                Banco.FecharConexao();
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Alterar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand(
                    "UPDATE Produtos SET descricao = @descricao, idCategoria = @idCategoria, idMarca = @idMarca, " +
                    "estoque = @estoque, valorVenda = @valorVenda, foto = @foto WHERE Id = @id",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@descricao", (object)descricao ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                Banco.Comando.Parameters.AddWithValue("@idMarca", idMarca);
                Banco.Comando.Parameters.AddWithValue("@estoque", estoque);
                Banco.Comando.Parameters.AddWithValue("@valorVenda", valorVenda);
                Banco.Comando.Parameters.AddWithValue("@foto", (object)foto ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@id", id);

                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                Banco.FecharConexao();
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Excluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand("DELETE FROM Produtos WHERE Id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", id);

                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                Banco.FecharConexao();
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}