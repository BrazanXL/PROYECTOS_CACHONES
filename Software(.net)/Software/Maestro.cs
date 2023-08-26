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
    public partial class Maestro : Form
    {
        ReporteM vRM;
        CEO ceo;
        public Maestro()
        {
            InitializeComponent();
            vRM = new ReporteM();
            ceo = new CEO();
        }
        private void BLogin_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //vRM.Visible = true;
            ceo.Visible = true;
        }
    }
}
