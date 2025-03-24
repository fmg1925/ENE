using Datos;
using Entidad;

namespace Negocio
{
    public class NLogin
    {
        private DLogin Datos = new DLogin();

        public ELogin Login(string Nombre, string Contraseña) // Llamar al procedimiento login
        {
            return DLogin.Instancia.Login(Nombre, Contraseña); // Logear con el nombre y contraseña proporcionados
        }
    }
}
