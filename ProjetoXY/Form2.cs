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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "etechoracio" && txtSenha.Text == "123456")
            {
                MessageBox.Show("Usuário Logado");
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
