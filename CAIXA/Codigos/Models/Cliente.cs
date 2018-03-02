using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIXA.Codigos.Models
{
    public class Cliente
    {
        public int Idc { get; set; }
        public string NomeTitula { get; set; }
        public int Senha { get; set; }
        public int IdConta { get; set; }

        public Cliente() { }
        public Cliente(int Idc, string nomeTitula, int senha, int idConta)
        {
            this.Idc = Idc;
            this.NomeTitula = nomeTitula;
            this.Senha = senha;
            this.IdConta = idConta;
        }
        public static IList<Cliente> Buscar(MySqlConnection connection, int Idc, string nomeTitula, int senha, int idConta, int NumConta)
        {
            List<Cliente> lista = new List<Cliente>();
            MySqlCommand comando = new MySqlCommand(string.Format("SELECT idCliente,nomeCliente,senha,idConta from cliente,conta where idConta= id", Idc, nomeTitula, senha, idConta), connection);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Cliente pcliente = new Cliente();
                pcliente.Idc = reader.GetInt32(0);
                pcliente.NomeTitula = reader.GetString(1);
                pcliente.Senha = reader.GetInt32(2);
                pcliente.IdConta = reader.GetInt32(3);

                lista.Add(pcliente);

            }
            return lista;
        }

        public static Cliente BuscarSenha(MySqlConnection connection, int senha)
        {
            Cliente pcliente = new Cliente();

            MySqlCommand comando = new MySqlCommand(string.Format("SELECT senha from cliente, conta join idConta=id where senha ='" + senha + "", senha), connection);
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {

                pcliente.Idc = reader.GetInt32(0);
               // pcliente.NomeTitula = reader.GetString(1);
                pcliente.Senha = reader.GetInt32(2);
                //pcliente.IdConta = reader.GetInt32(3);


            }
            return pcliente;

        }

    }
}
        /*
        public bool verificarLogin( String senha)
        {
        bool status = false;
        int retorno;
        var conn = new MySqlConnection(strCon);
        String SQL = "select count(*) from cliente where  senha='"+senha+"'";
        MySqlCommand cmd = new MySqlCommand(SQL, conn);
        conn.Open();

        //crie uma variavel do tipo <MySqlDataReader>
        MySqlDataReader mySqlDreader;

        //Atribua a esta variavel o datareader retornado do command
        mySqlDreader = cmd.EndExecuteReader();

        //Agora basta verificar o método <IsDBNull> do seu <MySqlDataReader>
        //Eu particularmente uso a seguinte forma:
        // status = !mySqlDreader.IsDBNull


        if (!mySqlDreader.IsDBNull)
	    status = true;

         return status;
        }*/
 