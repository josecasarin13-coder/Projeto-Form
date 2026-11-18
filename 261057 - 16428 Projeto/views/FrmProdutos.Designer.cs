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
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            gbrProdutos = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)ptbImagem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 16);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Código:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 53);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 93);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Categoria:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 130);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 4;
            label4.Text = "Marca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 168);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 5;
            label5.Text = "Estoque:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 214);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 6;
            label6.Text = "Valor:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(94, 45);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(166, 23);
            txtCodigo.TabIndex = 7;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(82, 13);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(178, 23);
            txtDescricao.TabIndex = 8;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(94, 90);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(166, 23);
            cboCategoria.TabIndex = 9;
            // 
            // cboMarca
            // 
            cboMarca.FormattingEnabled = true;
            cboMarca.Location = new Point(82, 130);
            cboMarca.Name = "cboMarca";
            cboMarca.Size = new Size(178, 23);
            cboMarca.TabIndex = 10;
            // 
            // ptbImagem
            // 
            ptbImagem.Location = new Point(506, 27);
            ptbImagem.Name = "ptbImagem";
            ptbImagem.Size = new Size(282, 228);
            ptbImagem.TabIndex = 11;
            ptbImagem.TabStop = false;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(82, 168);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(178, 23);
            txtEstoque.TabIndex = 12;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(83, 211);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(177, 23);
            txtValor.TabIndex = 13;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(27, 244);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(97, 23);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(185, 244);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(103, 23);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(339, 244);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(108, 23);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // gbrProdutos
            // 
            gbrProdutos.Location = new Point(12, 273);
            gbrProdutos.Name = "gbrProdutos";
            gbrProdutos.Size = new Size(776, 165);
            gbrProdutos.TabIndex = 17;
            gbrProdutos.TabStop = false;
            gbrProdutos.Text = "Produtos";
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gbrProdutos);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
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
            Name = "FrmProdutos";
            Text = "Código:";
            ((System.ComponentModel.ISupportInitialize)ptbImagem).EndInit();
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
        private Button btnSalvar;
        private Button btnEditar;
        private Button btnExcluir;
        private GroupBox gbrProdutos;
    }
}