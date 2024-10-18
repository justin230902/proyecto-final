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
    // Clase que representa el control de libros
    public partial class UClibros : Form
    {
        // Constructor que inicializa el formulario
        public UClibros()
        {
            InitializeComponent(); // Llama al método para inicializar los componentes del formulario
        }

        // Evento que se activa al cargar el formulario
        private void UClibros_Load(object sender, EventArgs e)
        {
        }

        // Evento que maneja el clic en el label1 (sin funcionalidad actualmente)
        private void label1_Click(object sender, EventArgs e)
        {
        }

        // Evento que maneja el clic en el label2 (sin funcionalidad actualmente)
        private void label2_Click(object sender, EventArgs e)
        {
        }

        // Evento que maneja el clic del botón "atras"
        private void btnlibrosatras_Click(object sender, EventArgs e)
        {
            this.Hide(); // Oculta el formulario actual
        }

        // Evento que minimiza el formulario
        private void btnminimizardashboard_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Cambia el estado de la ventana a minimizada
        }

        // Evento que cierra la aplicación
        private void btncerrardashboard_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        // Evento que permite mover el formulario al arrastrar (sin funcionalidad actualmente)
        private void UClibros_MouseDown(object sender, MouseEventArgs e)
        {
            // Aquí puedes agregar lógica si es necesario
        }
    }
}
