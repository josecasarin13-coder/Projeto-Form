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
            lbl1 = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            label2 = new Label();
            btnIncluir = new Button();
            btnAlterar = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            btnFechar = new Button();
            label3 = new Label();
            txtUF = new TextBox();
            panel1 = new Panel();
            dgvCidades = new DataGridView();
            txtPesquisa = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCidades).BeginInit();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(34, 15);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(49, 15);
            lbl1.TabIndex = 0;
            lbl1.Text = "Código:";
            // 
            // txtID
            // 
            txtID.Location = new Point(34, 33);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(34, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(575, 23);
            txtNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 82);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Cidade:";
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(34, 154);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(75, 23);
            btnIncluir.TabIndex = 4;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(149, 154);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 5;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(265, 154);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(372, 154);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 7;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(482, 154);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 8;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(663, 82);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 9;
            label3.Text = "UF:";
            // 
            // txtUF
            // 
            txtUF.Location = new Point(663, 100);
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(100, 23);
            txtUF.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvCidades);
            panel1.Controls.Add(txtPesquisa);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(34, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 230);
            panel1.TabIndex = 11;
            // 
            // dgvCidades
            // 
            dgvCidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCidades.Location = new Point(26, 67);
            dgvCidades.Name = "dgvCidades";
            dgvCidades.Size = new Size(703, 150);
            dgvCidades.TabIndex = 4;
            // 
            // txtPesquisa
            // 
            txtPesquisa.Location = new Point(26, 38);
            txtPesquisa.Name = "txtPesquisa";
            txtPesquisa.Size = new Size(627, 23);
            txtPesquisa.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 20);
            label1.Name = "label1";
            label1.Size = new Size(213, 15);
            label1.TabIndex = 1;
            label1.Text = "Digite o nome da Cidade para Pesquisa";
            // 
            // FrmCidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(txtUF);
            Controls.Add(label3);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnAlterar);
            Controls.Add(btnIncluir);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(lbl1);
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
        private Button btnIncluir;
        private Button btnAlterar;
        private Button btnCancelar;
        private Button btnExcluir;
        private Button btnFechar;
        private Label label3;
        private TextBox txtUF;
        private Panel panel1;
        private TextBox txtPesquisa;
        private Label label1;
        private DataGridView dgvCidades;
    }
}
