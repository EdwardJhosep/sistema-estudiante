using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//Agregamos un control gráfico
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)//img
        {

        }

        private void button1_Click(object sender, EventArgs e)//buton eliminar
        {

        }
    }
}
