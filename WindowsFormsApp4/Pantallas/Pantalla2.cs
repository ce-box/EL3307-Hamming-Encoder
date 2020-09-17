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
                MessageBox.Show("No se pudo realizar la conversión");
                con = 0;
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtE2.Text = txtE2.Text.ToUpper();
            string numero = txtE2.Text;
            
            bool verificado = false;
            int con = 0;
            while(con < numero.Length) {
                for (int i = 0; i < 16; i++)
                {
                    if (numero.Substring(con, 1) == hexadecimal[i])
                    {
                        verificado = true;

                    }
                }
                if (verificado == false)
                {
                    txt3.Text = "Error Caracter Invalido";
                    
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
                txt3.Text = convertir.hexa_bi(txtE2.Text);

                nRZI.rellenar2(txt3.Text, chart2);
                
                con = 0;
            }
            else
            {
                MessageBox.Show("No se pudo realizar la conversión");
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
            


            //chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisY.Title= "Amplitud";
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.Series["NRZI"].IsVisibleInLegend = false;
            chart1.Series["Centro"].IsVisibleInLegend = false;

            chart2.Titles.Add("NRZI Grafico");
            chart2.ChartAreas[0].AxisY.Maximum = 1.5;
            chart2.ChartAreas[0].AxisY.Minimum = -1.5;
            chart2.ChartAreas[0].AxisX.Minimum = -1;
            chart2.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gainsboro;
            chart2.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gainsboro;
            chart2.ChartAreas[0].AxisX.LineColor = Color.White;
            chart2.ChartAreas[0].AxisY.LabelStyle.Enabled = false;
            //chart2.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart2.ChartAreas[0].AxisY.Title = "Amplitud";
            chart2.ChartAreas[0].AxisX.Title = "Time";
            chart2.Series["NRZI"].IsVisibleInLegend = false;
            chart2.Series["Centro"].IsVisibleInLegend = false;

            
            

        }

        
    }
}
