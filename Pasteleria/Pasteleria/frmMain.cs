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

namespace Pasteleria
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            this.ttMensaje.SetToolTip(this.btnCerrar, "Cerrar Aplicación");
            this.ttMensaje.SetToolTip(this.btnMinimizar, "Minimizar Pantalla");
            this.ttMensaje.SetToolTip(this.btnMax, "Maximizar Pantalla");
            this.ttMensaje.SetToolTip(this.btnRestaurar, "Restaurar Pantalla");
        }
        //tamaño y ubicación de la pantalla del formulario
        public void pantallaOk()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Se cerraran todas las aplicaciones en curso. Verifique antes de confirmar.", "Mensaje del Sistema:", MessageBoxButtons.OKCancel);
            //Form mensaje = new frmInformation("Desea salir del sistema?");
            //resultado = mensaje.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                //MessageBox.Show("Cerrando la Aplicación");
                Application.Exit();
           
            }
            else
            {
                btnPedidoUser.Focus();
            }
                
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            
            this.WindowState = FormWindowState.Maximized;
            btnMax.Visible = false;
            btnMinimizar.Visible = true;
            btnRestaurar.Visible = true;
        }

        private void panMenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            btnMax.Visible = true;
            btnMinimizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMax.Visible = true;
            btnMinimizar.Visible = true;
            btnRestaurar.Visible = false;
        }
        //Mover ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panBarraTit_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnPedidoUser_Click(object sender, EventArgs e)
        {
            AbrirGestor(new winGestorPedido());
        }
        //Abrir ventanas de Gestor
        public void AbrirGestor(object GestPed)
        {
            if (this.panContenido.Controls.Count > 0)
                this.panContenido.Controls.RemoveAt(0);
            Form Ped = GestPed as Form;
            Ped.TopLevel = false;
            Ped.Dock = DockStyle.Fill;
            this.panContenido.Controls.Add(Ped);
            this.panContenido.Tag = Ped;
            Ped.Show();
                
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pantallaOk();
        }

        private void btnAtencion_Click(object sender, EventArgs e)
        {
            AbrirGestor(new winGestorPedido());
        }
    }
}
