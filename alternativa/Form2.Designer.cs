namespace alternativa
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.TNomeFan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tend = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TComple = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MCEP = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Tcidade = new System.Windows.Forms.TextBox();
            this.CEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.MCelular = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TEmail = new System.Windows.Forms.TextBox();
            this.CheckVincula = new System.Windows.Forms.CheckBox();
            this.BGravar = new System.Windows.Forms.Button();
            this.BCancela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNomeFan
            // 
            this.TNomeFan.Location = new System.Drawing.Point(15, 25);
            this.TNomeFan.MaxLength = 50;
            this.TNomeFan.Name = "TNomeFan";
            this.TNomeFan.Size = new System.Drawing.Size(410, 20);
            this.TNomeFan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Fantasia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereço";
            // 
            // Tend
            // 
            this.Tend.Location = new System.Drawing.Point(15, 66);
            this.Tend.MaxLength = 50;
            this.Tend.Name = "Tend";
            this.Tend.Size = new System.Drawing.Size(326, 20);
            this.Tend.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número";
            // 
            // Tnum
            // 
            this.Tnum.Location = new System.Drawing.Point(347, 66);
            this.Tnum.MaxLength = 0;
            this.Tnum.Name = "Tnum";
            this.Tnum.Size = new System.Drawing.Size(78, 20);
            this.Tnum.TabIndex = 5;
            this.Tnum.Leave += new System.EventHandler(this.Tnum_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Complemento";
            // 
            // TComple
            // 
            this.TComple.Location = new System.Drawing.Point(15, 107);
            this.TComple.MaxLength = 40;
            this.TComple.Name = "TComple";
            this.TComple.Size = new System.Drawing.Size(116, 20);
            this.TComple.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bairro";
            // 
            // TBairro
            // 
            this.TBairro.Location = new System.Drawing.Point(139, 107);
            this.TBairro.MaxLength = 20;
            this.TBairro.Name = "TBairro";
            this.TBairro.Size = new System.Drawing.Size(161, 20);
            this.TBairro.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CEP";
            // 
            // MCEP
            // 
            this.MCEP.Location = new System.Drawing.Point(306, 107);
            this.MCEP.Mask = "99999-999";
            this.MCEP.Name = "MCEP";
            this.MCEP.Size = new System.Drawing.Size(119, 20);
            this.MCEP.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cidade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(260, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Estado";
            // 
            // Tcidade
            // 
            this.Tcidade.Location = new System.Drawing.Point(15, 148);
            this.Tcidade.MaxLength = 40;
            this.Tcidade.Name = "Tcidade";
            this.Tcidade.Size = new System.Drawing.Size(242, 20);
            this.Tcidade.TabIndex = 14;
            // 
            // CEstado
            // 
            this.CEstado.FormattingEnabled = true;
            this.CEstado.Location = new System.Drawing.Point(263, 147);
            this.CEstado.MaxLength = 30;
            this.CEstado.Name = "CEstado";
            this.CEstado.Size = new System.Drawing.Size(162, 21);
            this.CEstado.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Telefone";
            // 
            // MTelefone
            // 
            this.MTelefone.Location = new System.Drawing.Point(15, 189);
            this.MTelefone.Mask = "(99) 9999-9999";
            this.MTelefone.Name = "MTelefone";
            this.MTelefone.Size = new System.Drawing.Size(119, 20);
            this.MTelefone.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(137, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Celular";
            // 
            // MCelular
            // 
            this.MCelular.Location = new System.Drawing.Point(140, 189);
            this.MCelular.Mask = "(99) 9999-99999";
            this.MCelular.Name = "MCelular";
            this.MCelular.Size = new System.Drawing.Size(119, 20);
            this.MCelular.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "E-mail";
            // 
            // TEmail
            // 
            this.TEmail.Location = new System.Drawing.Point(20, 230);
            this.TEmail.MaxLength = 50;
            this.TEmail.Name = "TEmail";
            this.TEmail.Size = new System.Drawing.Size(242, 20);
            this.TEmail.TabIndex = 21;
            // 
            // CheckVincula
            // 
            this.CheckVincula.AutoSize = true;
            this.CheckVincula.Location = new System.Drawing.Point(20, 259);
            this.CheckVincula.Name = "CheckVincula";
            this.CheckVincula.Size = new System.Drawing.Size(163, 17);
            this.CheckVincula.TabIndex = 22;
            this.CheckVincula.Text = "Vincular dados em Relatórios";
            this.CheckVincula.UseVisualStyleBackColor = true;
            // 
            // BGravar
            // 
            this.BGravar.Location = new System.Drawing.Point(347, 198);
            this.BGravar.Name = "BGravar";
            this.BGravar.Size = new System.Drawing.Size(75, 23);
            this.BGravar.TabIndex = 23;
            this.BGravar.Text = "&Gravar";
            this.BGravar.UseVisualStyleBackColor = true;
            this.BGravar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BCancela
            // 
            this.BCancela.Location = new System.Drawing.Point(347, 227);
            this.BCancela.Name = "BCancela";
            this.BCancela.Size = new System.Drawing.Size(75, 23);
            this.BCancela.TabIndex = 24;
            this.BCancela.Text = "&Cancelar";
            this.BCancela.UseVisualStyleBackColor = true;
            this.BCancela.Click += new System.EventHandler(this.BCancela_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 288);
            this.Controls.Add(this.BCancela);
            this.Controls.Add(this.BGravar);
            this.Controls.Add(this.CheckVincula);
            this.Controls.Add(this.TEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.MCelular);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.MTelefone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CEstado);
            this.Controls.Add(this.Tcidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MCEP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TBairro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TComple);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TNomeFan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados da Empresa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNomeFan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TComple;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox MCEP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tcidade;
        private System.Windows.Forms.ComboBox CEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox MTelefone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox MCelular;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TEmail;
        private System.Windows.Forms.CheckBox CheckVincula;
        private System.Windows.Forms.Button BGravar;
        private System.Windows.Forms.Button BCancela;
    }
}