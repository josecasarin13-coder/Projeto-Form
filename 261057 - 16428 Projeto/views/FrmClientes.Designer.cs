namespace _261057___16428_Projeto
{
    partial class FrmClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            txtUF = new TextBox();
            txtRenda = new TextBox();
            cboCidades = new ComboBox();
            mskCPF = new MaskedTextBox();
            dtpDataNasc = new DateTimePicker();
            picFoto = new PictureBox();
            chkVenda = new CheckBox();
            panel1 = new Panel();
            btnConsultar = new Button();
            dgvClientes = new DataGridView();
            txtPesquisa = new TextBox();
            label8 = new Label();
            btnFechar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnAlterar = new Button();
            btnIncluir = new Button();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 31);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 89);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 148);
            label3.Name = "label3";
            label3.Size = new Size(59, 20);
            label3.TabIndex = 2;
            label3.Text = "Cidade:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 149);
            label4.Name = "label4";
            label4.Size = new Size(29, 20);
            label4.TabIndex = 3;
            label4.Text = "UF:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 207);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 4;
            label5.Text = "CPF:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 207);
            label6.Name = "label6";
            label6.Size = new Size(148, 20);
            label6.TabIndex = 5;
            label6.Text = "Data de Nascimento:";

            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(449, 207);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 6;
            label7.Text = "Renda:";
            // 
            // txtID
            // 
            txtID.Location = new Point(14, 55);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(114, 27);
            txtID.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(14, 113);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(589, 27);
            txtNome.TabIndex = 9;
            // 
            // txtUF
            // 
            txtUF.Location = new Point(449, 173);
            txtUF.Margin = new Padding(3, 4, 3, 4);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(154, 27);
            txtUF.TabIndex = 10;
            // 
            // txtRenda
            // 
            txtRenda.Location = new Point(449, 233);
            txtRenda.Margin = new Padding(3, 4, 3, 4);
            txtRenda.Name = "txtRenda";
            txtRenda.Size = new Size(154, 27);
            txtRenda.TabIndex = 13;
            // 
            // cboCidades
            // 
            cboCidades.FormattingEnabled = true;
            cboCidades.Location = new Point(14, 172);
            cboCidades.Margin = new Padding(3, 4, 3, 4);
            cboCidades.Name = "cboCidades";
            cboCidades.Size = new Size(420, 28);
            cboCidades.TabIndex = 15;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(14, 231);
            mskCPF.Margin = new Padding(3, 4, 3, 4);
            mskCPF.Mask = "999.999.999-99";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(199, 27);
            mskCPF.TabIndex = 16;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(245, 233);
            dtpDataNasc.Margin = new Padding(3, 4, 3, 4);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(171, 27);
            dtpDataNasc.TabIndex = 17;
            // 
            // picFoto
            // 
            picFoto.Location = new Point(618, 13);
            picFoto.Margin = new Padding(3, 4, 3, 4);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(215, 248);
            picFoto.TabIndex = 18;
            picFoto.TabStop = false;
            // 
            // chkVenda
            // 
            chkVenda.AutoSize = true;
            chkVenda.Location = new Point(145, 58);
            chkVenda.Margin = new Padding(3, 4, 3, 4);
            chkVenda.Name = "chkVenda";
            chkVenda.Size = new Size(153, 24);
            chkVenda.TabIndex = 25;
            chkVenda.Text = "Bloqueia a venda?";
            chkVenda.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConsultar);
            panel1.Controls.Add(dgvClientes);
            panel1.Controls.Add(txtPesquisa);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(14, 337);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(819, 307);
            panel1.TabIndex = 26;
            // 
            // btnConsultar
            // 
            btnConsultar.Image = (Image)resources.GetObject("btnConsultar.Image");
            btnConsultar.Location = new Point(702, 12);
            btnConsultar.Margin = new Padding(3, 4, 3, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(86, 66);
            btnConsultar.TabIndex = 32;
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(30, 89);
            dgvClientes.Margin = new Padding(3, 4, 3, 4);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.Size = new Size(758, 200);
            dgvClientes.TabIndex = 4;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(30, 51);
            txtPesquisa.Margin = new Padding(3, 4, 3, 4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(658, 27);
            txtPesquisa.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(30, 27);
            label8.Name = "label8";
            label8.Size = new Size(271, 20);
            label8.TabIndex = 1;
            label8.Text = "Digite o nome da Cidade para Pesquisa";
            // 
            // btnFechar
            // 
            btnFechar.Image = (Image)resources.GetObject("btnFechar.Image");
            btnFechar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFechar.Location = new Point(682, 269);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(141, 60);
            btnFechar.TabIndex = 31;
            btnFechar.Text = "Fechar";
            btnFechar.TextAlign = ContentAlignment.MiddleRight;
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(503, 269);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(141, 60);
            btnExcluir.TabIndex = 30;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(342, 269);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 60);
            btnCancelar.TabIndex = 29;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = (Image)resources.GetObject("btnAlterar.Image");
            btnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterar.Location = new Point(184, 269);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(135, 60);
            btnAlterar.TabIndex = 28;
            btnAlterar.Text = "Alterar";
            btnAlterar.TextAlign = ContentAlignment.MiddleRight;
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnIncluir
            // 
            btnIncluir.Image = (Image)resources.GetObject("btnIncluir.Image");
            btnIncluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnIncluir.Location = new Point(14, 269);
            btnIncluir.Margin = new Padding(3, 4, 3, 4);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(135, 60);
            btnIncluir.TabIndex = 27;
            btnIncluir.Text = "Incluir";
            btnIncluir.TextAlign = ContentAlignment.MiddleRight;
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 657);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnAlterar);
            Controls.Add(btnIncluir);
            Controls.Add(panel1);
            Controls.Add(chkVenda);
            Controls.Add(picFoto);
            Controls.Add(dtpDataNasc);
            Controls.Add(mskCPF);
            Controls.Add(cboCidades);
            Controls.Add(txtRenda);
            Controls.Add(txtUF);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmClientes";
            Text = "Cadastro de Clientes";
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtUF;
        private TextBox txtRenda;
        private ComboBox cboCidades;
        private MaskedTextBox mskCPF;
        private DateTimePicker dtpDataNasc;
        private PictureBox picFoto;
        private CheckBox chkVenda;
        private Panel panel1;
        private DataGridView dgvClientes;
        private TextBox txtPesquisa;
        private Label label8;
        private Button btnFechar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnAlterar;
        private Button btnIncluir;
        private Button btnConsultar;
    }
}