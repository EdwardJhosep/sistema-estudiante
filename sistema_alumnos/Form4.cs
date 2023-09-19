using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_alumnos
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//boton volver
        {
            Form1 registerForm = new Form1();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//boton ingresar
        {
            string dni = textBox1.Text;
            string contraseña = textBox2.Text;

            // Verifica si los campos obligatorios están vacíos.
            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(contraseña))
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

                    // Consulta SQL para verificar el DNI y la contraseña en la tabla "Administradores".
                    string query = "SELECT COUNT(*) FROM Administradores WHERE DNI = @DNI AND Contraseña = @Contraseña";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Define los parámetros de la consulta.
                        command.Parameters.AddWithValue("@DNI", dni);
                        command.Parameters.AddWithValue("@Contraseña", contraseña);

                        int adminCount = (int)command.ExecuteScalar();

                        if (adminCount > 0)
                        {
                            // Las credenciales son válidas; puedes redirigir al administrador a la página de bienvenida.
                            Form7 form7 = new Form7();
                            form7.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("DNI o contraseña incorrectos.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)//titulo
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)//img
        {

        }

        private void label3_Click(object sender, EventArgs e)//text usuario
        {

        }

        private void label2_Click(object sender, EventArgs e)//text contraseña
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//usuario
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//contraseña
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
