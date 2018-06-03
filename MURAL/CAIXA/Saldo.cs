using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAIXA
{
    public partial class Saldo : Form
    {
        private Form formMenu;
        public Saldo(Form formMenu)
        {
            this.formMenu = formMenu;
            InitializeComponent();
            LeitorDeTexto.Instancia.Falar( "Você escolheu saldo \n Digite sua senha e tecle confirme");
        }    

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            formMenu.Show();
        }
        
         private async void btnConfirme_Click(object sender, EventArgs e)
        {
      
            try
            {
                //recebendo a senha digitada pelo usuario e convertendo pra int
                var senhaT = (txtSenha.Text);

                if (senhaT.Equals(ContaCliente.Instancia.Senha))
                {

                    DataTable dadosSaldo = AcessoDados.Instancia.BuscarDados("SELECT SUM(valor) AS VALOR FROM movimentacao WHERE id_mov = "
                        + ContaCliente.Instancia.IdCliente);
                    var valorBD = (double)dadosSaldo.Rows[0]["VALOR"];
                    if (valorBD > 0)
                    {
                        label3.Text = "R$ " + valorBD.ToString("N");
                        LeitorDeTexto.Instancia.Falar("O seu saldo é de: " + label3.Text);
                        await Task.Delay(2000);
                        //limpaTxt();                        
                        txtSenha.Text = "";
                        //lblMensagem.Text = "Retire seu cartão";
                    }
                    else
                    {
                        lblMensagem.Text = "Você não tem saldo";
                    }
                }
                else
                {
                    LeitorDeTexto.Instancia.Falar(" Número da conta ou senha inválidos");
                    lblMensagem.Text = "Número da conta ou senha inválidos";
                }
            }
            catch
            {
                lblMensagem.Text = "Senha inválida";
                
            }
            await Task.Delay(3000);
            
            this.Close();
            LeitorDeTexto.Instancia.Falar("Digite o número para a opção desejada");
            formMenu.Show();
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
