using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistema_alumnos
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Form1 registerForm = new Form1();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text;
            string contraseña = textBox2.Text;

            // Verifica si los campos obligatorios están vacíos.
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return; // No continúes si faltan campos obligatorios.
            }

            // Define la cadena de conexión a la base de datos SQL Server.
            string connectionString = "Data Source=EDWARDPC\\SQLEXPRESS;Initial Catalog=SISTEMA;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Aquí puedes construir tu consulta SQL para verificar el usuario y la contraseña en la base de datos "SISTEMA".
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Define los parámetros de la consulta.
                        command.Parameters.AddWithValue("@Usuario", usuario);
                        command.Parameters.AddWithValue("@Contraseña", contraseña);

                        int userCount = (int)command.ExecuteScalar();

                        if (userCount > 0)
                        {

                            // Las credenciales son válidas; puedes redirigir al usuario a la página de bienvenida (Form5).
                            Form5 welcomeForm = new Form5(usuario); // Pasa el nombre de usuario al Form5.
                            welcomeForm.Show();

                            // Cierra el formulario de inicio de sesión (Form3).
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
