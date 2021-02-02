namespace alternativa
{
    partial class Agenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            this.BBusca = new System.Windows.Forms.Button();
            this.Bcancelar = new System.Windows.Forms.Button();
            this.LVisualizar = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Veiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ocupacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LHora = new System.Windows.Forms.Label();
            this.TNomeBusca = new System.Windows.Forms.TextBox();
            this.TNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TVeiculo = new System.Windows.Forms.TextBox();
            this.TServico = new System.Windows.Forms.TextBox();
            this.CHora = new System.Windows.Forms.ComboBox();
            this.BGravar = new System.Windows.Forms.Button();
            this.MContato = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BRemover = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DTEntrada = new System.Windows.Forms.DateTimePicker();
            this.BVer = new System.Windows.Forms.Button();
            this.panelcontrole = new System.Windows.Forms.Panel();
            this.LOcupacao = new System.Windows.Forms.Label();
            this.COcupacao = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BBusca
            // 
            this.BBusca.Location = new System.Drawing.Point(12, 29);
            this.BBusca.Name = "BBusca";
            this.BBusca.Size = new System.Drawing.Size(75, 23);
            this.BBusca.TabIndex = 0;
            this.BBusca.Text = "Buscar";
            this.BBusca.UseVisualStyleBackColor = true;
            this.BBusca.Click += new System.EventHandler(this.BBusca_Click);
            // 
            // Bcancelar
            // 
            this.Bcancelar.Location = new System.Drawing.Point(93, 29);
            this.Bcancelar.Name = "Bcancelar";
            this.Bcancelar.Size = new System.Drawing.Size(75, 23);
            this.Bcancelar.TabIndex = 1;
            this.Bcancelar.Text = "Cancelar";
            this.Bcancelar.UseVisualStyleBackColor = true;
            this.Bcancelar.Click += new System.EventHandler(this.Bcancelar_Click);
            // 
            // LVisualizar
            // 
            this.LVisualizar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.Veiculo,
            this.Ocupacao});
            this.LVisualizar.FullRowSelect = true;
            this.LVisualizar.Location = new System.Drawing.Point(15, 287);
            this.LVisualizar.Name = "LVisualizar";
            this.LVisualizar.Size = new System.Drawing.Size(409, 122);
            this.LVisualizar.TabIndex = 2;
            this.LVisualizar.UseCompatibleStateImageBehavior = false;
            this.LVisualizar.View = System.Windows.Forms.View.Details;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 132;
            // 
            // Veiculo
            // 
            this.Veiculo.Text = "Veículo";
            this.Veiculo.Width = 205;
            // 
            // Ocupacao
            // 
            this.Ocupacao.Text = "Ocupação";
            this.Ocupacao.Width = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Veículo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Serviço";
            // 
            // LHora
            // 
            this.LHora.AutoSize = true;
            this.LHora.Location = new System.Drawing.Point(112, 104);
            this.LHora.Name = "LHora";
            this.LHora.Size = new System.Drawing.Size(41, 13);
            this.LHora.TabIndex = 7;
            this.LHora.Text = "Horário";
            // 
            // TNomeBusca
            // 
            this.TNomeBusca.Location = new System.Drawing.Point(215, 31);
            this.TNomeBusca.MaxLength = 50;
            this.TNomeBusca.Name = "TNomeBusca";
            this.TNomeBusca.Size = new System.Drawing.Size(206, 20);
            this.TNomeBusca.TabIndex = 8;
            // 
            // TNome
            // 
            this.TNome.Location = new System.Drawing.Point(12, 81);
            this.TNome.MaxLength = 50;
            this.TNome.Name = "TNome";
            this.TNome.Size = new System.Drawing.Size(242, 20);
            this.TNome.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data de Entrada";
            // 
            // TVeiculo
            // 
            this.TVeiculo.Location = new System.Drawing.Point(260, 81);
            this.TVeiculo.MaxLength = 50;
            this.TVeiculo.Name = "TVeiculo";
            this.TVeiculo.Size = new System.Drawing.Size(161, 20);
            this.TVeiculo.TabIndex = 11;
            // 
            // TServico
            // 
            this.TServico.Location = new System.Drawing.Point(12, 162);
            this.TServico.MaxLength = 300;
            this.TServico.Multiline = true;
            this.TServico.Name = "TServico";
            this.TServico.Size = new System.Drawing.Size(409, 90);
            this.TServico.TabIndex = 12;
            // 
            // CHora
            // 
            this.CHora.FormattingEnabled = true;
            this.CHora.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30"});
            this.CHora.Location = new System.Drawing.Point(115, 119);
            this.CHora.Name = "CHora";
            this.CHora.Size = new System.Drawing.Size(76, 21);
            this.CHora.TabIndex = 14;
            // 
            // BGravar
            // 
            this.BGravar.Location = new System.Drawing.Point(299, 258);
            this.BGravar.Name = "BGravar";
            this.BGravar.Size = new System.Drawing.Size(58, 23);
            this.BGravar.TabIndex = 15;
            this.BGravar.Text = "&Gravar";
            this.BGravar.UseVisualStyleBackColor = true;
            this.BGravar.Click += new System.EventHandler(this.button3_Click);
            // 
            // MContato
            // 
            this.MContato.Location = new System.Drawing.Point(286, 120);
            this.MContato.Mask = "(99) 00000-0000";
            this.MContato.Name = "MContato";
            this.MContato.Size = new System.Drawing.Size(134, 20);
            this.MContato.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Contato";
            // 
            // BRemover
            // 
            this.BRemover.Location = new System.Drawing.Point(363, 258);
            this.BRemover.Name = "BRemover";
            this.BRemover.Size = new System.Drawing.Size(58, 23);
            this.BRemover.TabIndex = 18;
            this.BRemover.Text = "&Remover";
            this.BRemover.UseVisualStyleBackColor = true;
            this.BRemover.Click += new System.EventHandler(this.BRemover_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 1);
            this.panel1.TabIndex = 19;
            // 
            // DTEntrada
            // 
            this.DTEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTEntrada.Location = new System.Drawing.Point(12, 120);
            this.DTEntrada.Name = "DTEntrada";
            this.DTEntrada.Size = new System.Drawing.Size(97, 20);
            this.DTEntrada.TabIndex = 13;
            this.DTEntrada.Value = new System.DateTime(2019, 2, 19, 0, 0, 0, 0);
            this.DTEntrada.Leave += new System.EventHandler(this.DTEntrada_Leave);
            // 
            // BVer
            // 
            this.BVer.Location = new System.Drawing.Point(365, 415);
            this.BVer.Name = "BVer";
            this.BVer.Size = new System.Drawing.Size(58, 23);
            this.BVer.TabIndex = 20;
            this.BVer.Text = "Ver";
            this.BVer.UseVisualStyleBackColor = true;
            this.BVer.Click += new System.EventHandler(this.BVer_Click);
            // 
            // panelcontrole
            // 
            this.panelcontrole.BackColor = System.Drawing.Color.Green;
            this.panelcontrole.Location = new System.Drawing.Point(12, 10);
            this.panelcontrole.Name = "panelcontrole";
            this.panelcontrole.Size = new System.Drawing.Size(408, 10);
            this.panelcontrole.TabIndex = 21;
            // 
            // LOcupacao
            // 
            this.LOcupacao.AutoSize = true;
            this.LOcupacao.Location = new System.Drawing.Point(194, 103);
            this.LOcupacao.Name = "LOcupacao";
            this.LOcupacao.Size = new System.Drawing.Size(57, 13);
            this.LOcupacao.TabIndex = 22;
            this.LOcupacao.Text = "Ocupação";
            // 
            // COcupacao
            // 
            this.COcupacao.FormattingEnabled = true;
            this.COcupacao.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.COcupacao.Location = new System.Drawing.Point(197, 119);
            this.COcupacao.Name = "COcupacao";
            this.COcupacao.Size = new System.Drawing.Size(83, 21);
            this.COcupacao.TabIndex = 23;
            this.COcupacao.Leave += new System.EventHandler(this.COcupacao_Leave);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 441);
            this.Controls.Add(this.COcupacao);
            this.Controls.Add(this.LOcupacao);
            this.Controls.Add(this.panelcontrole);
            this.Controls.Add(this.BVer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BRemover);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MContato);
            this.Controls.Add(this.BGravar);
            this.Controls.Add(this.CHora);
            this.Controls.Add(this.DTEntrada);
            this.Controls.Add(this.TServico);
            this.Controls.Add(this.TVeiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TNome);
            this.Controls.Add(this.TNomeBusca);
            this.Controls.Add(this.LHora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LVisualizar);
            this.Controls.Add(this.Bcancelar);
            this.Controls.Add(this.BBusca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBusca;
        private System.Windows.Forms.Button Bcancelar;
        private System.Windows.Forms.ListView LVisualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LHora;
        private System.Windows.Forms.TextBox TNomeBusca;
        private System.Windows.Forms.TextBox TNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader Veiculo;
        private System.Windows.Forms.ColumnHeader Ocupacao;
        private System.Windows.Forms.TextBox TVeiculo;
        private System.Windows.Forms.TextBox TServico;
        private System.Windows.Forms.ComboBox CHora;
        private System.Windows.Forms.Button BGravar;
        private System.Windows.Forms.MaskedTextBox MContato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BRemover;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DTEntrada;
        private System.Windows.Forms.Button BVer;
        private System.Windows.Forms.Panel panelcontrole;
        private System.Windows.Forms.Label LOcupacao;
        private System.Windows.Forms.ComboBox COcupacao;
    }
}