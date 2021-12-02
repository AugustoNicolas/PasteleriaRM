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
    public partial class frmTrabajador : Form
    {
        private TrabajadorCN cnTrabajador = new TrabajadorCN();
        private Trabajador trabajador = new Trabajador();

        public frmTrabajador()
        {
            InitializeComponent();
        }

        private void frmTrabajador_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void CargarGrid()
        {
            dgTrabajadores.DataSource = cnTrabajador.GetAll();
        }

        private void dgTrabajadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            trabajador.idTrabajador = Convert.ToInt32(dgTrabajadores.Rows[e.RowIndex].Cells["idTrabajador"].Value);
            trabajador.nombre = Convert.ToString(dgTrabajadores.Rows[e.RowIndex].Cells["nombre"].Value);


            txtCi.Text = Convert.ToString(dgTrabajadores.Rows[e.RowIndex].Cells["ciTrabajador"].Value);
            txtTelf.Text = Convert.ToString(dgTrabajadores.Rows[e.RowIndex].Cells["telf"].Value);
            txtNombre.Text = Convert.ToString(dgTrabajadores.Rows[e.RowIndex].Cells["nombre"].Value);

            dgTrabajadores.Rows[e.RowIndex].Cells["check"].Value = true;

            foreach (DataGridViewRow row in dgTrabajadores.Rows)
            {
                if (row != dgTrabajadores.Rows[e.RowIndex])
                {
                    row.Cells["check"].Value = false;
                }
            }
        } // end dgTrabajadores_CellContentClick

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Validaciones())
            {
                string message = $"Seguro que deesa eliminar el producto {trabajador.nombre}?";
                string caption = "Eliminando...";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    cnTrabajador.Delete(trabajador);
                    CargarGrid();
                }
            }

        }

        private bool Validaciones()
        {
            bool result = true;
            if (trabajador.nombre == null || trabajador.idTrabajador == 0)
            {
                errorProvider1.SetError(dgTrabajadores, "Seleccione un trabajador");
                result = false;
            }
            //if (string.IsNullOrEmpty(txtTelf.Text))
            //{
            //    errorProvider1.SetError(txtTelf, "El campo no puede estar vacio");
            //    result = false;
            //}
                return result;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    } //end class
}// end namespace
