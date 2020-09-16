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
    public partial class Pantalla2 : Form
    {
        Convertidor convertir = new Convertidor();
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
                rellenar(numero);
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

            txt3.Text = convertir.hexa_bi(txtE2.Text);
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
            chart1.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
            chart1.ChartAreas[0].AxisY.Title= "Amplitud";
            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.Series["NRZI"].IsVisibleInLegend = false;
            chart1.Series["Centro"].IsVisibleInLegend = false;

        }

        public void rellenar(string binario)
        {
            chart1.Series["NRZI"].Points.Clear();
            chart1.Series["Centro"].Points.Clear();
            string numero = "";
            int ind = 0;
            int control = 1;
            chart1.Series["NRZI"].Points.AddXY(ind, 1);
            chart1.Series["Centro"].Points.AddXY(-1, 0);
            chart1.Series["Centro"].Points.AddXY(ind, 0);
            chart1.Series["Centro"].Color = Color.Black;

            while (ind != binario.Length)
            {
                numero= binario.Substring(ind, 1);
                if (numero == "0" && control == 1)
                {
                    chart1.Series["NRZI"].Points.AddXY(ind, 1);
                    chart1.Series["Centro"].Points.AddXY(ind, 0);
                    ind++;
                }
                else if (numero == "0" && control == 0)
                {
                    chart1.Series["NRZI"].Points.AddXY(ind, -1);
                    chart1.Series["Centro"].Points.AddXY(ind, 0);
                    ind++;
                } else if (numero == "1" && control == 0)
                {
                    chart1.Series["NRZI"].Points.AddXY(ind, -1);
                    chart1.Series["NRZI"].Points.AddXY(ind, 1);
                    chart1.Series["Centro"].Points.AddXY(ind, 0);
                    control = 1;
                    ind++;
                }else if (numero == "1" && control == 1)
                {
                    
                    chart1.Series["NRZI"].Points.AddXY(ind, 1);
                    chart1.Series["NRZI"].Points.AddXY(ind, -1);
                    chart1.Series["Centro"].Points.AddXY(ind, 0);
                    control = 0;
                    ind++;
                }

            }
            if (control == 1)
            {
                chart1.Series["NRZI"].Points.AddXY(ind, 1);
                chart1.Series["Centro"].Points.AddXY(ind, 0);
                chart1.Series["Centro"].Points.AddXY(ind+1, 0);
            }
            else
            {
                chart1.Series["NRZI"].Points.AddXY(ind, -1);
                chart1.Series["Centro"].Points.AddXY(ind, 0);
                chart1.Series["Centro"].Points.AddXY(ind+1, 0);
            }
            
            



        }
    }
}
