using DllControleDeVendas.Sistema.Globais;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoLPA.Formularios.Modelos
{
    public partial class FormModeloCadastro : ProjetoLPA.Formularios.Modelos.FormModelo
    {
        private ClnFuncoesGerais.Operacao _Operacao;

        public ClnFuncoesGerais.Operacao Operacao
        {
            get { return _Operacao; }
            set { _Operacao = value; }
        }

        private int _Codigo;

        public int Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }

        public FormModeloCadastro()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
