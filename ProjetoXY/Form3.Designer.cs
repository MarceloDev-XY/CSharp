namespace ProjetoXY
{
    partial class FrmSpash
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpash));
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.pbAbertura = new System.Windows.Forms.ProgressBar();
            this.lvlDescricao = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(198, 158);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(103, 92);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // pbAbertura
            // 
            this.pbAbertura.Location = new System.Drawing.Point(387, 158);
            this.pbAbertura.Name = "pbAbertura";
            this.pbAbertura.Size = new System.Drawing.Size(249, 92);
            this.pbAbertura.TabIndex = 1;
            // 
            // lvlDescricao
            // 
            this.lvlDescricao.AutoSize = true;
            this.lvlDescricao.Font = new System.Drawing.Font("Arial", 15F);
            this.lvlDescricao.Location = new System.Drawing.Point(299, 54);
            this.lvlDescricao.Name = "lvlDescricao";
            this.lvlDescricao.Size = new System.Drawing.Size(199, 23);
            this.lvlDescricao.TabIndex = 2;
            this.lvlDescricao.Text = "Sistema - matéria DS";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSpash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvlDescricao);
            this.Controls.Add(this.pbAbertura);
            this.Controls.Add(this.pbxLogo);
            this.Name = "FrmSpash";
            this.Text = "Sistema - DS";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.ProgressBar pbAbertura;
        private System.Windows.Forms.Label lvlDescricao;
        private System.Windows.Forms.Timer timer1;
    }
}