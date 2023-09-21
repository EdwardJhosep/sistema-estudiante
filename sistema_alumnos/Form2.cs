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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)//RESIVE DNI
        {

        }

        private void label1_Click_1(object sender, EventArgs e)//TEXT REGISTRARSE
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)//IMAGEN 
        {

        }

        private void label2_Click(object sender, EventArgs e)//DNI TEXT
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//RESIVE NOMBRE
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//RESIVE CONTRASEÑA
        {
            textBox2.PasswordChar = '*';
        }

        private void groupBox1_Enter(object sender, EventArgs e)//GRUPO
        {

        }

        private void label3_Click(object sender, EventArgs e)//NOMBRE TEXT
        {

        }

        private void label4_Click(object sender, EventArgs e)//CONTRASEÑA TEXT
        {

        }

        private void button1_Click(object sender, EventArgs e)//BUTON VOLVER AL LOGIN
        {
            // Get user input from textboxes
            string dni = textBox1.Text;
            string nombre = textBox2.Text;
            string contraseña = textBox3.Text;
            string correo = textBox4.Text;
            string grado = textBox5.Text;
            int sesion;
            int.TryParse(textBox6.Text, out sesion); // Handle invalid input
            string nivel = textBox7.Text;
            int edad;
            int.TryParse(textBox8.Text, out edad); // Handle invalid input
            int dniAdministrador;
            int.TryParse(textBox9.Text, out dniAdministrador); // Handle invalid input

            // Define the connection string to the SQL Server database.
            string connectionString = "Data Source=localhost;Initial Catalog=SISTEMA;Integrated Security=True";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if the DNI_Administrador is 2001, and if so, display an error message.
                    if (dniAdministrador == 2001)
                    {
                        MessageBox.Show("El DNI 2001 no es un profesor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Define the SQL query for inserting data into the Usuarios table.
                    string insertQuery = "INSERT INTO Usuarios (DNI, Nombre, Contraseña, CorreoElectronico, Grado, Sesion, Nivel, Edad, DNI_Administrador) " +
                                         "VALUES (@DNI, @Nombre, @Contraseña, @Correo, @Grado, @Sesion, @Nivel, @Edad, @DNI_Administrador)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@DNI", dni);
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Grado", grado);
                        cmd.Parameters.AddWithValue("@Sesion", sesion);
                        cmd.Parameters.AddWithValue("@Nivel", nivel);
                        cmd.Parameters.AddWithValue("@Edad", edad);
                        cmd.Parameters.AddWithValue("@DNI_Administrador", dniAdministrador);

                        // Execute the SQL command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 registerForm = new Form7();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)//SESION TEXT
        {

        }

        private void label9_Click(object sender, EventArgs e)//EDAD TEXT
        {

        }

        private void label10_Click(object sender, EventArgs e)//DNI ADMINISTRADOR TEXT
        {

        }

        private void label5_Click(object sender, EventArgs e)//CORREO TEXT
        {

        }

        private void label6_Click(object sender, EventArgs e)//GRADO TEXT
        {

        }

        private void label8_Click(object sender, EventArgs e)//NIVEL TEXT
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//RESIVE CORREO
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//RESIVE GRADO
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)//RESIVE SESION
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)//RESIVE NIVEL
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)//RESIVE EDAD
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)//RESIVE DNI ADMINISTRADOR
        {

        }
    }
}
