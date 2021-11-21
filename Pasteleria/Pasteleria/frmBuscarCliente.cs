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
    public partial class frmBuscarCliente : Form
    {
        private int _idCliente;
        private ClienteCN clienteCN;
        public frmBuscarCliente()
        {
            InitializeComponent();
            clienteCN = new ClienteCN();
        }
        public int IdCliente
        {
            get { return _idCliente; }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = clienteCN.GetAll();
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            _idCliente = Convert.ToInt32(dgvClientes.Rows[e.RowIndex].Cells["id"].Value);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
