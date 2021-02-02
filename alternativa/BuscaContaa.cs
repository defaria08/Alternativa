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
    public partial class BuscaContaa : Form
    {
        string user, classe;
        public BuscaContaa(string usr,string clas)
        {

            InitializeComponent();
            contasdodia();
            user = usr;
            classe = clas;

        }

        private void BBuca_Click(object sender, EventArgs e)
        {
            verletra();
            atualizalista();

        }
        public void atualizalista()
        {
            LListadeContas.Items.Clear();

            SqlDataReader leitor;
            string DESCRI, SITU;
            int COD;
            DateTime DATAV;
            double VL;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();

            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            if (TCodigo.Text != "")
            {

                selecionafilme = new SqlCommand("select CODIGO AS COD, DESCRICAO as DESCRI,VALOR as VL,DATAV as DATAV, SITUACAO AS SITU from CONTAS WHERE CODIGO = " + TCodigo.Text + " ORDER BY DATAV ASC", conexao);
            }
            else if (TDescricao.Text.ToUpper() == "TODOS")
            {

                selecionafilme = new SqlCommand("select CODIGO AS COD, DESCRICAO as DESCRI,VALOR as VL,DATAV as DATAV, SITUACAO AS SITU from CONTAS ORDER BY DATAV ASC", conexao);
            }
            else if (TDescricao.Text != "")
            {

                selecionafilme = new SqlCommand("select CODIGO AS COD, DESCRICAO as DESCRI,VALOR as VL,DATAV as DATAV, SITUACAO AS SITU from CONTAS WHERE DESCRICAO LIKE '%" + TDescricao.Text + "%' ORDER BY DATAV ASC", conexao);
            }
            else
            {
                LVP1.Visible = true;
                LVP2.Visible = true;
                LVPagar.Visible = true;
                selecionafilme = new SqlCommand("select CODIGO AS COD, DESCRICAO as DESCRI,VALOR as VL,DATAV as DATAV, SITUACAO AS SITU from CONTAS WHERE DATAV = '" + DTVencimento.Value + "' ORDER BY DATAV ASC", conexao);
            }


            leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                COD = int.Parse(leitor["COD"].ToString());
                DESCRI = leitor["DESCRI"].ToString();
                VL = double.Parse(leitor["VL"].ToString());
                DATAV = DateTime.Parse(leitor["DATAV"].ToString());
                SITU = leitor["SITU"].ToString();


                ListViewItem itemLista = new ListViewItem(COD.ToString());

                ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, DESCRI);
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, VL.ToString("0.00"));
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, DATAV.ToShortDateString());
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, SITU);
                itemLista.SubItems.Add(subitemLista);

                LListadeContas.Items.Add(itemLista);

            }

            contasdodia();
            leitor.Close();
            conexao.Close();
        }
        public void contasdodia()
        {
            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();




            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            selecionafilme = new SqlCommand("select sum(VALOR) as vl from CONTAS where DATAV <='" + DTVencimento.Value + "' and situacao != 'Paga'", conexao);



            leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                if (leitor["vl"].ToString() != "")
                {
                    LVPagar.Text = "R$" + double.Parse(leitor["vl"].ToString()).ToString("0.00");

                }
            }


            leitor.Close();
            conexao.Close();
        }



        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BPagar_Click(object sender, EventArgs e)
        {
            if (LListadeContas.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para prosseguir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (classe == "Administrador")
                {
                    SqlCommand selecionafilme = new SqlCommand();
                    SqlConnection conexao = new SqlConnection();
                    conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    selecionafilme = new SqlCommand("update contas set situacao = @situacao where codigo =" + LListadeContas.SelectedItems[0].Text, conexao);

                    SqlParameter situacao = new SqlParameter("@situacao", "Paga");
                    selecionafilme.Parameters.Add(situacao);

                    selecionafilme.ExecuteNonQuery();
                    MessageBox.Show("Conta Paga", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    realizamovimentacao();

                    atualizalista();

                }
                else
                {
                    MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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

        private void realizamovimentacao()
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
                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();

                selecionafilme = new SqlCommand("select codcaixa as cod from caixa where datacaixa = '" + DateTime.Now.ToShortDateString() + "' and situacao = 'Aberto'", conexao);
                leitor = selecionafilme.ExecuteReader();

                if (leitor.Read() == true)
                {

                    /* selecionafilme = new SqlCommand("select classe as classe from USUARIOS where UPPER(LOGINN) ='" + TLogin.Text.ToUpper() + "'", conexao);
                     leitor = selecionafilme.ExecuteReader();

                     if (leitor.Read() == true)
                     {

                         senha = leitor["sen"].ToString();
                     }
                     leitor.Close();
                     conexao.Close();

                     if (TSenha.Text == senha)
                     {
                         conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                         conexao.Open();
                         */
                    conexao.Close();
                    conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    SqlCommand comandodeinsercao = new SqlCommand("Insert into movimentacoes(datacaixa, usuario, operacao, valor, tipo, justificativa, aprovacao)" +
                                                                    "values" +
                                                                    "(@datacaixa, @usuario, @operacao, @valor, @tipo, @justificativa, @aprovacao)", conexao);


                    SqlParameter datacaixa = new SqlParameter("@datacaixa", DateTime.Now.ToShortDateString());
                    comandodeinsercao.Parameters.Add(datacaixa);
                    SqlParameter usuario = new SqlParameter("@usuario", user);
                    comandodeinsercao.Parameters.Add(usuario);
                    SqlParameter operacao = new SqlParameter("@operacao", "Saída");
                    comandodeinsercao.Parameters.Add(operacao);
                    SqlParameter valor = new SqlParameter("@valor", double.Parse(LListadeContas.SelectedItems[0].SubItems[2].Text));
                    comandodeinsercao.Parameters.Add(valor);
                    SqlParameter tipo = new SqlParameter("@tipo", "Pagamento");
                    comandodeinsercao.Parameters.Add(tipo);
                    SqlParameter justificativa = new SqlParameter("@justificativa", "Pagamento da conta de " + LListadeContas.SelectedItems[0].SubItems[1].Text);
                    comandodeinsercao.Parameters.Add(justificativa);
                    SqlParameter aprovacao = new SqlParameter("@aprovacao", user);
                    comandodeinsercao.Parameters.Add(aprovacao);


                    comandodeinsercao.ExecuteNonQuery();

                    MessageBox.Show("Movimentação Cadastrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexao.Close();
                }
            }
            else
            {
                MessageBox.Show("Não existe um caixa aberto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
