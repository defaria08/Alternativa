using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alternativa
{
   
    public partial class Venda : Form
    {
        int validacao;
        string situacao;
        int os = 0;
        string codigo;
        double total, subtotal;
        float desconto;
        Pagamento pag;
        int cdvenda;


        SqlCommand selecionafilme = new SqlCommand();
        SqlConnection conexao = new SqlConnection();
        public Venda( int cd,string usr)
        {
            InitializeComponent();
            TUser.Text = usr;
            cdvenda = cd;
            AtribuiCodigo();
            
            if(cdvenda !=0)
            {
                carregavenda();
            }
        }
        public void validacpf()
        {
            string valor = MCPF.Text;
            if (RCNPJ.Checked)
            {
                if (Validacao.ValidaCNPJ.IsCnpj(valor))
                {
                    validacao = 1;
                }
                else
                {
                    validacao = 0;
                }
            }
            else if (RCPF.Checked)
            {
                if (Validacao.ValidaCPF.IsCpf(valor))
                {
                    validacao = 1;
                }
                else
                {
                    validacao = 0;
                }
            }
        }
        public void carregavenda()
        {
            SqlDataReader leitor;
            SqlCommand selecionavenda = new SqlCommand();
            SqlConnection conexao = new SqlConnection();
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            selecionavenda = new SqlCommand("select codvendaitem as codigo, USUARIO,CLIENTE,DOCUMENTO,DESCONTO,valor," +
                                                    "OS from vendas where codvendaitem =" + cdvenda, conexao);
            leitor = selecionavenda.ExecuteReader();

            if (leitor.Read() == true)
            {
                TCodigo.Text = leitor["codigo"].ToString();
                TUser.Text = leitor["USUARIO"].ToString();
                Tcliente.Text = leitor["CLIENTE"].ToString();
                MCPF.Text = leitor["DOCUMENTO"].ToString();
                TDesconto.Text = leitor["DESCONTO"].ToString();
                double total = double.Parse(leitor["valor"].ToString());
                TValorTotal.Text = total.ToString("0.00");
                os = int.Parse(leitor["os"].ToString());

                carregaprod(int.Parse(leitor["codigo"].ToString()));
            }
            BConfirmar.Enabled = false;

            leitor.Close();
            conexao.Close();

        }
        public void carregaprod(int ordem)
        {

            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();




            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            selecionafilme = new SqlCommand("select produto, valor, quantidade from listadecompra where codvenda = " + ordem, conexao);



            leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                ListViewItem itemLista = new ListViewItem(leitor["produto"].ToString());
                double vl = double.Parse(leitor["valor"].ToString());
                ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, vl.ToString("0.00"));
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["quantidade"].ToString());
                itemLista.SubItems.Add(subitemLista);


                ListadeItem.Items.Add(itemLista);

            }

            Calcsubtotal();
            leitor.Close();
            conexao.Close();

        }
        public void setOS(int os)
        {
            this.os = os;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            validacpf();
            if (validacao == 1)
            {
                verdesc();
                if (situacao.ToUpper() == "BLOQUEADO")
                {
                    MessageBox.Show("Cliente Bloqueado", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (ListadeItem.Items.Count != 0)
                        {
                            pag = new Pagamento(TValorTotal.Text, TCodigo.Text, TUser.Text, Tcliente.Text, MCPF.Text, TDesconto.Text, os, ListadeItem, TCodigo.Text);
                            pag.ShowDialog();

                            //FUNÇAO QUE GERA O PDF DE COMPROVANTE
                            gerarecibo();

                            //APRESENTA O PDF
                            System.Diagnostics.Process.Start(@"C:\Users\defar\Desktop\recibo.pdf");
                        }
                        else
                        {
                            MessageBox.Show("Lista de compras vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não existe um caixa aberto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Documento Inválido", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RCPF_CheckedChanged(object sender, EventArgs e)
        {
            MCPF.Mask = "000,000,000-00";
        }

        private void RCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            MCPF.Mask = "00,000,000/0000-00";
        }

        private void Venda_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BAdicionar_Click(object sender, EventArgs e)
        {

            verletra();
                codigo = TBproduto.Text;
            

            ListadeCompra(codigo);           

        }
        public void ListadeCompra(String cod)
        {

                SqlDataReader leitor;
                SqlCommand selecionafilme = new SqlCommand();
                SqlConnection conexao = new SqlConnection();




                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();


                selecionafilme = new SqlCommand("select codigo as codigo,descricao as descri,pvenda as vl from produtos where cbarras = '" + codigo + "'", conexao);



                leitor = selecionafilme.ExecuteReader();
                while (leitor.Read() == true)
                {
                    ListViewItem itemLista = new ListViewItem(leitor["descri"].ToString());
                    ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, (double.Parse(leitor["vl"].ToString()) * int.Parse(TQtd.Text)).ToString("0.00"));
                    itemLista.SubItems.Add(subitemLista);
                    subitemLista = new ListViewItem.ListViewSubItem(itemLista, TQtd.Text);
                    itemLista.SubItems.Add(subitemLista);
                    subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["codigo"].ToString());
                    itemLista.SubItems.Add(subitemLista);


                ListadeItem.Items.Add(itemLista);

                }

                Calcsubtotal();
                leitor.Close();
                conexao.Close();
            
        }
        public void Calcsubtotal()
        {
            subtotal = 0;
            for (int i = 0; i < ListadeItem.Items.Count; i++)
            {
                subtotal += double.Parse(ListadeItem.Items[i].SubItems[1].Text);
            }
            TSubtotal.Text = subtotal.ToString("0.00");

            Calculatotal();
        }

        public void Calculatotal()
        {
            if (Radioporcento.Checked == true)
            {
                total =  subtotal - ((subtotal / 100) * desconto);
            }
            else
            {
                total = subtotal - desconto;
            }
            TValorTotal.Text = total.ToString("0.00");
        }
       private void RProduto_CheckedChanged(object sender, EventArgs e)
        {
            TBproduto.Text = "";
        }

        private void RCBarras_CheckedChanged(object sender, EventArgs e)
        {
            TBproduto.Text = "";
        }

        private void BBusca_Click(object sender, EventArgs e)
        {
            if (RProduto.Checked == true)
            {
                selecionaproduto produto = new selecionaproduto(TBproduto.Text,"Ambos");
                produto.ShowDialog();
                TBproduto.Text = produto.codigo;
            }

        }

        private void Radioporcento_CheckedChanged(object sender, EventArgs e)
        {
            Calculatotal();
        }

        private void radiograna_CheckedChanged(object sender, EventArgs e)
        {
            Calculatotal();
        }

     
        private void TDesconto_TextChanged(object sender, EventArgs e)
        {
            if (TDesconto.Text == "")
            {
                desconto = 0;
            }
            else
            {
                desconto = float.Parse(TDesconto.Text);
            }
            Calculatotal();
        }

        private void BRemover_Click(object sender, EventArgs e)
        {
            if (ListadeItem.SelectedItems.Count != 0)
            {
                ListadeItem.Items[0].Remove();
            }
            Calcsubtotal();
        }
        public void gerarecibo()
        {

            //CRIA O PDF
            Document recibo = new Document(PageSize.A4);
            recibo.SetMargins(30, 20, 30, 20);
            recibo.AddCreationDate();

            //CAMINHO ONDE O PDF É SALVO E O NOME DO PDF
            string caminho = @"C:\Users\defar\Desktop\recibo.pdf";

            PdfWriter writer = PdfWriter.GetInstance(recibo, new FileStream(caminho, FileMode.Create));

            //ABRI O PDF
            recibo.Open();

            //-----------------------------------------------------------------------------------


            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();

            //-------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------

            
               
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

                
            selecionafilme = new SqlCommand("SELECT NOMEFAN AS NOME, ENDERECO, NUMERO, COMPLEMENTO, BARRIO AS BAIRRO, CEP, CIDADE, ESTADO, TELEFONE, CELULAR, EMAIL, VINCULAR FROM EMPRESA", conexao);


            //-------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------
            Paragraph paragrafo = new Paragraph();
            leitor = selecionafilme.ExecuteReader();
            if (leitor.Read() != false)
            {

                if (leitor["VINCULAR"].ToString() == "S")
                {

                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add(leitor["NOME"].ToString());
                    recibo.Add(paragrafo);

                    if (leitor["COMPLEMENTO"].ToString() == "")
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add(leitor["ENDERECO"].ToString() + ", " + leitor["NUMERO"].ToString() + " - " + leitor["BAIRRO"].ToString());
                        recibo.Add(paragrafo);
                    }
                    else
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add(leitor["ENDERECO"].ToString() + ", " + leitor["NUMERO"].ToString() + ", " + leitor["COMPLEMENTO"].ToString() + " - " + leitor["BAIRRO"].ToString());
                        recibo.Add(paragrafo);
                    }

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("CEP " + leitor["CEP"].ToString() + " - " + leitor["CIDADE"].ToString() + " - " + leitor["ESTADO"].ToString());
                    recibo.Add(paragrafo);


                    if ((leitor["TELEFONE"].ToString() == "(  )     -") && (leitor["CELULAR"].ToString() != "(  )     -"))
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add("FONE: " + leitor["CELULAR"].ToString());
                        recibo.Add(paragrafo);
                    }
                    else if ((leitor["TELEFONE"].ToString() != "(  )     -") && (leitor["CELULAR"].ToString() == "(  )     -"))
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add("FONE: " + leitor["TELEFONE"].ToString());
                        recibo.Add(paragrafo);
                    }
                    else
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add("FONE: " + leitor["TELEFONE"].ToString() + " / " + leitor["CELULAR"].ToString());
                        recibo.Add(paragrafo);
                    }

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("E-MAIL: " + leitor["EMAIL"].ToString());
                    recibo.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add(" ");
                    recibo.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("COMPROVANTE NÃO FISCAL");
                    recibo.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add(" ");
                    recibo.Add(paragrafo);

                }


                else
                {
                    //-----------------------------------------------------------------------------------
                    //PARAGRAFOS DE INICIO

                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("ALTERNATIVA MOTOS");
                    recibo.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("COMPROVANTE NÃO FISCAL");
                    recibo.Add(paragrafo);

                    for (int I = 0; I < 3; I++)
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add(" ");
                        recibo.Add(paragrafo);
                    }

                 
                }
                leitor.Close();
                conexao.Close();
            }

            //TABELA COM OS DADOS DO CLIENTE
            PdfPTable CABECALHO = new PdfPTable(2);
            CABECALHO.TotalWidth = 500f;
            CABECALHO.LockedWidth = true;
            float[] widths = new float[] { 325f, 175f };
            CABECALHO.SetWidths(widths);
           

            Paragraph coluna1 = new Paragraph();
            Paragraph coluna2 = new Paragraph();
            

            var cel1 = new PdfPCell();
            var cel2 = new PdfPCell();

            
            cel1.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cel2.Border = iTextSharp.text.Rectangle.NO_BORDER;
            

            cel1.AddElement(coluna1);
            cel2.AddElement(coluna2);
            

            CABECALHO.AddCell(cel1);
            CABECALHO.AddCell(cel2);
            


            Phrase item1 = new Phrase("Cliente: " + Tcliente.Text);
            var cel = new PdfPCell(item1);
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            CABECALHO.AddCell(cel);

            Phrase item3 = new Phrase("Documento: " + MCPF.Text);
            cel = new PdfPCell(item3);
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            CABECALHO.AddCell(cel);
            

            Phrase item4 = new Phrase("Atendente: " + TUser.Text);
            cel = new PdfPCell(item4);
            cel.Colspan = 2;
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            CABECALHO.AddCell(cel);

            Phrase item7 = new Phrase("Venda Nº: " + TCodigo.Text);
            cel = new PdfPCell(item7);
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            CABECALHO.AddCell(cel);

            Phrase item9 = new Phrase("Data: " + DateTime.Now.ToShortDateString());
            cel = new PdfPCell(item9);
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            CABECALHO.AddCell(cel);
            recibo.Add(CABECALHO);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add(" ");
            recibo.Add(paragrafo);

            //TABELA DAS PEÇAS
            PdfPTable ITEMS = new PdfPTable(3);
            ITEMS.TotalWidth = 500f;
            ITEMS.LockedWidth = true;
            float[] widths2 = new float[] { 100F, 270f, 130f };
            ITEMS.SetWidths(widths2);

            Paragraph coluna3 = new Paragraph("Quant.");
            Paragraph coluna4 = new Paragraph("Descrição das Peças");
            Paragraph coluna5 = new Paragraph("Valor");


            var cel3 = new PdfPCell();
            var cel4 = new PdfPCell();
            var cel5 = new PdfPCell();

            coluna3.Alignment = Element.ALIGN_CENTER;
            coluna4.Alignment = Element.ALIGN_CENTER;
            coluna5.Alignment = Element.ALIGN_CENTER;

           
            cel3.AddElement(coluna3);
            cel4.AddElement(coluna4);
            cel5.AddElement(coluna5);


            ITEMS.AddCell(cel3);
            ITEMS.AddCell(cel4);
            ITEMS.AddCell(cel5);


            Phrase v1, v2, v3;

            v1 = new Phrase(" ");
            v1.Font.Size = 2;
            cel = new PdfPCell(v1);
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            ITEMS.AddCell(cel);

            v2 = new Phrase(" ");
            v2.Font.Size = 2;
            cel = new PdfPCell(v2);
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            ITEMS.AddCell(cel);

            v3 = new Phrase(" ");
            v3.Font.Size = 2;
            cel = new PdfPCell(v3);
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            ITEMS.AddCell(cel);

            //BUSCANDO DA TABELA DE ITEMS
            foreach (ListViewItem lista in ListadeItem.Items)
            {
                v1 = new Phrase(lista.SubItems[2].Text);
                cel = new PdfPCell(v1);
                ITEMS.AddCell(cel);

                v2 = new Phrase(lista.Text);
                cel = new PdfPCell(v2);
                ITEMS.AddCell(cel);

                v3 = new Phrase("R$" + lista.SubItems[1].Text);
                cel = new PdfPCell(v3);
                cel.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                ITEMS.AddCell(cel);

            }

            v1 = new Phrase(" ");
            v1.Font.Size = 2;
            cel = new PdfPCell(v1);
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            ITEMS.AddCell(cel);

            v2 = new Phrase(" ");
            v2.Font.Size = 2;
            cel = new PdfPCell(v2);
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            ITEMS.AddCell(cel);

            v3 = new Phrase(" ");
            v3.Font.Size = 2;
            cel = new PdfPCell(v3);
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            ITEMS.AddCell(cel);

           
            //-------------------------------------------------------------------------

            v1 = new Phrase(" ");
            cel = new PdfPCell(v1);
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            ITEMS.AddCell(cel);

            v2 = new Phrase(" ");
            cel = new PdfPCell(v2);
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            ITEMS.AddCell(cel);

            if (radiograna.Checked == true)
            {
                v3 = new Phrase("DESC.: R$" + TDesconto.Text);
                cel = new PdfPCell(v3);
                cel.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                ITEMS.AddCell(cel);
            }
            else if(Radioporcento.Checked == true)
            {
                v3 = new Phrase("DESC.: % " + TDesconto.Text);
                cel = new PdfPCell(v3);
                cel.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                ITEMS.AddCell(cel);
            }
            //------------------------------------------------------------------
            v1 = new Phrase(" ");
            cel = new PdfPCell(v1);
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            ITEMS.AddCell(cel);

            v2 = new Phrase(" ");
            cel = new PdfPCell(v2);
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            ITEMS.AddCell(cel);

            v3 = new Phrase("TOTAL: R$" + TValorTotal.Text);
            cel = new PdfPCell(v3);
            cel.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
            ITEMS.AddCell(cel);
            
            recibo.Add(ITEMS);
            //------------------------------------------------------------------
            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Font.Size = 20;
            paragrafo.Add(" ");
            recibo.Add(paragrafo);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            paragrafo.Font.Size = 10;
            paragrafo.Add("         " + "Prezado Cliente: A moto só será liberada após o pagamento do(s) serviço(s) acima discriminado(s)");
            recibo.Add(paragrafo);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add(" ");
            recibo.Add(paragrafo);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add(" ");
            recibo.Add(paragrafo);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add(" ");
            recibo.Add(paragrafo);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("____________________________");
            recibo.Add(paragrafo);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Font.Size = 10;
            paragrafo.Add("Assinatura");
            recibo.Add(paragrafo);
            //-------------------------------------------------------------------

            //TEM QUE FECHAR O PDF PARA QUE CONSIGA VIZUALIZAR
            recibo.Close();
        }

        private void TQtd_Leave(object sender, EventArgs e)
        {
            verletra();
        }
        public void verletra()
        {
            int lt = 0;
            foreach (var letra in TQtd.Text)
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
                MessageBox.Show("Quantidade não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TQtd.Text = "0";
            }

        }

        private void TDesconto_Leave(object sender, EventArgs e)
        {
            verdesc();
        }
        public void verdesc()
        {
            int lt = 0;
            foreach (var letra in TDesconto.Text)
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
                MessageBox.Show("Desconto não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TDesconto.Text = "0";
            }

        }

        private void MCPF_Leave(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "select nome,situacao from clientes where cpf = '"+MCPF.Text + "'";

            SqlCommand pegacodigo = new SqlCommand(vQuery, conexao);

            SqlDataReader dr;

            dr = pegacodigo.ExecuteReader();
            if(dr.Read() ==true)
            {
                Tcliente.Text = dr["nome"].ToString();
                situacao = dr["situacao"].ToString();
            }

        }

        public void AtribuiCodigo()
        {
            int codigo;
            SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "select MAX(CODVENDAITEM) as valor from vendas";

            SqlCommand pegacodigo = new SqlCommand(vQuery, conexao);

            SqlDataReader dr;

            dr = pegacodigo.ExecuteReader();

            if (dr.Read() == false)
            {
                codigo = 1;
            }
            else
            {
                if (dr["valor"].ToString() == "")
                    codigo = 1;
                else
                    codigo = int.Parse(dr["valor"].ToString()) + 1;
            }

            dr.Close();

            TCodigo.Text = codigo.ToString();

            conexao.Close();
        }
        
    }
}