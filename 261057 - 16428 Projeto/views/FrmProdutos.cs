using System;
using System.Data;
using System.Windows.Forms;
using _261057___16428_Projeto.Models;

namespace _261057___16428_Projeto
{
    public partial class FrmProdutos : Form
    {
        Categoria ca;
        Marca ma;
        Produto pr;

        public FrmProdutos()
        {
            InitializeComponent();
            this.Load += FrmProdutos_Load;
            btnIncluir.Click += btnIncluir_Click;
            btnAlterar.Click += btnAlterar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnExcluir.Click += btnExcluir_Click;
            btnFechar.Click += btnFechar_Click;
            btnConsultar.Click += btnConsultar_Click;
            dgvClientes.CellClick += dgvClientes_CellClick;
            ptbImagem.Click += ptbImagem_Click;
        }

        private void carregarCombos()
        {
            ca = new Categoria();
            cboCategoria.DataSource = ca.Consultar();
            cboCategoria.DisplayMember = "categoria";
            cboCategoria.ValueMember = "id";

            ma = new Marca();
            cboMarca.DataSource = ma.Consultar();
            cboMarca.DisplayMember = "marca";
            cboMarca.ValueMember = "id";
        }

        private void limparControles()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            cboCategoria.SelectedIndex = -1;
            cboCategoria.Text = "";
            cboMarca.SelectedIndex = -1;
            cboMarca.Text = "";
            txtEstoque.Clear();
            txtValor.Clear();
            ptbImagem.ImageLocation = "";
            txtPesquisa.Clear();
            txtDescricao.Focus();
        }

        private void carregarGrid(string pesquisa)
        {
            pr = new Produto();
            pr.descricao = pesquisa;
            dgvClientes.DataSource = pr.Consultar();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            carregarCombos();
            limparControles();
            carregarGrid("");

            if (dgvClientes.Columns["idCategoria"] != null)
                dgvClientes.Columns["idCategoria"].Visible = false;
            if (dgvClientes.Columns["idMarca"] != null)
                dgvClientes.Columns["idMarca"].Visible = false;
            if (dgvClientes.Columns["foto"] != null)
                dgvClientes.Columns["foto"].Visible = false;
        }

        private void garantirCategoriaEMarca()
        {
            if (cboCategoria.SelectedIndex == -1)
            {
                string novaCategoria = cboCategoria.Text.Trim();
                ca = new Categoria { categoria = novaCategoria };
                ca.Incluir();
                cboCategoria.DataSource = ca.Consultar();
                cboCategoria.DisplayMember = "categoria";
                cboCategoria.ValueMember = "id";
                cboCategoria.Text = novaCategoria;
            }

            if (cboMarca.SelectedIndex == -1)
            {
                string novaMarca = cboMarca.Text.Trim();
                ma = new Marca { marca = novaMarca };
                ma.Incluir();
                cboMarca.DataSource = ma.Consultar();
                cboMarca.DisplayMember = "marca";
                cboMarca.ValueMember = "id";
                cboMarca.Text = novaMarca;
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cboCategoria.Text) || string.IsNullOrWhiteSpace(cboMarca.Text))
            {
                MessageBox.Show("Informe ou selecione a categoria e a marca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            garantirCategoriaEMarca();

            pr = new Produto
            {
                descricao = txtDescricao.Text.Trim(),
                idCategoria = (int)cboCategoria.SelectedValue,
                idMarca = (int)cboMarca.SelectedValue,
                estoque = double.TryParse(txtEstoque.Text.Trim(), out double est) ? est : 0,
                valorVenda = double.TryParse(txtValor.Text.Trim(), out double val) ? val : 0,
                foto = ptbImagem.ImageLocation
            };

            pr.Incluir();
            limparControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um produto na grade para alterar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                MessageBox.Show("Informe a descrição do produto.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cboCategoria.Text) || string.IsNullOrWhiteSpace(cboMarca.Text))
            {
                MessageBox.Show("Informe ou selecione a categoria e a marca.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            garantirCategoriaEMarca();

            pr = new Produto
            {
                id = int.Parse(txtCodigo.Text),
                descricao = txtDescricao.Text.Trim(),
                idCategoria = (int)cboCategoria.SelectedValue,
                idMarca = (int)cboMarca.SelectedValue,
                estoque = double.TryParse(txtEstoque.Text.Trim(), out double est) ? est : 0,
                valorVenda = double.TryParse(txtValor.Text.Trim(), out double val) ? val : 0,
                foto = ptbImagem.ImageLocation
            };

            pr.Alterar();
            limparControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Selecione um produto na grade para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                pr = new Produto { id = int.Parse(txtCodigo.Text) };
                pr.Excluir();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            carregarGrid(txtPesquisa.Text.Trim());
        }

        private void ptbImagem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    ptbImagem.ImageLocation = ofd.FileName;
                }
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvClientes.CurrentRow != null)
            {
                DataGridViewRow linha = dgvClientes.CurrentRow;
                txtCodigo.Text = linha.Cells["Id"].Value?.ToString() ?? string.Empty;
                txtDescricao.Text = linha.Cells["descricao"].Value?.ToString() ?? string.Empty;
                cboCategoria.Text = linha.Cells["categoria"].Value?.ToString() ?? string.Empty;
                cboMarca.Text = linha.Cells["marca"].Value?.ToString() ?? string.Empty;
                txtEstoque.Text = linha.Cells["estoque"].Value?.ToString() ?? string.Empty;
                txtValor.Text = linha.Cells["valorVenda"].Value?.ToString() ?? string.Empty;
                ptbImagem.ImageLocation = linha.Cells["foto"].Value?.ToString() ?? string.Empty;
            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}