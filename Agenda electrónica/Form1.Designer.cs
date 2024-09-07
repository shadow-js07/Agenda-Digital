namespace Acceso_a_datos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.Femenino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tMovil = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tCorreo = new System.Windows.Forms.TextBox();
            this.estadoC = new System.Windows.Forms.ComboBox();
            this.fechaN = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.SystemColors.Window;
            this.btnInsertar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(243, 298);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(108, 35);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(401, 298);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 53);
            this.label1.TabIndex = 4;
            this.label1.Text = "Datos del cliente";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(40, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre:";
            // 
            // tNombre
            // 
            this.tNombre.BackColor = System.Drawing.SystemColors.Window;
            this.tNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(123, 86);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(228, 22);
            this.tNombre.TabIndex = 6;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(40, 124);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 17);
            this.lblApellido.TabIndex = 7;
            this.lblApellido.Text = "Apellido:";
            // 
            // tApellido
            // 
            this.tApellido.BackColor = System.Drawing.SystemColors.Window;
            this.tApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tApellido.Location = new System.Drawing.Point(123, 124);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(228, 22);
            this.tApellido.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fecha de nacimiento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dirección:";
            // 
            // tDireccion
            // 
            this.tDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.tDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDireccion.Location = new System.Drawing.Point(123, 198);
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(228, 22);
            this.tDireccion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Género:";
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masculino.Location = new System.Drawing.Point(114, 238);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(44, 21);
            this.Masculino.TabIndex = 14;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "M";
            this.Masculino.UseVisualStyleBackColor = true;
            this.Masculino.CheckedChanged += new System.EventHandler(this.Masculino_CheckedChanged);
            // 
            // Femenino
            // 
            this.Femenino.AutoSize = true;
            this.Femenino.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Femenino.Location = new System.Drawing.Point(159, 238);
            this.Femenino.Name = "Femenino";
            this.Femenino.Size = new System.Drawing.Size(38, 21);
            this.Femenino.TabIndex = 15;
            this.Femenino.TabStop = true;
            this.Femenino.Text = "F";
            this.Femenino.UseVisualStyleBackColor = true;
            this.Femenino.CheckedChanged += new System.EventHandler(this.Femenino_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(398, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Estado civil:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(398, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Movil celular:";
            // 
            // tMovil
            // 
            this.tMovil.BackColor = System.Drawing.SystemColors.Window;
            this.tMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMovil.Location = new System.Drawing.Point(504, 124);
            this.tMovil.Name = "tMovil";
            this.tMovil.Size = new System.Drawing.Size(208, 22);
            this.tMovil.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(398, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Telefóno recidencial:";
            // 
            // tTelefono
            // 
            this.tTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.tTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTelefono.Location = new System.Drawing.Point(558, 162);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(208, 22);
            this.tTelefono.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(398, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Correo Electrónico:";
            // 
            // tCorreo
            // 
            this.tCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.tCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCorreo.Location = new System.Drawing.Point(546, 198);
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(220, 22);
            this.tCorreo.TabIndex = 23;
            // 
            // estadoC
            // 
            this.estadoC.FormattingEnabled = true;
            this.estadoC.Items.AddRange(new object[] {
            "Soltero",
            "Soltera",
            "Casado",
            "Casada",
            "Divorciado",
            "Divorciada",
            "Viudo",
            "Viuda"});
            this.estadoC.Location = new System.Drawing.Point(504, 86);
            this.estadoC.Name = "estadoC";
            this.estadoC.Size = new System.Drawing.Size(208, 24);
            this.estadoC.TabIndex = 24;
            // 
            // fechaN
            // 
            this.fechaN.CustomFormat = "dd/MM/yyyy";
            this.fechaN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaN.Location = new System.Drawing.Point(207, 161);
            this.fechaN.Name = "fechaN";
            this.fechaN.Size = new System.Drawing.Size(144, 22);
            this.fechaN.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(809, 360);
            this.Controls.Add(this.fechaN);
            this.Controls.Add(this.estadoC);
            this.Controls.Add(this.tCorreo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tMovil);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Femenino);
            this.Controls.Add(this.Masculino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnInsertar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Electrónica";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.RadioButton Femenino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tMovil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tCorreo;
        private System.Windows.Forms.ComboBox estadoC;
        private System.Windows.Forms.DateTimePicker fechaN;
    }
}

