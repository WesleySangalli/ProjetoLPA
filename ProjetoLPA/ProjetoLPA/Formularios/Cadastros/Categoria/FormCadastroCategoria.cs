using DllControleDeVendas.Sistema.Globais;
using DllControleDeVendas.Sistema.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLPA.Formularios.Cadastros.Categoria
{
    public partial class FormCadastroCategoria : ProjetoLPA.Formularios.Modelos.FormModeloCadastro
    {
        public FormCadastroCategoria()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // Herdado
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClnCategoria categoria = new ClnCategoria();
            categoria.Descricao = txtNome.Text;

            if (Operacao == ClnFuncoesGerais.Operacao.Inclusao)
            {
                categoria.Gravar();
            }
            else if (Operacao == ClnFuncoesGerais.Operacao.Alteracao)
            {
                categoria.ID = Codigo;
                categoria.Alterar();
            }

            MessageBox.Show("Registro gravado com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FormCadastroCategoria_Load(object sender, EventArgs e)
        {
            if (Operacao == ClnFuncoesGerais.Operacao.Alteracao)
            {
                ClnCategoria categoria = new ClnCategoria();
                OleDbDataReader dados = categoria.ListarCategoria(Codigo);
                if (dados.HasRows)
                {
                    dados.Read();
                    txtNome.Text = dados["CAT_DESCRICAO"].ToString();
                }
            }
        }
    }
}
