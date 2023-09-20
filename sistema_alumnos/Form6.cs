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
    public partial class Form6 : Form
    {
        // Otras declaraciones de la clase

        // Propiedad para almacenar el DNI del usuario
        public string DniUsuario { get; set; }

        // Constructor de la clase
        public Form6()
        {
            InitializeComponent();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Form4 registerForm = new Form4();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)//ACTUALIZAR NOTAS
        {
            Form9 registerForm = new Form9();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)//VER NOTAS
        {
            // Crear una instancia de Form10
            Form10 form10 = new Form10();

            // Asignar el valor del DNI de Form6 a la propiedad DniUsuario de Form10
            form10.DniUsuario = this.DniUsuario;

            // Mostrar Form10
            form10.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form6) si lo deseas.
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

            // Mostrar el DNI almacenado en el Label cuando se haga clic en el botón.
            label3.Text = " " + DniUsuario;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
