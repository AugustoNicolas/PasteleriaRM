using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDeDatos;
using System.Transactions;

namespace CapaDeNegocios
{
    public class PedidoCN
    {

        private DaPedido daPedido = new DaPedido();

        public void Create(Pedido invoice)
        {
            // Inicializo la transacción

            using (TransactionScope scope = new TransactionScope())
            {
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();
                Trabajador trabajador = new Trabajador();
                // Creo la factura en la BD
                daPedido.Create(pedido, cliente, trabajador);

                scope.Complete();
            }
        } //end create 
    } //end class
}// end namespace
