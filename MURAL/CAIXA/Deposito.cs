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
            LeitorDeTexto.Instancia.Falar("Digite sua senha e o valor");           
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

                    //condição para verifica se o valor esta de acordo para o deposito 
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

                            await Task.Delay(3000);
                            this.Close();
                            formMenu.Show();
                    }
                       
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

                //passa a string de conexao
                // MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=contabancaria;password=NL5KQMOJ");
                //abrindo a conexao
                //objcon.Open();

                //recebe a senha que foi informada pelo usuario no forma deposito
                //var senha = Int32.Parse(txtSenhaD.Text);
                
               // MySqlCommand objCmd = new MySqlCommand("select senha,id_cliente from cliente  where senha ='" + senha + "'", objcon);
                //limpa os paramentros
               // objCmd.Parameters.Clear(); 

          
                //executa comando
                //objCmd.CommandType = CommandType.Text;
               
                //recebe o conteudo do banco
               // MySqlDataReader dr;
               // dr = objCmd.ExecuteReader();

                //dr.Read();
                //senhaBd recebe a senha que esta salva no banco
                //var senhaBd = dr.GetInt32(0);
                //recebe o saldo salvo no banco                
                //int ID_CLIENTE = dr.GetInt32(1);
                //recebe o valor informado pelo usuario para add no banco
                //double depoTxt = double.Parse(txtSenhaD.Text);
                //double depoTxt = double.Parse(txtValor.Text);
                //string tipo = "D";

                
               // if (senha.Equals(senhaBd))
               // {
               ///       try
                        
                //        {
                        
                    //    depoTxt = System.Math.Floor(depoTxt);
                   //     dr.Close();
                   //     objCmd.Parameters.Clear();
                        //objCmd.CommandText = "update cliente inner join conta on idConta=id set saldo='" + atualizarSaldo + "', dataD = now()  where senha = '" + senha + "'";
                    //    objCmd.CommandText = "insert into movimentacao(id_mov,valor,tipo,data)values(?,?,?,now())";

                   //     objCmd.Parameters.Add("@id_mov", MySqlDbType.Int32).Value = ID_CLIENTE;
                   //     objCmd.Parameters.Add("@valor", MySqlDbType.Double).Value = depoTxt;
                  //      objCmd.Parameters.Add("@tipo", MySqlDbType.String).Value = tipo;
                       
                   //    objCmd.ExecuteNonQuery();
                  //      lblMensagem.Text = "Depósito efetuado no valor de "+ depoTxt + "reais";                       
                   //     LeitorDeTexto.Instancia.Falar(lblMensagem.Text);
                    //    lblMensagem.Text = "Depósito Realizado!";
                    //    await Task.Delay(3000);
                  //  }
                     //   catch (MySqlException ex)
                   //     {
                   //         lblMensagem.Text = "Deposito não realizado";                        
                  //      }
                    
             //   }
             //   }catch(MySqlException ex)
              //      {
                 //       lblMensagem.Text = "Senha Inválida";                
              //      }

             //   await Task.Delay(3000);
            //    this.Close();

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
