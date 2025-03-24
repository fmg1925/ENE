using System;

namespace Entidad // Espacio de trabajo de Entidad
{
    public class ELogin
    {
        public int ValIdUsuario; // Ir y buscar llaves primarias de la base de datos 

        public String ValNombre; // Nombres de la base de datos

        public String ValContraseña; // Nombres de la base de datos

        public int ValEsAdministrador; // Valor de administrador
        public int IdUsuario // Asignar Id Usuario
        {
            get { return ValIdUsuario; } // Asigna valor de las llaves primarias
            set { ValIdUsuario = value; }
        }
        public String Nombre // Asignar Nombre
        {
            get { return ValNombre; } // Asignar valor del Nombre
            set { ValNombre = value; }
        }
        public String Contraseña // Asignar Contraseña
        {
            get { return ValContraseña; } // Asignar valor de Contraseña
            set { ValContraseña = value; }
        }
        public int EsAdministrador // Asignar administrador
        {
            get { return ValEsAdministrador; } // Asignar valor de administrador
            set { ValEsAdministrador = value; }
        }
    }
}