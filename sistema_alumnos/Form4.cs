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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//boton volver
        {
            Form1 registerForm = new Form1();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//boton ingresar
        {
            Form7 registerForm = new Form7();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)//titulo
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)//img
        {

        }

        private void label3_Click(object sender, EventArgs e)//text usuario
        {

        }

        private void label2_Click(object sender, EventArgs e)//text contraseña
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)//usuario
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//contraseña
        {

        }
    }
}
