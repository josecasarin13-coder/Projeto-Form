using System;
using System.Drawing;
using System.Windows.Forms;

namespace _261057___16428_Projeto
{
    partial class FrmMenu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            mniCidades = new ToolStripMenuItem();
            mniClientes = new ToolStripMenuItem();
            mniProdutos = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1067, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mniCidades, mniClientes, mniProdutos });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(88, 24);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            cadastrosToolStripMenuItem.Click += cadastrosToolStripMenuItem_Click;
            // 
            // mniCidades
            // 
            mniCidades.Name = "mniCidades";
            mniCidades.Size = new Size(224, 26);
            mniCidades.Text = "Cidades";
            mniCidades.Click += cidadesToolStripMenuItem_Click;
            // 
            // mniClientes
            // 
            mniClientes.Name = "mniClientes";
            mniClientes.Size = new Size(224, 26);
            mniClientes.Text = "Clientes";
            mniClientes.Click += mniClientes_Click;
            // 
            // mniProdutos
            // 
            mniProdutos.Name = "mniProdutos";
            mniProdutos.Size = new Size(224, 26);
            mniProdutos.Text = "Produtos";
            mniProdutos.Click += mniProdutos_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 692);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmMenu";
            Text = "Menu do Sistema";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniCidades;
        private System.Windows.Forms.ToolStripMenuItem mniClientes;
        private System.Windows.Forms.ToolStripMenuItem mniProdutos;
    }
}