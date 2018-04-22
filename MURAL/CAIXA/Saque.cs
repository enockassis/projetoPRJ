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
    public partial class Valor : Form
    {
        
        String senha = "1234";
        Double saldo = 1650;
        
        Double saque = 0;
        Double ValorInf = 0;

        public Valor()
        {
            InitializeComponent();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {            
            String senhaInf = txtSenha.Text;

            if (senhaInf == senha)
            {               
              //  lblValores.Text  = "Digite o valor";               
                Double ValorInf = Convert.ToDouble(txtSaque.Text);                              
            }            
            else if(senhaInf != senha)
            {
              //  lblValores.Text = "SENHA INVÁLIDA";
            }

        }       
        
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      

        private void btnValor_Click(object sender, EventArgs e)
        {
            ValorInf = Convert.ToDouble(txtSaque.Text);
        
            if(ValorInf <= saldo)
            {
                
                lblMensagem.Text = "Saque Realizado";
                saldo -= ValorInf;
            }
            else if(ValorInf > saldo)
            {
                lblMensagem.Text = "Saldo Insuficiente";
            }
        }

        private void Valor_Load(object sender, EventArgs e)
        {

        }
    }
}

