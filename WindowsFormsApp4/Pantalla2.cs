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

        
        
    }
}
