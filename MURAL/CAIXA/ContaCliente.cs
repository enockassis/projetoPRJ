using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIXA
{
    public sealed class ContaCliente
    {
        private int idCliente;
        private string senha;

        private static readonly ContaCliente instancia = new ContaCliente();

        private ContaCliente()
        {
            
        }

        public static ContaCliente Instancia
        {
            get
            {
                return instancia;
            }
        }

        public int IdCliente
        {
            get
            {
                return idCliente;
            }

            set
            {
                idCliente = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }
    }
}
