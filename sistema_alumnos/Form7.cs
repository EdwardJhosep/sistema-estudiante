﻿using System;
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
    public partial class Form7 : Form
    {
        public string DniUsuario { get; set; }

        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form8 registerForm = new Form8();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 registerForm = new Form2();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 registerForm = new Form1();

            // Mostrar el formulario RegisterForm.
            registerForm.Show();

            // Opcionalmente, puedes ocultar el formulario actual (Form1) si lo deseas.
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
