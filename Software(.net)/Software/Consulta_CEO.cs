using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software
{
    public class Consulta_CEO
    {
        MySqlConnection connection = new MySqlConnection(@"server=bxymyfyxvxkhdlsf4tpg-mysql.services.clever-cloud.com;user id=uunvywmqw6xpltvy;password=eI54i3NKQkrF7bjSsJgV;database=bxymyfyxvxkhdlsf4tpg;");

        //añadirCliente
        //borrarCliente
        //editarCliente
        //listarDGV
        public DataTable ListarCliente() 
        {
            DataTable table = new DataTable();
            connection.Open();
            MySqlCommand command = new MySqlCommand("select Id, nit, nombre from Clientes", connection);
            MySqlDataReader resultado = command.ExecuteReader();

            if (resultado.HasRows) table.Load(resultado);

            resultado.Close();
            connection.Close();
            return table;

        }
    }
}
