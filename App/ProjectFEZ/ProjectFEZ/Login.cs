using Microsoft.Data.SqlClient;


namespace ProjectFEZ
{

    public partial class Form1 : Form
    {
        string conesion = "Data Source=FERNANDO;Initial Catalog=Prestamos;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void BTNiniciarseccion_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(conesion))
            {
                try
                {
                    connection.Open();

                    // Obtener los valores ingresados por el usuario
                    string nombre = TBcorreo.Text.Trim();
                    string idCuenta = TBcontraseña.Text.Trim();

                    // Consulta SQL para verificar el cliente
                    string query = @"
                        SELECT primer_nombre, identificacion 
                        FROM Clientes 
                        WHERE primer_nombre = @nombre AND identificacion = @identificacion";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@identificacion", idCuenta);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Si encuentra un resultado
                            {
                                try
                                {
                                    string query1 = "UPDATE Clientes SET recordar = 0;UPDATE Clientes SET recordar = 1 WHERE identificacion = @identificacion";

                                    using (SqlCommand cmd1 = new SqlCommand(query1, connection))
                                    {

                                        cmd1.Parameters.AddWithValue("@identificacion", idCuenta);

                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }


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

        private void CBusuario_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
