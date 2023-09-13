namespace Software
{
    partial class CrearCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearCliente));
            this.btnCrearC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.txtNameClient = new System.Windows.Forms.TextBox();
            this.txtNitClient = new System.Windows.Forms.TextBox();
            this.BVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassconf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCrearC
            // 
            this.btnCrearC.Location = new System.Drawing.Point(16, 264);
            this.btnCrearC.Name = "btnCrearC";
            this.btnCrearC.Size = new System.Drawing.Size(98, 23);
            this.btnCrearC.TabIndex = 0;
            this.btnCrearC.Text = "Crear Cliente";
            this.btnCrearC.UseVisualStyleBackColor = true;
            this.btnCrearC.Click += new System.EventHandler(this.btnCrearC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NIT";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(84, 13);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIDCliente.TabIndex = 4;
            // 
            // txtNameClient
            // 
            this.txtNameClient.Location = new System.Drawing.Point(84, 35);
            this.txtNameClient.Name = "txtNameClient";
            this.txtNameClient.Size = new System.Drawing.Size(100, 20);
            this.txtNameClient.TabIndex = 5;
            // 
            // txtNitClient
            // 
            this.txtNitClient.Location = new System.Drawing.Point(84, 58);
            this.txtNitClient.Name = "txtNitClient";
            this.txtNitClient.Size = new System.Drawing.Size(100, 20);
            this.txtNitClient.TabIndex = 6;
            // 
            // BVolver
            // 
            this.BVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BVolver.FlatAppearance.BorderSize = 0;
            this.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BVolver.ForeColor = System.Drawing.Color.White;
            this.BVolver.Location = new System.Drawing.Point(504, 265);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(75, 22);
            this.BVolver.TabIndex = 7;
            this.BVolver.Text = "Volver";
            this.BVolver.UseVisualStyleBackColor = false;
            this.BVolver.Click += new System.EventHandler(this.BVolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Logo";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(316, 10);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contraseña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(213, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Repetir contraseña";
            // 
            // txtPassconf
            // 
            this.txtPassconf.Location = new System.Drawing.Point(316, 32);
            this.txtPassconf.Name = "txtPassconf";
            this.txtPassconf.PasswordChar = '*';
            this.txtPassconf.Size = new System.Drawing.Size(100, 20);
            this.txtPassconf.TabIndex = 11;
            // 
            // CrearCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(591, 299);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassconf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BVolver);
            this.Controls.Add(this.txtNitClient);
            this.Controls.Add(this.txtNameClient);
            this.Controls.Add(this.txtIDCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCrearC);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(607, 338);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(607, 338);
            this.Name = "CrearCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearCliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrearCliente_FormClosing);
            this.Load += new System.EventHandler(this.CrearCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.TextBox txtNameClient;
        private System.Windows.Forms.TextBox txtNitClient;
        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassconf;
    }
}