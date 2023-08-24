/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/GUIForms/JFrame.java to edit this template
 */
package Formularios;

/**
 *
 * @author KyB
 */
public class RepoM extends javax.swing.JFrame {

    /**
     * Creates new form RepoM
     */
    public RepoM() {
        initComponents();
        this.setLocationRelativeTo(null);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        ExitButton = new javax.swing.JButton();
        jLabelReporteM = new javax.swing.JLabel();
        IDENTIFICACION_EQUIPO = new javax.swing.JLabel();
        jTextField_IDECL = new javax.swing.JTextField();
        IDENTIFICACION_USUARIO = new javax.swing.JLabel();
        jTextField_EQUIPO = new javax.swing.JTextField();
        MARCA = new javax.swing.JLabel();
        jTextField_MARCA = new javax.swing.JTextField();
        jTextField_MARCA1 = new javax.swing.JTextField();
        jTextField_MARCA2 = new javax.swing.JTextField();
        MARCA1 = new javax.swing.JLabel();
        MARCA2 = new javax.swing.JLabel();
        IDENTIFICACION_USUARIO1 = new javax.swing.JLabel();
        jTextField_EQUIPO1 = new javax.swing.JTextField();
        jCheckBox1 = new javax.swing.JCheckBox();
        jCheckBox2 = new javax.swing.JCheckBox();
        jCheckBox3 = new javax.swing.JCheckBox();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTextArea1 = new javax.swing.JTextArea();
        jButton1 = new javax.swing.JButton();
        jLabelLogo = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabelFondo = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setUndecorated(true);
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        ExitButton.setBackground(new java.awt.Color(51, 102, 255));
        ExitButton.setFont(new java.awt.Font("Segoe UI Semilight", 1, 14)); // NOI18N
        ExitButton.setForeground(new java.awt.Color(255, 255, 255));
        ExitButton.setText("Salir");
        ExitButton.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                ExitButtonActionPerformed(evt);
            }
        });
        getContentPane().add(ExitButton, new org.netbeans.lib.awtextra.AbsoluteConstraints(650, 0, 80, 30));

        jLabelReporteM.setFont(new java.awt.Font("Segoe UI Black", 1, 24)); // NOI18N
        jLabelReporteM.setForeground(new java.awt.Color(255, 255, 255));
        jLabelReporteM.setText("Formato de mantenimiento 001");
        getContentPane().add(jLabelReporteM, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 40, -1, 30));

        IDENTIFICACION_EQUIPO.setFont(new java.awt.Font("Segoe UI Black", 1, 14)); // NOI18N
        IDENTIFICACION_EQUIPO.setForeground(new java.awt.Color(255, 255, 255));
        IDENTIFICACION_EQUIPO.setText("Identificacion del equipo");
        getContentPane().add(IDENTIFICACION_EQUIPO, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 200, -1, -1));

        jTextField_IDECL.setBackground(new java.awt.Color(51, 153, 255));
        jTextField_IDECL.setFont(new java.awt.Font("Segoe UI Black", 1, 14)); // NOI18N
        jTextField_IDECL.setForeground(new java.awt.Color(255, 255, 255));
        jTextField_IDECL.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jTextField_IDECLActionPerformed(evt);
            }
        });
        getContentPane().add(jTextField_IDECL, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 200, 190, -1));

        IDENTIFICACION_USUARIO.setFont(new java.awt.Font("Segoe UI Black", 1, 14)); // NOI18N
        IDENTIFICACION_USUARIO.setForeground(new java.awt.Color(255, 255, 255));
        IDENTIFICACION_USUARIO.setText("Fecha (dd/mm/aa)");
        getContentPane().add(IDENTIFICACION_USUARIO, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 120, -1, -1));

        jTextField_EQUIPO.setBackground(new java.awt.Color(51, 153, 255));
        jTextField_EQUIPO.setFont(new java.awt.Font("Segoe UI Black", 1, 14)); // NOI18N
        jTextField_EQUIPO.setForeground(new java.awt.Color(255, 255, 255));
        jTextField_EQUIPO.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jTextField_EQUIPOActionPerformed(evt);
            }
        });
        getContentPane().add(jTextField_EQUIPO, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 120, 190, -1));

        MARCA.setFont(new java.awt.Font("Segoe UI Black", 1, 14)); // NOI18N
        MARCA.setForeground(new java.awt.Color(255, 255, 255));
        MARCA.setText("S/N");
        getContentPane().add(MARCA, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 320, -1, -1));

        jTextField_MARCA.setBackground(new java.awt.Color(51, 153, 255));
        jTextField_MARCA.setFont(new java.awt.Font("Segoe UI Black", 1, 14)); // NOI18N
        jTextField_MARCA.setForeground(new java.awt.Color(255, 255, 255));
        jTextField_MARCA.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jTextField_MARCAActionPerformed(evt);
            }
        });
        getContentPane().add(jTextField_MARCA, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 320, 190, -1));

        jTextField_MARCA1.setBackground(new java.awt.Color(51, 153, 255));
        jTextField_MARCA1.setFont(new java.awt.Font("Segoe UI Black", 1, 14)); // NOI18N
        jTextField_MARCA1.setForeground(new java.awt.Color(255, 255, 255));
        jTextField_MARCA1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jTextField_MARCA1ActionPerformed(evt);
            }
        });
        getContentPane().add(jTextField_MARCA1, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 240, 190, -1));

        jTextField_MARCA2.setBackground(new java.awt.Color(51, 153, 255));
        jTextField_MARCA2.setFont(new java.awt.Font("Segoe UI Black", 1, 14)); // NOI18N
        jTextField_MARCA2.setForeground(new java.awt.Color(255, 255, 255));
        jTextField_MARCA2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jTextField_MARCA2ActionPerformed(evt);
            }
        });
        getContentPane().add(jTextField_MARCA2, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 280, 190, -1));

        MARCA1.setFont(new java.awt.Font("Segoe UI Black", 1, 14)); // NOI18N
        MARCA1.setForeground(new java.awt.Color(255, 255, 255));
        MARCA1.setText("Marca");
        getContentPane().add(MARCA1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 240, -1, -1));

        MARCA2.setFont(new java.awt.Font("Segoe UI Black", 1, 14)); // NOI18N
        MARCA2.setForeground(new java.awt.Color(255, 255, 255));
        MARCA2.setText("Modelo");
        getContentPane().add(MARCA2, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 280, -1, -1));

        IDENTIFICACION_USUARIO1.setFont(new java.awt.Font("Segoe UI Black", 1, 14)); // NOI18N
        IDENTIFICACION_USUARIO1.setForeground(new java.awt.Color(255, 255, 255));
        IDENTIFICACION_USUARIO1.setText("Identificacion del usuario");
        getContentPane().add(IDENTIFICACION_USUARIO1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 160, -1, -1));

        jTextField_EQUIPO1.setBackground(new java.awt.Color(51, 153, 255));
        jTextField_EQUIPO1.setFont(new java.awt.Font("Segoe UI Black", 1, 14)); // NOI18N
        jTextField_EQUIPO1.setForeground(new java.awt.Color(255, 255, 255));
        jTextField_EQUIPO1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jTextField_EQUIPO1ActionPerformed(evt);
            }
        });
        getContentPane().add(jTextField_EQUIPO1, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 160, 190, -1));

        jCheckBox1.setFont(new java.awt.Font("Segoe UI Black", 0, 14)); // NOI18N
        jCheckBox1.setForeground(new java.awt.Color(255, 255, 255));
        jCheckBox1.setText("Evaluacion");
        getContentPane().add(jCheckBox1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 430, -1, -1));

        jCheckBox2.setFont(new java.awt.Font("Segoe UI Black", 0, 14)); // NOI18N
        jCheckBox2.setForeground(new java.awt.Color(255, 255, 255));
        jCheckBox2.setText("Preventivo");
        getContentPane().add(jCheckBox2, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 390, -1, -1));

        jCheckBox3.setFont(new java.awt.Font("Segoe UI Black", 0, 14)); // NOI18N
        jCheckBox3.setForeground(new java.awt.Color(255, 255, 255));
        jCheckBox3.setText("Correctivo");
        jCheckBox3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jCheckBox3ActionPerformed(evt);
            }
        });
        getContentPane().add(jCheckBox3, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 410, -1, -1));

        jLabel1.setFont(new java.awt.Font("Segoe UI Black", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(255, 255, 255));
        jLabel1.setText("Tipo de mantenimiento :");
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 370, -1, -1));

        jLabel2.setFont(new java.awt.Font("Segoe UI Black", 1, 18)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(255, 255, 255));
        jLabel2.setText("Desarrollo");
        getContentPane().add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 460, -1, -1));

        jTextArea1.setBackground(new java.awt.Color(51, 153, 255));
        jTextArea1.setColumns(20);
        jTextArea1.setFont(new java.awt.Font("Segoe UI Black", 1, 13)); // NOI18N
        jTextArea1.setForeground(new java.awt.Color(255, 255, 255));
        jTextArea1.setRows(5);
        jScrollPane1.setViewportView(jTextArea1);

        getContentPane().add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(90, 490, 560, 120));

        jButton1.setBackground(new java.awt.Color(102, 0, 255));
        jButton1.setText("Más opciones");
        getContentPane().add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 650, -1, -1));

        jLabelLogo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Img/LOGO_HT-removebg-preview.png"))); // NOI18N
        getContentPane().add(jLabelLogo, new org.netbeans.lib.awtextra.AbsoluteConstraints(110, 10, -1, -1));

        jLabel3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Img/LOGO_FInal-removebg-preview.png"))); // NOI18N
        getContentPane().add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 0, 130, 130));

        jLabelFondo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Img/fondo (1).jpg"))); // NOI18N
        getContentPane().add(jLabelFondo, new org.netbeans.lib.awtextra.AbsoluteConstraints(-10, 0, 740, -1));

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jTextField_IDECLActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jTextField_IDECLActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jTextField_IDECLActionPerformed

    private void jTextField_EQUIPOActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jTextField_EQUIPOActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jTextField_EQUIPOActionPerformed

    private void jTextField_MARCAActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jTextField_MARCAActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jTextField_MARCAActionPerformed

    private void jTextField_MARCA1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jTextField_MARCA1ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jTextField_MARCA1ActionPerformed

    private void jTextField_MARCA2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jTextField_MARCA2ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jTextField_MARCA2ActionPerformed

    private void jTextField_EQUIPO1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jTextField_EQUIPO1ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jTextField_EQUIPO1ActionPerformed

    private void jCheckBox3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jCheckBox3ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jCheckBox3ActionPerformed

    private void ExitButtonActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ExitButtonActionPerformed
        System.exit(0);
    }//GEN-LAST:event_ExitButtonActionPerformed

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(RepoM.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(RepoM.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(RepoM.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(RepoM.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new RepoM().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton ExitButton;
    private javax.swing.JLabel IDENTIFICACION_EQUIPO;
    private javax.swing.JLabel IDENTIFICACION_USUARIO;
    private javax.swing.JLabel IDENTIFICACION_USUARIO1;
    private javax.swing.JLabel MARCA;
    private javax.swing.JLabel MARCA1;
    private javax.swing.JLabel MARCA2;
    private javax.swing.JButton jButton1;
    private javax.swing.JCheckBox jCheckBox1;
    private javax.swing.JCheckBox jCheckBox2;
    private javax.swing.JCheckBox jCheckBox3;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabelFondo;
    private javax.swing.JLabel jLabelLogo;
    private javax.swing.JLabel jLabelReporteM;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTextArea jTextArea1;
    private javax.swing.JTextField jTextField_EQUIPO;
    private javax.swing.JTextField jTextField_EQUIPO1;
    private javax.swing.JTextField jTextField_IDECL;
    private javax.swing.JTextField jTextField_MARCA;
    private javax.swing.JTextField jTextField_MARCA1;
    private javax.swing.JTextField jTextField_MARCA2;
    // End of variables declaration//GEN-END:variables
}
