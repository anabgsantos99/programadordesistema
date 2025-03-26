
namespace picturebox
{
    partial class frmPictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPictureBox));
            this.pbComputador = new System.Windows.Forms.PictureBox();
            this.pbImagemImportada = new System.Windows.Forms.PictureBox();
            this.pbCidade = new System.Windows.Forms.PictureBox();
            this.btnVerImagem = new System.Windows.Forms.Button();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.btnAnexarImagem = new System.Windows.Forms.Button();
            this.pbAnexarImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemImportada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).BeginInit();
            this.panelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pbComputador
            // 
            this.pbComputador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbComputador.Image = ((System.Drawing.Image)(resources.GetObject("pbComputador.Image")));
            this.pbComputador.Location = new System.Drawing.Point(12, 12);
            this.pbComputador.Name = "pbComputador";
            this.pbComputador.Size = new System.Drawing.Size(430, 128);
            this.pbComputador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbComputador.TabIndex = 0;
            this.pbComputador.TabStop = false;
            // 
            // pbImagemImportada
            // 
            this.pbImagemImportada.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImagemImportada.Image = global::picturebox.Properties.Resources.computador;
            this.pbImagemImportada.Location = new System.Drawing.Point(12, 146);
            this.pbImagemImportada.Name = "pbImagemImportada";
            this.pbImagemImportada.Size = new System.Drawing.Size(430, 173);
            this.pbImagemImportada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagemImportada.TabIndex = 1;
            this.pbImagemImportada.TabStop = false;
            // 
            // pbCidade
            // 
            this.pbCidade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCidade.Location = new System.Drawing.Point(12, 325);
            this.pbCidade.Name = "pbCidade";
            this.pbCidade.Size = new System.Drawing.Size(430, 138);
            this.pbCidade.TabIndex = 2;
            this.pbCidade.TabStop = false;
            // 
            // btnVerImagem
            // 
            this.btnVerImagem.BackColor = System.Drawing.Color.Maroon;
            this.btnVerImagem.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerImagem.ForeColor = System.Drawing.Color.Cyan;
            this.btnVerImagem.Location = new System.Drawing.Point(494, 352);
            this.btnVerImagem.Name = "btnVerImagem";
            this.btnVerImagem.Size = new System.Drawing.Size(126, 69);
            this.btnVerImagem.TabIndex = 3;
            this.btnVerImagem.Text = "Ver Imagem";
            this.btnVerImagem.UseVisualStyleBackColor = false;
            this.btnVerImagem.Click += new System.EventHandler(this.btnVerImagem_Click);
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.Color.LightBlue;
            this.panelFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFundo.Controls.Add(this.btnAnexarImagem);
            this.panelFundo.Controls.Add(this.pbAnexarImagem);
            this.panelFundo.Location = new System.Drawing.Point(473, 12);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(242, 307);
            this.panelFundo.TabIndex = 4;
            // 
            // btnAnexarImagem
            // 
            this.btnAnexarImagem.BackColor = System.Drawing.Color.Cyan;
            this.btnAnexarImagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnexarImagem.ForeColor = System.Drawing.Color.Maroon;
            this.btnAnexarImagem.Location = new System.Drawing.Point(49, 220);
            this.btnAnexarImagem.Name = "btnAnexarImagem";
            this.btnAnexarImagem.Size = new System.Drawing.Size(131, 69);
            this.btnAnexarImagem.TabIndex = 1;
            this.btnAnexarImagem.Text = "Anexar Imagem";
            this.btnAnexarImagem.UseVisualStyleBackColor = false;
            this.btnAnexarImagem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAnexarImagem_MouseClick);
            // 
            // pbAnexarImagem
            // 
            this.pbAnexarImagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAnexarImagem.Location = new System.Drawing.Point(49, 19);
            this.pbAnexarImagem.Name = "pbAnexarImagem";
            this.pbAnexarImagem.Size = new System.Drawing.Size(131, 195);
            this.pbAnexarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbAnexarImagem.TabIndex = 0;
            this.pbAnexarImagem.TabStop = false;
            // 
            // frmPictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(727, 475);
            this.Controls.Add(this.panelFundo);
            this.Controls.Add(this.btnVerImagem);
            this.Controls.Add(this.pbCidade);
            this.Controls.Add(this.pbImagemImportada);
            this.Controls.Add(this.pbComputador);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmPictureBox";
            this.Text = "Picture Box";
            ((System.ComponentModel.ISupportInitialize)(this.pbComputador)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemImportada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCidade)).EndInit();
            this.panelFundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnexarImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbComputador;
        private System.Windows.Forms.PictureBox pbImagemImportada;
        private System.Windows.Forms.PictureBox pbCidade;
        private System.Windows.Forms.Button btnVerImagem;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Button btnAnexarImagem;
        private System.Windows.Forms.PictureBox pbAnexarImagem;
    }
}

