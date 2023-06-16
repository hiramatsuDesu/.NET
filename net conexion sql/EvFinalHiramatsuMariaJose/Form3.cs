using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvFinalHiramatsuMariaJose
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nomCom.Text == "")
            {
                nombreVacio.Text = "Complete el nombre del empleado";
                nombreVacio.Visible = true;
            }
            if (salario.Text == "")
            {
                salarioVacio.Text = "Salario no puede quedar vacío";
                salarioVacio.Visible = true;
            }
            if (edad.Text == "")
            {
                edadVacio.Text = "Edad no puede queda vacío";
                edadVacio.Visible = true;
            }
            if (dni.Text == "")
            {
                dniVacio.Text = "DNI no puede quedar vacío";
                dniVacio.Visible = true;
            }
            if (nomCom.Text == "" || salario.Text == "" || edad.Text == "" || dni.Text == "")
            {
                MessageBox.Show("Por favor complete todos los campos", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                string nomApe = nomCom.Text.ToString();
                decimal sal = Convert.ToDecimal(salario.Text);
                int ed = Convert.ToInt32(edad.Text);
                string nroDoc = dni.Text.ToString();

                int cas;

                if (checkBox1.Checked == true)
                {
                    cas = 1;
                }
                else {
                    cas = 0;
                }

                SqlConnection conn = new SqlConnection("data source=DESKTOP-TNCCV7J\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi");
                conn.Open();
                string altaEmpleado = @"AltaEmpleado";

                SqlCommand c = new SqlCommand(altaEmpleado, conn);
                c.CommandType = CommandType.StoredProcedure;

                c.Parameters.Add("@NombreCompleto", SqlDbType.VarChar).Value = nomApe;
                c.Parameters.Add("@DNI", SqlDbType.VarChar).Value = nroDoc;
                c.Parameters.Add("@Edad", SqlDbType.Int).Value = ed;
                c.Parameters.Add("@Casado", SqlDbType.Bit).Value = cas;
                c.Parameters.Add("@Salario", SqlDbType.Decimal).Value = sal;
                c.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Los datos han sido guardados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                nomCom.Text = "";
                salario.Text = "";
                edad.Text = "";
                dni.Text = "";
                checkBox1.Checked = false;
            }
            
            

            nomCom.Text = "";
            salario.Text = "";
            edad.Text = "";
            dni.Text = "";
            checkBox1.Checked = false;
        }

        private void nomCom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <=255)) { 
                MessageBox.Show("solo se admiten números, no letras", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo se admiten números, no letras", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 46) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo se admiten números, no letras", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 46) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("solo se admiten números, no letras", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
