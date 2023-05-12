using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace Login
{
    /// <summary>
    /// Hecho por Sneider Velasquez Iglesias 
    /// Este codigo es un login conectado a una base de datos
    /// </summary>
    public partial class fmrLogin : Form
    {

        // Variables para almacenar los datos de registro y login
        string UsuarioRegistro;
        string ContrasenaRegistro;
        string Usuario;
        string Contrasena;

        // Contador para llevar registro de intentos fallidos de login
        int contador;
        public fmrLogin()
        {
            InitializeComponent();
        }

        // Método para mostrar el panel de registro al hacer clic en el botón "Registrar"
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            gbxRegistrar.Visible = true;
        }

        // Método para registrar un nuevo usuario al hacer clic en el botón "Registrarse"
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            //Utilizamos estos tres objetos de SQLite
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;

            //Crear una nueva conexión de la base de datos
            conexion_sqlite = new SQLiteConnection("Data Source=dbRegistros_de_Usuario2.db;Version=3;Compress=False;");

            try
            {
                //Abriremos la conexión
                conexion_sqlite.Open();
            }
            catch (Exception ex)
            { 
                MessageBox.Show("La base de datos no se encuentra en la ruta");
            }
            cmd_sqlite = conexion_sqlite.CreateCommand();

            ////El objeto SQLiteCommando va a conocer la consulta de SQL
            ///cmd_sqlite.CommandText = "CREATE TABLE tbl_Registros(ID integer primary key,Usuario varchar(100), Contraseña varchar(100));";

            ////Ejecutaremos la consulta que hemos creado
            ///cmd_sqlite.ExecuteNonQuery();

            UsuarioRegistro = txtUsuarioRegistrar.Text;
            ContrasenaRegistro = txtContrasenaRegistrar.Text;
            try
            {
                //Insertando datos en la tabla
                cmd_sqlite.CommandText = $"INSERT INTO tbl_Registros(Usuario, Contraseña) VALUES('{UsuarioRegistro}', '{ContrasenaRegistro}')";
                cmd_sqlite.ExecuteNonQuery();
            }catch (Exception ex) 
            {
                MessageBox.Show("Usuario Existente.");
            }
            gbxRegistrar.Visible = false;
            conexion_sqlite.Close();
        }

        // Método para validar el usuario y contraseña al hacer clic en el botón "Iniciar"
        private void btnIniciar_Click(object sender, EventArgs e)
        {

            //Utilizamos estos tres objetos de SQLite
            SQLiteConnection conexion_sqlite;
            SQLiteCommand cmd_sqlite;
            SQLiteDataReader datareader_sqlite;

            //Crear una nueva conexión de la base de datos
            conexion_sqlite = new SQLiteConnection("Data Source=dbRegistros_de_Usuario2.db;Version=3;Compress=True;");
            try
            {
                //Abriremos la conexión
                conexion_sqlite.Open();
            }catch (Exception ex) { MessageBox.Show("La base da datos no se encuentra en la ruta."); }
            cmd_sqlite = conexion_sqlite.CreateCommand();

            Usuario = txtUsuario.Text;
            Contrasena = txtContrasena.Text;

            cmd_sqlite.CommandText = $"SELECT Usuario, Contraseña FROM tbl_Registros WHERE Usuario = '{Usuario}' AND Contraseña = '{Contrasena}'";
            datareader_sqlite = cmd_sqlite.ExecuteReader();

            // Si el usuario y contraseña coinciden con los registrados, muestra el formulario de bienvenida
            if (datareader_sqlite.Read())
            {
                fmrBienvenido fmrBienvenido = new fmrBienvenido();
                fmrBienvenido.Show();
                contador = 0;
                txtUsuario.Text = null;
                txtContrasena.Text = null;
                conexion_sqlite.Close();
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
                    conexion_sqlite.Close();
                    this.Close();
                }
            }
        }
    }
}