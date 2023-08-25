using Software.SubReporteM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software
{
    public partial class ReporteM : Form
    {
        TProcesos vTP;
        public ReporteM()
        {
            InitializeComponent();
            vTP = new TProcesos();
        }

        private void ReporteM_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            vTP.referenciar_vRM(this);
            vTP.Visible = true;
        }
    }
}
