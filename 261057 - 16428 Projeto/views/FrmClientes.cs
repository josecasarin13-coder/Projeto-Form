using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //Cria um objeto do tipo cidade
            //E alimenta o combobos
            ci= new Cidade();
            cboCidades.DataSource = ci.Consultar();
            cboCidades.DisplayMember = "nome";
            cboCidades.ValueMember = "id";

            limparControles();
            carregarGrid("");

            //Deixa invisível colunas do Grid
            dgvClientes.Columns["idCidade"].Visible = false;
            dgvClientes.Columns["foto"].Visible = false;
        }
    }
}
