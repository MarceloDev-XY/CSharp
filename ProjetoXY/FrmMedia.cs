using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoXY
{
    public partial class FrmMedia : Form
    {
        public FrmMedia()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            float valor1, valor2, valor3, media;

            valor1 = Convert.ToInt32(txtAvUm.Text);
            valor2 = Convert.ToInt32(txtAvDois.Text);
            valor3 = Convert.ToInt32(txtAvTres.Text);


            media = (valor1 + valor2 + valor3) / 3;

            lblMedia.Text = Convert.ToString(media);


            if (media >= 7)
            
                {
                    MessageBox.Show("Aluno APROVADO" + " " + "sua média é" + " " + media);
                }
                if (media >= 4 && media < 7 )
                {
                    MessageBox.Show("Aluno em recuperação" + " " + "sua média é" + " " + media);
                }

                else if (media < 4)
                {
                    MessageBox.Show("Aluno REPROVADO" + " " + "sua média é" + " " + media);
                }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtAvUm.Clear();
            txtAvDois.Clear();
            txtAvTres.Clear();

            lblMedia.Text = (" ");
        }
    }
}
