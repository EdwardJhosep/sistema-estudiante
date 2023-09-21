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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)//texto titulo
        {

        }

    

        private void button2_Click(object sender, EventArgs e)//buton volver
        {
            Form7 registerForm = new Form7();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)//img
        {

        }

        private void button1_Click(object sender, EventArgs e)//buton GUARDAR
        {
            // Get user input from textboxes
            string dni = textBox1.Text;
            string usuario = textBox2.Text;
            string contraseña = textBox3.Text;
            string correo = textBox4.Text;

            // Create a connection string
            string connectionString = "Data Source=EDWARDPC\\SQLEXPRESS;Initial Catalog=SISTEMA;Integrated Security=True";

            // Define the SQL query for inserting data into the Administradores table
            string insertQuery = "INSERT INTO Administradores (DNI, Usuario, Contraseña, CorreoElectronico) " +
                                 "VALUES (@DNI, @Usuario, @Contraseña, @Correo)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@DNI", dni);
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        cmd.Parameters.AddWithValue("@Correo", correo);

                        // Execute the SQL command
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Administrador agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar administrador: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)//label dni
        {

        }

        private void label3_Click(object sender, EventArgs e)//label usuario
        {

        }

        private void label4_Click(object sender, EventArgs e)//LABEL  CONTRASEÑA
        {

        }

        private void label5_Click(object sender, EventArgs e)//LABEL CORREO
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//DNI
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//USUARIO
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//CONTRASEÑA
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//CORREO
        {

        }
    }
}
