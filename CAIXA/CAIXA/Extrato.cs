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
    
    public partial class Extrato : Form
    {
        String senha = "12345";
        double saldo = 2300;

        public Extrato()
        {
            InitializeComponent();
        }        

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            String senhaInf = txtSenha.Text;
            if(senhaInf == senha)
            {
                lblPress.Text = "Imprimindo ...";
                lblMensagem.Text = "Aguarde a Impressão";
            }
            else
            {
                lblMensagem.Text = "SENHA INVÁLIDA";
            }
        }
    }
}
