using Presentacion.Trabajador;
using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu : Form
    {
        public Menu() // Formulario menú
        {
            InitializeComponent(); // Iniciar menú
        }

        private void SalirButton_Click(object sender, EventArgs e) // Al clickear salir
        {
            System.Windows.Forms.Application.Exit(); // Cerrar aplicación
        }

        private void VolverButton_Click(object sender, EventArgs e) // Al clickear volver
        {
            Login Log = new Login(); // Abrir login
            Log.Show();
            this.Close(); // Cerrar menú
        }

        private void ListarButton_Click(object sender, EventArgs e)
        {
            Trabajador_Consultar Tr = new Trabajador_Consultar(); // Abrir consultar
            Tr.UsuarioTextBox.Text = UsuarioTextBox.Text;
            Tr.AdminTextBox.Text = AdminTextBox.Text;
            Tr.Show();
            this.Close(); // Cerrar menú
        }

        private void IngresarButton_Click(object sender, EventArgs e)
        {
            Trabajador_Ingresar Tr = new Trabajador_Ingresar(); // Abrir ingresar
            Tr.UsuarioTextBox.Text = UsuarioTextBox.Text;
            Tr.Show();
            this.Close(); // Cerrar menú
        }

        private void ActualizarButton_Click(object sender, EventArgs e)
        {
            Trabajador_Consultar Tr = new Trabajador_Consultar(); // Abrir consultar
            Tr.UsuarioTextBox.Text = UsuarioTextBox.Text;
            Tr.AdminTextBox.Text = AdminTextBox.Text;
            Tr.ActualizarButton.Visible = true;
            Tr.Show();
            this.Close(); // Cerrar menú
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            Trabajador_Consultar Tr = new Trabajador_Consultar(); // Abrir consultar
            Tr.UsuarioTextBox.Text = UsuarioTextBox.Text;
            Tr.AdminTextBox.Text = AdminTextBox.Text;
            Tr.EliminarButton.Visible = true;
            Tr.Show();
            this.Close(); // Cerrar menú
        }

        private void CalcularSueldos_Click(object sender, EventArgs e)
        {
            Trabajador_Calcular Tr = new Trabajador_Calcular(); // Abrir calcular
            Tr.UsuarioTextBox.Text = UsuarioTextBox.Text;
            Tr.AdminTextBox.Text = AdminTextBox.Text;
            Tr.Show();
            this.Close(); // Cerrar menú
        }
    }
}
