using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIXA
{
    public class AcessoDados
    {
        private string _stringConexao;
        private MySqlConnection _conexao;

        private static readonly AcessoDados instancia = new AcessoDados();

        private AcessoDados()
        {
            this._stringConexao = ConfigurationManager.ConnectionStrings["contabancariaConnectionString"].ConnectionString;
            this._conexao = new MySqlConnection(_stringConexao);
        }

        public static AcessoDados Instancia
        {
            get
            {
                return instancia;
            }
        }

        public string StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }

        public MySqlConnection Conexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }
        }

        public DataTable BuscarDados(string comando)
           
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comando;
            cmd.Connection = Conexao;

            DataSet ds = new DataSet();

            cmd.Connection.Open();

            ds.Load(cmd.ExecuteReader(), LoadOption.OverwriteChanges, "Tabela");

            cmd.Connection.Close();

            return ds.Tables["Tabela"];
        }

        public void ExecutarComando(string comando)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comando;
            cmd.Connection = Conexao;

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
        }

        public void ExecutarComando(string comando, params MySqlParameter[] parametros)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = comando;
            cmd.Connection = Conexao;
            foreach (var parametro in parametros)
            {
                cmd.Parameters.Add(parametro);
            }

            cmd.Connection.Open();

            cmd.ExecuteNonQuery();

            cmd.Connection.Close();
        }

    }
}
