
namespace calculodeidade
{
    partial class frmCalculoIdade
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAnoNasc = new System.Windows.Forms.Label();
            this.txtAnoNasc = new System.Windows.Forms.TextBox();
            this.lblAnoAtual = new System.Windows.Forms.Label();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepPink;
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.lblIdade);
            this.panel1.Controls.Add(this.txtAnoAtual);
            this.panel1.Controls.Add(this.lblAnoAtual);
            this.panel1.Controls.Add(this.txtAnoNasc);
            this.panel1.Controls.Add(this.lblAnoNasc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 450);
            this.panel1.TabIndex = 0;
            // 
            // lblAnoNasc
            // 
            this.lblAnoNasc.AutoSize = true;
            this.lblAnoNasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoNasc.ForeColor = System.Drawing.Color.White;
            this.lblAnoNasc.Location = new System.Drawing.Point(287, 56);
            this.lblAnoNasc.Name = "lblAnoNasc";
            this.lblAnoNasc.Size = new System.Drawing.Size(177, 24);
            this.lblAnoNasc.TabIndex = 0;
            this.lblAnoNasc.Text = "Ano de Nascimento";
            // 
            // txtAnoNasc
            // 
            this.txtAnoNasc.Location = new System.Drawing.Point(307, 94);
            this.txtAnoNasc.Name = "txtAnoNasc";
            this.txtAnoNasc.Size = new System.Drawing.Size(134, 20);
            this.txtAnoNasc.TabIndex = 1;
            this.txtAnoNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAnoAtual
            // 
            this.lblAnoAtual.AutoSize = true;
            this.lblAnoAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnoAtual.ForeColor = System.Drawing.Color.White;
            this.lblAnoAtual.Location = new System.Drawing.Point(333, 163);
            this.lblAnoAtual.Name = "lblAnoAtual";
            this.lblAnoAtual.Size = new System.Drawing.Size(92, 24);
            this.lblAnoAtual.TabIndex = 2;
            this.lblAnoAtual.Text = "Ano Atual";
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.Location = new System.Drawing.Point(307, 206);
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(134, 20);
            this.txtAnoAtual.TabIndex = 3;
            this.txtAnoAtual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.ForeColor = System.Drawing.Color.White;
            this.lblIdade.Location = new System.Drawing.Point(361, 289);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(26, 29);
            this.lblIdade.TabIndex = 4;
            this.lblIdade.Text = "0";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(307, 346);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(134, 37);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // frmCalculoIdade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmCalculoIdade";
            this.Text = "Cálculo de Idade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtAnoAtual;
        private System.Windows.Forms.Label lblAnoAtual;
        private System.Windows.Forms.TextBox txtAnoNasc;
        private System.Windows.Forms.Label lblAnoNasc;
    }
}

