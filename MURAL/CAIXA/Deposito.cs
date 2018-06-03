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

        public int inteiro;
        
        private Form  formMenu;

        public Deposito(Form formMenu )
        {
            this.formMenu = formMenu;
            InitializeComponent();           
            LeitorDeTexto.Instancia.Falar("Você escolheu depósito \n Digite sua senha e o valor");           
        }       
       
    private async void btnValor_Click(object sender, EventArgs e)
        {
                try
                {
                    //recebendo a senha do usuário e convertendo-a para int
                    var senhaT = (txtSenhaD.Text);
                    if (senhaT.Equals(ContaCliente.Instancia.Senha))
                    {
                        double depositoTxt = double.Parse(txtValor.Text);

                        DataTable dadosDeposito = AcessoDados.Instancia.BuscarDados("Select SUM(valor) as Valor FROM movimentacao where id_mov = " + ContaCliente.Instancia.IdCliente);
                        var valorBD = (double)dadosDeposito.Rows[0]["VALOR"];

                        //condição para verificar se o valor está de acordo para o depósito 
                        if (depositoTxt <= 1 || depositoTxt == 3)
                        {
                            lblMensagem.Text = "Esse valor não pode ser depositado!";
                            LeitorDeTexto.Instancia.Falar(lblMensagem.Text);
                            await Task.Delay(3000);
                            this.Close();
                            formMenu.Show();
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
                                Value = depositoTxt
                            };

                            string tipo = "D";

                            MySqlParameter tipoMovimento = new MySqlParameter
                            {
                                ParameterName = "@tipo",
                                MySqlDbType = MySqlDbType.String,
                                Value = tipo
                            };

                            AcessoDados.Instancia.ExecutarComando(
                                "insert into movimentacao(id_mov,valor, tipo,data) values(?,?,?,now())",
                                idCliente, valorSaque, tipoMovimento
                                );

                            lblMensagem.Text = "Depósito realizado";
                            LeitorDeTexto.Instancia.Falar("Depósito efetuado no valor de  R$ " + depositoTxt.ToString("N2"));

                            await Task.Delay(5000);
                            this.Close();
                        LeitorDeTexto.Instancia.Falar("Digite o número para a opção desejada");
                        formMenu.Show();
                        }

                }else
                {
                    LeitorDeTexto.Instancia.Falar("Número da conta ou senha inválidos");
                    lblMensagem1.Text = "Número da conta ou senha inválidos";
                }
                }
                catch
                {
                    lblMensagem1.Text = "Ocorreu uma falha ao efetuar o depósito, tente novamente !!";
                    LeitorDeTexto.Instancia.Falar(lblMensagem1.Text);
                    await Task.Delay(3000);
                    this.Close();
                    formMenu.Show();
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

        private void txtSenhaD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      
    }       
 }
