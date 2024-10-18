using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace proyectofinalB
{
    // Clase que representa el formulario principal de la aplicación después de iniciar sesión
    public partial class interfaz : Form
    {
        // Variable privada para almacenar el nombre del usuario
        private string _Usuario;
        // Variable para referirse al formulario de inicio de sesión
        private Form inicio;

        // Constructor que recibe el nombre del usuario y lo almacena
        public interfaz(string textuser)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            _Usuario = textuser; // Asigna el nombre del usuario
        }

        // Constructor que recibe una referencia al formulario de inicio
        public interfaz(Form inicio)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            this.inicio = inicio; // Asigna el formulario de inicio
        }

        // Evento para manejar el clic del botón que abre el control de libros
        private void button1_Click(object sender, EventArgs e)
        {
            UClibros uClibros = new UClibros(); // Crea una instancia del control de libros
            uClibros.Show(); // Muestra el control
            uClibros.BringToFront(); // Lleva el control al frente
        }

        // Evento para minimizar el formulario
        private void btnminimizardashboard_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Cambia el estado de la ventana a minimizada
        }

        // Evento para cerrar la aplicación
        private void btncerrardashboard_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        // Evento del control de carga (sin funcionalidad)
        private void label4_Click(object sender, EventArgs e)
        {

        }

        // Evento que se activa al cargar el formulario
        private void interfaz_Load(object sender, EventArgs e)
        {
            lbluser.Text = _Usuario; // Muestra el nombre del usuario en la etiqueta
        }

        // Evento para manejar el clic del botón de reserva
        private void btnreserva_Click(object sender, EventArgs e)
        {
            UCreserva uCreserva = new UCreserva(); // Crea una instancia del control de reserva
            uCreserva.Show(); // Muestra el control
            uCreserva.BringToFront(); // Lleva el control al frente
        }

        // Evento que permite mover el formulario al arrastrar (sin funcionalidad)
        private void interfaz_MouseDown(object sender, MouseEventArgs e)
        {

        }

        // Evento del clic en el pictureBox (sin funcionalidad)
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        // Evento del botón para cerrar sesión
        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
            inicio.Show(); // Muestra el formulario de inicio de sesión
        }
    }
}

