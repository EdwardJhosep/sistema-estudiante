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
            comboBox2.Items.Clear(); // Limpiar el ComboBox de grados

            if (nivel == "Inicial")
            {
                comboBox2.Items.Add("3 años");
                comboBox2.Items.Add("4 años");
                comboBox2.Items.Add("5 años");
            }
            else if (nivel == "Primaria")
            {
                comboBox2.Items.Add("Primero");
                comboBox2.Items.Add("Segundo");
                comboBox2.Items.Add("Tercero");
                comboBox2.Items.Add("Cuarto");
                comboBox2.Items.Add("Quinto");
                comboBox2.Items.Add("Sexto");
            }
            else if (nivel == "Secundaria")
            {
                comboBox2.Items.Add("Primer año");
                comboBox2.Items.Add("Segundo año");
                comboBox2.Items.Add("Tercer año");
                comboBox2.Items.Add("Cuarto año");
                comboBox2.Items.Add("Quinto año");
            }

            // Habilitar el ComboBox de grados
            comboBox2.Enabled = true;

            // Dejar el ComboBox de grados en blanco después de cambiar las opciones
            comboBox2.SelectedIndex = -1;

        }



        // Método para llenar el ComboBox comboBox3 con las secciones basadas en el grado
        private void LlenarComboBox3Secciones(string grado)
        {
            comboBox3.Items.Clear(); // Limpiar el ComboBox de secciones

            if (grado != null)
            {
                // Agregar secciones comunes a todos los grados
                comboBox3.Items.Add("Sección A");
                comboBox3.Items.Add("Sección B");
                comboBox3.Items.Add("Sección C");
                comboBox3.Items.Add("Sección E");
                comboBox3.Items.Add("Sección D");


            }
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
        {    // Obtener la selección actual del ComboBox de niveles
            string selectedNivel = comboBox1.SelectedItem.ToString();

            // Llenar el ComboBox de grados basado en el nivel seleccionado
            LlenarComboBox2Grados(selectedNivel);

            // Deshabilitar el ComboBox de secciones hasta que se seleccione un grado
            comboBox3.Enabled = false;

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)//COMBO SELECTOR GRADO 
        {            // Obtener la selección actual del ComboBox de grados
            string selectedGrado = comboBox2.SelectedItem.ToString();

            // Llenar el ComboBox de secciones basado en el grado seleccionado
            LlenarComboBox3Secciones(selectedGrado);
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