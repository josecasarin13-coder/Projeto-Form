using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using __261057___16428_Projeto;

namespace _261057___16428_Projeto.Models
{
    internal class Marca
    {
        public int id { get; set; }
        public string marca { get; set; }

        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand(
                    "INSERT INTO Marcas (marca) VALUES (@marca)",
                    Banco.Conexao);
                Banco.Comando.Parameters.AddWithValue("@marca", marca);
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
                    "SELECT * FROM Marcas WHERE marca LIKE @marca ORDER BY marca",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@marca", (marca ?? string.Empty) + "%");

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