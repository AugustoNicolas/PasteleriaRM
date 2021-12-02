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

        public void Create(Pedido pedido, Cliente cliente, Trabajador trabajador)
        {
            // Inicializo la transacción
            pedido.fechaInicio = DateTime.Now;
            pedido.numPedido = (CountNumPed() + 1);
            if (pedido.status == 0) pedido.status = 1;

            if (pedido.fechaEntrega < DateTime.Now) pedido.fechaEntrega = DateTime.Now;

            if (pedido.direccionEntrega == null) pedido.direccionEntrega = "";

            using (TransactionScope scope = new TransactionScope())
            {
                // Creo la factura en la BD
                if (pedido.direccionEntrega != null && pedido.lat != null && pedido.lng != null)
                    daPedido.CreateWithMap(pedido, cliente, trabajador);
                else
                    daPedido.Create(pedido, cliente, trabajador);

                scope.Complete();
            }
        } //end create 

        public int CountNumPed()
        {
            return daPedido.CountNumPed();
        }
    } //end class
}// end namespace
