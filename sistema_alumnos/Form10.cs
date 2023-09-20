using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace sistema_alumnos
{
    public partial class Form10 : Form
    {
        public string DniUsuario { get; set; }
        public Form10()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)//AGRUPACION DE TODO
        {

        }

        private void button2_Click(object sender, EventArgs e)//BOTON VOLVER
        {
            Form7 registerForm = new Form7();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)//TITULO
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)//IMG
        {

        }

        private void label2_Click(object sender, EventArgs e)//TEXT USUARIO-DNI
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//RESIVE EL USUARIO-DNI
        {

        }

        private void button1_Click(object sender, EventArgs e)//VER EN dataGridView1_CellContentClick
        {
            // Define la cadena de conexión a la base de datos SQL Server.
            string connectionString = "Data Source=EDWARDPC\\SQLEXPRESS;Initial Catalog=SISTEMA;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Definir la consulta SQL para obtener los datos de los alumnos y sus notas
                string query = "SELECT Usuarios.Nombre, Notas.Matematica, Notas.Comunicacion, Notas.Ingles, Notas.Fisica, Notas.Quimica, Notas.Algebra, Notas.Promedio_Final " +
                               "FROM Usuarios " +
                               "INNER JOIN Notas ON Usuarios.DNI = Notas.DNI_Alumno " +
                               "WHERE Usuarios.DNI_Administrador = @DNI_Administrador";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Establecer el valor del parámetro DNI_Administrador con el DNI del usuario actual
                    command.Parameters.AddWithValue("@DNI_Administrador", DniUsuario);

                    // Crear un DataSet
                    DataSet dataSet = new DataSet();

                    // Llenar el DataSet con el DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataSet);

                    // Establecer el DataSet como fuente de datos del DataGridView
                    dataGridView1.DataSource = dataSet.Tables[0];
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//Agregamos un control gráfico
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
