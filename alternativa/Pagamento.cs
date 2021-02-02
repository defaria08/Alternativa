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
using System.Drawing.Imaging;

namespace alternativa
{
    public partial class Pagamento : Form
    {
        double valor, valorp, troco, desc;
        string user, clie, doc, codigovenda2;
        ListView listadeitem = new ListView();

        int os;
        public Pagamento(String valort, string codigovenda, string user, string clie, string doc, string desc, int os, ListView lista, string codigov)
        {
            InitializeComponent();
            LNVenda.Text = codigovenda;
            valor = double.Parse(valort);
            LVTotal.Text = valor.ToString("0.00");
            this.user = user;
            this.clie = clie;
            this.doc = doc;
            this.os = os;
            this.desc = double.Parse(desc);
            listadeitem = lista;
            codigovenda2 = codigov;

            calculatroco();

        }

        public void calculatroco()
        {
            troco = valorp - valor;
            LTroco.Text = troco.ToString("0.00");
        }
        public void verdin()
        {
            int lt = 0;
            foreach (var letra in TDinheiro.Text)
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
                MessageBox.Show("Valor do Dinheiro não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TDinheiro.Text = "0";
            }

        }
        public void vercred()
        {
            int lt = 0;
            foreach (var letra in TCredito.Text)
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
                MessageBox.Show("Valor dos Cartão de Crédito não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TCredito.Text = "0";
            }

        }
        public void verdeb()
        {
            int lt = 0;
            foreach (var letra in TCDebito.Text)
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
                MessageBox.Show("Valor do Cartão de Débito não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TCDebito.Text = "0";
            }

        }
        public void vercheq()
        {
            int lt = 0;
            foreach (var letra in TCheque.Text)
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
                MessageBox.Show("Valor do Cheque não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TCheque.Text = "0";
            }

        }
        private void BConfirmar_Click(object sender, EventArgs e)
        {
            verdin();
            vercred();
            verdeb();
            vercheq();

            

              
                    SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    SqlCommand comandodeinsercao = new SqlCommand("Insert into vendas (USUARIO,CLIENTE,DOCUMENTO,DESCONTO,VALOR,PGDIN,PGCRED,PGDEB,PGCHEQ,data,situacao,OS)" +
                                                                  "values" +
                                                                  "(@USUARIO,@CLIENTE,@DOCUMENTO,@DESCONTO,@VALOR,@PGDIN,@PGCRED,@PGDEB,@PGCHEQ,@data,@situacao,@OS)", conexao);


                    SqlParameter USUARIO = new SqlParameter("@USUARIO", user);
                    comandodeinsercao.Parameters.Add(USUARIO);
                    SqlParameter CLIENTE = new SqlParameter("@CLIENTE", clie);
                    comandodeinsercao.Parameters.Add(CLIENTE);
                    SqlParameter DOCUMENTO = new SqlParameter("@DOCUMENTO", doc);
                    comandodeinsercao.Parameters.Add(DOCUMENTO);
                    SqlParameter DESCONTO = new SqlParameter("@DESCONTO", desc);
                    comandodeinsercao.Parameters.Add(DESCONTO);
                    SqlParameter VALOR = new SqlParameter("@VALOR", double.Parse(LVTotal.Text));
                    comandodeinsercao.Parameters.Add(VALOR);
                    SqlParameter PGDIN = new SqlParameter("@PGDIN", double.Parse(TDinheiro.Text));
                    comandodeinsercao.Parameters.Add(PGDIN);
                    SqlParameter PGCRED = new SqlParameter("@PGCRED", double.Parse(TCredito.Text));
                    comandodeinsercao.Parameters.Add(PGCRED);
                    SqlParameter PGDEB = new SqlParameter("@PGDEB", double.Parse(TCDebito.Text));
                    comandodeinsercao.Parameters.Add(PGDEB);
                    SqlParameter PGCHEQ = new SqlParameter("@PGCHEQ", double.Parse(TCheque.Text));
                    comandodeinsercao.Parameters.Add(PGCHEQ);
                    SqlParameter datav = new SqlParameter("@data", DateTime.Now.ToShortDateString());
                    comandodeinsercao.Parameters.Add(datav);
                    SqlParameter situacao = new SqlParameter("@situacao", "Finalizada");
                    comandodeinsercao.Parameters.Add(situacao);
                    SqlParameter OS = new SqlParameter("@OS", os);
                    comandodeinsercao.Parameters.Add(OS);


                    comandodeinsercao.ExecuteNonQuery();

                    ListadeProduto();
                    MessageBox.Show("Venda Efetuada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexao.Close();


                    this.Close();
                
            


        }
        public void ListadeProduto()
        {


            if (listadeitem != null)
            {
               
                    foreach (ListViewItem item in listadeitem.Items)
                    {


                        SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                        conexao.Open();

                        SqlCommand comandodeinsercao = new SqlCommand("Insert into listadecompra (codvenda, produto, valor, quantidade)" +
                                                                    "values" +
                                                                    "(@codvenda, @produto, @valor, @quantidade)", conexao);


                        SqlParameter codvenda = new SqlParameter("@codvenda", int.Parse(codigovenda2));
                        comandodeinsercao.Parameters.Add(codvenda);
                        SqlParameter produto = new SqlParameter("@produto", item.Text);
                        comandodeinsercao.Parameters.Add(produto);
                        SqlParameter valor = new SqlParameter("@valor", double.Parse(item.SubItems[1].Text));
                        comandodeinsercao.Parameters.Add(valor);
                        SqlParameter quantidade = new SqlParameter("@quantidade", int.Parse(item.SubItems[2].Text));
                        comandodeinsercao.Parameters.Add(quantidade);

                        comandodeinsercao.ExecuteNonQuery();

                        conexao.Close();
                        conexao.Open();

                        comandodeinsercao = new SqlCommand("update produtos set quantidade = quantidade - @quantidade2 where codigo = " + int.Parse(item.SubItems[3].Text), conexao);
                        SqlParameter quantidade2 = new SqlParameter("@quantidade2", +int.Parse(item.SubItems[2].Text));
                        comandodeinsercao.Parameters.Add(quantidade2);
                        comandodeinsercao.ExecuteNonQuery();


                    }
                
            }
        }

    
    

        private void Calculo_Leave(object sender, EventArgs e)
        {
            verdin();
            vercred();
            verdeb();
            vercheq();
            valorp = (float.Parse(TDinheiro.Text) + float.Parse(TCredito.Text) + float.Parse(TCDebito.Text) + float.Parse(TCheque.Text));
            LVPago.Text = valorp.ToString("0.00");
            calculatroco();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }
    }
}
