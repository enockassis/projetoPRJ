using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAIXA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //AcessoDados dados = new AcessoDados();

                //DataTable tabelaCliente = dados.BuscarDados(@"SELECT * FROM cliente");
                //DataTable tabelaConta = dados.BuscarDados(@"SELECT * FROM conta");
                //if (dados.BuscarDados("SELECT * FROM conta WHERE numConta = 13").Rows.Count > 0)
                //    throw new Exception("Já existe uma conta com este número");

                //dados.ExecutarComando(@"insert into conta (saldo, numConta) values (-100, ""13"")");
                lblSaldo sal = new lblSaldo();
                sal.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Deposito dep = new Deposito();
            dep.Show();
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
             Saque1 saq = new Saque1();
            saq.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Extrato ext = new Extrato();
            ext.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
