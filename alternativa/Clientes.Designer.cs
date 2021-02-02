namespace alternativa
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.MCelular = new System.Windows.Forms.MaskedTextBox();
            this.MTelefone = new System.Windows.Forms.MaskedTextBox();
            this.LMail = new System.Windows.Forms.Label();
            this.DTNascimento = new System.Windows.Forms.DateTimePicker();
            this.LCelular = new System.Windows.Forms.Label();
            this.TApelido = new System.Windows.Forms.TextBox();
            this.LTelefone = new System.Windows.Forms.Label();
            this.LDTNas = new System.Windows.Forms.Label();
            this.LNome = new System.Windows.Forms.Label();
            this.TNome = new System.Windows.Forms.TextBox();
            this.BExcluirFoto = new System.Windows.Forms.Button();
            this.BCarregar = new System.Windows.Forms.Button();
            this.PBFoto = new System.Windows.Forms.PictureBox();
            this.TMail = new System.Windows.Forms.TextBox();
            this.LEndereço = new System.Windows.Forms.Label();
            this.TEndereco = new System.Windows.Forms.TextBox();
            this.LNumero = new System.Windows.Forms.Label();
            this.TNumero = new System.Windows.Forms.TextBox();
            this.LApelido = new System.Windows.Forms.Label();
            this.LComplemento = new System.Windows.Forms.Label();
            this.TComplemento = new System.Windows.Forms.TextBox();
            this.LBairro = new System.Windows.Forms.Label();
            this.TBairro = new System.Windows.Forms.TextBox();
            this.TCidade = new System.Windows.Forms.TextBox();
            this.TUf = new System.Windows.Forms.TextBox();
            this.LCEP = new System.Windows.Forms.Label();
            this.MCEP = new System.Windows.Forms.MaskedTextBox();
            this.LCidade = new System.Windows.Forms.Label();
            this.LUF = new System.Windows.Forms.Label();
            this.MRg = new System.Windows.Forms.MaskedTextBox();
            this.MCPF = new System.Windows.Forms.MaskedTextBox();
            this.BGravar = new System.Windows.Forms.Button();
            this.BLimpar = new System.Windows.Forms.Button();
            this.BAlterar = new System.Windows.Forms.Button();
            this.RCPF = new System.Windows.Forms.RadioButton();
            this.RCNPJ = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RIE = new System.Windows.Forms.RadioButton();
            this.RRG = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MCelular
            // 
            this.MCelular.Location = new System.Drawing.Point(462, 89);
            this.MCelular.Mask = "(99) 00000-0000";
            this.MCelular.Name = "MCelular";
            this.MCelular.Size = new System.Drawing.Size(96, 20);
            this.MCelular.TabIndex = 9;
            // 
            // MTelefone
            // 
            this.MTelefone.Location = new System.Drawing.Point(358, 89);
            this.MTelefone.Mask = "(99) 0000-0000";
            this.MTelefone.Name = "MTelefone";
            this.MTelefone.Size = new System.Drawing.Size(98, 20);
            this.MTelefone.TabIndex = 7;
            // 
            // LMail
            // 
            this.LMail.AutoSize = true;
            this.LMail.Location = new System.Drawing.Point(561, 73);
            this.LMail.Name = "LMail";
            this.LMail.Size = new System.Drawing.Size(35, 13);
            this.LMail.TabIndex = 10;
            this.LMail.Text = "E-mail";
            // 
            // DTNascimento
            // 
            this.DTNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTNascimento.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DTNascimento.Location = new System.Drawing.Point(240, 89);
            this.DTNascimento.Name = "DTNascimento";
            this.DTNascimento.Size = new System.Drawing.Size(112, 20);
            this.DTNascimento.TabIndex = 5;
            this.DTNascimento.Value = new System.DateTime(2019, 2, 14, 0, 0, 0, 0);
            // 
            // LCelular
            // 
            this.LCelular.AutoSize = true;
            this.LCelular.Location = new System.Drawing.Point(459, 73);
            this.LCelular.Name = "LCelular";
            this.LCelular.Size = new System.Drawing.Size(39, 13);
            this.LCelular.TabIndex = 8;
            this.LCelular.Text = "Celular";
            // 
            // TApelido
            // 
            this.TApelido.Location = new System.Drawing.Point(636, 48);
            this.TApelido.Name = "TApelido";
            this.TApelido.Size = new System.Drawing.Size(152, 20);
            this.TApelido.TabIndex = 3;
            // 
            // LTelefone
            // 
            this.LTelefone.AutoSize = true;
            this.LTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefone.Location = new System.Drawing.Point(355, 73);
            this.LTelefone.Name = "LTelefone";
            this.LTelefone.Size = new System.Drawing.Size(57, 13);
            this.LTelefone.TabIndex = 6;
            this.LTelefone.Text = "Telefone";
            // 
            // LDTNas
            // 
            this.LDTNas.AutoSize = true;
            this.LDTNas.Location = new System.Drawing.Point(237, 73);
            this.LDTNas.Name = "LDTNas";
            this.LDTNas.Size = new System.Drawing.Size(104, 13);
            this.LDTNas.TabIndex = 4;
            this.LDTNas.Text = "Data de Nascimento";
            // 
            // LNome
            // 
            this.LNome.AutoSize = true;
            this.LNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNome.Location = new System.Drawing.Point(237, 32);
            this.LNome.Name = "LNome";
            this.LNome.Size = new System.Drawing.Size(39, 13);
            this.LNome.TabIndex = 0;
            this.LNome.Text = "Nome";
            // 
            // TNome
            // 
            this.TNome.Location = new System.Drawing.Point(240, 48);
            this.TNome.Name = "TNome";
            this.TNome.Size = new System.Drawing.Size(387, 20);
            this.TNome.TabIndex = 1;
            // 
            // BExcluirFoto
            // 
            this.BExcluirFoto.Location = new System.Drawing.Point(114, 207);
            this.BExcluirFoto.Name = "BExcluirFoto";
            this.BExcluirFoto.Size = new System.Drawing.Size(60, 23);
            this.BExcluirFoto.TabIndex = 30;
            this.BExcluirFoto.Text = "&Excluir";
            this.BExcluirFoto.UseVisualStyleBackColor = true;
            this.BExcluirFoto.Click += new System.EventHandler(this.BExcluirFoto_Click);
            // 
            // BCarregar
            // 
            this.BCarregar.Location = new System.Drawing.Point(48, 207);
            this.BCarregar.Name = "BCarregar";
            this.BCarregar.Size = new System.Drawing.Size(60, 23);
            this.BCarregar.TabIndex = 31;
            this.BCarregar.Text = "&Carregar";
            this.BCarregar.UseVisualStyleBackColor = true;
            this.BCarregar.Click += new System.EventHandler(this.BCarregar_Click);
            // 
            // PBFoto
            // 
            this.PBFoto.Image = global::alternativa.Properties.Resources.perfil;
            this.PBFoto.Location = new System.Drawing.Point(12, 12);
            this.PBFoto.Name = "PBFoto";
            this.PBFoto.Size = new System.Drawing.Size(190, 189);
            this.PBFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBFoto.TabIndex = 16;
            this.PBFoto.TabStop = false;
            // 
            // TMail
            // 
            this.TMail.Location = new System.Drawing.Point(564, 89);
            this.TMail.Name = "TMail";
            this.TMail.Size = new System.Drawing.Size(224, 20);
            this.TMail.TabIndex = 11;
            // 
            // LEndereço
            // 
            this.LEndereço.AutoSize = true;
            this.LEndereço.Location = new System.Drawing.Point(465, 114);
            this.LEndereço.Name = "LEndereço";
            this.LEndereço.Size = new System.Drawing.Size(53, 13);
            this.LEndereço.TabIndex = 16;
            this.LEndereço.Text = "Endereço";
            // 
            // TEndereco
            // 
            this.TEndereco.Location = new System.Drawing.Point(468, 130);
            this.TEndereco.Name = "TEndereco";
            this.TEndereco.Size = new System.Drawing.Size(255, 20);
            this.TEndereco.TabIndex = 17;
            // 
            // LNumero
            // 
            this.LNumero.AutoSize = true;
            this.LNumero.Location = new System.Drawing.Point(726, 114);
            this.LNumero.Name = "LNumero";
            this.LNumero.Size = new System.Drawing.Size(44, 13);
            this.LNumero.TabIndex = 18;
            this.LNumero.Text = "Número";
            // 
            // TNumero
            // 
            this.TNumero.Location = new System.Drawing.Point(729, 130);
            this.TNumero.Name = "TNumero";
            this.TNumero.Size = new System.Drawing.Size(59, 20);
            this.TNumero.TabIndex = 19;
            this.TNumero.Text = "0";
            this.TNumero.Leave += new System.EventHandler(this.TNumero_Leave);
            // 
            // LApelido
            // 
            this.LApelido.AutoSize = true;
            this.LApelido.Location = new System.Drawing.Point(633, 32);
            this.LApelido.Name = "LApelido";
            this.LApelido.Size = new System.Drawing.Size(42, 13);
            this.LApelido.TabIndex = 2;
            this.LApelido.Text = "Apelido";
            // 
            // LComplemento
            // 
            this.LComplemento.AutoSize = true;
            this.LComplemento.Location = new System.Drawing.Point(239, 155);
            this.LComplemento.Name = "LComplemento";
            this.LComplemento.Size = new System.Drawing.Size(71, 13);
            this.LComplemento.TabIndex = 20;
            this.LComplemento.Text = "Complemento";
            // 
            // TComplemento
            // 
            this.TComplemento.Location = new System.Drawing.Point(240, 171);
            this.TComplemento.Name = "TComplemento";
            this.TComplemento.Size = new System.Drawing.Size(101, 20);
            this.TComplemento.TabIndex = 21;
            // 
            // LBairro
            // 
            this.LBairro.AutoSize = true;
            this.LBairro.Location = new System.Drawing.Point(344, 155);
            this.LBairro.Name = "LBairro";
            this.LBairro.Size = new System.Drawing.Size(34, 13);
            this.LBairro.TabIndex = 22;
            this.LBairro.Text = "Bairro";
            // 
            // TBairro
            // 
            this.TBairro.Location = new System.Drawing.Point(347, 171);
            this.TBairro.Name = "TBairro";
            this.TBairro.Size = new System.Drawing.Size(131, 20);
            this.TBairro.TabIndex = 23;
            // 
            // TCidade
            // 
            this.TCidade.Location = new System.Drawing.Point(564, 171);
            this.TCidade.Name = "TCidade";
            this.TCidade.Size = new System.Drawing.Size(173, 20);
            this.TCidade.TabIndex = 27;
            // 
            // TUf
            // 
            this.TUf.Location = new System.Drawing.Point(743, 171);
            this.TUf.Name = "TUf";
            this.TUf.Size = new System.Drawing.Size(45, 20);
            this.TUf.TabIndex = 29;
            // 
            // LCEP
            // 
            this.LCEP.AutoSize = true;
            this.LCEP.Location = new System.Drawing.Point(481, 155);
            this.LCEP.Name = "LCEP";
            this.LCEP.Size = new System.Drawing.Size(28, 13);
            this.LCEP.TabIndex = 24;
            this.LCEP.Text = "CEP";
            // 
            // MCEP
            // 
            this.MCEP.Location = new System.Drawing.Point(484, 171);
            this.MCEP.Mask = "00000-999";
            this.MCEP.Name = "MCEP";
            this.MCEP.Size = new System.Drawing.Size(74, 20);
            this.MCEP.TabIndex = 25;
            // 
            // LCidade
            // 
            this.LCidade.AutoSize = true;
            this.LCidade.Location = new System.Drawing.Point(561, 155);
            this.LCidade.Name = "LCidade";
            this.LCidade.Size = new System.Drawing.Size(40, 13);
            this.LCidade.TabIndex = 26;
            this.LCidade.Text = "Cidade";
            // 
            // LUF
            // 
            this.LUF.AutoSize = true;
            this.LUF.Location = new System.Drawing.Point(740, 155);
            this.LUF.Name = "LUF";
            this.LUF.Size = new System.Drawing.Size(21, 13);
            this.LUF.TabIndex = 28;
            this.LUF.Text = "UF";
            // 
            // MRg
            // 
            this.MRg.Location = new System.Drawing.Point(240, 130);
            this.MRg.Mask = "00.000.000-0";
            this.MRg.Name = "MRg";
            this.MRg.Size = new System.Drawing.Size(116, 20);
            this.MRg.TabIndex = 13;
            // 
            // MCPF
            // 
            this.MCPF.Location = new System.Drawing.Point(362, 130);
            this.MCPF.Mask = "000.000.000-00";
            this.MCPF.Name = "MCPF";
            this.MCPF.Size = new System.Drawing.Size(100, 20);
            this.MCPF.TabIndex = 15;
            // 
            // BGravar
            // 
            this.BGravar.Location = new System.Drawing.Point(566, 229);
            this.BGravar.Name = "BGravar";
            this.BGravar.Size = new System.Drawing.Size(70, 25);
            this.BGravar.TabIndex = 35;
            this.BGravar.Text = "&Gravar";
            this.BGravar.UseVisualStyleBackColor = true;
            this.BGravar.Click += new System.EventHandler(this.BGravar_Click);
            // 
            // BLimpar
            // 
            this.BLimpar.Location = new System.Drawing.Point(642, 229);
            this.BLimpar.Name = "BLimpar";
            this.BLimpar.Size = new System.Drawing.Size(70, 25);
            this.BLimpar.TabIndex = 34;
            this.BLimpar.Text = "&Limpar";
            this.BLimpar.UseVisualStyleBackColor = true;
            this.BLimpar.Click += new System.EventHandler(this.BLimpar_Click);
            // 
            // BAlterar
            // 
            this.BAlterar.Enabled = false;
            this.BAlterar.Location = new System.Drawing.Point(718, 229);
            this.BAlterar.Name = "BAlterar";
            this.BAlterar.Size = new System.Drawing.Size(70, 25);
            this.BAlterar.TabIndex = 33;
            this.BAlterar.Text = "&Alterar";
            this.BAlterar.UseVisualStyleBackColor = true;
            this.BAlterar.Click += new System.EventHandler(this.BAlterar_Click);
            // 
            // RCPF
            // 
            this.RCPF.AutoSize = true;
            this.RCPF.Checked = true;
            this.RCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCPF.Location = new System.Drawing.Point(362, 112);
            this.RCPF.Name = "RCPF";
            this.RCPF.Size = new System.Drawing.Size(48, 17);
            this.RCPF.TabIndex = 36;
            this.RCPF.TabStop = true;
            this.RCPF.Text = "CPF";
            this.RCPF.UseVisualStyleBackColor = true;
            this.RCPF.CheckedChanged += new System.EventHandler(this.RCPF_CheckedChanged);
            // 
            // RCNPJ
            // 
            this.RCNPJ.AutoSize = true;
            this.RCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RCNPJ.Location = new System.Drawing.Point(411, 112);
            this.RCNPJ.Name = "RCNPJ";
            this.RCNPJ.Size = new System.Drawing.Size(56, 17);
            this.RCNPJ.TabIndex = 37;
            this.RCNPJ.Text = "CNPJ";
            this.RCNPJ.UseVisualStyleBackColor = true;
            this.RCNPJ.CheckedChanged += new System.EventHandler(this.RCNPJ_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.RIE);
            this.groupBox1.Controls.Add(this.RRG);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(240, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 21);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // RIE
            // 
            this.RIE.AutoSize = true;
            this.RIE.Location = new System.Drawing.Point(51, 4);
            this.RIE.Name = "RIE";
            this.RIE.Size = new System.Drawing.Size(35, 17);
            this.RIE.TabIndex = 40;
            this.RIE.Text = "IE";
            this.RIE.UseVisualStyleBackColor = true;
            this.RIE.CheckedChanged += new System.EventHandler(this.RIE_CheckedChanged);
            // 
            // RRG
            // 
            this.RRG.AutoSize = true;
            this.RRG.Checked = true;
            this.RRG.Location = new System.Drawing.Point(0, 4);
            this.RRG.Name = "RRG";
            this.RRG.Size = new System.Drawing.Size(41, 17);
            this.RRG.TabIndex = 39;
            this.RRG.TabStop = true;
            this.RRG.Text = "RG";
            this.RRG.UseVisualStyleBackColor = true;
            this.RRG.CheckedChanged += new System.EventHandler(this.RRG_CheckedChanged);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 267);
            this.Controls.Add(this.DTNascimento);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RCNPJ);
            this.Controls.Add(this.RCPF);
            this.Controls.Add(this.BAlterar);
            this.Controls.Add(this.BLimpar);
            this.Controls.Add(this.BGravar);
            this.Controls.Add(this.MCPF);
            this.Controls.Add(this.MRg);
            this.Controls.Add(this.LUF);
            this.Controls.Add(this.LCidade);
            this.Controls.Add(this.MCEP);
            this.Controls.Add(this.LCEP);
            this.Controls.Add(this.TUf);
            this.Controls.Add(this.TCidade);
            this.Controls.Add(this.TBairro);
            this.Controls.Add(this.LBairro);
            this.Controls.Add(this.TComplemento);
            this.Controls.Add(this.LComplemento);
            this.Controls.Add(this.TNumero);
            this.Controls.Add(this.LNumero);
            this.Controls.Add(this.TEndereco);
            this.Controls.Add(this.LEndereço);
            this.Controls.Add(this.TMail);
            this.Controls.Add(this.MCelular);
            this.Controls.Add(this.MTelefone);
            this.Controls.Add(this.LMail);
            this.Controls.Add(this.LCelular);
            this.Controls.Add(this.TApelido);
            this.Controls.Add(this.LApelido);
            this.Controls.Add(this.LTelefone);
            this.Controls.Add(this.LDTNas);
            this.Controls.Add(this.LNome);
            this.Controls.Add(this.TNome);
            this.Controls.Add(this.BExcluirFoto);
            this.Controls.Add(this.BCarregar);
            this.Controls.Add(this.PBFoto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.PBFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox MCelular;
        private System.Windows.Forms.MaskedTextBox MTelefone;
        private System.Windows.Forms.Label LMail;
        private System.Windows.Forms.DateTimePicker DTNascimento;
        private System.Windows.Forms.Label LCelular;
        private System.Windows.Forms.TextBox TApelido;
        private System.Windows.Forms.Label LTelefone;
        private System.Windows.Forms.Label LDTNas;
        private System.Windows.Forms.Label LNome;
        private System.Windows.Forms.TextBox TNome;
        private System.Windows.Forms.Button BExcluirFoto;
        private System.Windows.Forms.Button BCarregar;
        private System.Windows.Forms.PictureBox PBFoto;
        private System.Windows.Forms.TextBox TMail;
        private System.Windows.Forms.Label LEndereço;
        private System.Windows.Forms.TextBox TEndereco;
        private System.Windows.Forms.Label LNumero;
        private System.Windows.Forms.TextBox TNumero;
        private System.Windows.Forms.Label LApelido;
        private System.Windows.Forms.Label LComplemento;
        private System.Windows.Forms.TextBox TComplemento;
        private System.Windows.Forms.Label LBairro;
        private System.Windows.Forms.TextBox TBairro;
        private System.Windows.Forms.TextBox TCidade;
        private System.Windows.Forms.TextBox TUf;
        private System.Windows.Forms.Label LCEP;
        private System.Windows.Forms.MaskedTextBox MCEP;
        private System.Windows.Forms.Label LCidade;
        private System.Windows.Forms.Label LUF;
        private System.Windows.Forms.MaskedTextBox MRg;
        private System.Windows.Forms.MaskedTextBox MCPF;
        private System.Windows.Forms.Button BGravar;
        private System.Windows.Forms.Button BLimpar;
        private System.Windows.Forms.Button BAlterar;
        private System.Windows.Forms.RadioButton RCPF;
        private System.Windows.Forms.RadioButton RCNPJ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RIE;
        private System.Windows.Forms.RadioButton RRG;
    }
}