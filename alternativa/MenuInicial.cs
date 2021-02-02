using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alternativa
{
    public partial class MenuInicial : Form
    {
        string cod, nom, senha, classe;
        public MenuInicial(string id, string nome, string senh, string clas)
        {
            InitializeComponent();
            Calendario();
            cod = id;
            nom = nome;
            senha = senh;
            classe = clas;
            LNomeUser.Text = nom;
        }
        public void Calendario()
        {
            MCalendario.TodayDate = DateTime.Now;
            datasNegrito();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void BCliente_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes(0);
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void MCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes(0);
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (classe == "Administrador")
            {
                Usuario user = new Usuario(0);
                user.MdiParent = this;
                user.Show();
            }
            else
            {
                MessageBox.Show("Usuário não possui permissão","Alternativa Motos",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void BUsuario_Click(object sender, EventArgs e)
        {
            if (classe == "Administrador")
            {
                Usuario user = new Usuario(0);
                user.MdiParent = this;
                user.Show();
            }
            else
            {
                MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BProduto_Click(object sender, EventArgs e)
        {
            Produtos prod = new Produtos(0);
            prod.MdiParent = this;
            prod.Show();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Produtos prod = new Produtos(0);
            prod.MdiParent = this;
            prod.Show();
        }

        private void BFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedores forn = new Fornecedores(0);
            forn.MdiParent = this;
            forn.Show();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Fornecedores forn = new Fornecedores(0);
            forn.MdiParent = this;
            forn.Show();
        }

        private void BConta_Click(object sender, EventArgs e)
        {
            Conta2 contas = new Conta2(nom,classe);
            contas.MdiParent = this;
            contas.Show();
        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Conta2 contas = new Conta2(nom,classe);
            contas.MdiParent = this;
            contas.Show();
        }

        private void BVenda_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda(0,nom);
            venda.MdiParent = this;
            venda.Show();
        }

        private void novaVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda(0,nom);
            venda.MdiParent = this;
            venda.Show();
        }

        private void BOrdem_Click(object sender, EventArgs e)
        {
            OrdemdeServico os = new OrdemdeServico(0,classe);
            os.MdiParent = this;
            os.Show();
        }
        private void BuscarUSerClie1(object sender, EventArgs e)
        {
            BuscaUserCli busca = new BuscaUserCli(1);
            busca.MdiParent = this;
            busca.Show();
        }
        private void BuscarUSerClie2(object sender, EventArgs e)
        {
            BuscaUserCli busca = new BuscaUserCli(2);
            busca.MdiParent = this;
            busca.Show();
        }

        private void trocarSenhaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (classe == "Administrador")
            {
                TrocarSenha senha = new TrocarSenha();
                senha.MdiParent = this;
                senha.Show();
            }
            else
            {
                MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        private void pGMEIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www8.receita.fazenda.gov.br/SimplesNacional/Aplicacoes/ATSPO/pgmei.app/Identificacao");
        }

        private void correiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www2.correios.com.br/sistemas/rastreamento/default.cfm");

        }

        private void mercadoLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.mercadolivre.com.br/");

        }

        private void buscarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            BuscaFornecedor buscaf = new BuscaFornecedor();
            buscaf.MdiParent = this;
            buscaf.Show();
        }

        private void buscarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BuscaProduto buscap = new BuscaProduto();
            buscap.MdiParent = this;
            buscap.Show();
        }

        private void buscarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            BuscaContaa buscac = new BuscaContaa(nom, classe);
            buscac.MdiParent = this;
            buscac.Show();
        }

        private void buscarOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscaOS buscaOS = new BuscaOS(classe);
            buscaOS.MdiParent = this;
            buscaOS.Show();
        }

        private void BLogoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarEstoque estoque = new GerenciarEstoque();
            estoque.MdiParent = this;
            estoque.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarVenda bvenda = new BuscarVenda(classe,nom);
            bvenda.MdiParent = this;
            bvenda.Show();
        }

        private void MCalendario_DateChanged_1(object sender, DateRangeEventArgs e)
        {


            Agenda agenda = new Agenda(DateTime.Parse(MCalendario.SelectionStart.ToShortDateString()));
            agenda.MdiParent = this;
            agenda.Show();



        }

        public void datasNegrito()
        {
            //criar um adaptador
            SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            string query = "SELECT Datae FROM Agenda";
            SqlCommand cm = new SqlCommand(query, conexao);
            SqlDataReader reader = cm.ExecuteReader();
            string date;

            while (reader.Read())
            {
                date = Convert.ToString(reader["Datae"]);
                int dia = Convert.ToInt32(date.Substring(0, 2));
                int mes = Convert.ToInt32(date.Substring(3, 2));
                int ano = Convert.ToInt32(date.Substring(6, 4));
                string dataRecebe = Convert.ToString(ano) + "," + Convert.ToString(mes) + "," + Convert.ToString(dia);
                MCalendario.AddBoldedDate(Convert.ToDateTime(dataRecebe));

            }



        }

        private void abrirCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreCaixa caixa = new AbreCaixa("Abrir");
            caixa.MdiParent = this;
            caixa.Show();
        }

        private void fecharCaixaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbreCaixa caixa = new AbreCaixa("Fechar");
            caixa.MdiParent = this;
            caixa.Show();
        }

        private void retiradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (classe != "Administrador")
            {
           movimentacaodecaixa movi = new movimentacaodecaixa("Saída",nom);
            movi.MdiParent = this;
            movi.Show();
            }
            else
            {
                MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          
        }

        private void entradaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (classe != "Atendente")
            {
                movimentacaodecaixa movi = new movimentacaodecaixa("Entrada",nom);
                movi.MdiParent = this;
                movi.Show();

            }
            else
            {
                MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
            
          

        private void BMovimentacao_Click(object sender, EventArgs e)
        {
            if (classe != "Atendente")
            {
                movimentacaodecaixa movi = new movimentacaodecaixa("",nom);
                movi.MdiParent = this;
                movi.Show();

            }
            else
            {
                MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BFechaCaixa_Click(object sender, EventArgs e)
        {
            AbreCaixa caixa = new AbreCaixa("Fechar");
            caixa.MdiParent = this;
            caixa.Show();
        }

        private void BAbreCaixa_Click(object sender, EventArgs e)
        {
            AbreCaixa caixa = new AbreCaixa("Abrir");
            caixa.MdiParent = this;
            caixa.Show();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 empresa = new Form2();
            empresa.MdiParent = this;
            empresa.Show();
        }

        private void diárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (classe == "Administrador")
            {
                RelatorioCaixa relatorio = new RelatorioCaixa(3, 0);
                relatorio.MdiParent = this;
                relatorio.Show();
            }
            else
            {
                MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void períodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (classe == "Administrador")
            {
                RelatorioCaixa relatorio = new RelatorioCaixa(2, 0);
                relatorio.MdiParent = this;
                relatorio.Show();
            }
            else
            {
                MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mensalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (classe == "Administrador")
            {
                RelatorioCaixa relatorio = new RelatorioCaixa(1, 0);
                relatorio.MdiParent = this;
                relatorio.Show();
            }
            else
            {
                MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }

        private void mesalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (classe == "Administrador")
            {
                  RelatorioFinanceiro relatorio = new RelatorioFinanceiro(1);
            relatorio.MdiParent = this;
            relatorio.Show();
            }
            else
            {
                MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          
        }

        private void diárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (classe == "Administrador")
            {
                RelatorioFinanceiro relatorio = new RelatorioFinanceiro(3);
                relatorio.MdiParent = this;
                relatorio.Show();
            }
            else
            {
                MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void canceladasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (classe == "Administrador")
            {
                RelatorioCaixa relatorio = new RelatorioCaixa(4, 1);
                relatorio.MdiParent = this;
                relatorio.Show();
            }
            else
            {
                MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (classe == "Administrador")
            {
                RelatoriodeOS relaos = new RelatoriodeOS();
                relaos.MdiParent = this;
                relaos.Show();
            }
            else
            {
                MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void quantidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GERARELATORIO(2);

        }
        public void GERARELATORIO(int tipo)
        {
            //CRIA O PDF
            Document relatorio = new Document(PageSize.A4.Rotate());
            relatorio.SetMargins(30, 20, 30, 20);
            relatorio.AddCreationDate();

            //CAMINHO ONDE O PDF É SALVO E O NOME DO PDF
            string caminho = @"C:\Users\defar\Desktop\relatoriopr.pdf";

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
                    paragrafo.Add("RELATÓRIO DE PRODUTOS - MÍNIMO");

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
                    paragrafo.Add("RELATÓRIO DE PRODUTOS");
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

                if (tipo == 2)
                {

                    //TABELA COM OS DADOS DO CLIENTE
                    PdfPTable CABECALHO = new PdfPTable(7);

                    CABECALHO.TotalWidth = 650f;
                    CABECALHO.LockedWidth = true;
                    float[] widths = new float[] { 75f, 85f, 150f, 100f, 100f, 70f, 70f };
                    CABECALHO.SetWidths(widths);


                    conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    selecionafilme = new SqlCommand("SELECT CODIGO, CBARRAS,DESCRICAO,MARCA,MODELO,QUANTIDADE,ESTOQUEMIN FROM PRODUTOS where quantidade <= estoquemin and tipo = 'Produto'", conexao);


                    Phrase item1 = new Phrase("Código");
                    var cel = new PdfPCell(item1);
                    CABECALHO.AddCell(cel);

                    Phrase item2 = new Phrase("Cód. de Barras");
                    cel = new PdfPCell(item2);
                    CABECALHO.AddCell(cel);


                    Phrase item3 = new Phrase("Descrição");
                    cel = new PdfPCell(item3);
                    cel.Colspan = 1;
                    CABECALHO.AddCell(cel);

                    Phrase item4 = new Phrase("Marca");
                    cel = new PdfPCell(item4);
                    CABECALHO.AddCell(cel);

                    Phrase item5 = new Phrase("Modelo");
                    cel = new PdfPCell(item5);
                    CABECALHO.AddCell(cel);

                    Phrase item6 = new Phrase("Quantidade");
                    cel = new PdfPCell(item6);
                    CABECALHO.AddCell(cel);

                    Phrase item7 = new Phrase("Mínimo");
                    cel = new PdfPCell(item7);
                    CABECALHO.AddCell(cel);

                    item1 = new Phrase(" ");
                    item1.Font.Size = 2;
                    cel = new PdfPCell(item1);
                    cel.Colspan = 7;
                    cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
                    CABECALHO.AddCell(cel);


                    leitor = selecionafilme.ExecuteReader();
                    while (leitor.Read() != false)
                    {
                        item1 = new Phrase(leitor["CODIGO"].ToString());
                        cel = new PdfPCell(item1);
                        CABECALHO.AddCell(cel);

                        item2 = new Phrase(leitor["CBARRAS"].ToString());
                        cel = new PdfPCell(item2);
                        CABECALHO.AddCell(cel);


                        item3 = new Phrase(leitor["DESCRICAO"].ToString());
                        cel = new PdfPCell(item3);
                        cel.Colspan = 1;
                        CABECALHO.AddCell(cel);


                        item4 = new Phrase(leitor["MARCA"].ToString());
                        cel = new PdfPCell(item4);
                        CABECALHO.AddCell(cel);

                        item5 = new Phrase(leitor["MODELO"].ToString());
                        cel = new PdfPCell(item5);
                        CABECALHO.AddCell(cel);


                        item6 = new Phrase(leitor["QUANTIDADE"].ToString());
                        cel = new PdfPCell(item6);
                        CABECALHO.AddCell(cel);

                        item7 = new Phrase(leitor["ESTOQUEMIN"].ToString());
                        cel = new PdfPCell(item7);
                        CABECALHO.AddCell(cel);



                    }
                    conexao.Close();
                    leitor.Close();


                    item1 = new Phrase(" ");
                    item1.Font.Size = 2;
                    cel = new PdfPCell(item1);
                    cel.Colspan = 7;
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
                }
                else if (tipo == 1)
                {
                    //TABELA COM OS DADOS DO CLIENTE
                    PdfPTable CABECALHO = new PdfPTable(7);

                    CABECALHO.TotalWidth = 650f;
                    CABECALHO.LockedWidth = true;
                    float[] widths = new float[] { 75f, 85f, 150f, 100f, 100f, 70f, 70f };
                    CABECALHO.SetWidths(widths);


                    conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    selecionafilme = new SqlCommand("SELECT CODIGO, CBARRAS,DESCRICAO,MARCA,MODELO,PVENDA,QUANTIDADE FROM PRODUTOS", conexao);


                    Phrase item1 = new Phrase("Código");
                    var cel = new PdfPCell(item1);
                    CABECALHO.AddCell(cel);

                    Phrase item2 = new Phrase("Cód. de Barras");
                    cel = new PdfPCell(item2);
                    CABECALHO.AddCell(cel);


                    Phrase item3 = new Phrase("Descrição");
                    cel = new PdfPCell(item3);
                    cel.Colspan = 1;
                    CABECALHO.AddCell(cel);

                    Phrase item4 = new Phrase("Marca");
                    cel = new PdfPCell(item4);
                    CABECALHO.AddCell(cel);

                    Phrase item5 = new Phrase("Modelo");
                    cel = new PdfPCell(item5);
                    CABECALHO.AddCell(cel);

                    Phrase item6 = new Phrase("Preço de Venda");
                    cel = new PdfPCell(item6);
                    CABECALHO.AddCell(cel);

                    Phrase item7 = new Phrase("Quantidade");
                    cel = new PdfPCell(item7);
                    CABECALHO.AddCell(cel);

                    item1 = new Phrase(" ");
                    item1.Font.Size = 2;
                    cel = new PdfPCell(item1);
                    cel.Colspan = 7;
                    cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
                    CABECALHO.AddCell(cel);
                    double pvenda;

                    leitor = selecionafilme.ExecuteReader();
                    while (leitor.Read() != false)
                    {
                        item1 = new Phrase(leitor["CODIGO"].ToString());
                        cel = new PdfPCell(item1);
                        CABECALHO.AddCell(cel);

                        item2 = new Phrase(leitor["CBARRAS"].ToString());
                        cel = new PdfPCell(item2);
                        CABECALHO.AddCell(cel);


                        item3 = new Phrase(leitor["DESCRICAO"].ToString());
                        cel = new PdfPCell(item3);
                        cel.Colspan = 1;
                        CABECALHO.AddCell(cel);


                        item4 = new Phrase(leitor["MARCA"].ToString());
                        cel = new PdfPCell(item4);
                        CABECALHO.AddCell(cel);

                        item5 = new Phrase(leitor["MODELO"].ToString());
                        cel = new PdfPCell(item5);
                        CABECALHO.AddCell(cel);

                        pvenda = double.Parse(leitor["PVENDA"].ToString());
                        item6 = new Phrase(pvenda.ToString("0.00"));
                        cel = new PdfPCell(item6);
                        CABECALHO.AddCell(cel);

                        item7 = new Phrase(leitor["QUANTIDADE"].ToString());
                        cel = new PdfPCell(item7);
                        CABECALHO.AddCell(cel);



                    }
                    conexao.Close();
                    leitor.Close();


                    item1 = new Phrase(" ");
                    item1.Font.Size = 2;
                    cel = new PdfPCell(item1);
                    cel.Colspan = 7;
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
                }

            }

            //TEM QUE FECHAR O PDF PARA QUE CONSIGA VIZUALIZAR
            relatorio.Close();
            //APRESENTA O PDF
            System.Diagnostics.Process.Start(@"C:\Users\defar\Desktop\relatoriopr.pdf");
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GERARELATORIO(1);
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //APRESENTA O PDF
            System.Diagnostics.Process.Start(@"C:\Manual.pdf");
        }

        private void MCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            MCalendario.Refresh();
            Calendario();
        }

        private void periodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (classe == "Administrador")
            {
                RelatorioFinanceiro relatorio = new RelatorioFinanceiro(2);
                relatorio.MdiParent = this;
                relatorio.Show();
            }
            else
            {
                MessageBox.Show("Usuário não possui permissão", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void MenuInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
