using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_Dashboard_Dark_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void delay_Tick(object sender, EventArgs e)
        {
            //give the gui time to render before lading data :-) - 
            delay.Stop();

            Bunifu.DataViz.WinForms.Canvas data = new Bunifu.DataViz.WinForms.Canvas();

            //custom chart colors
            bunifuCharts1.colorSet.Add(Color.FromArgb(149, 48, 93));
            bunifuCharts1.colorSet.Add(Color.FromArgb(225, 155, 45));
            bunifuCharts1.colorSet.Add(Color.FromArgb(75, 146, 108));


            //CREDIT SALES CHART

            Bunifu.DataViz.WinForms.DataPoint point1 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            point1.addLabely("MONDAY", "5800");
            point1.addLabely("TUESDAY", "5000");
            point1.addLabely("WEDNESDAY", "4000");
            point1.addLabely("THURSDAY", "8000");
            point1.addLabely("FRIDAY", "4000");
            point1.addLabely("SATURDAY", "5800");
            point1.addLabely("SUNDAY", "5000");
            data.addData(point1);

            //CHANNEL SALES CHART

            Bunifu.DataViz.WinForms.DataPoint point2 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            point2.addLabely("MONDAY", "2800");
            point2.addLabely("TUESDAY", "2500");
            point2.addLabely("WEDNESDAY", "3200");
            point2.addLabely("THURSDAY", "6000");
            point2.addLabely("FRIDAY", "3500");
            point2.addLabely("SATURDAY", "4000");
            point2.addLabely("SUNDAY", "3000");
            data.addData(point2);
           // bunifuCharts1.Render(data);

            //DIRECT SALES

            Bunifu.DataViz.WinForms.DataPoint point3 = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);
            point3.addLabely("MONDAY", "1000");
            point3.addLabely("TUESDAY", "2000");
            point3.addLabely("WEDNESDAY", "1100");
            point3.addLabely("THURSDAY", "4300");
            point3.addLabely("FRIDAY", "4000");
            point3.addLabely("SATURDAY", "1000");
            point3.addLabely("SUNDAY", "2000");
            data.addData(point3);
            bunifuCharts1.Render(data);





        }

        private void loader_Tick(object sender, EventArgs e)
        {
            
        }

        private void bunifuCharts1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
