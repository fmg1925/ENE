namespace Presentacion.Trabajador
{
    partial class Trabajador_Consultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grilla = new System.Windows.Forms.DataGridView();
            this.IdTrabajador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SueldoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasTrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SistemaDeSalud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afpv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saludv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActualizarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FiltrarPorComboBox = new System.Windows.Forms.ComboBox();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.LimpiarBusqueda = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.VolverButton = new System.Windows.Forms.Button();
            this.AdminTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTrabajador,
            this.Rut,
            this.Nombre,
            this.Direccion,
            this.SueldoLiquido,
            this.SueldoBruto,
            this.HorasTrabajadas,
            this.HorasExtras,
            this.AFP,
            this.SistemaDeSalud,
            this.Telefono,
            this.afpv,
            this.saludv});
            this.grilla.Location = new System.Drawing.Point(21, 151);
            this.grilla.Name = "grilla";
            this.grilla.RowHeadersVisible = false;
            this.grilla.RowTemplate.Height = 24;
            this.grilla.Size = new System.Drawing.Size(954, 354);
            this.grilla.TabIndex = 0;
            this.grilla.DoubleClick += new System.EventHandler(this.grilla_DoubleClick);
            // 
            // IdTrabajador
            // 
            this.IdTrabajador.HeaderText = "IdTrabajador";
            this.IdTrabajador.Name = "IdTrabajador";
            this.IdTrabajador.ReadOnly = true;
            this.IdTrabajador.Visible = false;
            // 
            // Rut
            // 
            this.Rut.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Rut.HeaderText = "Rut";
            this.Rut.Name = "Rut";
            this.Rut.ReadOnly = true;
            this.Rut.Width = 52;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 81;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 89;
            // 
            // SueldoLiquido
            // 
            this.SueldoLiquido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SueldoLiquido.HeaderText = "Sueldo Líquido";
            this.SueldoLiquido.Name = "SueldoLiquido";
            this.SueldoLiquido.Width = 112;
            // 
            // SueldoBruto
            // 
            this.SueldoBruto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SueldoBruto.HeaderText = "Sueldo Bruto";
            this.SueldoBruto.Name = "SueldoBruto";
            this.SueldoBruto.ReadOnly = true;
            // 
            // HorasTrabajadas
            // 
            this.HorasTrabajadas.HeaderText = "Horas Trabajadas";
            this.HorasTrabajadas.Name = "HorasTrabajadas";
            this.HorasTrabajadas.ReadOnly = true;
            // 
            // HorasExtras
            // 
            this.HorasExtras.HeaderText = "Horas Extras";
            this.HorasExtras.Name = "HorasExtras";
            this.HorasExtras.ReadOnly = true;
            // 
            // AFP
            // 
            this.AFP.HeaderText = "AFP";
            this.AFP.Name = "AFP";
            this.AFP.ReadOnly = true;
            // 
            // SistemaDeSalud
            // 
            this.SistemaDeSalud.HeaderText = "Sistema de Salud";
            this.SistemaDeSalud.Name = "SistemaDeSalud";
            this.SistemaDeSalud.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // afpv
            // 
            this.afpv.HeaderText = "afpv";
            this.afpv.Name = "afpv";
            this.afpv.ReadOnly = true;
            this.afpv.Visible = false;
            // 
            // saludv
            // 
            this.saludv.HeaderText = "saludv";
            this.saludv.Name = "saludv";
            this.saludv.ReadOnly = true;
            this.saludv.Visible = false;
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Enabled = false;
            this.ActualizarButton.Location = new System.Drawing.Point(841, 78);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(114, 56);
            this.ActualizarButton.TabIndex = 1;
            this.ActualizarButton.Text = "Actualizar";
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Visible = false;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Location = new System.Drawing.Point(841, 78);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(114, 56);
            this.EliminarButton.TabIndex = 2;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Visible = false;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarTextBox
            // 
            this.BuscarTextBox.Location = new System.Drawing.Point(84, 65);
            this.BuscarTextBox.Name = "BuscarTextBox";
            this.BuscarTextBox.Size = new System.Drawing.Size(197, 22);
            this.BuscarTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtrar por:";
            // 
            // FiltrarPorComboBox
            // 
            this.FiltrarPorComboBox.FormattingEnabled = true;
            this.FiltrarPorComboBox.Items.AddRange(new object[] {
            "Rut",
            "Nombre",
            "Dirección",
            "Sueldo Líquido",
            "Sueldo Bruto",
            "Horas Trabajadas",
            "Horas Extras",
            "AFP",
            "Sistema de Salud",
            "Teléfono"});
            this.FiltrarPorComboBox.Location = new System.Drawing.Point(110, 11);
            this.FiltrarPorComboBox.Name = "FiltrarPorComboBox";
            this.FiltrarPorComboBox.Size = new System.Drawing.Size(121, 24);
            this.FiltrarPorComboBox.TabIndex = 5;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(53, 111);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 23);
            this.BuscarButton.TabIndex = 6;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // LimpiarBusqueda
            // 
            this.LimpiarBusqueda.Location = new System.Drawing.Point(156, 111);
            this.LimpiarBusqueda.Name = "LimpiarBusqueda";
            this.LimpiarBusqueda.Size = new System.Drawing.Size(160, 23);
            this.LimpiarBusqueda.TabIndex = 7;
            this.LimpiarBusqueda.Text = "Limpiar Búsqueda";
            this.LimpiarBusqueda.UseVisualStyleBackColor = true;
            this.LimpiarBusqueda.Click += new System.EventHandler(this.LimpiarBusqueda_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(902, 12);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(73, 40);
            this.SalirButton.TabIndex = 8;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // VolverButton
            // 
            this.VolverButton.Location = new System.Drawing.Point(823, 12);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(73, 40);
            this.VolverButton.TabIndex = 9;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // AdminTextBox
            // 
            this.AdminTextBox.Location = new System.Drawing.Point(287, 30);
            this.AdminTextBox.Name = "AdminTextBox";
            this.AdminTextBox.ReadOnly = true;
            this.AdminTextBox.Size = new System.Drawing.Size(100, 22);
            this.AdminTextBox.TabIndex = 10;
            this.AdminTextBox.Visible = false;
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(287, 65);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(100, 22);
            this.UsuarioTextBox.TabIndex = 11;
            this.UsuarioTextBox.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Buscar:";
            // 
            // Trabajador_Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 537);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.AdminTextBox);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.LimpiarBusqueda);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.FiltrarPorComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BuscarTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ActualizarButton);
            this.Controls.Add(this.grilla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Trabajador_Consultar";
            this.Text = "Consultar Trabajadores";
            this.Load += new System.EventHandler(this.Trabajador_Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.TextBox BuscarTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FiltrarPorComboBox;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button LimpiarBusqueda;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button VolverButton;
        public System.Windows.Forms.TextBox AdminTextBox;
        public System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button ActualizarButton;
        public System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTrabajador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoLiquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SueldoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTrabajadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SistemaDeSalud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn afpv;
        private System.Windows.Forms.DataGridViewTextBoxColumn saludv;
    }
}