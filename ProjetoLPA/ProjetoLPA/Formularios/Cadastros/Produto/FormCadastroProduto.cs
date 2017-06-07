using DllControleDeVendas.Sistema.Globais;
using DllControleDeVendas.Sistema.Negocio;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

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
            produto.QtdEstoque = int.Parse(nudQuantidade.Value.ToString());
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

            MessageBox.Show("Registro gravado com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
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


                    foreach (ClnCategoria c in comboCategoria.Items)
                    {
                        if (c.ID == int.Parse(dados["CAT_ID"].ToString()))
                        {
                            comboCategoria.SelectedItem = c;
                            break;
                        }

                    }
                    if (bool.Parse(dados["PRO_ATIVO"].ToString()))
                    {
                        optSim.Checked = true;
                        optNao.Checked = false;
                    }
                    else
                    {
                        optNao.Checked = true;
                        optSim.Checked = false;
                    }
                    txtDescricao.Text = dados["PRO_DESCRICAO"].ToString();
                    nudQuantidade.Value = int.Parse(dados["PRO_QTDESTOQUE"].ToString());
                    txtValor.Text = dados["PRO_VALOR"].ToString();
                }
            }
        }

        private void CarregaComboCategoria()
        {
            ClnCategoria categoria = new ClnCategoria();
            OleDbDataReader categorias = categoria.ListarCategorias();

            while (categorias.Read())
            {
                ClnCategoria cat = new ClnCategoria();
                cat.Descricao = categorias["CAT_DESCRICAO"].ToString();
                cat.ID = int.Parse(categorias["CAT_ID"].ToString());
                comboCategoria.Items.Add(cat);
            }

            comboCategoria.DisplayMember = "Descricao";
        }
    }
}
