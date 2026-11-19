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

        public DataTable Consultar()
        {
            try
            {
                // Abre conexão com o banco
                Banco.AbrirConexao();

                // Alimenta o método Command com a instrução desejada e indica a conexão utilizada
                Banco.Comando = new MySqlCommand(
                    "SELECT * FROM Categorias WHERE categoria LIKE @categoria ORDER BY categoria",
                    Banco.Conexao);

                // Cria os parâmetros utilizados na instrução SQL com seu respectivo conteúdo
                Banco.Comando.Parameters.AddWithValue("@categoria", (categoria ?? string.Empty) + "%");

                Banco.Adaptador = new MySqlDataAdapter(Banco.Comando);
                Banco.datTabela = new DataTable();
                Banco.Adaptador.Fill(Banco.datTabela);

                // Fecha a conexão
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