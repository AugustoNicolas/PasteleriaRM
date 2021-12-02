using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaDeNegocios;

namespace Pasteleria
{
    public partial class frmCompra : Form
    {

        private frmMap mapPage = new frmMap();

        private ProductoCN productoCN;
        private PedidoCN pedidoCN;
        private ClienteCN clienteCN;
        private TrabajadorCN trabajadorCN;

        // Variable global que prepresenta al cliente seleccionado
        // para el pedido de compra
        //

        //Cliente cliente = null;
        Cliente cliente = new Cliente();
        Trabajador trabajador = null;
        Pedido ped = new Pedido();

        public frmCompra()//Inicializar componentes
        {
            InitializeComponent();
            productoCN = new ProductoCN();
            clienteCN = new ClienteCN();
            trabajadorCN = new TrabajadorCN();
            pedidoCN = new PedidoCN();
    }


        #region botones
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            NuevaLinea();
        }
      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion;
        #region labels

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void frmCompra_Load(object sender, EventArgs e)
        {
                //Se carga los items del combo
                DataGridViewComboBoxColumn comboColum = dgvLineaCompra.Columns["nombre"] as DataGridViewComboBoxColumn;
                comboColum.ValueMember = "idProducto"; //obtenemos el id
                comboColum.DisplayMember = "nombre";//se muestra el nombre
                comboColum.DataSource = productoCN.GetAll();
                NuevaLinea();
            
        }
        private void NuevaLinea()
        {
            //Creación de lista DataGridView con la clase que creamos antes
            List<DGVLine> newlist = new List<DGVLine>();
            bool pass = false;
            if (dgvLineaCompra.DataSource != null) //Pregunta si su DataSource está vacio 
            {

                foreach (DataGridViewRow row in dgvLineaCompra.Rows)
                {
                    DGVLine linea = new DGVLine();

                    linea.idProducto = Convert.ToInt32(row.Cells["idProducto"].Value);
                    linea.Producto = Convert.ToInt32(row.Cells["idProducto"].Value);
                    linea.Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    linea.PrecioUnitario = Convert.ToDecimal(row.Cells["precio"].Value);

                    newlist.Add(linea);
                }
                pass = true;
            }
            Queue<DGVLine> list = new Queue<DGVLine>();
            foreach (DGVLine linea in newlist)
            {
                list.Enqueue(linea);
            }
            newlist.Add(new DGVLine()); //se irá añadiendo objetos

            dgvLineaCompra.AutoGenerateColumns = false;
            dgvLineaCompra.DataSource = newlist; //Se cargan los componentes de la lista

            if (pass)
            {
                list.Enqueue(new DGVLine());
                foreach (DataGridViewRow row in dgvLineaCompra.Rows)
                {
                    DGVLine linea = list.Dequeue();
                    row.Cells["idProducto"].Value = linea.idProducto;
                    row.Cells["nombre"].Value = linea.Producto;
                    row.Cells["Cantidad"].Value = linea.Cantidad;
                    row.Cells["precio"].Value = linea.PrecioUnitario;
                }
            }
        }

        private double CalcularTotal()
        {

            double total = 0;
            foreach (DataGridViewRow row in dgvLineaCompra.Rows)
            {
                total += (Convert.ToDouble(row.Cells["precio"].Value) * Convert.ToInt32(row.Cells["cantidad"].Value));
            }
            txtTotal.Text = Convert.ToString(total);
            return total;
        }

        //Se está creando un componente que permita añadirlo al formulario
        DataGridViewComboBoxEditingControl dgvCombo;

        //Permitirá habilitar un control cuando se edite la celda pero de tipo del componente que realizamos
        private void dgvLineaCompra_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            dgvCombo=e.Control as DataGridViewComboBoxEditingControl;

