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
        private int id;
        private string nit;
        private string nombre;
        private byte[] logo;
        private string extension;
        private string pass;

        MySqlConnection connection = new MySqlConnection(@"server=bxymyfyxvxkhdlsf4tpg-mysql.services.clever-cloud.com;user id=uunvywmqw6xpltvy;password=eI54i3NKQkrF7bjSsJgV;database=bxymyfyxvxkhdlsf4tpg;");

        public int Id { get => id; set => id = value; }
        public string Nit { get => nit; set => nit = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public byte[] Logo { get => logo; set => logo = value; }
        public string Extension { get => extension; set => extension = value; }
        public string Pass { get => pass; set => pass = value; }

        //añadirCliente
        public string AggCC() 
        {
            connection.Open();
            MySqlCommand comando = new MySqlCommand("INSERT INTO Clientes (@nit, @nombre, @logo, @pass)", connection);
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@nit", Nit);
            comando.Parameters.AddWithValue("@nombre", Nombre);
            comando.Parameters.AddWithValue("@logo", Logo);
            comando.Parameters.AddWithValue("@extension", Extension);
            comando.Parameters.AddWithValue("@pass", Pass);
            comando.ExecuteNonQuery();
            connection.Close();
            return "Agregado con éxito";
        }

        //borrarCliente
        //en desarrollo

        //editarCliente
        //en desarrollo

        //añadirPlantillas
        //en desarrollo

        //borrarPlantillas
        //en desarrollo


        //listarDGV_Clientes
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
        //listarDGV_Plantillas*Cliente
        public DataTable ListarPlantillasXCliente() 
        {
            DataTable table = new DataTable();
            connection.Open();
            MySqlCommand command = new MySqlCommand("select archivo from Plantillas", connection);
            MySqlDataReader resultado_P = command.ExecuteReader();

            if (resultado_P.HasRows) table.Load(resultado_P);
            resultado_P.Close();
            connection.Close();
            return table;
        }
    }
}
