using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CAIXA.Codigos.Controle
{
    public class Conexao
    {
        public MySqlConnection conexao;

        public Conexao ()
        {
            conexao = new MySqlConnection("server=localhost;user id=root;database=contabancaria;pwd=NL5KQMOJ");
        }

        public bool AbriConexao()
        {
            try
            {
                conexao.Open();
                return true;
            }catch(MySqlException ex)
            {
                return false;
                throw ex;
            
            }
        }
        public bool fecharConexao()
        {
            try
            {
                conexao.Close();
                return true;
            }catch(MySqlException ex)
            {
                return false;
                throw ex;
            }
        }
    }
}
