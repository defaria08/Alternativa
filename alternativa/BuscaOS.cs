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
    public partial class BuscaOS : Form
    {
        string classe;
        public BuscaOS(string clas)
        {
            InitializeComponent();
            classe = clas;
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BBuca_Click(object sender, EventArgs e)
        {
            verletra();
            string nome,cod,nom;
            SqlDataReader leitor;
            DateTime dat;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();

            //-------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------


            LListadeCLiente.Items.Clear();
            nome = CCliente.Text;
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            if (TCódigo.Text != "")
            {
                selecionafilme = new SqlCommand("select codigo,cliente as nome ,datae as data,situacao from os where codigo=" + TCódigo.Text + " and situacao != 'Cancelada'", conexao);
            }
            else if (CCliente.Text.ToUpper() == "TODOS")
            {
                selecionafilme = new SqlCommand("select codigo,cliente as nome ,datae as data,situacao from os", conexao);
            }
            else
            {
                selecionafilme = new SqlCommand("select codigo,cliente as nome ,datae as data,situacao from os where cliente like '%" + nome + "%'", conexao);
            }

            //-------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------



            leitor = selecionafilme.ExecuteReader();
            if (leitor.Read() != false)
            {

                leitor.Close();
                leitor = selecionafilme.ExecuteReader();
                while (leitor.Read() == true)
                {
                    cod = leitor["codigo"].ToString();
                    nom = leitor["nome"].ToString();
                    dat = DateTime.Parse(leitor["data"].ToString());


                    ListViewItem itemLista = new ListViewItem(cod);
                    ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, nom);
                    itemLista.SubItems.Add(subitemLista);
                    subitemLista = new ListViewItem.ListViewSubItem(itemLista, dat.ToShortDateString());
                    itemLista.SubItems.Add(subitemLista);
                    subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["situacao"].ToString());
                    itemLista.SubItems.Add(subitemLista);

                    LListadeCLiente.Items.Add(itemLista);


                }
            }


            leitor.Close();
            conexao.Close();
        }

        private void LListadeCLiente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int codigo = int.Parse(LListadeCLiente.SelectedItems[0].Text);

            OrdemdeServico os = new OrdemdeServico(codigo,classe);
            os.ShowDialog();
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
