using DllControleDeVendas.Sistema.Globais;
using DllControleDeVendas.Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLPA.Formularios.Cadastros.Cliente
{
    public partial class FormConsultaCliente : ProjetoLPA.Formularios.Modelos.FormModeloConsulta
    {

        public FormConsultaCliente()
        {
            InitializeComponent();
            CarregaGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroCliente cadastro = new FormCadastroCliente();
            cadastro.Operacao = ClnFuncoesGerais.Operacao.Inclusao;
            cadastro.ShowDialog();
            CarregaGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            FormCadastroCliente alteracao = new FormCadastroCliente();
            alteracao.Operacao = ClnFuncoesGerais.Operacao.Alteracao;
            alteracao.Codigo = (int) dataGrid.CurrentRow.Cells[0].Value;
            alteracao.ShowDialog();
            CarregaGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void CarregaGrid()
        {
            ClnCliente cliente =  new ClnCliente();
            dataGrid.DataSource = cliente.Listar(txtDescricao.Text).Tables[0];
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja excluir o registro?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            ClnCliente exclusao = new ClnCliente();
            exclusao.Excluir((int)dataGrid.CurrentRow.Cells[0].Value);
            MessageBox.Show("Registro deletado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            CarregaGrid();
        }
    }
}
