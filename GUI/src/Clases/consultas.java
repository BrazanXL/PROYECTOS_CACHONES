package Clases;
/**
 * @author Bryan Pantoja
 */
import java.sql.Connection;
import java.sql.Statement;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import javax.swing.JOptionPane;


public class consultas {
    public void consultarUsuario(String user, String pass){
        ConexionDB db = new ConexionDB();
        // Se inicializa a null
        String usuarioCorrecto = null;
        String passCorrecto = null;
    try{
        Connection cn = db.connectar();
        PreparedStatement pst = cn.prepareStatement("SELECT idUsuario, nombre, clave FROM usuarios");
        ResultSet rs = pst.executeQuery();
        
        if(rs.next()){
            usuarioCorrecto = rs.getString(1);
            passCorrecto = rs.getString(2);
        }
        
        if(user.equals(usuarioCorrecto)&& pass.equals(passCorrecto)){
            JOptionPane.showMessageDialog(null, "Login correcto Bienvenido" + user);
        }else if(!user.equals(usuarioCorrecto)|| pass.equals(passCorrecto)){
            JOptionPane.showMessageDialog(null,"Usuario o contraseña incorrectos");
        }
    } catch (Exception e){
        JOptionPane.showMessageDialog(null, "error" + e);
    }
    }
}
