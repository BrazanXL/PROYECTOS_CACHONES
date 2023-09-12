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
    public partial class Cronograma : Form
    {
        CEO CEO;
        public Cronograma()
        {
            InitializeComponent();
        }

        private void Cronograma_Load(object sender, EventArgs e)
        {
            for (int f=1;f<=96;f++) 
            {
                dataGridView1.Rows.Add();
                CargarFecha();
            }
        }

        private void CargarFecha()
        {
            DateTime select = monthCalendar1.SelectionStart;
            Ltxt_Fecha.Text ="Fecha selecionada: " +select.ToString("dd/MM/yyyy");
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CEO.Visible = true;
        }
    }
}
