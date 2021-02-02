namespace alternativa
{
    partial class BuscaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaProduto));
            this.LListadeProduto = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fornecedor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BCancelar = new System.Windows.Forms.Button();
            this.BBuca = new System.Windows.Forms.Button();
            this.TDescricao = new System.Windows.Forms.TextBox();
            this.TCodigo = new System.Windows.Forms.TextBox();
            this.LCNPJ = new System.Windows.Forms.Label();
            this.LDescricao = new System.Windows.Forms.Label();
            this.LCódigo = new System.Windows.Forms.Label();
            this.CFornecedor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LListadeProduto
            // 
            this.LListadeProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Descricao,
            this.Quantidade,
            this.Fornecedor});
            this.LListadeProduto.FullRowSelect = true;
            this.LListadeProduto.Location = new System.Drawing.Point(15, 51);
            this.LListadeProduto.Name = "LListadeProduto";
            this.LListadeProduto.Size = new System.Drawing.Size(487, 107);
            this.LListadeProduto.TabIndex = 6;
            this.LListadeProduto.UseCompatibleStateImageBehavior = false;
            this.LListadeProduto.View = System.Windows.Forms.View.Details;
            this.LListadeProduto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LListadeProduto_MouseDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            this.Codigo.Width = 101;
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descrição";
            this.Descricao.Width = 210;
            // 
            // Quantidade
            // 
            this.Quantidade.Text = "Quantidade";
            this.Quantidade.Width = 70;
            // 
            // Fornecedor
            // 
            this.Fornecedor.Text = "Fornecedor";
            this.Fornecedor.Width = 98;
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
            // TDescricao
            // 
            this.TDescricao.Location = new System.Drawing.Point(103, 25);
            this.TDescricao.Name = "TDescricao";
            this.TDescricao.Size = new System.Drawing.Size(255, 20);
            this.TDescricao.TabIndex = 3;
            // 
            // TCodigo
            // 
            this.TCodigo.Location = new System.Drawing.Point(15, 25);
            this.TCodigo.Name = "TCodigo";
            this.TCodigo.Size = new System.Drawing.Size(82, 20);
            this.TCodigo.TabIndex = 1;
            this.TCodigo.Leave += new System.EventHandler(this.TCodigo_Leave);
            // 
            // LCNPJ
            // 
            this.LCNPJ.AutoSize = true;
            this.LCNPJ.Location = new System.Drawing.Point(361, 9);
            this.LCNPJ.Name = "LCNPJ";
            this.LCNPJ.Size = new System.Drawing.Size(61, 13);
            this.LCNPJ.TabIndex = 4;
            this.LCNPJ.Text = "Fornecedor";
            // 
            // LDescricao
            // 
            this.LDescricao.AutoSize = true;
            this.LDescricao.Location = new System.Drawing.Point(100, 9);
            this.LDescricao.Name = "LDescricao";
            this.LDescricao.Size = new System.Drawing.Size(55, 13);
            this.LDescricao.TabIndex = 2;
            this.LDescricao.Text = "Descrição";
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
            // CFornecedor
            // 
            this.CFornecedor.Location = new System.Drawing.Point(364, 25);
            this.CFornecedor.Name = "CFornecedor";
            this.CFornecedor.Size = new System.Drawing.Size(138, 20);
            this.CFornecedor.TabIndex = 5;
            // 
            // BuscaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 171);
            this.Controls.Add(this.CFornecedor);
            this.Controls.Add(this.LListadeProduto);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BBuca);
            this.Controls.Add(this.TDescricao);
            this.Controls.Add(this.TCodigo);
            this.Controls.Add(this.LCNPJ);
            this.Controls.Add(this.LDescricao);
            this.Controls.Add(this.LCódigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LListadeProduto;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.ColumnHeader Quantidade;
        private System.Windows.Forms.ColumnHeader Fornecedor;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BBuca;
        private System.Windows.Forms.TextBox TDescricao;
        private System.Windows.Forms.TextBox TCodigo;
        private System.Windows.Forms.Label LCNPJ;
        private System.Windows.Forms.Label LDescricao;
        private System.Windows.Forms.Label LCódigo;
        private System.Windows.Forms.TextBox CFornecedor;
    }
}