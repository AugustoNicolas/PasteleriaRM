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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void panContenido_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AbrirFromHija(object formhija)
        {
            if (this.panContenido.Controls.Count > 0)
                this.panContenido.Controls.RemoveAt(0);

            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panContenido.Controls.Add(fh);
            this.panContenido.Tag = fh;
            fh.Show();
        }

        private void btnPedidoUser_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new frmCompra());
        }
    }
}
