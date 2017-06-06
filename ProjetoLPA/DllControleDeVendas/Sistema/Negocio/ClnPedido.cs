using DllControleDeVendas.Sistema.Globais;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllControleDeVendas.Sistema.Negocio
{
    class ClnPedido
    {
        private ClnCliente clnCliente;

        public ClnCliente Cliente
        {
            get { return clnCliente; }
            set { clnCliente = value; }
        }

        private DateTime ped_DtEncomenda;

        public DateTime DtEncomenda
        {
            get { return ped_DtEncomenda; }
            set { ped_DtEncomenda = value; }
        }

        private int ped_ID;

        public int ID
        {
            get { return ped_ID; }
            set { ped_ID = value; }
        }

        private int ped_Status;

        public int Status
        {
            get { return ped_Status; }
            set { ped_Status = value; }
        }

        private double ped_Valor;

        public double Valor
        {
            get { return ped_Valor; }
            set { ped_Valor = value; }
        }

        private CldBancoDados cldBancoDados = new CldBancoDados();

        public void Gravar()
        {
            StringBuilder query = new StringBuilder();
            query.Append("  INSERT INTO Produto");
            query.Append("  (");
            query.Append("  CLI_ID,");
            query.Append("  PED_DATAENCOMENDA,");
            query.Append("  PED_VALOR,");
            query.Append("  PED_STATUS,");

            query.Append("  ) VALUES (");

            query.Append("  " + clnCliente.ID);
            query.Append("  , '" + ped_DtEncomenda + "'");
            query.Append("  , " + ped_Valor);
            query.Append("  , '" + ped_Status);
            query.Append(")");

            cldBancoDados.ExecutaComando(query.ToString());
        }


    }
}
