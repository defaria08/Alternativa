namespace alternativa
{
    partial class AbreCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbreCaixa));
            this.GSituacao = new System.Windows.Forms.GroupBox();
            this.RFechamento = new System.Windows.Forms.RadioButton();
            this.RAbertura = new System.Windows.Forms.RadioButton();
            this.LData = new System.Windows.Forms.Label();
            this.DTData = new System.Windows.Forms.DateTimePicker();
            this.LHora = new System.Windows.Forms.Label();
            this.DTHora = new System.Windows.Forms.DateTimePicker();
            this.LUsuario = new System.Windows.Forms.Label();
            this.TUsuario = new System.Windows.Forms.TextBox();
            this.LSaldoInicial = new System.Windows.Forms.Label();
            this.LSenha = new System.Windows.Forms.Label();
            this.TSenha = new System.Windows.Forms.TextBox();
            this.BCancela = new System.Windows.Forms.Button();
            this.BAbFc = new System.Windows.Forms.Button();
            this.TSaldo = new System.Windows.Forms.TextBox();
            this.LRs = new System.Windows.Forms.Label();
            this.GSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // GSituacao
            // 
            this.GSituacao.Controls.Add(this.RFechamento);
            this.GSituacao.Controls.Add(this.RAbertura);
            this.GSituacao.Location = new System.Drawing.Point(12, 12);
            this.GSituacao.Name = "GSituacao";
            this.GSituacao.Size = new System.Drawing.Size(138, 74);
            this.GSituacao.TabIndex = 0;
            this.GSituacao.TabStop = false;
            this.GSituacao.Text = "Situação";
            // 
            // RFechamento
            // 
            this.RFechamento.AutoSize = true;
            this.RFechamento.Location = new System.Drawing.Point(6, 42);
            this.RFechamento.Name = "RFechamento";
            this.RFechamento.Size = new System.Drawing.Size(84, 17);
            this.RFechamento.TabIndex = 1;
            this.RFechamento.Text = "Fechamento";
            this.RFechamento.UseVisualStyleBackColor = true;
            this.RFechamento.CheckedChanged += new System.EventHandler(this.RFaturamento_CheckedChanged);
            // 
            // RAbertura
            // 
            this.RAbertura.AutoSize = true;
            this.RAbertura.Checked = true;
            this.RAbertura.Location = new System.Drawing.Point(6, 19);
            this.RAbertura.Name = "RAbertura";
            this.RAbertura.Size = new System.Drawing.Size(65, 17);
            this.RAbertura.TabIndex = 0;
            this.RAbertura.TabStop = true;
            this.RAbertura.Text = "Abertura";
            this.RAbertura.UseVisualStyleBackColor = true;
            this.RAbertura.CheckedChanged += new System.EventHandler(this.RAbertura_CheckedChanged);
            // 
            // LData
            // 
            this.LData.AutoSize = true;
            this.LData.Location = new System.Drawing.Point(168, 12);
            this.LData.Name = "LData";
            this.LData.Size = new System.Drawing.Size(30, 13);
            this.LData.TabIndex = 1;
            this.LData.Text = "Data";
            // 
            // DTData
            // 
            this.DTData.Enabled = false;
            this.DTData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTData.Location = new System.Drawing.Point(171, 28);
            this.DTData.Name = "DTData";
            this.DTData.Size = new System.Drawing.Size(95, 20);
            this.DTData.TabIndex = 2;
            // 
            // LHora
            // 
            this.LHora.AutoSize = true;
            this.LHora.Location = new System.Drawing.Point(168, 51);
            this.LHora.Name = "LHora";
            this.LHora.Size = new System.Drawing.Size(30, 13);
            this.LHora.TabIndex = 3;
            this.LHora.Text = "Hora";
            // 
            // DTHora
            // 
            this.DTHora.Enabled = false;
            this.DTHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DTHora.Location = new System.Drawing.Point(171, 66);
            this.DTHora.Name = "DTHora";
            this.DTHora.Size = new System.Drawing.Size(95, 20);
            this.DTHora.TabIndex = 4;
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(15, 139);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(43, 13);
            this.LUsuario.TabIndex = 5;
            this.LUsuario.Text = "Usuário";
            // 
            // TUsuario
            // 
            this.TUsuario.Location = new System.Drawing.Point(12, 155);
            this.TUsuario.Name = "TUsuario";
            this.TUsuario.Size = new System.Drawing.Size(138, 20);
            this.TUsuario.TabIndex = 6;
            // 
            // LSaldoInicial
            // 
            this.LSaldoInicial.AutoSize = true;
            this.LSaldoInicial.Location = new System.Drawing.Point(15, 100);
            this.LSaldoInicial.Name = "LSaldoInicial";
            this.LSaldoInicial.Size = new System.Drawing.Size(64, 13);
            this.LSaldoInicial.TabIndex = 7;
            this.LSaldoInicial.Text = "Saldo Inicial";
            // 
            // LSenha
            // 
            this.LSenha.AutoSize = true;
            this.LSenha.Location = new System.Drawing.Point(15, 178);
            this.LSenha.Name = "LSenha";
            this.LSenha.Size = new System.Drawing.Size(38, 13);
            this.LSenha.TabIndex = 9;
            this.LSenha.Text = "Senha";
            // 
            // TSenha
            // 
            this.TSenha.Location = new System.Drawing.Point(12, 194);
            this.TSenha.Name = "TSenha";
            this.TSenha.PasswordChar = '*';
            this.TSenha.Size = new System.Drawing.Size(138, 20);
            this.TSenha.TabIndex = 10;
            // 
            // BCancela
            // 
            this.BCancela.Location = new System.Drawing.Point(192, 188);
            this.BCancela.Name = "BCancela";
            this.BCancela.Size = new System.Drawing.Size(75, 23);
            this.BCancela.TabIndex = 11;
            this.BCancela.Text = "&Cancelar";
            this.BCancela.UseVisualStyleBackColor = true;
            this.BCancela.Click += new System.EventHandler(this.BCancela_Click);
            // 
            // BAbFc
            // 
            this.BAbFc.Location = new System.Drawing.Point(191, 159);
            this.BAbFc.Name = "BAbFc";
            this.BAbFc.Size = new System.Drawing.Size(75, 23);
            this.BAbFc.TabIndex = 13;
            this.BAbFc.Text = "&Abrir";
            this.BAbFc.UseVisualStyleBackColor = true;
            this.BAbFc.Click += new System.EventHandler(this.BAbFc_Click);
            // 
            // TSaldo
            // 
            this.TSaldo.Location = new System.Drawing.Point(46, 116);
            this.TSaldo.Name = "TSaldo";
            this.TSaldo.Size = new System.Drawing.Size(104, 20);
            this.TSaldo.TabIndex = 14;
            this.TSaldo.Text = "0,00";
            this.TSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LRs
            // 
            this.LRs.AutoSize = true;
            this.LRs.Location = new System.Drawing.Point(15, 119);
            this.LRs.Name = "LRs";
            this.LRs.Size = new System.Drawing.Size(21, 13);
            this.LRs.TabIndex = 15;
            this.LRs.Text = "R$";
            // 
            // AbreCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 223);
            this.Controls.Add(this.LRs);
            this.Controls.Add(this.TSaldo);
            this.Controls.Add(this.BAbFc);
            this.Controls.Add(this.BCancela);
            this.Controls.Add(this.TSenha);
            this.Controls.Add(this.LSenha);
            this.Controls.Add(this.LSaldoInicial);
            this.Controls.Add(this.TUsuario);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.DTHora);
            this.Controls.Add(this.LHora);
            this.Controls.Add(this.DTData);
            this.Controls.Add(this.LData);
            this.Controls.Add(this.GSituacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AbreCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abertura / Fechamento de Caixa";
            this.GSituacao.ResumeLayout(false);
            this.GSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GSituacao;
        private System.Windows.Forms.RadioButton RFechamento;
        private System.Windows.Forms.RadioButton RAbertura;
        private System.Windows.Forms.Label LData;
        private System.Windows.Forms.DateTimePicker DTData;
        private System.Windows.Forms.Label LHora;
        private System.Windows.Forms.DateTimePicker DTHora;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.TextBox TUsuario;
        private System.Windows.Forms.Label LSaldoInicial;
        private System.Windows.Forms.Label LSenha;
        private System.Windows.Forms.TextBox TSenha;
        private System.Windows.Forms.Button BCancela;
        private System.Windows.Forms.Button BAbFc;
        private System.Windows.Forms.TextBox TSaldo;
        private System.Windows.Forms.Label LRs;
    }
}