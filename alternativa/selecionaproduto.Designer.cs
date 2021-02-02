namespace alternativa
{
    partial class selecionaproduto
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
            System.Windows.Forms.ColumnHeader Produto;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selecionaproduto));
            this.listadeproduto = new System.Windows.Forms.ListView();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fabricante = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Modelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Agrangencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Produto
            // 
            Produto.Text = "Produto";
            Produto.Width = 186;
            // 
            // listadeproduto
            // 
            this.listadeproduto.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            Produto,
            this.Fabricante,
            this.Modelo,
            this.Valor,
            this.Agrangencia});
            this.listadeproduto.FullRowSelect = true;
            this.listadeproduto.Location = new System.Drawing.Point(12, 12);
            this.listadeproduto.Name = "listadeproduto";
            this.listadeproduto.Size = new System.Drawing.Size(639, 190);
            this.listadeproduto.TabIndex = 0;
            this.listadeproduto.UseCompatibleStateImageBehavior = false;
            this.listadeproduto.View = System.Windows.Forms.View.Details;
            this.listadeproduto.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listadeproduto_MouseDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.Text = "Código";
            this.Codigo.Width = 127;
            // 
            // Fabricante
            // 
            this.Fabricante.Text = "Fabricante";
            this.Fabricante.Width = 84;
            // 
            // Modelo
            // 
            this.Modelo.Text = "Modelo";
            this.Modelo.Width = 66;
            // 
            // Valor
            // 
            this.Valor.Text = "Valor";
            // 
            // Agrangencia
            // 
            this.Agrangencia.Text = "Abrangencia";
            this.Agrangencia.Width = 108;
            // 
            // selecionaproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 214);
            this.Controls.Add(this.listadeproduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "selecionaproduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listadeproduto;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Fabricante;
        private System.Windows.Forms.ColumnHeader Modelo;
        private System.Windows.Forms.ColumnHeader Valor;
        private System.Windows.Forms.ColumnHeader Agrangencia;
    }
}