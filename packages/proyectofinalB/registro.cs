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
    // Clase que representa el formulario de registro
    public partial class registro : Form
    {
        // Variable privada para almacenar una referencia al formulario de inicio de sesión
        private Form inicio;

        // Constructor que recibe como parámetro el formulario de inicio
        public registro(Form inicio)
        {
            InitializeComponent(); // Inicializa los componentes del formulario
            this.inicio = inicio;  // Asigna el formulario de inicio a la variable 'inicio'
        }

        // Método privado para validar los campos de registro
        private bool ValidarRegistro()
        {
            // Comprueba si los campos de nombre y contraseña están vacíos
            if (string.IsNullOrEmpty(txtnombreregistro.Text) || string.IsNullOrEmpty(txtpassregistro.Text))
            {
                MessageBox.Show("Completa todos los campos."); // Muestra un mensaje de advertencia si están vacíos
                return false; // Retorna falso si no se han llenado los campos
            }
            return true; // Retorna verdadero si los campos están completos
        }

        // Método privado para guardar los datos del usuario
        private void GuardarDatos(string nombre, string clave)
        {
            // Llama al método RegistrarUsuarios de la clase BaseDeDatos para guardar el usuario
            BaseDeDatos.RegistrarUsuarios(nombre, clave);

            // Muestra un mensaje confirmando que el registro fue exitoso
            MessageBox.Show("Registro completado con éxito.");
        }

        // Evento del botón para confirmar el registro
        private void button1_Click(object sender, EventArgs e)
        {
            // Primero valida que los campos estén correctamente llenos
            if (ValidarRegistro())
            {
                // Si la validación es exitosa, se guardan los datos
                GuardarDatos(txtnombreregistro.Text, txtpassregistro.Text);

                // Cierra el formulario de registro
                this.Close();

                // Muestra nuevamente el formulario de inicio de sesión
                inicio.Show();
            }
        }

        // Evento del botón para volver al formulario de inicio sin completar el registro
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario actual
            inicio.Show(); // Muestra el formulario de inicio
        }

        // Evento del clic en la etiqueta (sin funcionalidad asignada)
        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Evento para minimizar el formulario al hacer clic en el botón de minimizar
        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Cambia el estado de la ventana a minimizada
        }

        // Evento para cerrar la aplicación al hacer clic en el botón de cerrar
        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        // Evento cuando el texto en el campo de contraseña cambia (sin funcionalidad adicional)
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Evento cuando el texto en el campo de apellido cambia (sin funcionalidad adicional)
        private void txtapellidoregistro_TextChanged(object sender, EventArgs e)
        {

        }

        // Evento del clic en la etiqueta (sin funcionalidad asignada)
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
