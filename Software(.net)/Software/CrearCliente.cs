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
                                    MessageBox.Show("Se ha registrado con exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
        }
    }
}
