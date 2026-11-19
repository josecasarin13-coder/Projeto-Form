using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using __261057___16428_Projeto;

namespace _261057___16428_Projeto.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand(
                    "INSERT INTO cidades (nome, uf) VALUES (@nome, @uf)",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@nome", (object)Nome ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@uf", (object)Uf ?? DBNull.Value);

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
                    "UPDATE cidades SET nome = @nome, uf = @uf WHERE id = @id",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@nome", (object)Nome ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@uf", (object)Uf ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@id", Id);

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
                Banco.Comando = new MySqlCommand("DELETE FROM cidades WHERE id = @id", Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@id", Id);

                Banco.Comando.ExecuteNonQuery();
                Banco.FecharConexao();
            }
            catch (Exception e)
            {
                Banco.FecharConexao();
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable Consultar()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand(
                    "SELECT * FROM Cidades WHERE nome LIKE @Nome ORDER BY nome",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@Nome", (Nome ?? string.Empty) + "%");

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
    }
}