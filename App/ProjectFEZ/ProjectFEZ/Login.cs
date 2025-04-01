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
using Microsoft.Data.SqlClient;


namespace ProjectFEZ
{

    public partial class Form1 : Form
    {
        string conesion = "Data Source=FERNANDO;Initial Catalog=Prestamos;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void BTNiniciarseccion_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Obtener los valores ingresados por el usuario
                    string nombre = txtNombre.Text.Trim();
                    string idCuenta = txtCuenta.Text.Trim();

                    // Consulta SQL para verificar el cliente
                    string query = @"
                        SELECT c.primer_nombre, cu.id_cuenta 
                        FROM Clientes c 
                        INNER JOIN Cuenta cu ON c.Identificacion = cu.Identificacion
                        WHERE c.primer_nombre = @nombre AND cu.id_cuenta = @idCuenta";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@idCuenta", idCuenta);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Si encuentra un resultado
                            {
                                MessageBox.Show($"Bienvenido, {reader["primer_nombre"]}!", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Aquí puedes abrir otro formulario si es necesario
                            }
                            else
                            {
                                MessageBox.Show("Nombre o número de cuenta incorrecto.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Esit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
