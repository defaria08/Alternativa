namespace alternativa
{
    partial class BuscaContaa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaContaa));
            this.LListadeContas = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATAV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Situacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BCancelar = new System.Windows.Forms.Button();
            this.BBuca = new System.Windows.Forms.Button();
            this.TDescricao = new System.Windows.Forms.TextBox();
            this.TCodigo = new System.Windows.Forms.TextBox();
            this.LSituacao = new System.Windows.Forms.Label();
            this.LDescricao = new System.Windows.Forms.Label();
            this.LCódigo = new System.Windows.Forms.Label();
            this.BPagar = new System.Windows.Forms.Button();
            this.DTVencimento = new System.Windows.Forms.DateTimePicker();
            this.LVP1 = new System.Windows.Forms.Label();
            this.LVPagar = new System.Windows.Forms.Label();
            this.LVP2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LListadeContas
            // 
            this.LListadeContas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Descricao,
            this.Valor,
            this.DATAV,
            this.Situacao});
            this.LListadeContas.FullRowSelect = true;
            this.LListadeContas.Location = new System.Drawing.Point(15, 51);
            this.LListadeContas.Name = "LListadeContas";
            this.LListadeContas.Size = new System.Drawing.Size(487, 267);
            this.LListadeContas.TabIndex = 6;
            this.LListadeContas.UseCompatibleStateImageBehavior = false;
            this.LListadeContas.View = System.Windows.Forms.View.Details;
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descrição";
            this.Descricao.Width = 163;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor R$";
            this.Valor.Width = 64;
            // 
            // DATAV
            // 
            this.DATAV.Text = "Data de Vencimento";
            this.DATAV.Width = 111;
            // 
            // Situacao
            // 
            this.Situacao.Text = "Situação";
            this.Situacao.Width = 79;
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
            this.BBuca.Text = "Bu&scar";
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
            // LSituacao
            // 
            this.LSituacao.AutoSize = true;
            this.LSituacao.Location = new System.Drawing.Point(361, 9);
            this.LSituacao.Name = "LSituacao";
            this.LSituacao.Size = new System.Drawing.Size(104, 13);
            this.LSituacao.TabIndex = 4;
            this.LSituacao.Text = "Data de Vencimento";
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
            // BPagar
            // 
            this.BPagar.Location = new System.Drawing.Point(522, 83);
            this.BPagar.Name = "BPagar";
            this.BPagar.Size = new System.Drawing.Size(75, 23);
            this.BPagar.TabIndex = 9;
            this.BPagar.Text = "&Baixa";
            this.BPagar.UseVisualStyleBackColor = true;
            this.BPagar.Click += new System.EventHandler(this.BPagar_Click);
            // 
            // DTVencimento
            // 
            this.DTVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTVencimento.Location = new System.Drawing.Point(364, 25);
            this.DTVencimento.Name = "DTVencimento";
            this.DTVencimento.Size = new System.Drawing.Size(138, 20);
            this.DTVencimento.TabIndex = 10;
            // 
            // LVP1
            // 
            this.LVP1.AutoSize = true;
            this.LVP1.Location = new System.Drawing.Point(516, 128);
            this.LVP1.Name = "LVP1";
            this.LVP1.Size = new System.Drawing.Size(73, 13);
            this.LVP1.TabIndex = 11;
            this.LVP1.Text = "Valor a pagar ";
            // 
            // LVPagar
            // 
            this.LVPagar.AutoSize = true;
            this.LVPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVPagar.Location = new System.Drawing.Point(511, 160);
            this.LVPagar.Name = "LVPagar";
            this.LVPagar.Size = new System.Drawing.Size(63, 21);
            this.LVPagar.TabIndex = 12;
            this.LVPagar.Text = "RS 0.00";
            // 
            // LVP2
            // 
            this.LVP2.AutoSize = true;
            this.LVP2.Location = new System.Drawing.Point(534, 144);
            this.LVP2.Name = "LVP2";
            this.LVP2.Size = new System.Drawing.Size(40, 13);
            this.LVP2.TabIndex = 13;
            this.LVP2.Text = "no DIA";
            // 
            // BuscaContaa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 330);
            this.Controls.Add(this.LVP2);
            this.Controls.Add(this.LVPagar);
            this.Controls.Add(this.LVP1);
            this.Controls.Add(this.DTVencimento);
            this.Controls.Add(this.BPagar);
            this.Controls.Add(this.LListadeContas);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BBuca);
            this.Controls.Add(this.TDescricao);
            this.Controls.Add(this.TCodigo);
            this.Controls.Add(this.LSituacao);
            this.Controls.Add(this.LDescricao);
            this.Controls.Add(this.LCódigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuscaContaa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView LListadeContas;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.ColumnHeader DATAV;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BBuca;
        private System.Windows.Forms.TextBox TDescricao;
        private System.Windows.Forms.TextBox TCodigo;
        private System.Windows.Forms.Label LSituacao;
        private System.Windows.Forms.Label LDescricao;
        private System.Windows.Forms.Label LCódigo;
        private System.Windows.Forms.ColumnHeader Situacao;
        private System.Windows.Forms.Button BPagar;
        private System.Windows.Forms.DateTimePicker DTVencimento;
        private System.Windows.Forms.Label LVP1;
        private System.Windows.Forms.Label LVPagar;
        private System.Windows.Forms.Label LVP2;
    }
}