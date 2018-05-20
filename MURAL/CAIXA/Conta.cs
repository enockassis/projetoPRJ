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
    public partial class Conta : Form
    {

        public Conta()
        {
            InitializeComponent();
            lblMensagem1.Text = "Se necessitar de ajuda, coloque o fone de ouvido para receber instruções";

        }
      
        private async void btnConfirme_Click(object sender, EventArgs e)
        {
           


            if (txtConta.Text == "" || txtSenha.Text == "")
            {
                lblMensagem.Text = "Digite o número de sua conta e a sua senha!";
                LeitorDeTexto.Instancia.Falar(lblMensagem.Text);
                txtConta.Focus();
                await Task.Delay(3000);
                Conta conta = new Conta();
                conta.Show();
            }
            else
            {
                DataTable dadosConta = AcessoDados.Instancia.BuscarDados("select id_cliente from cliente where id_cliente = " + txtConta.Text + " and senha = '" + txtSenha.Text + "'");
                if (dadosConta == null || dadosConta.Rows.Count == 0)
                {

                    lblMensagem.Text = "Número da conta ou senha inválidos!";
                    LeitorDeTexto.Instancia.Falar(lblMensagem.Text);
                    await Task.Delay(3000);
                    Conta conta = new Conta();
                    conta.Show();
                }
              

                else
                {
                   
                    ContaCliente.Instancia.IdCliente = int.Parse(txtConta.Text);
                    ContaCliente.Instancia.Senha = (txtSenha.Text);
                    txtSenha.Text = "";
                    txtConta.Text = "";
                    lblMensagem.Text = "";
                    FormMenu form = new FormMenu(this);
                    form.Show();
                    this.Hide();

                }
            }

        }
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            FormMenu form = new FormMenu(this);
            form.Show();
            this.Hide();
        }

        private void txtConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
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
           

