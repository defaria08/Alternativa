namespace alternativa
{
    partial class movimentacaodecaixa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TDataCaixa = new System.Windows.Forms.DateTimePicker();
            this.TUSer = new System.Windows.Forms.TextBox();
            this.COperacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TValor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Ctipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TJustificativa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TLogin = new System.Windows.Forms.TextBox();
            this.TSenha = new System.Windows.Forms.TextBox();
            this.BLAncar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data do Caixa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operação";
            // 
            // TDataCaixa
            // 
            this.TDataCaixa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TDataCaixa.Location = new System.Drawing.Point(15, 25);
            this.TDataCaixa.Name = "TDataCaixa";
            this.TDataCaixa.Size = new System.Drawing.Size(107, 20);
            this.TDataCaixa.TabIndex = 3;
            // 
            // TUSer
            // 
            this.TUSer.Location = new System.Drawing.Point(128, 25);
            this.TUSer.Name = "TUSer";
            this.TUSer.Size = new System.Drawing.Size(194, 20);
            this.TUSer.TabIndex = 4;
            // 
            // COperacao
            // 
            this.COperacao.FormattingEnabled = true;
            this.COperacao.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.COperacao.Location = new System.Drawing.Point(328, 25);
            this.COperacao.Name = "COperacao";
            this.COperacao.Size = new System.Drawing.Size(121, 21);
            this.COperacao.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "R$";
            // 
            // TValor
            // 
            this.TValor.Location = new System.Drawing.Point(39, 67);
            this.TValor.Name = "TValor";
            this.TValor.Size = new System.Drawing.Size(83, 20);
            this.TValor.TabIndex = 8;
            this.TValor.Text = "0.00";
            this.TValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TValor.Leave += new System.EventHandler(this.TValor_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tipo";
            // 
            // Ctipo
            // 
            this.Ctipo.FormattingEnabled = true;
            this.Ctipo.Items.AddRange(new object[] {
            "Dinheiro",
            "Cheque"});
            this.Ctipo.Location = new System.Drawing.Point(131, 67);
            this.Ctipo.Name = "Ctipo";
            this.Ctipo.Size = new System.Drawing.Size(141, 21);
            this.Ctipo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Justificativa";
            // 
            // TJustificativa
            // 
            this.TJustificativa.Location = new System.Drawing.Point(15, 108);
            this.TJustificativa.MaxLength = 50;
            this.TJustificativa.Multiline = true;
            this.TJustificativa.Name = "TJustificativa";
            this.TJustificativa.Size = new System.Drawing.Size(434, 70);
            this.TJustificativa.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Login";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Senha";
            // 
            // TLogin
            // 
            this.TLogin.Location = new System.Drawing.Point(15, 199);
            this.TLogin.Name = "TLogin";
            this.TLogin.Size = new System.Drawing.Size(100, 20);
            this.TLogin.TabIndex = 15;
            // 
            // TSenha
            // 
            this.TSenha.Location = new System.Drawing.Point(121, 199);
            this.TSenha.Name = "TSenha";
            this.TSenha.PasswordChar = '*';
            this.TSenha.Size = new System.Drawing.Size(100, 20);
            this.TSenha.TabIndex = 16;
            // 
            // BLAncar
            // 
            this.BLAncar.Location = new System.Drawing.Point(293, 197);
            this.BLAncar.Name = "BLAncar";
            this.BLAncar.Size = new System.Drawing.Size(75, 23);
            this.BLAncar.TabIndex = 17;
            this.BLAncar.Text = "&Lançar";
            this.BLAncar.UseVisualStyleBackColor = true;
            this.BLAncar.Click += new System.EventHandler(this.BLAncar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(374, 197);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 18;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // movimentacaodecaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 228);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BLAncar);
            this.Controls.Add(this.TSenha);
            this.Controls.Add(this.TLogin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TJustificativa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ctipo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.COperacao);
            this.Controls.Add(this.TUSer);
            this.Controls.Add(this.TDataCaixa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "movimentacaodecaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada / Saída de Caixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker TDataCaixa;
        private System.Windows.Forms.TextBox TUSer;
        private System.Windows.Forms.ComboBox COperacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TValor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Ctipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TJustificativa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TLogin;
        private System.Windows.Forms.TextBox TSenha;
        private System.Windows.Forms.Button BLAncar;
        private System.Windows.Forms.Button BCancelar;
    }
}