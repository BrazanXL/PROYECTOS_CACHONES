using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Software
{
    public partial class CEO : Form
    {
        CrearCliente CC;
        public CEO()
        {
            InitializeComponent();
            CC = new CrearCliente();
        }

        private void CEO_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            CC.referenciar_CC(this);
            CC.Visible = true;
        }

        private void CEO_Load(object sender, EventArgs e)
        {
            string consulta = "";
            MySqlDataAdapter ad = new MySqlDataAdapter(consulta,connection);

        }
    }
}
