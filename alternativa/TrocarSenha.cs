using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace alternativa
{
    public partial class TrocarSenha : Form
    {
        SqlDataReader leitor;
        string LOG, NOM, SENHA;
        SqlCommand selecionafilme;
        SqlConnection conexao;

        private void TNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void BAlterar_Click(object sender, EventArgs e)
        {
            if(TSenhaAtual.Text == SENHA)
            {
                if(TNovaSenha.Text == TConfirmaSenha.Text)
                {
                    SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();
                    string vQuery = "update USUARIOS set senha = @senha where loginn = '" + LOG + "'";

                    SqlCommand comandodeinsercao = new SqlCommand(vQuery, conexao);


                    SqlParameter senha = new SqlParameter("@senha", TNovaSenha.Text);
                    comandodeinsercao.Parameters.Add(senha);
                    comandodeinsercao.ExecuteNonQuery();
                    MessageBox.Show("Senha alterada com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpacampos();
                    conexao.Close();

                }
                else
                {
                    MessageBox.Show("Senhas não coencidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Senha atual inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void limpacampos()
        {
            TCodigo.Text = "";
            TNome.Text = "";
            TLogin.Text = "";
            TNomecompleto.Text = "";
            TSenhaAtual.Text = "";
            TNovaSenha.Text = "";
            TConfirmaSenha.Text = "";
            TCodigo.Focus();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BResetar_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "update USUARIOS set senha = @senha where loginn = '" + LOG + "'";

            SqlCommand comandodeinsercao = new SqlCommand(vQuery, conexao);


            SqlParameter senha = new SqlParameter("@senha", "1234");
            comandodeinsercao.Parameters.Add(senha);
            comandodeinsercao.ExecuteNonQuery();
            MessageBox.Show("Senha resetada para 1234", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpacampos();
            conexao.Close();

               
        }

        private void TSenhaAtual_TextChanged(object sender, EventArgs e)
        {

        }

        public TrocarSenha()
        {
            InitializeComponent();
        }

        private void BBuscar_Click(object sender, EventArgs e)
        {
            
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            if (TCodigo.Text != "")
            {
                selecionafilme = new SqlCommand("select loginn as LOG,Nome as NoM,senha as SENHA from USUARIOS where id =" + TCodigo.Text, conexao);
            }
            else if (TNome.Text != "")
            {
                selecionafilme = new SqlCommand("select loginn as LOG,Nome as NoM,senha as SENHA from USUARIOS where loginn ='" + TNome.Text + "'", conexao);
            }
            leitor = selecionafilme.ExecuteReader();
            if (leitor.Read() == false)
            {
                MessageBox.Show("Dados Inexistentes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            leitor.Close();
            leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                LOG = leitor["LOG"].ToString();
                NOM = leitor["NOM"].ToString();
                SENHA = leitor["SENHA"].ToString();

            }

            TLogin.Text = LOG;
            TNomecompleto.Text = NOM;

            leitor.Close();
            conexao.Close();
        }
    }
}
