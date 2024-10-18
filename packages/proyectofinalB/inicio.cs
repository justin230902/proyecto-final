using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectofinalB
{
    // Clase que representa el formulario de inicio de sesión
    public partial class login : Form
    {
        // Constructor del formulario de inicio de sesión
        public login()
        {
            InitializeComponent(); // Inicializa los componentes del formulario
        }

        // Importaciones de funciones de la API de Windows para mover la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Evento cuando el mouse entra en el campo de usuario (sin funcionalidad)
        private void textuser_MouseEnter(object sender, EventArgs e)
        {

        }

        // Evento que se activa cuando el campo de usuario recibe foco
        private void textuser_Enter(object sender, EventArgs e)
        {
            // Si el texto es "USUARIO", lo limpia y cambia el color del texto
            if (textuser.Text == "USUARIO")
            {
                textuser.Text = "";
                textuser.ForeColor = Color.White;
            }
        }

        // Evento que se activa cuando el campo de usuario pierde foco
        private void textuser_Leave(object sender, EventArgs e)
        {
            // Si el campo está vacío, restaura el texto y el color original
            if (textuser.Text == "")
            {
                textuser.Text = "USUARIO";
                textuser.ForeColor = Color.White;
            }
        }

        // Evento que se activa cuando el campo de contraseña recibe foco
        private void textpass_Enter(object sender, EventArgs e)
        {
            // Si el texto es "CONTRASEÑA", lo limpia y activa la visualización de caracteres como contraseña
            if (textpass.Text == "CONTRASEÑA")
            {
                textpass.Text = "";
                textpass.ForeColor = Color.White;
                textpass.UseSystemPasswordChar = true; // Muestra los caracteres como puntos
            }
        }

        // Evento que se activa cuando el campo de contraseña pierde foco
        private void textpass_Leave(object sender, EventArgs e)
        {
            // Si el campo está vacío, restaura el texto y el color original
            if (textpass.Text == "")
            {
                textpass.Text = "CONTRASEÑA";
                textpass.ForeColor = Color.White;
                textpass.UseSystemPasswordChar = false; // Muestra el texto sin ocultarlo
            }
        }

        // Evento del botón de cerrar
        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        // Evento del botón para minimizar el formulario
        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Cambia el estado de la ventana a minimizada
        }

        // Evento para mover el formulario al arrastrar (permite mover la ventana sin barra de título)
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); // Libera el mouse
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Envía el mensaje de movimiento a la ventana
        }

        // Evento del clic en el pictureBox (sin funcionalidad)
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); // Libera el mouse
            SendMessage(this.Handle, 0x112, 0xf012, 0); // Envía el mensaje de movimiento a la ventana
        }

        // Evento del botón para ingresar al sistema
        private void btningresar_Click(object sender, EventArgs e)
        {
            // Verifica si la contraseña ingresada coincide con la contraseña almacenada en la base de datos
            if (textpass.Text == BaseDeDatos.ComprobarLogin(textuser.Text))
            {
                interfaz dashboard = new interfaz(textuser.Text); // Crea una instancia del formulario de interfaz
                interfaz dashBoard = new interfaz(this); // Crea otra instancia de interfaz con el formulario actual
                dashBoard.Show(); // Muestra el nuevo formulario
                this.Hide(); // Oculta el formulario de inicio de sesión
                textuser.Clear(); // Limpia el campo de usuario
                textpass.Clear(); // Limpia el campo de contraseña
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas, intenta nuevamente."); // Mensaje de error
            }
        }

        // Evento que se activa cuando el texto en el campo de usuario cambia (sin funcionalidad)
        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }

        // Evento que se activa al cargar el formulario (sin funcionalidad)
        private void login_Load(object sender, EventArgs e)
        {

        }

        // Evento del botón para registrarse
        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            registro uCregistro = new registro(this); // Crea una instancia del formulario de registro
            this.Hide(); // Oculta el formulario de inicio de sesión
            uCregistro.Show(); // Muestra el formulario de registro
        }
    }
}
