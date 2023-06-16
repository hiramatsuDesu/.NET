using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvFinalHiramatsuMariaJose
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("data source=DESKTOP-TNCCV7J\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi");
            conn.Open();

            string nombre = textBox1.Text.ToString();

            string comando = @"ListarEmpleados";
            SqlCommand sentenciaSql = new SqlCommand(comando, conn);
            sentenciaSql.CommandType = CommandType.StoredProcedure;
            sentenciaSql.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nombre;
            SqlDataReader lectura = sentenciaSql.ExecuteReader();

            while (lectura.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = lectura["NombreCompleto"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = lectura["DNI"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = lectura["Edad"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = lectura["Salario"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = lectura["Casado"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = lectura["Id"].ToString();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string dni = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            int nroId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
            int edad = Convert.ToInt32(dataGridView1.CurrentRow.Cells[4].Value);
            decimal salario = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value);
            bool casado = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[3].Value);

            textBox2.Text = nombre;
            textBox3.Text = salario.ToString();
            textBox4.Text = edad.ToString();
            textBox5.Text = dni.ToString();
            textBox6.Text = nroId.ToString();
            if (casado)
            {
                checkBox1.Checked = true;
            }
            else {
                checkBox1.Checked = false;
            }

            //cargar el legajo del empleado
            compNombre.Text = nombre.ToString();
            compNombre.Visible = true;
            nroDni.Text = dni.ToString();
            nroDni.Visible = true;
            labelEdad.Text = edad.ToString();
            labelEdad.Visible = true;
            labeSalario.Text = salario.ToString();
            labeSalario.Visible = true;
            labelCasado.Text = casado.ToString();
            labelCasado.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                if (textBox2.Text.Length > 0 && textBox2.Text.Length > 0 && textBox3.Text.Length > 0 && textBox4.Text.Length > 0 && textBox6.Text.Length > 0)
                {
                    int id = Convert.ToInt32(textBox6.Text);
                    string nombre = textBox2.Text.ToString();
                    string dni = textBox5.Text.ToString();
                    int edad = Convert.ToInt32(textBox4.Text);
                    decimal salario = Convert.ToDecimal(textBox3.Text);
                    int casado;

                    if (checkBox1.Checked)
                    {
                        casado = 1;
                    }
                    else {
                        casado = 0;
                    }
                    
                    SqlConnection conn = new SqlConnection("data source=DESKTOP-TNCCV7J\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi");
                    conn.Open();
                    string altaEmpleado = @"ModificarEmpleado";

                    SqlCommand c = new SqlCommand(altaEmpleado, conn);
                    c.CommandType = CommandType.StoredProcedure;

                    c.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;
                    c.Parameters.Add("@NombreCompleto", SqlDbType.VarChar).Value = nombre;
                    c.Parameters.Add("@DNI", SqlDbType.VarChar).Value = dni;
                    c.Parameters.Add("@Edad", SqlDbType.Int).Value = edad;
                    c.Parameters.Add("@Casado", SqlDbType.Bit).Value = casado;
                    c.Parameters.Add("@Salario", SqlDbType.Decimal).Value = salario;
                    c.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Los datos han sido modificados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                    checkBox1.Checked = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    this.dataGridView1.Rows.Clear();

                }
                else {
                    MessageBox.Show("Verifique, hay campos que no estan cargados");
                }
            }catch(Exception ex){
                MessageBox.Show("error " + ex);
            }

            //mostrar el legajo modificado
            try
            {
                
                SqlConnection conn = new SqlConnection("data source=DESKTOP-TNCCV7J\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi");
                conn.Open();
                int nroId = Convert.ToInt32(textBox6.Text);
                string comando = @"MostrarEmpleado";
                SqlCommand sentenciaSql = new SqlCommand(comando, conn);
                sentenciaSql.CommandType = CommandType.StoredProcedure;
                sentenciaSql.Parameters.Add("@Id", SqlDbType.Int).Value = nroId;
                SqlDataReader lectura = sentenciaSql.ExecuteReader();

                while (lectura.Read())
                {
                    compNombre.Text = lectura["NombreCompleto"].ToString();
                    nroDni.Text = lectura["DNI"].ToString();
                    labeSalario.Text = lectura["Salario"].ToString();
                    labelEdad.Text = lectura["Edad"].ToString();
                    labelCasado.Text = lectura["casado"].ToString();
                }
            }
            catch (Exception ex) {
                MessageBox.Show("error" + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
