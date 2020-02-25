namespace ProjetoXY
{
    partial class frmCursos
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDigiteCurso = new System.Windows.Forms.Label();
            this.txtNumeroCurso = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btbSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(358, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(110, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Cursos";
            // 
            // lblDigiteCurso
            // 
            this.lblDigiteCurso.AutoSize = true;
            this.lblDigiteCurso.Location = new System.Drawing.Point(70, 165);
            this.lblDigiteCurso.Name = "lblDigiteCurso";
            this.lblDigiteCurso.Size = new System.Drawing.Size(155, 13);
            this.lblDigiteCurso.TabIndex = 1;
            this.lblDigiteCurso.Text = "Digite um número para o Curso:";
            // 
            // txtNumeroCurso
            // 
            this.txtNumeroCurso.Location = new System.Drawing.Point(73, 182);
            this.txtNumeroCurso.Name = "txtNumeroCurso";
            this.txtNumeroCurso.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroCurso.TabIndex = 2;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(73, 209);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btbSair
            // 
            this.btbSair.Location = new System.Drawing.Point(73, 327);
            this.btbSair.Name = "btbSair";
            this.btbSair.Size = new System.Drawing.Size(75, 23);
            this.btbSair.TabIndex = 4;
            this.btbSair.Text = "Sair";
            this.btbSair.UseVisualStyleBackColor = true;
            this.btbSair.Click += new System.EventHandler(this.btbSair_Click);
            // 
            // frmCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbSair);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtNumeroCurso);
            this.Controls.Add(this.lblDigiteCurso);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmCursos";
            this.Text = "Cursos - Etec Horácio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDigiteCurso;
        private System.Windows.Forms.TextBox txtNumeroCurso;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btbSair;
    }
}

