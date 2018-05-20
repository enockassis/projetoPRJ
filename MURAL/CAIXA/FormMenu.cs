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
            Extrato ext = new Extrato(this);
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
            LeitorDeTexto.Instancia.Falar("Digite o número para a opção desejada");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            formConta.Show();            
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
        
            Application.Exit();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
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
            }else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                Saque1 saq = new Saque1(this);
                saq.Show();
            }else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                Deposito dep = new Deposito(this);
                dep.Show();
            }else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                Extrato ext = new Extrato(this);
                ext.Show();
            }
            else if (e.KeyCode <=0 || e.KeyCode >= Keys.D5)
            { 
                LeitorDeTexto.Instancia.Falar("Digite 1 para saldo \n 2 para saque \n 3 para depósito \n ou 4 para extratoo!");
            }

        }

    }
}
