using System;
using System.Data;
using System.Data.SqlClient;
using Entidad;

namespace Datos
{
    public class DLogin
    {
        private Conexion Cn = new Conexion(); // Crear conexión

        public static DLogin _instancia = null; // Crear instancia vacía

        public static DLogin Instancia // Si ya hay instancia no instanciar
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new DLogin();
                }
                return _instancia;
            }
        }

        public ELogin Login(string Nombre, string Contrasena) // Procedimiento Login
        {
            ELogin Respuesta = null;

            using (SqlConnection connection = new SqlConnection(Conexion.Conex)) // Conexión a bd
            {
                try
                {
                    SqlCommand command = new SqlCommand("Login", connection); // Usando el sp
                    command.Parameters.AddWithValue("Nombre", Nombre); // Parámetros de Login
                    command.Parameters.AddWithValue("Contrasena", Contrasena);
                    command.Parameters.Add("IdUsuario", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.Parameters.Add("EsAdministrador", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    command.ExecuteNonQuery();

                    int idUsuario = Convert.ToInt32(command.Parameters["IdUsuario"].Value); // Devolver usuario y si es administrador
                    int esAdmin = Convert.ToInt32(command.Parameters["EsAdministrador"].Value);

                    Respuesta = new ELogin
                    {
                        IdUsuario = idUsuario,
                        EsAdministrador = esAdmin
                    };

                }
                catch (Exception) // En caso de error
                {
                    Respuesta = null;
                }
            }
            return Respuesta;
        }
    }
}