using System;
using System.Windows.Forms;

namespace sistema_alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();// Inicializa los componentes del formulario.

            // Asocia el evento FormClosing con el método Form1_FormClosing.
            this.FormClosing += Form1_FormClosing;
        }

       

            private void groupBox1_Enter(object sender, EventArgs e)//GROPUBOX
        {

        }

        private void label1_Click(object sender, EventArgs e)//TITULO
        {

        }

       

        private void button2_Click(object sender, EventArgs e)//BOTON INCIAR SESION
        {
            Form3 registerForm = new Form3();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//BOTON ADMIN
        {
            Form4 registerForm = new Form4();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

//Este método se ejecutará cuando el usuario intente cerrar
private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Muestra un cuadro de diálogo de confirmación.
            if (MessageBox.Show("¿Estás seguro que quieres salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // Cancela el cierre del formulario si el usuario elige "No".
            }
        }
    }
}