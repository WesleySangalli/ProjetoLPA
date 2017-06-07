using DllControleDeVendas.Sistema.Globais;
using DllControleDeVendas.Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLPA.Formularios.Sistema
{
    public partial class FormConsulta : ProjetoLPA.Formularios.Modelos.FormModeloConsulta
    {

        private ClnFuncoesGerais.TipoConsulta tipo;

        public ClnFuncoesGerais.TipoConsulta TipoConsulta
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int rowCodigo;

        public int Codigo
        {
            get { return rowCodigo; }
            set { rowCodigo = value; }
        }

        private int quantidade;

        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }


        private string rowDescricao;

        public string Descricao
        {
            get { return rowDescricao; }
            set { rowDescricao = value; }
        }

        public FormConsulta()
        {
            InitializeComponent();            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Herdado
        }
        public void CarregaDataGrid()
        {
            dataGrid.DataSource = null;

            if (tipo == ClnFuncoesGerais.TipoConsulta.Cliente)
            {
                ClnCliente cliente = new ClnCliente();
                dataGrid.DataSource = cliente.Listar(txtDescricao.Text).Tables[0];
            }
            else if (tipo == ClnFuncoesGerais.TipoConsulta.Produto)
            {
                ClnProduto produto = new ClnProduto();
                dataGrid.DataSource = produto.Listar(txtDescricao.Text).Tables[0];
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregaDataGrid();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Codigo = (int)dataGrid.CurrentRow.Cells[0].Value;
            Descricao = (string)dataGrid.CurrentRow.Cells[1].Value;

            if (tipo == ClnFuncoesGerais.TipoConsulta.Produto)
            {
                quantidade = int.Parse(dataGrid.CurrentRow.Cells[2].Value.ToString());
            }
            this.Close();
        }
    }
}
