using Software.SubReporteM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
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
        MySqlConnection connection = new MySqlConnection();
        MySqlCommand command = new MySqlCommand();
        public Maestro()
        {
            InitializeComponent();
            vRM = new ReporteM();
            ceo = new CEO();
            connection.ConnectionString = @"server=bxymyfyxvxkhdlsf4tpg-mysql.services.clever-cloud.com;user id=uunvywmqw6xpltvy;password=eI54i3NKQkrF7bjSsJgV;database=bxymyfyxvxkhdlsf4tpg;";
        }



        private void BLogin_Click(object sender, EventArgs e)
        {
            try {
                if (UserLogin.Text != "") {
                    if (PassLogin.Text != "") 
                    {
                        command.Connection = connection;
                        connection.Open();
                        command.CommandText = "SELECT * FROM usuarios WHERE ingresoUsuario = @ingresoUsuario";
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("ingresoUsuario", UserLogin.Text);

                        MySqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            String user = reader.GetString(1);
                            String pass = reader.GetString(2);
                            MessageBox.Show("los datos encontrados: "+user+" "+pass);
                            if (PassLogin.Text == pass)
                            {
                                this.Visible = false;
                                if (user == "CEO") 
                                {
                                    MessageBox.Show("Bienvenido " + user, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    ceo.Visible = true;
                                }
                                if(user == "Mantenimiento")
                                {
                                    MessageBox.Show("Bienvenido usuario de " + user, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    vRM.Visible = true;
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("La contraseña ingresada es incorrecta", "Inconsistencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                PassLogin.Text = "";
                            }
                        }
                        else 
                        { 
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
            } catch(SqlException error) {
                MessageBox.Show("Error" + error);
            }

            command.Dispose();
            connection.Close();
        }

        private void PassLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                // Trigger the click event of the login button
                BLogin_Click(sender, e);
            }
        }

        private void Maestro_Load(object sender, EventArgs e)
        {

        }
    }
}
