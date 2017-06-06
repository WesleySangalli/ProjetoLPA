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

namespace ProjetoLPA.Formularios.Cadastros.Cliente
{
    public partial class FormCadastroCliente : ProjetoLPA.Formularios.Modelos.FormModeloCadastro
    {
        public FormCadastroCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void FormCadastroCliente_Load(object sender, EventArgs e)
        {
            if (Operacao == ClnFuncoesGerais.Operacao.Alteracao)
            {
                ClnCliente cliente = new ClnCliente();
                OleDbDataReader dados = cliente.ListarCliente(Codigo);                
                if (dados.HasRows)
                {
                    dados.Read();
                    txtNome.Text = dados["CLI_NOMERAZAO"].ToString();
                    txtCpf.Text = dados["CLI_CNPJCPF"].ToString();
                    txtLogradouro.Text = dados["CLI_LOGRADOURO"].ToString();
                    txtBairro.Text = dados["CLI_BAIRRO"].ToString();
                    txtCidade.Text = dados["CLI_CIDADE"].ToString();
                    comboUf.Text = dados["CLI_UF"].ToString();
                    txtCep.Text = dados["CLI_CEP"].ToString();
                    txtEmail.Text = dados["CLI_EMAIL"].ToString();
                    txtTelefone.Text = dados["CLI_FONES"].ToString();                    
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClnCliente cliente = new ClnCliente();
            cliente.Bairro = txtBairro.Text;
            cliente.CEP = txtCep.Text;
            cliente.Cidade = txtCidade.Text;
            cliente.CNPJCPF = txtCpf.Text;
            cliente.DataCadastro = DateTime.Now;
            cliente.Email = txtEmail.Text;
            cliente.Fones = txtTelefone.Text;
            cliente.Logradouro = txtLogradouro.Text;
            cliente.Nome = txtNome.Text;
            cliente.UF = comboUf.Text;

            if (Operacao == ClnFuncoesGerais.Operacao.Inclusao)
            {
                cliente.Gravar();
            }
            else if (Operacao == ClnFuncoesGerais.Operacao.Alteracao)
            {
                cliente.ID = Codigo;
                cliente.Alterar();
            }

            MessageBox.Show("Registro gravado com sucesso", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
