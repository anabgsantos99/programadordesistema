
namespace alertas
{
    partial class frmAlertas
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
            this.lblTítulo = new System.Windows.Forms.Label();
            this.btnAlertaSimples = new System.Windows.Forms.Button();
            this.btnAlertaRobusto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTítulo
            // 
            this.lblTítulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTítulo.AutoSize = true;
            this.lblTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTítulo.Location = new System.Drawing.Point(234, 42);
            this.lblTítulo.Name = "lblTítulo";
            this.lblTítulo.Size = new System.Drawing.Size(294, 31);
            this.lblTítulo.TabIndex = 0;
            this.lblTítulo.Text = "Teste os alertas abaixo";
            this.lblTítulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAlertaSimples
            // 
            this.btnAlertaSimples.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlertaSimples.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(103)))), ((int)(((byte)(86)))));
            this.btnAlertaSimples.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaSimples.ForeColor = System.Drawing.Color.White;
            this.btnAlertaSimples.Location = new System.Drawing.Point(293, 95);
            this.btnAlertaSimples.Name = "btnAlertaSimples";
            this.btnAlertaSimples.Size = new System.Drawing.Size(161, 45);
            this.btnAlertaSimples.TabIndex = 1;
            this.btnAlertaSimples.Text = "Alerta Simples";
            this.btnAlertaSimples.UseVisualStyleBackColor = false;
            this.btnAlertaSimples.Click += new System.EventHandler(this.btnAlertaSimples_Click);
            // 
            // btnAlertaRobusto
            // 
            this.btnAlertaRobusto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlertaRobusto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlertaRobusto.FlatAppearance.BorderSize = 0;
            this.btnAlertaRobusto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAlertaRobusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlertaRobusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAlertaRobusto.Location = new System.Drawing.Point(293, 178);
            this.btnAlertaRobusto.Name = "btnAlertaRobusto";
            this.btnAlertaRobusto.Size = new System.Drawing.Size(161, 41);
            this.btnAlertaRobusto.TabIndex = 2;
            this.btnAlertaRobusto.Text = "Alerta Robusto";
            this.btnAlertaRobusto.UseVisualStyleBackColor = false;
            this.btnAlertaRobusto.Click += new System.EventHandler(this.btnAlertaRobusto_Click);
            // 
            // frmAlertas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAlertaRobusto);
            this.Controls.Add(this.btnAlertaSimples);
            this.Controls.Add(this.lblTítulo);
            this.Name = "frmAlertas";
            this.Text = "Alertas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTítulo;
        private System.Windows.Forms.Button btnAlertaSimples;
        private System.Windows.Forms.Button btnAlertaRobusto;
    }
}

