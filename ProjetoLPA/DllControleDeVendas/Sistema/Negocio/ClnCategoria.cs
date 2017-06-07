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
    public class ClnCategoria
    {
        private int cat_ID;

        public int ID
        {
            get { return cat_ID; }
            set { cat_ID = value; }
        }

        private string cat_Descricao;

        public string Descricao
        {
            get { return cat_Descricao; }
            set { cat_Descricao = value; }
        }

        private CldBancoDados cldBancoDados = new CldBancoDados();

        public void Alterar()
        {
            StringBuilder query = new StringBuilder();
            query.Append("  UPDATE Categoria");
            query.Append("  SET");
            query.Append("  CAT_DESCRICAO = '" + cat_Descricao + "',");
            query.Append("  CAT_ID = " + cat_ID);
            query.Append("  WHERE CAT_ID = " + cat_ID);
            cldBancoDados.ExecutaComando(query.ToString());
        }

        public void Excluir(int codigo)
        {
            StringBuilder query = new StringBuilder();
            query.Append("  DELETE FROM Categoria");
            query.Append("  WHERE CAT_ID = " + codigo);
            cldBancoDados.ExecutaComando(query.ToString());
        }

        public void Gravar()
        {
            StringBuilder query = new StringBuilder();
            query.Append("  INSERT INTO Categoria");
            query.Append("  (");
            query.Append("  CAT_DESCRICAO");
            query.Append("  ) VALUES (");
            query.Append("  '" + cat_Descricao + "'");
            query.Append("  )");
            cldBancoDados.ExecutaComando(query.ToString());
        }


        public DataSet Listar(string filtro)
        {
            StringBuilder query = new StringBuilder();
            query.Append("  SELECT CAT_ID as Codigo, CAT_DESCRICAO as Descricao FROM Categoria");

            if (!filtro.Equals(string.Empty))
            {
                query.Append("  WHERE CAT_DESCRICAO like '%" + filtro + "%'");
            }

            return cldBancoDados.RetornaDataSet(query.ToString());
        }

        public OleDbDataReader ListarCategoria(int codigo)
        {
            StringBuilder query = new StringBuilder();
            query.Append("  SELECT CAT_DESCRICAO");
            query.Append("  FROM Categoria");
            query.Append("  WHERE CAT_ID = " + codigo);
            return cldBancoDados.RetornaDataReader(query.ToString());
        }

        public OleDbDataReader ListarCategorias()
        {
            StringBuilder query = new StringBuilder();
            query.Append("  SELECT CAT_DESCRICAO, CAT_ID");
            query.Append("  FROM Categoria");            
            return cldBancoDados.RetornaDataReader(query.ToString());
        }
    }
}
