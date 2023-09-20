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
using Excel = Microsoft.Office.Interop.Excel;


namespace sistema_alumnos
{
    public partial class Form9 : Form
    {
        private string DniProfesor;
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 registerForm = new Form6();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//GUARDAR NOTAS 
        {
            try
            {
                // Obtén el DataTable del DataGridView (esto contiene los datos mostrados en el DataGridView)
                DataTable dataTable = (DataTable)dataGridView1.DataSource;

                // Define la cadena de conexión a la base de datos
                string connectionString = "Data Source=EDWARDPC\\SQLEXPRESS;Initial Catalog=SISTEMA;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Itera a través de las filas del DataTable para guardar los cambios en las notas
                    foreach (DataRow row in dataTable.Rows)
                    {
                        // Obtén el ID del alumno y las nuevas notas desde el DataTable
                        int alumnoID = Convert.ToInt32(row["ID"]);
                        decimal matematica = Convert.ToDecimal(row["Matematica"]);
                        decimal comunicacion = Convert.ToDecimal(row["Comunicacion"]);
                        decimal ingles = Convert.ToDecimal(row["Ingles"]);
                        decimal fisica = Convert.ToDecimal(row["Fisica"]);
                        decimal quimica = Convert.ToDecimal(row["Quimica"]);
                        decimal algebra = Convert.ToDecimal(row["Algebra"]);
                        decimal promedioFinal = Convert.ToDecimal(row["Promedio_Final"]);

                        // Define la consulta SQL para actualizar las notas del alumno
                        string updateQuery = "UPDATE Alumnos SET " +
                                             "Matematica = @Matematica, " +
                                             "Comunicacion = @Comunicacion, " +
                                             "Ingles = @Ingles, " +
                                             "Fisica = @Fisica, " +
                                             "Quimica = @Quimica, " +
                                             "Algebra = @Algebra, " +
                                             "Promedio_Final = @PromedioFinal " +
                                             "WHERE ID = @AlumnoID";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddWithValue("@Matematica", matematica);
                            updateCommand.Parameters.AddWithValue("@Comunicacion", comunicacion);
                            updateCommand.Parameters.AddWithValue("@Ingles", ingles);
                            updateCommand.Parameters.AddWithValue("@Fisica", fisica);
                            updateCommand.Parameters.AddWithValue("@Quimica", quimica);
                            updateCommand.Parameters.AddWithValue("@Algebra", algebra);
                            updateCommand.Parameters.AddWithValue("@PromedioFinal", promedioFinal);
                            updateCommand.Parameters.AddWithValue("@AlumnoID", alumnoID);

                            // Ejecuta la consulta de actualización
                            updateCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Cambios en las notas guardados exitosamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios en las notas: " + ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void Form9_Load(object sender, EventArgs e)
        {
            // Llena el DataGridView con los datos de los alumnos del profesor
            CargarAlumnosDelProfesor();
        }
        private void CargarAlumnosDelProfesor()
        {
            try
            {
                // Define la conexión y la consulta SQL para cargar los datos de los alumnos del profesor
                string connectionString = "Data Source=EDWARDPC\\SQLEXPRESS;Initial Catalog=SISTEMA;Integrated Security=True";
                string query = "SELECT Alumnos.Nombre AS NombreAlumno, " +
                               "Alumnos.Matematica, " +
                               "Alumnos.Comunicacion, " +
                               "Alumnos.Ingles, " +
                               "Alumnos.Fisica, " +
                               "Alumnos.Quimica, " +
                               "Alumnos.Algebra, " +
                               "Alumnos.Promedio_Final " +
                               "FROM Alumnos " +
                               "WHERE Alumnos.DNI_Profesor = @DNI_Profesor";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@DNI_Profesor", DniProfesor);

                        DataSet dataSet = new DataSet();
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataSet);

                        dataGridView1.DataSource = dataSet.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de los alumnos: " + ex.Message);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//Agregamos un control gráfico
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
