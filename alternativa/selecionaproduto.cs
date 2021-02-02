using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace alternativa
{
    public partial class selecionaproduto : Form
    {
        string produto,tipo;
        public string codigo;

        public selecionaproduto(string prod, string tip)
        {
            produto = prod;
            tipo = tip;
            InitializeComponent();
            atualizalista();
        }

        public void atualizalista()
        {
            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();



            listadeproduto.Items.Clear();
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            if (tipo == "Produto")
            {
                selecionafilme = new SqlCommand("select cbarras as codigo,descricao as descri,fabricante as fab, modelo as mod, pvenda as vl, abrangente as abg from produtos where descricao like '%" + produto + "%' and tipo = 'Produto'", conexao);
            }
            else if (tipo == "Serviço")
            {
                selecionafilme = new SqlCommand("select cbarras as codigo,descricao as descri,fabricante as fab, modelo as mod, pvenda as vl, abrangente as abg from produtos where descricao like '%" + produto + "%'and tipo = 'Serviço'", conexao);
            }
            else
                selecionafilme = new SqlCommand("select cbarras as codigo,descricao as descri,fabricante as fab, modelo as mod, pvenda as vl, abrangente as abg from produtos where descricao like '%" + produto + "%'", conexao);
        


        leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                ListViewItem itemLista = new ListViewItem(leitor["codigo"].ToString());
                ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["descri"].ToString());
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["fab"].ToString());
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["mod"].ToString());
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, double.Parse(leitor["vl"].ToString()).ToString("0.00"));
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["abg"].ToString());
                itemLista.SubItems.Add(subitemLista);

                listadeproduto.Items.Add(itemLista);

            }


            leitor.Close();
            conexao.Close();
        }

       

        private void listadeproduto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            codigo = listadeproduto.SelectedItems[0].Text;
            this.Close();
        }
    }
}
