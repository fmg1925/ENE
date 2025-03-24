namespace Presentacion.Trabajador
{
    partial class Trabajador_Ingresar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AFPComboBox = new System.Windows.Forms.ComboBox();
            this.SistemaDeSaludComboBox = new System.Windows.Forms.ComboBox();
            this.SalirButton = new System.Windows.Forms.Button();
            this.VolverButton = new System.Windows.Forms.Button();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.HorasTrabajadasTextBox = new System.Windows.Forms.TextBox();
            this.HorasExtrasTextBox = new System.Windows.Forms.TextBox();
            this.TelefonoTextBox = new System.Windows.Forms.TextBox();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.RutTextBox = new System.Windows.Forms.TextBox();
            this.IngresarButton = new System.Windows.Forms.Button();
            this.LimpiarButton = new System.Windows.Forms.Button();
            this.LabelSueldoBruto = new System.Windows.Forms.Label();
            this.LabelSueldoLiquido = new System.Windows.Forms.Label();
            this.LabelDescuentos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Trabajador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rut:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 170);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Horas Trabajadas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Horas Extras:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 172);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "AFP:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 226);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Sistema de Salud:";
            // 
            // AFPComboBox
            // 
            this.AFPComboBox.FormattingEnabled = true;
            this.AFPComboBox.Items.AddRange(new object[] {
            "Cuprum",
            "Modelo",
            "Capital",
            "Provida"});
            this.AFPComboBox.Location = new System.Drawing.Point(319, 172);
            this.AFPComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AFPComboBox.Name = "AFPComboBox";
            this.AFPComboBox.Size = new System.Drawing.Size(76, 21);
            this.AFPComboBox.TabIndex = 9;
            this.AFPComboBox.SelectedIndexChanged += new System.EventHandler(this.AFPComboBox_SelectedIndexChanged);
            // 
            // SistemaDeSaludComboBox
            // 
            this.SistemaDeSaludComboBox.FormattingEnabled = true;
            this.SistemaDeSaludComboBox.Items.AddRange(new object[] {
            "Fonasa",
            "Consalud",
            "Masvida",
            "Banmedica"});
            this.SistemaDeSaludComboBox.Location = new System.Drawing.Point(319, 223);
            this.SistemaDeSaludComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SistemaDeSaludComboBox.Name = "SistemaDeSaludComboBox";
            this.SistemaDeSaludComboBox.Size = new System.Drawing.Size(76, 21);
            this.SistemaDeSaludComboBox.TabIndex = 10;
            this.SistemaDeSaludComboBox.SelectedIndexChanged += new System.EventHandler(this.SistemaDeSaludComboBox_SelectedIndexChanged);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(536, 15);
            this.SalirButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(56, 19);
            this.SalirButton.TabIndex = 11;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // VolverButton
            // 
            this.VolverButton.Location = new System.Drawing.Point(476, 15);
            this.VolverButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(56, 19);
            this.VolverButton.TabIndex = 12;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(18, 9);
            this.UsuarioTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(76, 20);
            this.UsuarioTextBox.TabIndex = 13;
            this.UsuarioTextBox.Visible = false;
            // 
            // HorasTrabajadasTextBox
            // 
            this.HorasTrabajadasTextBox.Location = new System.Drawing.Point(319, 78);
            this.HorasTrabajadasTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HorasTrabajadasTextBox.Name = "HorasTrabajadasTextBox";
            this.HorasTrabajadasTextBox.Size = new System.Drawing.Size(76, 20);
            this.HorasTrabajadasTextBox.TabIndex = 14;
            this.HorasTrabajadasTextBox.TextChanged += new System.EventHandler(this.HorasTrabajadasTextBox_TextChanged);
            this.HorasTrabajadasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HorasTrabajadasTextBox_KeyPress);
            // 
            // HorasExtrasTextBox
            // 
            this.HorasExtrasTextBox.Location = new System.Drawing.Point(319, 124);
            this.HorasExtrasTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HorasExtrasTextBox.Name = "HorasExtrasTextBox";
            this.HorasExtrasTextBox.Size = new System.Drawing.Size(76, 20);
            this.HorasExtrasTextBox.TabIndex = 15;
            this.HorasExtrasTextBox.TextChanged += new System.EventHandler(this.HorasExtrasTextBox_TextChanged);
            this.HorasExtrasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HorasExtrasTextBox_KeyPress);
            // 
            // TelefonoTextBox
            // 
            this.TelefonoTextBox.Location = new System.Drawing.Point(75, 170);
            this.TelefonoTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TelefonoTextBox.Name = "TelefonoTextBox";
            this.TelefonoTextBox.Size = new System.Drawing.Size(76, 20);
            this.TelefonoTextBox.TabIndex = 16;
            this.TelefonoTextBox.TextChanged += new System.EventHandler(this.TelefonoTextBox_TextChanged);
            this.TelefonoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelefonoTextBox_KeyPress);
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(75, 226);
            this.DireccionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(76, 20);
            this.DireccionTextBox.TabIndex = 17;
            this.DireccionTextBox.TextChanged += new System.EventHandler(this.DireccionTextBox_TextChanged);
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(75, 124);
            this.NombreTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(76, 20);
            this.NombreTextBox.TabIndex = 18;
            this.NombreTextBox.TextChanged += new System.EventHandler(this.NombreTextBox_TextChanged);
            // 
            // RutTextBox
            // 
            this.RutTextBox.Location = new System.Drawing.Point(75, 76);
            this.RutTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RutTextBox.Name = "RutTextBox";
            this.RutTextBox.Size = new System.Drawing.Size(76, 20);
            this.RutTextBox.TabIndex = 19;
            this.RutTextBox.TextChanged += new System.EventHandler(this.RutTextBox_TextChanged);
            this.RutTextBox.Leave += new System.EventHandler(this.RutTextBox_Leave);
            // 
            // IngresarButton
            // 
            this.IngresarButton.Enabled = false;
            this.IngresarButton.Location = new System.Drawing.Point(430, 215);
            this.IngresarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IngresarButton.Name = "IngresarButton";
            this.IngresarButton.Size = new System.Drawing.Size(74, 35);
            this.IngresarButton.TabIndex = 20;
            this.IngresarButton.Text = "Ingresar";
            this.IngresarButton.UseVisualStyleBackColor = true;
            this.IngresarButton.Click += new System.EventHandler(this.IngresarButton_Click);
            // 
            // LimpiarButton
            // 
            this.LimpiarButton.Enabled = false;
            this.LimpiarButton.Location = new System.Drawing.Point(518, 215);
            this.LimpiarButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LimpiarButton.Name = "LimpiarButton";
            this.LimpiarButton.Size = new System.Drawing.Size(74, 35);
            this.LimpiarButton.TabIndex = 21;
            this.LimpiarButton.Text = "Limpiar";
            this.LimpiarButton.UseVisualStyleBackColor = true;
            this.LimpiarButton.Click += new System.EventHandler(this.LimpiarButton_Click);
            // 
            // LabelSueldoBruto
            // 
            this.LabelSueldoBruto.AutoSize = true;
            this.LabelSueldoBruto.Location = new System.Drawing.Point(440, 76);
            this.LabelSueldoBruto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSueldoBruto.Name = "LabelSueldoBruto";
            this.LabelSueldoBruto.Size = new System.Drawing.Size(80, 13);
            this.LabelSueldoBruto.TabIndex = 22;
            this.LabelSueldoBruto.Text = "Sueldo Bruto: 0";
            // 
            // LabelSueldoLiquido
            // 
            this.LabelSueldoLiquido.AutoSize = true;
            this.LabelSueldoLiquido.Location = new System.Drawing.Point(440, 145);
            this.LabelSueldoLiquido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSueldoLiquido.Name = "LabelSueldoLiquido";
            this.LabelSueldoLiquido.Size = new System.Drawing.Size(91, 13);
            this.LabelSueldoLiquido.TabIndex = 23;
            this.LabelSueldoLiquido.Text = "Sueldo Líquido: 0";
            // 
            // LabelDescuentos
            // 
            this.LabelDescuentos.AutoSize = true;
            this.LabelDescuentos.Location = new System.Drawing.Point(440, 110);
            this.LabelDescuentos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDescuentos.Name = "LabelDescuentos";
            this.LabelDescuentos.Size = new System.Drawing.Size(76, 13);
            this.LabelDescuentos.TabIndex = 24;
            this.LabelDescuentos.Text = "Descuentos: 0";
            // 
            // Trabajador_Ingresar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 295);
            this.ControlBox = false;
            this.Controls.Add(this.LabelDescuentos);
            this.Controls.Add(this.LabelSueldoLiquido);
            this.Controls.Add(this.LabelSueldoBruto);
            this.Controls.Add(this.LimpiarButton);
            this.Controls.Add(this.IngresarButton);
            this.Controls.Add(this.RutTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.TelefonoTextBox);
            this.Controls.Add(this.HorasExtrasTextBox);
            this.Controls.Add(this.HorasTrabajadasTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.SistemaDeSaludComboBox);
            this.Controls.Add(this.AFPComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Trabajador_Ingresar";
            this.Text = "Ingresar Trabajador";
            this.Load += new System.EventHandler(this.Trabajador_Ingresar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox AFPComboBox;
        private System.Windows.Forms.ComboBox SistemaDeSaludComboBox;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.Button VolverButton;
        public System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox HorasTrabajadasTextBox;
        private System.Windows.Forms.TextBox HorasExtrasTextBox;
        private System.Windows.Forms.TextBox TelefonoTextBox;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.TextBox RutTextBox;
        private System.Windows.Forms.Button IngresarButton;
        private System.Windows.Forms.Button LimpiarButton;
        private System.Windows.Forms.Label LabelSueldoBruto;
        private System.Windows.Forms.Label LabelSueldoLiquido;
        private System.Windows.Forms.Label LabelDescuentos;
    }
}