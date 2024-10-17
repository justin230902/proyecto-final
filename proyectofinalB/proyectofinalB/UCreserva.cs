using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace proyectofinalB
{
    public partial class UCreserva : Form
    {
        public UCreserva()
        {
            InitializeComponent();
        }

        


        private void btnatrasreserva_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void UCreserva_Load(object sender, EventArgs e)
        {

        }

        private void btnminimizardashboard_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;

        }

        private void btncerrardashboard_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void UCreserva_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
