using Software.SubReporteM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        string userLogin;
        string userPass;
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        public Maestro()
        {
            InitializeComponent();
            vRM = new ReporteM();
            ceo = new CEO();
            connection.ConnectionString = @"";
        }



        private void BLogin_Click(object sender, EventArgs e)
        {
            try {
                if (UserLogin.Text != "") {
                    if (PassLogin.Text != "") {
                        if (UserLogin.Text =="CEO") {
                            if (PassLogin.Text =="2023") {
                                this.Visible = false;
                                //vRM.Visible = true;
                                MessageBox.Show("Bienvenido","",MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ceo.Visible = true;

                            }
                            else {
                                MessageBox.Show("La contraseña ingresada es incorrecta", "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                PassLogin.Text = "";
                            }
                        }
                        else {
                            MessageBox.Show("El Usuario ingresado no existe, comunicate con tu provedor de usuarios", "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else {
                        MessageBox.Show("Ingresa la contraseña", "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else {
                    MessageBox.Show("Ingresa el usuario", "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            } catch {

            }
        }
    }
}
