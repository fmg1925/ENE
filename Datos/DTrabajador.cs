using Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Datos
{
    public class DTrabajador
    {
        private Conexion Cn = new Conexion(); // Crear conexión

        public static DTrabajador _instancia = null; // Crear instancia vacía

        public static DTrabajador Instancia // Si ya hay instancia no instanciar
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DTrabajador();
                }
                return _instancia;
            }
        }

        public List<ETrabajador> Listar() // Procedimiento Listar
        {
            List<ETrabajador> Lis = new List<ETrabajador>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                SqlCommand cmd = new SqlCommand("Bus_Trabajador", oConexion); // Usando el sp
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    oConexion.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Lis.Add(new ETrabajador() // Listar parámetros del trabajador
                        {
                            IdTrabajador = Convert.ToInt32(dr["IdTrabajador"]),
                            Rut = dr["Rut"].ToString(),
                            Nombre = dr["Nombre"].ToString(),
                            Direccion = dr["Direccion"].ToString(),
                            Telefono = dr["Telefono"].ToString(),
                            HorasTrabajadas = Convert.ToInt32(dr["HorasTrabajadas"]),
                            HorasExtras = Convert.ToInt32(dr["HorasExtras"]),
                            AFP = Convert.ToInt32(dr["AFP"]),
                            Salud = Convert.ToInt32(dr["Salud"]),
                        });
                    }
                    dr.Close();
                    return Lis;
                }
                catch (Exception e) // En caso de error
                {
                    Debug.Print(e.ToString());
                    Lis = null;
                    return Lis;
                }
            }
        }

        public bool Ingresar(ETrabajador obj) // Procedimiento Ingresar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Ing_Trabajador", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("Rut", obj.Rut); // Parámetros de trabajador
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("HorasTrabajadas", obj.HorasTrabajadas);
                    cmd.Parameters.AddWithValue("HorasExtras", obj.HorasExtras);
                    cmd.Parameters.AddWithValue("AFP", obj.AFP);
                    cmd.Parameters.AddWithValue("Salud", obj.Salud);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception e) // En caso de error
                {
                    Debug.Print(e.ToString());
                    Respuesta = false;
                }
            }
            return Respuesta;
        }

        public bool Actualizar(ETrabajador obj) // Procedimiento Actualizar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Act_Trabajador", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdTrabajador", obj.IdTrabajador); // Parámetros de trabajador
                    cmd.Parameters.AddWithValue("Rut", obj.Rut);
                    cmd.Parameters.AddWithValue("Nombre", obj.Nombre);
                    cmd.Parameters.AddWithValue("Direccion", obj.Direccion);
                    cmd.Parameters.AddWithValue("Telefono", obj.Telefono);
                    cmd.Parameters.AddWithValue("HorasTrabajadas", obj.HorasTrabajadas);
                    cmd.Parameters.AddWithValue("HorasExtras", obj.HorasExtras);
                    cmd.Parameters.AddWithValue("AFP", obj.AFP);
                    cmd.Parameters.AddWithValue("Salud", obj.Salud);
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception e) // En caso de error
                {
                    Debug.Print(e.ToString());
                    Respuesta = false;
                }
            }
            return Respuesta;
        }

        public bool Eliminar(int Id) // Procedimiento Eliminar
        {
            bool Respuesta = true;
            using (SqlConnection Con = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Eli_Trabajador", Con); // Usando el sp
                    cmd.Parameters.AddWithValue("IdTrabajador", Id); // Usando id del trabajador
                    cmd.Parameters.Add("Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    Con.Open();
                    cmd.ExecuteNonQuery();
                    Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                }
                catch (Exception e) // En caso de error
                {
                    Debug.Print(e.ToString());
                    Respuesta = false;
                }
            }
            return Respuesta;
        }
    }
}