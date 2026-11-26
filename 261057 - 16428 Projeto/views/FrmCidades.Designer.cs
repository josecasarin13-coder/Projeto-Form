namespace _261057___16428_Projeto
{
    partial class FrmCidades
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCidades));
            lbl1 = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtUF = new TextBox();
            btnFechar = new Button();
            btnExcluir = new Button();
            btnCancelar = new Button();
            btnAlterar = new Button();
            btnIncluir = new Button();
            panel1 = new Panel();
            btnConsultar = new Button();
            dgvCidades = new DataGridView();
            txtPesquisa = new TextBox();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCidades).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(12, 19);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(61, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "Código:";
            // 
            // txtID
            // 
            txtID.Location = new Point(12, 43);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(114, 27);
            txtID.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 109);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(657, 27);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 3;
            label2.Text = "Cidade:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(709, 85);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 9;
            label3.Text = "UF:";
            // 
            // txtUF
            // 
            txtUF.Location = new Point(709, 109);
            txtUF.Margin = new Padding(3, 4, 3, 4);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(114, 27);
            txtUF.TabIndex = 10;
            // 
            // btnFechar
            // 
            btnFechar.Image = (Image)resources.GetObject("btnFechar.Image");
            btnFechar.ImageAlign = ContentAlignment.MiddleLeft;
            btnFechar.Location = new Point(682, 156);
            btnFechar.Margin = new Padding(3, 4, 3, 4);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(141, 60);
            btnFechar.TabIndex = 37;
            btnFechar.Text = "Fechar";
            btnFechar.TextAlign = ContentAlignment.MiddleRight;
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Image = (Image)resources.GetObject("btnExcluir.Image");
            btnExcluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnExcluir.Location = new Point(503, 156);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(141, 60);
            btnExcluir.TabIndex = 36;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.MiddleRight;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(342, 156);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(135, 60);
            btnCancelar.TabIndex = 35;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Image = (Image)resources.GetObject("btnAlterar.Image");
            btnAlterar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAlterar.Location = new Point(184, 156);
            btnAlterar.Margin = new Padding(3, 4, 3, 4);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(135, 60);
            btnAlterar.TabIndex = 34;
            btnAlterar.Text = "Alterar";
            btnAlterar.TextAlign = ContentAlignment.MiddleRight;
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnIncluir
            // 
            btnIncluir.Image = (Image)resources.GetObject("btnIncluir.Image");
            btnIncluir.ImageAlign = ContentAlignment.MiddleLeft;
            btnIncluir.Location = new Point(14, 156);
            btnIncluir.Margin = new Padding(3, 4, 3, 4);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(135, 60);
            btnIncluir.TabIndex = 33;
            btnIncluir.Text = "Incluir";
            btnIncluir.TextAlign = ContentAlignment.MiddleRight;
            btnIncluir.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnConsultar);
            panel1.Controls.Add(dgvCidades);
            panel1.Controls.Add(txtPesquisa);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(12, 224);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 307);
            panel1.TabIndex = 32;
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
            // dgvCidades
            // 
            dgvCidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCidades.Location = new Point(30, 89);
            dgvCidades.Margin = new Padding(3, 4, 3, 4);
            dgvCidades.Name = "dgvCidades";
            dgvCidades.RowHeadersWidth = 51;
            dgvCidades.Size = new Size(758, 200);
            dgvCidades.TabIndex = 4;
            dgvCidades.CellContentClick += dgvCidades_CellContentClick;
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
            // FrmCidades
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 551);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnAlterar);
            Controls.Add(btnIncluir);
            Controls.Add(panel1);
            Controls.Add(txtUF);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(lbl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCidades";
            Text = "Cadastro de Cidades";
            Load += FrmCidades_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCidades).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl1;
        private TextBox txtID;
        private TextBox txtNome;
        private Label label2;
        private Label label3;
        private TextBox txtUF;
        private Button btnFechar;
        private Button btnExcluir;
        private Button btnCancelar;
        private Button btnAlterar;
        private Button btnIncluir;
        private Panel panel1;
        private Button btnConsultar;
        private DataGridView dgvCidades;
        private TextBox txtPesquisa;
        private Label label8;
    }
}
