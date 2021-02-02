namespace alternativa
{
    partial class BuscarVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarVenda));
            this.LListadeProduto = new System.Windows.Forms.ListView();
            this.NVenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BCancelar = new System.Windows.Forms.Button();
            this.BBuca = new System.Windows.Forms.Button();
            this.TNVenda = new System.Windows.Forms.TextBox();
            this.LCliente = new System.Windows.Forms.Label();
            this.LNVenda = new System.Windows.Forms.Label();
            this.CCliente = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LListadeProduto
            // 
            this.LListadeProduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NVenda,
            this.Nome,
            this.DataV});
            this.LListadeProduto.FullRowSelect = true;
            this.LListadeProduto.Location = new System.Drawing.Point(15, 51);
            this.LListadeProduto.Name = "LListadeProduto";
            this.LListadeProduto.Size = new System.Drawing.Size(487, 107);
            this.LListadeProduto.TabIndex = 4;
            this.LListadeProduto.UseCompatibleStateImageBehavior = false;
            this.LListadeProduto.View = System.Windows.Forms.View.Details;
            this.LListadeProduto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LListadeProduto_MouseDoubleClick);
            // 
            // NVenda
            // 
            this.NVenda.Text = "Nº Venda";
            this.NVenda.Width = 99;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 277;
            // 
            // DataV
            // 
            this.DataV.Text = "Data Venda";
            this.DataV.Width = 102;
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(521, 54);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 6;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // BBuca
            // 
            this.BBuca.Location = new System.Drawing.Point(522, 25);
            this.BBuca.Name = "BBuca";
            this.BBuca.Size = new System.Drawing.Size(75, 23);
            this.BBuca.TabIndex = 5;
            this.BBuca.Text = "&Buscar";
            this.BBuca.UseVisualStyleBackColor = true;
            this.BBuca.Click += new System.EventHandler(this.BBuca_Click);
            // 
            // TNVenda
            // 
            this.TNVenda.Location = new System.Drawing.Point(15, 25);
            this.TNVenda.Name = "TNVenda";
            this.TNVenda.Size = new System.Drawing.Size(82, 20);
            this.TNVenda.TabIndex = 1;
            this.TNVenda.Leave += new System.EventHandler(this.TNVenda_Leave);
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Location = new System.Drawing.Point(100, 9);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(39, 13);
            this.LCliente.TabIndex = 2;
            this.LCliente.Text = "Cliente";
            // 
            // LNVenda
            // 
            this.LNVenda.AutoSize = true;
            this.LNVenda.Location = new System.Drawing.Point(12, 9);
            this.LNVenda.Name = "LNVenda";
            this.LNVenda.Size = new System.Drawing.Size(68, 13);
            this.LNVenda.TabIndex = 0;
            this.LNVenda.Text = "Nº da Venda";
            // 
            // CCliente
            // 
            this.CCliente.FormattingEnabled = true;
            this.CCliente.Location = new System.Drawing.Point(103, 25);
            this.CCliente.Name = "CCliente";
            this.CCliente.Size = new System.Drawing.Size(399, 21);
            this.CCliente.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(522, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "&Estorno";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuscarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 173);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CCliente);
            this.Controls.Add(this.LListadeProduto);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BBuca);
            this.Controls.Add(this.TNVenda);
            this.Controls.Add(this.LCliente);
            this.Controls.Add(this.LNVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscarVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Venda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LListadeProduto;
        private System.Windows.Forms.ColumnHeader NVenda;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader DataV;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BBuca;
        private System.Windows.Forms.TextBox TNVenda;
        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.Label LNVenda;
        private System.Windows.Forms.ComboBox CCliente;
        private System.Windows.Forms.Button button1;
    }
}