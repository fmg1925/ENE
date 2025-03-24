using Entidad;
using Negocio;
using Presentacion.AAClases;
using System;
using System.Windows.Forms;

namespace Presentacion.Trabajador
{
    public partial class Trabajador_Actualizar : Form
    {
        ValidarRut Rut = new ValidarRut(); // Clase validar rut
        ETrabajador Ent = new ETrabajador(); // Entidad Trabajador
        public Trabajador_Actualizar() // Formulario Ingresar Trabajador
        {
            InitializeComponent(); // Iniciar formulario
        }

        private void SalirButton_Click(object sender, EventArgs e) // Al clickear salir
        {
            Application.Exit(); // Cerrar aplicación
        }

        private void VolverButton_Click(object sender, EventArgs e) // Al clickear volver
        {
            Menu Men = new Menu(); // Abrir menú
            Men.IngresarButton.Enabled = true; // Activar botones
            Men.ActualizarButton.Enabled = true;
            Men.EliminarButton.Enabled = true;
            Men.LabelAdmin.Text = "Posees permisos de administrador";
            Men.LabelUsuario.Text = "Bienvenido " + UsuarioTextBox.Text;
            Men.UsuarioTextBox.Text = UsuarioTextBox.Text;
            Men.AdminTextBox.Text = "1";
            Men.Show();
            this.Close(); // Cerrar consultar
        }

        private void RutTextBox_Leave(object sender, EventArgs e) // Al dejar de escribir rut
        {
            bool respuesta = false;
            if (RutTextBox.Text.Length < 8) // Si el rut tiene menos de 8 carácteres
            {
                RutTextBox.Text = "Rut Inválido";
                return; // Invalidar rut
            }
            respuesta = Rut.validarRut(RutTextBox.Text); // Comprobar rut

            if (respuesta == false) // Si el rut no es válido
            {
                RutTextBox.Text = "Rut Inválido"; // Invalidar rut
            }
            else
            {
                string rutformateado = RutTextBox.Text.Replace(".", "").Replace("-", ""); // Formatear rut añadiendo puntos y guión
                rutformateado = rutformateado.Insert(rutformateado.Length - 1, "-");
                rutformateado = rutformateado.Insert(rutformateado.Length - 5, ".");
                rutformateado = rutformateado.Insert(rutformateado.Length - 9, ".");
                RutTextBox.Text = rutformateado;
            }
        }

        private void Trabajador_Ingresar_Load(object sender, EventArgs e) // Al cargar el formulario
        {
            if(AFPComboBox.SelectedIndex == -1 || SistemaDeSaludComboBox.SelectedIndex == -1) // Si no hay índice seleccionado
            {
                AFPComboBox.SelectedIndex = 0; // Cargar primer objeto de los comboboxes
                SistemaDeSaludComboBox.SelectedIndex = 0;
            }
            Validar(); // Validar
        }

