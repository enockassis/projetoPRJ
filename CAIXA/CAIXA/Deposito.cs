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
    public partial class Deposito : Form
    {
        Double saldo = 2400;
        String senha = "12345";
        String senhaInf;

        public Deposito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtSenhaD.Focus();
            Select();

        }

        //________________________________________________________________________________
        /* private void txtValor_Leave(object sender, KeyPressEventArgs e)
         {
             txtValor.Text = Convert.ToDouble(txtValor.Text).ToString("C");
         }

         


     private void txtValor_Enter(object sender, EventArgs e)
         {
             String x = "";
             for (int i = 0; i < txtValor.Length - 1; i++)
             {
                 if ((txtValor.Text[] >= '0' &&
                     txtValor.Text[i] <= '9') ||
                         txtValor.Text[i] == ',')
             {
                 x += txtValor.Text[i];
             }

             txtValor.Text = x;
             txtValor.SelectAll();*/




        //________________________________________________________________________________

        private async void btnValor_Click(object sender, EventArgs e)
        {
            try
            {
                var deposito = 0;
                //passa a string de conexao
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=contabd;password=NL5KQMOJ");
                //abrindo a conexao
                objcon.Open();
                                //  MessageBox.Show("Conectado");
                //recebe a senha que foi informada pelo usuario no forma deposito
                var senha = Int32.Parse(txtSenhaD.Text);
                MySqlCommand objCmd = new MySqlCommand("select senha,saldo from cliente inner join conta on idConta=id where senha ='" + senha + "'", objcon);
                //limpa os paramentros
                objCmd.Parameters.Clear();

                //objCmd.Parameters.Add("@senha", MySqlDbType.Int32).Value = txtSenhaD.Text;
               // objCmd.Parameters.Add("@saldo", MySqlDbType.Double).Value = deposito.ToString();
               
                //executa comando
                objCmd.CommandType = CommandType.Text;
                //recebe o conteudo do banco
                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();

                //senhaBd recebe a senha que esta salva no banco
                var senhaBd = dr.GetInt32(0);
                //recebe o saldo salvo no banco
                double depoBd = dr.GetDouble(1);
                //recebe o valor informado pelo usuario para add no banco
                double depoTxt = double.Parse(txtSenhaD.Text);
                // soma o saldo informado pelo usuario e soma com o do banco
                double atualizarSaldo = depoBd + depoTxt;
                dr.Close();
                if (senha.Equals(senhaBd))
                {
                        try
                        {
                            
                            objCmd.Parameters.Clear();
                            objCmd.CommandText = "update cliente inner join conta on idConta=id set saldo='" + atualizarSaldo + "', dataD = now()  where senha = '" + senha + "'";
                       
                        objCmd.ExecuteNonQuery();

                            lblMensagem.Text = "Deposito Realidado com Sucesso!";
                        }
                        catch (MySqlException ex)
                        {
                            lblMensagem.Text = "Deposito nao realizado";
                        MessageBox.Show("de" +ex);
                        }
                                     
                }
                }catch { }

                await Task.Delay(3000);
                this.Close();

       }
        //evento para permite so numeros 
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
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

        }
        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            moeda(ref txtValor);
            try
            {
                Double d = Convert.ToDouble(txtValor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("erro ao digitar numero");
                txtValor.Text = "";
            }
        }*/
    }
}