namespace TallerExamenFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxNombre = new System.Windows.Forms.TextBox();
            this.TxtBoxApellido = new System.Windows.Forms.TextBox();
            this.Fecha_de_Nacimiento = new System.Windows.Forms.Label();
            this.DataTimeNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.RbottonFemenino = new System.Windows.Forms.RadioButton();
            this.RButtonMasculino = new System.Windows.Forms.RadioButton();
            this.RbuttonOtro = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtBoxCantidad = new System.Windows.Forms.TextBox();
            this.TxtBoxSaldo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DataTineEjecucuion = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.RButtonConsulta = new System.Windows.Forms.RadioButton();
            this.RButtonRetiro = new System.Windows.Forms.RadioButton();
            this.RButtonDeposito = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BtEdicion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // TxtBoxNombre
            // 
            this.TxtBoxNombre.Location = new System.Drawing.Point(87, 43);
            this.TxtBoxNombre.Name = "TxtBoxNombre";
            this.TxtBoxNombre.Size = new System.Drawing.Size(122, 20);
            this.TxtBoxNombre.TabIndex = 2;
            this.TxtBoxNombre.TextChanged += new System.EventHandler(this.TxtBoxNombre_TextChanged);
            // 
            // TxtBoxApellido
            // 
            this.TxtBoxApellido.Location = new System.Drawing.Point(87, 75);
            this.TxtBoxApellido.Name = "TxtBoxApellido";
            this.TxtBoxApellido.Size = new System.Drawing.Size(122, 20);
            this.TxtBoxApellido.TabIndex = 3;
            // 
            // Fecha_de_Nacimiento
            // 
            this.Fecha_de_Nacimiento.AutoSize = true;
            this.Fecha_de_Nacimiento.Location = new System.Drawing.Point(26, 135);
            this.Fecha_de_Nacimiento.Name = "Fecha_de_Nacimiento";
            this.Fecha_de_Nacimiento.Size = new System.Drawing.Size(111, 13);
            this.Fecha_de_Nacimiento.TabIndex = 4;
            this.Fecha_de_Nacimiento.Text = "Fecha de Nacimiento:";
            // 
            // DataTimeNacimiento
            // 
            this.DataTimeNacimiento.Location = new System.Drawing.Point(156, 135);
            this.DataTimeNacimiento.Name = "DataTimeNacimiento";
            this.DataTimeNacimiento.Size = new System.Drawing.Size(200, 20);
            this.DataTimeNacimiento.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo:";
            // 
            // RbottonFemenino
            // 
            this.RbottonFemenino.AutoSize = true;
            this.RbottonFemenino.Location = new System.Drawing.Point(32, 216);
            this.RbottonFemenino.Name = "RbottonFemenino";
            this.RbottonFemenino.Size = new System.Drawing.Size(71, 17);
            this.RbottonFemenino.TabIndex = 7;
            this.RbottonFemenino.TabStop = true;
            this.RbottonFemenino.Text = "Femenino";
            this.RbottonFemenino.UseVisualStyleBackColor = true;
            // 
            // RButtonMasculino
            // 
            this.RButtonMasculino.AutoSize = true;
            this.RButtonMasculino.Location = new System.Drawing.Point(124, 216);
            this.RButtonMasculino.Name = "RButtonMasculino";
            this.RButtonMasculino.Size = new System.Drawing.Size(68, 17);
            this.RButtonMasculino.TabIndex = 8;
            this.RButtonMasculino.TabStop = true;
            this.RButtonMasculino.Text = "Maculino";
            this.RButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // RbuttonOtro
            // 
            this.RbuttonOtro.AutoSize = true;
            this.RbuttonOtro.Location = new System.Drawing.Point(217, 216);
            this.RbuttonOtro.Name = "RbuttonOtro";
            this.RbuttonOtro.Size = new System.Drawing.Size(45, 17);
            this.RbuttonOtro.TabIndex = 9;
            this.RbuttonOtro.TabStop = true;
            this.RbuttonOtro.Text = "Otro";
            this.RbuttonOtro.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Datos Bancarios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cantidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Saldo:";
            // 
            // TxtBoxCantidad
            // 
            this.TxtBoxCantidad.Location = new System.Drawing.Point(92, 291);
            this.TxtBoxCantidad.Name = "TxtBoxCantidad";
            this.TxtBoxCantidad.Size = new System.Drawing.Size(170, 20);
            this.TxtBoxCantidad.TabIndex = 13;
            // 
            // TxtBoxSaldo
            // 
            this.TxtBoxSaldo.Location = new System.Drawing.Point(92, 327);
            this.TxtBoxSaldo.Name = "TxtBoxSaldo";
            this.TxtBoxSaldo.Size = new System.Drawing.Size(170, 20);
            this.TxtBoxSaldo.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fecha de Ejecucion:";
            // 
            // DataTineEjecucuion
            // 
            this.DataTineEjecucuion.Location = new System.Drawing.Point(156, 388);
            this.DataTineEjecucuion.Name = "DataTineEjecucuion";
            this.DataTineEjecucuion.Size = new System.Drawing.Size(200, 20);
            this.DataTineEjecucuion.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Opcion:";
            // 
            // RButtonConsulta
            // 
            this.RButtonConsulta.AutoSize = true;
            this.RButtonConsulta.Location = new System.Drawing.Point(217, 467);
            this.RButtonConsulta.Name = "RButtonConsulta";
            this.RButtonConsulta.Size = new System.Drawing.Size(66, 17);
            this.RButtonConsulta.TabIndex = 20;
            this.RButtonConsulta.TabStop = true;
            this.RButtonConsulta.Text = "Consulta";
            this.RButtonConsulta.UseVisualStyleBackColor = true;
            // 
            // RButtonRetiro
            // 
            this.RButtonRetiro.AutoSize = true;
            this.RButtonRetiro.Location = new System.Drawing.Point(124, 467);
            this.RButtonRetiro.Name = "RButtonRetiro";
            this.RButtonRetiro.Size = new System.Drawing.Size(53, 17);
            this.RButtonRetiro.TabIndex = 19;
            this.RButtonRetiro.TabStop = true;
            this.RButtonRetiro.Text = "Retiro";
            this.RButtonRetiro.UseVisualStyleBackColor = true;
            // 
            // RButtonDeposito
            // 
            this.RButtonDeposito.AutoSize = true;
            this.RButtonDeposito.Location = new System.Drawing.Point(33, 468);
            this.RButtonDeposito.Name = "RButtonDeposito";
            this.RButtonDeposito.Size = new System.Drawing.Size(67, 17);
            this.RButtonDeposito.TabIndex = 18;
            this.RButtonDeposito.TabStop = true;
            this.RButtonDeposito.Text = "Deposito";
            this.RButtonDeposito.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(422, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Direccion:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(483, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(127, 20);
            this.textBox3.TabIndex = 22;
            // 
            // BtEdicion
            // 
            this.BtEdicion.Location = new System.Drawing.Point(633, 42);
            this.BtEdicion.Name = "BtEdicion";
            this.BtEdicion.Size = new System.Drawing.Size(75, 23);
            this.BtEdicion.TabIndex = 23;
            this.BtEdicion.Text = "Edicion";
            this.BtEdicion.UseVisualStyleBackColor = true;
            this.BtEdicion.Click += new System.EventHandler(this.BtEdicion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.Controls.Add(this.BtEdicion);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RButtonConsulta);
            this.Controls.Add(this.RButtonRetiro);
            this.Controls.Add(this.RButtonDeposito);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DataTineEjecucuion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtBoxSaldo);
            this.Controls.Add(this.TxtBoxCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RbuttonOtro);
            this.Controls.Add(this.RButtonMasculino);
            this.Controls.Add(this.RbottonFemenino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataTimeNacimiento);
            this.Controls.Add(this.Fecha_de_Nacimiento);
            this.Controls.Add(this.TxtBoxApellido);
            this.Controls.Add(this.TxtBoxNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxNombre;
        private System.Windows.Forms.TextBox TxtBoxApellido;
        private System.Windows.Forms.Label Fecha_de_Nacimiento;
        private System.Windows.Forms.DateTimePicker DataTimeNacimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RbottonFemenino;
        private System.Windows.Forms.RadioButton RButtonMasculino;
        private System.Windows.Forms.RadioButton RbuttonOtro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBoxCantidad;
        private System.Windows.Forms.TextBox TxtBoxSaldo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DataTineEjecucuion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton RButtonConsulta;
        private System.Windows.Forms.RadioButton RButtonRetiro;
        private System.Windows.Forms.RadioButton RButtonDeposito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BtEdicion;
    }
}

