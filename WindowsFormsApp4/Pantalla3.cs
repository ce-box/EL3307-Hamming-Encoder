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
    public partial class Pantalla3 : Form
    {
        public Pantalla3()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = "Hamming Code";
            
            DataTable dt = new DataTable();
            dt.Columns.Add("Sin paridad");
            dt.Columns.Add("P1");
            dt.Columns.Add("P2");
            dt.Columns.Add("d1");
            dt.Columns.Add("P3");
            dt.Columns.Add("d2");
            dt.Columns.Add("d3");
            dt.Columns.Add("d4");
            dt.Columns.Add("P4");
            dt.Columns.Add("d5");
            dt.Columns.Add("d6");
            dt.Columns.Add("d7");
            dt.Columns.Add("d8");
            dt.Columns.Add("d9");
            dt.Columns.Add("d10");
            dt.Columns.Add("d11");
            dt.Columns.Add("P5");
            dt.Columns.Add("d12");
            dt.Rows.Add("Sin paridad");
            dt.Rows.Add("P1");
            dt.Rows.Add("P2");
            dt.Rows.Add("P3");
            dt.Rows.Add("P4");
            dt.Rows.Add("P5");
            dt.Rows.Add("Con paridad");

            dtGV1.DataSource = dt;



            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Sin paridad");
            dt2.Columns.Add("P1");
            dt2.Columns.Add("P2");
            dt2.Columns.Add("d1");
            dt2.Columns.Add("P3");
            dt2.Columns.Add("d2");
            dt2.Columns.Add("d3");
            dt2.Columns.Add("d4");
            dt2.Columns.Add("P4");
            dt2.Columns.Add("d5");
            dt2.Columns.Add("d6");
            dt2.Columns.Add("d7");
            dt2.Columns.Add("d8");
            dt2.Columns.Add("d9");
            dt2.Columns.Add("d10");
            dt2.Columns.Add("d11");
            dt2.Columns.Add("P5");
            dt2.Columns.Add("d12");
            dt2.Rows.Add("Sin paridad");
            dt2.Rows.Add("P1");
            dt2.Rows.Add("P2");
            dt2.Rows.Add("P3");
            dt2.Rows.Add("P4");
            dt2.Rows.Add("P5");
            dt2.Rows.Add("Con paridad");

            dtGV2.DataSource = dt2;

           
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            ((DataRowView)dtGV1.Rows[0].DataBoundItem).DataView.Table.Rows[1][1] = 1;
        }

        private void Pantalla3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.pantalla3.Hide();
            Program.pantalla1.Show();
        }

       
    }
}
