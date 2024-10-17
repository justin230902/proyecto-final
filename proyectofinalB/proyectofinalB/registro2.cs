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
    public partial class registro2 : Form
    {
        private Form inicio;
        public registro2(Form inicio)
        {
            InitializeComponent();
            this.inicio = inicio;
        }
        private bool ValidarRegistro()
        {
          
                if (string.IsNullOrEmpty(txtnombreregistro.Text) || string.IsNullOrEmpty(txtapellidoregistro.Text) || string.IsNullOrEmpty(txtpassregistro.Text))
                {
                    MessageBox.Show("Completa todos los campos.");
                    return false;
                }
            return true;
        }
        private void GuardarDatos()
        {
            // Código para guardar los datos
            MessageBox.Show("Registro completado con éxito.");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarRegistro())
            {
                GuardarDatos();
                this.Close();
                inicio.Show();
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            inicio.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtapellidoregistro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
