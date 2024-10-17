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

    public partial class interfaz : Form
    {
        private string _Usuario;
        public interfaz(string textuser)
        {
            InitializeComponent();
            _Usuario = textuser;
        }
        

        public interfaz()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UClibros uClibros = new UClibros();
            uClibros.Show();
            uClibros.BringToFront();
        }

        private void btnminimizardashboard_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btncerrardashboard_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void interfaz_Load(object sender, EventArgs e)
        {
            lbluser.Text = _Usuario;

        }

        private void btnreserva_Click(object sender, EventArgs e)
        {
            UCreserva uCreserva = new UCreserva();
            uCreserva.Show();
            uCreserva.BringToFront();
        }

        private void interfaz_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
