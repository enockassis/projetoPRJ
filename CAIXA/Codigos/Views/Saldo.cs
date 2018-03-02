using CAIXA.Codigos.Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CAIXA.Codigos.Models;

namespace CAIXA
{
    public partial class Saldo : Form
    {
        Conexao conecao = new Conexao();
        public Saldo()
        {
            InitializeComponent();
            //Mensagem de voz
        }

        private void btnNovaOp_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
          /*  try
            { Cliente pcliente = new Cliente();
                var senhaT = Convert.ToInt32(txtSenha.Text);
                if (conecao.AbriConexao() == true)
                {
                   // pcliente.Senha= Cliente.BuscarSenha(conecao.conexao, senhaT);
                    if( pcliente.Senha == senhaT)
                    {

                    }
                }*/
            } /*catch () { }//https://www.youtube.com/watch?v=ZbsKL2y4kRw*/


            /*var saldotxt = double.Parse(tSaldo.ToString());
            var senhatxt = int.Parse(tnumConta.ToString());
            try
            {
                if (conecao.AbriConexao() == true)
                {
                    ListaConta(conecao.conexao,saldotxt, senhatxt);
                }
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        
        public void ListaConta(MySqlConnection connection, string saldo, string numConta)
        {
            dtConta.DataSource = Conta.Buscar(connection, saldo, numConta);
           // txtSaldo.Text = dtConta.ToString();
        }
        private void dtConta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
/*txtSenha.Text = dtConta.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSaldo.Text = dtConta.Rows[e.RowIndex].Cells[1].Value.ToString();
       */ }

        private void Saldo_Load(object sender, EventArgs e)
        {

            ListaConta(conecao.conexao,  txtSaldo.Text, txtSenha.Text );
           /* try
            {
                if (conecao.AbriConexao() == true)
                {
                    ListaConta(conecao.conexao, double.Parse(txtSaldo.Text), int.Parse(txtSenha.Text));
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }
    }
}
