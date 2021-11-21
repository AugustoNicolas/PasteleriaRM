using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class DaPedido
    {
        /// <summary>
        /// Metodo para armar un pedido por medio de un reader
        /// </summary>
        /// 
        // Dejar para fase 2 del proyecto 
        private Pedido LoadPedido(IDataReader reader)
        {
            Pedido ped = new Pedido();
            ped.idPedido = Convert.ToInt32(reader["idPedido"]);
            ped.numPedido = Convert.ToInt32(reader["numPedido"]);
            ped.fechaInicio = Convert.ToDateTime(reader["fechaInicio"]);
            ped.fechaEntrega = Convert.ToDateTime(reader["fechaEntrega"]);
            ped.costo = Convert.ToInt32(reader["costo"]);
            ped.direccionEntrega = Convert.ToString(reader["direccion"]);
            ped.status = Convert.ToInt32(reader["estado"]);

            return ped;
        } //end loadpedido

        public List<Pedido> GetAll()
        {
            List<Pedido> list = new List<Pedido>();

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();

                string sql = @"SELECT * FROM tblPedido";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(LoadPedido(reader));
                }

            }

            return list;
        }//end get all

        public Pedido GetById(int id)
        {
            Pedido pedido = null;
            DaProducto DAproducto = new DaProducto();
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT * FROM tblPedido WHERE idPedido = @idped";
                    using(SqlCommand cmd = new SqlCommand(sql, conn))
                    {

                        cmd.Parameters.AddWithValue("@idped", id);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            pedido = LoadPedido(reader);
                            pedido.listaDeProductos = DAproducto.GetAllProductosInPedidoById(id);                                                    
                        }
                    }                   

                    return pedido;
                }
                catch
                {
                    throw;
                }
            }
        } // end get by id

        public void Create(Pedido ped, Cliente cliente, Trabajador trabajador)
        {
            using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"INSERT into tblPedido (numPedido, fechaInicio, fechaEntrega, costo, dirreccion, estado, idCliente, idTrabajador)
                values (@numped,@fechaIni, @fechaFin,@costo,@direccion,@estado,@idcliente,@idTrabajador)";

                using(SqlCommand cmd = new SqlCommand(sql, conn))
                    //linea para pedido
                {
                    cmd.Parameters.AddWithValue("@numped", ped.numPedido);
                    cmd.Parameters.AddWithValue("@fechaIni", ped.fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", ped.fechaEntrega);
                    cmd.Parameters.AddWithValue("@costo", ped.costo);
                    cmd.Parameters.AddWithValue("@direccion", ped.direccionEntrega);
                    cmd.Parameters.AddWithValue("@estado", ped.status);
                    cmd.Parameters.AddWithValue("@idcliente", cliente.idCliente);
                    cmd.Parameters.AddWithValue("@idTrabajador", trabajador.idTrabajador);
                }
                //linea para el detalle del pedido
                string sqlDetalle = @"INSERT INTO tblDetallePedido(idProducto, idPedido) values (@idpro, @idped)";
                using (SqlCommand cmd = new SqlCommand(sqlDetalle, conn))
                //linea para pedido
                {
                    foreach(Producto producto in ped.listaDeProductos)
                    {
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@idpro", producto.idProducto);
                        cmd.Parameters.AddWithValue("@fechaIni", ped.idPedido);

                        producto.idProducto = Convert.ToInt32(cmd.ExecuteScalar());

                    }
                }

            }
        }// end create

        public decimal GetPrecioByIdPedido(int id)
        {
            decimal precio = 0;

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();

                string sql = @"SELECT precio FROM tblProducto WHERE idProducto = @idProducto";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idProducto", Convert.ToInt32(id));
                precio = Convert.ToDecimal(cmd.ExecuteScalar());

            }

            return precio;

        } // end precio by id



    }// end class
} //end namesapce