            if (dgvCombo != null)
            {
                dgvCombo.SelectedIndexChanged += new EventHandler(dgvLineaCompra_SelectedIndexChanged);
            }
        }
        private void dgvLineaCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox; //Hará que se despliegue un combobox con la lista de productos
            
            //se toma la fila actual
            DataGridViewRow row = dgvLineaCompra.CurrentRow;

            //Se captura el precio unitario, se convierte y selecciona al siguiente valor
            row.Cells["Precio"].Value = productoCN.GetPrecioByIdProducto(Convert.ToInt32(combo.SelectedValue));
            row.Cells["idProducto"].Value = Convert.ToInt32(combo.SelectedValue);

            //  List<int[]> arrayList = new List<int[]>();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                cliente = clienteCN.GetById(frm.IdCliente); //Mantengo la entidad cliente seleccionada global al formilario

                //muestro en pantalla la info del cliente

                txtId.Text = Convert.ToString(cliente.idCliente);
                txtNit.Text = Convert.ToString(cliente.nit);
                txtNombre.Text = cliente.nombre;
                txtTelf.Text = cliente.telefono;
                
            }
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            if (!Validaciones())
                return;


            #region Creo\Actualizo la informacion del cliente

            //
            // si el cliente se ha seleccionado lo actualizo, sino se crea uno nuevo
            //
            if (cliente == null)
                cliente = new Cliente();

            cliente.idCliente = Convert.ToInt32(txtId.Text);
            cliente.nombre = txtNombre.Text;
            cliente.nit = Convert.ToInt32(txtNit.Text);
            cliente.telefono = txtTelf.Text;

            cliente = clienteCN.SaveCustomer(cliente);

            #endregion

            ped.listaDeProductos = new List<DetallePedido>();
            ped.costo = CalcularTotal();
            foreach (DataGridViewRow row in dgvLineaCompra.Rows)
            {
                DetallePedido producto = new DetallePedido();

                producto.idProducto = Convert.ToInt32(row.Cells["idProducto"].Value);
                producto.cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                ped.costo += Convert.ToInt32(row.Cells["precio"].Value);
                ped.listaDeProductos.Add(producto);
            }
            ped.direccionEntrega = txtRef.Text;

            trabajador = trabajadorCN.GetById(1);
            pedidoCN.Create(ped, cliente, trabajador);
            InicializarControles();
        }
        private bool Validaciones()
        {
            bool result = true;

            errorProvider1.Clear();

            //verifico los campos cliente
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre es obligatorio");
                result=false;
            }
            if(string.IsNullOrEmpty(txtNit.Text))
            {
                errorProvider1.SetError(txtNit, "El NIT es obligatorio");
                result = false;
            }
            if (string.IsNullOrEmpty(txtTelf.Text))
            {
                errorProvider1.SetError(txtTelf, "El teléfono es obligatorio");
                result = false;
            }
            if (string.IsNullOrEmpty(txtId.Text))
            {
                errorProvider1.SetError(txtId, "El id es obligatorio");
                result = false;
            }

            // Validaciones check
            if (chEnvio.Checked)
            {
                if (mapPage.ShowDialog() == DialogResult.OK)
                {
                    errorProvider1.SetError(btnMap, "Seleccione una ubicacion en el mapa");
                    result = false;
                }

                if (string.IsNullOrEmpty(txtRef.Text))
                {
                    errorProvider1.SetError(txtRef, "La referencia es obligatorio");
                    result = false;
                }
            }
            //
            // valido las lineas de compra
            //
                foreach (DataGridViewRow row in dgvLineaCompra.Rows)
            {
                //
                // inicializo las linea de error
                // en caso de tener un mensaje de error previo
                //
                row.ErrorText = "";

                //
                // se validan los campos de la fila
                //
                if (string.IsNullOrEmpty(Convert.ToString(row.Cells["nombre"].Value)))
                {
                    row.ErrorText = "Debe seleccionar in item de compra.";
                    result = false;
                }
                if (string.IsNullOrEmpty(Convert.ToString(row.Cells["precio"].Value)))
                {
                    row.ErrorText = "Debe seleccionar in item de compra.";
                    result = false;
                }
                if (string.IsNullOrEmpty(Convert.ToString(row.Cells["cantidad"].Value)))
                {
                    row.ErrorText = "Debe ingresar una cantidad";
                    result = false;
                }
                else
                {
                    int cantidad = 0;
                    if (!Int32.TryParse(Convert.ToString(row.Cells["cantidad"].Value), out cantidad))
                    {
                        row.ErrorText = "La cantidad ingresada debe ser un valor numerico";
                        result = false;
                    }
                }

            }

            return result;
        }
        /// <summary>
        /// Inicializa el formulario dejandolo preparado para un nuevo pedido
        /// </summary>
        private void InicializarControles()
        {
            //
            // Limpia las lineas del pedido anterior, pero deja preparada
            // una nueva linea lista para seleccionar el item
            //
            List<DGVLine> list = dgvLineaCompra.DataSource as List<DGVLine>;
            list.Clear();
            dgvLineaCompra.DataSource = null;

            NuevaLinea();

            cliente = null;

            txtNit.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtRef.Text = string.Empty;
            txtTelf.Text = string.Empty;
            txtId.Text = string.Empty;
            chEnvio.Checked = false;
        }

        private void dgvLineaCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvCombo != null)
                dgvCombo.SelectedIndexChanged -= new EventHandler(dgvLineaCompra_SelectedIndexChanged);
            CalcularTotal();
        }

        private void dgvLineaCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            //boton para debug de las ventanas del Main
        {
            frmMain WinMain = new frmMain();
            WinMain.Show();
            this.Visible = false;
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            mapPage.ShowDialog();
            DataTable dt = mapPage.DatosMap();
            if (dt.Rows.Count > 0)
            {
                ped.descripcionMap = dt.Rows[0].ItemArray[0].ToString();
                ped.lat = Convert.ToDouble(dt.Rows[0].ItemArray[1].ToString());
                ped.lng = Convert.ToDouble(dt.Rows[0].ItemArray[2].ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    public class DGVLine: ICloneable //Creará una nueva línea
        {
            public int? Producto { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public int idProducto { get; set; }

        #region ICloneable Members
        public object Clone()
            {
                DGVLine item = new DGVLine(); //Se crea el item

                item.Producto = this.Producto;
                item.Cantidad = this.Cantidad;
                item.PrecioUnitario = this.PrecioUnitario;
                item.idProducto = this.idProducto;

            return item; //devuelve un item como línea

            }

            #endregion
        }
}
