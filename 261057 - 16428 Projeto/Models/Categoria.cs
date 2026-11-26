using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using __261057___16428_Projeto;

namespace _261057___16428_Projeto.Models
{
    internal class Categoria
    {
        public int id { get; set; }
        public string categoria { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand(
                    "INSERT INTO Categorias (categoria) VALUES (@categoria)",
                    Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@categoria", categoria);
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
                    "SELECT * FROM Categorias WHERE categoria LIKE @categoria ORDER BY categoria",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@categoria", (categoria ?? string.Empty) + "%");

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