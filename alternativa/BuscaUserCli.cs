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
    public partial class BuscaUserCli : Form
    {
        public int tipo = 0;
        public BuscaUserCli(int tipo)
        {
            InitializeComponent();
            this.tipo = tipo;

        }

        private void BBuca_Click(object sender, EventArgs e)
        {
            verletra();
            atualizalista();
        }
        private void atualizalista()
        {
            string nome;
            SqlDataReader leitor;
            string cod, nom, doc;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();

            //-------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------

            if (tipo == 2)
            {
                LListadeUserCli.Items.Clear();
                nome = TNome.Text;
                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();

                if (TCodigo.Text != "")
                {
                    selecionafilme = new SqlCommand("select id as codigo,Nome as nome,CPF as doc, situacao from Clientes where id =" + TCodigo.Text, conexao);
                }
                else if (TNome.Text != "")
                {
                    selecionafilme = new SqlCommand("select id as codigo,Nome as nome,CPF as doc, situacao from Clientes where Nome like '%" + nome + "%'", conexao);
                }
                else
                {
                    selecionafilme = new SqlCommand("select id as codigo,Nome as nome,CPF as doc,situacao from Clientes where cpf ='" + MCPF.Text + "'", conexao);
                }
            }
            //-------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------

            else if (tipo == 1)
            {
                LListadeUserCli.Items.Clear();
                nome = TNome.Text;
                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();

                if (TCodigo.Text != "")
                {
                    selecionafilme = new SqlCommand("select id as codigo,Nome as nome,CPF as doc, situacao from USUARIOS where id =" + TCodigo.Text + "and loginn != 'admin'", conexao);
                }
                else if (TNome.Text != "")
                {
                    selecionafilme = new SqlCommand("select id as codigo,Nome as nome,CPF as doc, situacao from USUARIOS where Nome like '%" + nome + "%' and loginn != 'admin'", conexao);
                }
                else
                {
                    selecionafilme = new SqlCommand("select id as codigo,Nome as nome,CPF as doc, situacao from USUARIOS where cpf ='" + MCPF.Text + "'and loginn != 'admin'", conexao);
                }
            }


            //-------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------

            leitor = selecionafilme.ExecuteReader();
            if (leitor.Read() == false)
            {
                MessageBox.Show("Dados Inexistentes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            leitor.Close();
            leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                cod = leitor["codigo"].ToString();
                nom = leitor["nome"].ToString();
                doc = leitor["doc"].ToString();


                ListViewItem itemLista = new ListViewItem(cod);
                ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, nom);
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, doc);
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["situacao"].ToString());
                itemLista.SubItems.Add(subitemLista);

                LListadeUserCli.Items.Add(itemLista);


            }


            leitor.Close();
            conexao.Close();
        }
        private void LListadeUserCli_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int codigo = int.Parse(LListadeUserCli.SelectedItems[0].Text);
            if (tipo == 2)
            {
                Clientes clientes = new Clientes(codigo);
                clientes.ShowDialog();

            }
            else if (tipo == 1)
            {
                Usuario user = new Usuario(codigo);
                user.ShowDialog();
            }
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BBloquear_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");

            if (tipo == 1)
            {


                string vQuery = "update usuarios set situacao = @situacao where ID = " + LListadeUserCli.SelectedItems[0].Text;
                SqlCommand comandodeinsercao = new SqlCommand(vQuery, conexao);
                conexao.Open();

                if (LListadeUserCli.SelectedItems[0].SubItems[3].Text == "ATIVO")
                {
                    SqlParameter SITUACAO = new SqlParameter("@situacao", "BLOQUEADO");
                    comandodeinsercao.Parameters.Add(SITUACAO);
                }
                else
                {
                    SqlParameter SITUACAO = new SqlParameter("@situacao", "ATIVO");
                    comandodeinsercao.Parameters.Add(SITUACAO);
                }
                comandodeinsercao.ExecuteNonQuery();
            }
            else if (tipo == 2)
            {


                string vQuery = "update clientes set situacao = @situacao where ID = " + LListadeUserCli.SelectedItems[0].Text;
                SqlCommand comandodeinsercao = new SqlCommand(vQuery, conexao);
                conexao.Open();

                if (LListadeUserCli.SelectedItems[0].SubItems[3].Text == "ATIVO")
                {
                    SqlParameter SITUACAO = new SqlParameter("@situacao", "BLOQUEADO");
                    comandodeinsercao.Parameters.Add(SITUACAO);
                }
                else
                {
                    SqlParameter SITUACAO = new SqlParameter("@situacao", "ATIVO");
                    comandodeinsercao.Parameters.Add(SITUACAO);
                }
                comandodeinsercao.ExecuteNonQuery();
            }

            atualizalista();
            conexao.Close();
        }

        private void TCodigo_Leave(object sender, EventArgs e)
        {
            verletra();
        }
        public void verletra()
        {
            int lt = 0;
            foreach (var letra in TCodigo.Text)
            {
                if (char.IsLetter(letra) == true)
                {
                    lt = 1;
                }
                if (letra == '.' || letra == ' ')
                {
                    lt = 1;
                }
            }
            if (lt == 1)
            {
                MessageBox.Show("Código não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TCodigo.Text = "0";
            }

        }
    }
}
    
    
    

