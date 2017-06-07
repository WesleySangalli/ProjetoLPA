using DllControleDeVendas.Sistema.Globais;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllControleDeVendas.Sistema.Negocio
{
    public class ClnProduto
    {
        private ClnCategoria clnCategoria;

        public ClnCategoria Categoria
        {
            get { return clnCategoria; }
            set { clnCategoria = value; }
        }

        private bool pro_Ativo;

        public bool Ativo
        {
            get { return pro_Ativo; }
            set { pro_Ativo = value; }
        }

        private string pro_Descricao;

        public string Descricao
        {
            get { return pro_Descricao; }
            set { pro_Descricao = value; }
        }

        private int pro_ID;

        public int ID
        {
            get { return pro_ID; }
            set { pro_ID = value; }
        }

        private int pro_QtdEstoque;

        public int QtdEstoque
        {
            get { return pro_QtdEstoque; }
            set { pro_QtdEstoque = value; }
        }

        private double pro_Valor;

        public double Valor
        {
            get { return pro_Valor; }
            set { pro_Valor = value; }
        }

        private CldBancoDados cldBancoDados = new CldBancoDados();

        public void Alterar()
        {
            StringBuilder query = new StringBuilder();
            query.Append("  UPDATE Produto");
            query.Append("  SET");
            query.Append("  CAT_ID = " + clnCategoria.ID + ",");
            query.Append("  PRO_DESCRICAO = '" + pro_Descricao + "',");
            query.Append("  PRO_QTDESTOQUE = " + pro_QtdEstoque + ",");
            query.Append("  PRO_VALOR = " + pro_Valor + ",");
            query.Append("  PRO_ATIVO = " + pro_Ativo);
            query.Append("  WHERE PRO_ID=" + pro_ID);
            cldBancoDados.ExecutaComando(query.ToString());
        }


        public void Excluir(int codigo)
        {
            StringBuilder query = new StringBuilder();
            query.Append("  DELETE FROM Produto");
            query.Append("  WHERE PRO_ID = " + codigo);
            cldBancoDados.ExecutaComando(query.ToString());
        }


        public void Gravar()
        {
            StringBuilder query = new StringBuilder();
            query.Append("  INSERT INTO Produto");
            query.Append("  (CAT_ID, PRO_DESCRICAO, PRO_QTDESTOQUE, PRO_VALOR, PRO_ATIVO)");
            query.Append("  VALUES");
            query.Append("  (" + clnCategoria.ID + ",'" + pro_Descricao + "', " + pro_QtdEstoque + ", " + pro_Valor + "," + pro_Ativo + ")");
            cldBancoDados.ExecutaComando(query.ToString());
        }

        public DataSet Listar(string filtro)
        {
            StringBuilder query = new StringBuilder();
            query.Append("  SELECT PRO_ID as Codigo,");
            query.Append("  PRO_DESCRICAO as Descricao,");
            query.Append("  PRO_QTDESTOQUE as Quantidade,");
            query.Append("  PRO_ATIVO as ATIVO");
            query.Append("  FROM Produto");

            if (!filtro.Equals(string.Empty))
            {
                query.Append("  WHERE PRO_DESCRICAO like '%" + filtro + "%'");
            }

            return cldBancoDados.RetornaDataSet(query.ToString());
        }

        public OleDbDataReader ListarProduto(int codigo)
        {
            StringBuilder query = new StringBuilder();
            query.Append("  SELECT PRO_ID,");
            query.Append("  CAT_ID,");
            query.Append("  PRO_DESCRICAO,");
            query.Append("  PRO_QTDESTOQUE,");
            query.Append("  PRO_VALOR,");
            query.Append("  PRO_ATIVO");
            query.Append("  FROM Produto");
            query.Append("  WHERE PRO_ID = " + codigo);
            return cldBancoDados.RetornaDataReader(query.ToString());
        }

    }
}
