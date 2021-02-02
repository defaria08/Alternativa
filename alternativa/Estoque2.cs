using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alternativa
{
    public partial class Estoque2 : Form
    {
        string cod;
        public Estoque2(string codigo)
        {
            cod = codigo;
            InitializeComponent();
        }

        private void BGravar_Click(object sender, EventArgs e)
        {
            verletra();
            SqlDataReader leitor;
            string qtde="";
            int novaqtde = 0;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();

            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            selecionafilme = new SqlCommand("select quantidade as quantidade from produtos where codigo =" + cod, conexao);


            leitor = selecionafilme.ExecuteReader();
            if (leitor.Read() == false)
            {
                MessageBox.Show("Dados Inexistentes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            leitor.Close();
            leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                qtde = leitor["quantidade"].ToString();
            }

            if(RAdicionar.Checked == true)
            {
                novaqtde = int.Parse(qtde) + int.Parse(TQTDEN.Text);
            }
            else if(RRemover.Checked==true)
            {
                novaqtde = int.Parse(qtde) - int.Parse(TQTDEN.Text);
            }
            conexao.Close();

            if (novaqtde < 0)
            {
                MessageBox.Show("Produto não pode ter quantidade inferior a 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string vQuery = "update produtos set quantidade = @quantidade where codigo = " + cod;

                SqlCommand comandodeinsercao = new SqlCommand(vQuery, conexao);
                conexao.Open();

                SqlParameter quant = new SqlParameter("@quantidade", novaqtde);
                comandodeinsercao.Parameters.Add(quant);
                comandodeinsercao.ExecuteNonQuery();

                if (RAdicionar.Checked == true)
                {
                    MessageBox.Show("Produto Adicionado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (RRemover.Checked == true)
                {
                    MessageBox.Show("Produto Removido ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                conexao.Close();
            }
            this.Close();

        }

        private void BMais_Click(object sender, EventArgs e)
        {
            TQTDEN.Text = (int.Parse(TQTDEN.Text) + 1).ToString();
        }

        private void BMenos_Click(object sender, EventArgs e)
        {
            if(TQTDEN.Text == "0")
            {
                TQTDEN.Text = "0";
                   
            }
            else
            {
                TQTDEN.Text = (int.Parse(TQTDEN.Text) - 1).ToString();
            }
        }

        private void BCamcelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TQTDEN_Leave(object sender, EventArgs e)
        {
            verletra();
        }
        public void verletra()
        {
            int lt = 0;
            foreach (var letra in TQTDEN.Text)
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
                TQTDEN.Text = "0";
            }

        }
    }
}
