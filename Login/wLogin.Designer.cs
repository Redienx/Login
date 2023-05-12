namespace Login
{
    partial class fmrLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIncio = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.gbxRegistrar = new System.Windows.Forms.GroupBox();
            this.lblRegistrar = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblUsuarioRegistrar = new System.Windows.Forms.Label();
            this.txtContrasenaRegistrar = new System.Windows.Forms.TextBox();
            this.txtUsuarioRegistrar = new System.Windows.Forms.TextBox();
            this.lblContrasenaRegistrar = new System.Windows.Forms.Label();
            this.gbxRegistrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIncio
            // 
            this.lblIncio.AutoSize = true;
            this.lblIncio.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncio.Location = new System.Drawing.Point(89, 66);
            this.lblIncio.Name = "lblIncio";
            this.lblIncio.Size = new System.Drawing.Size(196, 27);
            this.lblIncio.TabIndex = 0;
            this.lblIncio.Text = "INICIO DE SESIÓN";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(54, 155);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(131, 155);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(171, 22);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(131, 212);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(171, 22);
            this.txtContrasena.TabIndex = 4;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Location = new System.Drawing.Point(32, 218);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(76, 16);
            this.lblContrasena.TabIndex = 3;
            this.lblContrasena.Text = "Contraseña";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(94, 277);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(106, 36);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(216, 277);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(106, 36);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // gbxRegistrar
            // 
            this.gbxRegistrar.Controls.Add(this.lblRegistrar);
            this.gbxRegistrar.Controls.Add(this.btnRegistrarse);
            this.gbxRegistrar.Controls.Add(this.lblUsuarioRegistrar);
            this.gbxRegistrar.Controls.Add(this.txtContrasenaRegistrar);
            this.gbxRegistrar.Controls.Add(this.txtUsuarioRegistrar);
            this.gbxRegistrar.Controls.Add(this.lblContrasenaRegistrar);
            this.gbxRegistrar.Location = new System.Drawing.Point(392, 43);
            this.gbxRegistrar.Name = "gbxRegistrar";
            this.gbxRegistrar.Size = new System.Drawing.Size(357, 324);
            this.gbxRegistrar.TabIndex = 7;
            this.gbxRegistrar.TabStop = false;
            this.gbxRegistrar.Visible = false;
            // 
            // lblRegistrar
            // 
            this.lblRegistrar.AutoSize = true;
            this.lblRegistrar.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistrar.Location = new System.Drawing.Point(58, 18);
            this.lblRegistrar.Name = "lblRegistrar";
            this.lblRegistrar.Size = new System.Drawing.Size(250, 27);
            this.lblRegistrar.TabIndex = 8;
            this.lblRegistrar.Text = "REGISTRO DE USUARIO";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(152, 234);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(106, 36);
            this.btnRegistrarse.TabIndex = 13;
            this.btnRegistrarse.Text = "Registrar";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblUsuarioRegistrar
            // 
            this.lblUsuarioRegistrar.AutoSize = true;
            this.lblUsuarioRegistrar.Location = new System.Drawing.Point(49, 107);
            this.lblUsuarioRegistrar.Name = "lblUsuarioRegistrar";
            this.lblUsuarioRegistrar.Size = new System.Drawing.Size(54, 16);
            this.lblUsuarioRegistrar.TabIndex = 9;
            this.lblUsuarioRegistrar.Text = "Usuario";
            // 
            // txtContrasenaRegistrar
            // 
            this.txtContrasenaRegistrar.Location = new System.Drawing.Point(126, 164);
            this.txtContrasenaRegistrar.Name = "txtContrasenaRegistrar";
            this.txtContrasenaRegistrar.Size = new System.Drawing.Size(171, 22);
            this.txtContrasenaRegistrar.TabIndex = 12;
            // 
            // txtUsuarioRegistrar
            // 
            this.txtUsuarioRegistrar.Location = new System.Drawing.Point(126, 107);
            this.txtUsuarioRegistrar.Name = "txtUsuarioRegistrar";
            this.txtUsuarioRegistrar.Size = new System.Drawing.Size(171, 22);
            this.txtUsuarioRegistrar.TabIndex = 10;
            // 
            // lblContrasenaRegistrar
            // 
            this.lblContrasenaRegistrar.AutoSize = true;
            this.lblContrasenaRegistrar.Location = new System.Drawing.Point(27, 170);
            this.lblContrasenaRegistrar.Name = "lblContrasenaRegistrar";
            this.lblContrasenaRegistrar.Size = new System.Drawing.Size(76, 16);
            this.lblContrasenaRegistrar.TabIndex = 11;
            this.lblContrasenaRegistrar.Text = "Contraseña";
            // 
            // fmrLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxRegistrar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblIncio);
            this.Name = "fmrLogin";
            this.Text = "Login";
            this.gbxRegistrar.ResumeLayout(false);
            this.gbxRegistrar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncio;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblRegistrar;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblUsuarioRegistrar;
        private System.Windows.Forms.TextBox txtContrasenaRegistrar;
        private System.Windows.Forms.TextBox txtUsuarioRegistrar;
        private System.Windows.Forms.Label lblContrasenaRegistrar;
        public System.Windows.Forms.GroupBox gbxRegistrar;
    }
}

