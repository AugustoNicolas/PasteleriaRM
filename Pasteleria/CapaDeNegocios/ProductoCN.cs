using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CapaDeDatos;
using Entidades;

namespace CapaDeNegocios
{
    public class ProductoCN
    {
        private DaProducto daProducto = new DaProducto();       

        public List<Producto> GetAll()
        {
            return daProducto.GetAll();
        } // end GetAll

        public Producto GetProductoByid(int id)
        {
            try
            {
                if (id >= 0)
                {
                    return daProducto.GetProductoById(id);
                }
                else
                {
                    throw new Exception("El id debe ser mayor o igual a 0....");
                }
            }
            catch (Exception)
            {
                throw;
            }
        } //end GetProductoByid

        public decimal GetPrecioByIdProducto(int id)
        {
            try
            {
                if (id >= 0)
                {
                    return daProducto.GetPrecioById(id);
                }
                else
                {
                    //colocar una excepcion;
                    throw new Exception("El id debe ser mayor o igual a 0....");
                }

            }
            catch (Exception)
            {

                throw;
            }

        }// end GetPrecioByIdProducto
    } //end class
}// end namespace
