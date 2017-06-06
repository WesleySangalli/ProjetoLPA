using DllControleDeVendas.Sistema.Globais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllControleDeVendas.Sistema.Negocio
{
    public class ClnItem
    {
        private ClnPedido clnPedido;

        public ClnPedido Pedido
        {
            get { return clnPedido; }
            set { clnPedido = value; }
        }

        private ClnProduto clnProduto;

        public ClnProduto Produto
        {
            get { return clnProduto; }
            set { clnProduto = value; }
        }

        private int ite_ID;

        public int ID
        {
            get { return ite_ID; }
            set { ite_ID = value; }
        }

        private int ite_Qtde;

        public int Quantidade
        {
            get { return ite_Qtde; }
            set { ite_Qtde = value; }
        }

        private double ite_Valor;

        public double Valor
        {
            get { return ite_Valor; }
            set { ite_Valor = value; }
        }

        private CldBancoDados cldBancoDados = new CldBancoDados();

        public void Excluir(int codigo)
        {
            StringBuilder query = new StringBuilder();
            query.Append("  DELETE FROM Item");
            query.Append("  WHERE ITE_ID = " + ite_ID);
            cldBancoDados.ExecutaComando(query.ToString());
        }

        public void Gravar()
        {
            StringBuilder query = new StringBuilder();
            query.Append("  INSERT INTO Produto");
            query.Append("  (");
            query.Append("  PED_ID,");
            query.Append("  PRO_ID,");
            query.Append("  ITE_QTDE,");
            query.Append("  ITE_VALOR,");

            query.Append("  ) VALUES (");

            query.Append("  " + clnPedido.ID);
            query.Append("  , " + clnProduto.ID);
            query.Append("  , " + ite_Qtde);
            query.Append("  , " + ite_Valor);
            query.Append(")");

            cldBancoDados.ExecutaComando(query.ToString());
        }

        public void Listar()
        {
            StringBuilder query = new StringBuilder();
            query.Append("  SELECT PED_ID,");
            query.Append("  PRO_ID,");
            query.Append("  ITE_QTDE,");
            query.Append("  ITE_VALOR,");
            query.Append("  FROM Item");

            cldBancoDados.RetornaDataSet(query.ToString());
        }
    }
}
