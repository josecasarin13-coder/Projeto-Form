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
        }

        void limparControles()
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
        }

        void carregarGrid(string pesquisa)
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

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}