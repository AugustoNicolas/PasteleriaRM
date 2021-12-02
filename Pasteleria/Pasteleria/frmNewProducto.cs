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
    public partial class frmNewProducto : Form
    {
        public Producto producto = new Producto();
        private ProductoCN cnproducto = new ProductoCN();

        public frmNewProducto()
        {
            InitializeComponent();
        }

        private void frmNewProducto_Load(object sender, EventArgs e)
        {
            if (!producto.Equals(new Producto()))
            {
                txtNombre.Text = producto.nombre;
                txtPrecio.Text = Convert.ToString(producto.precio);
                txtCategoria.Text = producto.categoria;
                txtTama.Text = producto.tamaño;
                if (producto.foto != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(producto.foto);
                    imgBox.Image = Image.FromStream(ms);
                }
                    
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.producto.nombre = txtNombre.Text;
            this.producto.precio = Convert.ToDouble(txtPrecio.Text);
            this.producto.tamaño = txtTama.Text;
            this.producto.categoria = txtCategoria.Text;

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            if(imgBox.Image != null)
            {
                imgBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                this.producto.foto = ms.GetBuffer();
            }

            cnproducto.Create(producto);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog foto = new OpenFileDialog();
            DialogResult rs = foto.ShowDialog();
            if (rs == DialogResult.OK)
            {
                imgBox.Image = Image.FromFile(foto.FileName);
            }
        }
    }
}
