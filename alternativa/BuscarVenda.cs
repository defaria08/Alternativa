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
    
    public partial class BuscarVenda : Form
    {
        string cod, nom,classe;
        double valor = 0;
        public BuscarVenda(string clas, string user)
        {
            InitializeComponent();
            classe = clas;
            nom = user;
        }

        private void BBuca_Click(object sender, EventArgs e)
        {
            verletra();
            atualizalista();
        }
        public void atualizalista()
        {
            string nome;
            SqlDataReader leitor;
            DateTime dat;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();

            //-------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------


            LListadeProduto.Items.Clear();
            nome = CCliente.Text;
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            if (TNVenda.Text != "")
            {
                selecionafilme = new SqlCommand("select codvendaitem as codigo,cliente as nome,data as data from vendas where codvendaitem=" + TNVenda.Text + " and situacao != 'Cancelada'", conexao);
            }
            else if(CCliente.Text.ToUpper() == "TODOS" )
            {
                selecionafilme = new SqlCommand("select codvendaitem as codigo,cliente as nome,data as data from vendas where situacao != 'Cancelada'", conexao);
            }
            else
            {
                selecionafilme = new SqlCommand("select codvendaitem as codigo,cliente as nome,data as data from vendas where cliente like '%" + nome + "%' and situacao != 'Cancelada'", conexao);
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

                    LListadeProduto.Items.Add(itemLista);


                }
            }


            leitor.Close();
            conexao.Close();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LListadeProduto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int codigo = int.Parse(LListadeProduto.SelectedItems[0].Text);

            Venda venda = new Venda(codigo,"");
            venda.ShowDialog();


        }
        public void buscavalor(string codi)
        {
            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();



            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            selecionafilme = new SqlCommand("select valor from vendas where codvendaitem = "+ codi, conexao);
            leitor = selecionafilme.ExecuteReader();

            if (leitor.Read() == true)
            {
                valor = double.Parse(leitor["valor"].ToString());
            }
        }

        private void TNVenda_Leave(object sender, EventArgs e)
        {
            verletra();
        }
        public void verletra()
        {
            int lt = 0;
            foreach (var letra in TNVenda.Text)
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
                MessageBox.Show("Nº da venda não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TNVenda.Text = "0";
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (LListadeProduto.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para prosseguir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (classe != "Administrador")
                {

                }
                else
                {
                    SqlDataReader leitor;
                    SqlCommand selecionafilme = new SqlCommand();
                    SqlConnection conexao = new SqlConnection();



                    conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    selecionafilme = new SqlCommand("select codcaixa as cod from caixa where datacaixa = '" + DateTime.Now.ToShortDateString() + "' and situacao = 'Aberto'", conexao);
                    leitor = selecionafilme.ExecuteReader();

                    if (leitor.Read() == true)
                    {


                        conexao.Close();
                        conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                        conexao.Open();

                        SqlCommand comandodeinsercao = new SqlCommand("Insert into movimentacoes(datacaixa, usuario, operacao, valor, tipo, justificativa, aprovacao)" +
                                                                        "values" +
                                                                        "(@datacaixa, @usuario, @operacao, @valor, @tipo, @justificativa, @aprovacao)", conexao);


                        SqlParameter datacaixa = new SqlParameter("@datacaixa", DateTime.Now.ToShortDateString());
                        comandodeinsercao.Parameters.Add(datacaixa);
                        SqlParameter usuario = new SqlParameter("@usuario", nom);
                        comandodeinsercao.Parameters.Add(usuario);
                        SqlParameter operacao = new SqlParameter("@operacao", "Saída");
                        comandodeinsercao.Parameters.Add(operacao);
                        buscavalor(LListadeProduto.SelectedItems[0].Text);
                        SqlParameter valor1 = new SqlParameter("@valor", valor);
                        comandodeinsercao.Parameters.Add(valor1);
                        SqlParameter tipo = new SqlParameter("@tipo", "Estorno");
                        comandodeinsercao.Parameters.Add(tipo);
                        SqlParameter justificativa = new SqlParameter("@justificativa", "Estorno da venda " + LListadeProduto.SelectedItems[0].Text);
                        comandodeinsercao.Parameters.Add(justificativa);
                        SqlParameter aprovacao = new SqlParameter("@aprovacao", nom);
                        comandodeinsercao.Parameters.Add(aprovacao);


                        comandodeinsercao.ExecuteNonQuery();

                        MessageBox.Show("Movimentação Cadastrada", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        conexao.Close();
                        MudaStatusVenda();
                    }


                    else
                    {
                        MessageBox.Show("Não existe um caixa aberto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        public void MudaStatusVenda()
        {

         
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();



            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            selecionafilme = new SqlCommand("update vendas set situacao = @situacao where codvendaitem = " + cod + " and situacao = 'Finalizada'", conexao);

            SqlParameter situacao = new SqlParameter("@situacao","Cancelada");
            selecionafilme.Parameters.Add(situacao);

            selecionafilme.ExecuteNonQuery();
            conexao.Close();
            atualizalista();
        }

    }
    
}