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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void calcularMédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Instanciando o formulário
            FrmMedia fMedia = new FrmMedia();

            // Indica que o formulário que será aberto 
            // é filho do FrmPrincipal
            fMedia.MdiParent = this;

            // Exibirá o formulário Filho 
            fMedia.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente encerrar o sistema ?", "Pergunta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Obrigado por utilizar nossos serviços e até mais !", "*** Obrigado ***",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();            }
        }
    }
}
