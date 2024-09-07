using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Acceso_a_datos
{
    public partial class Form1 : Form
    {
        private Form2 form2Instance;
        SqlConnection conect = new SqlConnection("Server=LAPTOP-B0VC381B;Database=AgendaDigital;Trusted_Connection=True;");

        string Nombre;
        string Apellido;
        DateTime Fecha;
        string Direccion;
        string Estado;
        string Movil;
        string Telefono;
        string Correo;
        string Genero;

        public Form1()
        {
            InitializeComponent();
            form2Instance = new Form2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nombre = tNombre.Text;
            Apellido = tApellido.Text;
            Fecha = fechaN.Value;
            Direccion = tDireccion.Text;
            Estado = estadoC.Text;
            Movil = tMovil.Text;
            Telefono = tTelefono.Text;
            Correo = tCorreo.Text;

           
                string query = "INSERT INTO Contactos (Nombre, Apellido, FechaNacimiento, Direccion, Genero, EstadoCivil, Movil, Telefono, CorreoElectronico) " +
                               "VALUES (@Nombre, @Apellido, @FechaNacimiento, @Direccion, @Genero, @EstadoCivil, @Movil, @Telefono, @CorreoElectronico)";
                using (SqlCommand comando = new SqlCommand(query, conect))
                {
                    comando.Parameters.AddWithValue("@Nombre", Nombre);
                    comando.Parameters.AddWithValue("@Apellido", Apellido);
                    comando.Parameters.AddWithValue("@FechaNacimiento", Fecha);
                    comando.Parameters.AddWithValue("@Direccion", Direccion);
                    comando.Parameters.AddWithValue("@Genero", Genero);
                    comando.Parameters.AddWithValue("@EstadoCivil", Estado);
                    comando.Parameters.AddWithValue("@Movil", Movil);
                    comando.Parameters.AddWithValue("@Telefono", Telefono);
                    comando.Parameters.AddWithValue("@CorreoElectronico", Correo);

                    conect.Open();
                    comando.ExecuteNonQuery();
                    conect.Close();
                }

                MessageBox.Show("Datos insertados correctamente en la base de datos.");
            

            tNombre.Text = "";
            tApellido.Text = "";
            tDireccion.Text = "";
            estadoC.Text = "";
            tMovil.Text = "";
            tTelefono.Text = "" ;
            tCorreo.Text = "";

        }

        private void fecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Masculino_CheckedChanged(object sender, EventArgs e)
        {
            Genero = "M";
        }

        private void Femenino_CheckedChanged(object sender, EventArgs e)
        {
            Genero = "F";
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            form2Instance.ShowDialog();
        }
    }
}
