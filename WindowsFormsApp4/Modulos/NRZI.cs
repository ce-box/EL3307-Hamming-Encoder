using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp4.Modulos
{
    public class NRZI
    {
        public void rellenar(string binario, Chart chart1)
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
                numero = binario.Substring(ind, 1);
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
                }
                else if (numero == "1" && control == 0)
                {
                    chart1.Series["NRZI"].Points.AddXY(ind, -1);
                    chart1.Series["NRZI"].Points.AddXY(ind, 1);
                    chart1.Series["Centro"].Points.AddXY(ind, 0);
                    control = 1;
                    ind++;
                }
                else if (numero == "1" && control == 1)
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
                chart1.Series["Centro"].Points.AddXY(ind + 1, 0);
            }
            else
            {
                chart1.Series["NRZI"].Points.AddXY(ind, -1);
                chart1.Series["Centro"].Points.AddXY(ind, 0);
                chart1.Series["Centro"].Points.AddXY(ind + 1, 0);
            }





        }

        public void rellenar2(string binario, Chart chart2)
        {
            chart2.Series["NRZI"].Points.Clear();
            chart2.Series["Centro"].Points.Clear();
            string numero = "";
            int ind = 0;
            int control = 1;
            chart2.Series["NRZI"].Points.AddXY(ind, 1);
            chart2.Series["Centro"].Points.AddXY(-1, 0);
            chart2.Series["Centro"].Points.AddXY(ind, 0);
            chart2.Series["Centro"].Color = Color.Black;

            while (ind != binario.Length)
            {
                numero = binario.Substring(ind, 1);
                if (numero == "0" && control == 1)
                {
                    chart2.Series["NRZI"].Points.AddXY(ind, 1);
                    chart2.Series["Centro"].Points.AddXY(ind, 0);
                    ind++;
                }
                else if (numero == "0" && control == 0)
                {
                    chart2.Series["NRZI"].Points.AddXY(ind, -1);
                    chart2.Series["Centro"].Points.AddXY(ind, 0);
                    ind++;
                }
                else if (numero == "1" && control == 0)
                {
                    chart2.Series["NRZI"].Points.AddXY(ind, -1);
                    chart2.Series["NRZI"].Points.AddXY(ind, 1);
                    chart2.Series["Centro"].Points.AddXY(ind, 0);
                    control = 1;
                    ind++;
                }
                else if (numero == "1" && control == 1)
                {

                    chart2.Series["NRZI"].Points.AddXY(ind, 1);
                    chart2.Series["NRZI"].Points.AddXY(ind, -1);
                    chart2.Series["Centro"].Points.AddXY(ind, 0);
                    control = 0;
                    ind++;
                }
            }
            if (control == 1)
            {
                chart2.Series["NRZI"].Points.AddXY(ind, 1);
                chart2.Series["Centro"].Points.AddXY(ind, 0);
                chart2.Series["Centro"].Points.AddXY(ind + 1, 0);
            }
            else
            {
                chart2.Series["NRZI"].Points.AddXY(ind, -1);
                chart2.Series["Centro"].Points.AddXY(ind, 0);
                chart2.Series["Centro"].Points.AddXY(ind + 1, 0);
            }

        }
    }
}
