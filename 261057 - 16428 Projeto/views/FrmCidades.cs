using System;
using System.Data;
using System.Windows.Forms;
using _261057___16428_Projeto.Models;

namespace _261057___16428_Projeto
{
    public partial class FrmCidades : Form
    {
        Cidade ci;

        public FrmCidades()
        {
            InitializeComponent();
            btnIncluir.Click += btnIncluir_Click;
            btnAlterar.Click += btnAlterar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnExcluir.Click += btnExcluir_Click;
            btnFechar.Click += btnFechar_Click;
            txtPesquisa.TextChanged += txtPesquisa_TextChanged;
            dgvCidades.CellClick += dgvCidades_CellClick;
        }

        private void limparControles()
        {
            txtID.Clear();
            txtNome.Clear();
            txtUF.Clear();
            txtPesquisa.Clear();
            txtNome.Focus();
        }

        private void carregarGrid(string pesquisa)
        {
            ci = new Cidade();
            ci.Nome = pesquisa;
            dgvCidades.DataSource = ci.Consultar();
        }

        private void FrmCidades_Load(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome da cidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            ci = new Cidade
            {
                Nome = txtNome.Text.Trim(),
                Uf = txtUF.Text.Trim().ToUpper()
            };

            ci.Incluir();
            limparControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Selecione uma cidade na grade para alterar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ci = new Cidade
            {
                Id = int.Parse(txtID.Text),
                Nome = txtNome.Text.Trim(),
                Uf = txtUF.Text.Trim().ToUpper()
            };

            ci.Alterar();
            limparControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Selecione uma cidade na grade para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir esta cidade?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ci = new Cidade { Id = int.Parse(txtID.Text) };
                ci.Excluir();
                limparControles();
                carregarGrid("");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text.Trim());
        }

        private void dgvCidades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCidades.CurrentRow != null)
            {
                DataGridViewRow linha = dgvCidades.CurrentRow;
                txtID.Text = linha.Cells["id"].Value?.ToString() ?? string.Empty;
                txtNome.Text = linha.Cells["nome"].Value?.ToString() ?? string.Empty;
                txtUF.Text = linha.Cells["uf"].Value?.ToString() ?? string.Empty;
            }
        }
    }
}