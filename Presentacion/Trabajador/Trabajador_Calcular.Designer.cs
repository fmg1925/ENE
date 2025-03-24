namespace Presentacion.Trabajador
{
    partial class Trabajador_Calcular
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
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.AdminTextBox = new System.Windows.Forms.TextBox();
            this.VolverButton = new System.Windows.Forms.Button();
            this.SalirButton = new System.Windows.Forms.Button();
            this.HorasExtrasTextBox = new System.Windows.Forms.TextBox();
            this.HorasTrabajadasTextBox = new System.Windows.Forms.TextBox();
            this.SistemaDeSaludComboBox = new System.Windows.Forms.ComboBox();
            this.AFPComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LabelDescuentos = new System.Windows.Forms.Label();
            this.LabelSueldoLiquido = new System.Windows.Forms.Label();
            this.LabelSueldoBruto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(21, 12);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.ReadOnly = true;
            this.UsuarioTextBox.Size = new System.Drawing.Size(100, 20);
            this.UsuarioTextBox.TabIndex = 0;
            this.UsuarioTextBox.Visible = false;
            // 
            // AdminTextBox
            // 
            this.AdminTextBox.Location = new System.Drawing.Point(21, 49);
            this.AdminTextBox.Name = "AdminTextBox";
            this.AdminTextBox.ReadOnly = true;
            this.AdminTextBox.Size = new System.Drawing.Size(100, 20);
            this.AdminTextBox.TabIndex = 1;
            this.AdminTextBox.Visible = false;
            // 
            // VolverButton
            // 
            this.VolverButton.Location = new System.Drawing.Point(262, 159);
            this.VolverButton.Margin = new System.Windows.Forms.Padding(2);
            this.VolverButton.Name = "VolverButton";
            this.VolverButton.Size = new System.Drawing.Size(86, 30);
            this.VolverButton.TabIndex = 9;
            this.VolverButton.Text = "Volver";
            this.VolverButton.UseVisualStyleBackColor = true;
            this.VolverButton.Click += new System.EventHandler(this.VolverButton_Click);
            // 
            // SalirButton
            // 
            this.SalirButton.Location = new System.Drawing.Point(262, 120);
            this.SalirButton.Margin = new System.Windows.Forms.Padding(2);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(86, 34);
            this.SalirButton.TabIndex = 8;
            this.SalirButton.Text = "Salir";
            this.SalirButton.UseVisualStyleBackColor = true;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // HorasExtrasTextBox
            // 
            this.HorasExtrasTextBox.Location = new System.Drawing.Point(126, 72);
            this.HorasExtrasTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HorasExtrasTextBox.Name = "HorasExtrasTextBox";
            this.HorasExtrasTextBox.Size = new System.Drawing.Size(76, 20);
            this.HorasExtrasTextBox.TabIndex = 23;
            this.HorasExtrasTextBox.TextChanged += new System.EventHandler(this.HorasExtrasTextBox_TextChanged);
            this.HorasExtrasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HorasExtrasTextBox_KeyPress);
            // 
            // HorasTrabajadasTextBox
            // 
            this.HorasTrabajadasTextBox.Location = new System.Drawing.Point(126, 26);
            this.HorasTrabajadasTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.HorasTrabajadasTextBox.Name = "HorasTrabajadasTextBox";
            this.HorasTrabajadasTextBox.Size = new System.Drawing.Size(76, 20);
            this.HorasTrabajadasTextBox.TabIndex = 22;
            this.HorasTrabajadasTextBox.TextChanged += new System.EventHandler(this.HorasTrabajadasTextBox_TextChanged);
            this.HorasTrabajadasTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HorasTrabajadasTextBox_KeyPress);
            // 
            // SistemaDeSaludComboBox
            // 
            this.SistemaDeSaludComboBox.FormattingEnabled = true;
            this.SistemaDeSaludComboBox.Items.AddRange(new object[] {
            "Fonasa",
            "Consalud",
            "Masvida",
            "Banmedica"});
            this.SistemaDeSaludComboBox.Location = new System.Drawing.Point(126, 171);
            this.SistemaDeSaludComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SistemaDeSaludComboBox.Name = "SistemaDeSaludComboBox";
            this.SistemaDeSaludComboBox.Size = new System.Drawing.Size(76, 21);
            this.SistemaDeSaludComboBox.TabIndex = 21;
            this.SistemaDeSaludComboBox.SelectedIndexChanged += new System.EventHandler(this.SistemaDeSaludComboBox_SelectedIndexChanged);
            // 
            // AFPComboBox
            // 
            this.AFPComboBox.FormattingEnabled = true;
            this.AFPComboBox.Items.AddRange(new object[] {
            "Cuprum",
            "Modelo",
            "Capital",
            "Provida"});
            this.AFPComboBox.Location = new System.Drawing.Point(126, 120);
            this.AFPComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.AFPComboBox.Name = "AFPComboBox";
            this.AFPComboBox.Size = new System.Drawing.Size(76, 21);
            this.AFPComboBox.TabIndex = 20;
            this.AFPComboBox.SelectedIndexChanged += new System.EventHandler(this.AFPComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 174);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sistema de Salud:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(76, 124);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "AFP:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Horas Extras:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Horas Trabajadas:";
            // 
            // LabelDescuentos
            // 
            this.LabelDescuentos.AutoSize = true;
            this.LabelDescuentos.Location = new System.Drawing.Point(259, 60);
            this.LabelDescuentos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelDescuentos.Name = "LabelDescuentos";
            this.LabelDescuentos.Size = new System.Drawing.Size(76, 13);
            this.LabelDescuentos.TabIndex = 27;
            this.LabelDescuentos.Text = "Descuentos: 0";
            // 
            // LabelSueldoLiquido
            // 
            this.LabelSueldoLiquido.AutoSize = true;
            this.LabelSueldoLiquido.Location = new System.Drawing.Point(259, 95);
            this.LabelSueldoLiquido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSueldoLiquido.Name = "LabelSueldoLiquido";
            this.LabelSueldoLiquido.Size = new System.Drawing.Size(91, 13);
            this.LabelSueldoLiquido.TabIndex = 26;
            this.LabelSueldoLiquido.Text = "Sueldo Líquido: 0";
            // 
            // LabelSueldoBruto
            // 
            this.LabelSueldoBruto.AutoSize = true;
            this.LabelSueldoBruto.Location = new System.Drawing.Point(259, 26);
            this.LabelSueldoBruto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSueldoBruto.Name = "LabelSueldoBruto";
            this.LabelSueldoBruto.Size = new System.Drawing.Size(80, 13);
            this.LabelSueldoBruto.TabIndex = 25;
            this.LabelSueldoBruto.Text = "Sueldo Bruto: 0";
            // 
            // Trabajador_Calcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 219);
            this.ControlBox = false;
            this.Controls.Add(this.LabelDescuentos);
            this.Controls.Add(this.LabelSueldoLiquido);
            this.Controls.Add(this.LabelSueldoBruto);
            this.Controls.Add(this.HorasExtrasTextBox);
            this.Controls.Add(this.HorasTrabajadasTextBox);
            this.Controls.Add(this.SistemaDeSaludComboBox);
            this.Controls.Add(this.AFPComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.VolverButton);
            this.Controls.Add(this.SalirButton);
            this.Controls.Add(this.AdminTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Trabajador_Calcular";
            this.Text = "Calcular Sueldos";
            this.Load += new System.EventHandler(this.Trabajador_Calcular_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox UsuarioTextBox;
        public System.Windows.Forms.TextBox AdminTextBox;
        private System.Windows.Forms.Button VolverButton;
        private System.Windows.Forms.Button SalirButton;
        private System.Windows.Forms.TextBox HorasExtrasTextBox;
        private System.Windows.Forms.TextBox HorasTrabajadasTextBox;
        private System.Windows.Forms.ComboBox SistemaDeSaludComboBox;
        private System.Windows.Forms.ComboBox AFPComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LabelDescuentos;
        private System.Windows.Forms.Label LabelSueldoLiquido;
        private System.Windows.Forms.Label LabelSueldoBruto;
    }
}