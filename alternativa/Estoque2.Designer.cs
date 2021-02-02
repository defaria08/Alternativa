namespace alternativa
{
    partial class Estoque2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque2));
            this.RAdicionar = new System.Windows.Forms.RadioButton();
            this.RRemover = new System.Windows.Forms.RadioButton();
            this.BMais = new System.Windows.Forms.Button();
            this.BMenos = new System.Windows.Forms.Button();
            this.TQTDEN = new System.Windows.Forms.TextBox();
            this.BGravar = new System.Windows.Forms.Button();
            this.BCamcelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RAdicionar
            // 
            this.RAdicionar.AutoSize = true;
            this.RAdicionar.Location = new System.Drawing.Point(38, 12);
            this.RAdicionar.Name = "RAdicionar";
            this.RAdicionar.Size = new System.Drawing.Size(69, 17);
            this.RAdicionar.TabIndex = 0;
            this.RAdicionar.TabStop = true;
            this.RAdicionar.Text = "Adicionar";
            this.RAdicionar.UseVisualStyleBackColor = true;
            // 
            // RRemover
            // 
            this.RRemover.AutoSize = true;
            this.RRemover.Location = new System.Drawing.Point(126, 12);
            this.RRemover.Name = "RRemover";
            this.RRemover.Size = new System.Drawing.Size(68, 17);
            this.RRemover.TabIndex = 1;
            this.RRemover.TabStop = true;
            this.RRemover.Text = "Remover";
            this.RRemover.UseVisualStyleBackColor = true;
            // 
            // BMais
            // 
            this.BMais.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BMais.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMais.Location = new System.Drawing.Point(167, 55);
            this.BMais.Name = "BMais";
            this.BMais.Size = new System.Drawing.Size(39, 23);
            this.BMais.TabIndex = 4;
            this.BMais.Text = "+";
            this.BMais.UseVisualStyleBackColor = true;
            this.BMais.Click += new System.EventHandler(this.BMais_Click);
            // 
            // BMenos
            // 
            this.BMenos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BMenos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMenos.Location = new System.Drawing.Point(12, 55);
            this.BMenos.Name = "BMenos";
            this.BMenos.Size = new System.Drawing.Size(39, 23);
            this.BMenos.TabIndex = 2;
            this.BMenos.Text = "-";
            this.BMenos.UseVisualStyleBackColor = true;
            this.BMenos.Click += new System.EventHandler(this.BMenos_Click);
            // 
            // TQTDEN
            // 
            this.TQTDEN.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TQTDEN.ForeColor = System.Drawing.Color.Navy;
            this.TQTDEN.Location = new System.Drawing.Point(57, 45);
            this.TQTDEN.Multiline = true;
            this.TQTDEN.Name = "TQTDEN";
            this.TQTDEN.Size = new System.Drawing.Size(104, 45);
            this.TQTDEN.TabIndex = 3;
            this.TQTDEN.Text = "0";
            this.TQTDEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TQTDEN.Leave += new System.EventHandler(this.TQTDEN_Leave);
            // 
            // BGravar
            // 
            this.BGravar.Location = new System.Drawing.Point(32, 116);
            this.BGravar.Name = "BGravar";
            this.BGravar.Size = new System.Drawing.Size(75, 23);
            this.BGravar.TabIndex = 5;
            this.BGravar.Text = "&Gravar";
            this.BGravar.UseVisualStyleBackColor = true;
            this.BGravar.Click += new System.EventHandler(this.BGravar_Click);
            // 
            // BCamcelar
            // 
            this.BCamcelar.Location = new System.Drawing.Point(119, 116);
            this.BCamcelar.Name = "BCamcelar";
            this.BCamcelar.Size = new System.Drawing.Size(75, 23);
            this.BCamcelar.TabIndex = 6;
            this.BCamcelar.Text = " &Cancelar";
            this.BCamcelar.UseVisualStyleBackColor = true;
            this.BCamcelar.Click += new System.EventHandler(this.BCamcelar_Click);
            // 
            // Estoque2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 153);
            this.Controls.Add(this.BCamcelar);
            this.Controls.Add(this.BGravar);
            this.Controls.Add(this.TQTDEN);
            this.Controls.Add(this.BMenos);
            this.Controls.Add(this.BMais);
            this.Controls.Add(this.RRemover);
            this.Controls.Add(this.RAdicionar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Estoque2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RAdicionar;
        private System.Windows.Forms.RadioButton RRemover;
        private System.Windows.Forms.Button BMais;
        private System.Windows.Forms.Button BMenos;
        private System.Windows.Forms.TextBox TQTDEN;
        private System.Windows.Forms.Button BGravar;
        private System.Windows.Forms.Button BCamcelar;
    }
}