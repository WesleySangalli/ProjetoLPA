using DllControleDeVendas.Sistema.Globais;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllControleDeVendas.Sistema.Negocio
{
    class ClnCategoria
    {
        private int _cat_ID;

        public int cat_ID
        {
            get { return _cat_ID; }
            set { _cat_ID = value; }
        }

        private int _cat_Descricao;

        public int cat_Descricao
        {
            get { return _cat_Descricao; }
            set { _cat_Descricao = value; }
        }

        private CldBancoDados cldBancoDados = new CldBancoDados();

        public void Alterar()
        {
            StringBuilder query = new StringBuilder();
            query.Append("  UPDATE Categoria");
            query.Append("  SET");
            query.Append("  CAT_DESCRICAO = '" + cat_Descricao + "'");
            query.Append("  CAT_ID = " + cat_ID);
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


        public void Listar(string filtro)
        {
            StringBuilder query = new StringBuilder();
            query.Append("  SELECT CAT_ID as Codigo, CAT_DESCRICAO as Descricao FROM Categoria");
            query.Append("  FROM Categoria");

            if (!filtro.Equals(string.Empty))
            {
                query.Append("  WHERE CAT_DESCRICAO like '%" + filtro + "%'");
            }

            cldBancoDados.RetornaDataSet(query.ToString());
        }

        public OleDbDataReader ListarCategoria(int codigo)
        {
            StringBuilder query = new StringBuilder();
            query.Append("  SELECT CAT_DESCRICAO");
            query.Append("  FROM Categoria");
            query.Append("  WHERE CAT_ID = " + codigo);
            return cldBancoDados.RetornaDataReader(query.ToString());
        }
    }
}
