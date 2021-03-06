﻿using DllControleDeVendas.Sistema.Globais;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllControleDeVendas.Sistema.Negocio
{
    public class ClnCliente
    {
        private string cli_Bairro;

        public string Bairro
        {
            get { return cli_Bairro; }
            set { cli_Bairro = value; }
        }

        private string cli_Cep;

        public string CEP
        {
            get { return cli_Cep; }
            set { cli_Cep = value; }
        }

        private string cli_Cidade;

        public string Cidade
        {
            get { return cli_Cidade; }
            set { cli_Cidade = value; }
        }

        private string cli_CNPJCPF;

        public string CNPJCPF
        {
            get { return cli_CNPJCPF; }
            set { cli_CNPJCPF = value; }
        }

        private DateTime cli_dataCadastro;

        public DateTime DataCadastro
        {
            get { return cli_dataCadastro; }
            set { cli_dataCadastro = value; }
        }

        private string cli_Email;

        public string Email
        {
            get { return cli_Email; }
            set { cli_Email = value; }
        }

        private string cli_Fones;

        public string Fones
        {
            get { return cli_Fones; }
            set { cli_Fones = value; }
        }

        private int cli_ID;

        public int ID
        {
            get { return cli_ID; }
            set { cli_ID = value; }
        }

        private string cli_Logradouro;

        public string Logradouro
        {
            get { return cli_Logradouro; }
            set { cli_Logradouro = value; }
        }

        private string cli_nome;

        public string Nome
        {
            get { return cli_nome; }
            set { cli_nome = value; }
        }

        private string cli_UF;

        public string UF
        {
            get { return cli_UF; }
            set { cli_UF = value; }
        }

        private CldBancoDados cldBancoDados = new CldBancoDados();

        public void Alterar()
        {
            StringBuilder query = new StringBuilder();
            query.Append("  UPDATE Cliente");
            query.Append("  SET");
            query.Append("  CLI_NOMERAZAO = '" + cli_nome + "',");
            query.Append("  CLI_CNPJCPF = '" + cli_CNPJCPF + "',");
            query.Append("  CLI_LOGRADOURO = '" + cli_Logradouro + "',");
            query.Append("  CLI_BAIRRO = '" + cli_Bairro + "',");
            query.Append("  CLI_CIDADE = '" + cli_Cidade + "',");
            query.Append("  CLI_UF = '" + cli_UF + "',");
            query.Append("  CLI_CEP = '" + cli_Cep + "',");
            query.Append("  CLI_EMAIL = '" + cli_Email + "',");
            query.Append("  CLI_FONES = '" + cli_Fones + "',");
            query.Append("  CLI_DATACADASTRO = '" + cli_dataCadastro + "'");
            query.Append("  WHERE CLI_ID=" + cli_ID);
            cldBancoDados.ExecutaComando(query.ToString());
        }

        public void Excluir(int codigo)
        {
            StringBuilder query = new StringBuilder();
            query.Append("  DELETE FROM Cliente WHERE CLI_ID = " + codigo);
            cldBancoDados.ExecutaComando(query.ToString());
        }

        public void Gravar()
        {
            StringBuilder query = new StringBuilder();
            query.Append("  INSERT INTO Cliente");
            query.Append("  (");
            query.Append("  CLI_NOMERAZAO,");
            query.Append("  CLI_CNPJCPF,");
            query.Append("  CLI_LOGRADOURO,");
            query.Append("  CLI_BAIRRO,");
            query.Append("  CLI_CIDADE,");
            query.Append("  CLI_UF,");
            query.Append("  CLI_CEP,");
            query.Append("  CLI_EMAIL,");
            query.Append("  CLI_FONES,");
            query.Append("  CLI_DATACADASTRO");

            query.Append("  ) VALUES (");

            query.Append("  '" + cli_nome + "'");
            query.Append("  , '" + cli_CNPJCPF + "'");
            query.Append("  , '" + cli_Logradouro + "'");
            query.Append("  , '" + cli_Bairro + "'");
            query.Append("  , '" + cli_Cidade + "'");
            query.Append("  , '" + cli_UF + "'");
            query.Append("  , '" + cli_Cep + "'");
            query.Append("  , '" + cli_Email + "'");
            query.Append("  , '" + cli_Fones + "'");
            query.Append("  , '" + cli_dataCadastro + "'");
            query.Append(")");

            cldBancoDados.ExecutaComando(query.ToString());
        }

        public DataSet Listar(string filtro)
        {
            StringBuilder query = new StringBuilder();
            query.Append("  SELECT CLI_ID as Codigo,");
            query.Append("  CLI_NOMERAZAO as Nome,");
            query.Append("  CLI_CNPJCPF as CPF");
            query.Append("  FROM Cliente");

            if (!filtro.Equals(string.Empty))
            {
                query.Append("  WHERE CLI_NOMERAZAO like '%" + filtro + "%'");
            }

            return cldBancoDados.RetornaDataSet(query.ToString());
        }


        public OleDbDataReader ListarCliente(int codigo)
        {
            StringBuilder query = new StringBuilder();
            query.Append("  SELECT CLI_ID,");
            query.Append("  CLI_NOMERAZAO,");
            query.Append("  CLI_CNPJCPF,");
            query.Append("  CLI_LOGRADOURO,");
            query.Append("  CLI_BAIRRO,");
            query.Append("  CLI_CIDADE,");
            query.Append("  CLI_UF,");
            query.Append("  CLI_CEP,");
            query.Append("  CLI_EMAIL,");
            query.Append("  CLI_FONES,");
            query.Append("  CLI_DATACADASTRO");
            query.Append("  FROM Cliente");
            query.Append("  WHERE CLI_ID = " + codigo);

            try
            {
                return cldBancoDados.RetornaDataReader(query.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
