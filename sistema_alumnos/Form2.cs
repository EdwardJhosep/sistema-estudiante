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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)//RESIVE DNI
        {

        }

        private void label1_Click_1(object sender, EventArgs e)//TEXT REGISTRARSE
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)//IMAGEN 
        {

        }

        private void label2_Click(object sender, EventArgs e)//DNI TEXT
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)//RESIVE NOMBRE
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)//RESIVE CONTRASEÑA
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)//GRUPO
        {

        }

        private void label3_Click(object sender, EventArgs e)//NOMBRE TEXT
        {

        }

        private void label4_Click(object sender, EventArgs e)//CONTRASEÑA TEXT
        {

        }

        private void button1_Click(object sender, EventArgs e)//BUTON VOLVER AL LOGIN
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 registerForm = new Form7();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)//SESION TEXT
        {

        }

        private void label9_Click(object sender, EventArgs e)//EDAD TEXT
        {

        }

        private void label10_Click(object sender, EventArgs e)//DNI ADMINISTRADOR TEXT
        {

        }

        private void label5_Click(object sender, EventArgs e)//CORREO TEXT
        {

        }

        private void label6_Click(object sender, EventArgs e)//GRADO TEXT
        {

        }

        private void label8_Click(object sender, EventArgs e)//NIVEL TEXT
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)//RESIVE CORREO
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)//RESIVE GRADO
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)//RESIVE SESION
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)//RESIVE NIVEL
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)//RESIVE EDAD
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)//RESIVE DNI ADMINISTRADOR
        {

        }
    }
}
