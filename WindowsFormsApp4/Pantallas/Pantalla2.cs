using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp4.Modulos;
using WindowsFormsApp4.Pantallas;

namespace WindowsFormsApp4
{
    public partial class Pantalla2 : Form
    {
        Convertidor convertir = new Convertidor();
        
        NRZI nRZI = new NRZI();
        List<string> hexadecimal = new List<string> {"0","1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };
        public Pantalla2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero = txtE1.Text;
            int con = 0;
            
            while (con != numero.Length)
            {
                if (numero.Substring(con, 1)=="1" || numero.Substring(con, 1) == "0")
                {
                    con++;
                }
                else
                {
                    txt1.Text = "Error Caracter invalido";
                    txt2.Text = "Error Caracter invalido";
                    break;
                }
            }
            if (con == numero.Length)
            {
                txt1.Text=convertir.bi_hexa(numero);
                txt2.Text =convertir.bi_octal(numero);
                nRZI.rellenar(numero,chart1);
                con = 0;
            }
            else
            {
                Program.alert = new Alert();
                Program.alert.Show();
                con = 0;
            }
            
            
        }


        private void Pantalla2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Program.pantalla2.Hide();
            Program.pantalla1.Show();
        }

        private void Pantalla2_Load(object sender, EventArgs e)
        {
            
            chart1.Titles.Add("NRZI Grafico");
            chart1.ChartAreas[0].AxisY.Maximum = 1.5;
            chart1.ChartAreas[0].AxisY.Minimum = -1.5;
            chart1.ChartAreas[0].AxisX.Minimum = -1;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gainsboro;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            chart1.ChartAreas[0].AxisX.LineColor = Color.White;
            chart1.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisY.Title= "Amplitud";
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.Series["Centro"].IsVisibleInLegend = false;
            chart1.Series["NRZI"].IsVisibleInLegend = false;
            chart1.Series["NRZI"].Color = Color.LimeGreen;
            chart1.Series["NRZI"].BorderWidth = 2;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void txtE2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
