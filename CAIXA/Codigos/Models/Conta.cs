using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CAIXA.Codigos.Controle;

namespace CAIXA.Codigos.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public string Saldo { get; set; }
        public string NumConta { get; set; }

        public Conta() { }

        public Conta(int Id,string Saldo,string numConta)
        {
            this.Id = Id;
            this.Saldo = Saldo;
            this.NumConta = NumConta;
        }
       // public static adicionarConta() { }
        //public static int buscaValor() { }
        //public static int excluir() { }

        public static IList<Conta> Buscar(MySqlConnection connection, string saldo, string NumConta)
        {

        
            List<Conta> lista = new List<Conta>();

            
            MySqlCommand comando = new MySqlCommand("select id,saldo,numConta from conta");
            MySqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Conta pconta = new Conta();
                pconta.Id = reader.GetInt32(0);
                pconta.Saldo = reader.GetString(2);
                pconta.NumConta = reader.GetString(3);

                lista.Add(pconta);

            }
            return lista;
        }


    }
    



}
