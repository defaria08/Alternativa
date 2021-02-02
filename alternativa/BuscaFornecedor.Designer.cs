namespace alternativa
{
    partial class BuscaFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaFornecedor));
            this.LListadeFornecedor = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeFant = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CNPJ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Situacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.BBloquear = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BBuca = new System.Windows.Forms.Button();
            this.TNome = new System.Windows.Forms.TextBox();
            this.TCódigo = new System.Windows.Forms.TextBox();
            this.LCNPJ = new System.Windows.Forms.Label();
            this.LNome = new System.Windows.Forms.Label();
            this.LCódigo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LListadeFornecedor
            // 
            this.LListadeFornecedor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.NomeFant,
            this.CNPJ,
            this.Situacao});
            this.LListadeFornecedor.FullRowSelect = true;
            this.LListadeFornecedor.Location = new System.Drawing.Point(15, 51);
            this.LListadeFornecedor.Name = "LListadeFornecedor";
            this.LListadeFornecedor.Size = new System.Drawing.Size(487, 107);
            this.LListadeFornecedor.TabIndex = 6;
            this.LListadeFornecedor.UseCompatibleStateImageBehavior = false;
            this.LListadeFornecedor.View = System.Windows.Forms.View.Details;
            this.LListadeFornecedor.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LListadeFornecedor_MouseDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            // 
            // NomeFant
            // 
            this.NomeFant.Text = "Nome Fantasia";
            this.NomeFant.Width = 221;
            // 
            // CNPJ
            // 
            this.CNPJ.Text = "CNPJ";
            this.CNPJ.Width = 111;
            // 
            // Situacao
            // 
            this.Situacao.Text = "Situação";
            this.Situacao.Width = 90;
            // 
            // MCNPJ
            // 
            this.MCNPJ.Location = new System.Drawing.Point(364, 25);
            this.MCNPJ.Mask = "00.000.000/0000-00";
            this.MCNPJ.Name = "MCNPJ";
            this.MCNPJ.Size = new System.Drawing.Size(138, 20);
            this.MCNPJ.TabIndex = 5;
            // 
            // BBloquear
            // 
            this.BBloquear.Location = new System.Drawing.Point(522, 83);
            this.BBloquear.Name = "BBloquear";
            this.BBloquear.Size = new System.Drawing.Size(75, 42);
            this.BBloquear.TabIndex = 9;
            this.BBloquear.Text = "Bloquear &Desbloquear";
            this.BBloquear.UseVisualStyleBackColor = true;
            this.BBloquear.Click += new System.EventHandler(this.BBloquear_Click);
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
            // TNome
            // 
            this.TNome.Location = new System.Drawing.Point(103, 25);
            this.TNome.Name = "TNome";
            this.TNome.Size = new System.Drawing.Size(255, 20);
            this.TNome.TabIndex = 3;
            // 
            // TCódigo
            // 
            this.TCódigo.Location = new System.Drawing.Point(15, 25);
            this.TCódigo.Name = "TCódigo";
            this.TCódigo.Size = new System.Drawing.Size(82, 20);
            this.TCódigo.TabIndex = 1;
            this.TCódigo.Leave += new System.EventHandler(this.TCódigo_Leave);
            // 
            // LCNPJ
            // 
            this.LCNPJ.AutoSize = true;
            this.LCNPJ.Location = new System.Drawing.Point(361, 9);
            this.LCNPJ.Name = "LCNPJ";
            this.LCNPJ.Size = new System.Drawing.Size(34, 13);
            this.LCNPJ.TabIndex = 4;
            this.LCNPJ.Text = "CNPJ";
            // 
            // LNome
            // 
            this.LNome.AutoSize = true;
            this.LNome.Location = new System.Drawing.Point(100, 9);
            this.LNome.Name = "LNome";
            this.LNome.Size = new System.Drawing.Size(78, 13);
            this.LNome.TabIndex = 2;
            this.LNome.Text = "Nome Fantasia";
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
            // BuscaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 168);
            this.Controls.Add(this.LListadeFornecedor);
            this.Controls.Add(this.MCNPJ);
            this.Controls.Add(this.BBloquear);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BBuca);
            this.Controls.Add(this.TNome);
            this.Controls.Add(this.TCódigo);
            this.Controls.Add(this.LCNPJ);
            this.Controls.Add(this.LNome);
            this.Controls.Add(this.LCódigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LListadeFornecedor;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader NomeFant;
        private System.Windows.Forms.ColumnHeader CNPJ;
        private System.Windows.Forms.ColumnHeader Situacao;
        private System.Windows.Forms.MaskedTextBox MCNPJ;
        private System.Windows.Forms.Button BBloquear;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BBuca;
        private System.Windows.Forms.TextBox TNome;
        private System.Windows.Forms.TextBox TCódigo;
        private System.Windows.Forms.Label LCNPJ;
        private System.Windows.Forms.Label LNome;
        private System.Windows.Forms.Label LCódigo;
    }
}