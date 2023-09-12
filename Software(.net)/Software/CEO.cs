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
        Consulta_CEO obj_cCEO = new Consulta_CEO();
        CrearCliente CC;
        Cronograma crono;
        public CEO()
        {
            InitializeComponent();
            LlenarData();
            crono = new Cronograma();
            CC = new CrearCliente();
        }
        private void LlenarData() 
        {
            dgv_Clientes.DataSource = obj_cCEO.ListarCliente();
        }
        private void CEO_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LlenarData();
            this.Visible = true;
            CC.referenciar_CC(this);
            CC.Visible = true;
            
        }

        private void CEO_Load(object sender, EventArgs e)
        {
            //string consulta = "";
            //MySqlDataAdapter ad = new MySqlDataAdapter(consulta,connection);

        }

        private void btn_Crono_Click(object sender, EventArgs e)
        {
            crono.referenciar_Cg(this);
            crono.Visible = true;
        }
    }
}
