namespace alternativa
{
    partial class BuscaUserCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaUserCli));
            this.LCódigo = new System.Windows.Forms.Label();
            this.LNome = new System.Windows.Forms.Label();
            this.LCPF = new System.Windows.Forms.Label();
            this.TCodigo = new System.Windows.Forms.TextBox();
            this.TNome = new System.Windows.Forms.TextBox();
            this.BBuca = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BBloquear = new System.Windows.Forms.Button();
            this.MCPF = new System.Windows.Forms.MaskedTextBox();
            this.LListadeUserCli = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Situacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // LCódigo
            // 
            this.LCódigo.AutoSize = true;
            this.LCódigo.Location = new System.Drawing.Point(12, 9);
            this.LCódigo.Name = "LCódigo";
            this.LCódigo.Size = new System.Drawing.Size(40, 13);
            this.LCódigo.TabIndex = 0;
            this.LCódigo.Text = "Código";
            // 
            // LNome
            // 
            this.LNome.AutoSize = true;
            this.LNome.Location = new System.Drawing.Point(100, 9);
            this.LNome.Name = "LNome";
            this.LNome.Size = new System.Drawing.Size(35, 13);
            this.LNome.TabIndex = 2;
            this.LNome.Text = "Nome";
            // 
            // LCPF
            // 
            this.LCPF.AutoSize = true;
            this.LCPF.Location = new System.Drawing.Point(361, 9);
            this.LCPF.Name = "LCPF";
            this.LCPF.Size = new System.Drawing.Size(27, 13);
            this.LCPF.TabIndex = 4;
            this.LCPF.Text = "CPF";
            // 
            // TCodigo
            // 
            this.TCodigo.Location = new System.Drawing.Point(15, 25);
            this.TCodigo.Name = "TCodigo";
            this.TCodigo.Size = new System.Drawing.Size(82, 20);
            this.TCodigo.TabIndex = 1;
            this.TCodigo.Leave += new System.EventHandler(this.TCodigo_Leave);
            // 
            // TNome
            // 
            this.TNome.Location = new System.Drawing.Point(103, 25);
            this.TNome.Name = "TNome";
            this.TNome.Size = new System.Drawing.Size(255, 20);
            this.TNome.TabIndex = 3;
            // 
            // BBuca
            // 
            this.BBuca.Location = new System.Drawing.Point(522, 25);
            this.BBuca.Name = "BBuca";
            this.BBuca.Size = new System.Drawing.Size(75, 23);
            this.BBuca.TabIndex = 7;
            this.BBuca.Text = "&Buscar";
            this.BBuca.UseVisualStyleBackColor = true;
            this.BBuca.Click += new System.EventHandler(this.BBuca_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(522, 54);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 8;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BBloquear
            // 
            this.BBloquear.Location = new System.Drawing.Point(522, 83);
            this.BBloquear.Name = "BBloquear";
            this.BBloquear.Size = new System.Drawing.Size(75, 39);
            this.BBloquear.TabIndex = 9;
            this.BBloquear.Text = "Bloquear &Desbloquear";
            this.BBloquear.UseVisualStyleBackColor = true;
            this.BBloquear.Click += new System.EventHandler(this.BBloquear_Click);
            // 
            // MCPF
            // 
            this.MCPF.Location = new System.Drawing.Point(364, 25);
            this.MCPF.Mask = "000.000.000-00";
            this.MCPF.Name = "MCPF";
            this.MCPF.Size = new System.Drawing.Size(138, 20);
            this.MCPF.TabIndex = 5;
            // 
            // LListadeUserCli
            // 
            this.LListadeUserCli.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Nome,
            this.CPF,
            this.Situacao});
            this.LListadeUserCli.FullRowSelect = true;
            this.LListadeUserCli.Location = new System.Drawing.Point(15, 51);
            this.LListadeUserCli.Name = "LListadeUserCli";
            this.LListadeUserCli.Size = new System.Drawing.Size(487, 107);
            this.LListadeUserCli.TabIndex = 6;
            this.LListadeUserCli.UseCompatibleStateImageBehavior = false;
            this.LListadeUserCli.View = System.Windows.Forms.View.Details;
            this.LListadeUserCli.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LListadeUserCli_MouseDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 240;
            // 
            // CPF
            // 
            this.CPF.Text = "CPF";
            this.CPF.Width = 93;
            // 
            // Situacao
            // 
            this.Situacao.Text = "Situação";
            this.Situacao.Width = 90;
            // 
            // BuscaUserCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 170);
            this.Controls.Add(this.LListadeUserCli);
            this.Controls.Add(this.MCPF);
            this.Controls.Add(this.BBloquear);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BBuca);
            this.Controls.Add(this.TNome);
            this.Controls.Add(this.TCodigo);
            this.Controls.Add(this.LCPF);
            this.Controls.Add(this.LNome);
            this.Controls.Add(this.LCódigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscaUserCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCódigo;
        private System.Windows.Forms.Label LNome;
        private System.Windows.Forms.Label LCPF;
        private System.Windows.Forms.TextBox TCodigo;
        private System.Windows.Forms.TextBox TNome;
        private System.Windows.Forms.Button BBuca;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BBloquear;
        private System.Windows.Forms.MaskedTextBox MCPF;
        private System.Windows.Forms.ListView LListadeUserCli;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader CPF;
        private System.Windows.Forms.ColumnHeader Situacao;
    }
}