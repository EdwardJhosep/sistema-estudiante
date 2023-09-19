using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistema_alumnos
{
    public partial class Form5 : Form
    {
        private string nombreUsuario;
        private string connectionString = "Data Source=EDWARDPC\\SQLEXPRESS;Initial Catalog=SISTEMA;Integrated Security=True";

        public Form5()
        {
            InitializeComponent();
        }

        public Form5(string usuario) : this()
        {
            this.nombreUsuario = usuario;
        }




        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        { // Define the SQL query with parameters
            string query = "SELECT Matematica, Comunicacion, Ingles, Fisica, Quimica, Algebra, Promedio_Final " +
                           "FROM Notas " +
                           "WHERE DNI_Alumno = @nombreUsuario";

            // Create a SqlConnection and a SqlDataAdapter
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                // Define the parameter @nombreUsuario
                adapter.SelectCommand.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                // Create a DataTable to hold the retrieved data
                DataTable dataTable = new DataTable();

                // Fill the DataTable with data from the database
                adapter.Fill(dataTable);

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dataTable;

                // Configure the column headers in the DataGridView
                dataGridView1.Columns["Matematica"].HeaderText = "MATEMATICA";
                dataGridView1.Columns["Comunicacion"].HeaderText = "COMUNICACION";
                dataGridView1.Columns["Ingles"].HeaderText = "INGLES";
                dataGridView1.Columns["Fisica"].HeaderText = "FISICA";
                dataGridView1.Columns["Quimica"].HeaderText = "QUIMICA";
                dataGridView1.Columns["Algebra"].HeaderText = "ALGEBRA";
                dataGridView1.Columns["Promedio_Final"].HeaderText = "PROMEDIOFINAL";
            }
        }
    

    


        private void button3_Click(object sender, EventArgs e)//voton volver 
        {
            Form1 registerForm = new Form1();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//dataGridView1_CellContentClick
        {

        }

        private void label1_Click(object sender, EventArgs e)//text titulo
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)//img
        {

        }
    }
}
