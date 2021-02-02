namespace alternativa
{
    partial class Venda
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
            System.Windows.Forms.ColumnHeader Cod;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venda));
            this.LVenda = new System.Windows.Forms.Label();
            this.LUsuario = new System.Windows.Forms.Label();
            this.LCliente = new System.Windows.Forms.Label();
            this.LValorTotal = new System.Windows.Forms.Label();
            this.LSubtotal = new System.Windows.Forms.Label();
            this.LDesconto = new System.Windows.Forms.Label();
            this.ListadeItem = new System.Windows.Forms.ListView();
            this.CLDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLQtd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TCodigo = new System.Windows.Forms.TextBox();
            this.TUser = new System.Windows.Forms.TextBox();
            this.Tcliente = new System.Windows.Forms.TextBox();
            this.RCBarras = new System.Windows.Forms.RadioButton();
            this.RProduto = new System.Windows.Forms.RadioButton();
            this.TQtd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TSubtotal = new System.Windows.Forms.TextBox();
            this.TDesconto = new System.Windows.Forms.TextBox();
            this.TValorTotal = new System.Windows.Forms.TextBox();
            this.BCancelar = new System.Windows.Forms.Button();
            this.BConfirmar = new System.Windows.Forms.Button();
            this.BAdicionar = new System.Windows.Forms.Button();
            this.BRemover = new System.Windows.Forms.Button();
            this.MCPF = new System.Windows.Forms.MaskedTextBox();
            this.RCPF = new System.Windows.Forms.RadioButton();
            this.RCNPJ = new System.Windows.Forms.RadioButton();
            this.gpdoc = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PFotoProduto = new System.Windows.Forms.PictureBox();
            this.TBproduto = new System.Windows.Forms.TextBox();
            this.BBusca = new System.Windows.Forms.Button();
            this.Radioporcento = new System.Windows.Forms.RadioButton();
            this.radiograna = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            Cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gpdoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PFotoProduto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LVenda
            // 
            this.LVenda.AutoSize = true;
            this.LVenda.Location = new System.Drawing.Point(22, 12);
            this.LVenda.Name = "LVenda";
            this.LVenda.Size = new System.Drawing.Size(38, 13);
            this.LVenda.TabIndex = 0;
            this.LVenda.Text = "Venda";
            // 
            // LUsuario
            // 
            this.LUsuario.AutoSize = true;
            this.LUsuario.Location = new System.Drawing.Point(116, 12);
            this.LUsuario.Name = "LUsuario";
            this.LUsuario.Size = new System.Drawing.Size(43, 13);
            this.LUsuario.TabIndex = 2;
            this.LUsuario.Text = "Usuário";
            // 
            // LCliente
            // 
            this.LCliente.AutoSize = true;
            this.LCliente.Location = new System.Drawing.Point(246, 12);
            this.LCliente.Name = "LCliente";
            this.LCliente.Size = new System.Drawing.Size(39, 13);
            this.LCliente.TabIndex = 4;
            this.LCliente.Text = "Cliente";
            // 
            // LValorTotal
            // 
            this.LValorTotal.AutoSize = true;
            this.LValorTotal.Location = new System.Drawing.Point(629, 318);
            this.LValorTotal.Name = "LValorTotal";
            this.LValorTotal.Size = new System.Drawing.Size(58, 13);
            this.LValorTotal.TabIndex = 21;
            this.LValorTotal.Text = "Valor Total";
            // 
            // LSubtotal
            // 
            this.LSubtotal.AutoSize = true;
            this.LSubtotal.Location = new System.Drawing.Point(629, 192);
            this.LSubtotal.Name = "LSubtotal";
            this.LSubtotal.Size = new System.Drawing.Size(46, 13);
            this.LSubtotal.TabIndex = 17;
            this.LSubtotal.Text = "Subtotal";
            // 
            // LDesconto
            // 
            this.LDesconto.AutoSize = true;
            this.LDesconto.Location = new System.Drawing.Point(629, 255);
            this.LDesconto.Name = "LDesconto";
            this.LDesconto.Size = new System.Drawing.Size(53, 13);
            this.LDesconto.TabIndex = 19;
            this.LDesconto.Text = "Desconto";
            // 
            // ListadeItem
            // 
            this.ListadeItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CLDescricao,
            this.CLValor,
            this.CLQtd,
            Cod});
            this.ListadeItem.FullRowSelect = true;
            this.ListadeItem.Location = new System.Drawing.Point(25, 104);
            this.ListadeItem.Name = "ListadeItem";
            this.ListadeItem.Size = new System.Drawing.Size(577, 310);
            this.ListadeItem.TabIndex = 16;
            this.ListadeItem.UseCompatibleStateImageBehavior = false;
            this.ListadeItem.View = System.Windows.Forms.View.Details;
            // 
            // CLDescricao
            // 
            this.CLDescricao.Text = "Descrição";
            this.CLDescricao.Width = 398;
            // 
            // CLValor
            // 
            this.CLValor.Text = "Valor R$";
            this.CLValor.Width = 79;
            // 
            // CLQtd
            // 
            this.CLQtd.Text = "Quantidade";
            this.CLQtd.Width = 94;
            // 
            // TCodigo
            // 
            this.TCodigo.Enabled = false;
            this.TCodigo.Location = new System.Drawing.Point(25, 28);
            this.TCodigo.Name = "TCodigo";
            this.TCodigo.Size = new System.Drawing.Size(88, 20);
            this.TCodigo.TabIndex = 1;
            // 
            // TUser
            // 
            this.TUser.Enabled = false;
            this.TUser.Location = new System.Drawing.Point(119, 28);
            this.TUser.MaxLength = 30;
            this.TUser.Name = "TUser";
            this.TUser.Size = new System.Drawing.Size(124, 20);
            this.TUser.TabIndex = 3;
            // 
            // Tcliente
            // 
            this.Tcliente.Location = new System.Drawing.Point(249, 28);
            this.Tcliente.MaxLength = 50;
            this.Tcliente.Name = "Tcliente";
            this.Tcliente.Size = new System.Drawing.Size(232, 20);
            this.Tcliente.TabIndex = 5;
            // 
            // RCBarras
            // 
            this.RCBarras.AutoSize = true;
            this.RCBarras.Checked = true;
            this.RCBarras.Location = new System.Drawing.Point(1, 1);
            this.RCBarras.Name = "RCBarras";
            this.RCBarras.Size = new System.Drawing.Size(106, 17);
            this.RCBarras.TabIndex = 8;
            this.RCBarras.TabStop = true;
            this.RCBarras.Text = "Código de Barras";
            this.RCBarras.UseVisualStyleBackColor = true;
            this.RCBarras.CheckedChanged += new System.EventHandler(this.RCBarras_CheckedChanged);
            // 
            // RProduto
            // 
            this.RProduto.AutoSize = true;
            this.RProduto.Location = new System.Drawing.Point(112, 1);
            this.RProduto.Name = "RProduto";
            this.RProduto.Size = new System.Drawing.Size(73, 17);
            this.RProduto.TabIndex = 10;
            this.RProduto.Text = "Descrição";
            this.RProduto.UseVisualStyleBackColor = true;
            // 
            // TQtd
            // 
            this.TQtd.Location = new System.Drawing.Point(353, 75);
            this.TQtd.Name = "TQtd";
            this.TQtd.Size = new System.Drawing.Size(77, 20);
            this.TQtd.TabIndex = 13;
            this.TQtd.Text = "1";
            this.TQtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TQtd.Leave += new System.EventHandler(this.TQtd_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantidade";
            // 
            // TSubtotal
            // 
            this.TSubtotal.Enabled = false;
            this.TSubtotal.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.TSubtotal.ForeColor = System.Drawing.Color.Blue;
            this.TSubtotal.Location = new System.Drawing.Point(674, 208);
            this.TSubtotal.Multiline = true;
            this.TSubtotal.Name = "TSubtotal";
            this.TSubtotal.Size = new System.Drawing.Size(114, 44);
            this.TSubtotal.TabIndex = 18;
            this.TSubtotal.Text = "0.00";
            this.TSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TDesconto
            // 
            this.TDesconto.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.TDesconto.ForeColor = System.Drawing.Color.Blue;
            this.TDesconto.Location = new System.Drawing.Point(674, 271);
            this.TDesconto.Multiline = true;
            this.TDesconto.Name = "TDesconto";
            this.TDesconto.Size = new System.Drawing.Size(114, 44);
            this.TDesconto.TabIndex = 20;
            this.TDesconto.Text = "0,00";
            this.TDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TDesconto.TextChanged += new System.EventHandler(this.TDesconto_TextChanged);
            this.TDesconto.Leave += new System.EventHandler(this.TDesconto_Leave);
            // 
            // TValorTotal
            // 
            this.TValorTotal.Enabled = false;
            this.TValorTotal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TValorTotal.Location = new System.Drawing.Point(674, 334);
            this.TValorTotal.Multiline = true;
            this.TValorTotal.Name = "TValorTotal";
            this.TValorTotal.Size = new System.Drawing.Size(114, 44);
            this.TValorTotal.TabIndex = 22;
            this.TValorTotal.Text = "0.00";
            this.TValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(713, 391);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 0;
            this.BCancelar.Text = "Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // BConfirmar
            // 
            this.BConfirmar.Location = new System.Drawing.Point(632, 391);
            this.BConfirmar.Name = "BConfirmar";
            this.BConfirmar.Size = new System.Drawing.Size(75, 23);
            this.BConfirmar.TabIndex = 23;
            this.BConfirmar.Text = "Confirmar";
            this.BConfirmar.UseVisualStyleBackColor = true;
            this.BConfirmar.Click += new System.EventHandler(this.button3_Click);
            // 
            // BAdicionar
            // 
            this.BAdicionar.Location = new System.Drawing.Point(436, 72);
            this.BAdicionar.Name = "BAdicionar";
            this.BAdicionar.Size = new System.Drawing.Size(80, 23);
            this.BAdicionar.TabIndex = 14;
            this.BAdicionar.Text = "Adicionar";
            this.BAdicionar.UseVisualStyleBackColor = true;
            this.BAdicionar.Click += new System.EventHandler(this.BAdicionar_Click);
            // 
            // BRemover
            // 
            this.BRemover.Location = new System.Drawing.Point(522, 72);
            this.BRemover.Name = "BRemover";
            this.BRemover.Size = new System.Drawing.Size(80, 23);
            this.BRemover.TabIndex = 15;
            this.BRemover.Text = "Remover";
            this.BRemover.UseVisualStyleBackColor = true;
            this.BRemover.Click += new System.EventHandler(this.BRemover_Click);
            // 
            // MCPF
            // 
            this.MCPF.Location = new System.Drawing.Point(487, 28);
            this.MCPF.Mask = "999.999.999-99";
            this.MCPF.Name = "MCPF";
            this.MCPF.Size = new System.Drawing.Size(115, 20);
            this.MCPF.TabIndex = 7;
            this.MCPF.Leave += new System.EventHandler(this.MCPF_Leave);
            // 
            // RCPF
            // 
            this.RCPF.AutoSize = true;
            this.RCPF.CausesValidation = false;
            this.RCPF.Checked = true;
            this.RCPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RCPF.Location = new System.Drawing.Point(5, 3);
            this.RCPF.Name = "RCPF";
            this.RCPF.Size = new System.Drawing.Size(45, 17);
            this.RCPF.TabIndex = 24;
            this.RCPF.TabStop = true;
            this.RCPF.Text = "CPF";
            this.RCPF.UseVisualStyleBackColor = true;
            this.RCPF.CheckedChanged += new System.EventHandler(this.RCPF_CheckedChanged);
            // 
            // RCNPJ
            // 
            this.RCNPJ.AutoSize = true;
            this.RCNPJ.Location = new System.Drawing.Point(56, 3);
            this.RCNPJ.Name = "RCNPJ";
            this.RCNPJ.Size = new System.Drawing.Size(52, 17);
            this.RCNPJ.TabIndex = 25;
            this.RCNPJ.Text = "CNPJ";
            this.RCNPJ.UseVisualStyleBackColor = true;
            this.RCNPJ.CheckedChanged += new System.EventHandler(this.RCNPJ_CheckedChanged);
            // 
            // gpdoc
            // 
            this.gpdoc.Controls.Add(this.RCNPJ);
            this.gpdoc.Controls.Add(this.RCPF);
            this.gpdoc.Location = new System.Drawing.Point(487, 5);
            this.gpdoc.Name = "gpdoc";
            this.gpdoc.Size = new System.Drawing.Size(114, 23);
            this.gpdoc.TabIndex = 26;
            this.gpdoc.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(614, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 39);
            this.label1.TabIndex = 27;
            this.label1.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(614, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 39);
            this.label3.TabIndex = 29;
            this.label3.Text = "R$";
            // 
            // PFotoProduto
            // 
            this.PFotoProduto.Image = global::alternativa.Properties.Resources.icon_revenda;
            this.PFotoProduto.Location = new System.Drawing.Point(632, 12);
            this.PFotoProduto.Name = "PFotoProduto";
            this.PFotoProduto.Size = new System.Drawing.Size(156, 163);
            this.PFotoProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PFotoProduto.TabIndex = 9;
            this.PFotoProduto.TabStop = false;
            // 
            // TBproduto
            // 
            this.TBproduto.Location = new System.Drawing.Point(25, 75);
            this.TBproduto.MaxLength = 20;
            this.TBproduto.Name = "TBproduto";
            this.TBproduto.Size = new System.Drawing.Size(245, 20);
            this.TBproduto.TabIndex = 30;
            // 
            // BBusca
            // 
            this.BBusca.Location = new System.Drawing.Point(276, 73);
            this.BBusca.Name = "BBusca";
            this.BBusca.Size = new System.Drawing.Size(71, 23);
            this.BBusca.TabIndex = 31;
            this.BBusca.Text = "Buscar";
            this.BBusca.UseVisualStyleBackColor = true;
            this.BBusca.Click += new System.EventHandler(this.BBusca_Click);
            // 
            // Radioporcento
            // 
            this.Radioporcento.AutoSize = true;
            this.Radioporcento.Checked = true;
            this.Radioporcento.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Radioporcento.ForeColor = System.Drawing.Color.Navy;
            this.Radioporcento.Location = new System.Drawing.Point(621, 271);
            this.Radioporcento.Name = "Radioporcento";
            this.Radioporcento.Size = new System.Drawing.Size(40, 25);
            this.Radioporcento.TabIndex = 32;
            this.Radioporcento.TabStop = true;
            this.Radioporcento.Text = "%";
            this.Radioporcento.UseVisualStyleBackColor = true;
            this.Radioporcento.CheckedChanged += new System.EventHandler(this.Radioporcento_CheckedChanged);
            // 
            // radiograna
            // 
            this.radiograna.AutoSize = true;
            this.radiograna.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiograna.ForeColor = System.Drawing.Color.Navy;
            this.radiograna.Location = new System.Drawing.Point(621, 290);
            this.radiograna.Name = "radiograna";
            this.radiograna.Size = new System.Drawing.Size(47, 25);
            this.radiograna.TabIndex = 33;
            this.radiograna.Text = "R$";
            this.radiograna.UseVisualStyleBackColor = true;
            this.radiograna.CheckedChanged += new System.EventHandler(this.radiograna_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RProduto);
            this.panel1.Controls.Add(this.RCBarras);
            this.panel1.Location = new System.Drawing.Point(25, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            this.panel1.TabIndex = 35;
            // 
            // Venda
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.radiograna);
            this.Controls.Add(this.Radioporcento);
            this.Controls.Add(this.BBusca);
            this.Controls.Add(this.TBproduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MCPF);
            this.Controls.Add(this.BRemover);
            this.Controls.Add(this.BAdicionar);
            this.Controls.Add(this.BConfirmar);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.TValorTotal);
            this.Controls.Add(this.TDesconto);
            this.Controls.Add(this.TSubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TQtd);
            this.Controls.Add(this.Tcliente);
            this.Controls.Add(this.TUser);
            this.Controls.Add(this.TCodigo);
            this.Controls.Add(this.ListadeItem);
            this.Controls.Add(this.PFotoProduto);
            this.Controls.Add(this.LDesconto);
            this.Controls.Add(this.LSubtotal);
            this.Controls.Add(this.LValorTotal);
            this.Controls.Add(this.LCliente);
            this.Controls.Add(this.LUsuario);
            this.Controls.Add(this.LVenda);
            this.Controls.Add(this.gpdoc);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.Load += new System.EventHandler(this.Venda_Load);
            this.gpdoc.ResumeLayout(false);
            this.gpdoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PFotoProduto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LVenda;
        private System.Windows.Forms.Label LUsuario;
        private System.Windows.Forms.Label LCliente;
        private System.Windows.Forms.Label LValorTotal;
        private System.Windows.Forms.Label LSubtotal;
        private System.Windows.Forms.Label LDesconto;
        private System.Windows.Forms.PictureBox PFotoProduto;
        private System.Windows.Forms.ListView ListadeItem;
        private System.Windows.Forms.TextBox TCodigo;
        private System.Windows.Forms.TextBox TUser;
        private System.Windows.Forms.TextBox Tcliente;
        private System.Windows.Forms.RadioButton RCBarras;
        private System.Windows.Forms.RadioButton RProduto;
        private System.Windows.Forms.TextBox TQtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TSubtotal;
        private System.Windows.Forms.TextBox TDesconto;
        private System.Windows.Forms.TextBox TValorTotal;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Button BConfirmar;
        private System.Windows.Forms.Button BAdicionar;
        private System.Windows.Forms.Button BRemover;
        private System.Windows.Forms.ColumnHeader CLDescricao;
        private System.Windows.Forms.ColumnHeader CLValor;
        private System.Windows.Forms.ColumnHeader CLQtd;
        private System.Windows.Forms.MaskedTextBox MCPF;
        private System.Windows.Forms.RadioButton RCPF;
        private System.Windows.Forms.RadioButton RCNPJ;
        private System.Windows.Forms.GroupBox gpdoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBproduto;
        private System.Windows.Forms.Button BBusca;
        private System.Windows.Forms.RadioButton Radioporcento;
        private System.Windows.Forms.RadioButton radiograna;
        private System.Windows.Forms.Panel panel1;
    }
}