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
    // Declaracion de conexion a MySQL
    public static Connection con;
    // Datos de conexion a red
    private static final String driver="com.mysql.jdbc.Driver";
    private static final String user="root";
    private static final String pass="1001Server";
    private static final String url="jdbc:mysql://127.0.0.1:3306/login?characterEncoding=utf8";
    // funcion de conexion
    public Connection connectar(){
        con = null;
        try{
            con = (Connection) DriverManager.getConnection(url, user, pass);
            if(con!=null){}
        }catch(SQLException e){JOptionPane.showMessageDialog(null,"Error" +e.toString());}
        return con;
    }
    
}
