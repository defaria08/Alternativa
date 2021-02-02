using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alternativa
{
    public partial class movimentacaodecaixa : Form
    {
        string user;
        public movimentacaodecaixa(string tipo, string usr)
        {
            InitializeComponent();
            COperacao.Text = tipo;
            user = usr;
            TUSer.Text = user;
        }

        private void BCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BLAncar_Click(object sender, EventArgs e)
        {
            verletra();
            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();


            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            selecionafilme = new SqlCommand("select codcaixa as cod from caixa where datacaixa = '" + TDataCaixa.Value + "' and situacao = 'Aberto'", conexao);
            leitor = selecionafilme.ExecuteReader();

            if (leitor.Read() == true)
            {



                string senha = "";


                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();

                selecionafilme = new SqlCommand("select senha as sen from USUARIOS where UPPER(LOGINN) ='" + TLogin.Text.ToUpper() + "'", conexao);
                leitor = selecionafilme.ExecuteReader();

                if (leitor.Read() == true)
                {

                    senha = leitor["sen"].ToString();
                }
                leitor.Close();
                conexao.Close();

                if (TSenha.Text == senha)
                {
                    conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    SqlCommand comandodeinsercao = new SqlCommand("Insert into movimentacoes(datacaixa, usuario, operacao, valor, tipo, justificativa, aprovacao)" +
                                                                    "values" +
                                                                    "(@datacaixa, @usuario, @operacao, @valor, @tipo, @justificativa, @aprovacao)", conexao);


                    SqlParameter datacaixa = new SqlParameter("@datacaixa", TDataCaixa.Value);
                    comandodeinsercao.Parameters.Add(datacaixa);
                    SqlParameter usuario = new SqlParameter("@usuario", user);
                    comandodeinsercao.Parameters.Add(usuario);
                    SqlParameter operacao = new SqlParameter("@operacao", COperacao.Text);
                    comandodeinsercao.Parameters.Add(operacao);
                    SqlParameter valor = new SqlParameter("@valor", double.Parse(TValor.Text));
                    comandodeinsercao.Parameters.Add(valor);
                    SqlParameter tipo = new SqlParameter("@tipo", Ctipo.Text);
                    comandodeinsercao.Parameters.Add(tipo);
                    SqlParameter justificativa = new SqlParameter("@justificativa", TJustificativa.Text);
                    comandodeinsercao.Parameters.Add(justificativa);
                    SqlParameter aprovacao = new SqlParameter("@aprovacao", TLogin.Text);
                    comandodeinsercao.Parameters.Add(aprovacao);


                    comandodeinsercao.ExecuteNonQuery();

                    MessageBox.Show("Movimentação Cadastrada", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Senhas não coencidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Não existe um caixa aberto!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TValor_Leave(object sender, EventArgs e)
        {
            verletra();
        }
        public void verletra()
        {
            int lt = 0;
            foreach (var letra in TValor.Text)
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
                MessageBox.Show("Valor não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TValor.Text = "0";
            }

        }
    }
}
