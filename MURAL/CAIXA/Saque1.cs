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
        private Form formMenu;
        
        public Saque1(Form formMenu)
        {
            this.formMenu = formMenu;
            InitializeComponent();            
            LeitorDeTexto.Instancia.Falar("Você escolheu saque \n Por favor digite sua senha e o valor do saque");
        }

        private async void btnValor_Click(object sender, EventArgs e)
        {
            try
            {
                //recebendo a senha do usuário e convertendo para int 
                var senhaT = (txtSenha.Text);
                if (senhaT.Equals(ContaCliente.Instancia.Senha))
                {
                    double saqueTxt = double.Parse(textValor.Text);
                    DataTable dadosSaldo = AcessoDados.Instancia.BuscarDados("SELECT SUM(valor) as VALOR FROM movimentacao WHERE id_mov = " + ContaCliente.Instancia.IdCliente);
                    
                    var valorBD = (double)dadosSaldo.Rows[0]["VALOR"];
                    


                    if (saqueTxt <= 1 || saqueTxt == 3) {
                        lblMensagem.Text = "Esse valor não pode ser sacado!!";
                        LeitorDeTexto.Instancia.Falar(lblMensagem.Text);
                    }
                    else { 
                        if ((valorBD - saqueTxt) <= 0)
                        {
                            lblMensagem.Text = "Você não tem saldo suficiente!";
                            LeitorDeTexto.Instancia.Falar(lblMensagem.Text);

                            
                        }
                        else
                        {
                            MySqlParameter idCliente = new MySqlParameter
                            {
                                ParameterName = "@id_mov",
                                MySqlDbType = MySqlDbType.Int32,
                                Value = ContaCliente.Instancia.IdCliente
                            };

                            MySqlParameter valorSaque = new MySqlParameter
                            {
                                ParameterName = "@valor",
                                MySqlDbType = MySqlDbType.Double,
                                Value = saqueTxt * -1
                            };

                            string tipo = "S";
                            MySqlParameter tipoMovimento = new MySqlParameter
                            {
                                ParameterName = "@tipo",
                                MySqlDbType = MySqlDbType.String,
                                Value = tipo
                            };
                            AcessoDados.Instancia.ExecutarComando(
                                "insert into movimentacao(id_mov,valor,tipo,data) values (?,?,?,now())",
                                 idCliente, valorSaque, tipoMovimento
                            );

                            lblMensagem.Text = "Saque realizado";
                            LeitorDeTexto.Instancia.Falar("Saque efetuado no valor de R$ " + saqueTxt.ToString("N2"));
                            
                        }

                    }
                }else
                {
                    LeitorDeTexto.Instancia.Falar("Número da conta ou senha inválidos");
                    lblMensagem1.Text = "Número da conta ou senha inválidos";
                }
            }
            catch
            {
                lblMensagem1.Text = "Ocorreu uma falha ao efetuar o saque, tente novamente!";
                LeitorDeTexto.Instancia.Falar(lblMensagem1.Text);
                await Task.Delay(3000);
            }
            finally
            {
                await Task.Delay(3000);
                this.Close();
                formMenu.Show();
            }
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
            {
                MessageBox.Show("Saque não efetuado");
                 
            }
            
        }                
                
            private void txtValor_TextChanged(object sender, EventArgs e)
       {
           moeda(ref textValor);
           try
           {
               double d = Convert.ToDouble(textValor.Text);
           }
           catch (Exception)
           {
               lblMensagem.Text = "Digite novamente";
               textValor.Text = "";
           }
       }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            formMenu.Show();
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
            moeda(ref textValor);
            try
            {
                double d = Convert.ToDouble(textValor.Text);
            }
            catch (Exception)
            {
                lblMensagem.Text = "Digite novamente";
                textValor.Text = "";
            }
        }       

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }     
    }
}