        private void IngresarButton_Click(object sender, EventArgs e) // Al clickear ingresar
        {
            var res = MessageBox.Show("Esta seguro de la acción a realizar?", "Sistema.", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar confirmación
            Ent.IdTrabajador = Convert.ToInt32(IdTrabajadorTextBox.Text);
            Ent.Rut = RutTextBox.Text;
            Ent.Nombre = NombreTextBox.Text; // Conseguir valores de los textboxes y afp y salud del combobox
            Ent.Direccion = DireccionTextBox.Text;
            Ent.Telefono = TelefonoTextBox.Text;
            Ent.HorasTrabajadas = Convert.ToInt32(HorasTrabajadasTextBox.Text);
            Ent.HorasExtras = Convert.ToInt32(HorasExtrasTextBox.Text);
            Ent.AFP = AFPComboBox.SelectedIndex;
            Ent.Salud = SistemaDeSaludComboBox.SelectedIndex;
            if (res == DialogResult.Yes)
            {
                Respuesta<bool> resultado = NTrabajador.Actualizar(Ent); // Ingresar trabajador

                if (resultado.Estado) // Si se ingresó
                {
                    RutAnterior.Text = RutTextBox.Text; // Cambiar valores anteriores
                    NombreAnterior.Text = NombreTextBox.Text;
                    TelefonoAnterior.Text = TelefonoTextBox.Text;
                    DireccionAnterior.Text = DireccionTextBox.Text;
                    HorasAnterior.Text = HorasTrabajadasTextBox.Text;
                    HorasExtrasAnterior.Text = HorasExtrasTextBox.Text;
                    AFPAnterior.Text = AFPComboBox.SelectedIndex.ToString();
                    SaludAnterior.Text = SistemaDeSaludComboBox.SelectedIndex.ToString();
                    Validar(); // Validar
                    MessageBox.Show("Actualización fue realizada correctamente", "Sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // Si no
                {
                    MessageBox.Show("Actualización fallida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Reclamar
                }
            }
            else if (res == DialogResult.No) // Si se elige no
            {
                VolverButton.Focus(); // Enfocar botón de volver
            }
            else if (res == DialogResult.Cancel) // Si se elige cancelar
            {
                SalirButton.Focus(); // Enfocar botón de salir
            }
        }

        private void HorasTrabajadasTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en horas trabajadas
        {
            if(!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar)) // Si se presiona algo que no es un número
            {
                e.Handled = true;
                MessageBox.Show("Sólo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Sólo permitir números
            }
        }

        private void HorasExtrasTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en horas extras
        {
            if (!char.IsDigit(e.KeyChar) & !char.IsControl(e.KeyChar)) // Si se presiona algo que no es un número
            {
                e.Handled = true;
                MessageBox.Show("Sólo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Sólo permitir números
            }
        }


        private void Validar() // Función para validar
        {
            if (RutTextBox.Text != RutAnterior.Text || NombreTextBox.Text != NombreAnterior.Text || TelefonoTextBox.Text != TelefonoAnterior.Text || DireccionTextBox.Text != DireccionAnterior.Text || HorasTrabajadasTextBox.Text != HorasAnterior.Text || HorasExtrasTextBox.Text != HorasExtrasAnterior.Text || AFPComboBox.SelectedIndex != Convert.ToInt32(AFPAnterior.Text) || SistemaDeSaludComboBox.SelectedIndex != Convert.ToInt32(SaludAnterior.Text)) // Si se ha cambiado algún valor
            {
                AnularButton.Enabled = true; // Habilitar botón de anular
                IngresarButton.Enabled = true; // Habilitar botón de actualizar
            } else // Si no
            {
                AnularButton.Enabled = false; // Deshabilitar botón de anular
                IngresarButton.Enabled = false; // Deshabilitar botón de actualizar
                return; // Dejar de validar
            }
            if (RutTextBox.Text == "Rut Inválido") { IngresarButton.Enabled = false; return; } // Si hay rut inválido cancelar y deshabilitar actualizar
            if (RutTextBox.Text.Trim() != "" & NombreTextBox.Text.Trim() != "" & TelefonoTextBox.Text.Trim() != "" & DireccionTextBox.Text.Trim() != "" & HorasTrabajadasTextBox.Text.Trim() != "" & HorasExtrasTextBox.Text.Trim() != "") // Si nada está vacío
            {
                IngresarButton.Enabled = true; // Habilitar botón de actualizar
            } else // Si no
            {
                IngresarButton.Enabled = false; // Deshabilitar botón de actualizar
            }
        }

        private void Calcular() // Función calcular
        {
            if (HorasTrabajadasTextBox.Text.Trim() != "" & HorasExtrasTextBox.Text != "") // Si hay horas trabajadas y horas extras
            {
                int Descuento = 0, SueldoBruto = 0, SueldoLiquido = 0; // Realizar cálculo de descuentos afp y salud
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
                LabelSueldoBruto.Text = "Sueldo Bruto: " + SueldoBruto.ToString(); // Mostrar sueldo bruto, líquido y descuento
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
        private void HorasTrabajadasTextBox_TextChanged(object sender, EventArgs e) // Al cambiar horas trabajadas
        {
            Validar(); // Validar
            Calcular(); // Calcular sueldo
        }

        private void HorasExtrasTextBox_TextChanged(object sender, EventArgs e) // Al cambiar horas extras
        {
            Validar(); // Validar
            Calcular(); // Calcular sueldo
        }

        private void AFPComboBox_SelectedIndexChanged(object sender, EventArgs e) // Al cambiar afp
        {
            Validar(); // Validar
            Calcular(); // Calcular sueldo
        }

        private void SistemaDeSaludComboBox_SelectedIndexChanged(object sender, EventArgs e) // Al cambiar sistema de salud
        {
            Validar(); // Validar
            Calcular(); // Calcular sueldo
        }

        private void RutTextBox_TextChanged(object sender, EventArgs e) // Al cambiar rut
        {
            Validar(); // Validar
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e) // Al cambiar nombre
        {
            Validar(); // Validar
        }

        private void TelefonoTextBox_TextChanged(object sender, EventArgs e) // Al cambiar teléfono
        {
            Validar(); // Validar
        }

        private void DireccionTextBox_TextChanged(object sender, EventArgs e) // Al cambiar dirección
        {
            Validar(); // Validar
        }

        private void TelefonoTextBox_KeyPress(object sender, KeyPressEventArgs e) // Al presionar tecla en teléfono
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) // Solo permitir números
            {
                e.Handled = true;
                MessageBox.Show("Sólo se permiten números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnularButton_Click(object sender, EventArgs e) // Al clickear anular
        {
            RutTextBox.Text = RutAnterior.Text; // Devolver valores anteriores
            NombreTextBox.Text = NombreAnterior.Text;
            TelefonoTextBox.Text = TelefonoAnterior.Text;
            DireccionTextBox.Text = DireccionAnterior.Text;
            HorasTrabajadasTextBox.Text = HorasAnterior.Text;
            HorasExtrasTextBox.Text = HorasExtrasAnterior.Text;
            AFPComboBox.SelectedIndex = Convert.ToInt32(AFPAnterior.Text);
            SistemaDeSaludComboBox.SelectedIndex = Convert.ToInt32(SaludAnterior.Text);
            AnularButton.Enabled = false;
        }
    }
}
