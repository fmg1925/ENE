using System;

namespace Entidad // Espacio de trabajo de Entidad
{
    public class ETrabajador // Clase ETrabajador
    {
        public int ValIdTrabajador; // Ir y buscar llaves primarias de la base de datos 
        public string ValRut; // Valor RUT
        public string ValNombre; // Valor Nombre
        public string ValDireccion; // Valor Dirección
        public string ValTelefono; // Valor Teléfono
        public int ValHorasTrabajadas; // Valor Horas Trabajadas
        public int ValHorasExtras; // Valor Horas Extras
        public int ValAFP; // Valor AFP
        public int ValSalud; // Valor Sistema de Salud

        public int IdTrabajador // IdTrabajador
        {
            get { return ValIdTrabajador; } // Asignar IdTrabajador
            set { ValIdTrabajador = value; }
        }
        public string Rut // Rut
        {
            get { return ValRut; } // Asignar Rut
            set { ValRut = value; }
        }
        public string Nombre // Nombre
        {
            get { return ValNombre; } // Asignar Nombre
            set { ValNombre = value; }
        }
        public string Direccion // Dirección
        {
            get { return ValDireccion; } // Asignar Dirección
            set { ValDireccion = value; }
        }
        public string Telefono // Teléfono
        {
            get { return ValTelefono; } // Asignar Teléfono
            set { ValTelefono = value; }
        }
        public int HorasTrabajadas // Horas Trabajadas
        {
            get { return ValHorasTrabajadas; } // Asignar Horas Trabajadas
            set { ValHorasTrabajadas = value; }
        }
        public int HorasExtras // Horas Extras
        {
            get { return ValHorasExtras; } // Asignar Horas Extras
            set { ValHorasExtras = value; }
        }
        public int AFP // AFP
        {
            get { return ValAFP; } // Asignar AFP
            set { ValAFP = value; }
        }
        public int Salud // Sistema de Salud
        {
            get { return ValSalud; } // Asignar Sistema de Salud
            set { ValSalud = value; }
        }
    }
}