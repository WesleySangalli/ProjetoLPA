﻿using ProjetoLPA.Formularios.Cadastros.Categoria;
using ProjetoLPA.Formularios.Cadastros.Cliente;
using ProjetoLPA.Formularios.Cadastros.Produto;
using System;
using System.Windows.Forms;

namespace ProjetoLPA.Formularios.Sistema
{
    public partial class FormMenu : ProjetoLPA.Formularios.Modelos.FormModelo
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sistema de Vendas v1.0", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaCliente form = new FormConsultaCliente();
            form.ShowDialog();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultaProduto form = new FormConsultaProduto();
            form.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultaCategoria form = new FormConsultaCategoria();
            form.ShowDialog();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPedido form = new FormPedido();
            form.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}