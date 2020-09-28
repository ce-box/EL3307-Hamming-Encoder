using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Pantallas;

namespace WindowsFormsApp4
{
    public partial class Pantalla1 : Form
    {
        public Pantalla1()
        {
            InitializeComponent();
        }

        private void Pantalla1_Load(object sender, EventArgs e)
        {
            label1.Text = "Proyecto 1 Diseño Logico II S 2020";
            // Área cliente del formulario.
            //
            Rectangle r = this.ClientRectangle;

            // Punto intermedio del área cliente.
            //
            int c = r.Width / 2;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.pantalla1.Hide();
            Program.pantalla2 = new Pantalla2();
            Program.pantalla2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.pantalla1.Hide();
            Program.pantalla3 = new Pantalla3();
            Program.pantalla3.Show();
        }

        private void Pantalla1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.pantalla1.Hide();
            Program.pantalla2 = new Pantalla2();
            Program.pantalla2.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Program.pantalla1.Hide();
            Program.pantalla3 = new Pantalla3();
            Program.pantalla3.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Program.pantalla1.Hide();
            Program.pantalla2 = new Pantalla2();
            Program.pantalla2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program.pantalla1.Hide();
            Program.pantalla3 = new Pantalla3();
            Program.pantalla3.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }
    }
    
}
