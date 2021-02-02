using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace alternativa
{
    public partial class Clientes : Form
    {
        int validacao;
        int acao;
        string foto1 = "";
        public Clientes(int tipo)
        {
            InitializeComponent();
            acao = tipo;
            if (acao != 0)
            {
                BuscaCliente();
                BAlterar.Enabled = true;
                BGravar.Enabled = false;
            }
        }

        private void BExcluirFoto_Click(object sender, EventArgs e)
        {
            PBFoto.ImageLocation = "C:\\Users\\defar\\Desktop\\Alternativa\\editado\\perfil.png";

        }

        private void BCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Filter = "jpg|*.jpg";
            if (foto.ShowDialog() == DialogResult.OK)
            {
                foto1 = foto.FileName;
                PBFoto.ImageLocation = foto.FileName;
            }
        }

        private void BCapturar_Click(object sender, EventArgs e)
        {

        }
        public void validacpf()
        {
            string valor = MCPF.Text;
            if (RCNPJ.Checked)
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
            else if (RCPF.Checked)
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
        public bool Verficadados()
        {
            if (TNome.Text == "" || MTelefone.Text == "(  )     -" || MCPF.Text == "  ,   ,   -")
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
                validacpf();
                if (validacao == 1)
                {
                    verletra();
                    SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    SqlCommand comandodeinsercao = new SqlCommand("Insert into ClienteS (Nome, apelido, datan, telefone,celular," +
                                                                    "mail,rg,cpf,endereco,numero,complemento,bairro,cep,cidade,uf,situacao,foto)" +
                                                                    "values" +
                                                                    "(@Nome,@apelido,@datan,@telefone,@celular,@mail,@rg,@cpf,@endereco,@numero," +
                                                                    "@complemento,@bairro,@cep,@cidade,@uf,@situacao,@foto)", conexao);


                    SqlParameter nome = new SqlParameter("@Nome", TNome.Text);
                    comandodeinsercao.Parameters.Add(nome);
                    SqlParameter apelido = new SqlParameter("@apelido", TApelido.Text);
                    comandodeinsercao.Parameters.Add(apelido);
                    SqlParameter datan = new SqlParameter("@datan", DTNascimento.Text);
                    comandodeinsercao.Parameters.Add(datan);
                    SqlParameter telefone = new SqlParameter("@telefone", MTelefone.Text);
                    comandodeinsercao.Parameters.Add(telefone);
                    SqlParameter celular = new SqlParameter("@celular", MCelular.Text);
                    comandodeinsercao.Parameters.Add(celular);
                    SqlParameter mail = new SqlParameter("@mail", TMail.Text);
                    comandodeinsercao.Parameters.Add(mail);
                    SqlParameter rg = new SqlParameter("@rg", MRg.Text);
                    comandodeinsercao.Parameters.Add(rg);
                    SqlParameter cpf = new SqlParameter("@cpf", MCPF.Text);
                    comandodeinsercao.Parameters.Add(cpf);
                    SqlParameter endereco = new SqlParameter("@endereco", TEndereco.Text);
                    comandodeinsercao.Parameters.Add(endereco);
                    SqlParameter numero = new SqlParameter("@numero", int.Parse(TNumero.Text));
                    comandodeinsercao.Parameters.Add(numero);
                    SqlParameter complemento = new SqlParameter("@complemento", TComplemento.Text);
                    comandodeinsercao.Parameters.Add(complemento);
                    SqlParameter bairro = new SqlParameter("@bairro", TBairro.Text);
                    comandodeinsercao.Parameters.Add(bairro);
                    SqlParameter cep = new SqlParameter("@cep", MCEP.Text);
                    comandodeinsercao.Parameters.Add(cep);
                    SqlParameter cidade = new SqlParameter("@cidade", TCidade.Text);
                    comandodeinsercao.Parameters.Add(cidade);
                    SqlParameter uf = new SqlParameter("@uf", TUf.Text);
                    comandodeinsercao.Parameters.Add(uf);
                    SqlParameter situacao = new SqlParameter("@situacao", "ATIVO");
                    comandodeinsercao.Parameters.Add(situacao);
                    SqlParameter foto = new SqlParameter("@foto", foto1);
                    comandodeinsercao.Parameters.Add(foto);
                    comandodeinsercao.ExecuteNonQuery();

                    MessageBox.Show("Cliente Cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Documento Inválido", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Campos em Negrito são obrigatórios", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void RCPF_CheckedChanged(object sender, EventArgs e)
        {
            MCPF.Mask = "000.000.000-00";
        }

        private void RCNPJ_CheckedChanged(object sender, EventArgs e)
        {
            MCPF.Mask = "00.000.000/0000-00";
        }

        private void RRG_CheckedChanged(object sender, EventArgs e)
        {
            MRg.Mask = "00.000.000-00";
        }

        private void RIE_CheckedChanged(object sender, EventArgs e)
        {
            MRg.Mask = "000.000.000.000";
        }
        private void BuscaCliente()
        {

            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            selecionafilme = new SqlCommand("select id as cod, Nome, apelido, datan, telefone,celular," +
                                                               "mail,rg,cpf,endereco,numero,complemento,bairro, " +
                                                               "cep,cidade,uf,foto from Clientes where id =" + acao, conexao);
            leitor = selecionafilme.ExecuteReader();

            if (leitor.Read() == true)
            {

                TNome.Text = leitor["Nome"].ToString();
                TApelido.Text = leitor["apelido"].ToString();
                DTNascimento.Text = leitor["datan"].ToString();
                MTelefone.Text = leitor["telefone"].ToString();
                MCelular.Text = leitor["celular"].ToString();
                TMail.Text = leitor["mail"].ToString();
                MRg.Text = leitor["rg"].ToString();
                MCPF.Text = leitor["cpf"].ToString();
                TEndereco.Text = leitor["endereco"].ToString();
                TNumero.Text = leitor["numero"].ToString();
                TComplemento.Text = leitor["complemento"].ToString();
                TBairro.Text = leitor["bairro"].ToString();
                MCEP.Text = leitor["cep"].ToString();
                TCidade.Text = leitor["cidade"].ToString();
                TUf.Text = leitor["uf"].ToString();
                PBFoto.ImageLocation = leitor["foto"].ToString();


            }


            leitor.Close();
            conexao.Close();

        }

        private void BLimpar_Click(object sender, EventArgs e)
        {
            TNome.Text = "";
            TApelido.Text = "";
            DTNascimento.Text = DateTime.Now.ToShortDateString();
            MTelefone.Text = "";
            MCelular.Text = "";
            TMail.Text = "";
            MRg.Text = "";
            MCPF.Text = "";
            TEndereco.Text = "";
            TNumero.Text = "";
            TComplemento.Text = "";
            TBairro.Text = "";
            MCEP.Text = "";
            TCidade.Text = "";
            TUf.Text = "";

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
                if (letra == '.' || letra == ' ')
                {
                    lt = 1;
                }

            }
            if (lt == 1 || TNumero.Text == "")
            {
                MessageBox.Show("Número não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TNumero.Text = "0";
            }

        }

        private void BAlterar_Click(object sender, EventArgs e)
        {
            if (Verficadados())
            {
                validacpf();
                if (validacao == 1)
                {
                    SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    SqlCommand comandodeinsercao = new SqlCommand("update ClienteS set Nome =@Nome, apelido = @apelido, datan= @datan, telefone = @telefone,celular = @celular," +
                                                                    "mail = @mail,rg = @rg,cpf = @cpf,endereco =@endereco,numero=@numero,complemento=@complemento,bairro = @bairro,cep = @cep,cidade = @cidade,uf = @uf,situacao = @situacao,foto = @foto" +
                                                                    " where id = "+ acao, conexao);


                    SqlParameter nome = new SqlParameter("@Nome", TNome.Text);
                    comandodeinsercao.Parameters.Add(nome);
                    SqlParameter apelido = new SqlParameter("@apelido", TApelido.Text);
                    comandodeinsercao.Parameters.Add(apelido);
                    SqlParameter datan = new SqlParameter("@datan", DTNascimento.Text);
                    comandodeinsercao.Parameters.Add(datan);
                    SqlParameter telefone = new SqlParameter("@telefone", MTelefone.Text);
                    comandodeinsercao.Parameters.Add(telefone);
                    SqlParameter celular = new SqlParameter("@celular", MCelular.Text);
                    comandodeinsercao.Parameters.Add(celular);
                    SqlParameter mail = new SqlParameter("@mail", TMail.Text);
                    comandodeinsercao.Parameters.Add(mail);
                    SqlParameter rg = new SqlParameter("@rg", MRg.Text);
                    comandodeinsercao.Parameters.Add(rg);
                    SqlParameter cpf = new SqlParameter("@cpf", MCPF.Text);
                    comandodeinsercao.Parameters.Add(cpf);
                    SqlParameter endereco = new SqlParameter("@endereco", TEndereco.Text);
                    comandodeinsercao.Parameters.Add(endereco);
                    SqlParameter numero = new SqlParameter("@numero", int.Parse(TNumero.Text));
                    comandodeinsercao.Parameters.Add(numero);
                    SqlParameter complemento = new SqlParameter("@complemento", TComplemento.Text);
                    comandodeinsercao.Parameters.Add(complemento);
                    SqlParameter bairro = new SqlParameter("@bairro", TBairro.Text);
                    comandodeinsercao.Parameters.Add(bairro);
                    SqlParameter cep = new SqlParameter("@cep", MCEP.Text);
                    comandodeinsercao.Parameters.Add(cep);
                    SqlParameter cidade = new SqlParameter("@cidade", TCidade.Text);
                    comandodeinsercao.Parameters.Add(cidade);
                    SqlParameter uf = new SqlParameter("@uf", TUf.Text);
                    comandodeinsercao.Parameters.Add(uf);
                    SqlParameter situacao = new SqlParameter("@situacao", "ATIVO");
                    comandodeinsercao.Parameters.Add(situacao);
                    SqlParameter foto = new SqlParameter("@foto", foto1);
                    comandodeinsercao.Parameters.Add(foto);
                    comandodeinsercao.ExecuteNonQuery();

                    MessageBox.Show("Cliente Alterado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexao.Close();
                }
                else
                {
                    MessageBox.Show("Documento Inválido", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Campos em Negrito são obrigatórios", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
