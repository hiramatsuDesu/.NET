using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvFinalHiramatsuMariaJose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 listar = new Form2();
            listar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 agregar = new Form3();
            agregar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 eliminar = new Form4();
            eliminar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 modificar = new Form5();
            modificar.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
