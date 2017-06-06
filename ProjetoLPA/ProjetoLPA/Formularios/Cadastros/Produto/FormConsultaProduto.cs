using DllControleDeVendas.Sistema.Globais;
using DllControleDeVendas.Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLPA.Formularios.Cadastros.Produto
{
    public partial class FormConsultaProduto : ProjetoLPA.Formularios.Modelos.FormModeloConsulta
    {
        public FormConsultaProduto()
        {
            InitializeComponent();
            CarregaGrid();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Herdado
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o registro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ClnProduto exclusao = new ClnProduto();
            exclusao.Excluir((int)dataGrid.CurrentRow.Cells[0].Value);
            MessageBox.Show("Registro deletado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FormCadastroProduto alteracao = new FormCadastroProduto();
            alteracao.Operacao = ClnFuncoesGerais.Operacao.Inclusao;
            alteracao.Codigo = (int)dataGrid.CurrentRow.Cells[0].Value;
            alteracao.ShowDialog();
            CarregaGrid();            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroProduto cadastro = new FormCadastroProduto();
            cadastro.Operacao = ClnFuncoesGerais.Operacao.Inclusao;            
            cadastro.ShowDialog();
            CarregaGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            ClnProduto cliente = new ClnProduto();
            dataGrid.DataSource = cliente.Listar(txtDescricao.Text).Tables[0];
        }
    }
}
