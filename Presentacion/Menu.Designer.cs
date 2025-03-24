namespace Presentacion
{
    partial class Menu
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
            this.AdminTextBox = new System.Windows.Forms.TextBox();
            this.ListarButton = new System.Windows.Forms.Button();
            this.ActualizarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.SalirButton = new System.Windows.Forms.Button();
            this.VolverButton = new System.Windows.Forms.Button();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.LabelAdmin = new System.Windows.Forms.Label();
            this.CalcularSueldos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdminTextBox
            // 
            this.AdminTextBox.Location = new System.Drawing.Point(9, 49);
            this.AdminTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.AdminTextBox.Name = "AdminTextBox";
            this.AdminTextBox.ReadOnly = true;
            this.AdminTextBox.Size = new System.Drawing.Size(76, 20);
            this.AdminTextBox.TabIndex = 0;
            this.AdminTextBox.Visible = false;
            // 
            // ListarButton
            // 
            this.ListarButton.Location = new System.Drawing.Point(122, 119);
            this.ListarButton.Margin = new System.Windows.Forms.Padding(2);
            this.ListarButton.Name = "ListarButton";
            this.ListarButton.Size = new System.Drawing.Size(105, 48);
            this.ListarButton.TabIndex = 1;
            this.ListarButton.Text = "Listar Trabajadores";
            this.ListarButton.UseVisualStyleBackColor = true;
            this.ListarButton.Click += new System.EventHandler(this.ListarButton_Click);
            // 
            // ActualizarButton
            // 
            this.ActualizarButton.Enabled = false;
            this.ActualizarButton.Location = new System.Drawing.Point(122, 171);
            this.ActualizarButton.Margin = new System.Windows.Forms.Padding(2);
            this.ActualizarButton.Name = "ActualizarButton";
            this.ActualizarButton.Size = new System.Drawing.Size(105, 48);
            this.ActualizarButton.TabIndex = 2;
            this.ActualizarButton.Text = "Actualizar Trabajadores";
            this.ActualizarButton.UseVisualStyleBackColor = true;
            this.ActualizarButton.Click += new System.EventHandler(this.ActualizarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Enabled = false;
            this.EliminarButton.Location = new System.Drawing.Point(236, 171);
            this.EliminarButton.Margin = new System.Windows.Forms.Padding(2);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(106, 48);
            this.EliminarButton.TabIndex = 3;
            this.EliminarButton.Text = "Eliminar Trabajadores";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // IngresarButton
            // 
            this.IngresarButton.Enabled = false;
            this.IngresarButton.Location = new System.Drawing.Point(9, 171);
            this.IngresarButton.Margin = new System.Windows.Forms.Padding(2);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(105, 48);
            this.IngresarButton.TabIndex = 4;
            this.IngresarButton.Text = "Ingresar Trabajadores";
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Location = new System.Drawing.Point(10, 11);
            this.LabelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(156, 13);
            this.LabelUsuario.TabIndex = 5;
            this.LabelUsuario.Text = "Bienvenido (nombre de usuario)";
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(255, 8);
            this.SalirButton.Margin = new System.Windows.Forms.Padding(2);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(86, 34);
            this.SalirButton.TabIndex = 6;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // VolverButton
            // 
            this.VolverButton.Location = new System.Drawing.Point(255, 47);
            this.VolverButton.Margin = new System.Windows.Forms.Padding(2);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(86, 30);
            this.VolverButton.TabIndex = 7;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(9, 72);
            this.UsuarioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(76, 20);
            this.UsuarioTextBox.TabIndex = 8;
            this.UsuarioTextBox.Visible = false;
            // 
            // LabelAdmin
            // 
            this.LabelAdmin.AutoSize = true;
            this.LabelAdmin.Location = new System.Drawing.Point(10, 33);
            this.LabelAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelAdmin.Name = "LabelAdmin";
            this.LabelAdmin.Size = new System.Drawing.Size(182, 13);
            this.LabelAdmin.TabIndex = 9;
            this.LabelAdmin.Text = "No posees permisos de administrador";
            // 
            // CalcularSueldos
            // 
            this.CalcularSueldos.Location = new System.Drawing.Point(236, 119);
            this.CalcularSueldos.Margin = new System.Windows.Forms.Padding(2);
            this.CalcularSueldos.Name = "CalcularSueldos";
            this.CalcularSueldos.Size = new System.Drawing.Size(105, 48);
            this.CalcularSueldos.TabIndex = 10;
            this.CalcularSueldos.Text = "Calcular Sueldos";
            this.CalcularSueldos.UseVisualStyleBackColor = true;
            this.CalcularSueldos.Click += new System.EventHandler(this.CalcularSueldos_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 236);
            this.ControlBox = false;
            this.Controls.Add(this.CalcularSueldos);
            this.Controls.Add(this.LabelAdmin);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.ActualizarButton);
            this.Controls.Add(this.ListarButton);
            this.Controls.Add(this.AdminTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menú";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox AdminTextBox;
        private System.Windows.Forms.Button ListarButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button VolverButton;
        public System.Windows.Forms.Label LabelUsuario;
        public System.Windows.Forms.Button ActualizarButton;
        public System.Windows.Forms.Button EliminarButton;
        public System.Windows.Forms.Button IngresarButton;
        public System.Windows.Forms.TextBox UsuarioTextBox;
        public System.Windows.Forms.Label LabelAdmin;
        private System.Windows.Forms.Button CalcularSueldos;
    }
}