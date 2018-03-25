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
       
        String senhaInf;
        

        public Deposito()
        {
            InitializeComponent();  
                     
        }       
       
    private async void btnValor_Click(object sender, EventArgs e)
        {
            
            try
            {

                //passa a string de conexao
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=contabancaria;password=NL5KQMOJ");
                //abrindo a conexao
                objcon.Open();
                                
                //recebe a senha que foi informada pelo usuario no forma deposito
                var senha = Int32.Parse(txtSenhaD.Text);
                MySqlCommand objCmd = new MySqlCommand("select senha,id_cliente from cliente  where senha ='" + senha + "'", objcon);
                //limpa os paramentros
                objCmd.Parameters.Clear(); 

          
                //executa comando
                objCmd.CommandType = CommandType.Text;
               
                //recebe o conteudo do banco
                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();

                dr.Read();
                //senhaBd recebe a senha que esta salva no banco
                var senhaBd = dr.GetInt32(0);
                //recebe o saldo salvo no banco                
                int ID_CLIENTE = dr.GetInt32(1);
                //recebe o valor informado pelo usuario para add no banco
                //double depoTxt = double.Parse(txtSenhaD.Text);
                double depoTxt = double.Parse(txtValor.Text);
                string tipo = "D";

                
                if (senha.Equals(senhaBd))
                {
                        try
                        {
                        dr.Close();
                        objCmd.Parameters.Clear();
                        //objCmd.CommandText = "update cliente inner join conta on idConta=id set saldo='" + atualizarSaldo + "', dataD = now()  where senha = '" + senha + "'";
                        objCmd.CommandText = "insert into movimentacao(id_mov,valor,tipo,data)values(?,?,?,now())";

                        objCmd.Parameters.Add("@id_mov", MySqlDbType.Int32).Value = ID_CLIENTE;
                        objCmd.Parameters.Add("@valor", MySqlDbType.Double).Value = depoTxt;
                        objCmd.Parameters.Add("@tipo", MySqlDbType.String).Value = tipo;
                        

                        objCmd.ExecuteNonQuery();
                        
                        lblMensagem.Text = "Depósito Realizado!";
                        }
                        catch (MySqlException ex)
                        {
                            lblMensagem.Text = "Deposito não realizado";
                        //MessageBox.Show("de" +ex);
                    }
                    
                }
                }catch(MySqlException ex)
                    {
                        lblMensagem.Text = "Senha Inválida";
                //MessageBox.Show("erro" + ex);
                    }

                await Task.Delay(2000);
                this.Close();

       }

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
                      lblMensagem.Text = "Erro ao digitar número";
                      txtValor.Text = "";
                  }                       
           }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtValor_TextChanged_1(object sender, EventArgs e)
        {
            moeda(ref txtValor);

            try
            {
                Double d = Convert.ToDouble(txtValor.Text);
            }
            catch (Exception)
            {
                lblMensagem.Text = "Erro ao digitar número";
                txtValor.Text = "";
            }


        }
    }       
 }
