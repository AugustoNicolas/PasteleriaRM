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
    public class DaProducto
    {
        public List<Producto> GetAll()
        {
            List<Producto> list = new List<Producto>();

            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();

                string sql = @"SELECT * FROM tblProducto";
                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(LoadProducto(reader));
                }

            }

            return list;
        }//end get all

        public List<Producto> GetAllProductosInPedidoById(int id)
        {
            List<Producto> listaDeProductos = new List<Producto>();
            using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {

                conn.Open();
                string sqlDetalle = @"Select P.idProducto, p.precio, p.stock, p.categoria, p.tamaño, p.saborMasa, p.saborRelleno, p.relleno, p.nombre
                                        FROM tblProducto p, tblDetallePedido DP
                                       WHERE p.idProducto = DP.idProducto and DP.idPedido = @idped";
                SqlCommand command = new SqlCommand(sqlDetalle, conn);
                command.Parameters.AddWithValue("@idped", id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listaDeProductos.Add(LoadProducto(reader));
                }
                return listaDeProductos;
            }
        } // end GetAllPedidoById

        public Producto GetProductoById(int id)
        {
            Producto producto = null;
            using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                string sql = @"SELECT * FROM tblproducto WHERE idProducto = @idpro";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idpro", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) producto = LoadProducto(reader);
                return producto;

            }
        }

        public decimal GetPrecioById(int id)
        {
            decimal precio = 0;
            using(SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                conn.Open();
                string sql = @"SELECT precio FROM tblProducto WHERE idProducto = @idpro";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@idpro", id);
                precio = Convert.ToDecimal(cmd.ExecuteScalar());
            }
            return precio;
        }



        private Producto LoadProducto(IDataReader reader)
        {
            Producto pro = new Producto();
            pro.idProducto = Convert.ToInt32(reader["idProducto"]);
            pro.nombre = Convert.ToString(reader["nombre"]);
            pro.precio = Convert.ToInt32(reader["precio"]);
            pro.stock = Convert.ToInt32(reader["stock"]);
            pro.categoria = Convert.ToString(reader["categoria"]);
            pro.tamaño = Convert.ToString(reader["tamaño"]);
            pro.saborMasa = Convert.ToString(reader["saborMasa"]);
            pro.saborRelleno = Convert.ToString(reader["saborRelleno"]);
            pro.relleno = Convert.ToString(reader["relleno"]);

            return pro;
        }// end load
    } //end class
}//end namespace
