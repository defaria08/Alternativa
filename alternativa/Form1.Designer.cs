namespace alternativa
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BEntrar = new System.Windows.Forms.Button();
            this.BSair = new System.Windows.Forms.Button();
            this.LLogin = new System.Windows.Forms.Label();
            this.LSenha = new System.Windows.Forms.Label();
            this.TLogin = new System.Windows.Forms.TextBox();
            this.TSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BEntrar
            // 
            this.BEntrar.Location = new System.Drawing.Point(37, 222);
            this.BEntrar.Name = "BEntrar";
            this.BEntrar.Size = new System.Drawing.Size(75, 23);
            this.BEntrar.TabIndex = 4;
            this.BEntrar.Text = "&Entrar";
            this.BEntrar.UseVisualStyleBackColor = true;
            this.BEntrar.Click += new System.EventHandler(this.BEntrar_Click);
            // 
            // BSair
            // 
            this.BSair.Location = new System.Drawing.Point(118, 222);
            this.BSair.Name = "BSair";
            this.BSair.Size = new System.Drawing.Size(75, 23);
            this.BSair.TabIndex = 5;
            this.BSair.Text = "&Sair";
            this.BSair.UseVisualStyleBackColor = true;
            this.BSair.Click += new System.EventHandler(this.BSair_Click);
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Location = new System.Drawing.Point(30, 127);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(33, 13);
            this.LLogin.TabIndex = 0;
            this.LLogin.Text = "Login";
            // 
            // LSenha
            // 
            this.LSenha.AutoSize = true;
            this.LSenha.Location = new System.Drawing.Point(30, 171);
            this.LSenha.Name = "LSenha";
            this.LSenha.Size = new System.Drawing.Size(38, 13);
            this.LSenha.TabIndex = 2;
            this.LSenha.Text = "Senha";
            // 
            // TLogin
            // 
            this.TLogin.Location = new System.Drawing.Point(33, 143);
            this.TLogin.MaxLength = 13;
            this.TLogin.Name = "TLogin";
            this.TLogin.Size = new System.Drawing.Size(165, 20);
            this.TLogin.TabIndex = 1;
            // 
            // TSenha
            // 
            this.TSenha.Location = new System.Drawing.Point(33, 187);
            this.TSenha.Name = "TSenha";
            this.TSenha.PasswordChar = '*';
            this.TSenha.Size = new System.Drawing.Size(165, 20);
            this.TSenha.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::alternativa.Properties.Resources.moto;
            this.pictureBox1.Location = new System.Drawing.Point(46, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(69, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login ou senha Inválido";
            this.label1.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(233, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TSenha);
            this.Controls.Add(this.TLogin);
            this.Controls.Add(this.LSenha);
            this.Controls.Add(this.LLogin);
            this.Controls.Add(this.BSair);
            this.Controls.Add(this.BEntrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BEntrar;
        private System.Windows.Forms.Button BSair;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.Label LSenha;
        private System.Windows.Forms.TextBox TLogin;
        private System.Windows.Forms.TextBox TSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

