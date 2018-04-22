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
    public partial class FormMenu : Form
    {
        private Form formConta;
        public FormMenu(Form formConta)
        {
            this.formConta = formConta;
            InitializeComponent();
            
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                Saldo sal = new Saldo(this);
                
                sal.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Deposito dep = new Deposito(this);
            dep.Show();
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
             Saque1 saq = new Saque1(this);
            saq.Show();
        }     
    

        private void button4_Click(object sender, EventArgs e)
        {
            Extrato ext = new Extrato();
            ext.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            LeitorDeTexto.Instancia.Falar((string)btn.Tag);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            LeitorDeTexto.Instancia.Falar("Por favor, escolha uma das opções");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            formConta.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // this.Close();
            Application.Exit();
        }
    }
}
