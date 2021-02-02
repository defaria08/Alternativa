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
    public partial class Conta2 : Form
    {
        string user,classe;
        
        public Conta2(string usr, string clase)
        {
            InitializeComponent();
            limpaform();
            atualizalista();
            AtribuiCodigo();
            classe = clase;
            user = usr;
        }
        public void AtribuiCodigo()
        {
            int codigo;
            SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "select MAX(codigo) as cod from contas";

            SqlCommand pegacodigo = new SqlCommand(vQuery, conexao);

            SqlDataReader dr;

            dr = pegacodigo.ExecuteReader();

            if (dr.Read() == false)
            {
                codigo = 1;
            }
            else
            {
                if (dr["cod"].ToString() == "")
                    codigo = 1;
                else
                    codigo = int.Parse(dr["cod"].ToString()) + 1;
            }

            dr.Close();

            TCodigo.Text = codigo.ToString();
            conexao.Close();
        }
        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAdicionar_Click(object sender, EventArgs e)
        {
            verletra();
            SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            SqlCommand comandodeinsercao = new SqlCommand("Insert into CONTAS (DESCRICAO, DATAV, VALOR, SITUACAO)" +
                                                            "values" +
                                                            "(@DESCRICAO, @DATAV, @VALOR, @SITUACAO)", conexao);

            SqlParameter DESCRICAO = new SqlParameter("@DESCRICAO", TDescricao.Text);
            comandodeinsercao.Parameters.Add(DESCRICAO);
            SqlParameter DATAV = new SqlParameter("@DATAV", DTVencimento.Value);
            comandodeinsercao.Parameters.Add(DATAV);
            SqlParameter VALOR = new SqlParameter("@VALOR", double.Parse(TValor.Text));
            comandodeinsercao.Parameters.Add(VALOR);
            SqlParameter SITUACAO = new SqlParameter("@SITUACAO", CSituacao.Text);
            comandodeinsercao.Parameters.Add(SITUACAO);
            comandodeinsercao.ExecuteNonQuery();

            MessageBox.Show("Conta Cadastrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            conexao.Close();
            limpaform();
            atualizalista();
            AtribuiCodigo();


        }

        public void limpaform()
        {
            TDescricao.Text = "";
            DTVencimento.Value = DateTime.Now;
            TValor.Text = "0.00";
            CSituacao.Text = "A Pagar";
            ListaConta.Items.Clear();
            AtribuiCodigo();
        }

        private void BLimpar_Click(object sender, EventArgs e)
        {
            limpaform();
        }
        public void atualizalista()
        {
            ListaConta.Items.Clear();

            SqlDataReader leitor;
            string DESCRI, SITU;
            int COD;
            DateTime DATAV;
            double VL;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();



            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            selecionafilme = new SqlCommand("select CODIGO AS COD, DESCRICAO as DESCRI,VALOR as VL,DATAV as DATAV, SITUACAO AS SITU from CONTAS WHERE DATAV >= '" + DTVencimento.Value + "' AND SITUACAO != 'Paga' ORDER BY DATAV ASC", conexao);


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
                subitemLista = new ListViewItem.ListViewSubItem(itemLista,VL.ToString("0.00"));
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, DATAV.ToShortDateString());
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, SITU);
                itemLista.SubItems.Add(subitemLista);

                ListaConta.Items.Add(itemLista);

            }


            leitor.Close();
            conexao.Close();
            contasdodia();
        }

        private void BPagar_Click(object sender, EventArgs e)
        {
            if (ListaConta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um item para prosseguir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (classe != "Administrador")
                {
                    MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlCommand selecionafilme = new SqlCommand();
                    SqlConnection conexao = new SqlConnection();
                    conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    selecionafilme = new SqlCommand("update contas set situacao = @situacao where codigo =" + ListaConta.SelectedItems[0].Text, conexao);

                    SqlParameter situacao = new SqlParameter("@situacao", "Paga");
                    selecionafilme.Parameters.Add(situacao);

                    selecionafilme.ExecuteNonQuery();
                    MessageBox.Show("Conta Paga", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    realizamovimentacao();
                    AtribuiCodigo();
                    atualizalista();
                }
               
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
                    SqlParameter valor1 = new SqlParameter("@valor", double.Parse(ListaConta.SelectedItems[0].SubItems[2].Text));
                    comandodeinsercao.Parameters.Add(valor1);
                    SqlParameter tipo = new SqlParameter("@tipo", "Pagamento");
                    comandodeinsercao.Parameters.Add(tipo);
                    SqlParameter justificativa = new SqlParameter("@justificativa", "Pagamento da conta de " + ListaConta.SelectedItems[0].SubItems[1].Text);
                    comandodeinsercao.Parameters.Add(justificativa);
                    SqlParameter aprovacao = new SqlParameter("@aprovacao", user);
                    comandodeinsercao.Parameters.Add(aprovacao);


                    comandodeinsercao.ExecuteNonQuery();

                    MessageBox.Show("Conta Paga", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexao.Close();
                }
            }
            else
            {
                MessageBox.Show("Não existe um caixa aberto!", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TValor_Leave(object sender, EventArgs e)
        {
            verletra();
        }
        public void verletra()
        {
            int lt = 0;
            foreach (var letra in TValor.Text)
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
                MessageBox.Show("Valor não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TValor.Text = "0";
            }

        }
        public void contasdodia()
        {
            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();




            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            DateTimePicker diaatual = new DateTimePicker();
            diaatual.Value = DateTime.Parse(DateTime.Now.ToShortDateString());

            selecionafilme = new SqlCommand("select sum(VALOR) as vl from CONTAS where DATAV ='" + diaatual.Value + "'AND SITUACAO != 'Paga'", conexao);



            leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                if (leitor["vl"].ToString() != "")
                {
                    LVPDia.Text = "R$" + double.Parse(leitor["vl"].ToString()).ToString("0.00");

                }
                else
                {
                    LVPDia.Text = "R$0.00";

                }
            }


            leitor.Close();
            conexao.Close();
        }
    }
}




