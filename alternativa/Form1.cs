using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alternativa
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
                
        }

        private void BSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BEntrar_Click(object sender, EventArgs e)
        {


       
            SqlDataReader leitor;
            string cod, nom, senha,classe;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();

            //-------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------

           
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            selecionafilme = new SqlCommand("select id , loginn, senha, classe ,situacao  from usuarios where upper(loginn) ='" + TLogin.Text.ToUpper() + "' " , conexao);

            leitor = selecionafilme.ExecuteReader();
            if (leitor.Read() == false)
            {
                label1.Visible = true;

            }
            else
            {

                cod = leitor["id"].ToString();
                nom = leitor["loginn"].ToString();
                senha = leitor["senha"].ToString();
                classe = leitor["classe"].ToString();

                if (senha == TSenha.Text)
                {
                    label1.Visible = false;
                    MenuInicial menu = new MenuInicial(cod,nom,senha,classe);
                    TLogin.Text = "";
                    TSenha.Text = "";
                    menu.ShowDialog();
                   
                }
                else
                {
                    label1.Visible = true;
                }
            }
           
            leitor.Close();
            conexao.Close();
            
        }
    }
}
