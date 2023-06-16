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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("data source=DESKTOP-TNCCV7J\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi");
            conn.Open();

            string nombre = filtro.Text.ToString();

            String comando = @"ListarEmpleados";
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
                dataGridView1.Rows[n].Cells[3].Value = lectura["Salario"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = lectura["Casado"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = lectura["Id"].ToString();
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string dni = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            MessageBox.Show("selecciono al empleado: " + nombre + " - DNI: " + dni, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try {
                string nombre = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string dni = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value);
                MessageBox.Show("Ha seleccionado eliminar a: " + nombre + " - DNI: " + dni, "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                try
                {
                    SqlConnection conn = new SqlConnection("data source=DESKTOP-TNCCV7J\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi");
                    conn.Open();
                    string procedimiento = @"EliminarEmpleado";
                    SqlCommand sentenciaSql = new SqlCommand(procedimiento, conn);
                    sentenciaSql.CommandType = CommandType.StoredProcedure;
                    sentenciaSql.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;
                    sentenciaSql.ExecuteNonQuery();
                    conn.Close();

                    this.dataGridView1.Rows.Clear();
                    MessageBox.Show("Se ha eliminado correctamente", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }catch (Exception ex){
                    MessageBox.Show("Error, contacte al administrador " + ex, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception exc){
                MessageBox.Show("Error, contacte al administrador " + exc, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
    
}
