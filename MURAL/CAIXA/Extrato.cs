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
    
    public partial class Extrato : Form
    {
       
        public Extrato()
        {
            InitializeComponent();
            dtgExtrato.Visible = false;
            LeitorDeTexto.Instancia.Falar("Por favor digite sua senha");
        }        

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnSenha_Click(object sender, EventArgs e)
        {
            try
            {
                //passa a string de conexao
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=contabancaria;password=NL5KQMOJ");

                //abrindo a conexao
                objcon.Open();

                //recebendo a senha digitada pelo usuario e convertendo pra int
                var senhaT = Int32.Parse(txtSenha.Text);

                MySqlCommand objCmd = new MySqlCommand("select senha,nome,valor,tipo,data from cliente inner join movimentacao on id_cliente=id_mov where senha ='" + senhaT + "' order by(data)", objcon);
                // objCmd.Parameters.Clear();

                objCmd.CommandType = CommandType.Text;
                //recebe o conteudo do banco
                MySqlDataReader dr;

                DataTable dt = new DataTable();

                dt.Load(objCmd.ExecuteReader());
                
                dtgExtrato.DataSource = dt;
                
                dr = objCmd.ExecuteReader();
                dr.Read();
               
                try
                {
                    //retornando a senha do banco
                    var senhaBd = dr.GetInt32(0);

                    if (senhaT.Equals(senhaBd))
                    {
                        
                        //ocultando a coluna senha no datagridview
                        dtgExtrato.Columns["senha"].Visible = false;
                        //exibindo o datagridview
                       dtgExtrato.Visible = true;
                       dtgExtrato.AutoResizeRows();                                   
                       
                    }              
                }
                catch
                {
                    lblMensagem.Text = "Senha inválida";
                }
                dr.Close();
                objcon.Close();
            }
            catch
            {
                lblMensagem.Text=("Nao conectado");
            }
            await Task.Delay(30000);
            this.Close();
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dtgExtrato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }  
}
