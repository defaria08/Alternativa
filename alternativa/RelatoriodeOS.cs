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
    public partial class RelatoriodeOS : Form
    {
   
        public RelatoriodeOS()
        {
            InitializeComponent();
           
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
            string caminho = @"C:\Users\defar\Desktop\relatorioos.pdf";

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
                        case 1: paragrafo.Add("RELATÓRIO DE OS - MENSAL"); break;
                        case 2: paragrafo.Add("RELATÓRIO DE OS - PERIÓDICO"); break;
                        case 3: paragrafo.Add("RELATÓRIO DE OS - DIÁRIO"); break;
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
                    paragrafo.Add("RELATÓRIO DE OS");
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

                CABECALHO.TotalWidth = 800;
                CABECALHO.LockedWidth = true;
                float[] widths = new float[] { 70f, 180f, 150f, 80f, 150f, 80f,100f };
                CABECALHO.SetWidths(widths);


                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();

                if((cmecanico.Text == "") && (csituacao.Text == ""))
                {
                    switch (tipo)
                    {
                        case 1:
                            {
                                selecionafilme = new SqlCommand("select codigo,cliente,marca,modelo,situacao,mecanico,valortotal,datae FROM os WHERE month(datae) = '" + DTInicio.Value.Month + "'", conexao);
                            }; break;
                        case 2:
                            {
                                selecionafilme = new SqlCommand("select codigo,cliente,marca,modelo,situacao,mecanico,valortotal,datae FROM os WHERE datae between '" + DTInicio.Value + "'", conexao);
                            }; break;
                        case 3:
                            {
                                selecionafilme = new SqlCommand("select codigo,cliente,marca,modelo,situacao,mecanico,valortotal,datae FROM os WHERE datae= '" + DTInicio.Value + "'", conexao);
                            }; break;

                    }
                }
                else if ((cmecanico.Text != "") && (csituacao.Text == ""))
                {
                    switch (tipo)
                    {
                        case 1:
                            {
                                selecionafilme = new SqlCommand("select codigo,cliente,marca,modelo,situacao,mecanico,valortotal,datae FROM os WHERE month(datae) = '" + DTInicio.Value.Month + "' and mecanico = '" + cmecanico.Text + "'", conexao);
                            }; break;
                        case 2:
                            {
                                selecionafilme = new SqlCommand("select codigo,cliente,marca,modelo,situacao,mecanico,valortotal,datae FROM os WHERE datae between '" + DTInicio.Value + "' and '" + DTFim.Value + "' and mecanico = '" + cmecanico.Text + "'", conexao);
                            }; break;
                        case 3:
                            {
                                selecionafilme = new SqlCommand("select codigo,cliente,marca,modelo,situacao,mecanico,valortotal,datae FROM os WHERE datae= '" + DTInicio.Value + "' and mecanico = '" + cmecanico.Text + "'", conexao);
                            }; break;

                    }
                }
                else if ((cmecanico.Text == "") && (csituacao.Text != ""))
                {
                    switch (tipo)
                    {
                        case 1:
                            {
                                selecionafilme = new SqlCommand("select codigo,cliente,marca,modelo,situacao,mecanico,valortotal,datae FROM os WHERE month(datae) = '" + DTInicio.Value.Month + "'", conexao);
                            }; break;
                        case 2:
                            {
                                selecionafilme = new SqlCommand("select codigo,cliente,marca,modelo,situacao,mecanico,valortotal,datae FROM os WHERE datae between '" + DTInicio.Value + "'", conexao);
                            }; break;
                        case 3:
                            {
                                selecionafilme = new SqlCommand("select codigo,cliente,marca,modelo,situacao,mecanico,valortotal,datae FROM os WHERE datae= '" + DTInicio.Value + "'", conexao);
                            }; break;

                    }
                }
                else
                {
                    switch (tipo)
                    {
                        case 1:
                            {
                                selecionafilme = new SqlCommand("select codigo,cliente,marca,modelo,situacao,mecanico,valortotal,datae FROM os WHERE month(datae) = '" + DTInicio.Value.Month + "' and mecanico = '" + cmecanico.Text + "' and situacao = '" + csituacao.Text + "'", conexao);
                            }; break;
                        case 2:
                            {
                                selecionafilme = new SqlCommand("select codigo,cliente,marca,modelo,situacao,mecanico,valortotal,datae FROM os WHERE datae between '" + DTInicio.Value + "' and '" + DTFim.Value + "' and mecanico = '" + cmecanico.Text + "' and situacao = '" + csituacao.Text + "'", conexao);
                            }; break;
                        case 3:
                            {
                                selecionafilme = new SqlCommand("select codigo,cliente,marca,modelo,situacao,mecanico,valortotal,datae FROM os WHERE datae= '" + DTInicio.Value + "' and mecanico = '" + cmecanico.Text + "' and situacao = '" + csituacao.Text + "'", conexao);
                            }; break;

                    }
                }

                Phrase item1 = new Phrase("Nº da OS");
                var cel = new PdfPCell(item1);
                CABECALHO.AddCell(cel);

                Phrase item2 = new Phrase("Cliente");
                cel = new PdfPCell(item2);
                CABECALHO.AddCell(cel);


                Phrase item3 = new Phrase("Veículo");
                cel = new PdfPCell(item3);
                cel.Colspan = 1;
                CABECALHO.AddCell(cel);

                Phrase item4 = new Phrase("Situação");
                cel = new PdfPCell(item4);
                CABECALHO.AddCell(cel);

                Phrase item5 = new Phrase("Mecânico");
                cel = new PdfPCell(item5);
                CABECALHO.AddCell(cel);

                Phrase item6 = new Phrase("Valor Total");
                cel = new PdfPCell(item6);
                CABECALHO.AddCell(cel);

                Phrase item7 = new Phrase("Data de Entrada");
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

                    
                    item1 = new Phrase(leitor["codigo"].ToString()); 
                    cel = new PdfPCell(item1);
                    CABECALHO.AddCell(cel);

                    item2 = new Phrase(leitor["cliente"].ToString());
                    cel = new PdfPCell(item2);
                    CABECALHO.AddCell(cel);


                    item3 = new Phrase(leitor["marca"].ToString() + " " + leitor["modelo"].ToString());
                    cel = new PdfPCell(item3);
                    cel.Colspan = 1;
                    CABECALHO.AddCell(cel);

                    item4 = new Phrase(leitor["situacao"].ToString());
                    cel = new PdfPCell(item4);
                    CABECALHO.AddCell(cel);

                    item5 = new Phrase(leitor["mecanico"].ToString());
                    cel = new PdfPCell(item5);
                    CABECALHO.AddCell(cel);

                    valor = double.Parse(leitor["valortotal"].ToString());
                    item6 = new Phrase("R$" + valor.ToString("0.00"));
                    cel = new PdfPCell(item6);
                    CABECALHO.AddCell(cel);

                    data = DateTime.Parse(leitor["datae"].ToString());
                    item7 = new Phrase(data.ToShortDateString());
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

                
               


                //TEM QUE FECHAR O PDF PARA QUE CONSIGA VIZUALIZAR
                relatorio.Close();
                //APRESENTA O PDF
                System.Diagnostics.Process.Start(@"C:\Users\defar\Desktop\relatorioos.pdf");

            }

        }
    }
}
