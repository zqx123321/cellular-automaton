using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OurWorld
{
    public partial class result : Form
    {

        AutoSizeFormClass asc = new AutoSizeFormClass();
        public result()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void result_Load(object sender, EventArgs e)
        {
            chart1.Visible = true;
            ChartArea chartArea1 = new ChartArea("C1");
            chart1.ChartAreas.Add(chartArea1);
            chart1.Series.Clear();
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true; //用户可以选择从那里放大
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true; //用户可以选择从那里放大
            chart1.ChartAreas[0].AxisX2.Enabled = AxisEnabled.False;
            chart1.ChartAreas[0].AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
            Series Grass = new Series("绿色植物");
            Grass.ChartType = SeriesChartType.Spline;
            Series GrassAnimal = new Series("食草动物");
            GrassAnimal.ChartType = SeriesChartType.Spline;
            Series LowAnimal = new Series("低级食肉动物");
            LowAnimal.ChartType = SeriesChartType.Spline;
            Series HighAnimal = new Series("高级食肉动物");
            HighAnimal.ChartType = SeriesChartType.Spline;
            Series People = new Series("人类");
            People.ChartType = SeriesChartType.Spline;
            //给系列上的点进行赋值，分别对应横坐标和纵坐标的值
            List<String[]> res = new List<string[]>();
            for (int i = 0; i < 5; i++)
            {
                string[] lines = System.IO.File.ReadAllLines("res" + (i + 1) + ".txt");
                res.Add(lines);
            }
            
            for(int i = 0; i < res[0].Length; i++)
            {

                Grass.Points.AddY(res[Constant.GRASS-1][i]);
                GrassAnimal.Points.AddY(res[Constant.GRASS_ANIMAL - 1][i]);
                LowAnimal.Points.AddY(res[Constant.LOW_ANIMAL - 1][i]);
                HighAnimal.Points.AddY(res[Constant.HIGH_ANIMAL - 1][i]);
                People.Points.AddY(res[Constant.PEOPLE_ANIMAL - 1][i]);
            }
            chart1.ChartAreas[0].AxisX.Interval = 1;   //设置X轴坐标的间隔为1
            chart1.ChartAreas[0].AxisX.IntervalOffset = 1;  //设置X轴坐标偏移为1
            chart1.ChartAreas[0].AxisX.LabelStyle.IsStaggered = true;   //设置是否交错显示,比如数据多的时间分成两行来显示  
            //chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.Series.Add(Grass);
            chart1.Series.Add(GrassAnimal);
            chart1.Series.Add(LowAnimal);
            chart1.Series.Add(HighAnimal);
            chart1.Series.Add(People);
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].BorderWidth = 2;
            chart1.Series[2].BorderWidth = 2;
            chart1.Series[3].BorderWidth = 2;
            chart1.Series[4].BorderWidth = 2;
        

        }

        private void result_SizeChanged(object sender, EventArgs e)
        {
            asc.controlAutoSize(this);
        }
    }
}
