using Entidad;
using Negocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion.Trabajador
{
    public partial class Trabajador_Consultar : Form
    {
        string AFPd, Salud;
        public Trabajador_Consultar() // Formulario consultar trabajador
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
            if(AdminTextBox.Text == "1") // Si es admin
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

        private void Trabajador_Consultar_Load(object sender, EventArgs e) // Al cargar el formulario
        {
            CargarDatos(); // Cargar datos
        }

        private void LimpiarBusqueda_Click(object sender, EventArgs e) // Al clickear limpiar búsqueda
        {
            BuscarTextBox.Clear(); // Limpiar búsqueda
            CargarDatos(); // Cargar datos
        }

        private void BuscarButton_Click(object sender, EventArgs e) // Al clickear buscar
        {
            foreach(DataGridViewRow row in grilla.Rows) // Buscar con el filtro seleccionado
            {
                if (row.Cells[FiltrarPorComboBox.SelectedIndex+1].Value.ToString().Trim().ToUpper().Contains(BuscarTextBox.Text.Trim().ToUpper()))
                {
                    row.Visible = true;
                } else
                {
                    row.Visible = false;
                }
            }
        }

        private void grilla_DoubleClick(object sender, EventArgs e) // Al hacer doble click en la grilla
        {
            EliminarButton.Enabled = true; // Habilitar botón de eliminar
            ActualizarButton.Enabled = true; // Habilitar botón de actualizar
        }

        private void EliminarButton_Click(object sender, EventArgs e) // Al clickear eliminar
        {
            var res = MessageBox.Show("¿Está seguro de la acción a realizar?", "Sistema", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); // Mostrar confirmación
            if (res == DialogResult.Yes)
            {
                Respuesta<bool> resultado = NTrabajador.Eliminar(Convert.ToInt32(grilla.CurrentRow.Cells[0].Value)); // Conseguir id del trabajador
                if (resultado.Estado) // Si se eliminó
                {
                    MessageBox.Show("La eliminación se realizó correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information); // Eliminación correcta
                }
                else // Si no
                {
                    MessageBox.Show("No se pudo eliminar el registro", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Error al eliminar
                }
            }
            else if (res == DialogResult.No) // Si se elige no
            {
                VolverButton.Focus(); // Enfocar botón de volver
            }
            else if (res == DialogResult.Cancel) // Si se elige cancelar
            {
                SalirButton.Focus(); // Si se elige salir
            }
            grilla.Rows.Clear(); // Limpiar grilla
            CargarDatos(); // Cargar datos
        }

        private void ActualizarButton_Click(object sender, EventArgs e) // Al clickear actualizar
        {
            Trabajador_Actualizar Act = new Trabajador_Actualizar(); // Crear formulario actualizar
            Act.UsuarioTextBox.Text = UsuarioTextBox.Text; // Pasar valores del trabajador al otro formulario
            Act.IdTrabajadorTextBox.Text = this.grilla.CurrentRow.Cells[0].Value.ToString();
            Act.RutTextBox.Text = this.grilla.CurrentRow.Cells[1].Value.ToString();
            Act.NombreTextBox.Text = this.grilla.CurrentRow.Cells[2].Value.ToString();
            Act.TelefonoTextBox.Text = this.grilla.CurrentRow.Cells[10].Value.ToString();
            Act.DireccionTextBox.Text = this.grilla.CurrentRow.Cells[3].Value.ToString();
            Act.HorasTrabajadasTextBox.Text = this.grilla.CurrentRow.Cells[6].Value.ToString();
            Act.HorasExtrasTextBox.Text = this.grilla.CurrentRow.Cells[7].Value.ToString();
            Act.AFPComboBox.SelectedIndex = Convert.ToInt32(this.grilla.CurrentRow.Cells[11].Value);
            Act.SistemaDeSaludComboBox.SelectedIndex = Convert.ToInt32(this.grilla.CurrentRow.Cells[12].Value);
            Act.RutAnterior.Text = this.grilla.CurrentRow.Cells[1].Value.ToString(); // Guardar valores anteriores
            Act.NombreAnterior.Text = this.grilla.CurrentRow.Cells[2].Value.ToString();
            Act.TelefonoAnterior.Text = this.grilla.CurrentRow.Cells[10].Value.ToString();
            Act.DireccionAnterior.Text = this.grilla.CurrentRow.Cells[3].Value.ToString();
            Act.HorasAnterior.Text = this.grilla.CurrentRow.Cells[6].Value.ToString();
            Act.HorasExtrasAnterior.Text = this.grilla.CurrentRow.Cells[7].Value.ToString();
            Act.AFPAnterior.Text = this.grilla.CurrentRow.Cells[11].Value.ToString();
            Act.SaludAnterior.Text = this.grilla.CurrentRow.Cells[12].Value.ToString();
            Act.Show(); // Abrir actualizar
            this.Hide(); // Ocultar consulta
        }

        private void CargarDatos() // Cargar datos
        {
            try
            {
                grilla.Rows.Clear(); // Limpiar grilla
                List<ETrabajador> Listar = new NTrabajador().Listar(); // Listar regiones
                foreach (ETrabajador item in Listar) // Por cada trabajador
                {
                    int Descuento = 0, SueldoBruto = 0, SueldoLiquido = 0; // Calcular sueldo, afp, y sistema de salud al que pertenece
                    if(item.AFP == 0) { Descuento = 7; AFPd = "Cuprum"; }
                    else if (item.AFP == 1) { Descuento = 9; AFPd = "Modelo"; }
                    else if (item.AFP == 2) { Descuento = 12; AFPd = "Capital"; }
                    else if (item.AFP == 3) { Descuento = 13; AFPd = "Provida"; }
                    if(item.Salud == 0) { Descuento += 12; Salud = "Fonasa"; }
                    else if (item.Salud == 1) { Descuento += 13; Salud = "Consalud"; }
                    else if (item.Salud == 2) { Descuento += 14; Salud = "Masvida"; }
                    else if (item.Salud == 3) { Descuento += 15; Salud = "Banmedica"; }
                    SueldoBruto = item.HorasTrabajadas * 5000 + item.HorasExtras * 7000;
                    SueldoLiquido = SueldoBruto - (int)(SueldoBruto * ((decimal)Descuento / 100));
                    grilla.Rows.Add(new object[] { item.IdTrabajador, item.Rut, item.Nombre, item.Direccion, SueldoLiquido.ToString(), SueldoBruto.ToString(), item.HorasTrabajadas.ToString(), item.HorasExtras.ToString(), AFPd, Salud, item.Telefono, item.AFP, item.Salud }); // Añadir trabajadores a la grilla
                }
                FiltrarPorComboBox.SelectedIndex = 0;
            }
            catch (Exception ex) // En caso de error
            {
                MessageBox.Show(ex.Message); // Mostrar mensaje de error
            }
            grilla.ClearSelection(); // Deseleccionar grilla
        }
    }
}
