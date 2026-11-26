using System;
using System.Data;
using System.Windows.Forms;
using _261057___16428_Projeto.Models;

namespace _261057___16428_Projeto
{
    public partial class FrmClientes : Form
    {
        Cidade ci;
        Cliente cl;

        public FrmClientes()
        {
            InitializeComponent();
            this.Load += FrmClientes_Load;
            btnCancelar.Click += btnCancelar_Click;
            btnExcluir.Click += btnExcluir_Click;
            btnFechar.Click += btnFechar_Click;
            btnConsultar.Click += btnConsultar_Click;
            dgvClientes.CellClick += dgvClientes_CellClick;
            cboCidades.SelectedIndexChanged += cboCidades_SelectedIndexChanged;
            picFoto.Click += picFoto_Click;
        }

        private void limparControles()
        {
            txtID.Clear();
            txtNome.Clear();
            cboCidades.SelectedIndex = -1;
            txtUF.Clear();
            mskCPF.Clear();
            txtRenda.Clear();
            dtpDataNasc.Value = DateTime.Now;
            picFoto.ImageLocation = "";
            chkVenda.Checked = false;
            txtPesquisa.Clear();
            txtNome.Focus();
        }

        private void carregarGrid(string pesquisa)
        {
            cl = new Cliente();
            cl.nome = pesquisa;
            dgvClientes.DataSource = cl.Consultar();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ci = new Cidade();
            cboCidades.DataSource = ci.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            limparControles();
            carregarGrid("");

            if (dgvClientes.Columns["idCidade"] != null)
                dgvClientes.Columns["idCidade"].Visible = false;
            if (dgvClientes.Columns["foto"] != null)
                dgvClientes.Columns["foto"].Visible = false;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (cboCidades.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma cidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCidades.Focus();
                return;
            }

            cl = new Cliente
            {
                nome = txtNome.Text.Trim(),
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dtpDataNasc.Value,
                renda = double.TryParse(txtRenda.Text.Trim(), out double renda) ? renda : 0,
                cpf = mskCPF.Text.Trim(),
                foto = picFoto.ImageLocation,
                venda = chkVenda.Checked
            };

            cl.Incluir();
            limparControles();
            carregarGrid("");
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Selecione um cliente na grade para alterar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Informe o nome do cliente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNome.Focus();
                return;
            }

            if (cboCidades.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma cidade.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCidades.Focus();
                return;
            }

            cl = new Cliente
            {
                id = int.Parse(txtID.Text),
                nome = txtNome.Text.Trim(),
                idCidade = (int)cboCidades.SelectedValue,
                dataNasc = dtpDataNasc.Value,
                renda = double.TryParse(txtRenda.Text.Trim(), out double renda) ? renda : 0,
                cpf = mskCPF.Text.Trim(),
                foto = picFoto.ImageLocation,
                venda = chkVenda.Checked
            };

            cl.Alterar();
            limparControles();
            carregarGrid("");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Selecione um cliente na grade para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Deseja realmente excluir este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cl = new Cliente { id = int.Parse(txtID.Text) };
                cl.Excluir();
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

        private void cboCidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCidades.SelectedIndex != -1 && cboCidades.SelectedItem is DataRowView reg)
            {
                txtUF.Text = reg["uf"]?.ToString() ?? string.Empty;
            }
        }

        private void picFoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    picFoto.ImageLocation = ofd.FileName;
                }
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvClientes.CurrentRow != null)
            {
                DataGridViewRow linha = dgvClientes.CurrentRow;
                txtID.Text = linha.Cells["Id"].Value?.ToString() ?? string.Empty;
                txtNome.Text = linha.Cells["nome"].Value?.ToString() ?? string.Empty;
                cboCidades.Text = linha.Cells["cidade"].Value?.ToString() ?? string.Empty;
                txtUF.Text = linha.Cells["uf"].Value?.ToString() ?? string.Empty;
                chkVenda.Checked = Convert.ToBoolean(linha.Cells["venda"].Value ?? false);
                mskCPF.Text = linha.Cells["cpf"].Value?.ToString() ?? string.Empty;
                dtpDataNasc.Text = linha.Cells["dataNasc"].Value?.ToString() ?? DateTime.Now.ToString();
                txtRenda.Text = linha.Cells["renda"].Value?.ToString() ?? string.Empty;
                picFoto.ImageLocation = linha.Cells["foto"].Value?.ToString() ?? string.Empty;
            }
        }
    }
}