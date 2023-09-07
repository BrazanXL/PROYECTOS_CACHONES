using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software
{
    internal class Connet
    {
        string SDB = @"server=bxymyfyxvxkhdlsf4tpg-mysql.services.clever-cloud.com;user id=uunvywmqw6xpltvy;password=eI54i3NKQkrF7bjSsJgV;database=bxymyfyxvxkhdlsf4tpg;";
        public MySqlConnection Connection = new MySqlConnection();

        public ConectarDB() 
        {
            Connection.ConnectionString = SDB;
        }

        public void abrir() {
            try {
                Connection.Open();
                Console.WriteLine("Conexion abirta");
            }catch(Exception e) {
                Console.WriteLine("Error al abrir la DB"+e.Message);
                logger.RegistrarError("Se Capturo el sigiente error: " + e);
            }
        }
        public void cerrar() {
            Connection.Close();
        }
    }
}
