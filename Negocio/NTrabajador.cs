using Datos;
using Entidad;
using System.Collections.Generic;

namespace Negocio
{
    public class NTrabajador
    {
        public List<ETrabajador> Listar() // Llamar al procedimiento listar
        {
            return DTrabajador.Instancia.Listar(); // Listar trabajadores
        }

        public static Respuesta<bool> Ingresar(ETrabajador obj) // Llamar al procedimiento ingresar
        {
            bool Respuesta = false;
            Respuesta = DTrabajador.Instancia.Ingresar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Actualizar(ETrabajador obj) // Llamar al procedimiento actualizar
        {
            bool Respuesta = false;
            Respuesta = DTrabajador.Instancia.Actualizar(obj);
            return new Respuesta<bool>() { Estado = Respuesta };
        }

        public static Respuesta<bool> Eliminar(int Id) // Llamar al procedimiento eliminar
        {
            bool Respuesta = false;
            Respuesta = DTrabajador.Instancia.Eliminar(Id);
            return new Respuesta<bool>() { Estado = Respuesta };
        }
    }
}