namespace alternativa
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.PProdutoFoto = new System.Windows.Forms.PictureBox();
            this.LCodigo = new System.Windows.Forms.Label();
            this.LCBarras = new System.Windows.Forms.Label();
            this.LDescricao = new System.Windows.Forms.Label();
            this.LPCusto = new System.Windows.Forms.Label();
            this.LLucro = new System.Windows.Forms.Label();
            this.LPVenda = new System.Windows.Forms.Label();
            this.LModelo = new System.Windows.Forms.Label();
            this.LAno = new System.Windows.Forms.Label();
            this.LMarca = new System.Windows.Forms.Label();
            this.LFabricante = new System.Windows.Forms.Label();
            this.LQualidade = new System.Windows.Forms.Label();
            this.LEstoqueMin = new System.Windows.Forms.Label();
            this.BCarregar = new System.Windows.Forms.Button();
            this.BRemover = new System.Windows.Forms.Button();
            this.BGravar = new System.Windows.Forms.Button();
            this.BLimpar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.TCódigo = new System.Windows.Forms.TextBox();
            this.TCBarras = new System.Windows.Forms.TextBox();
            this.TDescricao = new System.Windows.Forms.TextBox();
            this.TModelo = new System.Windows.Forms.TextBox();
            this.TMarca = new System.Windows.Forms.TextBox();
            this.TFabricante = new System.Windows.Forms.TextBox();
            this.TPVenda = new System.Windows.Forms.TextBox();
            this.TLucro = new System.Windows.Forms.TextBox();
            this.TPCusto = new System.Windows.Forms.TextBox();
            this.TQTD = new System.Windows.Forms.TextBox();
            this.TEstoqueMin = new System.Windows.Forms.TextBox();
            this.MAnoAbrangente = new System.Windows.Forms.MaskedTextBox();
            this.LFornecedor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CFornecedor = new System.Windows.Forms.ComboBox();
            this.LTipo = new System.Windows.Forms.Label();
            this.CTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PProdutoFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PProdutoFoto
            // 
            this.PProdutoFoto.Image = global::alternativa.Properties.Resources.download;
            this.PProdutoFoto.Location = new System.Drawing.Point(619, 12);
            this.PProdutoFoto.Name = "PProdutoFoto";
            this.PProdutoFoto.Size = new System.Drawing.Size(169, 170);
            this.PProdutoFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PProdutoFoto.TabIndex = 0;
            this.PProdutoFoto.TabStop = false;
            // 
            // LCodigo
            // 
            this.LCodigo.AutoSize = true;
            this.LCodigo.Location = new System.Drawing.Point(12, 12);
            this.LCodigo.Name = "LCodigo";
            this.LCodigo.Size = new System.Drawing.Size(40, 13);
            this.LCodigo.TabIndex = 0;
            this.LCodigo.Text = "Código";
            // 
            // LCBarras
            // 
            this.LCBarras.AutoSize = true;
            this.LCBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LCBarras.Location = new System.Drawing.Point(88, 12);
            this.LCBarras.Name = "LCBarras";
            this.LCBarras.Size = new System.Drawing.Size(104, 13);
            this.LCBarras.TabIndex = 2;
            this.LCBarras.Text = "Código de Barras";
            // 
            // LDescricao
            // 
            this.LDescricao.AutoSize = true;
            this.LDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDescricao.Location = new System.Drawing.Point(261, 12);
            this.LDescricao.Name = "LDescricao";
            this.LDescricao.Size = new System.Drawing.Size(64, 13);
            this.LDescricao.TabIndex = 4;
            this.LDescricao.Text = "Descrição";
            // 
            // LPCusto
            // 
            this.LPCusto.AutoSize = true;
            this.LPCusto.Location = new System.Drawing.Point(301, 94);
            this.LPCusto.Name = "LPCusto";
            this.LPCusto.Size = new System.Drawing.Size(80, 13);
            this.LPCusto.TabIndex = 17;
            this.LPCusto.Text = "Preço de Custo";
            // 
            // LLucro
            // 
            this.LLucro.AutoSize = true;
            this.LLucro.Location = new System.Drawing.Point(389, 94);
            this.LLucro.Name = "LLucro";
            this.LLucro.Size = new System.Drawing.Size(45, 13);
            this.LLucro.TabIndex = 19;
            this.LLucro.Text = "Lucro %";
            // 
            // LPVenda
            // 
            this.LPVenda.AutoSize = true;
            this.LPVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPVenda.Location = new System.Drawing.Point(479, 92);
            this.LPVenda.Name = "LPVenda";
            this.LPVenda.Size = new System.Drawing.Size(98, 13);
            this.LPVenda.TabIndex = 21;
            this.LPVenda.Text = "Preço de Venda";
            // 
            // LModelo
            // 
            this.LModelo.AutoSize = true;
            this.LModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LModelo.Location = new System.Drawing.Point(163, 53);
            this.LModelo.Name = "LModelo";
            this.LModelo.Size = new System.Drawing.Size(48, 13);
            this.LModelo.TabIndex = 8;
            this.LModelo.Text = "Modelo";
            // 
            // LAno
            // 
            this.LAno.AutoSize = true;
            this.LAno.Location = new System.Drawing.Point(423, 53);
            this.LAno.Name = "LAno";
            this.LAno.Size = new System.Drawing.Size(84, 13);
            this.LAno.TabIndex = 12;
            this.LAno.Text = "Ano Abrangente";
            // 
            // LMarca
            // 
            this.LMarca.AutoSize = true;
            this.LMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMarca.Location = new System.Drawing.Point(287, 53);
            this.LMarca.Name = "LMarca";
            this.LMarca.Size = new System.Drawing.Size(42, 13);
            this.LMarca.TabIndex = 10;
            this.LMarca.Text = "Marca";
            // 
            // LFabricante
            // 
            this.LFabricante.AutoSize = true;
            this.LFabricante.Location = new System.Drawing.Point(12, 53);
            this.LFabricante.Name = "LFabricante";
            this.LFabricante.Size = new System.Drawing.Size(57, 13);
            this.LFabricante.TabIndex = 6;
            this.LFabricante.Text = "Fabricante";
            // 
            // LQualidade
            // 
            this.LQualidade.AutoSize = true;
            this.LQualidade.Location = new System.Drawing.Point(13, 138);
            this.LQualidade.Name = "LQualidade";
            this.LQualidade.Size = new System.Drawing.Size(62, 13);
            this.LQualidade.TabIndex = 23;
            this.LQualidade.Text = "Quantidade";
            // 
            // LEstoqueMin
            // 
            this.LEstoqueMin.AutoSize = true;
            this.LEstoqueMin.Location = new System.Drawing.Point(103, 138);
            this.LEstoqueMin.Name = "LEstoqueMin";
            this.LEstoqueMin.Size = new System.Drawing.Size(84, 13);
            this.LEstoqueMin.TabIndex = 25;
            this.LEstoqueMin.Text = "Estoque Minímo";
            // 
            // BCarregar
            // 
            this.BCarregar.Location = new System.Drawing.Point(626, 188);
            this.BCarregar.Name = "BCarregar";
            this.BCarregar.Size = new System.Drawing.Size(75, 23);
            this.BCarregar.TabIndex = 29;
            this.BCarregar.Text = "Carregar";
            this.BCarregar.UseVisualStyleBackColor = true;
            this.BCarregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BRemover
            // 
            this.BRemover.Location = new System.Drawing.Point(707, 188);
            this.BRemover.Name = "BRemover";
            this.BRemover.Size = new System.Drawing.Size(75, 23);
            this.BRemover.TabIndex = 30;
            this.BRemover.Text = "Remover";
            this.BRemover.UseVisualStyleBackColor = true;
            this.BRemover.Click += new System.EventHandler(this.button2_Click);
            // 
            // BGravar
            // 
            this.BGravar.Location = new System.Drawing.Point(15, 216);
            this.BGravar.Name = "BGravar";
            this.BGravar.Size = new System.Drawing.Size(75, 23);
            this.BGravar.TabIndex = 31;
            this.BGravar.Text = "&Gravar";
            this.BGravar.UseVisualStyleBackColor = true;
            this.BGravar.Click += new System.EventHandler(this.BGravar_Click);
            // 
            // BLimpar
            // 
            this.BLimpar.Location = new System.Drawing.Point(96, 216);
            this.BLimpar.Name = "BLimpar";
            this.BLimpar.Size = new System.Drawing.Size(75, 23);
            this.BLimpar.TabIndex = 32;
            this.BLimpar.Text = "&Limpar";
            this.BLimpar.UseVisualStyleBackColor = true;
            this.BLimpar.Click += new System.EventHandler(this.BLimpar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(177, 216);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 33;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // TCódigo
            // 
            this.TCódigo.Enabled = false;
            this.TCódigo.Location = new System.Drawing.Point(15, 28);
            this.TCódigo.Name = "TCódigo";
            this.TCódigo.Size = new System.Drawing.Size(70, 20);
            this.TCódigo.TabIndex = 1;
            // 
            // TCBarras
            // 
            this.TCBarras.Location = new System.Drawing.Point(91, 28);
            this.TCBarras.MaxLength = 20;
            this.TCBarras.Name = "TCBarras";
            this.TCBarras.Size = new System.Drawing.Size(168, 20);
            this.TCBarras.TabIndex = 3;
            // 
            // TDescricao
            // 
            this.TDescricao.Location = new System.Drawing.Point(265, 28);
            this.TDescricao.MaxLength = 30;
            this.TDescricao.Name = "TDescricao";
            this.TDescricao.Size = new System.Drawing.Size(320, 20);
            this.TDescricao.TabIndex = 5;
            // 
            // TModelo
            // 
            this.TModelo.Location = new System.Drawing.Point(166, 69);
            this.TModelo.MaxLength = 30;
            this.TModelo.Name = "TModelo";
            this.TModelo.Size = new System.Drawing.Size(118, 20);
            this.TModelo.TabIndex = 9;
            // 
            // TMarca
            // 
            this.TMarca.Location = new System.Drawing.Point(290, 69);
            this.TMarca.MaxLength = 30;
            this.TMarca.Name = "TMarca";
            this.TMarca.Size = new System.Drawing.Size(130, 20);
            this.TMarca.TabIndex = 11;
            // 
            // TFabricante
            // 
            this.TFabricante.Location = new System.Drawing.Point(15, 69);
            this.TFabricante.MaxLength = 30;
            this.TFabricante.Name = "TFabricante";
            this.TFabricante.Size = new System.Drawing.Size(145, 20);
            this.TFabricante.TabIndex = 7;
            // 
            // TPVenda
            // 
            this.TPVenda.Location = new System.Drawing.Point(482, 109);
            this.TPVenda.MaxLength = 5;
            this.TPVenda.Name = "TPVenda";
            this.TPVenda.Size = new System.Drawing.Size(103, 20);
            this.TPVenda.TabIndex = 22;
            this.TPVenda.Text = "0";
            this.TPVenda.Leave += new System.EventHandler(this.TPVenda_Leave);
            // 
            // TLucro
            // 
            this.TLucro.Location = new System.Drawing.Point(392, 109);
            this.TLucro.MaxLength = 5;
            this.TLucro.Name = "TLucro";
            this.TLucro.Size = new System.Drawing.Size(84, 20);
            this.TLucro.TabIndex = 20;
            this.TLucro.Text = "0";
            this.TLucro.TextChanged += new System.EventHandler(this.TLucro_TextChanged);
            this.TLucro.Leave += new System.EventHandler(this.TLucro_Leave);
            // 
            // TPCusto
            // 
            this.TPCusto.Location = new System.Drawing.Point(304, 109);
            this.TPCusto.MaxLength = 5;
            this.TPCusto.Name = "TPCusto";
            this.TPCusto.Size = new System.Drawing.Size(82, 20);
            this.TPCusto.TabIndex = 18;
            this.TPCusto.Text = "0";
            this.TPCusto.Leave += new System.EventHandler(this.TPCusto_Leave);
            // 
            // TQTD
            // 
            this.TQTD.Location = new System.Drawing.Point(16, 154);
            this.TQTD.MaxLength = 5;
            this.TQTD.Name = "TQTD";
            this.TQTD.Size = new System.Drawing.Size(84, 20);
            this.TQTD.TabIndex = 24;
            this.TQTD.Text = "0";
            this.TQTD.Leave += new System.EventHandler(this.TQTD_Leave);
            // 
            // TEstoqueMin
            // 
            this.TEstoqueMin.Location = new System.Drawing.Point(106, 154);
            this.TEstoqueMin.MaxLength = 5;
            this.TEstoqueMin.Name = "TEstoqueMin";
            this.TEstoqueMin.Size = new System.Drawing.Size(100, 20);
            this.TEstoqueMin.TabIndex = 26;
            this.TEstoqueMin.Text = "0";
            this.TEstoqueMin.Leave += new System.EventHandler(this.TEstoqueMin_Leave);
            // 
            // MAnoAbrangente
            // 
            this.MAnoAbrangente.Location = new System.Drawing.Point(426, 69);
            this.MAnoAbrangente.Mask = "9999 - 9999";
            this.MAnoAbrangente.Name = "MAnoAbrangente";
            this.MAnoAbrangente.Size = new System.Drawing.Size(159, 20);
            this.MAnoAbrangente.TabIndex = 13;
            // 
            // LFornecedor
            // 
            this.LFornecedor.AutoSize = true;
            this.LFornecedor.Location = new System.Drawing.Point(13, 94);
            this.LFornecedor.Name = "LFornecedor";
            this.LFornecedor.Size = new System.Drawing.Size(61, 13);
            this.LFornecedor.TabIndex = 14;
            this.LFornecedor.Text = "Fornecedor";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(271, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // CFornecedor
            // 
            this.CFornecedor.FormattingEnabled = true;
            this.CFornecedor.Location = new System.Drawing.Point(16, 109);
            this.CFornecedor.MaxLength = 50;
            this.CFornecedor.Name = "CFornecedor";
            this.CFornecedor.Size = new System.Drawing.Size(249, 21);
            this.CFornecedor.TabIndex = 15;
            // 
            // LTipo
            // 
            this.LTipo.AutoSize = true;
            this.LTipo.Location = new System.Drawing.Point(207, 138);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(28, 13);
            this.LTipo.TabIndex = 27;
            this.LTipo.Text = "Tipo";
            // 
            // CTipo
            // 
            this.CTipo.FormattingEnabled = true;
            this.CTipo.Items.AddRange(new object[] {
            "Produto",
            "Serviço"});
            this.CTipo.Location = new System.Drawing.Point(212, 153);
            this.CTipo.MaxLength = 20;
            this.CTipo.Name = "CTipo";
            this.CTipo.Size = new System.Drawing.Size(121, 21);
            this.CTipo.TabIndex = 28;
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 251);
            this.Controls.Add(this.CTipo);
            this.Controls.Add(this.LTipo);
            this.Controls.Add(this.CFornecedor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LFornecedor);
            this.Controls.Add(this.MAnoAbrangente);
            this.Controls.Add(this.TEstoqueMin);
            this.Controls.Add(this.TQTD);
            this.Controls.Add(this.TPCusto);
            this.Controls.Add(this.TLucro);
            this.Controls.Add(this.TPVenda);
            this.Controls.Add(this.TFabricante);
            this.Controls.Add(this.TMarca);
            this.Controls.Add(this.TModelo);
            this.Controls.Add(this.TDescricao);
            this.Controls.Add(this.TCBarras);
            this.Controls.Add(this.TCódigo);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BLimpar);
            this.Controls.Add(this.BGravar);
            this.Controls.Add(this.BRemover);
            this.Controls.Add(this.BCarregar);
            this.Controls.Add(this.LEstoqueMin);
            this.Controls.Add(this.LQualidade);
            this.Controls.Add(this.LFabricante);
            this.Controls.Add(this.LMarca);
            this.Controls.Add(this.LAno);
            this.Controls.Add(this.LModelo);
            this.Controls.Add(this.LPVenda);
            this.Controls.Add(this.LLucro);
            this.Controls.Add(this.LPCusto);
            this.Controls.Add(this.LDescricao);
            this.Controls.Add(this.LCBarras);
            this.Controls.Add(this.LCodigo);
            this.Controls.Add(this.PProdutoFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            ((System.ComponentModel.ISupportInitialize)(this.PProdutoFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PProdutoFoto;
        private System.Windows.Forms.Label LCodigo;
        private System.Windows.Forms.Label LCBarras;
        private System.Windows.Forms.Label LDescricao;
        private System.Windows.Forms.Label LPCusto;
        private System.Windows.Forms.Label LLucro;
        private System.Windows.Forms.Label LPVenda;
        private System.Windows.Forms.Label LModelo;
        private System.Windows.Forms.Label LAno;
        private System.Windows.Forms.Label LMarca;
        private System.Windows.Forms.Label LFabricante;
        private System.Windows.Forms.Label LQualidade;
        private System.Windows.Forms.Label LEstoqueMin;
        private System.Windows.Forms.Button BCarregar;
        private System.Windows.Forms.Button BRemover;
        private System.Windows.Forms.Button BGravar;
        private System.Windows.Forms.Button BLimpar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.TextBox TCódigo;
        private System.Windows.Forms.TextBox TCBarras;
        private System.Windows.Forms.TextBox TDescricao;
        private System.Windows.Forms.TextBox TModelo;
        private System.Windows.Forms.TextBox TMarca;
        private System.Windows.Forms.TextBox TFabricante;
        private System.Windows.Forms.TextBox TPVenda;
        private System.Windows.Forms.TextBox TLucro;
        private System.Windows.Forms.TextBox TPCusto;
        private System.Windows.Forms.TextBox TQTD;
        private System.Windows.Forms.TextBox TEstoqueMin;
        private System.Windows.Forms.MaskedTextBox MAnoAbrangente;
        private System.Windows.Forms.Label LFornecedor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CFornecedor;
        private System.Windows.Forms.Label LTipo;
        private System.Windows.Forms.ComboBox CTipo;
    }
}