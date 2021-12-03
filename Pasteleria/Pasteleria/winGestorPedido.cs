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

namespace Pasteleria
{
    public partial class winGestorPedido : Form
    {
        private PedidoCN pedidocn = new PedidoCN();
        private List<Pedido> listaDePedidos = new List<Pedido>();

        public winGestorPedido()
        {
            InitializeComponent();

            this.ttMesagge.SetToolTip(this.btnAsignar, "Asignar la ejecución del pedido");
            this.ttMesagge.SetToolTip(this.btnCerrar, "Pedido Elaborado: Cerrar Pedido");
            this.ttMesagge.SetToolTip(this.btnPedidosPen, "Listar pedidos pendientes Sin Asignar");
            this.ttMesagge.SetToolTip(this.btnPedidosNoCerrados, "Listar pedidos en proceso de preparación");
            this.ttMesagge.SetToolTip(this.btnPedidosCerrados, "Listar los pedidos cerrados por fecha");
        }

        

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ttMesagge_Popup(object sender, PopupEventArgs e)
        {

        }

        private void winGestorPedido_Load(object sender, EventArgs e)
        {
            DGPed.DataSource = Filtrador(1);
            
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            winAsignarPed frm = new winAsignarPed();
            frm.listaDePedidos = this.listaDePedidos;
            frm.ShowDialog();
            DGPed.DataSource = Filtrador(1);
            this.listaDePedidos = new List<Pedido>();
            
        }

        private void DGPed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pedido pedido = new Pedido();

            pedido.idPedido = Convert.ToInt32(DGPed.Rows[e.RowIndex].Cells["idPedido"].Value);
            //if (listaDePedidos.Contains(pedido))
            //else
            //    listaDePedidos.Add(pedido);

            if (Convert.ToBoolean(DGPed.Rows[e.RowIndex].Cells["check"].Value) == true)
            {
                DGPed.Rows[e.RowIndex].Cells["check"].Value = false;
                foreach(Pedido pedidoVar in listaDePedidos)
                {
                    if(pedidoVar.idPedido == pedido.idPedido)
                    {
                        listaDePedidos.Remove(pedidoVar);
                        break;
                    }
                }
            }
            else
            {
                DGPed.Rows[e.RowIndex].Cells["check"].Value = true;
                listaDePedidos.Add(pedido);
            }
            //foreach(DataRow row in DGPed.Rows)
            //{
            //    row = 5;
            //}
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnPedidosPen_Click(object sender, EventArgs e)
        {
            DGPed.DataSource = Filtrador(1);
        }

        private List<Pedido> Filtrador(int status)
        {
            List<Pedido> listaFiltradaDePedidos = new List<Pedido>();
            foreach (Pedido pedido in pedidocn.GetAll())
            {
                if (pedido.status == status)
                    listaFiltradaDePedidos.Add(pedido);
            }
            return listaFiltradaDePedidos;
        }

        private void btnPedidosNoCerrados_Click(object sender, EventArgs e)
        {
            DGPed.DataSource = Filtrador(2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DGPed.DataSource = Filtrador(3);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            foreach(Pedido pedido in listaDePedidos)
            {
                pedidocn.CerrarPedido(pedido);
            }
            DGPed.DataSource = Filtrador(3);
        }
    }
}
