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
    public partial class frmCursos : Form
    {
        public frmCursos()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            if (txtNumeroCurso.Text == "1")
            {
                MessageBox.Show("Técnico em informática");
            }
            else if (txtNumeroCurso.Text == "2")
            {
                MessageBox.Show("Técnico em Redes");
            }
            else if(txtNumeroCurso.Text == "3")
            {
                MessageBox.Show("Eletrônica");
            }
            else
            {
                MessageBox.Show("Opção Inválida");
            }
        }

        private void btbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
