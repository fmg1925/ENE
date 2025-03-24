using System;
using System.Windows.Forms;

namespace Presentacion.Trabajador
{
    public partial class Trabajador_Calcular : Form
    {
        public Trabajador_Calcular() // Calcular Sueldo
        {
            InitializeComponent(); // Iniciar formulario
        }

        private void SalirButton_Click(object sender, EventArgs e) // Al clickear salir
        {
            System.Windows.Forms.Application.Exit(); // Cerrar aplicación
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            Menu Men = new Menu(); // Abrir menú
            if (AdminTextBox.Text == "1") // Si es admin
            {
                Men.IngresarButton.Enabled = true; // Activar botones de administración
                Men.ActualizarButton.Enabled = true;
                Men.EliminarButton.Enabled = true;
                Men.LabelAdmin.Text = "Posees permisos de administrador";
            }
            Men.LabelUsuario.Text = "Bienvenido " + UsuarioTextBox.Text; // Cargar nombre de usuario
            Men.UsuarioTextBox.Text = UsuarioTextBox.Text;
            Men.AdminTextBox.Text = AdminTextBox.Text;
            Men.Show();
            this.Close(); // Cerrar consultar
        }
        private void Calcular() // Calcular
        {
            if (HorasTrabajadasTextBox.Text.Trim() != "" & HorasExtrasTextBox.Text != "") // Si hay horas trabajadas y horas extras
            {
                int Descuento = 0, SueldoBruto = 0, SueldoLiquido = 0; // Realizar cálculo de sueldo bruto, líquido y descuentos por afp y salud
                if (AFPComboBox.SelectedIndex == 0) { Descuento = 7; }
                else if (AFPComboBox.SelectedIndex == 1) { Descuento = 9; }
                else if (AFPComboBox.SelectedIndex == 2) { Descuento = 12; }
                else if (AFPComboBox.SelectedIndex == 3) { Descuento = 13; }
                if (SistemaDeSaludComboBox.SelectedIndex == 0) { Descuento += 12; }
                else if (SistemaDeSaludComboBox.SelectedIndex == 1) { Descuento += 13; }
                else if (SistemaDeSaludComboBox.SelectedIndex == 2) { Descuento += 14; }
                else if (SistemaDeSaludComboBox.SelectedIndex == 3) { Descuento += 15; }
                SueldoBruto = Convert.ToInt32(HorasTrabajadasTextBox.Text) * 5000 + Convert.ToInt32(HorasExtrasTextBox.Text) * 7000;
                SueldoLiquido = SueldoBruto - (int)(SueldoBruto * ((decimal)Descuento / 100));
                LabelSueldoBruto.Text = "Sueldo Bruto: " + SueldoBruto.ToString(); // Mostrar sueldo líquido, bruto y descuentos
                LabelDescuentos.Text = "Descuentos: " + ((int)(SueldoBruto * ((decimal)Descuento / 100))).ToString();
                LabelSueldoLiquido.Text = "Sueldo Líquido: " + SueldoLiquido.ToString();
            }
            else // Si no
            {
                LabelSueldoBruto.Text = "Sueldo Bruto: 0"; // No calcular
                LabelDescuentos.Text = "Descuentos: 0";
                LabelSueldoLiquido.Text = "Sueldo Líquido: 0";
            }
        }

        private void Trabajador_Calcular_Load(object sender, EventArgs e) // Al cargar el formulario
        {
            AFPComboBox.SelectedIndex = 0; // Elegir primer objeto combo boxes
            SistemaDeSaludComboBox.SelectedIndex = 0;
        }

        private void HorasTrabajadasTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en horas trabajadas
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // Solo permitir números
            {
                e.Handled = true;
                MessageBox.Show("Sólo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HorasExtrasTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en horas extras
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // Solo permitir números
            {
                e.Handled = true;
                MessageBox.Show("Sólo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HorasTrabajadasTextBox_TextChanged(object sender, EventArgs e) // Al cambiar horas trabajadas
        {
            Calcular(); // Calcular
        }

        private void HorasExtrasTextBox_TextChanged(object sender, EventArgs e) // Al cambiar horas extras
        {
            Calcular(); // Calcular
        }

        private void AFPComboBox_SelectedIndexChanged(object sender, EventArgs e) // Al cambiar afp
        {
            Calcular(); // Calcular
        }

        private void SistemaDeSaludComboBox_SelectedIndexChanged(object sender, EventArgs e) // Al cambiar sistema de salud
        {
            Calcular(); // Calcular
        }
    }
}
