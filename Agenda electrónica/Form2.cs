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
using System.Collections;

namespace Acceso_a_datos
{
    public partial class Form2 : Form
    {
        SqlConnection conect = new SqlConnection("Server=LAPTOP-B0VC381B;Database=AgendaDigital;Trusted_Connection=True;");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            conect.Open();

            string ID = tId.Text;
            string query = "select * from Contactos where Id =" + ID;
            SqlCommand comando = new SqlCommand(query, conect);
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                tNombre.Text = reader["Nombre"].ToString();
                tApellido.Text = reader["Apellido"].ToString();
                fecha.Value = Convert.ToDateTime(reader["FechaNacimiento"]);
                tDireccion.Text = reader["Direccion"].ToString();
                genero.Text = reader["Genero"].ToString();
                estado.Text = reader["EstadoCivil"].ToString();
                tMovil.Text = reader["Movil"].ToString();
                tTelefono.Text = reader["Telefono"].ToString();
                tCorreo.Text = reader["CorreoElectronico"].ToString();
                btnModificar.Enabled = true;
            }
            else
                MessageBox.Show("No existe registro.");
            conect.Close();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            conect.Open();

            string ID = tId.Text;
            string Nombre = tNombre.Text;
            string Apellido = tApellido.Text;
            DateTime Fecha = fecha.Value;
            string Direccion = tDireccion.Text;
            string Estado = estado.Text;
            string Movil = tMovil.Text;
            string Telefono = tTelefono.Text;
            string Correo = tCorreo.Text;
            string Genero = genero.Text;

            string query = "UPDATE Contactos SET Nombre = @Nombre, Apellido = @Apellido, FechaNacimiento = @Fecha, Direccion = @Direccion, " +
                           "Genero = @Genero, EstadoCivil = @Estado, Movil = @Movil, Telefono = @Telefono, CorreoElectronico = @Correo WHERE Id = @ID";

            SqlCommand comando = new SqlCommand(query, conect);

            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Apellido", Apellido);
            comando.Parameters.AddWithValue("@Fecha", Fecha);
            comando.Parameters.AddWithValue("@Direccion", Direccion);
            comando.Parameters.AddWithValue("@Genero", Genero);
            comando.Parameters.AddWithValue("@Estado", Estado);
            comando.Parameters.AddWithValue("@Movil", Movil);
            comando.Parameters.AddWithValue("@Telefono", Telefono);
            comando.Parameters.AddWithValue("@Correo", Correo);
            comando.Parameters.AddWithValue("@ID", ID);

            int cantidad;
            cantidad = comando.ExecuteNonQuery();

                if (cantidad == 1)
                {
                    MessageBox.Show("Modificación de datos exitosa.");
                    tNombre.Text = "";
                    tApellido.Text = "";
                    tDireccion.Text = "";
                    genero.Text = "";
                    estado.Text = "";
                    tMovil.Text = "";
                    tTelefono.Text = "";
                    tCorreo.Text = "";
                }
                else
                {
                    MessageBox.Show("No existe registro.");
              
                }

                conect.Close();
                btnModificar.Enabled = false;
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conect.Open();

            string ID = tId.Text;
            string query = "delete from Contactos where Id =" + ID;
            SqlCommand comando = new SqlCommand(query, conect);
            int fila = comando.ExecuteNonQuery();

            if (fila > 0)
            {
                MessageBox.Show("Datos eliminados correctamente.");
                tNombre.Text = "";
                tApellido.Text = "";
                tDireccion.Text = "";
                genero.Text = "";
                estado.Text = "";
                tMovil.Text = "";
                tTelefono.Text = "";
                tCorreo.Text = "";
            }
            else
            MessageBox.Show("No existe registro con ese ID.");
            conect.Close();
        }
    }
}

