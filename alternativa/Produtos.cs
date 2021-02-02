using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace alternativa
{
    public partial class Produtos : Form
    {
        int prod;
        public Produtos(int codprod)
        {
            InitializeComponent();
            carregaforn();
            AtribuiCodigo();
            prod = codprod;
            if(prod != 0)
            {
                Carregaprod();
                BGravar.Text = "Alterar";
            }
        }
        public void carregaforn()
        {
           
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();

            //-------------------------------------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------------


            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            selecionafilme = new SqlCommand("select nfantasia from fornecedores", conexao);
            SqlDataReader leitor;
            leitor = selecionafilme.ExecuteReader();

            while(leitor.Read() == true)
            {
                CFornecedor.Items.Add(leitor["nfantasia"].ToString());
            }


        }
        public void Carregaprod()
        {
            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            selecionafilme = new SqlCommand("select codigo as cod, CBARRAS,DESCRICAO,FABRICANTE,MODELO,MARCA,ABRANGENTE,FORNECEDOR," +
                                                          "PCUSTO,LUCRO,PVENDA,QUANTIDADE,ESTOQUEMIN, TIPO from produtos where codigo =" + prod, conexao);
            leitor = selecionafilme.ExecuteReader();

            if (leitor.Read() == true)
            {

                TDescricao.Text = leitor["DESCRICAO"].ToString();
                TCBarras.Text = leitor["CBARRAS"].ToString();
                TFabricante.Text = leitor["FABRICANTE"].ToString();
                TModelo.Text = leitor["MODELO"].ToString();
                TMarca.Text = leitor["MARCA"].ToString();
                MAnoAbrangente.Text = leitor["ABRANGENTE"].ToString();
                CFornecedor.Text = leitor["FORNECEDOR"].ToString();
                double custo = double.Parse(leitor["PCUSTO"].ToString());
                TPCusto.Text = custo.ToString("0.00");
                double lucro = double.Parse(leitor["LUCRO"].ToString());
                TLucro.Text = lucro.ToString("0.00");
                double venda = double.Parse(leitor["PVENDA"].ToString());
                TPVenda.Text = venda.ToString("0.00");
                TQTD.Text = leitor["QUANTIDADE"].ToString();
                TEstoqueMin.Text = leitor["ESTOQUEMIN"].ToString();
                CTipo.Text = leitor["TIPO"].ToString();
                

            }


            leitor.Close();
            conexao.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Filter = "jpg|*.jpg";
            if(foto.ShowDialog()==DialogResult.OK)
            {
                PProdutoFoto.ImageLocation = foto.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PProdutoFoto.ImageLocation = "C:\\Users\\defar\\Desktop\\Alternativa\\sem editar\\download.png";

        }
        public void verpc()
        {
            int lt = 0;
            foreach (var letra in TPCusto.Text)
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
                MessageBox.Show("Custo não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TPCusto.Text = "0";
            }

        }
        public void verlc()
        {
            int lt = 0;
            foreach (var letra in TLucro.Text)
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
                MessageBox.Show("Lucro não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TLucro.Text = "0";
            }

        }
        public void vervv()
        {
            int lt = 0;
            foreach (var letra in TPVenda.Text)
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
                MessageBox.Show("Valor de venda não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TPVenda.Text = "0";
            }

        }
        public void verqt()
        {
            int lt = 0;
            foreach (var letra in TQTD.Text)
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
                MessageBox.Show("quantidade não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TQTD.Text = "0";
            }

        }
        public void veret()
        {
            int lt = 0;
            foreach (var letra in TEstoqueMin.Text)
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
                MessageBox.Show("estoque minimo não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TEstoqueMin.Text = "0";
            }

        }

        public bool Verficadados()
        {
            if (TCBarras.Text == "" || TDescricao.Text == "" || TMarca.Text == "" || TModelo.Text == "" || TPVenda.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void BGravar_Click(object sender, EventArgs e)
        {
            if (Verficadados())
            {

              
                    verpc();
                    verlc();
                    vervv();
                    verqt();
                    veret();
                if (BGravar.Text != "Alterar")
                {
                    SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    SqlCommand comandodeinsercao = new SqlCommand("Insert into PRODUTOS (CBARRAS,DESCRICAO,FABRICANTE,MODELO,MARCA,ABRANGENTE,FORNECEDOR," +
                                                                  "PCUSTO,LUCRO,PVENDA,QUANTIDADE,ESTOQUEMIN, TIPO)" +
                                                                  "values" +
                                                                  "(@CBARRAS,@DESCRICAO,@FABRICANTE,@MODELO,@MARCA,@ABRANGENTE,@FORNECEDOR," +
                                                                  "@PCUSTO,@LUCRO,@PVENDA,@QUANTIDADE,@ESTOQUEMIN,@TIPO)", conexao);


                    SqlParameter CBARRAS = new SqlParameter("@CBARRAS", TCBarras.Text);
                    comandodeinsercao.Parameters.Add(CBARRAS);
                    SqlParameter DESCRICACAO = new SqlParameter("@DESCRICAO", TDescricao.Text);
                    comandodeinsercao.Parameters.Add(DESCRICACAO);
                    SqlParameter FABRICANTE = new SqlParameter("@FABRICANTE", TFabricante.Text);
                    comandodeinsercao.Parameters.Add(FABRICANTE);
                    SqlParameter MODELO = new SqlParameter("@MODELO", TModelo.Text);
                    comandodeinsercao.Parameters.Add(MODELO);
                    SqlParameter MARCA = new SqlParameter("@MARCA", TMarca.Text);
                    comandodeinsercao.Parameters.Add(MARCA);
                    SqlParameter ABRANGENTE = new SqlParameter("@ABRANGENTE", MAnoAbrangente.Text);
                    comandodeinsercao.Parameters.Add(ABRANGENTE);
                    SqlParameter FORNECEDOR = new SqlParameter("@FORNECEDOR", CFornecedor.Text);
                    comandodeinsercao.Parameters.Add(FORNECEDOR);
                    SqlParameter PCUSTO = new SqlParameter("@PCUSTO", float.Parse(TPCusto.Text));
                    comandodeinsercao.Parameters.Add(PCUSTO);
                    SqlParameter LUCRO = new SqlParameter("@LUCRO", float.Parse(TLucro.Text));
                    comandodeinsercao.Parameters.Add(LUCRO);
                    SqlParameter PVENDA = new SqlParameter("@PVENDA", float.Parse(TPVenda.Text));
                    comandodeinsercao.Parameters.Add(PVENDA);
                    SqlParameter QUANTIDADE = new SqlParameter("@QUANTIDADE", int.Parse(TQTD.Text));
                    comandodeinsercao.Parameters.Add(QUANTIDADE);
                    SqlParameter ESTOQUEMIN = new SqlParameter("@ESTOQUEMIN", int.Parse(TEstoqueMin.Text));
                    comandodeinsercao.Parameters.Add(ESTOQUEMIN);
                    SqlParameter TIPO = new SqlParameter("@TIPO", CTipo.Text);
                    comandodeinsercao.Parameters.Add(TIPO);
                    comandodeinsercao.ExecuteNonQuery();

                    MessageBox.Show("Produto Cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexao.Close();
                }
                else
                {
                    SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    SqlCommand comandodeinsercao = new SqlCommand("update  PRODUTOS set CBARRAS = @CBARRAS,DESCRICAO = @DESCRICAO,FABRICANTE =@FABRICANTE,MODELO=@MODELO,MARCA=@MARCA,ABRANGENTE =@ABRANGENTE,FORNECEDOR =@FORNECEDOR," +
                                                                  "PCUSTO =@PCUSTO,LUCRO=@LUCRO,PVENDA=@PVENDA,QUANTIDADE=@QUANTIDADE,ESTOQUEMIN=@ESTOQUEMIN, TIPO=@TIPO WHERE CODIGO = " + prod, conexao);
                                                                 

                    SqlParameter CBARRAS = new SqlParameter("@CBARRAS", TCBarras.Text);
                    comandodeinsercao.Parameters.Add(CBARRAS);
                    SqlParameter DESCRICACAO = new SqlParameter("@DESCRICAO", TDescricao.Text);
                    comandodeinsercao.Parameters.Add(DESCRICACAO);
                    SqlParameter FABRICANTE = new SqlParameter("@FABRICANTE", TFabricante.Text);
                    comandodeinsercao.Parameters.Add(FABRICANTE);
                    SqlParameter MODELO = new SqlParameter("@MODELO", TModelo.Text);
                    comandodeinsercao.Parameters.Add(MODELO);
                    SqlParameter MARCA = new SqlParameter("@MARCA", TMarca.Text);
                    comandodeinsercao.Parameters.Add(MARCA);
                    SqlParameter ABRANGENTE = new SqlParameter("@ABRANGENTE", MAnoAbrangente.Text);
                    comandodeinsercao.Parameters.Add(ABRANGENTE);
                    SqlParameter FORNECEDOR = new SqlParameter("@FORNECEDOR", CFornecedor.Text);
                    comandodeinsercao.Parameters.Add(FORNECEDOR);
                    SqlParameter PCUSTO = new SqlParameter("@PCUSTO", float.Parse(TPCusto.Text));
                    comandodeinsercao.Parameters.Add(PCUSTO);
                    SqlParameter LUCRO = new SqlParameter("@LUCRO", float.Parse(TLucro.Text));
                    comandodeinsercao.Parameters.Add(LUCRO);
                    SqlParameter PVENDA = new SqlParameter("@PVENDA", float.Parse(TPVenda.Text));
                    comandodeinsercao.Parameters.Add(PVENDA);
                    SqlParameter QUANTIDADE = new SqlParameter("@QUANTIDADE", int.Parse(TQTD.Text));
                    comandodeinsercao.Parameters.Add(QUANTIDADE);
                    SqlParameter ESTOQUEMIN = new SqlParameter("@ESTOQUEMIN", int.Parse(TEstoqueMin.Text));
                    comandodeinsercao.Parameters.Add(ESTOQUEMIN);
                    SqlParameter TIPO = new SqlParameter("@TIPO", CTipo.Text);
                    comandodeinsercao.Parameters.Add(TIPO);
                    comandodeinsercao.ExecuteNonQuery();

                    MessageBox.Show("Produto alterado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexao.Close();
                }
            }
            else
            {
                MessageBox.Show("Campos em Negrito são obrigatórios", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void BLimpar_Click(object sender, EventArgs e)        {
            TDescricao.Text = "";
            TCBarras.Text = "0"; 
            TFabricante.Text = "";
            TModelo.Text = "";
            TMarca.Text = "";
            MAnoAbrangente.Text = "";
            CFornecedor.Text = "";
            TPCusto.Text = "0.00";
            TLucro.Text = "0.00";
            TPVenda.Text = "0.00";
            TQTD.Text = "0";
            TEstoqueMin.Text = "0";
            CTipo.Text = "";
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AtribuiCodigo()
        {
            int codigo;
            SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "select MAX(codigo) as cod from produtos";

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

            TCódigo.Text = codigo.ToString();
            conexao.Close();
        }

        private void TLucro_Leave(object sender, EventArgs e)
        {
            verpc();
            verlc();
            vervv();
            verqt();
            veret();

           
        }

        private void TPCusto_Leave(object sender, EventArgs e)
        {
            verpc();
            verlc();
            vervv();
            verqt();
            veret();
        }

        private void TPVenda_Leave(object sender, EventArgs e)
        {
            verpc();
            verlc();
            vervv();
            verqt();
            veret();

        }

        private void TQTD_Leave(object sender, EventArgs e)
        {
            verpc();
            verlc();
            vervv();
            verqt();
            veret();
        }

        private void TEstoqueMin_Leave(object sender, EventArgs e)
        {
            verpc();
            verlc();
            vervv();
            verqt();
            veret();
        }

        private void TLucro_TextChanged(object sender, EventArgs e)
        {
            verpc();
            verlc();
            if (TLucro.Text != "" && TLucro.Text !=" ")
            {
                TPVenda.Text = (((double.Parse(TPCusto.Text) / 100) * (float.Parse(TLucro.Text)) + double.Parse(TPCusto.Text)).ToString("0.00"));
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Fornecedores FORN = new Fornecedores(0);
            FORN.Show();
        }
    }
}
