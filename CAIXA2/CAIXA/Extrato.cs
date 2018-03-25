﻿using MySql.Data.MySqlClient;
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

                MySqlCommand objCmd = new MySqlCommand("select nome,valor,tipo,data from cliente inner join movimentacao on id_cliente=id_mov where senha ='" + senhaT + "' order by(data)", objcon);
                // objCmd.Parameters.Clear();

                objCmd.CommandType = CommandType.Text;
                //recebe o conteudo do banco
                MySqlDataReader dr;
               // MySqlDataAdapter db = new  MySqlDataAdapter();
                
               // DataTable dt = new DataTable();
               // db.Fill(dt);

                
                dr = objCmd.ExecuteReader();
                dr.Read();
                //dtgExtrato.DataSource = dr;

                try
                {
                    //retornando a senha do banco
                    var senhaBd = dr.GetInt32(0);
                    if (senhaT.Equals(senhaBd))
                    {
                        objCmd = new MySqlCommand("select senha,sum(valor) as valor from cliente inner join movimentacao on id_cliente=id_mov where senha ='" + senhaT + "'", objcon);
                        

                        exibirSaldoAtual.Text = dr.GetDouble(1).ToString("N");
                      
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
                MessageBox.Show("Nao conectado");
            }
            await Task.Delay(3000);
            this.Close();
        }
    }  
}
