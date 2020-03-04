namespace ProjetoXY
{
    partial class FrmMedia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedia));
            this.btnSair = new System.Windows.Forms.Button();
            this.lblTituloMedia = new System.Windows.Forms.Label();
            this.txtAvTres = new System.Windows.Forms.TextBox();
            this.txtAvDois = new System.Windows.Forms.TextBox();
            this.txtAvUm = new System.Windows.Forms.TextBox();
            this.lblAvUm = new System.Windows.Forms.Label();
            this.lblAvDois = new System.Windows.Forms.Label();
            this.lblAvTres = new System.Windows.Forms.Label();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(185, 289);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTituloMedia
            // 
            this.lblTituloMedia.AutoSize = true;
            this.lblTituloMedia.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMedia.Location = new System.Drawing.Point(148, 9);
            this.lblTituloMedia.Name = "lblTituloMedia";
            this.lblTituloMedia.Size = new System.Drawing.Size(149, 22);
            this.lblTituloMedia.TabIndex = 1;
            this.lblTituloMedia.Text = "Cálculo de Média";
            // 
            // txtAvTres
            // 
            this.txtAvTres.Location = new System.Drawing.Point(287, 120);
            this.txtAvTres.Name = "txtAvTres";
            this.txtAvTres.Size = new System.Drawing.Size(100, 20);
            this.txtAvTres.TabIndex = 2;
            // 
            // txtAvDois
            // 
            this.txtAvDois.Location = new System.Drawing.Point(181, 120);
            this.txtAvDois.Name = "txtAvDois";
            this.txtAvDois.Size = new System.Drawing.Size(100, 20);
            this.txtAvDois.TabIndex = 4;
            // 
            // txtAvUm
            // 
            this.txtAvUm.Location = new System.Drawing.Point(75, 120);
            this.txtAvUm.Name = "txtAvUm";
            this.txtAvUm.Size = new System.Drawing.Size(100, 20);
            this.txtAvUm.TabIndex = 5;
            // 
            // lblAvUm
            // 
            this.lblAvUm.AutoSize = true;
            this.lblAvUm.Location = new System.Drawing.Point(94, 93);
            this.lblAvUm.Name = "lblAvUm";
            this.lblAvUm.Size = new System.Drawing.Size(63, 13);
            this.lblAvUm.TabIndex = 6;
            this.lblAvUm.Text = "Avaliação 1";
            // 
            // lblAvDois
            // 
            this.lblAvDois.AutoSize = true;
            this.lblAvDois.Location = new System.Drawing.Point(197, 93);
            this.lblAvDois.Name = "lblAvDois";
            this.lblAvDois.Size = new System.Drawing.Size(63, 13);
            this.lblAvDois.TabIndex = 7;
            this.lblAvDois.Text = "Avaliação 2";
            // 
            // lblAvTres
            // 
            this.lblAvTres.AutoSize = true;
            this.lblAvTres.Location = new System.Drawing.Point(306, 93);
            this.lblAvTres.Name = "lblAvTres";
            this.lblAvTres.Size = new System.Drawing.Size(63, 13);
            this.lblAvTres.TabIndex = 8;
            this.lblAvTres.Text = "Avaliação 3";
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(75, 235);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(100, 23);
            this.btnMedia.TabIndex = 12;
            this.btnMedia.Text = "Média";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(287, 235);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(442, 337);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.lblAvTres);
            this.Controls.Add(this.lblAvDois);
            this.Controls.Add(this.lblAvUm);
            this.Controls.Add(this.txtAvUm);
            this.Controls.Add(this.txtAvDois);
            this.Controls.Add(this.txtAvTres);
            this.Controls.Add(this.lblTituloMedia);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMedia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculadora Etec - Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblTituloMedia;
        private System.Windows.Forms.TextBox txtAvTres;
        private System.Windows.Forms.TextBox txtAvDois;
        private System.Windows.Forms.TextBox txtAvUm;
        private System.Windows.Forms.Label lblAvUm;
        private System.Windows.Forms.Label lblAvDois;
        private System.Windows.Forms.Label lblAvTres;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnLimpar;
    }
}