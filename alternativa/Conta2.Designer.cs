namespace alternativa
{
    partial class Conta2
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
            this.LCodigo = new System.Windows.Forms.Label();
            this.LDescricao = new System.Windows.Forms.Label();
            this.LValor = new System.Windows.Forms.Label();
            this.LDVencimento = new System.Windows.Forms.Label();
            this.LSituacao = new System.Windows.Forms.Label();
            this.TCodigo = new System.Windows.Forms.TextBox();
            this.TDescricao = new System.Windows.Forms.TextBox();
            this.DTVencimento = new System.Windows.Forms.DateTimePicker();
            this.TValor = new System.Windows.Forms.TextBox();
            this.CSituacao = new System.Windows.Forms.ComboBox();
            this.BLimpar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.ListaConta = new System.Windows.Forms.ListView();
            this.codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataVencimento = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Situacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BAdicionar = new System.Windows.Forms.Button();
            this.BPagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LVPDia = new System.Windows.Forms.Label();
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
            // LDescricao
            // 
            this.LDescricao.AutoSize = true;
            this.LDescricao.Location = new System.Drawing.Point(83, 9);
            this.LDescricao.Name = "LDescricao";
            this.LDescricao.Size = new System.Drawing.Size(55, 13);
            this.LDescricao.TabIndex = 2;
            this.LDescricao.Text = "Descrição";
            // 
            // LValor
            // 
            this.LValor.AutoSize = true;
            this.LValor.Location = new System.Drawing.Point(12, 50);
            this.LValor.Name = "LValor";
            this.LValor.Size = new System.Drawing.Size(31, 13);
            this.LValor.TabIndex = 6;
            this.LValor.Text = "Valor";
            // 
            // LDVencimento
            // 
            this.LDVencimento.AutoSize = true;
            this.LDVencimento.Location = new System.Drawing.Point(355, 9);
            this.LDVencimento.Name = "LDVencimento";
            this.LDVencimento.Size = new System.Drawing.Size(104, 13);
            this.LDVencimento.TabIndex = 4;
            this.LDVencimento.Text = "Data de Vencimento";
            // 
            // LSituacao
            // 
            this.LSituacao.AutoSize = true;
            this.LSituacao.Location = new System.Drawing.Point(83, 50);
            this.LSituacao.Name = "LSituacao";
            this.LSituacao.Size = new System.Drawing.Size(49, 13);
            this.LSituacao.TabIndex = 8;
            this.LSituacao.Text = "Situação";
            // 
            // TCodigo
            // 
            this.TCodigo.Enabled = false;
            this.TCodigo.Location = new System.Drawing.Point(15, 25);
            this.TCodigo.Name = "TCodigo";
            this.TCodigo.Size = new System.Drawing.Size(65, 20);
            this.TCodigo.TabIndex = 1;
            // 
            // TDescricao
            // 
            this.TDescricao.Location = new System.Drawing.Point(86, 24);
            this.TDescricao.Name = "TDescricao";
            this.TDescricao.Size = new System.Drawing.Size(266, 20);
            this.TDescricao.TabIndex = 3;
            // 
            // DTVencimento
            // 
            this.DTVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTVencimento.Location = new System.Drawing.Point(358, 25);
            this.DTVencimento.Name = "DTVencimento";
            this.DTVencimento.Size = new System.Drawing.Size(101, 20);
            this.DTVencimento.TabIndex = 5;
            // 
            // TValor
            // 
            this.TValor.Location = new System.Drawing.Point(15, 66);
            this.TValor.Name = "TValor";
            this.TValor.Size = new System.Drawing.Size(65, 20);
            this.TValor.TabIndex = 7;
            this.TValor.Leave += new System.EventHandler(this.TValor_Leave);
            // 
            // CSituacao
            // 
            this.CSituacao.FormattingEnabled = true;
            this.CSituacao.Items.AddRange(new object[] {
            "A Pagar",
            "Paga"});
            this.CSituacao.Location = new System.Drawing.Point(86, 66);
            this.CSituacao.Name = "CSituacao";
            this.CSituacao.Size = new System.Drawing.Size(205, 21);
            this.CSituacao.TabIndex = 9;
            // 
            // BLimpar
            // 
            this.BLimpar.Location = new System.Drawing.Point(312, 290);
            this.BLimpar.Name = "BLimpar";
            this.BLimpar.Size = new System.Drawing.Size(75, 23);
            this.BLimpar.TabIndex = 16;
            this.BLimpar.Text = "&Limpar";
            this.BLimpar.UseVisualStyleBackColor = true;
            this.BLimpar.Click += new System.EventHandler(this.BLimpar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(393, 290);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 17;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // ListaConta
            // 
            this.ListaConta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codigo,
            this.Descricao,
            this.Valor,
            this.DataVencimento,
            this.Situacao});
            this.ListaConta.FullRowSelect = true;
            this.ListaConta.Location = new System.Drawing.Point(12, 139);
            this.ListaConta.Name = "ListaConta";
            this.ListaConta.Size = new System.Drawing.Size(456, 145);
            this.ListaConta.TabIndex = 12;
            this.ListaConta.UseCompatibleStateImageBehavior = false;
            this.ListaConta.View = System.Windows.Forms.View.Details;
            // 
            // codigo
            // 
            this.codigo.Text = "Código";
            this.codigo.Width = 58;
            // 
            // Descricao
            // 
            this.Descricao.Text = "Descrição";
            this.Descricao.Width = 137;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor R$";
            this.Valor.Width = 73;
            // 
            // DataVencimento
            // 
            this.DataVencimento.Text = "Data de Vencimento";
            this.DataVencimento.Width = 116;
            // 
            // Situacao
            // 
            this.Situacao.Text = "Situação";
            this.Situacao.Width = 64;
            // 
            // BAdicionar
            // 
            this.BAdicionar.Location = new System.Drawing.Point(384, 64);
            this.BAdicionar.Name = "BAdicionar";
            this.BAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BAdicionar.TabIndex = 10;
            this.BAdicionar.Text = "&Adicionar";
            this.BAdicionar.UseVisualStyleBackColor = true;
            this.BAdicionar.Click += new System.EventHandler(this.BAdicionar_Click);
            // 
            // BPagar
            // 
            this.BPagar.Location = new System.Drawing.Point(231, 290);
            this.BPagar.Name = "BPagar";
            this.BPagar.Size = new System.Drawing.Size(75, 23);
            this.BPagar.TabIndex = 15;
            this.BPagar.Text = "&Pagar";
            this.BPagar.UseVisualStyleBackColor = true;
            this.BPagar.Click += new System.EventHandler(this.BPagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Contas a Pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Valor a pagar do Dia:";
            // 
            // LVPDia
            // 
            this.LVPDia.AutoSize = true;
            this.LVPDia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LVPDia.Location = new System.Drawing.Point(124, 293);
            this.LVPDia.Name = "LVPDia";
            this.LVPDia.Size = new System.Drawing.Size(52, 17);
            this.LVPDia.TabIndex = 14;
            this.LVPDia.Text = "R$ 0.00";
            // 
            // Conta2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 325);
            this.Controls.Add(this.LVPDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BPagar);
            this.Controls.Add(this.BAdicionar);
            this.Controls.Add(this.ListaConta);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BLimpar);
            this.Controls.Add(this.CSituacao);
            this.Controls.Add(this.TValor);
            this.Controls.Add(this.DTVencimento);
            this.Controls.Add(this.TDescricao);
            this.Controls.Add(this.TCodigo);
            this.Controls.Add(this.LSituacao);
            this.Controls.Add(this.LDVencimento);
            this.Controls.Add(this.LValor);
            this.Controls.Add(this.LDescricao);
            this.Controls.Add(this.LCodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Conta2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.Label LDescricao;
        private System.Windows.Forms.Label LValor;
        private System.Windows.Forms.Label LDVencimento;
        private System.Windows.Forms.Label LSituacao;
        private System.Windows.Forms.TextBox TCodigo;
        private System.Windows.Forms.TextBox TDescricao;
        private System.Windows.Forms.DateTimePicker DTVencimento;
        private System.Windows.Forms.TextBox TValor;
        private System.Windows.Forms.Button BLimpar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.ListView ListaConta;
        private System.Windows.Forms.ColumnHeader Descricao;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.ColumnHeader DataVencimento;
        private System.Windows.Forms.ColumnHeader Situacao;
        private System.Windows.Forms.Button BAdicionar;
        private System.Windows.Forms.Button BPagar;
        private System.Windows.Forms.ColumnHeader codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LVPDia;
        protected System.Windows.Forms.ComboBox CSituacao;
    }
}