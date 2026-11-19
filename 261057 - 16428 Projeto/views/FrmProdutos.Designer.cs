namespace _261057___16428_Projeto
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCodigo = new TextBox();
            txtDescricao = new TextBox();
            cboCategoria = new ComboBox();
            cboMarca = new ComboBox();
            ptbImagem = new PictureBox();
            txtEstoque = new TextBox();
            txtValor = new TextBox();
            btnFechar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnAlterar = new Button();
            btnIncluir = new Button();
            panel1 = new Panel();
            btnConsultar = new Button();
            dgvClientes = new DataGridView();
            txtPesquisa = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)ptbImagem).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Código:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 84);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 150);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 3;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(252, 150);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 4;
            label4.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 220);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 5;
            label5.Text = "Estoque:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 220);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 6;
            label6.Text = "Valor:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(22, 108);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(433, 27);
            txtCodigo.TabIndex = 7;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(22, 44);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(111, 27);
            txtDescricao.TabIndex = 8;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(24, 174);
            cboCategoria.Margin = new Padding(3, 4, 3, 4);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(200, 28);
            cboCategoria.TabIndex = 9;
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(252, 174);
            cboMarca.Margin = new Padding(3, 4, 3, 4);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(203, 28);
            cboMarca.TabIndex = 10;
            // 
            // ptbImagem
            // 
            ptbImagem.Location = new Point(476, 20);
            ptbImagem.Margin = new Padding(3, 4, 3, 4);
            ptbImagem.Name = "ptbImagem";
            ptbImagem.Size = new Size(246, 251);
            ptbImagem.TabIndex = 11;
            ptbImagem.TabStop = false;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(24, 244);
            txtEstoque.Margin = new Padding(3, 4, 3, 4);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(189, 27);
            txtEstoque.TabIndex = 12;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(253, 244);
            txtValor.Margin = new Padding(3, 4, 3, 4);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(202, 27);
            txtValor.TabIndex = 13;
            txtValor.TextChanged += txtValor_TextChanged;
            // 
            // btnFechar
            // 
            btnFechar.Image = (Image)resources.GetObject("btnFechar.Image");
            btnFechar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFechar.Location = new Point(591, 279);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(131, 60);
            btnFechar.TabIndex = 37;
            btnFechar.Text = "Fechar";
            btnFechar.TextAlign = ContentAlignment.MiddleRight;
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(448, 279);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(122, 60);
            btnExcluir.TabIndex = 36;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(299, 279);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(128, 60);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = (Image)resources.GetObject("btnAlterar.Image");
            btnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterar.Location = new Point(158, 279);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(119, 60);
            btnAlterar.TabIndex = 34;
            btnAlterar.Text = "Alterar";
            btnAlterar.TextAlign = ContentAlignment.MiddleRight;
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            btnIncluir.Image = (Image)resources.GetObject("btnIncluir.Image");
            btnIncluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnIncluir.Location = new Point(23, 279);
            btnIncluir.Margin = new Padding(3, 4, 3, 4);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(119, 60);
            btnIncluir.TabIndex = 33;
            btnIncluir.Text = "Incluir";
            btnIncluir.TextAlign = ContentAlignment.MiddleRight;
            btnIncluir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConsultar);
            panel1.Controls.Add(dgvClientes);
            panel1.Controls.Add(txtPesquisa);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(23, 347);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(699, 307);
            panel1.TabIndex = 32;
            // 
            // btnConsultar
            // 
            btnConsultar.Image = (Image)resources.GetObject("btnConsultar.Image");
            btnConsultar.Location = new Point(574, 12);
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
            dgvClientes.Size = new Size(639, 200);
            dgvClientes.TabIndex = 4;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(30, 51);
            txtPesquisa.Margin = new Padding(3, 4, 3, 4);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(538, 27);
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
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 674);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnAlterar);
            Controls.Add(btnIncluir);
            Controls.Add(panel1);
            Controls.Add(txtValor);
            Controls.Add(txtEstoque);
            Controls.Add(ptbImagem);
            Controls.Add(cboMarca);
            Controls.Add(cboCategoria);
            Controls.Add(txtDescricao);
            Controls.Add(txtCodigo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmProdutos";
            Text = "Código:";
            ((System.ComponentModel.ISupportInitialize)ptbImagem).EndInit();
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
        private TextBox txtCodigo;
        private TextBox txtDescricao;
        private ComboBox cboCategoria;
        private ComboBox cboMarca;
        private PictureBox ptbImagem;
        private TextBox txtEstoque;
        private TextBox txtValor;
        private Button btnFechar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnAlterar;
        private Button btnIncluir;
        private Panel panel1;
        private Button btnConsultar;
        private DataGridView dgvClientes;
        private TextBox txtPesquisa;
        private Label label8;
    }
}