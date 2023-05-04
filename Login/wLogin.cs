using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class fmrLogin : Form
    {

        // Variables para almacenar los datos de registro y login
        string UsuarioRegistro;
        string ContrasenaRegistro;
        string Usuario;
        string Contrasena;

        // Contador para llevar registro de intentos fallidos de login
        int contador;

        // Bandera para verificar si se han registrado usuarios previamente
        bool bandera = false;

        public fmrLogin()
        {
            InitializeComponent();
        }

        // Método para mostrar el panel de registro al hacer clic en el botón "Registrar"
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            gbxRegistrar.Visible = true;
            bandera = true;
        }

        // Método para registrar un nuevo usuario al hacer clic en el botón "Registrarse"
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            UsuarioRegistro = txtUsuarioRegistrar.Text;
            ContrasenaRegistro = txtContrasenaRegistrar.Text;
            gbxRegistrar.Visible = false;
        }

        // Método para validar el usuario y contraseña al hacer clic en el botón "Iniciar"
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Usuario = txtUsuario.Text;
            Contrasena = txtContrasena.Text;

            // Si no hay usuarios registrados, muestra un mensaje de error
            if (bandera == false)
            {
                MessageBox.Show("Sin registros previos");
            }
            else
            {
                // Si el usuario y contraseña coinciden con los registrados, muestra el formulario de bienvenida
                if (Usuario == UsuarioRegistro && Contrasena == ContrasenaRegistro)
                {
                    fmrBienvenido fmrBienvenido = new fmrBienvenido();
                    fmrBienvenido.Show();
                    contador = 0;
                }
                else
                {
                    contador++;
                    // Si hay menos de 3 intentos fallidos, muestra un mensaje de error
                    if (contador < 3)
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecto. Vuelva a intentar");
                    }
                    // Si hay 3 o más intentos fallidos, muestra un mensaje de error y cierra el formulario de login
                    else
                    {
                        MessageBox.Show("Muchos intentos erroneos. Bloqueado");
                        this.Close();
                    }
                }
            }
        }
    }
}
// Codigo hecho por Sneider Velasquez Iglesias
// 4 de abril de 2023