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
    public partial class CrearCliente : Form
    {
        Consulta_CEO obj_cCEO = new Consulta_CEO();
        CEO Vceo;
        public CrearCliente()
        {
            InitializeComponent();

        }
        public void referenciar_CC(CEO Vceo)
        {
            this.Vceo = Vceo;
        }

        private void CrearCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BVolver_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Vceo.Visible = true;
        }

        private void btnCrearC_Click(object sender, EventArgs e)
        {
            try {
                if (txtIDCliente.Text != "")
                {
                    if (txtNameClient.Text != "") 
                    {
                        if (txtNitClient.Text != "")
                        {
                            if (txtPass.Text != "")
                            {
                                if (txtPassconf.Text == txtPass.Text)
                                {
                                    if (Ruta_Logo.Text != "")
                                    {
                                                                               
                                        // Logo Clientes
                                        byte[] logo = null;
                                        Stream MySteam = openFileDialog1.OpenFile();
                                        MemoryStream logo_Open = new MemoryStream();
                                        MySteam.CopyTo(logo_Open);
                                        logo = logo_Open.ToArray();
                                        //<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>//
                                        // Datos clientes
                                        obj_cCEO.Nit = txtNitClient.Text;
                                        obj_cCEO.Nombre = txtNameClient.Text;
                                        obj_cCEO.Pass = txtPassconf.Text;
                                        obj_cCEO.Logo = logo;
                                        obj_cCEO.Extension = txtNitClient.Text;
                                        //<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>//
                                        MessageBox.Show(obj_cCEO.AggCC());
                                        //MessageBox.Show("Se ha registrado con exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        // limpiar campos
                                        txtIDCliente.Text = "";
                                        txtNameClient.Text = "";
                                        txtNitClient.Text = "";
                                        txtPass.Text = "";
                                        txtPassconf.Text = "";
                                        Ruta_Logo.Text = "";
                                        Name_Logo.Text = "";
                                    }
                                    else { }

                                }
                                else
                                {
                                    MessageBox.Show("Porfavor verifique la contaseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else {
                                MessageBox.Show("Porfavor ingrese la contaseña para el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else {
                            MessageBox.Show("Porfavor ingrese el nit del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } 
                    else {
                        MessageBox.Show("Porfavor ingrese el nombre del cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }
                }else {
                    MessageBox.Show("Porfavor ingrese la ID del cliente","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            } catch(Exception error) {
                MessageBox.Show("Error: "+ error);
                logger.RegistrarError("Se Capturo el sigiente error: " + error);
            }
        }

        private void CrearCliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_Exa_CC_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Documentos";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if(openFileDialog1.ShowDialog()==DialogResult.OK)
                Ruta_Logo.Text = openFileDialog1.FileName;
        }
    }
}
