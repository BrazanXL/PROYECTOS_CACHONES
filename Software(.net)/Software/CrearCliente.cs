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
    public partial class CrearCliente : Form
    {
        CEO ceo;
        public CrearCliente()
        {
            InitializeComponent();

        }
        public void referenciar_CC(CEO ceo)
        {
            this.ceo = ceo;
        }

        private void CrearCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            ceo.Visible = true;
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ceo.Visible = true;
        }
    }
}
