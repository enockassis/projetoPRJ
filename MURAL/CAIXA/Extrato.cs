using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CAIXA
{

    public partial class Extrato : Form
    {

        
        private Form formMenu;
        public Extrato(Form formMenu) {
            this.formMenu = formMenu;
            InitializeComponent();
            dtgExtrato.Visible = false;
            LeitorDeTexto.Instancia.Falar("Você escolheu extrato \n Por favor digite sua senha e tecle confirme");
        }    


        private void btnSenha_Click(object sender, EventArgs e)
            
        {
            var senhaT = Int32.Parse(txtSenha.Text);

            try
            {
                //passa a string de conexao
                MySqlConnection objcon = new MySqlConnection("server=localhost;port=3306;User Id=root;database=contabancaria;password=NL5KQMOJ");

                //abrindo a conexao
                objcon.Open();

                MySqlCommand objCmd = new MySqlCommand("select senha,nome,valor,tipo,data from cliente inner join movimentacao on id_cliente=id_mov where senha ='" + senhaT + "' order by(data)", objcon);
                // objCmd.Parameters.Clear();

                objCmd.CommandType = CommandType.Text;
                //recebe o conteúdo do banco
                MySqlDataReader dr;

                DataTable dt = new DataTable();

                dt.Load(objCmd.ExecuteReader());



                dr = objCmd.ExecuteReader();
                dr.Read();

                try
                {
                    //retornando a senha do banco
                    var senhaBd = dr.GetInt32(0);

                    if ((senhaT) != Int32.Parse(ContaCliente.Instancia.Senha))
                    {
                        lblMensagem.Text = "Senha inválida";
                        LeitorDeTexto.Instancia.Falar("Senha inválida\nTecle sair para uma nova tentativa");
                    }

                    else if (senhaT.Equals(senhaBd))
                    {

                        dtgExtrato.DataSource = dt;


                        //ocultando a coluna senha no datagridview
                        dtgExtrato.Columns["senha"].Visible = false;

                        //exibindo o datagridview
                        dtgExtrato.Visible = true;
                        dtgExtrato.AutoResizeRows();
                        LeitorDeTexto.Instancia.Falar("Ao término da consulta, tecle SAIR, para voltar ao menu inicial");
                        senhaT = (0);

                    }

            }

            catch
            {
                lblMensagem.Text = "Senha inválida";
                LeitorDeTexto.Instancia.Falar("Senha inválida\nTecle sair para uma nova tentativa");

            }
                dr.Close();
                objcon.Close();

            }
            catch
            {
                lblMensagem.Text = ("Não conectado");
            }          

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

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            LeitorDeTexto.Instancia.Falar("Digite o número para a opção desejada");
            formMenu.Show();
        }
    }
}

