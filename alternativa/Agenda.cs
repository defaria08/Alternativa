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
    public partial class Agenda : Form
    {
        string data;
        int cheio = 0;
        public Agenda(DateTime data)
        {

            this.data = data.ToShortDateString();
            InitializeComponent();
            DTEntrada.Value = Convert.ToDateTime(this.data);
            busca();
            contaagenda();
            controle();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            contaagenda();
            verletra();
            SqlConnection conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            SqlCommand comandodeinsercao = new SqlCommand("Insert into AGENDA (CLIENTE,VEICULO,DATAE,HORARIO,OCUPACAO,CONTATO,SERVICO)" +
                                                            "values" +
                                                            "(@CLIENTE,@VEICULO,@DATAE,@HORA,@OCUPACAO,@CONTATO,@SERVICO)", conexao);


            SqlParameter CLIENTE = new SqlParameter("@CLIENTE", TNome.Text);
            comandodeinsercao.Parameters.Add(CLIENTE);
            SqlParameter VEICULO = new SqlParameter("@VEICULO", TVeiculo.Text);
            comandodeinsercao.Parameters.Add(VEICULO);
            SqlParameter DATAE = new SqlParameter("@DATAE", DTEntrada.Text);
            comandodeinsercao.Parameters.Add(DATAE);
            SqlParameter HORA = new SqlParameter("@HORA", CHora.Text);
            comandodeinsercao.Parameters.Add(HORA);
            SqlParameter OCUPACAO = new SqlParameter("@OCUPACAO", int.Parse(COcupacao.Text));
            comandodeinsercao.Parameters.Add(OCUPACAO);
            SqlParameter CONTATO = new SqlParameter("@CONTATO", MContato.Text);
            comandodeinsercao.Parameters.Add(CONTATO);
            SqlParameter SERVICO = new SqlParameter("@SERVICO", TServico.Text);
            comandodeinsercao.Parameters.Add(SERVICO);

            if (cheio >= 12)
            {
                if (MessageBox.Show("Agenda do Dia Cheia. \nTem certeza que deseja salvar novo agendamento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    comandodeinsercao.ExecuteNonQuery();

                    MessageBox.Show("Agendamento ok", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conexao.Close();
                    limpacampos();
                    busca();
                    contaagenda();
                    controle();
                }
                else
                {
                    MessageBox.Show("Agendamento Cancelado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                comandodeinsercao.ExecuteNonQuery();

                MessageBox.Show("Agendamento ok", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conexao.Close();
                limpacampos();
                busca();
                contaagenda();
                controle();
            }

        }

        public void limpacampos()
        {
            TNome.Text = "";
            TVeiculo.Text = "";
            CHora.Text = "";
            MContato.Text = "";
            TServico.Text = "";
        }

        private void Bcancelar_Click(object sender, EventArgs e)
        {
            busca();
            this.Close();
        }

        private void BBusca_Click(object sender, EventArgs e)
        {
            busca();
        }

        public void busca()
        {
            DateTime hoje = DateTime.Now;
            SqlDataReader leitor;
            string NOM, VEI, OCUP;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();



            LVisualizar.Items.Clear();
            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            if (TNomeBusca.Text == "")
            {
                selecionafilme = new SqlCommand("select CLIENTE as NOM,VEICULO as VEI,OCUPACAO as OCUP from AGENDA where DATAE ='" + DTEntrada.Value.ToShortDateString() + "'", conexao);
            }
            else
            {
                selecionafilme = new SqlCommand("select CLIENTE as NOM,VEICULO as VEI,OCUPACAO as OCUP from AGENDA where CLIENTE LIKE '%" + TNomeBusca.Text + "%'AND DATAE >= '" + hoje.ToShortDateString() + "'", conexao);
            }

            leitor = selecionafilme.ExecuteReader();

            if (TNomeBusca.Text != "")
            {
                if (leitor.Read() == false)
                {
                    MessageBox.Show("Não Existem Agendamento", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            leitor.Close();
            leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                NOM = leitor["NOM"].ToString();
                VEI = leitor["VEI"].ToString();
                OCUP = leitor["OCUP"].ToString();



                ListViewItem itemLista = new ListViewItem(NOM);
                ListViewItem.ListViewSubItem subitemLista = new ListViewItem.ListViewSubItem(itemLista, VEI);
                itemLista.SubItems.Add(subitemLista);
                subitemLista = new ListViewItem.ListViewSubItem(itemLista, OCUP);
                itemLista.SubItems.Add(subitemLista);

                LVisualizar.Items.Add(itemLista);

            }


            leitor.Close();
            conexao.Close();
        }



        private void BVer_Click(object sender, EventArgs e)
        {

            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();




            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();


            if (LVisualizar.SelectedItems.Count != 0)
            {
                selecionafilme = new SqlCommand("select CLIENTE as NOM,VEICULO as VEI,DATAE AS DT, HORARIO AS HORA,OCUPACAO as OCUP,CONTATO AS CONT, SERVICO AS SERV from AGENDA where CLIENTE = '" + LVisualizar.SelectedItems[0].Text + "' and datae = '"+ DTEntrada.Value +"'", conexao);


                leitor = selecionafilme.ExecuteReader();



                leitor.Close();
                leitor = selecionafilme.ExecuteReader();
                while (leitor.Read() == true)
                {
                    TNome.Text = leitor["NOM"].ToString();
                    TVeiculo.Text = leitor["VEI"].ToString();
                    DTEntrada.Text = leitor["DT"].ToString();
                    CHora.Text = leitor["HORA"].ToString();
                    COcupacao.Text = leitor["OCUP"].ToString();
                    MContato.Text = leitor["CONT"].ToString();
                    TServico.Text = leitor["SERV"].ToString();




                }


                leitor.Close();

            }
            else
            {
                MessageBox.Show("Selecione para prosseguir", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            conexao.Close();
        }

        private void DTEntrada_Leave(object sender, EventArgs e)
        {
            busca();
            contaagenda();
            controle();
        }
        public void contaagenda()
        {
            cheio = 0;
            SqlDataReader leitor;
            SqlCommand selecionafilme = new SqlCommand();
            SqlConnection conexao = new SqlConnection();




            conexao = new SqlConnection("Data Source = DESKTOP-L0FTKI7; Initial Catalog = ALTERNATIVA; Integrated Security=SSPI");
            conexao.Open();

            selecionafilme = new SqlCommand("select sum(OCUPACAO) as vl from AGENDA where DATAE ='" + DTEntrada.Value.ToShortDateString() + "'", conexao);


            
            leitor = selecionafilme.ExecuteReader();
            while (leitor.Read() == true)
            {
                if(leitor["vl"].ToString()!= "")
                { 
                    cheio = int.Parse(leitor["vl"].ToString());

                }
            }
            

            leitor.Close();
            conexao.Close();
        }
        void controle()
        {
            if((cheio >= 0) && (cheio <= 6))
            {
                panelcontrole.BackColor = Color.Green; 
            }
            else if((cheio > 6) && (cheio <12))
            {
                panelcontrole.BackColor = Color.Yellow;
            }
            else
            {
                panelcontrole.BackColor = Color.Red;
            }
            
        }

        private void BRemover_Click(object sender, EventArgs e)
        {
            
        }

        private void COcupacao_Leave(object sender, EventArgs e)
        {
            verletra();
        }
        public void verletra()
        {
            int lt = 0;
            foreach (var letra in COcupacao.Text)
            {
                if (char.IsLetter(letra) == true)
                {
                    lt = 1;
                }
            }
            if (lt == 1)
            {
                MessageBox.Show("Ocupação não pode conter letras", "Alternativa Motos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                COcupacao.Text = "0";
            }

        }
    }
}