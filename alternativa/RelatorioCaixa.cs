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
    public partial class RelatorioCaixa : Form
    {
        int cancela;
        public RelatorioCaixa(int tipo,int cancel)
        {
            InitializeComponent();
            selecionatipo(tipo);
            cancela = cancel;
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
            Document relatorio = new Document(PageSize.A4);
            relatorio.SetMargins(30, 20, 30, 20);
            relatorio.AddCreationDate();

            //CAMINHO ONDE O PDF É SALVO E O NOME DO PDF
            string caminho = @"C:\Users\defar\Desktop\relatorio.pdf";

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
                        case 1: paragrafo.Add("RELATÓRIO DE VENDAS - MENSAL"); break;
                        case 2: paragrafo.Add("RELATÓRIO DE VENDAS - PERIÓDICO"); break;
                        case 3: paragrafo.Add("RELATÓRIO DE VENDAS - DIÁRIO"); break;
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
                    paragrafo.Add("RELATÓRIO DE VENDAS");
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
                PdfPTable CABECALHO = new PdfPTable(5);

                CABECALHO.TotalWidth = 550f;
                CABECALHO.LockedWidth = true;
                float[] widths = new float[] { 75f, 85f, 250f, 60f, 70f };
                CABECALHO.SetWidths(widths);


                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();

                if ((tipo == 1) && (cancela == 0))
                {
                    selecionafilme = new SqlCommand("SELECT CODVENDAITEM AS COD, DATA, CLIENTE, VALOR, SITUACAO FROM VENDAS WHERE month(DATA) = '" + DTInicio.Value.Month + "'", conexao);
                }
                if ((tipo == 2) && (cancela == 0))
                {
                    selecionafilme = new SqlCommand("SELECT CODVENDAITEM AS COD, DATA, CLIENTE, VALOR, SITUACAO FROM VENDAS WHERE DATA between '" + DTInicio.Value + "' and '" + DTFim.Value + "'", conexao);
                }
                if ((tipo == 3) && (cancela == 0))
                {
                    selecionafilme = new SqlCommand("SELECT CODVENDAITEM AS COD, DATA, CLIENTE, VALOR, SITUACAO FROM VENDAS WHERE DATA = '" + DTInicio.Value + "'", conexao);
                }
                if ((tipo == 1) && (cancela == 1))
                {
                    selecionafilme = new SqlCommand("SELECT CODVENDAITEM AS COD, DATA, CLIENTE, VALOR, SITUACAO FROM VENDAS WHERE month(DATA) = '" + DTInicio.Value.Month + "' and situacao = 'Cancelada' order by DATA asc", conexao);
                }
                if ((tipo == 2) && (cancela == 1))
                {
                    selecionafilme = new SqlCommand("SELECT CODVENDAITEM AS COD, DATA, CLIENTE, VALOR, SITUACAO FROM VENDAS WHERE DATA between '" + DTInicio.Value + "' and '" + DTFim.Value + "' and situacao = 'Cancelada' order by DATA asc", conexao);
                }
                if ((tipo == 3) && (cancela == 1))
                {
                    selecionafilme = new SqlCommand("SELECT CODVENDAITEM AS COD, DATA, CLIENTE, VALOR, SITUACAO FROM VENDAS WHERE DATA = '" + DTInicio.Value + " 'and situacao = 'Cancelada'  order by DATA asc", conexao);
                }

                Phrase item1 = new Phrase("Nº da Venda");
                var cel = new PdfPCell(item1);
                CABECALHO.AddCell(cel);

                Phrase item2 = new Phrase("Data da Venda");
                cel = new PdfPCell(item2);
                CABECALHO.AddCell(cel);


                Phrase item3 = new Phrase("Cliente");
                cel = new PdfPCell(item3);
                cel.Colspan = 1;
                CABECALHO.AddCell(cel);

                Phrase item4 = new Phrase("Valor");
                cel = new PdfPCell(item4);
                CABECALHO.AddCell(cel);

                Phrase item5 = new Phrase("Situação");
                cel = new PdfPCell(item5);
                CABECALHO.AddCell(cel);

                item1 = new Phrase(" ");
                item1.Font.Size = 2;
                cel = new PdfPCell(item1);
                cel.Colspan = 5;
                cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
                CABECALHO.AddCell(cel);
                double valor;
                DateTime data;

                leitor = selecionafilme.ExecuteReader();
                while(leitor.Read() != false)
                {
                    item1 = new Phrase(leitor["COD"].ToString());
                    cel = new PdfPCell(item1);
                    CABECALHO.AddCell(cel);

                    data = DateTime.Parse(leitor["DATA"].ToString());
                    item2 = new Phrase(data.ToShortDateString());
                    cel = new PdfPCell(item2);
                    CABECALHO.AddCell(cel);


                    item3 = new Phrase(leitor["CLIENTE"].ToString());
                    cel = new PdfPCell(item3);
                    cel.Colspan = 1;
                    CABECALHO.AddCell(cel);

                    valor = double.Parse(leitor["VALOR"].ToString());
                    item4 = new Phrase("R$"+valor.ToString("0.00"));
                    cel = new PdfPCell(item4);
                    CABECALHO.AddCell(cel);

                    item5 = new Phrase(leitor["SITUACAO"].ToString());
                    cel = new PdfPCell(item5);
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
                if (cancela != 1)
                {
                    conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    switch (tipo)
                    {
                        case 1:
                            {
                                selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM VENDAS WHERE month(DATA) = '" + DTInicio.Value.Month + "' AND SITUACAO = 'Finalizada'", conexao);
                            }; break;
                        case 2:
                            {
                                selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM VENDAS WHERE DATA between '" + DTInicio.Value + "' and '" + DTFim.Value + "' AND SITUACAO = 'Finalizada'", conexao);
                            }; break;
                        case 3:
                            {
                                selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM VENDAS WHERE DATA = '" + DTInicio.Value + "' AND SITUACAO = 'Finalizada'", conexao);
                            }; break;

                    }


                    leitor = selecionafilme.ExecuteReader();
                    leitor.Read();
                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    double finalizadas;
                    if (leitor["valor"].ToString() == "")
                    {
                        finalizadas = 0;
                        paragrafo.Add("Total de Vendas Finalizadas: R$" + finalizadas.ToString("0.00"));
                    }
                    else
                    {
                        finalizadas = double.Parse(leitor["valor"].ToString());
                        paragrafo.Add("Total de Vendas Finalizadas: R$" + finalizadas.ToString("0.00"));
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
                                selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM VENDAS WHERE month(DATA) = '" + DTInicio.Value.Month + "' AND SITUACAO = 'Cancelada'", conexao);
                            }; break;
                        case 2:
                            {
                                selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM VENDAS WHERE DATA between '" + DTInicio.Value + "' and '" + DTFim.Value + "' AND SITUACAO = 'Cancelada'", conexao);
                            }; break;
                        case 3:
                            {
                                selecionafilme = new SqlCommand("SELECT SUM(VALOR) as valor FROM VENDAS WHERE DATA = '" + DTInicio.Value + "' AND SITUACAO = 'Cancelada'", conexao);
                            }; break;

                    }

                    leitor = selecionafilme.ExecuteReader();
                    leitor.Read();
                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    double canceladas;
                    if (leitor["valor"].ToString() == "")
                    {
                        canceladas = 0;
                        paragrafo.Add("Total de Vendas Canceladas: R$" + canceladas.ToString("0.00"));
                    }
                    else
                    {
                        canceladas = double.Parse(leitor["valor"].ToString());
                        paragrafo.Add("Total de Vendas Canceladas: R$" + canceladas.ToString("0.00"));
                    }
                    relatorio.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add(" ");
                    relatorio.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    double geral = finalizadas - canceladas;
                    paragrafo.Add("Saldo das vendas: R$" + geral.ToString("0.00"));
                    relatorio.Add(paragrafo);
                }

                //TEM QUE FECHAR O PDF PARA QUE CONSIGA VIZUALIZAR
                relatorio.Close();
                //APRESENTA O PDF
                System.Diagnostics.Process.Start(@"C:\Users\defar\Desktop\relatorio.pdf");

            }

        }
    }
}
