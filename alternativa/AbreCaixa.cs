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
    public partial class AbreCaixa : Form
    {
        double total = 0, total2 = 0, total3 = 0, fundo = 0,totale= 0, totals=0;
        int lt = 0;
        private void BCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public AbreCaixa(string situacao)
        {
            InitializeComponent();
         
            if(situacao =="Abrir")
            {
                RAbertura.Checked = true;
            }
            else if(situacao =="Fechar")
            {
                RFechamento.Checked = true;
            }

        }
        public void calculatotal()
        {
                    
            SqlDataReader leitor;
            
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();

            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            selecionafilme = new SqlCommand(" select sum(valor) as total from vendas where data = '"+DTData.Value+"'", conexao);
            leitor = selecionafilme.ExecuteReader();
            if(leitor.Read() == true)
            {
                if (leitor["total"].ToString() != "")
                {
                    total = double.Parse(leitor["total"].ToString());
                }
            }
            leitor.Close();
            conexao.Close();
            //---------------------------------------------------------------------------------------------

            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            selecionafilme = new SqlCommand(" select sum(valor) as total from movimentacoes where datacaixa = '" + DTData.Value + "' and operacao = 'Entrada'", conexao);
            leitor = selecionafilme.ExecuteReader();
            if (leitor.Read() == true)
            {
                if (leitor["total"].ToString() != "")
                {
                    totale = double.Parse(leitor["total"].ToString());
                }
            }
            leitor.Close();
            conexao.Close();
            //--------------------------------------------------------------------------------------------- 
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            selecionafilme = new SqlCommand(" select sum(valor) as total from movimentacoes where datacaixa = '" + DTData.Value + "' and operacao = 'Saída' ", conexao);
            leitor = selecionafilme.ExecuteReader();
            if (leitor.Read() == true)
            {
                if (leitor["total"].ToString() != "")
                {
                    totals = double.Parse(leitor["total"].ToString());
                }
            }
            leitor.Close();
            conexao.Close();
            //--------------------------------------------------------------------------------------------- 
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            selecionafilme = new SqlCommand("select sum(totaldia) as total from caixa where datacaixa = '" + DTData.Value + "'", conexao);
            leitor = selecionafilme.ExecuteReader();
            if(leitor.Read() ==true)
            {
                if (leitor["total"].ToString() != "")
                {
                    
                    total2 = double.Parse(leitor["total"].ToString());
                }
                else
                {
                    total2 = 0;
                }

                
            }

            leitor.Close();
            conexao.Close();
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            selecionafilme = new SqlCommand("select valorinit as fundo from caixa where datacaixa = '" + DTData.Value + "' and situacao = 'Aberto'", conexao);
            leitor = selecionafilme.ExecuteReader();
            if (leitor.Read() == true)
            {
                if (leitor["fundo"].ToString() != "")
                {
                    fundo = double.Parse(leitor["fundo"].ToString());
                }
                else
                {
                    fundo = 0;
                }
            }
            total3 = total - total2 + fundo - totals + totale;

            TSaldo.Text = total3.ToString("0.00");

            leitor.Close();
            conexao.Close();
        }
    



        private void RAbertura_CheckedChanged(object sender, EventArgs e)
        {
            DTData.Enabled = false;
            BAbFc.Text = "Abrir";
            LSaldoInicial.Text = "Valor Inicial";
        }

        private void RFaturamento_CheckedChanged(object sender, EventArgs e)
        {
            DTData.Enabled = true;
            BAbFc.Text = "Fechar";
            LSaldoInicial.Text = "Total do Dia";
            calculatotal();
        }
        public void verificaletra()
        {
            lt = 0;
            foreach(var letra in TSaldo.Text)
            {
                if (char.IsLetter(letra) == true)
                {
                    lt = 1;
                }
            }
        }
        private void BAbFc_Click(object sender, EventArgs e)
        {
            verificaletra();
            if (lt != 1)
            {
                if (RAbertura.Checked == true)
                {

                    SqlDataReader leitor, leitor2;
                    SqlCommand selecionafilme = new SqlCommand();
                    SqlConnection conexao = new SqlConnection();

                    //-------------------------------------------------------------------------------------------------
                    //-------------------------------------------------------------------------------------------------

                    conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    selecionafilme = new SqlCommand("select * from caixa where datacaixa = '" + DTData.Value + "' and situacao = 'Aberto'", conexao);

                    //-------------------------------------------------------------------------------------------------
                    //-------------------------------------------------------------------------------------------------

                    leitor = selecionafilme.ExecuteReader();
                    if (leitor.Read() == true)
                    {
                        MessageBox.Show("Já existe um caixa aberto ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        leitor.Close();

                    }
                    else
                    {
                        leitor.Close();

                        SqlCommand buscasenha = new SqlCommand("select senha, classe from usuarios where loginn = '" + TUsuario.Text.ToUpper() + "'", conexao);
                        leitor2 = buscasenha.ExecuteReader();


                        if (leitor2.Read() == true)
                        {
                            if (leitor2["senha"].ToString() == TSenha.Text)
                            {
                                conexao.Close();

                                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                                conexao.Open();

                                SqlCommand insere = new SqlCommand("Insert into caixa (datacaixa, horaabre, valorinit, situacao, usuarioabre)" +
                                                                                        "values" +
                                                                                        "(@datacaixa, @horaabre, @valorinit, @situacao, @usuarioabre)", conexao);



                                SqlParameter datacaixa = new SqlParameter("@datacaixa", DTData.Text);
                                insere.Parameters.Add(datacaixa);
                                SqlParameter horaabre = new SqlParameter("@horaabre", DTHora.Text);
                                insere.Parameters.Add(horaabre);
                                SqlParameter valorinit = new SqlParameter("@valorinit", double.Parse(TSaldo.Text));
                                insere.Parameters.Add(valorinit);
                                SqlParameter situacao = new SqlParameter("@situacao", "Aberto");
                                insere.Parameters.Add(situacao);
                                SqlParameter usuarioabre = new SqlParameter("@usuarioabre", TUsuario.Text);
                                insere.Parameters.Add(usuarioabre);

                                insere.ExecuteNonQuery();

                                MessageBox.Show("Caixa Aberto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Senha Inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }


                            leitor2.Close();
                        }
                    }

                    conexao.Close();
                }

                else if (RFechamento.Checked == true)
                {
                    SqlDataReader leitor, leitor2;
                    SqlCommand selecionafilme = new SqlCommand();
                    SqlConnection conexao = new SqlConnection();


                    //-------------------------------------------------------------------------------------------------
                    //-------------------------------------------------------------------------------------------------

                    conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                    conexao.Open();

                    selecionafilme = new SqlCommand("select * from caixa where datacaixa = '" + DTData.Value + "' and situacao = 'Aberto'", conexao);

                    //-------------------------------------------------------------------------------------------------
                    //-------------------------------------------------------------------------------------------------

                    leitor = selecionafilme.ExecuteReader();
                    if (leitor.Read() == false)
                    {
                        MessageBox.Show("Não existe um caixa aberto ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        leitor.Close();

                    }
                    else
                    {
                        leitor.Close();

                        SqlCommand buscasenha = new SqlCommand("select senha, classe from usuarios where loginn = '" + TUsuario.Text.ToUpper() + "'", conexao);
                        leitor2 = buscasenha.ExecuteReader();


                        if (leitor2.Read() == true)
                        {
                            if (leitor2["senha"].ToString() == TSenha.Text)
                            {
                                conexao.Close();

                                conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
                                conexao.Open();

                                SqlCommand insere = new SqlCommand("update caixa set horafecha = @horafecha, totaldia = @totaldia,diferenca = @diferenca ,situacao = @situacao, usuariofecha = @usuariofecha where datacaixa = '" + DTData.Value + "' and situacao = 'Aberto'", conexao);



                                SqlParameter horafecha = new SqlParameter("@horafecha", DTHora.Text);
                                insere.Parameters.Add(horafecha);
                                SqlParameter totaldia = new SqlParameter("@totaldia", double.Parse(TSaldo.Text));
                                insere.Parameters.Add(totaldia);
                                SqlParameter diferenca = new SqlParameter("@diferenca", double.Parse(TSaldo.Text) - total3);
                                insere.Parameters.Add(diferenca);
                                SqlParameter situacao = new SqlParameter("@situacao", "Fechado");
                                insere.Parameters.Add(situacao);
                                SqlParameter usuariofecha = new SqlParameter("@usuariofecha", TUsuario.Text);
                                insere.Parameters.Add(usuariofecha);


                                insere.ExecuteNonQuery();

                                MessageBox.Show("Caixa fechado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Senha Inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }


                            leitor2.Close();
                        }
                    }

                    conexao.Close();
                }
            }
            else
            {
                MessageBox.Show("Saldo não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
        
    
}
