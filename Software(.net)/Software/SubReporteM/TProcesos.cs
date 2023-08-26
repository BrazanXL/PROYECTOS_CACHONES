using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software.SubReporteM
{
    public partial class TProcesos : Form
    {
        ReporteM vRM;
        public TProcesos()
        {
            InitializeComponent();
        }

        public void referenciar_vRM(ReporteM vRM) 
        {
           this.vRM = vRM;
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            vRM.Visible = true;
        }

        private void TProcesos_FormClosing(object sender, FormClosingEventArgs e)
        {
            vRM.Visible = true;
        }
    }
}
