using __261057___16428_Projeto;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _261057___16428_Projeto.Models
{
    internal class Produto
    {
        public int Id { get; set; }
        public double Valor { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }
        public string Marca { get; set; }
        public string Estoque { get; set; }


        public void Incluir()
        {
            try
            {
                Banco.AbrirConexao();
                Banco.Comando = new MySqlCommand(
                    "INSERT INTO produto (descricao, categoria, marca, estoque, valor) VALUES (@descricao, @categoria, @marca, @estoque, @valor)",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@descricao", (object)Descricao ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@categoria", (object)Categoria ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@marca", (object)Marca ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@estoque", (object)Estoque ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@valor", Valor);

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
                    "UPDATE produto SET descricao = @descricao, categoria = @categoria, marca = @marca, estoque = @estoque, valor = @valor WHERE id = @id",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@descricao", (object)Descricao ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@categoria", (object)Categoria ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@marca", (object)Marca ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@estoque", (object)Estoque ?? DBNull.Value);
                Banco.Comando.Parameters.AddWithValue("@valor", Valor);
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
                Banco.Comando = new MySqlCommand("DELETE FROM produto WHERE id = @id", Banco.Conexao);
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
                    "SELECT * FROM produto  WHERE descricao LIKE @descricao ORDER BY descricao",
                    Banco.Conexao);

                Banco.Comando.Parameters.AddWithValue("@descricao", (Descricao ?? string.Empty) + "%");

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
