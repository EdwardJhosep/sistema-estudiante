﻿namespace sistema_alumnos
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GRADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATEMATICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMUNICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INGLES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FISICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUIMICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALGEBRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INICIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1157, 586);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USUARIO,
            this.GRADO,
            this.MATEMATICA,
            this.COMUNICACION,
            this.INGLES,
            this.FISICA,
            this.QUIMICA,
            this.ALGEBRA,
            this.INICIAL});
            this.dataGridView1.Location = new System.Drawing.Point(1, 185);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1156, 278);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(32, 509);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(967, 507);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "ACTUALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(967, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACTUALIZAR DATOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // USUARIO
            // 
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.MinimumWidth = 6;
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.Width = 125;
            // 
            // GRADO
            // 
            this.GRADO.HeaderText = "GRADO";
            this.GRADO.MinimumWidth = 6;
            this.GRADO.Name = "GRADO";
            this.GRADO.Width = 125;
            // 
            // MATEMATICA
            // 
            this.MATEMATICA.HeaderText = "MATEMATICA";
            this.MATEMATICA.MinimumWidth = 6;
            this.MATEMATICA.Name = "MATEMATICA";
            this.MATEMATICA.Width = 125;
            // 
            // COMUNICACION
            // 
            this.COMUNICACION.HeaderText = "COMUNICACION";
            this.COMUNICACION.MinimumWidth = 6;
            this.COMUNICACION.Name = "COMUNICACION";
            this.COMUNICACION.Width = 125;
            // 
            // INGLES
            // 
            this.INGLES.HeaderText = "INGLES";
            this.INGLES.MinimumWidth = 6;
            this.INGLES.Name = "INGLES";
            this.INGLES.Width = 125;
            // 
            // FISICA
            // 
            this.FISICA.HeaderText = "FISICA";
            this.FISICA.MinimumWidth = 6;
            this.FISICA.Name = "FISICA";
            this.FISICA.Width = 125;
            // 
            // QUIMICA
            // 
            this.QUIMICA.HeaderText = "QUIMICA";
            this.QUIMICA.MinimumWidth = 6;
            this.QUIMICA.Name = "QUIMICA";
            this.QUIMICA.Width = 125;
            // 
            // ALGEBRA
            // 
            this.ALGEBRA.HeaderText = "ALGEBRA";
            this.ALGEBRA.MinimumWidth = 6;
            this.ALGEBRA.Name = "ALGEBRA";
            this.ALGEBRA.Width = 125;
            // 
            // INICIAL
            // 
            this.INICIAL.HeaderText = "INICIAL";
            this.INICIAL.MinimumWidth = 6;
            this.INICIAL.Name = "INICIAL";
            this.INICIAL.Width = 125;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 598);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form9";
            this.Text = "Form9";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATEMATICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMUNICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn INGLES;
        private System.Windows.Forms.DataGridViewTextBoxColumn FISICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUIMICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALGEBRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn INICIAL;
    }
}