using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace sistema_alumnos
{
    public partial class Form10 : Form
    {
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

        private void button1_Click(object sender, EventArgs e)//EXPORTAR A EXCEL
        {
            
        }
    }
}
