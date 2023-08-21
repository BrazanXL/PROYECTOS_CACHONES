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


public class consultas {
    public void consultarUsuario(String user, String pass){
        // TODO add your handling code here:
        ConexionDB db = new ConexionDB();
        // Se inicializa a null
        String usuarioCorrecto = null;
        String passCorrecto = null;
    try {
        Connection cf = db.conectar();
        PreparedStatement pst = cf.prepareStatement("SELECT nombre, clave FROM Usuarios");
        ResultSet rs = pst.executeQuery();

        if (rs.next()) {
            usuarioCorrecto = rs.getString(1);
            passCorrecto = rs.getString(2);
        }

        if (user.equals(usuarioCorrecto) && pass.equals(passCorrecto)) {
            JOptionPane.showMessageDialog(null, "Login correcto Bienvenido " + user);
        } else if (!user.equals(usuarioCorrecto) || pass.equals(passCorrecto)) {

            JOptionPane.showMessageDialog(null, "Usuario o contraseña incorrectos");
        }

    } catch (Exception e) {
        JOptionPane.showMessageDialog(null, "Error " + e);
    }
    }
}
