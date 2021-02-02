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
    public partial class Fornecedores : Form
    {
        int forn;
        int validacao;
        public Fornecedores(int cforn)
        {
            InitializeComponent();
            AtribuiCodigo();
            forn = cforn;
            if(cforn != 0)
            {
                CarregaForn();
                BGravar.Text = "Alterar";
            }
        }
        public void CarregaForn()
        {
            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            selecionafilme = new SqlCommand("select codigo, RSOCIAL,NFANTASIA,ENDERECO,NUMERO,COMPLEMENTO,BAIRRO," +
                                                            "CIDADE,CEP,ESTADO,SITUACAO,TELEFONE,CELULAR,FAX,EMAIL,CNPJ,IE,IM,CONTATO " +
                                                               "from fornecedores where codigo =" + forn, conexao);
            leitor = selecionafilme.ExecuteReader();

            if (leitor.Read() == true)
            {
                TCodigo.Text = leitor["codigo"].ToString();
                TRSocial.Text = leitor["RSOCIAL"].ToString();
                TNFantasia.Text = leitor["NFANTASIA"].ToString();
                TEndereco.Text = leitor["ENDERECO"].ToString();
                TNumero.Text = leitor["NUMERO"].ToString();
                TComplemento.Text = leitor["COMPLEMENTO"].ToString();
                TBairro.Text = leitor["BAIRRO"].ToString();
                TCidade.Text = leitor["CIDADE"].ToString();
                MCEP.Text = leitor["CEP"].ToString();
                CEstado.Text = leitor["ESTADO"].ToString();
                CSituacao.Text = leitor["SITUACAO"].ToString();
                MTelefone.Text = leitor["TELEFONE"].ToString();
                MCelular.Text = leitor["CELULAR"].ToString();
                MFax.Text = leitor["FAX"].ToString();
                TMail.Text = leitor["EMAIL"].ToString();
                MCNPJ.Text = leitor["CNPJ"].ToString();
                TIEstadual.Text = leitor["IE"].ToString();
                TIMunicipal.Text = leitor["IM"].ToString();
                TContato.Text = leitor["CONTATO"].ToString();

            }


            leitor.Close();
            conexao.Close();
        }
        public void AtribuiCodigo()
        {
            int codigo;
            SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();
            string vQuery = "select MAX(codigo) as cod from fornecedores";

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
        public void validacpf()
        {
            string valor = MCNPJ.Text;

            if (Validacao.ValidaCNPJ.IsCnpj(valor))
            {
                validacao = 1;
            }
            else
            {
                validacao = 0;
            }

        }
        private void BGravar_Click(object sender, EventArgs e)
        {


            validacpf();

            if (validacao == 1)
            {
                verletra();

                if (BGravar.Text != "Alterar")
                {
                    SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    SqlCommand comandodeinsercao = new SqlCommand("Insert into fornecedores (RSOCIAL,NFANTASIA,ENDERECO,NUMERO,COMPLEMENTO,BAIRRO," +
                                                                    "CIDADE,CEP,ESTADO,SITUACAO,TELEFONE,CELULAR,FAX,EMAIL,CNPJ,IE,IM,CONTATO)" +
                                                                    "values" +
                                                                    "(@RSOCIAL, @NFANTASIA, @ENDERECO, @NUMERO, @COMPLEMENTO, @BAIRRO, " +
                                                                    "@CIDADE,@CEP,@ESTADO,@SITUACAO,@TELEFONE,@CELULAR,@FAX,@EMAIL,@CNPJ,@IE,@IM,@CONTATO)", conexao);


                    SqlParameter RSOCIAL = new SqlParameter("@RSOCIAL", TRSocial.Text);
                    comandodeinsercao.Parameters.Add(RSOCIAL);
                    SqlParameter NFANTASIA = new SqlParameter("@NFANTASIA", TNFantasia.Text);
                    comandodeinsercao.Parameters.Add(NFANTASIA);
                    SqlParameter ENDERECO = new SqlParameter("@ENDERECO", TEndereco.Text);
                    comandodeinsercao.Parameters.Add(ENDERECO);
                    SqlParameter NUMERO = new SqlParameter("@NUMERO", TNumero.Text);
                    comandodeinsercao.Parameters.Add(NUMERO);
                    SqlParameter COMPLEMENTO = new SqlParameter("@COMPLEMENTO", TComplemento.Text);
                    comandodeinsercao.Parameters.Add(COMPLEMENTO);
                    SqlParameter BAIRRO = new SqlParameter("@BAIRRO", TBairro.Text);
                    comandodeinsercao.Parameters.Add(BAIRRO);
                    SqlParameter CIDADE = new SqlParameter("@CIDADE", TCidade.Text);
                    comandodeinsercao.Parameters.Add(CIDADE);
                    SqlParameter CEP = new SqlParameter("@CEP", MCEP.Text);
                    comandodeinsercao.Parameters.Add(CEP);
                    SqlParameter ESTADO = new SqlParameter("@ESTADO", CEstado.Text);
                    comandodeinsercao.Parameters.Add(ESTADO);
                    SqlParameter SITUACAO = new SqlParameter("@SITUACAO", CSituacao.Text);
                    comandodeinsercao.Parameters.Add(SITUACAO);
                    SqlParameter TELEFONE = new SqlParameter("@TELEFONE", MTelefone.Text);
                    comandodeinsercao.Parameters.Add(TELEFONE);
                    SqlParameter CELULAR = new SqlParameter("@CELULAR", MCelular.Text);
                    comandodeinsercao.Parameters.Add(CELULAR);
                    SqlParameter FAX = new SqlParameter("@FAX", MFax.Text);
                    comandodeinsercao.Parameters.Add(FAX);
                    SqlParameter EMAIL = new SqlParameter("@EMAIL", TMail.Text);
                    comandodeinsercao.Parameters.Add(EMAIL);
                    SqlParameter CNPJ = new SqlParameter("@CNPJ", MCNPJ.Text);
                    comandodeinsercao.Parameters.Add(CNPJ);
                    SqlParameter IE = new SqlParameter("@IE", TIEstadual.Text);
                    comandodeinsercao.Parameters.Add(IE);
                    SqlParameter IM = new SqlParameter("@IM", TIMunicipal.Text);
                    comandodeinsercao.Parameters.Add(IM);
                    SqlParameter CONTATO = new SqlParameter("@CONTATO", TContato.Text);
                    comandodeinsercao.Parameters.Add(CONTATO);

                    comandodeinsercao.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor Cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexao.Close();
          
                }

                else
                {
                    SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    SqlCommand comandodeinsercao = new SqlCommand("update fornecedores set RSOCIAL = @RSOCIAL,NFANTASIA = @NFANTASIA,ENDERECO = @ENDERECO,NUMERO = @NUMERO,COMPLEMENTO = @COMPLEMENTO,BAIRRO = @BAIRRO," +
                                                                    "CIDADE = @CIDADE ,CEP = @CEP ,ESTADO =@ESTADO ,SITUACAO =@SITUACAO ,TELEFONE = @TELEFONE ,CELULAR =@CELULAR ,FAX = @FAX,EMAIL = @EMAIL ,CNPJ = @CNPJ,IE = @IE,IM=@IM,CONTATO=@CONTATO " +
                                                                     "WHERE CODIGO = " + forn, conexao);


                    SqlParameter RSOCIAL = new SqlParameter("@RSOCIAL", TRSocial.Text);
                    comandodeinsercao.Parameters.Add(RSOCIAL);
                    SqlParameter NFANTASIA = new SqlParameter("@NFANTASIA", TNFantasia.Text);
                    comandodeinsercao.Parameters.Add(NFANTASIA);
                    SqlParameter ENDERECO = new SqlParameter("@ENDERECO", TEndereco.Text);
                    comandodeinsercao.Parameters.Add(ENDERECO);
                    SqlParameter NUMERO = new SqlParameter("@NUMERO", TNumero.Text);
                    comandodeinsercao.Parameters.Add(NUMERO);
                    SqlParameter COMPLEMENTO = new SqlParameter("@COMPLEMENTO", TComplemento.Text);
                    comandodeinsercao.Parameters.Add(COMPLEMENTO);
                    SqlParameter BAIRRO = new SqlParameter("@BAIRRO", TBairro.Text);
                    comandodeinsercao.Parameters.Add(BAIRRO);
                    SqlParameter CIDADE = new SqlParameter("@CIDADE", TCidade.Text);
                    comandodeinsercao.Parameters.Add(CIDADE);
                    SqlParameter CEP = new SqlParameter("@CEP", MCEP.Text);
                    comandodeinsercao.Parameters.Add(CEP);
                    SqlParameter ESTADO = new SqlParameter("@ESTADO", CEstado.Text);
                    comandodeinsercao.Parameters.Add(ESTADO);
                    SqlParameter SITUACAO = new SqlParameter("@SITUACAO", CSituacao.Text);
                    comandodeinsercao.Parameters.Add(SITUACAO);
                    SqlParameter TELEFONE = new SqlParameter("@TELEFONE", MTelefone.Text);
                    comandodeinsercao.Parameters.Add(TELEFONE);
                    SqlParameter CELULAR = new SqlParameter("@CELULAR", MCelular.Text);
                    comandodeinsercao.Parameters.Add(CELULAR);
                    SqlParameter FAX = new SqlParameter("@FAX", MFax.Text);
                    comandodeinsercao.Parameters.Add(FAX);
                    SqlParameter EMAIL = new SqlParameter("@EMAIL", TMail.Text);
                    comandodeinsercao.Parameters.Add(EMAIL);
                    SqlParameter CNPJ = new SqlParameter("@CNPJ", MCNPJ.Text);
                    comandodeinsercao.Parameters.Add(CNPJ);
                    SqlParameter IE = new SqlParameter("@IE", TIEstadual.Text);
                    comandodeinsercao.Parameters.Add(IE);
                    SqlParameter IM = new SqlParameter("@IM", TIMunicipal.Text);
                    comandodeinsercao.Parameters.Add(IM);
                    SqlParameter CONTATO = new SqlParameter("@CONTATO", TContato.Text);
                    comandodeinsercao.Parameters.Add(CONTATO);

                    comandodeinsercao.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor Alterado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexao.Close();
                }
            }
            else
            {
                MessageBox.Show("Documento Inválido", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        public void limpaform()
        {
            AtribuiCodigo();
            TRSocial.Text = "";
            TNFantasia.Text = "";
            TEndereco.Text = "";
            TNumero.Text = "0";
            TComplemento.Text = "";
            TBairro.Text = "";
            TCidade.Text = "";
            MCEP.Text = "";
            CEstado.Text = "";
            CSituacao.Text = "ATIVO";
            MTelefone.Text = "";
            MCelular.Text = "";
            MFax.Text = "";
            TMail.Text = "";
            MCNPJ.Text = "";
            TIEstadual.Text = "";
            TIMunicipal.Text = "";
            TContato.Text = "";
        }

        private void BLimpar_Click(object sender, EventArgs e)
        {
            limpaform();
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TNumero_Leave(object sender, EventArgs e)
        {
            verletra();
        }
        public void verletra()
        {
            int lt = 0;
            foreach (var letra in TNumero.Text)
            {
                if (char.IsLetter(letra) == true)
                {
                    lt = 1;
                }
                if (letra == '.' || letra == ' ' )
                {
                   lt = 1;
                }
            }
            if (lt == 1)
            {
                MessageBox.Show("Número não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TNumero.Text = "0";
            }

        }
    }
}
