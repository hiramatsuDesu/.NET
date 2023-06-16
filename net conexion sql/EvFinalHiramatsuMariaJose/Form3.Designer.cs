namespace EvFinalHiramatsuMariaJose
{
    partial class Form3
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
            this.casado = new System.Windows.Forms.GroupBox();
            this.dniVacio = new System.Windows.Forms.Label();
            this.edadVacio = new System.Windows.Forms.Label();
            this.salarioVacio = new System.Windows.Forms.Label();
            this.nombreVacio = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dni = new System.Windows.Forms.TextBox();
            this.edad = new System.Windows.Forms.TextBox();
            this.salario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nomCom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.casado.SuspendLayout();
            this.SuspendLayout();
            // 
            // casado
            // 
            this.casado.Controls.Add(this.checkBox1);
            this.casado.Controls.Add(this.dniVacio);
            this.casado.Controls.Add(this.edadVacio);
            this.casado.Controls.Add(this.salarioVacio);
            this.casado.Controls.Add(this.nombreVacio);
            this.casado.Controls.Add(this.button2);
            this.casado.Controls.Add(this.dni);
            this.casado.Controls.Add(this.edad);
            this.casado.Controls.Add(this.salario);
            this.casado.Controls.Add(this.button1);
            this.casado.Controls.Add(this.nomCom);
            this.casado.Controls.Add(this.label4);
            this.casado.Controls.Add(this.label3);
            this.casado.Controls.Add(this.label2);
            this.casado.Controls.Add(this.label1);
            this.casado.Location = new System.Drawing.Point(12, 12);
            this.casado.Name = "casado";
            this.casado.Size = new System.Drawing.Size(316, 341);
            this.casado.TabIndex = 0;
            this.casado.TabStop = false;
            this.casado.Text = "Complete los campos";
            // 
            // dniVacio
            // 
            this.dniVacio.AutoSize = true;
            this.dniVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dniVacio.ForeColor = System.Drawing.Color.IndianRed;
            this.dniVacio.Location = new System.Drawing.Point(116, 200);
            this.dniVacio.Name = "dniVacio";
            this.dniVacio.Size = new System.Drawing.Size(28, 13);
            this.dniVacio.TabIndex = 14;
            this.dniVacio.Text = "error";
            this.dniVacio.Visible = false;
            // 
            // edadVacio
            // 
            this.edadVacio.AutoSize = true;
            this.edadVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edadVacio.ForeColor = System.Drawing.Color.IndianRed;
            this.edadVacio.Location = new System.Drawing.Point(116, 150);
            this.edadVacio.Name = "edadVacio";
            this.edadVacio.Size = new System.Drawing.Size(28, 13);
            this.edadVacio.TabIndex = 13;
            this.edadVacio.Text = "error";
            this.edadVacio.Visible = false;
            // 
            // salarioVacio
            // 
            this.salarioVacio.AutoSize = true;
            this.salarioVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salarioVacio.ForeColor = System.Drawing.Color.IndianRed;
            this.salarioVacio.Location = new System.Drawing.Point(116, 103);
            this.salarioVacio.Name = "salarioVacio";
            this.salarioVacio.Size = new System.Drawing.Size(28, 13);
            this.salarioVacio.TabIndex = 12;
            this.salarioVacio.Text = "error";
            this.salarioVacio.Visible = false;
            // 
            // nombreVacio
            // 
            this.nombreVacio.AutoSize = true;
            this.nombreVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreVacio.ForeColor = System.Drawing.Color.IndianRed;
            this.nombreVacio.Location = new System.Drawing.Point(116, 52);
            this.nombreVacio.Name = "nombreVacio";
            this.nombreVacio.Size = new System.Drawing.Size(28, 13);
            this.nombreVacio.TabIndex = 11;
            this.nombreVacio.Text = "error";
            this.nombreVacio.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(119, 177);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(127, 20);
            this.dni.TabIndex = 9;
            this.dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dni_KeyPress);
            // 
            // edad
            // 
            this.edad.Location = new System.Drawing.Point(119, 127);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(127, 20);
            this.edad.TabIndex = 8;
            this.edad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edad_KeyPress);
            // 
            // salario
            // 
            this.salario.Location = new System.Drawing.Point(119, 80);
            this.salario.Name = "salario";
            this.salario.Size = new System.Drawing.Size(127, 20);
            this.salario.TabIndex = 7;
            this.salario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salario_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(205, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nomCom
            // 
            this.nomCom.Location = new System.Drawing.Point(119, 29);
            this.nomCom.Name = "nomCom";
            this.nomCom.Size = new System.Drawing.Size(127, 20);
            this.nomCom.TabIndex = 5;
            this.nomCom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nomCom_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(151, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Casado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 375);
            this.Controls.Add(this.casado);
            this.Name = "Form3";
            this.Text = "Alta Empleado";
            this.casado.ResumeLayout(false);
            this.casado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox casado;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.TextBox salario;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nomCom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dniVacio;
        private System.Windows.Forms.Label edadVacio;
        private System.Windows.Forms.Label salarioVacio;
        private System.Windows.Forms.Label nombreVacio;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}