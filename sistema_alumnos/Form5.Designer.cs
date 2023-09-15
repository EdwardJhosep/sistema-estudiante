namespace sistema_alumnos
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MATEMATICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMUNICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INGLES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FISICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUIMICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALGEBRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INICIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1033, 523);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATEMATICA,
            this.COMUNICACION,
            this.INGLES,
            this.FISICA,
            this.QUIMICA,
            this.ALGEBRA,
            this.INICIAL});
            this.dataGridView1.Location = new System.Drawing.Point(25, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(920, 298);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MATEMATICA
            // 
            this.MATEMATICA.HeaderText = "MATEMATICA ";
            this.MATEMATICA.MinimumWidth = 6;
            this.MATEMATICA.Name = "MATEMATICA";
            this.MATEMATICA.ReadOnly = true;
            this.MATEMATICA.Width = 125;
            // 
            // COMUNICACION
            // 
            this.COMUNICACION.HeaderText = "COMUNICACION";
            this.COMUNICACION.MinimumWidth = 6;
            this.COMUNICACION.Name = "COMUNICACION";
            this.COMUNICACION.ReadOnly = true;
            this.COMUNICACION.Width = 125;
            // 
            // INGLES
            // 
            this.INGLES.HeaderText = "INGLES";
            this.INGLES.MinimumWidth = 6;
            this.INGLES.Name = "INGLES";
            this.INGLES.ReadOnly = true;
            this.INGLES.Width = 125;
            // 
            // FISICA
            // 
            this.FISICA.HeaderText = "FISICA";
            this.FISICA.MinimumWidth = 6;
            this.FISICA.Name = "FISICA";
            this.FISICA.ReadOnly = true;
            this.FISICA.Width = 125;
            // 
            // QUIMICA
            // 
            this.QUIMICA.HeaderText = "QUIMICA";
            this.QUIMICA.MinimumWidth = 6;
            this.QUIMICA.Name = "QUIMICA";
            this.QUIMICA.ReadOnly = true;
            this.QUIMICA.Width = 125;
            // 
            // ALGEBRA
            // 
            this.ALGEBRA.HeaderText = "ALGEBRA";
            this.ALGEBRA.MinimumWidth = 6;
            this.ALGEBRA.Name = "ALGEBRA";
            this.ALGEBRA.ReadOnly = true;
            this.ALGEBRA.Width = 125;
            // 
            // INICIAL
            // 
            this.INICIAL.HeaderText = "INICIAL";
            this.INICIAL.MinimumWidth = 6;
            this.INICIAL.Name = "INICIAL";
            this.INICIAL.ReadOnly = true;
            this.INICIAL.Width = 125;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(8, 487);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(819, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(358, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENIDO";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATEMATICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMUNICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn INGLES;
        private System.Windows.Forms.DataGridViewTextBoxColumn FISICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUIMICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALGEBRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn INICIAL;
    }
}