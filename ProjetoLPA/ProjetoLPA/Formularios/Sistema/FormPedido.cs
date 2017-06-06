using DllControleDeVendas.Sistema.Globais;
using DllControleDeVendas.Sistema.Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLPA.Formularios.Sistema
{
    public partial class FormPedido : ProjetoLPA.Formularios.Modelos.FormModeloCadastro
    {

        private int codigoCliente;
        private string descricaoCliente;

        private int codigoProduto;
        private string descricaoProduto;

        ArrayList items = new ArrayList();

        public FormPedido()
        {
            InitializeComponent();
            gridItem.DataSource = items;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FormConsulta consultaCliente = new FormConsulta();
            consultaCliente.TipoConsulta = ClnFuncoesGerais.TipoConsulta.Cliente;
            consultaCliente.ShowDialog();

            codigoCliente = consultaCliente.Codigo;
            descricaoCliente = consultaCliente.Descricao;

            txtCliente.Text = descricaoCliente;
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            FormConsulta consultaProduto = new FormConsulta();
            consultaProduto.TipoConsulta = ClnFuncoesGerais.TipoConsulta.Produto;
            consultaProduto.ShowDialog();

            codigoProduto = consultaProduto.Codigo;
            descricaoProduto = consultaProduto.Descricao;

            txtProduto.Text = descricaoProduto;
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            // esse botao é pura enganação ... o ID já está setado! rs
            MessageBox.Show("Cliente Selecionado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // hehehe
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ClnItem item = new ClnItem();
            ClnProduto produto = new ClnProduto();

            produto.Descricao = descricaoProduto;
            produto.ID = codigoProduto;

            item.Produto = produto;
            item.Valor = double.Parse(txtValor.Text);
            item.Quantidade = int.Parse(txtQuantidade.Text);

            items.Add(item);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            int pos = (int)gridItem.CurrentRow.Cells[0].Value;
            items.RemoveAt(pos);
        }
    }
}
