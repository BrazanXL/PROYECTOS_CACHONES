package Clases;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import javax.swing.JOptionPane;

/**
 * @author Bryan Pantoja
 * @author Ismael cajar
 * @author hansel ortiz
 * @author rafael camargo
 */
public class ConexionDB {
    // Declaramos la conexion a mysql
    public static Connection con;
    // Declaramos los datos de conexion a la bd
    String driver = "com.mysql.cj.jdbc.Driver";
    String user = "yirwvs91wd7961v21dx0";
    String pass = "pscale_pw_EhK1sktrX9kgCIyzoVvsoS9lzZgEi6BCWe8xVUH6BR1";
    String url = "jdbc:mysql://aws.connect.psdb.cloud/usuarios?sslMode=VERIFY_IDENTITY";
    // Funcion que va conectarse a mi bd de mysql
    public Connection conectar(){
      con = null;
      try{
          con = (Connection) DriverManager.getConnection(url, user, pass);
          if(con!=null){
          }
      }
      catch(SQLException e)
      {
          JOptionPane.showMessageDialog(null,"Error" + e.toString());
      }
      return con;
    }
}
