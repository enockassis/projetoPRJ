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
    public partial class Saque : Form
    {
        public Saque()
        {
            InitializeComponent();
        }      

        private void btnNovaOp_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Saque_Load(object sender, EventArgs e)
        {

        }

        private void tbtnNovaOp_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void btnSai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
