using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alternativa
{
    public partial class GerenciarEstoque : Form
    {
        public GerenciarEstoque()
        {
            InitializeComponent();
        }

        private void BGerenciar_Click(object sender, EventArgs e)
        {
            if (LListadeProduto.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para prosseguir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Estoque2 gerenciar = new Estoque2(LListadeProduto.SelectedItems[0].Text);
                gerenciar.ShowDialog();
                busca();

            }

        }

        private void BBuca_Click(object sender, EventArgs e)
        {
            verletra();
            busca();
          
        }

        public void busca()
        {
            SqlDataReader leitor;
            string cod, qtde, forn, descri;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();
            LListadeProduto.Items.Clear();
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            if (TCodigo.Text != "")
            {
                selecionafilme = new SqlCommand("select codigo as codigo,descricao as descricao,quantidade as quantidade, fornecedor as fornecedor from produtos where codigo =" + TCodigo.Text, conexao);
            }
            else if (TDescricao.Text != "")
            {
                selecionafilme = new SqlCommand("select codigo as codigo,descricao as descricao,quantidade as quantidade, fornecedor as fornecedor from produtos where descricao like '%" + TDescricao.Text + "%'", conexao);
            }
            else
            {
                selecionafilme = new SqlCommand("select codigo as codigo,descricao as descricao,quantidade as quantidade, fornecedor as fornecedor from produtos where fornecedor like '%" + CFornecedor.Text + "%'", conexao);
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
                cod = leitor["codigo"].ToString();
                descri = leitor["descricao"].ToString();
                qtde = leitor["quantidade"].ToString();
                forn = leitor["fornecedor"].ToString();


                ListViewItem itemLista = new ListViewItem(cod);
                ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, descri);
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, qtde);
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, forn);
                itemLista.SubItems.Add(subitemLista);

                LListadeProduto.Items.Add(itemLista);

            }


            leitor.Close();
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
