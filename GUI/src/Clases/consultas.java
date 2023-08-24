package Clases;
/**
 * @author Bryan Pantoja
 */
import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JOptionPane;
import javax.swing.JPasswordField;
import javax.swing.JTextField;


public class consultas {
    public void consultarUsuario(JTextField user, JPasswordField pass){
        // Se inicializa a null
        
    try {
        ResultSet rs = null;
        PreparedStatement ps = null;
        Clases.ConexionDB oCDB = new Clases.ConexionDB();
        
        String consulta="select * from Usuarios where usuarios.ingresoUsuario=(?) and usuarios.ingresoPass=(?);";
        ps = oCDB.conectar().prepareStatement(consulta);
        
        String Pass =String.valueOf(pass.getPassword());
        ps.setString(1, user.getText());
        ps.setString(2, Pass);
        
        rs = ps.executeQuery();
        

        if (rs.next()) {
            JOptionPane.showMessageDialog(null, "Login correcto Bienvenido " + user.getText());

        } else
        {
            JOptionPane.showMessageDialog(null, "Usuario o contraseña incorrectos");
        }
        

    } catch (Exception e) {
        JOptionPane.showMessageDialog(null, "Error " + e);
    }
    }
}
