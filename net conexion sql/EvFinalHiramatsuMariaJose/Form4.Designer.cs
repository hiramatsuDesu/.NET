namespace EvFinalHiramatsuMariaJose
{
    partial class Form4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.filtro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.filtro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione los datos a eliminar";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(506, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cero,
            this.uno,
            this.dos,
            this.tres,
            this.cuatro,
            this.cinco});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(2, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(579, 101);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cero
            // 
            this.cero.HeaderText = "Nombre Completo";
            this.cero.Name = "cero";
            this.cero.ReadOnly = true;
            // 
            // uno
            // 
            this.uno.HeaderText = "DNI";
            this.uno.Name = "uno";
            this.uno.ReadOnly = true;
            // 
            // dos
            // 
            this.dos.HeaderText = "Casado";
            this.dos.Name = "dos";
            this.dos.ReadOnly = true;
            // 
            // tres
            // 
            this.tres.HeaderText = "Salario";
            this.tres.Name = "tres";
            this.tres.ReadOnly = true;
            // 
            // cuatro
            // 
            this.cuatro.HeaderText = "Edad";
            this.cuatro.Name = "cuatro";
            this.cuatro.ReadOnly = true;
            // 
            // cinco
            // 
            this.cinco.HeaderText = "id";
            this.cinco.Name = "cinco";
            this.cinco.ReadOnly = true;
            this.cinco.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(163, 41);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(258, 20);
            this.filtro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtro por nombre del empleado";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 352);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form4";
            this.Text = "Eliminar datos del empleado";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filtro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cero;
        private System.Windows.Forms.DataGridViewTextBoxColumn uno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dos;
        private System.Windows.Forms.DataGridViewTextBoxColumn tres;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuatro;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinco;
    }
}