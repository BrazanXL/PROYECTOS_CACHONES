using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software
{
    public partial class Cronograma : Form
    {
        CEO Vceo;
        public Cronograma()
        {
            InitializeComponent();
        }

        public void referenciar_Cg(CEO Vceo) { this.Vceo = Vceo; }

        private void Cronograma_Load(object sender, EventArgs e)
        {
            for (int f=1;f<=96;f++) 
            {
                dataGridView1.Rows.Add();
            }
            CargarFecha();
        }

        private void CargarFecha()
        {
            DateTime select = monthCalendar1.SelectionStart;
            Ltxt_Fecha.Text ="Fecha selecionada: " +select.ToString("dd/MM/yyyy");
            string fecha = select.Year.ToString()+ select.Month.ToString()+ select.Day.ToString();
            if (!File.Exists(fecha))
            {
                StreamWriter archivo=new StreamWriter(fecha);
                DateTime fe = DateTime.Today;
                for (int f = 1; f <= 96; f++) 
                {
                    archivo.WriteLine(fe.ToString("HH:mm"));
                    archivo.WriteLine("");
                    fe = fe.AddMinutes(15);
                }
                archivo.Close();
            }
            StreamReader archivo2 =new StreamReader(fecha);
            int x = 0;
            while (!archivo2.EndOfStream) {
                string linea1 = archivo2.ReadLine();
                string linea2 = archivo2.ReadLine();
                dataGridView1.Rows[x].Cells[0].Value = linea1;
                dataGridView1.Rows[x].Cells[1].Value = linea2;
                x++;

            }
            archivo2.Close();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Vceo.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            CargarFecha();
        }
    }
}
