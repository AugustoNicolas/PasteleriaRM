using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocios;
using Entidades;
using System.Runtime.InteropServices;

namespace Pasteleria
{
    public partial class winAsignarPed : Form
    {
        private TrabajadorCN cntrabajador = new TrabajadorCN();
        private PedidoCN cnPedido = new PedidoCN();
        public List<Pedido> listaDePedidos = new List<Pedido>();
        Trabajador trabajador = new Trabajador();

        //Mover ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public winAsignarPed()
        {
            InitializeComponent();
        }

        private void DGPedSel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void winAsignarPed_Load(object sender, EventArgs e)
        {
            DGTrabajador.DataSource = cntrabajador.GetAll();

            DGTrabajador.Columns["nombre"].Visible = false;
            DGTrabajador.Columns["idTrabajador"].Visible = false;
            DGTrabajador.Columns["ciTrabajador"].Visible = false;
            DGTrabajador.Columns["telefono"].Visible = false;
            DGTrabajador.Columns["dateIn"].Visible = false;
            DGTrabajador.Columns["dateMod"].Visible = false;

            this.Location = new Point(863, 252);

        }

        private void winAsignarPed_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        public Trabajador GetTrabajador()
        {
            return trabajador;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            trabajador.idTrabajador = Convert.ToInt32(DGTrabajador.Rows[e.RowIndex].Cells["idTrabajador"].Value);

            DGTrabajador.Rows[e.RowIndex].Cells["cbkTrabajador"].Value = true;

            foreach (DataGridViewRow row in DGTrabajador.Rows)
            {
                if (row != DGTrabajador.Rows[e.RowIndex])
                {
                    row.Cells["cbkTrabajador"].Value = false;
                }
            }
        }

        private void DGTrabajador_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            foreach(Pedido pedido in listaDePedidos)
            {
                pedido.idTrabajador = trabajador.idTrabajador;
                cnPedido.AsignarPedido(pedido);
            }
            this.Close();
        }
    }
}
