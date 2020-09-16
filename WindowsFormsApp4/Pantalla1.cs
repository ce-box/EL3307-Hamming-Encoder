using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // Establecemos la nueva posición del control Label.
            //
            label1.Location = new Point(c - label1.Width / 2, label1.Location.Y);
            btn2.Location = new Point(c - btn2.Width / 2, btn2.Location.Y);
            btn1.Location = new Point(c - btn1.Width / 2, btn1.Location.Y);
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
    }
}
