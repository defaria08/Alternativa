namespace alternativa
{
    partial class RelatorioFinanceiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatorioFinanceiro));
            this.RMEnsal = new System.Windows.Forms.RadioButton();
            this.RPeriodico = new System.Windows.Forms.RadioButton();
            this.Rdiario = new System.Windows.Forms.RadioButton();
            this.DTInicio = new System.Windows.Forms.DateTimePicker();
            this.DTFim = new System.Windows.Forms.DateTimePicker();
            this.BGerar = new System.Windows.Forms.Button();
            this.BCancelar = new System.Windows.Forms.Button();
            this.LTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RMEnsal
            // 
            this.RMEnsal.AutoSize = true;
            this.RMEnsal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.RMEnsal.Location = new System.Drawing.Point(12, 12);
            this.RMEnsal.Name = "RMEnsal";
            this.RMEnsal.Size = new System.Drawing.Size(70, 21);
            this.RMEnsal.TabIndex = 0;
            this.RMEnsal.TabStop = true;
            this.RMEnsal.Text = "Mensal";
            this.RMEnsal.UseVisualStyleBackColor = true;
            this.RMEnsal.CheckedChanged += new System.EventHandler(this.RMEnsal_CheckedChanged);
            // 
            // RPeriodico
            // 
            this.RPeriodico.AutoSize = true;
            this.RPeriodico.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.RPeriodico.Location = new System.Drawing.Point(118, 12);
            this.RPeriodico.Name = "RPeriodico";
            this.RPeriodico.Size = new System.Drawing.Size(87, 21);
            this.RPeriodico.TabIndex = 1;
            this.RPeriodico.TabStop = true;
            this.RPeriodico.Text = "Periódico";
            this.RPeriodico.UseVisualStyleBackColor = true;
            this.RPeriodico.CheckedChanged += new System.EventHandler(this.RPeriodico_CheckedChanged);
            // 
            // Rdiario
            // 
            this.Rdiario.AutoSize = true;
            this.Rdiario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdiario.Location = new System.Drawing.Point(241, 12);
            this.Rdiario.Name = "Rdiario";
            this.Rdiario.Size = new System.Drawing.Size(64, 21);
            this.Rdiario.TabIndex = 2;
            this.Rdiario.TabStop = true;
            this.Rdiario.Text = "Diário";
            this.Rdiario.UseVisualStyleBackColor = true;
            this.Rdiario.CheckedChanged += new System.EventHandler(this.Rdiario_CheckedChanged);
            // 
            // DTInicio
            // 
            this.DTInicio.CustomFormat = "";
            this.DTInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTInicio.Location = new System.Drawing.Point(129, 58);
            this.DTInicio.Name = "DTInicio";
            this.DTInicio.Size = new System.Drawing.Size(85, 20);
            this.DTInicio.TabIndex = 3;
            // 
            // DTFim
            // 
            this.DTFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFim.Location = new System.Drawing.Point(220, 58);
            this.DTFim.Name = "DTFim";
            this.DTFim.Size = new System.Drawing.Size(85, 20);
            this.DTFim.TabIndex = 4;
            // 
            // BGerar
            // 
            this.BGerar.Location = new System.Drawing.Point(86, 109);
            this.BGerar.Name = "BGerar";
            this.BGerar.Size = new System.Drawing.Size(75, 23);
            this.BGerar.TabIndex = 5;
            this.BGerar.Text = "&Gerar";
            this.BGerar.UseVisualStyleBackColor = true;
            this.BGerar.Click += new System.EventHandler(this.BGerar_Click);
            // 
            // BCancelar
            // 
            this.BCancelar.Location = new System.Drawing.Point(167, 109);
            this.BCancelar.Name = "BCancelar";
            this.BCancelar.Size = new System.Drawing.Size(75, 23);
            this.BCancelar.TabIndex = 6;
            this.BCancelar.Text = "&Cancelar";
            this.BCancelar.UseVisualStyleBackColor = true;
            this.BCancelar.Click += new System.EventHandler(this.BCancelar_Click);
            // 
            // LTipo
            // 
            this.LTipo.AutoSize = true;
            this.LTipo.Location = new System.Drawing.Point(8, 63);
            this.LTipo.Name = "LTipo";
            this.LTipo.Size = new System.Drawing.Size(104, 13);
            this.LTipo.TabIndex = 7;
            this.LTipo.Text = "Selecione o Período";
            // 
            // RelatorioFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 144);
            this.Controls.Add(this.LTipo);
            this.Controls.Add(this.BCancelar);
            this.Controls.Add(this.BGerar);
            this.Controls.Add(this.DTFim);
            this.Controls.Add(this.DTInicio);
            this.Controls.Add(this.Rdiario);
            this.Controls.Add(this.RPeriodico);
            this.Controls.Add(this.RMEnsal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatorioFinanceiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Financeiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RMEnsal;
        private System.Windows.Forms.RadioButton RPeriodico;
        private System.Windows.Forms.RadioButton Rdiario;
        private System.Windows.Forms.DateTimePicker DTInicio;
        private System.Windows.Forms.DateTimePicker DTFim;
        private System.Windows.Forms.Button BGerar;
        private System.Windows.Forms.Button BCancelar;
        private System.Windows.Forms.Label LTipo;
    }
}