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
        public int inteiro;
       
        
        public Saque1()
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

                var senha = Int32.Parse(txtSenha.Text);
                MySqlCommand objCmd = new MySqlCommand("select senha,id_cliente,sum(valor)  from cliente inner join movimentacao on id_cliente=id_mov where senha ='" + senha + "'", objcon);
                objCmd.Parameters.Clear();
               
                //executa comando
                objCmd.CommandType = CommandType.Text;
                //recebe o conteudo do banco
                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();
                
                //recebe o valor informado pelo usuario para adicionar no banco
                double saqueTxt = double.Parse(txtValor.Text);
                string tipo = "S";
                //recebe os valores do banco
                var senhaBd = dr.GetInt32(0);
                int ID_CLIENTE = dr.GetInt32(1);
                double saldoBd = dr.GetDouble(2);

                dr.Close();
                try
                {
                    if (senha.Equals(senhaBd))
                    {
                        if (saldoBd >= saqueTxt)
                        {
                            objCmd.Parameters.Clear();
                            saqueTxt = saqueTxt * -1;
                            objCmd.CommandText = "insert into movimentacao(id_mov,valor,tipo,data)values(?,?,?,now())";

                            objCmd.Parameters.Add("@id_mov", MySqlDbType.Int32).Value = ID_CLIENTE;
                            objCmd.Parameters.Add("@valor", MySqlDbType.Double).Value = saqueTxt;
                            objCmd.Parameters.Add("@tipo", MySqlDbType.String).Value = tipo;
                            objCmd.ExecuteNonQuery();
                            
                            lblMensagem.Text = "Saque realizado";
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
                lblMensagem.Text = "Senha Inválida";
            }

            await Task.Delay(2000);
            this.Close();
        }
        //-------------------------------------------------
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
            {
                MessageBox.Show("Saque não efetuado");
                 //lblMensagem.Text = "Saque não Efetuado";
            }
            
        }

             private void txtValor_TextChanged(object sender, EventArgs e)
        {
            moeda(ref txtValor);
            try
            {
                double d = Convert.ToDouble(txtValor.Text);
            }
            catch (Exception)
            {
                lblMensagem.Text = "Digite novamente";
                txtValor.Text = "";
            }
        }
                  
   

    private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //evitando a entrada de caracteres não numéricos
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValor_TextChanged_1(object sender, EventArgs e)
        {
            moeda(ref txtValor);
            try
            {
                double d = Convert.ToDouble(txtValor.Text);
            }
            catch (Exception)
            {
                lblMensagem.Text = "Digite novamente";
                txtValor.Text = "";
            }
        }
    }
  }