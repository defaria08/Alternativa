using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alternativa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            CARREGADADOS();
        }
        public void CARREGADADOS()
        {

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

            leitor = selecionafilme.ExecuteReader();
            if (leitor.Read() != false)
            {
                TNomeFan.Text = leitor["NOME"].ToString();
                Tend.Text = leitor["ENDERECO"].ToString();
                Tnum.Text = leitor["NUMERO"].ToString();
                TComple.Text = leitor["COMPLEMENTO"].ToString();
                TBairro.Text = leitor["BAIRRO"].ToString();
                MCEP.Text = leitor["CEP"].ToString();
                Tcidade.Text = leitor["CIDADE"].ToString();
                CEstado.Text = leitor["ESTADO"].ToString();
                MTelefone.Text = leitor["TELEFONE"].ToString();
                MCelular.Text = leitor["CELULAR"].ToString();
                TEmail.Text = leitor["EMAIL"].ToString();

                if (leitor["VINCULAR"].ToString() == "S")
                {
                    CheckVincula.Checked = true;
                }
                else
                {
                    CheckVincula.Checked = false;
                }
                

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            verletra();
            SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");

            string vQuery = "update EMPRESA set NOMEFAN=@NOMEFAN, ENDERECO = @ENDERECO, NUMERO = @NUMERO, COMPLEMENTO = @COMPLEMENTO," +
                            "BARRIO = @BAIRRO, CEP= @CEP, CIDADE = @CIDADE,ESTADO = @ESTADO, TELEFONE = @TELEFONE, CELULAR = @CELULAR, "+
                            "EMAIL = @EMAIL, VINCULAR = @VINCULAR";

            SqlCommand comandodeinsercao = new SqlCommand(vQuery, conexao);
            conexao.Open();

            SqlParameter NOMEFAN = new SqlParameter("@NOMEFAN", TNomeFan.Text);
            comandodeinsercao.Parameters.Add(NOMEFAN);
            SqlParameter ENDERECO = new SqlParameter("@ENDERECO", Tend.Text);
            comandodeinsercao.Parameters.Add(ENDERECO);
            SqlParameter NUMERO = new SqlParameter("@NUMERO", int.Parse(Tnum.Text));
            comandodeinsercao.Parameters.Add(NUMERO);
            SqlParameter COMPLEMENTO = new SqlParameter("@COMPLEMENTO", TComple.Text);
            comandodeinsercao.Parameters.Add(COMPLEMENTO);
            SqlParameter BAIRRO = new SqlParameter("@BAIRRO", TBairro.Text);
            comandodeinsercao.Parameters.Add(BAIRRO);
            SqlParameter CEP = new SqlParameter("@CEP", MCEP.Text);
            comandodeinsercao.Parameters.Add(CEP);
            SqlParameter CIDADE = new SqlParameter("@CIDADE", Tcidade.Text);
            comandodeinsercao.Parameters.Add(CIDADE);
            SqlParameter ESTADO = new SqlParameter("@ESTADO", CEstado.Text);
            comandodeinsercao.Parameters.Add(ESTADO);
            SqlParameter TELEFONE = new SqlParameter("@TELEFONE",MTelefone.Text);
            comandodeinsercao.Parameters.Add(TELEFONE);
            SqlParameter CELULAR = new SqlParameter("@CELULAR", MCelular .Text);
            comandodeinsercao.Parameters.Add(CELULAR);
            SqlParameter EMAIL = new SqlParameter("@EMAIL", TEmail.Text);
            comandodeinsercao.Parameters.Add(EMAIL);
            if (CheckVincula.Checked == true)
            {
                SqlParameter VINCULAR = new SqlParameter("@VINCULAR", "S");
                comandodeinsercao.Parameters.Add(VINCULAR);
            }
            else
            {
                SqlParameter VINCULAR = new SqlParameter("@VINCULAR", "N");
                comandodeinsercao.Parameters.Add(VINCULAR);
            }

            comandodeinsercao.ExecuteNonQuery();
            MessageBox.Show("Dados Alterados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Tnum_Leave(object sender, EventArgs e)
        {
            verletra();
        }
        public void verletra()
        {
            int lt = 0;
            foreach (var letra in Tnum.Text)
            {
                if (char.IsLetter(letra) == true)
                {
                    lt = 1;
                }
            }
            if (lt == 1)
            {
                MessageBox.Show("Número não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Tnum.Text = "0";
            }

        }
    }
}
