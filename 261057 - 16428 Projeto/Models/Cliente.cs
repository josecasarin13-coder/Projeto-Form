using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using __261057___16428_Projeto;

namespace _261057___16428_Projeto.Models
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idCidade { get; set; }
        public DateTime dataNasc { get; set; }
        public double renda { get; set; }
        public string cpf { get; set; }
        public string foto { get; set; }
        public bool venda { get; set; }

        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand(
                    "SELECT cl.*, ci.nome AS cidade, ci.uf " +
                    "FROM Clientes cl " +
                    "INNER JOIN Cidades ci ON ci.id = cl.idCidade " +
                    "WHERE cl.nome LIKE @Nome " +
                    "ORDER BY cl.nome",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@Nome", (nome ?? string.Empty) + "%");

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
                    "INSERT INTO clientes (nome, idCidade, dataNasc, renda, cpf, foto, venda) " +
                    "VALUES (@nome, @idCidade, @dataNasc, @renda, @cpf, @foto, @venda)",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@nome", (object)nome ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@idCidade", idCidade);
                Banco.Comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                Banco.Comando.Parameters.AddWithValue("@renda", renda);
                Banco.Comando.Parameters.AddWithValue("@cpf", (object)cpf ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@foto", (object)foto ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@venda", venda);

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
                    "UPDATE clientes SET nome = @nome, idCidade = @idCidade, dataNasc = @dataNasc, " +
                    "renda = @renda, cpf = @cpf, foto = @foto, venda = @venda WHERE id = @id",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@nome", (object)nome ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@idCidade", idCidade);
                Banco.Comando.Parameters.AddWithValue("@dataNasc", dataNasc);
                Banco.Comando.Parameters.AddWithValue("@renda", renda);
                Banco.Comando.Parameters.AddWithValue("@cpf", (object)cpf ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@foto", (object)foto ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@venda", venda);
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
                Banco.Comando = new MySqlCommand("DELETE FROM clientes WHERE id = @id", Banco.Conexao);
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