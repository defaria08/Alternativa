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

namespace alternativa
{
    public partial class Usuario : Form
    {
        int validacao;
        int codiuser = 0;
        string foto1 = "";
        public Usuario(int coduser)
        {
            InitializeComponent();
            codiuser = coduser;
            if (codiuser != 0)
            {
                TLogin.Enabled = false;
                TSenha.Enabled = false;
                TVSenha.Enabled = false;
                BAlterar.Enabled = true;
                BGravar.Enabled = false;
                buscaruser();
            }
        }
        public void validacpf()
        {
            string valor = MCPF.Text;

            if (Validacao.ValidaCPF.IsCpf(valor))
            {
                validacao = 1;
            }
            else
            {
                validacao = 0;
            }

        }
        private void BCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            foto.Filter = "jpg|*.jpg";
            if (foto.ShowDialog() == DialogResult.OK)
            {
                foto1 = foto.FileName;
                PBFoto.ImageLocation = foto1;
                foto1 = PBFoto.ImageLocation;
            }
        }

        private void BExcluirFoto_Click(object sender, EventArgs e)
        {
            PBFoto.ImageLocation = "C:\\Users\\defar\\Desktop\\Alternativa\\editado\\perfil.png";

        }
        public bool Verficadados()
        {
            if (TNome.Text == "" || MTelefone.Text == "(  )     -" || MCPF.Text == "  ,   ,   -" || TLogin.Text =="" || TSenha.Text =="" ||CClasse.Text =="")
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
                    if (TSenha.Text == TVSenha.Text)
                    {
                        SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                        conexao.Open();

                        SqlCommand comandodeinsercao = new SqlCommand("Insert into USUARIOS (Nome, apelido, datan, telefone,celular," +
                                                                        "mail,rg,cpf,endereco,numero,complemento,bairro,cep,cidade,uf, loginn,senha,classe, situacao,foto)" +
                                                                        "values" +
                                                                        "(@Nome,@apelido,@datan,@telefone,@celular,@mail,@rg,@cpf,@endereco,@numero," +
                                                                        "@complemento,@bairro,@cep,@cidade,@uf,@loginn,@senha,@classe,@situacao,@foto)", conexao);


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
                        SqlParameter login = new SqlParameter("@loginn", TLogin.Text);
                        comandodeinsercao.Parameters.Add(login);
                        SqlParameter senha = new SqlParameter("@senha", TSenha.Text);
                        comandodeinsercao.Parameters.Add(senha);
                        SqlParameter classe = new SqlParameter("@classe", CClasse.Text);
                        comandodeinsercao.Parameters.Add(classe);
                        SqlParameter situacao = new SqlParameter("@situacao", "ATIVO");
                        comandodeinsercao.Parameters.Add(situacao);
                        SqlParameter foto = new SqlParameter("@foto", foto1);
                        comandodeinsercao.Parameters.Add(foto);

                        comandodeinsercao.ExecuteNonQuery();

                        MessageBox.Show("Usuário Cadastrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        conexao.Close();
                    }
                    else
                    {
                        MessageBox.Show("Senhas não coencidem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
        private void buscaruser()
        {
            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            selecionafilme = new SqlCommand("select id as cod, Nome, apelido, datan, telefone,celular," +
                                                               "mail,rg,cpf,endereco,numero,complemento," +
                                                               "bairro,cep,cidade,uf, loginn,senha,classe,foto" +
                                                               " from usuarios where id =" + codiuser, conexao);
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
                TLogin.Text = leitor["loginn"].ToString();
                TSenha.Text = leitor["senha"].ToString();
                TVSenha.Text = leitor["senha"].ToString();
                CClasse.Text = leitor["classe"].ToString();
                PBFoto.ImageLocation = leitor["foto"].ToString();
            }


            leitor.Close();
            conexao.Close();

        }

        private void BLimpar_Click(object sender, EventArgs e)
        {
            TLogin.Enabled = true;
            TSenha.Enabled = true;
            TVSenha.Enabled = true;

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
            TLogin.Text = "";
            TSenha.Text = "";
            TVSenha.Text = "";
            CClasse.Text = "";


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
            if (lt == 1)
            {
                MessageBox.Show("Número não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TNumero.Text = "0";
            }

        }

        private void BAlterar_Click(object sender, EventArgs e)
        {
            verletra();
            validacpf();
            if (validacao == 1)
            {

                SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                conexao.Open();

                SqlCommand comandodeinsercao = new SqlCommand("update USUARIOS set  apelido = @apelido, datan = @datan, telefone = @telefone,celular = @celular," +
                                                                   "mail = @mail,rg = @rg,cpf =@cpf,endereco= @endereco,numero =@numero,complemento = @complemento," +
                                                                   "bairro = @bairro,cep = @cep,cidade =@cidade,uf =@uf, foto = @foto)" +
                                                                    "where id = " + codiuser, conexao);



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

                SqlParameter foto = new SqlParameter("@foto", foto1);
                comandodeinsercao.Parameters.Add(foto);

                comandodeinsercao.ExecuteNonQuery();

                MessageBox.Show("Usuário Alterado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conexao.Close();
            }

            else
            {
                MessageBox.Show("Documento Inválido", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}