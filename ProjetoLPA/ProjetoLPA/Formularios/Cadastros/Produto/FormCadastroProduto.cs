using DllControleDeVendas.Sistema.Globais;
using DllControleDeVendas.Sistema.Negocio;
using System;
using System.Data;
using System.Data.OleDb;

namespace ProjetoLPA.Formularios.Cadastros.Produto
{
    public partial class FormCadastroProduto : ProjetoLPA.Formularios.Modelos.FormModeloCadastro
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Herdado
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

            ClnProduto produto = new ClnProduto();
            produto.Ativo = optSim.Checked;
            produto.Categoria = (ClnCategoria)comboCategoria.SelectedItem;
            produto.Descricao = txtDescricao.Text;
            produto.Valor = double.Parse(txtValor.Text);

            if (Operacao == ClnFuncoesGerais.Operacao.Inclusao)
            {
                produto.Gravar();
            }
            else if (Operacao == ClnFuncoesGerais.Operacao.Alteracao)
            {
                produto.ID = Codigo;
                produto.Alterar();
            }
        }

        private void optSim_CheckedChanged(object sender, EventArgs e)
        {
            if (optSim.Checked == true)
            {
                optNao.Checked = false;
            }
        }

        private void optNao_CheckedChanged(object sender, EventArgs e)
        {
            if (optNao.Checked == true)
            {
                optSim.Checked = false;
            }
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            CarregaComboCategoria();

            if (Operacao == ClnFuncoesGerais.Operacao.Alteracao)
            {
                ClnProduto produto = new ClnProduto();
                OleDbDataReader dados = produto.ListarProduto(Codigo);
                if (dados.HasRows)
                {
                    dados.Read();

                    ClnCategoria categoria = new ClnCategoria();
                    OleDbDataReader categorias = categoria.ListarCategoria(int.Parse(dados["CAT_ID"].ToString()));
                    if (categorias.HasRows)
                    {
                        categorias.Read();
                        categoria.Descricao = categorias["CAT_DESCRICAO"].ToString();
                    }
                    comboCategoria.SelectedItem = categoria;
                    produto.Ativo = bool.Parse(dados["PRO_ATIVO"].ToString());
                    produto.Descricao = dados["PRO_DESCRICAO"].ToString();
                    produto.QtdEstoque = int.Parse(dados["PRO_QTDESTOQUE"].ToString());
                    produto.Valor = double.Parse(dados["PRO_VALOR"].ToString());
                }
            }
        }

        private void CarregaComboCategoria()
        {
            ClnCategoria categoria = new ClnCategoria();
            comboCategoria.DataSource = categoria.Listar("");
        }
    }
}
