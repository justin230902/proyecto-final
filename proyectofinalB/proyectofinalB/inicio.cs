using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace proyectofinalB
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
            
        }

        

[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

  
    private void textuser_MouseEnter(object sender, EventArgs e)
        {

        }

        private void textuser_Enter(object sender, EventArgs e)
        {
            if (textuser.Text == "USUARIO")
            {
                textuser.Text = "";
                textuser.ForeColor = Color.White;
            }
        }

        private void textuser_Leave(object sender, EventArgs e)
        {
            if (textuser.Text == "")
            {
                textuser.Text = "USUARIO";
                textuser.ForeColor = Color.White;
            }
        }

        private void textpass_Enter(object sender, EventArgs e)
        {
            if (textpass.Text == "CONTRASEÑA")
            {
                textpass.Text = "";
                textpass.ForeColor = Color.White;
                textpass.UseSystemPasswordChar = true;
            }
        }

        private void textpass_Leave(object sender, EventArgs e)
        {
            if (textpass.Text == "")
            {
                textpass.Text = "CONTRASEÑA";
                textpass.ForeColor = Color.White;
                textpass.UseSystemPasswordChar = false;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (textuser.Text == "admin" && textpass.Text == "1234") 
            {
                interfaz dashboard = new interfaz(textuser.Text);
                dashboard.Show();

                interfaz dashBoard = new interfaz(this);
                dashBoard.Show();
                this.Hide();
                textuser.Clear();
                textpass.Clear();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas, intenta nuevamente.");
            }

            
        }


        private void textuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnregistrarse_Click(object sender, EventArgs e)
        {
            registro2 uCregistro = new registro2(this);
              this.Hide();
            uCregistro.Show();
           
          
            
        }
    }
}
