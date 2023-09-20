using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistema_alumnos
{
    public partial class Form10 : Form
    {
        private string connectionString = "Data Source=EDWARDPC\\SQLEXPRESS;Initial Catalog=SISTEMA;Integrated Security=True";
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
            Form6 registerForm = new Form6();

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
            DniUsuario = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DniUsuario))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT Usuarios.Nombre, Notas.Matematica, Notas.Comunicacion, Notas.Ingles, Notas.Fisica, Notas.Quimica, Notas.Algebra, Notas.Promedio_Final " +
                                       "FROM Usuarios " +
                                       "INNER JOIN Notas ON Usuarios.DNI = Notas.DNI_Alumno " +
                                       "WHERE Usuarios.DNI = @DNI_Usuario"; // Modificamos la condición aquí

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@DNI_Usuario", DniUsuario); // Cambiamos el parámetro

                            DataSet dataSet = new DataSet();
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            adapter.Fill(dataSet);

                            dataGridView1.DataSource = dataSet.Tables[0];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un DNI válido antes de buscar datos.");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//Agregamos un control gráfico
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//VER TODO 
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Usuarios.Nombre, Notas.Matematica, Notas.Comunicacion, Notas.Ingles, Notas.Fisica, Notas.Quimica, Notas.Algebra, Notas.Promedio_Final " +
                                   "FROM Usuarios " +
                                   "INNER JOIN Notas ON Usuarios.DNI = Notas.DNI_Alumno";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        DataSet dataSet = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataSet);

                        dataGridView1.DataSource = dataSet.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
        }
    }
}
