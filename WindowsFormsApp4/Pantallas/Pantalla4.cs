using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp4.Modulos;

namespace WindowsFormsApp4.Pantallas
{
    public partial class Pantalla4 : Form
    {
        Convertidor convertir = new Convertidor();

        NRZI nRZI = new NRZI();
        List<string> hexadecimal = new List<string> { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        public Pantalla4()
        {
            InitializeComponent();
        }

        private void Pantalla4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtE1.Text = txtE1.Text.ToUpper();
            string numero = txtE1.Text;

            bool verificado = false;
            int con = 0;
            while (con < numero.Length)
            {
                for (int i = 0; i < 16; i++)
                {
                    if (numero.Substring(con, 1) == hexadecimal[i])
                    {
                        verificado = true;

                    }
                }
                if (verificado == false)
                {
                    txt2.Text = "Error Caracter Invalido";

                    break;
                }
                else
                {
                    verificado = false;
                }
                con++;
            }
            if (con == numero.Length)
            {
                txt2.Text = convertir.hexa_bi(txtE1.Text);

                nRZI.rellenar2(txt2.Text, chart1);

                con = 0;
            }
            else
            {
                Program.alert = new Alert();
                Program.alert.Show();
                con = 0;
            }
        }

        private void Pantalla4_Load(object sender, EventArgs e)
        {

            chart1.Titles.Add("NRZI Grafico");
            chart1.ChartAreas[0].AxisY.Maximum = 1.5;
            chart1.ChartAreas[0].AxisY.Minimum = -1.5;
            chart1.ChartAreas[0].AxisX.Minimum = -1;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gainsboro;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            chart1.ChartAreas[0].AxisX.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisY.Title = "Amplitud";
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.Series["NRZI"].IsVisibleInLegend = false;
            chart1.Series["Centro"].IsVisibleInLegend = false;
            chart1.Series["NRZI"].Color = Color.LimeGreen;
            chart1.Series["NRZI"].BorderWidth = 2;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtE1_TextChanged(object sender, EventArgs e)
        {

        }

  
        private void button2_Click(object sender, EventArgs e)
        {
            Program.pantalla4.Hide();
            Program.pantalla1.Show();
        }

        private void txtE1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
