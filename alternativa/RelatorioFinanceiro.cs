using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alternativa
{
    public partial class RelatorioFinanceiro : Form
    {
        public RelatorioFinanceiro(int tipo)
        {
            InitializeComponent();
            selecionatipo(tipo);
        }
        public void selecionatipo(int tipo)
        {
            switch(tipo)
            {
                case 1: { RMEnsal.Checked = true; RPeriodico.Checked = false; Rdiario.Checked = false; LTipo.Text = "Selecione o Mês"; DTFim.Visible = false; } break;
                case 2: { RMEnsal.Checked = false; RPeriodico.Checked = true; Rdiario.Checked = false; LTipo.Text = "Selecione o Período"; DTFim.Visible = true; } break;
                case 3: { RMEnsal.Checked = false; RPeriodico.Checked = false; Rdiario.Checked = true; LTipo.Text = "Selecione o Dia"; DTFim.Visible = false; } break;
            }
        }

        private void RMEnsal_CheckedChanged(object sender, EventArgs e)
        {
         
            
            LTipo.Text = "Selecione o Mês";
            DTFim.Visible = false;
        }

        private void RPeriodico_CheckedChanged(object sender, EventArgs e)
        {
       
            LTipo.Text = "Selecione o Período";
            DTFim.Visible = true;
        }

        private void Rdiario_CheckedChanged(object sender, EventArgs e)
        {
            DTInicio.Value = DateTime.Now;
            LTipo.Text = "Selecione o Dia";
            DTFim.Visible = false;
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BGerar_Click(object sender, EventArgs e)
        {
            if (RMEnsal.Checked == true)
            {
                GeraRel(1);
            }
            else if(RPeriodico.Checked == true)
            {
                GeraRel(2);
            }
            else
            {
                GeraRel(3);
            }
        }

        public void GeraRel(int tipo)
        {
            //CRIA O PDF
            Document relatorio = new Document(iTextSharp.text.PageSize.A4.Rotate());
            relatorio.SetMargins(10, 10, 10, 10);
            relatorio.AddCreationDate();

            //CAMINHO ONDE O PDF É SALVO E O NOME DO PDF
            string caminho = @"C:\Users\defar\Desktop\relatoriof.pdf";

            PdfWriter writer = PdfWriter.GetInstance(relatorio, new FileStream(caminho, FileMode.Create));

            //ABRI O PDF
            relatorio.Open();

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
                    relatorio.Add(paragrafo);

                    if (leitor["COMPLEMENTO"].ToString() == "")
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add(leitor["ENDERECO"].ToString() + ", " + leitor["NUMERO"].ToString() + " - " + leitor["BAIRRO"].ToString());
                        relatorio.Add(paragrafo);
                    }
                    else
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add(leitor["ENDERECO"].ToString() + ", " + leitor["NUMERO"].ToString() + ", " + leitor["COMPLEMENTO"].ToString() + " - " + leitor["BAIRRO"].ToString());
                        relatorio.Add(paragrafo);
                    }

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("CEP " + leitor["CEP"].ToString() + " - " + leitor["CIDADE"].ToString() + " - " + leitor["ESTADO"].ToString());
                    relatorio.Add(paragrafo);


                    if ((leitor["TELEFONE"].ToString() == "(  )     -") && (leitor["CELULAR"].ToString() != "(  )     -"))
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add("FONE: " + leitor["CELULAR"].ToString());
                        relatorio.Add(paragrafo);
                    }
                    else if ((leitor["TELEFONE"].ToString() != "(  )     -") && (leitor["CELULAR"].ToString() == "(  )     -"))
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add("FONE: " + leitor["TELEFONE"].ToString());
                        relatorio.Add(paragrafo);
                    }
                    else
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add("FONE: " + leitor["TELEFONE"].ToString() + " / " + leitor["CELULAR"].ToString());
                        relatorio.Add(paragrafo);
                    }

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("E-MAIL: " + leitor["EMAIL"].ToString());
                    relatorio.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add(" ");
                    relatorio.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    switch (tipo)
                    {
                        case 1: paragrafo.Add("RELATÓRIO FINANCEIRO - MENSAL"); break;
                        case 2: paragrafo.Add("RELATÓRIO FINANCEIRO - PERIÓDICO"); break;
                        case 3: paragrafo.Add("RELATÓRIO FINANCEIRO - DIÁRIO"); break;
                    }
                    relatorio.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add(" ");
                    relatorio.Add(paragrafo);

                }


                else
                {
                    //-----------------------------------------------------------------------------------
                    //PARAGRAFOS DE INICIO

                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("ALTERNATIVA MOTOS");
                    relatorio.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("RELATÓRIO FINANCEIRO");
                    relatorio.Add(paragrafo);

                    for (int I = 0; I < 3; I++)
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add(" ");
                        relatorio.Add(paragrafo);
                    }


                }
                leitor.Close();
                conexao.Close();

                //TABELA COM OS DADOS DO CLIENTE
                PdfPTable CABECALHO = new PdfPTable(7);

                CABECALHO.TotalWidth = 800f;
                CABECALHO.LockedWidth = true;
                float[] widths = new float[] { 85f, 95f, 80f, 80f, 90f, 290f,80f };
                CABECALHO.SetWidths(widths);


                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();

                switch (tipo)
                {
                    case 1:
                        {
                            selecionafilme = new SqlCommand("SELECT datacaixa as data, usuario , operacao, valor, tipo, justificativa, aprovacao FROM movimentacoes WHERE month(datacaixa) = '" + DTInicio.Value.Month + "' order by datacaixa asc", conexao);
                        }; break;
                    case 2:
                        {
                            selecionafilme = new SqlCommand("SELECT datacaixa as data, usuario , operacao, valor, tipo, justificativa, aprovacao FROM movimentacoes WHERE datacaixa between '" + DTInicio.Value + "' and '" + DTFim.Value + "' order by datacaixa asc", conexao);
                        }; break;
                    case 3:
                        {
                            selecionafilme = new SqlCommand("SELECT datacaixa as data, usuario , operacao, valor, tipo, justificativa, aprovacao FROM movimentacoes WHERE datacaixa = '" + DTInicio.Value + "' order by datacaixa asc", conexao);
                        };break;

                }
                Phrase item1 = new Phrase("Data do Caixa");
                var cel = new PdfPCell(item1);
                CABECALHO.AddCell(cel);

                Phrase item2 = new Phrase("Usuário");
                cel = new PdfPCell(item2);
                CABECALHO.AddCell(cel);


                Phrase item3 = new Phrase("Operação");
                cel = new PdfPCell(item3);
                cel.Colspan = 1;
                CABECALHO.AddCell(cel);

                Phrase item4 = new Phrase("Valor");
                cel = new PdfPCell(item4);
                CABECALHO.AddCell(cel);

                Phrase item5 = new Phrase("Tipo");
                cel = new PdfPCell(item5);
                CABECALHO.AddCell(cel);

                Phrase item6 = new Phrase("Justificativa");
                cel = new PdfPCell(item6);
                CABECALHO.AddCell(cel);

                Phrase item7 = new Phrase("Aprovação");
                cel = new PdfPCell(item7);
                CABECALHO.AddCell(cel);

                item1 = new Phrase(" ");
                item1.Font.Size = 2;
                cel = new PdfPCell(item1);
                cel.Colspan = 7;
                cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
                CABECALHO.AddCell(cel);
                double valor;
                DateTime data;

                leitor = selecionafilme.ExecuteReader();
                while(leitor.Read() != false)
                {

                    data = DateTime.Parse(leitor["data"].ToString());
                    item1 = new Phrase(data.ToShortDateString()); 
                    cel = new PdfPCell(item1);
                    CABECALHO.AddCell(cel);

                    item2 = new Phrase(leitor["usuario"].ToString());
                    cel = new PdfPCell(item2);
                    CABECALHO.AddCell(cel);


                    item3 = new Phrase(leitor["operacao"].ToString());
                    cel = new PdfPCell(item3);
                    cel.Colspan = 1;
                    CABECALHO.AddCell(cel);

                    valor = double.Parse(leitor["valor"].ToString());
                    item4 = new Phrase("R$"+valor.ToString("0.00"));
                    cel = new PdfPCell(item4);
                    CABECALHO.AddCell(cel);

                    item5 = new Phrase(leitor["tipo"].ToString());
                    cel = new PdfPCell(item5);
                    CABECALHO.AddCell(cel);

                    item6 = new Phrase(leitor["justificativa"].ToString());
                    cel = new PdfPCell(item6);
                    CABECALHO.AddCell(cel);

                    item7 = new Phrase(leitor["aprovacao"].ToString());
                    cel = new PdfPCell(item7);
                    CABECALHO.AddCell(cel);



                }
                conexao.Close();
                leitor.Close();


                item1 = new Phrase(" ");
                item1.Font.Size = 2;
                cel = new PdfPCell(item1);
                cel.Colspan = 5;
                cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
                CABECALHO.AddCell(cel);

                relatorio.Add(CABECALHO);

                paragrafo = new Paragraph();
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(" ");
                relatorio.Add(paragrafo);

                paragrafo = new Paragraph();
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(" ");
                relatorio.Add(paragrafo);

                
                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();
                switch (tipo)
                {
                    case 1:
                        {
                            selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM movimentacoes WHERE month(datacaixa) = '" + DTInicio.Value.Month + "' AND operacao = 'Entrada'", conexao);
                        }; break;
                    case 2:
                        {
                            selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM movimentacoes WHERE datacaixa between '" + DTInicio.Value + "' and '" + DTFim.Value + "' AND operacao = 'Entrada'", conexao);
                        }; break;
                    case 3:
                        {
                            selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM movimentacoes WHERE datacaixa = '" + DTInicio.Value + "' AND operacao = 'Entrada'", conexao);
                        }; break;

                }

                leitor = selecionafilme.ExecuteReader();
                leitor.Read();
                paragrafo = new Paragraph();
                paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                double entrada;
                if (leitor["valor"].ToString() == "")
                {
                    entrada = 0;
                    paragrafo.Add("Total de Movimentações de Entrada: R$" + entrada.ToString("0.00"));
                }
                else
                {
                    entrada = double.Parse(leitor["valor"].ToString());
                    paragrafo.Add("Total de Movimentações de Entrada: R$" + entrada.ToString("0.00"));
                }
                relatorio.Add(paragrafo);

                conexao.Close();
                leitor.Close();

                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();
                switch (tipo)
                {
                    case 1:
                        {
                            selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM movimentacoes WHERE month(datacaixa) = '" + DTInicio.Value.Month + "' AND operacao = 'Saída'", conexao);
                        }; break;
                    case 2:
                        {
                            selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM movimentacoes WHERE datacaixa between '" + DTInicio.Value + "' and '" + DTFim.Value + "' AND operacao = 'Saída'", conexao);
                        }; break;
                    case 3:
                        {
                            selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM movimentacoes WHERE datacaixa = '" + DTInicio.Value + "' AND operacao = 'Saída'", conexao);
                        }; break;

                }

                leitor = selecionafilme.ExecuteReader();
                leitor.Read();
                paragrafo = new Paragraph();
                paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                double saida;
                if (leitor["valor"].ToString() == "")
                {
                    saida = 0;
                    paragrafo.Add("Total de Movimentações de Saída: R$" + saida.ToString("0.00"));
                }
                else
                {
                    saida = double.Parse(leitor["valor"].ToString());
                    paragrafo.Add("Total de Movimentações de Saída: R$" + saida.ToString("0.00"));
                }
                relatorio.Add(paragrafo);

                conexao.Close();
                leitor.Close();

                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();
                switch (tipo)
                {
                    case 1:
                        {
                            selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM movimentacoes WHERE month(datacaixa) = '" + DTInicio.Value.Month + "' AND operacao = 'Estorno'", conexao);
                        }; break;
                    case 2:
                        {
                            selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM movimentacoes WHERE datacaixa between '" + DTInicio.Value + "' and '" + DTFim.Value + "' AND operacao = 'EStorno'", conexao);
                        }; break;
                    case 3:
                        {
                            selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM movimentacoes WHERE datacaixa = '" + DTInicio.Value + "' AND operacao = 'Estorno'", conexao);
                        }; break;

                }

                leitor = selecionafilme.ExecuteReader();
                leitor.Read();
                paragrafo = new Paragraph();
                paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                double estorno;
                if (leitor["valor"].ToString() == "")
                {
                    estorno = 0;
                    paragrafo.Add("Total de Estornos: R$" + estorno.ToString("0.00"));
                }
                else
                {
                    estorno = double.Parse(leitor["valor"].ToString());
                    paragrafo.Add("Total de Estornos: R$" + estorno.ToString("0.00"));
                }
                relatorio.Add(paragrafo);

                paragrafo = new Paragraph();
                paragrafo.Alignment = Element.ALIGN_CENTER;
                paragrafo.Add(" ");
                relatorio.Add(paragrafo);

                paragrafo = new Paragraph();
                paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                double geral = entrada - saida - estorno;
                paragrafo.Add("Saldo das Movimentações: R$" + geral.ToString("0.00"));
                relatorio.Add(paragrafo);


                //TEM QUE FECHAR O PDF PARA QUE CONSIGA VIZUALIZAR
                relatorio.Close();
                //APRESENTA O PDF
                System.Diagnostics.Process.Start(@"C:\Users\defar\Desktop\relatoriof.pdf");

            }

        }
    }
}
