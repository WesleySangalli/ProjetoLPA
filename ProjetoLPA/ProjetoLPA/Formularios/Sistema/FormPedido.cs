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

        private double ValorTotal;
        private int max;

        public FormPedido()
        {
            InitializeComponent();

            gridItem.Columns.Add("Cod_Produto", "Cod_Produto");
            gridItem.Columns.Add("Produto", "Produto");
            gridItem.Columns.Add("Quantidade", "Quantidade");
            gridItem.Columns.Add("Valor", "Valor");
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FormConsulta consultaCliente = new FormConsulta();
            consultaCliente.TipoConsulta = ClnFuncoesGerais.TipoConsulta.Cliente;
            consultaCliente.CarregaDataGrid();
            consultaCliente.ShowDialog();

            codigoCliente = consultaCliente.Codigo;
            descricaoCliente = consultaCliente.Descricao;

            txtCliente.Text = descricaoCliente;
        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            FormConsulta consultaProduto = new FormConsulta();
            consultaProduto.TipoConsulta = ClnFuncoesGerais.TipoConsulta.Produto;
            consultaProduto.CarregaDataGrid();
            consultaProduto.ShowDialog();

            codigoProduto = consultaProduto.Codigo;
            descricaoProduto = consultaProduto.Descricao;
            max = consultaProduto.Quantidade;

            txtProduto.Text = descricaoProduto;
            txtQuantidade.Maximum = max;
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            // esse botao é pura enganação ... o ID já está setado! rs
            MessageBox.Show("Cliente Selecionado!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // hehehe
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            gridItem.Rows.Add(new string[] { codigoProduto.ToString(), descricaoProduto, txtQuantidade.Text, txtValor.Text });
            ValorTotal += double.Parse(txtValor.Text);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            gridItem.Rows.Remove(gridItem.CurrentRow);
            ValorTotal -= double.Parse(gridItem.CurrentRow.Cells[3].Value.ToString());
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (codigoCliente == 0 && descricaoCliente == null)
            {
                MessageBox.Show("Seleciona um cliente", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gridItem.RowCount == 0)
            {
                MessageBox.Show("Seleciona ao menos um produto", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClnPedido pedido = new ClnPedido();

            ClnCliente cliente = new ClnCliente();
            cliente.ID = codigoCliente;
            pedido.Cliente = cliente;

            pedido.DtEncomenda = dtpData.Value;
            pedido.Status = 1;

            pedido.Valor = ValorTotal;
            int idPedido = pedido.Gravar();
            pedido.ID = idPedido;

            foreach (DataGridViewRow row in gridItem.Rows)
            {
                if (row != null && row.Cells[0].Value != null)
                {
                    ClnProduto produto = new ClnProduto();
                    produto.ID = int.Parse(row.Cells[0].Value.ToString());

                    ClnItem item = new ClnItem()
                    {
                        Pedido = pedido,
                        Produto = produto,
                        Quantidade = int.Parse(row.Cells[2].Value.ToString()),
                        Valor = double.Parse(row.Cells[3].Value.ToString())
                    };

                    item.Gravar();
                }
            }

            MessageBox.Show("Venda cadastrada com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }
    }
}
