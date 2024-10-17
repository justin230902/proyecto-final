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
    public partial class UClibros : Form 
    {
        
        public UClibros()
        {
            InitializeComponent();
        }

        private void UClibros_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlibrosatras_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void btnminimizardashboard_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btncerrardashboard_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void UClibros_MouseDown(object sender, MouseEventArgs e)
        {
           
        }
    }
}
