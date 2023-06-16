using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EvFinalHiramatsuMariaJose
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("data source=DESKTOP-TNCCV7J\\SQLEXPRESS; initial catalog=EMPLEADOS_DB; integrated security=sspi");
            conn.Open();

            String comando = @"ListarEmpleados";
            SqlCommand sentenciaSql = new SqlCommand(comando, conn);
            sentenciaSql.CommandType = CommandType.StoredProcedure;
            SqlDataReader lectura = sentenciaSql.ExecuteReader();
            while (lectura.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = lectura["NombreCompleto"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = lectura["DNI"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = lectura["Edad"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = lectura["Salario"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = lectura["Casado"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
