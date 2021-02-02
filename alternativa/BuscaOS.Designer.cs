namespace alternativa
{
    partial class BuscaOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaOS));
            this.LListadeCLiente = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATAV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Situacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BCancelar = new System.Windows.Forms.Button();
            this.BBuca = new System.Windows.Forms.Button();
            this.TCódigo = new System.Windows.Forms.TextBox();
            this.LCliente = new System.Windows.Forms.Label();
            this.LCódigo = new System.Windows.Forms.Label();
            this.CCliente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LListadeCLiente
            // 
            this.LListadeCLiente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.nome,
            this.DATAV,
            this.Situacao});
            this.LListadeCLiente.FullRowSelect = true;
            this.LListadeCLiente.Location = new System.Drawing.Point(15, 51);
            this.LListadeCLiente.Name = "LListadeCLiente";
            this.LListadeCLiente.Size = new System.Drawing.Size(487, 107);
            this.LListadeCLiente.TabIndex = 4;
            this.LListadeCLiente.UseCompatibleStateImageBehavior = false;
            this.LListadeCLiente.View = System.Windows.Forms.View.Details;
            this.LListadeCLiente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LListadeCLiente_MouseDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            this.Codigo.Width = 51;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 219;
            // 
            // DATAV
            // 
            this.DATAV.Text = "Data de Entrada";
            this.DATAV.Width = 94;
            // 
            // Situacao
            // 
            this.Situacao.Text = "Situação";
            this.Situacao.Width = 88;
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(522, 54);
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
            // TCódigo
            // 
            this.TCódigo.Location = new System.Drawing.Point(15, 25);
            this.TCódigo.Name = "TCódigo";
            this.TCódigo.Size = new System.Drawing.Size(82, 20);
            this.TCódigo.TabIndex = 1;
            this.TCódigo.Leave += new System.EventHandler(this.TCódigo_Leave);
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
            // LCódigo
            // 
            this.LCódigo.AutoSize = true;
            this.LCódigo.Location = new System.Drawing.Point(12, 9);
            this.LCódigo.Name = "LCódigo";
            this.LCódigo.Size = new System.Drawing.Size(40, 13);
            this.LCódigo.TabIndex = 0;
            this.LCódigo.Text = "Código";
            // 
            // CCliente
            // 
            this.CCliente.FormattingEnabled = true;
            this.CCliente.Location = new System.Drawing.Point(103, 24);
            this.CCliente.Name = "CCliente";
            this.CCliente.Size = new System.Drawing.Size(399, 21);
            this.CCliente.TabIndex = 3;
            // 
            // BuscaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 169);
            this.Controls.Add(this.CCliente);
            this.Controls.Add(this.LListadeCLiente);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BBuca);
            this.Controls.Add(this.TCódigo);
            this.Controls.Add(this.LCliente);
            this.Controls.Add(this.LCódigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscaOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LListadeCLiente;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader DATAV;
        private System.Windows.Forms.ColumnHeader Situacao;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BBuca;
        private System.Windows.Forms.TextBox TCódigo;
        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.Label LCódigo;
        private System.Windows.Forms.ComboBox CCliente;
    }
}