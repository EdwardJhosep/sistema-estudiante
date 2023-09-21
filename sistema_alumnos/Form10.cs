using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace sistema_alumnos
{
    public partial class Form10 : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=SISTEMA;Integrated Security=True";

        private int exportCount = 1; // Contador para generar nombres únicos
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

        private void label2_Click(object sender, EventArgs e)//TEXT ADMINITRADOR-DNI
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//RESIVE EL ADMINISTRADOR-DNI
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
                MessageBox.Show("Por favor, inicia ingrese su dni  administrador antes de ver los datos.");
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//Agregamos un control gráfico
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    // Crear una nueva instancia de Excel
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Visible = true;
                    Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                    Excel.Worksheet worksheet = (Excel.Worksheet)workbook.ActiveSheet;

                    // Encabezados de columnas
                    for (int i = 1; i <= dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }

                    // Datos de filas
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    // Generar un nombre de archivo único usando el contador
                    string fileName = $"ExportedData_{exportCount}.xlsx";
                    exportCount++; // Incrementar el contador para el próximo archivo

                    // Guardar el archivo de Excel
                    workbook.SaveAs(fileName);

                    excelApp.Quit();
                    releaseObject(worksheet);
                    releaseObject(workbook);
                    releaseObject(excelApp);

                    MessageBox.Show($"Datos exportados exitosamente a {fileName}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar a Excel: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No hay datos para exportar.");
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Error al liberar el objeto: " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
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

                            string query = "SELECT Usuarios.Nombre, Notas.Matematica, Notas.Comunicacion, Notas.Ingles, Notas.Fisica, Notas.Quimica, Notas.Algebra, Notas.Promedio_Final " +
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


        private void label3_Click(object sender, EventArgs e)//DNI USUARIO
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//OBTENER DNI USUARIO
        {

        }
    }
}
