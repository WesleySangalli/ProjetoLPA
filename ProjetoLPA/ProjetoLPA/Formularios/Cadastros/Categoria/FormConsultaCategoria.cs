using DllControleDeVendas.Sistema.Globais;
using DllControleDeVendas.Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLPA.Formularios.Cadastros.Categoria
{
    public partial class FormConsultaCategoria : ProjetoLPA.Formularios.Modelos.FormModeloConsulta
    {
        public FormConsultaCategoria()
        {
            InitializeComponent();
            CarregaGrid();
        }

        private void FormConsultaCategoria_Load(object sender, EventArgs e)
        {

        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ClnCategoria exclusao = new ClnCategoria();
            exclusao.Excluir((int)dataGrid.CurrentRow.Cells[0].Value);
            MessageBox.Show("Registro deletado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FormCadastroCategoria alteracao = new FormCadastroCategoria();
            alteracao.Operacao = ClnFuncoesGerais.Operacao.Alteracao;
            alteracao.Codigo = (int)dataGrid.CurrentRow.Cells[0].Value;
            alteracao.ShowDialog();
            CarregaGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroCategoria form = new FormCadastroCategoria();
            form.Operacao = ClnFuncoesGerais.Operacao.Inclusao;
            form.ShowDialog();
            CarregaGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Herdado
        }


        private void CarregaGrid()
        {
            ClnCategoria categoria = new ClnCategoria();
            dataGrid.DataSource = categoria.Listar(txtDescricao.Text).Tables[0];
        }

    }
}
