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
            Double valor1, valor2, valor3, media;

            valor1 = Convert.ToDouble(txtAvUm.Text);
            valor2 = Convert.ToDouble(txtAvDois.Text);
            valor3 = Convert.ToDouble(txtAvTres.Text);


            media = (valor1 + valor2 + valor3) / 3;

            


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

           
        }

        private void lblMedia_Click(object sender, EventArgs e)
        {

        }
    }
}
