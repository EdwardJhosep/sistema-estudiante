using System;
using System.Windows.Forms;

namespace sistema_alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();// Inicializa los componentes del formulario.


            // Llamar a la funcion llenar combo niveles
            LlenarComboBox1Niveles();


            // Asocia el evento FormClosing con el método Form1_FormClosing.
            this.FormClosing += Form1_FormClosing;
        }

        // Método para llenar el ComboBox comboBox1 con los niveles


        private void LlenarComboBox1Niveles()//crear funcion combo niveles 
        {
            comboBox1.Items.Add("Inicial");
            comboBox1.Items.Add("Primaria");
            comboBox1.Items.Add("Secundaria");

            // Seleccionar el primer nivel por defecto
            comboBox1.SelectedIndex = 0;

        }

        // Método para llenar el ComboBox comboBox2 con los grados basados en el nivel
        private void LlenarComboBox2Grados(string nivel)
        {
            
        }

    

    // Método para llenar el ComboBox comboBox3 con las secciones basadas en el grado
    private void LlenarComboBox3Secciones(string grado)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)//GROPUBOX
        {

        }

        private void label1_Click(object sender, EventArgs e)//TITULO
        {

        }

        private void label2_Click(object sender, EventArgs e)//SELECCIONE SU GRADO
        {

        }
        private void label4_Click(object sender, EventArgs e)//TEXT SELECCIONE SECCION
        {

        }

        private void label3_Click(object sender, EventArgs e)//SELECCIONE SE SECCION
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//CONBO SELECTOR DE NIVEL
        {    
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//COMBO SELECTOR GRADO 
        {
        }



        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)//COMBO DE SELECION SECCION
        {

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