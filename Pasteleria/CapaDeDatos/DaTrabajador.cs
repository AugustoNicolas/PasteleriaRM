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
    public class DaTrabajador
    {
        private Trabajador LoadTrabajador(IDataReader reader)
        {
            Trabajador trabajador = new Trabajador();
            trabajador.idTrabajador = Convert.ToInt32(reader["idTrabajador"]);
            trabajador.ciTrabajador = Convert.ToInt32(reader["ciTrabajador"]);
            trabajador.nombre = Convert.ToString(reader["nombre"]);
            trabajador.telefono = Convert.ToString(reader["telf"]);
            trabajador.nick = Convert.ToString(reader["nick"]);
            trabajador.dateIn = Convert.ToDateTime(reader["dateIn"]);
            if (reader["dateMod"] != DBNull.Value)
               trabajador.dateMod = Convert.ToDateTime(reader["dateMod"]);


            return trabajador;
        } //end trabajador 

        public List<Trabajador> GetAll()
        {
            List<Trabajador> listaDeTrabajadores = new List<Trabajador>();
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT * FROM tblTrabajador ORDER BY nombre";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listaDeTrabajadores.Add(LoadTrabajador(reader));
                    }
                    return listaDeTrabajadores;
                }
                catch
                {
                    throw;
                }
            }
        } // end get all

        public Trabajador GetById(int id)
        {
            Trabajador trabajador = null;
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT * FROM tblTrabajador WHERE idTrabajador = @idTra";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@idTra", id);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) trabajador = LoadTrabajador(reader);
                    return trabajador;
                }
                catch
                {
                    throw;
                }
            }
        } // end get by id

        public bool Exist(int id)
        {
            int nrorecrd = 0;
            using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
            {
                try
                {
                    conn.Open();
                    string sql = @"SELECT Count(*)  FROM tblTrabajador     WHERE idTrabajador = @idtra";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@idtra", id);
                    nrorecrd = Convert.ToInt32(cmd.ExecuteScalar());

                    return nrorecrd > 0;

                }
                catch
                {
                    throw;
                }
            }
        } // end exist

        //Listas por nick de trabajadores
        public List<Trabajador> GetNick()
        {
            try
            {
                List<Trabajador> listaDeTrabajadores = new List<Trabajador>();
                using (SqlConnection conn = new SqlConnection(ConexionSQL.ObtenerCadenaConexion()))
                {
                    conn.Open();
                    string sql = @"SELECT nick,idTrabajador  FROM tblTrabajador";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Trabajador trabajador = new Trabajador();
                        trabajador.nick = Convert.ToString(reader["nick"]);
                        trabajador.idTrabajador= Convert.ToInt32(reader["idTrabajador"]);
                    }
                    return listaDeTrabajadores;

                }
            }


            catch
            {
                throw;
            }

        }


    } //end class
} // end namesapce
