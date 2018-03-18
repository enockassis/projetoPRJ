using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAIXA
{
    public partial class Saque1 : Form
    {

        /*public double valorInf;
        public String senha = "12345";
        double saldo = 2500;*/
        public Saque1()
        {
            InitializeComponent();
        }



        /* private void btnSenha_Click(object sender, EventArgs e)
         {
             String senhaInf = txtSenha.Text;
             if (senhaInf == senha)
             {
                 lblValor.Text = "Digite o Valor";
             }
             else
             {
                 lblValor.Text = "Digite a senha correta !!!";
                 txtValor.Visible = false;


                 lblMensagem.Text = "SENHA INVÁLIDA";
             }
         }*/

        private async void btnValor_Click(object sender, EventArgs e)
        {     /*       
            String senhaInf = txtSenha.Text; 
            Double valorInf;
            valorInf = Convert.ToDouble(txtValor.Text);

            if (senhaInf == senha)
            {
                lblValor.Text = "Digite o valor";
            }*/

            try
            {

                var deposito = 0;
                //passa a string de conexao
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=contabd;password=NL5KQMOJ");
                //abrindo a conexao
                objcon.Open();
                // MessageBox.Show("Conectado");

                var senha = Int32.Parse(txtSenha.Text);
                MySqlCommand objCmd = new MySqlCommand("select senha,saldo from cliente inner join conta on idConta=id where senha ='" + senha + "'", objcon);
                objCmd.Parameters.Clear();
                // objCmd.Parameters.Add("@senha", MySqlDbType.Int32).Value = txbDepSenha.Text;
                //objCmd.Parameters.Add("@saldo", MySqlDbType.Double).Value = deposito.ToString();
                //executa comando
                objCmd.CommandType = CommandType.Text;
                //recebe o conteudo do banco
                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();
                //recebe o saldo salvo no banco
                double saqueBd = dr.GetDouble(1);
                //recebe o valor informado pelo usuario para add no banco
                double saqueTxt = double.Parse(txtValor.Text);
                // subtracao do saldo informado pelo usuario  do banco
                double realizaSaque = saqueBd - saqueTxt;

                var senhaBd = dr.GetInt32(0);
                //var dataSaque = DateTime.Today();
                dr.Close();
                try
                {
                    if (senha.Equals(senhaBd))
                    {
                        if (saqueBd >= saqueTxt)
                        {
                            objCmd.Parameters.Clear();
                            objCmd.CommandText = ("update cliente inner join conta on idConta=id set saldo='" + realizaSaque + "',dataS = now() where senha = '" + senha + "'");

                            objCmd.ExecuteNonQuery();

                            // MessageBox.Show("Saque Realidado com Sucesso!");
                            lblMensagem.Text = "Saque realizado com sucesso";
                        }
                        else
                        {
                            lblMensagem.Text = "Saldo insuficiente";
                        }
                    }
                    else
                    {
                        lblMensagem.Text ="Senha invalida";
                    }
                }
                catch { }

                objcon.Close();
            }
            catch
            {
                MessageBox.Show("Nao conectado");
            }

            await Task.Delay(3000);
            this.Close();
        }
        /*
        public static void moeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;
            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);
                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);
                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            { }
            */
    
    //---------------------------------------------------------------------*/

    private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    /*
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            moeda(ref txtValor);
        }*/
    }
  }