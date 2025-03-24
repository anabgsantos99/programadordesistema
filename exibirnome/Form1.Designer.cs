
namespace exibirnome
{
    partial class frmExibirNome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtExibirNome = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExibirNome
            // 
            this.txtExibirNome.Location = new System.Drawing.Point(46, 84);
            this.txtExibirNome.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtExibirNome.Name = "txtExibirNome";
            this.txtExibirNome.Size = new System.Drawing.Size(353, 31);
            this.txtExibirNome.TabIndex = 0;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(125, 141);
            this.btnExibir.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(196, 44);
            this.btnExibir.TabIndex = 1;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // frmExibirNome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 274);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtExibirNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmExibirNome";
            this.Text = "Exibir Nome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExibirNome;
        private System.Windows.Forms.Button btnExibir;
    }
}

