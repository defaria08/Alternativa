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

    public partial class OrdemdeServico : Form
    {
        string situacao;
        int validacao;
        int os = 0;
        string problemarel, problemac, servicor, lischecklist = "a", obs, fechado;
        Pagamento pag;
        int codigo = 0, codvenda = 0;
        private void BSalvarProblemas_Click(object sender, EventArgs e)
        {
            problemarel = tprobrel.Text;
            problemac = tprobconst.Text;
            servicor = tservicorel.Text;
        }
        public void validacpf()
        {
            string valor = MDocumento.Text;
            if (radioButton2.Checked)
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
            else if (radioButton1.Checked)
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


        private void button3_Click(object sender, EventArgs e)
        {
            obs = Tobs.Text;
        }

        private void BLimparOBs_Click(object sender, EventArgs e)
        {
            limpaobs();
        }

        private void BlimparProblemas_Click(object sender, EventArgs e)
        {
            limpaproblemas();
        }
        public void vervp()
        {
            int lt = 0;
            foreach (var letra in TVLProduto.Text)
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
                MessageBox.Show("Valor dos Proutos não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TVLProduto.Text = "0";
            }

        }
        public void versv()
        {
            int lt = 0;
            foreach (var letra in TVLServico.Text)
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
                MessageBox.Show("Valor dos Serviços não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TVLServico.Text = "0";
            }

        }

        public void verdl()
        {
            int lt = 0;
            foreach (var letra in TDeslocamento.Text)
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
                MessageBox.Show("Valor do Deslocamento não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TDeslocamento.Text = "0";
            }

        }
        public void verdc()
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
                MessageBox.Show("Valor do Desconto não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TDesconto.Text = "0";
            }

        }
        public void vervt()
        {
            int lt = 0;
            foreach (var letra in ttotal.Text)
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
                MessageBox.Show("Valor Total não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ttotal.Text = "0";
            }

        }
        private void BGravar_Click(object sender, EventArgs e)
        {
            validacpf();
            if (validacao == 1)
            {

                    vercc();
                    vervp();
                    versv();
                    verdl();
                    verdc();
                    vervt();
                    lischecklist = "";

                    if (C1.Checked)
                    {
                        lischecklist = lischecklist + C1.Text + "|";
                    }
                    if (C2.Checked)
                    {
                        lischecklist = lischecklist + C2.Text + "|";
                    }
                    if (C3.Checked)
                    {
                        lischecklist = lischecklist + C3.Text + "|";
                    }
                    if (C4.Checked)
                    {
                        lischecklist = lischecklist + C4.Text + "|";
                    }
                    if (C5.Checked)
                    {
                        lischecklist = lischecklist + C5.Text + "|";
                    }
                    if (C6.Checked)
                    {
                        lischecklist = lischecklist + C6.Text + "|";
                    }
                    if (C7.Checked)
                    {
                        lischecklist = lischecklist + C7.Text + "|";
                    }
                    if (C8.Checked)
                    {
                        lischecklist = lischecklist + C8.Text + "|";
                    }
                    if (C9.Checked)
                    {
                        lischecklist = lischecklist + C9.Text + "|";
                    }
                    if (C10.Checked)
                    {
                        lischecklist = lischecklist + C10.Text + "|";
                    }
                    if (C11.Checked)
                    {
                        lischecklist = lischecklist + C11.Text + "|";
                    }
                    if (C12.Checked)
                    {
                        lischecklist = lischecklist + C12.Text + "|";
                    }
                    if (C13.Checked)
                    {
                        lischecklist = lischecklist + C13.Text + "|";
                    }
                    if (C14.Checked)
                    {
                        lischecklist = lischecklist + C14.Text + "|";
                    }
                    if (C15.Checked)
                    {
                        lischecklist = lischecklist + C15.Text + "|";
                    }
                    if (C16.Checked)
                    {
                        lischecklist = lischecklist + C16.Text + "|";
                    }

                    if (os == 0)
                    {
                        SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                        conexao.Open();

                        SqlCommand comandodeinsercao = new SqlCommand("Insert into OS (CLIENTE, DOCUMENTO, SITUACAO, DATAE," +
                                                                        "PREVISAO, MARCA, MODELO, CC, PLACA, COMBUSTIVEL, MECANICO," +
                                                                        "CHECKLIST, KMATUAL, NIVELCOMBUS, NIVELOLEO, PDIANTEIRO, PTRASEIRO," +
                                                                        "BATERIA, PROBLEMAREL, PROBLEMACONS, SERVICOREAL," +
                                                                        "OBSERVACAO, VALORPROD, VALORSERV, DESLOCAMENTO, " +
                                                                        "DESCONTO, VALORTOTAL)" +
                                                                        "values" +
                                                                        "(@CLIENTE, @DOCUMENTO, @SITUACAO, @DATAE," +
                                                                        "@PREVISAO, @MARCA, @MODELO, @CC, @PLACA, @COMBUSTIVEL, @MECANICO," +
                                                                        "@CHECKLIST, @KMATUAL, @NIVELCOMBUS, @NIVELOLEO, @PDIANTEIRO, @PTRASEIRO," +
                                                                        "@BATERIA, @PROBLEMAREL, @PROBLEMACONS, @SERVICOREAL," +
                                                                        "@OBSERVACAO, @VALORPROD, @VALORSERV, @DESLOCAMENTO, " +
                                                                        "@DESCONTO, @VALORTOTAL)", conexao);

                        SqlParameter CLIENTE = new SqlParameter("@CLIENTE", CCliente.Text);
                        comandodeinsercao.Parameters.Add(CLIENTE);
                        SqlParameter DOCUMENTO = new SqlParameter("@DOCUMENTO", MDocumento.Text);
                        comandodeinsercao.Parameters.Add(DOCUMENTO);
                        SqlParameter SITUACAO = new SqlParameter("@SITUACAO", CSituacao.Text);
                        comandodeinsercao.Parameters.Add(SITUACAO);
                        SqlParameter DATAE = new SqlParameter("@DATAE", DTEntrada.Value);
                        comandodeinsercao.Parameters.Add(DATAE);
                        SqlParameter PREVISAO = new SqlParameter("@PREVISAO", DTPrevista.Text);
                        comandodeinsercao.Parameters.Add(PREVISAO);
                        SqlParameter MARCA = new SqlParameter("@MARCA", TMarca.Text);
                        comandodeinsercao.Parameters.Add(MARCA);
                        SqlParameter MODELO = new SqlParameter("@MODELO", TModelo.Text);
                        comandodeinsercao.Parameters.Add(MODELO);
                        SqlParameter CC = new SqlParameter("@CC", int.Parse(TCilindrada.Text));
                        comandodeinsercao.Parameters.Add(CC);
                        SqlParameter PLACA = new SqlParameter("@PLACA", TPlaca.Text);
                        comandodeinsercao.Parameters.Add(PLACA);
                        SqlParameter COMBUSTIVEL = new SqlParameter("@COMBUSTIVEL", CCombustivel.Text);
                        comandodeinsercao.Parameters.Add(COMBUSTIVEL);
                        SqlParameter MECANICO = new SqlParameter("@MECANICO", CMecanico.Text);
                        comandodeinsercao.Parameters.Add(MECANICO);
                        SqlParameter CHECKLIST = new SqlParameter("@CHECKLIST", lischecklist);
                        comandodeinsercao.Parameters.Add(CHECKLIST);
                        SqlParameter KMATUAL = new SqlParameter("@KMATUAL", tKM.Text);
                        comandodeinsercao.Parameters.Add(KMATUAL);
                        SqlParameter NIVELCOMBUS = new SqlParameter("@NIVELCOMBUS", TNiCombus.Text);
                        comandodeinsercao.Parameters.Add(NIVELCOMBUS);
                        SqlParameter NIVELOLEO = new SqlParameter("@NIVELOLEO", TNiOleo.Text);
                        comandodeinsercao.Parameters.Add(NIVELOLEO);
                        SqlParameter PDIANTEIRO = new SqlParameter("@PDIANTEIRO", TPDianteiro.Text);
                        comandodeinsercao.Parameters.Add(PDIANTEIRO);
                        SqlParameter PTRASEIRO = new SqlParameter("@PTRASEIRO", TPTraseiro.Text);
                        comandodeinsercao.Parameters.Add(PTRASEIRO);
                        SqlParameter BATERIA = new SqlParameter("@BATERIA", TNiBateria.Text);
                        comandodeinsercao.Parameters.Add(BATERIA);
                        SqlParameter PROBLEMAREL = new SqlParameter("@PROBLEMAREL", tprobrel.Text);
                        comandodeinsercao.Parameters.Add(PROBLEMAREL);
                        SqlParameter PROBLEMACONS = new SqlParameter("@PROBLEMACONS", tprobconst.Text);
                        comandodeinsercao.Parameters.Add(PROBLEMACONS);
                        SqlParameter SERVICOREAL = new SqlParameter("@SERVICOREAL", tservicorel.Text);
                        comandodeinsercao.Parameters.Add(SERVICOREAL);
                        listaprod();
                        listaservico();
                        SqlParameter OBSERVACAO = new SqlParameter("@OBSERVACAO", Tobs.Text);
                        comandodeinsercao.Parameters.Add(OBSERVACAO);
                        SqlParameter VALORPROD = new SqlParameter("@VALORPROD", double.Parse(TVLProduto.Text));
                        comandodeinsercao.Parameters.Add(VALORPROD);
                        SqlParameter VALORSERV = new SqlParameter("@VALORSERV", double.Parse(TVLServico.Text));
                        comandodeinsercao.Parameters.Add(VALORSERV);
                        SqlParameter DESLOCAMENTO = new SqlParameter("@DESLOCAMENTO", double.Parse(TDeslocamento.Text));
                        comandodeinsercao.Parameters.Add(DESLOCAMENTO);
                        SqlParameter DESCONTO = new SqlParameter("@DESCONTO", float.Parse(TDesconto.Text));
                        comandodeinsercao.Parameters.Add(DESCONTO);
                        SqlParameter VALORTOTAL = new SqlParameter("@VALORTOTAL", double.Parse(ttotal.Text));
                        comandodeinsercao.Parameters.Add(VALORTOTAL);

                        comandodeinsercao.ExecuteNonQuery();

                        MessageBox.Show("OS Cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        conexao.Close();

                        GERAOS();

                    }

                    else
                    {

                        SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                        conexao.Open();

                        SqlCommand comandodeinsercao = new SqlCommand("UPDATE OS SET SITUACAO = @SITUACAO, " +
                                                                        "PREVISAO = @PREVISAO, MARCA = @MARCA, MODELO = @MODELO, CC = @CC, PLACA = @PLACA, COMBUSTIVEL = @COMBUSTIVEL, MECANICO = @MECANICO," +
                                                                        "CHECKLIST = @CHECKLIST, KMATUAL = @KMATUAL, NIVELCOMBUS = @NIVELCOMBUS, NIVELOLEO = @NIVELOLEO, PDIANTEIRO = @PDIANTEIRO, PTRASEIRO =@PTRASEIRO," +
                                                                        "BATERIA = @BATERIA, PROBLEMAREL = @PROBLEMAREL, PROBLEMACONS = @PROBLEMACONS, SERVICOREAL = @SERVICOREAL," +
                                                                        "OBSERVACAO = @OBSERVACAO, VALORPROD = @VALORPROD, VALORSERV = @VALORSERV, DESLOCAMENTO = @DESLOCAMENTO, " +
                                                                        "DESCONTO = @DESCONTO, VALORTOTAL = @VALORTOTAL WHERE CODIGO = " + os, conexao);


                        SqlParameter SITUACAO = new SqlParameter("@SITUACAO", CSituacao.Text);
                        comandodeinsercao.Parameters.Add(SITUACAO);
                        SqlParameter PREVISAO = new SqlParameter("@PREVISAO", DTPrevista.Text);
                        comandodeinsercao.Parameters.Add(PREVISAO);
                        SqlParameter MARCA = new SqlParameter("@MARCA", TMarca.Text);
                        comandodeinsercao.Parameters.Add(MARCA);
                        SqlParameter MODELO = new SqlParameter("@MODELO", TModelo.Text);
                        comandodeinsercao.Parameters.Add(MODELO);
                        SqlParameter CC = new SqlParameter("@CC", int.Parse(TCilindrada.Text));
                        comandodeinsercao.Parameters.Add(CC);
                        SqlParameter PLACA = new SqlParameter("@PLACA", TPlaca.Text);
                        comandodeinsercao.Parameters.Add(PLACA);
                        SqlParameter COMBUSTIVEL = new SqlParameter("@COMBUSTIVEL", CCombustivel.Text);
                        comandodeinsercao.Parameters.Add(COMBUSTIVEL);
                        SqlParameter MECANICO = new SqlParameter("@MECANICO", CMecanico.Text);
                        comandodeinsercao.Parameters.Add(MECANICO);
                        SqlParameter CHECKLIST = new SqlParameter("@CHECKLIST", lischecklist);
                        comandodeinsercao.Parameters.Add(CHECKLIST);
                        SqlParameter KMATUAL = new SqlParameter("@KMATUAL", tKM.Text);
                        comandodeinsercao.Parameters.Add(KMATUAL);
                        SqlParameter NIVELCOMBUS = new SqlParameter("@NIVELCOMBUS", TNiCombus.Text);
                        comandodeinsercao.Parameters.Add(NIVELCOMBUS);
                        SqlParameter NIVELOLEO = new SqlParameter("@NIVELOLEO", TNiOleo.Text);
                        comandodeinsercao.Parameters.Add(NIVELOLEO);
                        SqlParameter PDIANTEIRO = new SqlParameter("@PDIANTEIRO", TPDianteiro.Text);
                        comandodeinsercao.Parameters.Add(PDIANTEIRO);
                        SqlParameter PTRASEIRO = new SqlParameter("@PTRASEIRO", TPTraseiro.Text);
                        comandodeinsercao.Parameters.Add(PTRASEIRO);
                        SqlParameter BATERIA = new SqlParameter("@BATERIA", TNiBateria.Text);
                        comandodeinsercao.Parameters.Add(BATERIA);
                        SqlParameter PROBLEMAREL = new SqlParameter("@PROBLEMAREL", tprobrel.Text);
                        comandodeinsercao.Parameters.Add(PROBLEMAREL);
                        SqlParameter PROBLEMACONS = new SqlParameter("@PROBLEMACONS", tprobconst.Text);
                        comandodeinsercao.Parameters.Add(PROBLEMACONS);
                        SqlParameter SERVICOREAL = new SqlParameter("@SERVICOREAL", tservicorel.Text);
                        comandodeinsercao.Parameters.Add(SERVICOREAL);
                        listaprod();
                        listaservico();
                        SqlParameter OBSERVACAO = new SqlParameter("@OBSERVACAO", Tobs.Text);
                        comandodeinsercao.Parameters.Add(OBSERVACAO);
                        SqlParameter VALORPROD = new SqlParameter("@VALORPROD", double.Parse(TVLProduto.Text));
                        comandodeinsercao.Parameters.Add(VALORPROD);
                        SqlParameter VALORSERV = new SqlParameter("@VALORSERV", double.Parse(TVLServico.Text));
                        comandodeinsercao.Parameters.Add(VALORSERV);
                        SqlParameter DESLOCAMENTO = new SqlParameter("@DESLOCAMENTO", double.Parse(TDeslocamento.Text));
                        comandodeinsercao.Parameters.Add(DESLOCAMENTO);
                        SqlParameter DESCONTO = new SqlParameter("@DESCONTO", float.Parse(TDesconto.Text));
                        comandodeinsercao.Parameters.Add(DESCONTO);
                        SqlParameter VALORTOTAL = new SqlParameter("@VALORTOTAL", double.Parse(ttotal.Text));
                        comandodeinsercao.Parameters.Add(VALORTOTAL);

                        comandodeinsercao.ExecuteNonQuery();

                      
                        conexao.Close();

                    }
                    DialogResult resp = MessageBox.Show("Deseja Imprimir?", "Alternativa Motos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resp == DialogResult.Yes)
                    {
                        GERAOS();
                        //APRESENTA O PDF
                        System.Diagnostics.Process.Start(@"C:\Users\defar\Desktop\os.pdf");
                    }
                
            }
            else
            {
                MessageBox.Show("Documento Inválido", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void listaprod()
        {

            if (os != 0)
            {

                SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();

                SqlCommand comandodeinsercao = new SqlCommand("delete from ProdutoOS where codos = " + os, conexao);
                comandodeinsercao.ExecuteNonQuery();
                conexao.Close();

            }

            if (listitem.Items.Count != 0)
            {
                foreach (ListViewItem item in listitem.Items)
                {


                    SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    SqlCommand comandodeinsercao = new SqlCommand("Insert into ProdutoOS (codos,cbarras,descricao,quantidade,valor)" +
                                                                  "values" +
                                                                  "(@codos, @cbarras, @descricao, @quantidade,@valor)", conexao);

                    if (os == 0)
                    {
                        SqlParameter codos = new SqlParameter("@codos", codigo);
                        comandodeinsercao.Parameters.Add(codos);
                    }
                    else
                    {
                        SqlParameter codos = new SqlParameter("@codos", os);
                        comandodeinsercao.Parameters.Add(codos);
                    }
                    SqlParameter cbarras = new SqlParameter("@cbarras", item.Text);
                    comandodeinsercao.Parameters.Add(cbarras);
                    SqlParameter descricao = new SqlParameter("@descricao", item.SubItems[1].Text);
                    comandodeinsercao.Parameters.Add(descricao);
                    SqlParameter quantidade = new SqlParameter("@quantidade", int.Parse(item.SubItems[2].Text));
                    comandodeinsercao.Parameters.Add(quantidade);
                    SqlParameter valor = new SqlParameter("@valor", double.Parse(item.SubItems[3].Text));
                    comandodeinsercao.Parameters.Add(valor);

                    comandodeinsercao.ExecuteNonQuery();

                    conexao.Close();
                    conexao.Open();

                    comandodeinsercao = new SqlCommand("update produtos set quantidade = quantidade - @quantidade2 where codigo = " + codigo, conexao);
                    SqlParameter quantidade2 = new SqlParameter("@quantidade2", +int.Parse(item.SubItems[2].Text));
                    comandodeinsercao.Parameters.Add(quantidade2);
                    comandodeinsercao.ExecuteNonQuery();

                }

            }

        }


        public void AtribuiCodigo()
        {

            SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "select MAX(codigo) as cod from OS";

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

        public void AtribuiCodigovenda()
        {

            SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "select MAX(codvendaitem) as cod from vendas";

            SqlCommand pegacodigo = new SqlCommand(vQuery, conexao);

            SqlDataReader dr;

            dr = pegacodigo.ExecuteReader();

            if (dr.Read() == false)
            {
                codvenda = 1;
            }
            else
            {
                if (dr["cod"].ToString() == "")
                    codvenda = 1;
                else
                    codvenda = int.Parse(dr["cod"].ToString()) + 1;
            }

            dr.Close();
            conexao.Close();
        }
        public void listaservico()
        {
            if (os != 0)
            {

                SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();

                SqlCommand comandodeinsercao = new SqlCommand("delete from ServicoOS where codos = " + os, conexao);
                comandodeinsercao.ExecuteNonQuery();
                conexao.Close();

            }

            if (listserv.Items.Count != 0)
            {
                foreach (ListViewItem item in listserv.Items)
                {


                    SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    SqlCommand comandodeinsercao = new SqlCommand("Insert into servicoOS (codos,cbarras,descricao,quantidade,valor)" +
                                                                  "values" +
                                                                  "(@codos, @cbarras, @descricao, @quantidade,@valor)", conexao);
                    if (os == 0)
                    {

                        SqlParameter codos = new SqlParameter("@codos", codigo);
                        comandodeinsercao.Parameters.Add(codos);
                    }
                    else
                    {
                        SqlParameter codos = new SqlParameter("@codos", os);
                        comandodeinsercao.Parameters.Add(codos);
                    }
                    SqlParameter cbarras = new SqlParameter("@cbarras", item.Text);
                    comandodeinsercao.Parameters.Add(cbarras);
                    SqlParameter descricao = new SqlParameter("@descricao", item.SubItems[1].Text);
                    comandodeinsercao.Parameters.Add(descricao);
                    SqlParameter quantidade = new SqlParameter("@quantidade", int.Parse(item.SubItems[2].Text));
                    comandodeinsercao.Parameters.Add(quantidade);
                    SqlParameter valor = new SqlParameter("@valor", double.Parse(item.SubItems[3].Text));
                    comandodeinsercao.Parameters.Add(valor);

                    comandodeinsercao.ExecuteNonQuery();

                    conexao.Close();

                }

            }



        }
        public void carregamecanico()
        {

            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();

            //-------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------


            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            selecionafilme = new SqlCommand("select nome from usuarios where classe = 'Mecânico'", conexao);
            SqlDataReader leitor;
            leitor = selecionafilme.ExecuteReader();

            while (leitor.Read() == true)
            {
                CMecanico.Items.Add(leitor["nome"].ToString());
            }


        }

        public OrdemdeServico(int ordem, string classe)
        {
            InitializeComponent();
            os = ordem;
            AtribuiCodigo();
            carregamecanico();
            if(classe != "Mecânico" && classe != "Administrador")
            {
                tprobconst.Enabled = false;
                tservicorel.Enabled = false;
            }
            if (ordem != 0)
            {
                if (classe != "Mecânico" && classe != "Administrador")
                {
                    CSituacao.Enabled = false;
                }
                CCliente.Enabled = false;
                MDocumento.Enabled = false;
                DTEntrada.Enabled = false;
                BGravar.Text = "Alterar";

                carregaOS();
            }
            
        }
        public void carregaOS()
        {

            SqlDataReader leitor;
            SqlCommand selecionavenda = new SqlCommand();
            SqlConnection conexao = new SqlConnection();
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            selecionavenda = new SqlCommand("select codigo, CLIENTE, DOCUMENTO, SITUACAO, DATAE," +
                                                            "PREVISAO, MARCA, MODELO, CC, PLACA, COMBUSTIVEL, MECANICO," +
                                                            "CHECKLIST, KMATUAL, NIVELCOMBUS, NIVELOLEO, PDIANTEIRO, PTRASEIRO," +
                                                            "BATERIA, PROBLEMAREL, PROBLEMACONS, SERVICOREAL," +
                                                            "OBSERVACAO, VALORPROD, VALORSERV, DESLOCAMENTO,"+
                                                            "DESCONTO, VALORTOTAL from OS where codigo =" + os, conexao);
            leitor = selecionavenda.ExecuteReader();
            
            if (leitor.Read() == true)
            {
                TCodigo.Text = leitor["codigo"].ToString();
                CCliente.Text = leitor["CLIENTE"].ToString();
                MDocumento.Text = leitor["DOCUMENTO"].ToString();
                CSituacao.Text = leitor["SITUACAO"].ToString();
                DTEntrada.Text = leitor["DATAE"].ToString();
                DTPrevista.Text = leitor["PREVISAO"].ToString();
                TMarca.Text = leitor["MARCA"].ToString();
                TModelo.Text = leitor["MODELO"].ToString();
                TCilindrada.Text = leitor["CC"].ToString();
                TPlaca.Text = leitor["PLACA"].ToString();
                CCombustivel.Text = leitor["COMBUSTIVEL"].ToString();
                CMecanico.Text = leitor["MECANICO"].ToString();
                tKM.Text = leitor["KMATUAL"].ToString();
                TNiCombus.Text = leitor["NIVELCOMBUS"].ToString();
                TNiOleo.Text = leitor["NIVELOLEO"].ToString();
                TPDianteiro.Text = leitor["PDIANTEIRO"].ToString();
                TPTraseiro.Text = leitor["PTRASEIRO"].ToString();
                TNiBateria.Text = leitor["BATERIA"].ToString();
                tprobrel.Text = leitor["PROBLEMAREL"].ToString();
                tprobconst.Text = leitor["PROBLEMACONS"].ToString();
                tservicorel.Text = leitor["SERVICOREAL"].ToString();
                Tobs.Text = leitor["OBSERVACAO"].ToString();
                double valores = double.Parse(leitor["VALORPROD"].ToString());
                TVLProduto.Text = valores.ToString("0.00");
                valores = double.Parse(leitor["VALORSERV"].ToString());
                TVLServico.Text = valores.ToString("0.00");
                valores = double.Parse(leitor["DESLOCAMENTO"].ToString());
                TDeslocamento.Text = valores.ToString("0.00");
                valores = double.Parse(leitor["DESCONTO"].ToString());
                TDesconto.Text = valores.ToString("0.00");
                valores = double.Parse(leitor["VALORTOTAL"].ToString());
                ttotal.Text = valores.ToString("0.00");

                carregaprod(int.Parse(leitor["codigo"].ToString()));
                carregaserv(int.Parse(leitor["codigo"].ToString()));



                VRChecklist(leitor["CHECKLIST"].ToString());

            }
  
            leitor.Close();
            conexao.Close();

        }
        public void VRChecklist(string check)
        {
            string[] checklist = check.Split('|');

            foreach( var palavra in checklist)
            {
                switch(palavra)
                {
                    case "Buzina": C1.Checked = true; break;
                    case "Sinaleira": C2.Checked = true; break;
                    case "Farol": C3.Checked = true; break;
                    case "Seta F. Direita": C4.Checked = true; break;
                    case "Seta F. Esquerda": C5.Checked = true; break;
                    case "Seta T. Direita": C6.Checked = true; break;
                    case "Seta T. Esquerda": C7.Checked = true; break;
                    case "Retrovisores": C8.Checked = true; break;
                    case "Carenagem Esquerda": C9.Checked = true; break;
                    case "Carenagem Direita": C10.Checked = true; break;
                    case "Rabeta": C11.Checked = true; break;
                    case "Escape": C12.Checked = true; break;
                    case "Travas": C13.Checked = true; break;
                    case "Bateria": C14.Checked = true; break;
                    case "Manual": C15.Checked = true; break;
                    case "Chave": C16.Checked = true; break;
                }
            }
                



        }
        public void carregaprod(int oprod)
        {

            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();




            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            selecionafilme = new SqlCommand("select cbarras, descricao, quantidade,valor from ProdutoOS where codos = " + oprod, conexao);



            leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                ListViewItem itemLista = new ListViewItem(leitor["cbarras"].ToString());
              
                ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["descricao"].ToString());
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["quantidade"].ToString());
                itemLista.SubItems.Add(subitemLista);
                double vl1 = double.Parse(leitor["valor"].ToString());
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, vl1.ToString("0.00"));
                itemLista.SubItems.Add(subitemLista);


                listitem.Items.Add(itemLista);

            }

            
            leitor.Close();
            conexao.Close();

        }
        public void carregaserv(int oprod)
        {

            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();




            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            selecionafilme = new SqlCommand("select cbarras, descricao, quantidade,valor from servicoOS where codos = " + oprod, conexao);



            leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                ListViewItem itemLista = new ListViewItem(leitor["cbarras"].ToString());
                ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista,leitor["descricao"].ToString());
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["quantidade"].ToString());
                itemLista.SubItems.Add(subitemLista);
                double vl1 = double.Parse(leitor["valor"].ToString());
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, vl1.ToString("0.00"));
                itemLista.SubItems.Add(subitemLista);


                listserv.Items.Add(itemLista);

            }


            leitor.Close();
            conexao.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if ((Tqdt.Text == "0") | (Tqdt.Text == "") | (Tqdt.Text == " "))
            {
                MessageBox.Show("Quantidade inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListadeCompra(TCBarras.Text);
            }
            TCBarras.Text = "";
        }
        public void ListadeCompra(String cod)
        {
            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();




            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            selecionafilme = new SqlCommand("select cbarras as codigo,descricao as descri,pvenda as vl from produtos where cbarras = '" + cod + "' AND TIPO = 'Produto'", conexao);



            leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                ListViewItem itemLista = new ListViewItem(leitor["codigo"].ToString());
                ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["descri"].ToString());
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, Tqdt.Text);
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, (double.Parse(leitor["vl"].ToString()) * int.Parse(Tqdt.Text)).ToString("0.00"));
                itemLista.SubItems.Add(subitemLista);




                listitem.Items.Add(itemLista);

            }

            calcprod();
            leitor.Close();
            conexao.Close();
        }
        public void calcprod()
        {
            double subtotal = 0;
            for (int i = 0; i < listitem.Items.Count; i++)
            {
                subtotal += double.Parse(listitem.Items[i].SubItems[3].Text);
            }
            TVLProduto.Text = subtotal.ToString("0.00");

            calctotal();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int qtd = int.Parse(Tqdt.Text);

            if (qtd > 0)
            {
                qtd--;
                Tqdt.Text = qtd.ToString();
            }
        }

        private void BPlus_Click(object sender, EventArgs e)
        {
            int qtd = int.Parse(Tqdt.Text);

            qtd++;
            Tqdt.Text = qtd.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (RDescri.Checked == true)
            {
                selecionaproduto produto = new selecionaproduto(TCBarras.Text, "Produto");
                produto.ShowDialog();
                TCBarras.Text = produto.codigo;
            }

        }

        private void RDescri_CheckedChanged(object sender, EventArgs e)
        {
            TCBarras.Text = "";
        }

        private void Rbarras_CheckedChanged(object sender, EventArgs e)
        {
            TCBarras.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (listitem.SelectedItems.Count != 0)
            {
                listitem.Items[0].Remove();
            }
            calcprod();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (gValor.Visible == true)
                gValor.Visible = false;
            else
                gValor.Visible = true;

        }

        private void bconfalter_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(talteracao.Text);
            listitem.SelectedItems[0].SubItems[3].Text = valor.ToString("0.00");
            calcprod();

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tservicos.Text = "";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tservicos.Text = "";
        }

        private void BBuscaServ_Click(object sender, EventArgs e)
        {
            if (Rdescriserv.Checked == true)
            {
                selecionaproduto produto = new selecionaproduto(TCBarras.Text, "Serviço");
                produto.ShowDialog();
                tservicos.Text = produto.codigo;
            }
        }

        private void Bincluirserv_Click(object sender, EventArgs e)
        {

            listservico(tservicos.Text);

            tservicos.Text = "";
        }
        public void listservico(String cod)
        {
            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();




            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            selecionafilme = new SqlCommand("select cbarras as codigo,descricao as descri,pvenda as vl from produtos where cbarras = '" + cod + "' AND TIPO = 'Serviço'", conexao);



            leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                ListViewItem itemLista = new ListViewItem(leitor["codigo"].ToString());
                ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, leitor["descri"].ToString());
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, Tqdt.Text);
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, (double.Parse(leitor["vl"].ToString()) * int.Parse(Tqdt.Text)).ToString("0.00"));
                itemLista.SubItems.Add(subitemLista);




                listserv.Items.Add(itemLista);

            }

            calcserv();
            leitor.Close();
            conexao.Close();

        }
        public void calcserv()
        {
            double subtotal = 0;
            for (int i = 0; i < listserv.Items.Count; i++)
            {
                subtotal += double.Parse(listserv.Items[i].SubItems[3].Text);
            }
            TVLServico.Text = subtotal.ToString("0.00");
            calctotal();

        }

        private void BRemovServ_Click(object sender, EventArgs e)
        {
            if (listserv.SelectedItems.Count != 0)
            {
                listserv.Items[0].Remove();
            }
            calcserv();
        }

        private void BAlterServ_Click(object sender, EventArgs e)
        {
            if (GValorServ.Visible == true)
                GValorServ.Visible = false;
            else
                GValorServ.Visible = true;
        }

        private void BaltValServ_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(TAlVlServ.Text);
            listserv.SelectedItems[0].SubItems[3].Text = valor.ToString("0.00");
            calcserv();
        }

        private void TDeslocamento_TextChanged(object sender, EventArgs e)
        {
            if (TDeslocamento.Text != "")
            {
                calctotal();
            }

        }
        public void calctotal()
        {
            if (RBDinheiro.Checked is true)
            {
                ttotal.Text = (double.Parse(TVLProduto.Text) + double.Parse(TVLServico.Text) + double.Parse(TDeslocamento.Text) - double.Parse(TDesconto.Text)).ToString("0.00");
            }
            else if (RBPorcento.Checked is true)
            {
                ttotal.Text = ((double.Parse(TVLProduto.Text) + double.Parse(TVLServico.Text) + double.Parse(TDeslocamento.Text)) - (((double.Parse(TVLProduto.Text) + double.Parse(TVLServico.Text) + double.Parse(TDeslocamento.Text)) / 100) * double.Parse(TDesconto.Text))).ToString("0.00");
            }
        }

        private void bmenos_Click(object sender, EventArgs e)
        {
            int qtd = int.Parse(tqtdserv.Text);

            if (qtd > 0)
            {
                qtd--;
                tqtdserv.Text = qtd.ToString();
            }
        }

        private void bmais_Click(object sender, EventArgs e)
        {
            int qtd = int.Parse(tqtdserv.Text);


            qtd++;
            tqtdserv.Text = qtd.ToString();

        }

        private void TDesconto_TextChanged(object sender, EventArgs e)
        {

            if (TDesconto.Text != "")
            {
                calctotal();
            }
        }

        private void RBDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            calctotal();
        }

        private void RBPorcento_CheckedChanged(object sender, EventArgs e)
        {
            calctotal();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BAddCli_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes(0);
            cliente.ShowDialog();
        }

        private void TCilindrada_Leave(object sender, EventArgs e)
        {
            vercc();
        }
        public void vercc()
        {
            int lt = 0;
            foreach (var letra in TCilindrada.Text)
            {
                if (char.IsLetter(letra) == true)
                {
                    lt = 1;
                }
                if (letra == '.' || letra == ' ')
                {
                    lt =1;
                }
            }
            if (lt == 1)
            {
                MessageBox.Show("Clindrada não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TCilindrada.Text = "0";
            }

        }

        private void TVLProduto_Leave(object sender, EventArgs e)
        {
            vervp();
        }

        private void TVLServico_Leave(object sender, EventArgs e)
        {
            versv();
        }

        private void TDeslocamento_Leave(object sender, EventArgs e)
        {
            verdl();
        }

        private void TDesconto_Leave(object sender, EventArgs e)
        {
            verdc();
        }

        private void ttotal_Leave(object sender, EventArgs e)
        {
            vervt();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            MDocumento.Mask = "99.999.999/9999-99";
            MDocumento.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MDocumento.Mask = "999.999.999-99";
            MDocumento.Text = "";
        }

        private void MDocumento_Leave(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "select nome,situacao from clientes where cpf = '" + MDocumento.Text + "'";

            SqlCommand pegacodigo = new SqlCommand(vQuery, conexao);

            SqlDataReader dr;

            dr = pegacodigo.ExecuteReader();
            if (dr.Read() == true)
            {
                CCliente.Text = dr["nome"].ToString();
                situacao = dr["situacao"].ToString();
            }
        }

        public void FinalizaOs(int cod)
        {
            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();

            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            selecionafilme = new SqlCommand("select situacao from OS where codigo = " + cod, conexao);
            leitor = selecionafilme.ExecuteReader();
            leitor.Read();
            if (leitor["situacao"].ToString().ToUpper() == "FINALIZADA")
            {
                conexao.Close();
                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();
                fechado = "no";
                DialogResult resp2 =  MessageBox.Show("Ordem de Serviço já fechada.\n Deseja Reimprimir?", "Alternativa Motos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resp2 == DialogResult.Yes)
                {
                    GERAOS();
                    //APRESENTA O PDF
                    System.Diagnostics.Process.Start(@"C:\Users\defar\Desktop\os.pdf");

                }
                conexao.Close();
                leitor.Close();
            }
            else
            {
                fechado = "ok";
                conexao.Close();
                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();
                selecionafilme = new SqlCommand("update os set situacao = @situacao where codigo = " + cod, conexao);
                SqlParameter situacao = new SqlParameter("@situacao", "FINALIZADA");
                selecionafilme.Parameters.Add(situacao);
                selecionafilme.ExecuteReader();
                conexao.Close();
                leitor.Close();
            }
        }
        private void BFinalizar_Click(object sender, EventArgs e)
        {
            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();
            ListView a = new ListView();
            AtribuiCodigovenda();

            FinalizaOs(int.Parse(TCodigo.Text));


            if (fechado == "ok")
            {
                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();

                selecionafilme = new SqlCommand("select codcaixa as cod from caixa where datacaixa = '" + DateTime.Now.ToShortDateString() + "' and situacao = 'Aberto'", conexao);
                leitor = selecionafilme.ExecuteReader();

                if (leitor.Read() == true)
                {
                    if ((listitem.Items.Count != 0) || (listserv.Items.Count != 0))
                    {
                        pag = new Pagamento(ttotal.Text, codvenda.ToString(), CMecanico.Text, CCliente.Text, MDocumento.Text, TDesconto.Text, int.Parse(TCodigo.Text), a, codvenda.ToString());
                        pag.ShowDialog();
                        DialogResult resp = MessageBox.Show("Deseja Imprimir?", "Alternativa Motos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resp == DialogResult.Yes)
                        {
                            GERAOS();
                            //APRESENTA O PDF
                            System.Diagnostics.Process.Start(@"C:\Users\defar\Desktop\os.pdf");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lista de PRODUTOS/SERVIÇOS vazia!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Não existe um caixa aberto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }
        public void limpaproblemas()
        {
            tprobrel.Text = "";
            tprobconst.Text = "";
            tservicorel.Text = "";
            problemarel = "";
            problemac = "";
            servicor = "";
        }
        public void limpaobs()
        {
            Tobs.Text = "";
            obs = "";
        }

        public void GERAOS()
        {
            string checklist="";
            if (C1.Checked)
            {
                checklist = checklist + "Buzina - OK | ,";
            }
            if (C2.Checked)
            {
                checklist = checklist + "Sinaleira - OK | ,";

            }
            if (C3.Checked)
            {
                checklist = checklist + "Farol - OK | ,";

            }
            if (C4.Checked)
            {
                checklist = checklist + "Seta F. Direita - OK | ,";

            }
            if (C5.Checked)
            {
                checklist = checklist + "Seta F. Esquerda - OK | ,";
                 
            }
            if (C6.Checked)
            {
                checklist = checklist + "Seta T. Direita - OK | ,";

            }
            if (C7.Checked)
            {
                checklist = checklist + "Seta T. Esquerda - OK | ,";

            }
            if (C8.Checked)
            {
                checklist = checklist + "Retrovisores - OK | ,";

            }
            if (C9.Checked)
            {
                checklist = checklist + "Carenagem Esquerda - OK | ,";

            }
            if (C10.Checked)
            {
                checklist = checklist + "Carenagem Direita - OK | ,";

            }
            if (C11.Checked)
            {
                checklist = checklist + "Rabeta - OK | ,";

            }
            if (C12.Checked)
            {
                checklist = checklist + "Escape - OK | ,";

            }
            if (C13.Checked)
            {
                checklist = checklist + "Travas - OK | ,";

            }
            if (C14.Checked)
            {
                checklist = checklist + "Bateria - OK | ,";

            }
            if (C15.Checked)
            {
                checklist = checklist + "Manual - OK | ,";

            }
            if (C16.Checked)
            {
                checklist = checklist + "Chave - OK | ,";

            }
            


            //CRIA O PDF
            Document os = new Document(PageSize.A4);
            os.SetMargins(30, 20, 30, 20);
            os.AddCreationDate();

            //CAMINHO ONDE O PDF É SALVO E O NOME DO PDF
            string caminho = @"C:\Users\defar\Desktop\OS.pdf";

            PdfWriter writer = PdfWriter.GetInstance(os, new FileStream(caminho, FileMode.Create));

            //ABRI O PDF
            os.Open();

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
                    os.Add(paragrafo);

                    if (leitor["COMPLEMENTO"].ToString() == "")
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add(leitor["ENDERECO"].ToString() + ", " + leitor["NUMERO"].ToString() + " - " + leitor["BAIRRO"].ToString());
                        os.Add(paragrafo);
                    }
                    else
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add(leitor["ENDERECO"].ToString() + ", " + leitor["NUMERO"].ToString() + ", " + leitor["COMPLEMENTO"].ToString() + " - " + leitor["BAIRRO"].ToString());
                        os.Add(paragrafo);
                    }

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("CEP " + leitor["CEP"].ToString() + " - " + leitor["CIDADE"].ToString() + " - " + leitor["ESTADO"].ToString());
                    os.Add(paragrafo);


                    if ((leitor["TELEFONE"].ToString() == "(  )     -") && (leitor["CELULAR"].ToString() != "(  )     -"))
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add("FONE: " + leitor["CELULAR"].ToString());
                        os.Add(paragrafo);
                    }
                    else if ((leitor["TELEFONE"].ToString() != "(  )     -") && (leitor["CELULAR"].ToString() == "(  )     -"))
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add("FONE: " + leitor["TELEFONE"].ToString());
                        os.Add(paragrafo);
                    }
                    else
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add("FONE: " + leitor["TELEFONE"].ToString() + " / " + leitor["CELULAR"].ToString());
                        os.Add(paragrafo);
                    }

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("E-MAIL: " + leitor["EMAIL"].ToString());
                    os.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add(" ");
                    os.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("ORDEM DE SERVIÇO");
                    os.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add(" ");
                    os.Add(paragrafo);

                }


                else
                {
                    //-----------------------------------------------------------------------------------
                    //PARAGRAFOS DE INICIO

                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("ALTERNATIVA MOTOS");
                    os.Add(paragrafo);

                    paragrafo = new Paragraph();
                    paragrafo.Alignment = Element.ALIGN_CENTER;
                    paragrafo.Add("COMPROVANTE NÃO FISCAL");
                    os.Add(paragrafo);

                    for (int I = 0; I < 3; I++)
                    {
                        paragrafo = new Paragraph();
                        paragrafo.Alignment = Element.ALIGN_CENTER;
                        paragrafo.Add(" ");
                        os.Add(paragrafo);
                    }


                }
                leitor.Close();
                conexao.Close();
            }

            //TABELA COM OS DADOS DO CLIENTE
            PdfPTable CABECALHO = new PdfPTable(4);
            CABECALHO.TotalWidth = 575;
            CABECALHO.LockedWidth = true;
            float[] widths = new float[] { 140f, 140f,140f,150f };
            CABECALHO.SetWidths(widths);


            Paragraph coluna1 = new Paragraph();
            Paragraph coluna2 = new Paragraph();
            Paragraph coluna21 = new Paragraph();
            Paragraph coluna22= new Paragraph();


            var cel1 = new PdfPCell();
            var cel2 = new PdfPCell();
            var cel21 = new PdfPCell();
            var cel22 = new PdfPCell();


            cel1.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cel2.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cel21.Border = iTextSharp.text.Rectangle.NO_BORDER;
            cel22.Border = iTextSharp.text.Rectangle.NO_BORDER;


            cel1.AddElement(coluna1);
            cel2.AddElement(coluna2);
            cel21.AddElement(coluna21);
            cel22.AddElement(coluna22);



            CABECALHO.AddCell(cel1);
            CABECALHO.AddCell(cel2);
            CABECALHO.AddCell(cel21);
            CABECALHO.AddCell(cel22);



            Phrase item1 = new Phrase("Ordem de Serviço Nº: " + TCodigo.Text);
            var cel = new PdfPCell(item1);
            cel.Colspan = 4;
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            CABECALHO.AddCell(cel);

            Phrase v2 = new Phrase(" ");
            cel = new PdfPCell(v2);
            v2.Font.Size = 2;
            cel.Colspan = 4;
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            CABECALHO.AddCell(cel);

            Phrase item2 = new Phrase("Nome: " + CCliente.Text);
            cel = new PdfPCell(item2);
            cel.Colspan = 2;
            CABECALHO.AddCell(cel);

            Phrase item3 = new Phrase("Documento: " + MDocumento.Text);
            cel = new PdfPCell(item3);
            cel.Colspan = 2;
            CABECALHO.AddCell(cel);


            Phrase item4 = new Phrase("Situação: " + CSituacao.Text);
            cel = new PdfPCell(item4);
            CABECALHO.AddCell(cel);

            Phrase item7 = new Phrase("Entrada: " + DTEntrada.Text);
            cel = new PdfPCell(item7);
            CABECALHO.AddCell(cel);

            Phrase item8 = new Phrase("Saída: " + DTPrevista.Text);
            cel = new PdfPCell(item8);
            CABECALHO.AddCell(cel);

            Phrase item9 = new Phrase("Marca: " + TMarca.Text);
            cel= new PdfPCell(item9);
            CABECALHO.AddCell(cel);
           

            Phrase item5= new Phrase("Modelo: " + TModelo.Text);
            cel = new PdfPCell(item5);
            CABECALHO.AddCell(cel);
            

            Phrase item = new Phrase("Cilindrada: " + TCilindrada.Text);
            cel = new PdfPCell(item);
            CABECALHO.AddCell(cel);
            

            Phrase item13= new Phrase("Placa: " + TPlaca.Text);
            cel = new PdfPCell(item13);
            CABECALHO.AddCell(cel);
            

            Phrase item12 = new Phrase("Combustível: " + CCombustivel.Text);
            cel = new PdfPCell(item12);
           CABECALHO.AddCell(cel);
           

            Phrase item11 = new Phrase("Mecânico: " + CMecanico.Text);
            cel = new PdfPCell(item11);
            cel.Colspan = 4;
            CABECALHO.AddCell(cel);

            Phrase v1 = new Phrase(" ");
            cel = new PdfPCell(v1);
            v1.Font.Size = 2;
            cel.Colspan = 4;
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            CABECALHO.AddCell(cel);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add(" ");
            os.Add(paragrafo);
            os.Add(CABECALHO);

            string[] palavras = checklist.Split(',');
            string frase = "";
            foreach( var palavra in palavras)
            {
                frase = frase + palavra;

            }

            //TABELA COM OS DADOS Da MOTO
            PdfPTable DMotos = new PdfPTable(4);
            DMotos.TotalWidth = 575;
            DMotos.LockedWidth = true;
            float[] widths2 = new float[] { 140f, 140f, 140f, 150f };
            DMotos.SetWidths(widths2);

            Phrase items = new Phrase("Checklist: " + frase);
            cel = new PdfPCell(items);
            cel.Colspan = 4;
            DMotos.AddCell(cel);

            Phrase items1 = new Phrase("KM Atual: " + tKM.Text);
            cel = new PdfPCell(items1);
            DMotos.AddCell(cel);

            Phrase items2 = new Phrase("Nível Combustivel: " + TNiCombus.Text);
            cel = new PdfPCell(items2);
            DMotos.AddCell(cel);

            Phrase items3 = new Phrase("Nível Óleo: " + TNiOleo.Text);
            cel = new PdfPCell(items3);
            DMotos.AddCell(cel);

            Phrase items4 = new Phrase("Nível Bateria: " + TNiBateria.Text);
            cel = new PdfPCell(items4);
            DMotos.AddCell(cel);

            Phrase items5 = new Phrase("Pneu Dianteiro: " + TPDianteiro.Text);
            cel = new PdfPCell(items5);
            DMotos.AddCell(cel);

            Phrase items6 = new Phrase("Pneu Traseiro: " + TPTraseiro.Text);
            cel = new PdfPCell(items6);
            DMotos.AddCell(cel);


            Phrase items7 = new Phrase("");
            cel = new PdfPCell(items7);
            DMotos.AddCell(cel);

            Phrase items8 = new Phrase("");
            cel = new PdfPCell(items8);
            DMotos.AddCell(cel);

            Phrase v3 = new Phrase(" ");
            cel = new PdfPCell(v3);
            v3.Font.Size = 2;
            cel.Colspan = 4;
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            DMotos.AddCell(cel);

            Phrase items11 = new Phrase("Problema Relatado: " + tprobrel.Text);
            cel = new PdfPCell(items11);
            cel.Colspan = 2;
            DMotos.AddCell(cel);

            Phrase items22 = new Phrase("Problema Constatado: " + tprobconst.Text);
            cel = new PdfPCell(items22);
            cel.Colspan = 2;
            DMotos.AddCell(cel);

            Phrase items33 = new Phrase("Serviço Realizado: " + tservicorel.Text);
            cel = new PdfPCell(items33);
            cel.Colspan = 4;
            DMotos.AddCell(cel);

            Phrase v4 = new Phrase(" ");
            cel = new PdfPCell(v3);
            v4.Font.Size = 2;
            cel.Colspan = 4;
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            DMotos.AddCell(cel);
            os.Add(DMotos);

            //TABELA DAS PEÇAS
            PdfPTable ITEMS = new PdfPTable(4);
            ITEMS.TotalWidth = 575f;
            ITEMS.LockedWidth = true;
            float[] widths3 = new float[] { 50F, 120F,295F, 110f };
            ITEMS.SetWidths(widths3);

            v1 = new Phrase("Produtos");
            cel = new PdfPCell(v1);
            cel.Colspan = 4;
            ITEMS.AddCell(cel);

            v1 = new Phrase(" ");
            v1.Font.Size = 2;
            cel = new PdfPCell(v1);
            cel.Colspan = 4;
            ITEMS.AddCell(cel);


            Paragraph coluna3 = new Paragraph("Quant.");
            Paragraph coluna4 = new Paragraph("Código");
            Paragraph coluna5 = new Paragraph("Descrição das Peças");
            Paragraph coluna7 = new Paragraph("Valor");


            var cel3 = new PdfPCell();
            var cel4 = new PdfPCell();
            var cel5 = new PdfPCell();
            var cel7 = new PdfPCell();

            coluna3.Alignment = Element.ALIGN_CENTER;
            coluna4.Alignment = Element.ALIGN_CENTER;
            coluna5.Alignment = Element.ALIGN_CENTER;
            coluna7.Alignment = Element.ALIGN_RIGHT;


            cel3.AddElement(coluna3);
            cel4.AddElement(coluna4);
            cel5.AddElement(coluna5);
            cel7.AddElement(coluna7);


            ITEMS.AddCell(cel3);
            ITEMS.AddCell(cel4);
            ITEMS.AddCell(cel5);
            ITEMS.AddCell(cel7);

           
            foreach (ListViewItem lista in listitem.Items)
            {
                v1 = new Phrase(lista.SubItems[2].Text);
                cel = new PdfPCell(v1);
                ITEMS.AddCell(cel);

                v2 = new Phrase(lista.Text);
                cel = new PdfPCell(v2);
                ITEMS.AddCell(cel);

                v3 = new Phrase(lista.SubItems[1].Text);
                cel = new PdfPCell(v3);
                cel.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                ITEMS.AddCell(cel);

                v4 = new Phrase("R$" + lista.SubItems[3].Text);
                cel = new PdfPCell(v4);
                cel.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                ITEMS.AddCell(cel);
            }

            v1 = new Phrase(" ");
            v1.Font.Size = 2;
            cel = new PdfPCell(v1);
            cel.Colspan = 4;
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            ITEMS.AddCell(cel);
            
            os.Add(ITEMS);

            //TABELA DAS SERVICOS
            PdfPTable ITEMS2 = new PdfPTable(4);
            ITEMS2.TotalWidth = 575f;
            ITEMS2.LockedWidth = true;
            float[] widths4 = new float[] { 50F, 120F, 295F, 110f };
            ITEMS2.SetWidths(widths4);

            v1 = new Phrase("Serviços");
            cel = new PdfPCell(v1);
            cel.Colspan = 4;
            ITEMS2.AddCell(cel);

            v1 = new Phrase(" ");
            v1.Font.Size = 2;
            cel = new PdfPCell(v1);
            cel.Colspan = 4;
            ITEMS2.AddCell(cel);


            Paragraph coluna31 = new Paragraph("Quant.");
            Paragraph coluna41 = new Paragraph("Código");
            Paragraph coluna51 = new Paragraph("Descrição do Serviço");
            Paragraph coluna71 = new Paragraph("Valor");


            var cel31 = new PdfPCell();
            var cel41 = new PdfPCell();
            var cel51 = new PdfPCell();
            var cel71 = new PdfPCell();

            coluna31.Alignment = Element.ALIGN_CENTER;
            coluna41.Alignment = Element.ALIGN_CENTER;
            coluna51.Alignment = Element.ALIGN_CENTER;
            coluna71.Alignment = Element.ALIGN_RIGHT;


            cel31.AddElement(coluna31);
            cel41.AddElement(coluna41);
            cel51.AddElement(coluna51);
            cel71.AddElement(coluna71);


            ITEMS2.AddCell(cel31);
            ITEMS2.AddCell(cel41);
            ITEMS2.AddCell(cel51);
            ITEMS2.AddCell(cel71);


            foreach (ListViewItem lista in listserv.Items)
            {
                v1 = new Phrase(lista.SubItems[2].Text);
                cel = new PdfPCell(v1);
                ITEMS2.AddCell(cel);

                v2 = new Phrase(lista.Text);
                cel = new PdfPCell(v2);
                ITEMS2.AddCell(cel);

                v3 = new Phrase(lista.SubItems[1].Text);
                cel = new PdfPCell(v3);
                cel.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                ITEMS2.AddCell(cel);

                v4 = new Phrase("R$" + lista.SubItems[3].Text);
                cel = new PdfPCell(v4);
                cel.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                ITEMS2.AddCell(cel);
            }

            v1 = new Phrase(" ");
            v1.Font.Size = 2;
            cel = new PdfPCell(v1);
            cel.Colspan = 4;
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            ITEMS2.AddCell(cel);
            os.Add(ITEMS2);


            //Observacoes
            PdfPTable obs = new PdfPTable(4);
            obs.TotalWidth = 575f;
            obs.LockedWidth = true;
            float[] widths11 = new float[] { 50F, 120F, 295F, 110f };
            obs.SetWidths(widths11);

            v1 = new Phrase("Observações");
            cel = new PdfPCell(v1);
            cel.Colspan = 4;
            obs.AddCell(cel);

            v1 = new Phrase(" ");
            v1.Font.Size = 2;
            cel = new PdfPCell(v1);
            cel.Colspan = 4;
            obs.AddCell(cel);

            v1 = new Phrase(Tobs.Text);
            cel = new PdfPCell(v1);
            cel.Colspan = 4;
            obs.AddCell(cel);

            v1 = new Phrase(" ");
            v1.Font.Size = 2;
            cel = new PdfPCell(v1);
            cel.Colspan = 4;
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            obs.AddCell(cel);
            os.Add(obs);

            //PREÇOS
            
            PdfPTable PRICE = new PdfPTable(4);
            PRICE.TotalWidth = 575f;
            PRICE.LockedWidth = true;
            float[] widths10 = new float[] { 143F, 143F, 144F, 143f };
            obs.SetWidths(widths10);

            Paragraph coluna32 = new Paragraph("Valor de Produtos");
            Paragraph coluna42 = new Paragraph("Valor de Serviços");
            Paragraph coluna52 = new Paragraph("Deslocamento");
            Paragraph coluna72 = new Paragraph("Desconto");


            var cel32 = new PdfPCell();
            var cel42 = new PdfPCell();
            var cel52 = new PdfPCell();
            var cel72 = new PdfPCell();

            coluna32.Alignment = Element.ALIGN_CENTER;
            coluna42.Alignment = Element.ALIGN_CENTER;
            coluna52.Alignment = Element.ALIGN_CENTER;
            coluna72.Alignment = Element.ALIGN_CENTER;


            cel32.AddElement(coluna32);
            cel42.AddElement(coluna42);
            cel52.AddElement(coluna52);
            cel72.AddElement(coluna72);


            PRICE.AddCell(cel32);
            PRICE.AddCell(cel42);
            PRICE.AddCell(cel52);
            PRICE.AddCell(cel72);

            float total1 = float.Parse(TVLProduto.Text);
            v1 = new Phrase("R$ " +  total1.ToString("0.00"));
            cel = new PdfPCell(v1);
            PRICE.AddCell(cel);

            float total2 = float.Parse(TVLServico.Text);
            v1 = new Phrase("R$ " + total2.ToString("0.00"));
            cel = new PdfPCell(v1);
            PRICE.AddCell(cel);

            float total3 = float.Parse(TDeslocamento.Text);
            v1 = new Phrase("R$ " + total3.ToString("0.00"));
            cel = new PdfPCell(v1);
            PRICE.AddCell(cel);

            if (RBDinheiro.Checked == true)
            {
                float total4 = float.Parse(TDesconto.Text);
                v1 = new Phrase("R$ " + total4.ToString("0.00"));
                cel = new PdfPCell(v1);
                PRICE.AddCell(cel);
            }
            else if(RBPorcento.Checked == true)
            {
                v1 = new Phrase(TDesconto.Text);
                cel = new PdfPCell(v1);
                PRICE.AddCell(cel);
            }

            v1 = new Phrase(" ");
            cel = new PdfPCell(v1);
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            PRICE.AddCell(cel);

            v1 = new Phrase(" ");
            cel = new PdfPCell(v1);
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            PRICE.AddCell(cel);

            v1 = new Phrase("Total: ");
            
            cel = new PdfPCell(v1);
            cel.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            PRICE.AddCell(cel);

            float total = float.Parse(ttotal.Text);
            v1 = new Phrase("R$ " + total.ToString("0.00"));
            cel = new PdfPCell(v1);
            cel.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
            cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
            PRICE.AddCell(cel);

            v1 = new Phrase(" ");
            v1.Font.Size = 2;
            cel = new PdfPCell(v1);
            cel.Colspan = 4;
            cel.BackgroundColor = iTextSharp.text.BaseColor.DARK_GRAY;
            PRICE.AddCell(cel);
            os.Add(PRICE);

            //fim

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Font.Size = 20;
            paragrafo.Add(" ");
            os.Add(paragrafo);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Font.Size = 10;
            paragrafo.Add("Prezado Cliente: A moto só será liberada após o pagamento do(s) serviço(s) acima discriminado(s)");
            os.Add(paragrafo);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add(" ");
            os.Add(paragrafo);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add(" ");
            os.Add(paragrafo);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add(" ");
            os.Add(paragrafo);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Add("____________________________");
            os.Add(paragrafo);

            paragrafo = new Paragraph();
            paragrafo.Alignment = Element.ALIGN_CENTER;
            paragrafo.Font.Size = 10;
            paragrafo.Add("Assinatura");
            os.Add(paragrafo);


            os.Close();


        }
    }
    
}
