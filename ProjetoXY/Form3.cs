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
    public partial class FrmSpash : Form
    {
        public FrmSpash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbAbertura.Value < 100)
            {
                pbAbertura.Value = pbAbertura.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                this.Visible = false;
                FrmLogin f = new FrmLogin ();
                f.Show();
            }
        }
    }
}
