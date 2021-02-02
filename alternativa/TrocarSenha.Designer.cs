namespace alternativa
{
    partial class TrocarSenha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrocarSenha));
            this.LCodigo = new System.Windows.Forms.Label();
            this.LLoginBusca = new System.Windows.Forms.Label();
            this.LLogin = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BResetar = new System.Windows.Forms.Button();
            this.BAlterar = new System.Windows.Forms.Button();
            this.BBuscar = new System.Windows.Forms.Button();
            this.TCodigo = new System.Windows.Forms.TextBox();
            this.TNome = new System.Windows.Forms.TextBox();
            this.TLogin = new System.Windows.Forms.TextBox();
            this.TNomecompleto = new System.Windows.Forms.TextBox();
            this.TSenhaAtual = new System.Windows.Forms.TextBox();
            this.TNovaSenha = new System.Windows.Forms.TextBox();
            this.TConfirmaSenha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // LCodigo
            // 
            this.LCodigo.AutoSize = true;
            this.LCodigo.Location = new System.Drawing.Point(12, 9);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(40, 13);
            this.LCodigo.TabIndex = 0;
            this.LCodigo.Text = "Código";
            // 
            // LLoginBusca
            // 
            this.LLoginBusca.AutoSize = true;
            this.LLoginBusca.Location = new System.Drawing.Point(87, 9);
            this.LLoginBusca.Name = "LLoginBusca";
            this.LLoginBusca.Size = new System.Drawing.Size(33, 13);
            this.LLoginBusca.TabIndex = 3;
            this.LLoginBusca.Text = "Login";
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Location = new System.Drawing.Point(12, 70);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(33, 13);
            this.LLogin.TabIndex = 18;
            this.LLogin.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome Completo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Senha Antiga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(266, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Confirmar Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nova Senha";
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(315, 152);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 17;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BResetar
            // 
            this.BResetar.Location = new System.Drawing.Point(234, 152);
            this.BResetar.Name = "BResetar";
            this.BResetar.Size = new System.Drawing.Size(75, 23);
            this.BResetar.TabIndex = 16;
            this.BResetar.Text = "&Resetar";
            this.BResetar.UseVisualStyleBackColor = true;
            this.BResetar.Click += new System.EventHandler(this.BResetar_Click);
            // 
            // BAlterar
            // 
            this.BAlterar.Location = new System.Drawing.Point(153, 152);
            this.BAlterar.Name = "BAlterar";
            this.BAlterar.Size = new System.Drawing.Size(75, 23);
            this.BAlterar.TabIndex = 15;
            this.BAlterar.Text = "&Alterar";
            this.BAlterar.UseVisualStyleBackColor = true;
            this.BAlterar.Click += new System.EventHandler(this.BAlterar_Click);
            // 
            // BBuscar
            // 
            this.BBuscar.Location = new System.Drawing.Point(315, 22);
            this.BBuscar.Name = "BBuscar";
            this.BBuscar.Size = new System.Drawing.Size(75, 23);
            this.BBuscar.TabIndex = 4;
            this.BBuscar.Text = "&Buscar";
            this.BBuscar.UseVisualStyleBackColor = true;
            this.BBuscar.Click += new System.EventHandler(this.BBuscar_Click);
            // 
            // TCodigo
            // 
            this.TCodigo.Location = new System.Drawing.Point(15, 25);
            this.TCodigo.MaxLength = 5;
            this.TCodigo.Name = "TCodigo";
            this.TCodigo.Size = new System.Drawing.Size(66, 20);
            this.TCodigo.TabIndex = 1;
            // 
            // TNome
            // 
            this.TNome.Location = new System.Drawing.Point(87, 25);
            this.TNome.MaxLength = 30;
            this.TNome.Name = "TNome";
            this.TNome.Size = new System.Drawing.Size(214, 20);
            this.TNome.TabIndex = 2;
            this.TNome.TextChanged += new System.EventHandler(this.TNome_TextChanged);
            // 
            // TLogin
            // 
            this.TLogin.Location = new System.Drawing.Point(15, 86);
            this.TLogin.MaxLength = 30;
            this.TLogin.Name = "TLogin";
            this.TLogin.Size = new System.Drawing.Size(151, 20);
            this.TLogin.TabIndex = 6;
            // 
            // TNomecompleto
            // 
            this.TNomecompleto.Location = new System.Drawing.Point(172, 86);
            this.TNomecompleto.MaxLength = 30;
            this.TNomecompleto.Name = "TNomecompleto";
            this.TNomecompleto.Size = new System.Drawing.Size(218, 20);
            this.TNomecompleto.TabIndex = 8;
            // 
            // TSenhaAtual
            // 
            this.TSenhaAtual.Location = new System.Drawing.Point(15, 128);
            this.TSenhaAtual.MaxLength = 30;
            this.TSenhaAtual.Name = "TSenhaAtual";
            this.TSenhaAtual.PasswordChar = '*';
            this.TSenhaAtual.Size = new System.Drawing.Size(121, 20);
            this.TSenhaAtual.TabIndex = 10;
            this.TSenhaAtual.TextChanged += new System.EventHandler(this.TSenhaAtual_TextChanged);
            // 
            // TNovaSenha
            // 
            this.TNovaSenha.Location = new System.Drawing.Point(142, 128);
            this.TNovaSenha.MaxLength = 30;
            this.TNovaSenha.Name = "TNovaSenha";
            this.TNovaSenha.PasswordChar = '*';
            this.TNovaSenha.Size = new System.Drawing.Size(121, 20);
            this.TNovaSenha.TabIndex = 12;
            // 
            // TConfirmaSenha
            // 
            this.TConfirmaSenha.Location = new System.Drawing.Point(269, 128);
            this.TConfirmaSenha.MaxLength = 30;
            this.TConfirmaSenha.Name = "TConfirmaSenha";
            this.TConfirmaSenha.PasswordChar = '*';
            this.TConfirmaSenha.Size = new System.Drawing.Size(121, 20);
            this.TConfirmaSenha.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(15, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 1);
            this.panel1.TabIndex = 5;
            // 
            // TrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 183);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TConfirmaSenha);
            this.Controls.Add(this.TNovaSenha);
            this.Controls.Add(this.TSenhaAtual);
            this.Controls.Add(this.TNomecompleto);
            this.Controls.Add(this.TLogin);
            this.Controls.Add(this.TNome);
            this.Controls.Add(this.TCodigo);
            this.Controls.Add(this.BBuscar);
            this.Controls.Add(this.BAlterar);
            this.Controls.Add(this.BResetar);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LLogin);
            this.Controls.Add(this.LLoginBusca);
            this.Controls.Add(this.LCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrocarSenha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trocar Senha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.Label LLoginBusca;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BResetar;
        private System.Windows.Forms.Button BAlterar;
        private System.Windows.Forms.Button BBuscar;
        private System.Windows.Forms.TextBox TCodigo;
        private System.Windows.Forms.TextBox TNome;
        private System.Windows.Forms.TextBox TLogin;
        private System.Windows.Forms.TextBox TNomecompleto;
        private System.Windows.Forms.TextBox TSenhaAtual;
        private System.Windows.Forms.TextBox TNovaSenha;
        private System.Windows.Forms.TextBox TConfirmaSenha;
        private System.Windows.Forms.Panel panel1;
    }
}