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
    public partial class frmProduccion : Form
    {
        private IngredientesCN cnIngredientes = new IngredientesCN();
        private Ingredientes ingrediente = new Ingredientes();

        public frmProduccion()
        {
            InitializeComponent();
        }

        private void frmProduccion_Load(object sender, EventArgs e)
        {
            dgIngredietes.DataSource = cnIngredientes.GetAll();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
