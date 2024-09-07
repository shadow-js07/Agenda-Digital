namespace Acceso_a_datos
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.estado = new System.Windows.Forms.ComboBox();
            this.tCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.tTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.tMovil = new System.Windows.Forms.TextBox();
            this.lblMovil = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.tDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.titulo = new System.Windows.Forms.Label();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.titulo2 = new System.Windows.Forms.Label();
            this.genero = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // estado
            // 
            this.estado.BackColor = System.Drawing.SystemColors.Window;
            this.estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estado.FormattingEnabled = true;
            this.estado.Items.AddRange(new object[] {
            "Soltero",
            "Soltera",
            "Casado",
            "Casada",
            "Divorciado",
            "Divorciada",
            "Viudo",
            "Viuda"});
            this.estado.Location = new System.Drawing.Point(498, 244);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(208, 24);
            this.estado.TabIndex = 48;
            // 
            // tCorreo
            // 
            this.tCorreo.BackColor = System.Drawing.SystemColors.Window;
            this.tCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCorreo.Location = new System.Drawing.Point(541, 359);
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(220, 22);
            this.tCorreo.TabIndex = 47;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(393, 365);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(139, 17);
            this.lblCorreo.TabIndex = 46;
            this.lblCorreo.Text = "Correo Electrónico:";
            // 
            // tTelefono
            // 
            this.tTelefono.BackColor = System.Drawing.SystemColors.Window;
            this.tTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTelefono.Location = new System.Drawing.Point(553, 323);
            this.tTelefono.Name = "tTelefono";
            this.tTelefono.Size = new System.Drawing.Size(208, 22);
            this.tTelefono.TabIndex = 45;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(393, 326);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(145, 17);
            this.lblTelefono.TabIndex = 44;
            this.lblTelefono.Text = "Telefóno residencial:";
            // 
            // tMovil
            // 
            this.tMovil.BackColor = System.Drawing.SystemColors.Window;
            this.tMovil.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMovil.Location = new System.Drawing.Point(507, 285);
            this.tMovil.Name = "tMovil";
            this.tMovil.Size = new System.Drawing.Size(200, 22);
            this.tMovil.TabIndex = 43;
            // 
            // lblMovil
            // 
            this.lblMovil.AutoSize = true;
            this.lblMovil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovil.Location = new System.Drawing.Point(393, 285);
            this.lblMovil.Name = "lblMovil";
            this.lblMovil.Size = new System.Drawing.Size(100, 17);
            this.lblMovil.TabIndex = 42;
            this.lblMovil.Text = "Movil celular:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(393, 247);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(89, 17);
            this.lblEstado.TabIndex = 41;
            this.lblEstado.Text = "Estado civil:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(32, 399);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(62, 17);
            this.lblGenero.TabIndex = 38;
            this.lblGenero.Text = "Género:";
            // 
            // tDireccion
            // 
            this.tDireccion.BackColor = System.Drawing.SystemColors.Window;
            this.tDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDireccion.Location = new System.Drawing.Point(118, 359);
            this.tDireccion.Name = "tDireccion";
            this.tDireccion.Size = new System.Drawing.Size(228, 22);
            this.tDireccion.TabIndex = 37;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(35, 360);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(76, 17);
            this.lblDireccion.TabIndex = 36;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(35, 323);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(147, 17);
            this.lblFecha.TabIndex = 35;
            this.lblFecha.Text = "Fecha de nacimiento:";
            // 
            // tApellido
            // 
            this.tApellido.BackColor = System.Drawing.SystemColors.Window;
            this.tApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tApellido.Location = new System.Drawing.Point(118, 285);
            this.tApellido.Name = "tApellido";
            this.tApellido.Size = new System.Drawing.Size(228, 22);
            this.tApellido.TabIndex = 34;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(35, 285);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 17);
            this.lblApellido.TabIndex = 33;
            this.lblApellido.Text = "Apellido:";
            // 
            // tNombre
            // 
            this.tNombre.BackColor = System.Drawing.SystemColors.Window;
            this.tNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(118, 247);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(228, 22);
            this.tNombre.TabIndex = 32;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(35, 247);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 17);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre:";
            // 
            // titulo
            // 
            this.titulo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(185, 20);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(471, 53);
            this.titulo.TabIndex = 30;
            this.titulo.Text = "Buscar datos del cliente";
            this.titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.BackColor = System.Drawing.SystemColors.Window;
            this.btnBuscarID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarID.Location = new System.Drawing.Point(467, 97);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(108, 35);
            this.btnBuscarID.TabIndex = 28;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = false;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.Window;
            this.btnModificar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(260, 446);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(108, 35);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(35, 104);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(152, 17);
            this.lblBuscar.TabIndex = 50;
            this.lblBuscar.Text = "Buscar ID del cliente:";
            // 
            // tId
            // 
            this.tId.BackColor = System.Drawing.SystemColors.Window;
            this.tId.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tId.Location = new System.Drawing.Point(207, 104);
            this.tId.Name = "tId";
            this.tId.Size = new System.Drawing.Size(228, 22);
            this.tId.TabIndex = 51;
            this.tId.TextChanged += new System.EventHandler(this.tId_TextChanged);
            // 
            // titulo2
            // 
            this.titulo2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo2.Location = new System.Drawing.Point(64, 162);
            this.titulo2.Name = "titulo2";
            this.titulo2.Size = new System.Drawing.Size(717, 53);
            this.titulo2.TabIndex = 52;
            this.titulo2.Text = "Modificar o eliminar datos del cliente";
            // 
            // genero
            // 
            this.genero.Location = new System.Drawing.Point(118, 399);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(97, 22);
            this.genero.TabIndex = 53;
            // 
            // fecha
            // 
            this.fecha.CustomFormat = "dd/MM/yyyy";
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(193, 323);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(153, 22);
            this.fecha.TabIndex = 55;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(406, 446);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(108, 35);
            this.btnEliminar.TabIndex = 56;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 521);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.titulo2);
            this.Controls.Add(this.tId);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.tCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.tTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.tMovil);
            this.Controls.Add(this.lblMovil);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.tDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.tApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.btnBuscarID);
            this.Controls.Add(this.btnModificar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda Electrónica";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox estado;
        private System.Windows.Forms.TextBox tCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox tTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox tMovil;
        private System.Windows.Forms.Label lblMovil;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox tDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox tApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.Label titulo2;
        private System.Windows.Forms.TextBox genero;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button btnEliminar;
    }
}