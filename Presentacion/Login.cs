using Entidad;
using Negocio;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Login : Form // Formulario login
    {

        ELogin Ent = new ELogin(); // Entidad login

        public Login() // Iniciar login
        {
            InitializeComponent(); // Iniciar formulario
        }

        private void LoginButton_Click(object sender, EventArgs e) // Al clickear login
        {
            string Nombre = UsuarioTextBox.Text;
            string Contraseña = ContraseñaTextBox.Text;
            NLogin Neg = new NLogin();
            ELogin Ent = Neg.Login(Nombre, Contraseña); // Llamar a función login

            if (Ent.IdUsuario != 0) // Si el procedimiento devolvió un usuario
            {
                MessageBox.Show("Inicio de sesión exitoso"); // Se inicia la sesión
                Configuracion.Ent = Ent;
                Menu MP = new Menu();
                if(Ent.EsAdministrador == 1) // Si es administrador
                {
                    MP.IngresarButton.Enabled = true; // Habilitar botones de administración de trabajadores
                    MP.ActualizarButton.Enabled = true;
                    MP.EliminarButton.Enabled = true;
                    MP.LabelAdmin.Text = "Posees permisos de administrador";
                }
                MP.UsuarioTextBox.Text = Nombre;
                MP.AdminTextBox.Text = Ent.EsAdministrador.ToString(); // Pasar estado de administrador al menú
                MP.LabelUsuario.Text = "Bienvenido " + Nombre;
                MP.Show(); // Abrir menú
                this.Hide();
            }
            else // Si no
            {
                MessageBox.Show("Usuario o contraseña incorrectos"); // Mostrar error
            }
        }

        private void Salir_Click(object sender, EventArgs e) // Al clickear salir
        {
            System.Windows.Forms.Application.Exit(); // Cerrar aplicación
        }
    }
}