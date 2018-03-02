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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Saldo sal = new Saldo();
            sal.Show();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            Deposito dep = new Deposito();
            dep.Show();
        }
     
        private void button2_Click(object sender, EventArgs e)
        {
            Saque saq = new Saque();
            saq.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Extrato ext = new Extrato();
            ext.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
