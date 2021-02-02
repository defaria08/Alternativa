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
    public partial class BuscaFornecedor : Form
    {
        public BuscaFornecedor()
        {
            InitializeComponent();
        }

        private void BBuca_Click(object sender, EventArgs e)
        {
            verletra();
            atualizalista();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            if (TCódigo.Text != "")
            {
                selecionafilme = new SqlCommand("select codigo,nfantasia,cnpj ,situacao from fornecedores where codigo =" + TCódigo.Text, conexao);
            }
            else if (TNome.Text != "")
            {
                selecionafilme = new SqlCommand("select codigo,nfantasia,cnpj ,situacao from fornecedores where nfantasia like '%" + TNome.Text + "%'", conexao);
            }
            else
            {
                selecionafilme = new SqlCommand("select codigo,nfantasia,cnpj ,situacao from fornecedores where cnpj ='" + MCNPJ.Text + "'", conexao);
            }
            LListadeFornecedor.Items.Clear();

            nome = TNome.Text;
            conexao.Open();

        
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
                nom = leitor["nfantasia"].ToString();
                doc = leitor["cnpj"].ToString();


                ListViewItem itemLista = new ListViewItem(cod);
                ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, nom);
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, doc);
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["situacao"].ToString());
                itemLista.SubItems.Add(subitemLista);

                LListadeFornecedor.Items.Add(itemLista);


            }


            leitor.Close();
            conexao.Close();
        }

        private void BBloquear_Click(object sender, EventArgs e)
        {

            SqlConnection conexao = new SqlConnection();
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");

            string vQuery = "update fornecedores set situacao = @situacao where codigo = " + LListadeFornecedor.SelectedItems[0].Text;
            SqlCommand comandodeinsercao = new SqlCommand(vQuery, conexao);
            conexao.Open();

            if (LListadeFornecedor.SelectedItems[0].SubItems[3].Text == "ATIVO")
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
            
            atualizalista();
            conexao.Close();
        }

        private void LListadeFornecedor_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int codigo = int.Parse(LListadeFornecedor.SelectedItems[0].Text);
            
                Fornecedores forn = new Fornecedores(codigo);
                forn.ShowDialog();

           
        }

        private void TCódigo_Leave(object sender, EventArgs e)
        {
            verletra();
        }
        public void verletra()
        {
            int lt = 0;
            foreach (var letra in TCódigo.Text)
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
                TCódigo.Text = "0";
            }

        }
    }
}
