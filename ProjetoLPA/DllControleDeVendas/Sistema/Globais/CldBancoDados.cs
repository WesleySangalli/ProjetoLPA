using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DllControleDeVendas.Sistema.Globais
{
    class CldBancoDados
    {
        string stringConexao = Properties.Settings.Default.Conexao;

        private OleDbConnection AbreBanco()
        {
            OleDbConnection conexao = new OleDbConnection();
            conexao.ConnectionString = stringConexao;
            conexao.Open();
            return conexao;
        }

        private void FechaBanco(OleDbConnection conexao)
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

        public void ExecutaComando(string query)
        {
            OleDbConnection conexao = new OleDbConnection();
            try
            {
                conexao = this.AbreBanco();
                OleDbCommand comando = new OleDbCommand();

                comando.CommandText = query;
                comando.CommandType = CommandType.Text;
                comando.Connection = conexao;
                comando.ExecuteNonQuery();
            }catch(Exception e)
            {
                throw e;
            }
            finally
            {
                this.FechaBanco(conexao);
            }
        }

        public int ExecutaComandoRetorno(string query)
        {
            OleDbConnection conexao = new OleDbConnection();
            OleDbDataReader reader;

            try
            {
                conexao = this.AbreBanco();
                OleDbCommand comando = new OleDbCommand();

                comando.CommandText = query;
                comando.CommandType = CommandType.Text;
                comando.Connection = conexao;
                comando.ExecuteNonQuery();

                comando.CommandText = "Select @@Identity";
                reader = comando.ExecuteReader();
                reader.Read();

                return (int)reader[0];
            }catch(Exception e)
            {
                throw e;
            }
            finally
            {
                this.FechaBanco(conexao);
            }
        }

        public DataSet RetornaDataSet(string query)
        {
            OleDbConnection conexao = new OleDbConnection();
            try
            {
                conexao = this.AbreBanco();
                OleDbCommand comando = new OleDbCommand();

                comando.CommandText = query;
                comando.CommandType = CommandType.Text;
                comando.Connection = conexao;
                comando.ExecuteNonQuery();


                OleDbDataAdapter adaptador = new OleDbDataAdapter();
                // ACHO QUE FALTA ALGO AQUI!
                DataSet dataSetRetorno = new DataSet();

                // COM MAGICA??
                adaptador.Fill(dataSetRetorno);
                return dataSetRetorno;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.FechaBanco(conexao);
            }
        }

        public OleDbDataReader RetornaDataReader(string query)
        {
            OleDbConnection conexao = new OleDbConnection();
            try
            {
                conexao = this.AbreBanco();
                OleDbCommand comando = new OleDbCommand();

                comando.CommandText = query;
                comando.CommandType = CommandType.Text;
                comando.Connection = conexao;
                return comando.ExecuteReader();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.FechaBanco(conexao);
            }
        }
    }
}
