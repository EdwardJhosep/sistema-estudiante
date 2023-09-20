using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            {
                // Crear una aplicación Excel
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = true; // Esto mostrará la aplicación Excel

                // Agregar un nuevo libro
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1]; // Hoja de cálculo activa

                // Encabezados de las columnas
                worksheet.Cells[1, 1] = "Usuario";
                worksheet.Cells[1, 2] = "Comportamiento";
                worksheet.Cells[1, 3] = "Matemáticas";
                worksheet.Cells[1, 4] = "Comunicación";
                worksheet.Cells[1, 5] = "Inglés";
                worksheet.Cells[1, 6] = "Álgebra";
                worksheet.Cells[1, 7] = "Física";
                worksheet.Cells[1, 8] = "Química";

                // Obtener los datos del DataGridView
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            // Manejar el caso en el que la celda sea nula (por ejemplo, asignar un valor predeterminado)
                            worksheet.Cells[i + 2, j + 1] = "ERROR ";
                        }
                    }
                }


                // Guardar el archivo Excel en una ubicación deseada
                workbook.SaveAs(@"C:\Users\Administrador\source\TuArchivo.xlsx");

                // Cerrar la aplicación Excel
                excelApp.Quit();

                // Liberar recursos
                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

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
