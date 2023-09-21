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
        private DataSet dataSet = new DataSet();

        string connectionString = "Data Source=localhost;Initial Catalog=SISTEMA;Integrated Security=True";

        public string DniUsuario { get; set; }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DniUsuario))
            {
                try
                {
                    // Finaliza cualquier edición actual en el DataGridView
                    dataGridView1.EndEdit();

                    // Obtén el DataTable actual del DataGridView si existe
                    DataTable currentDataTable = dataGridView1.DataSource as DataTable;

                    if (currentDataTable != null)
                    {
                        // Obten los cambios realizados en el DataTable
                        DataTable changes = currentDataTable.GetChanges();

                        if (changes != null)
                        {
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();

                                // Usa un SqlDataAdapter para actualizar los cambios en la base de datos
                                using (SqlDataAdapter adapter = new SqlDataAdapter())
                                {
                                    adapter.SelectCommand = new SqlCommand("SELECT * FROM Notas", connection);
                                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                                    // Actualiza los cambios en la base de datos
                                    adapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                                    adapter.Update(changes);
                                }

                                // Confirma los cambios en el DataTable
                                currentDataTable.AcceptChanges();
                                MessageBox.Show("Cambios guardados exitosamente.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se detectaron cambios para guardar.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener el DataSource del DataGridView.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, inicia sesión como administrador antes de guardar los cambios.");
            }
        }


        private void Form9_Load(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dniUsuarioFiltrar = textBox2.Text;

            if (!string.IsNullOrEmpty(DniUsuario))
            {
                if (!string.IsNullOrEmpty(dniUsuarioFiltrar))
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string query = "SELECT Usuarios.Nombre, Notas.ID, Notas.DNI_Alumno, Notas.Matematica, Notas.Comunicacion, Notas.Ingles, Notas.Fisica, Notas.Quimica, Notas.Algebra, Notas.Promedio_Final " +
                                            "FROM Usuarios " +
                                            "INNER JOIN Notas ON Usuarios.DNI = Notas.DNI_Alumno " +
                                            "WHERE Usuarios.DNI_Administrador = @DNI_Administrador AND Usuarios.DNI = @DNI_Usuario";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@DNI_Administrador", DniUsuario);
                                command.Parameters.AddWithValue("@DNI_Usuario", dniUsuarioFiltrar);

                                DataSet dataSet = new DataSet();
                                SqlDataAdapter adapter = new SqlDataAdapter(command);
                                adapter.Fill(dataSet);

                                if (dataSet.Tables[0].Rows.Count > 0)
                                {
                                    dataGridView1.DataSource = dataSet.Tables[0];
                                }
                                else
                                {
                                    MessageBox.Show("No se encontraron datos para el usuario específico.");
                                }
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
                    MessageBox.Show("Por favor, ingresa el DNI del usuario para filtrar los datos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, inicia sesión como administrador antes de filtrar los datos.");
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DniUsuario))
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT Usuarios.Nombre, Notas.ID, Notas.DNI_Alumno, Notas.Matematica, Notas.Comunicacion, Notas.Ingles, Notas.Fisica, Notas.Quimica, Notas.Algebra, Notas.Promedio_Final " +
                                       "FROM Usuarios " +
                                       "INNER JOIN Notas ON Usuarios.DNI = Notas.DNI_Alumno " +
                                       "WHERE Usuarios.DNI_Administrador = @DNI_Administrador";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@DNI_Administrador", DniUsuario);

                            DataSet dataSet = new DataSet();
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            adapter.Fill(dataSet);

                            if (dataSet.Tables[0].Rows.Count > 0)
                            {
                                dataGridView1.DataSource = dataSet.Tables[0];
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron datos para el administrador actual");
                            }
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
                MessageBox.Show("Por favor, inicia sesión como administrador antes de ver los datos.");
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DniUsuario = textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
