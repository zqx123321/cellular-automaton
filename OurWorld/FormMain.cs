using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OurWorld
{
    public partial class FormMain : Form
    {
        public static FormMain form;
        public bool PlaceRand;
        public bool isChange;
        public bool isPlace;
        public bool isOK;
        public int[] LiveCount;
        public FormMain()
        {
            InitializeComponent();
            Biz.Canvas = picCanvas;
            trbSpeed.Value = 5;
            tmrTime.Interval = 150;
            PlaceRand = false;
            isChange = false;
            isPlace = false;
            isOK = false;
            LiveCount = new int[5];
            this.WindowState = FormWindowState.Maximized;
            listView1.GridLines = true;//显示行与行之间的分隔线   
            listView1.FullRowSelect = true;//要选择就是一行   
            listView1.View = View.Details;//定义列表显示的方式  
            listView1.Scrollable = true;//需要时候显示滚动条  
            listView1.MultiSelect = false; // 不可以多行选择   
            listView1.HeaderStyle = ColumnHeaderStyle.Clickable;
            listView1.Visible = true;//lstView可见 
            // 针对数据库的字段名称，建立与之适应显示表头  
            listView1.Columns.Add("世界小喇叭", 400, HorizontalAlignment.Center);//第一个参数，表头名，第2个参数，表头大小，第3个参数，样式  
            listView1.Visible = true;//lstView可见
            form = this;
            for (int i = 0; i < 5; i++)
            {
                FileStream fs = new FileStream("res" + (i + 1) + ".txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Close();
                fs.Close();
            }

        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            Biz.InitGrid();
            Biz.GetAllLife();
        }

        public void setCount()
        {
            txtCountGrass.Text = LiveCount[0].ToString();
            txtCountGrassAnimal.Text = LiveCount[1].ToString();
            txtCountLowAnimal.Text = LiveCount[2].ToString();
            txtCountHighAnimal.Text = LiveCount[3].ToString();
            txtCountPeople.Text = LiveCount[4].ToString();

            for(int i = 0; i < 5; i++)
            {
                FileStream fs = new FileStream("res" + (i + 1) + ".txt", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs); // 创建写入流
                sw.WriteLine(LiveCount[i].ToString());
                sw.Close(); 
                fs.Close();
            }
            

        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == Constant.START)
            {
                if (!isOK)
                {
                    Biz.RandomSeed();
                    isOK = true;
                }
                Biz.GetAllLife();
                tmrTime.Start();
                btnStartStop.Text = Constant.STOP;
            }
            else
            {
                btnStartStop.Text = Constant.START;
                tmrTime.Stop();
            }
        }


       

        private void btnClear_Click(object sender, EventArgs e)
        {
            tmrTime.Stop();
            btnStartStop.Text = Constant.START;
            isOK = false;
            Biz.InitGrid();
            Biz.GetAllLife();
            for (int i = 0; i < 5; i++)
            {
                FileStream fs = new FileStream("res" + (i + 1) + ".txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.Close();
                fs.Close();
            }
        }

        private void trbSpeed_Scroll(object sender, EventArgs e)
        {
            if (trbSpeed.Value == 1)
            {
                tmrTime.Interval = 3000;
            }
            else if (trbSpeed.Value == 2)
            {
                tmrTime.Interval = 1000;
            }
            else if (trbSpeed.Value == 3)
            {
                tmrTime.Interval = 500;
            }
            else if (trbSpeed.Value == 4)
            {
                tmrTime.Interval = 250;
            }
            else
            {
                tmrTime.Interval = 150;
            }
        }

        private void btnRndSeed_Click(object sender, EventArgs e)
        {
            Biz.RandomSeed();
            isOK = true;
        }


        public void addItem(String content)
        {
            ListViewItem Item = new ListViewItem();
            Item.SubItems[0].Text = content;
            listView1.Items.Insert(0, Item);
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            if (Biz.TimerCount > 0)
            {
                Biz.TimerCount--;
            }
            else if (Biz.TimerCount == 0)
            {
                tmrTime.Stop();
                Biz.TimerCount--;
                picCanvas.Enabled = true;
                trbSpeed_Scroll(null, null);
            }
            else
            {
                Biz.NextGeneration();
            }
        }

     

        private void btnStep_Click(object sender, EventArgs e)
        {
            tmrTime.Stop();
            btnStartStop.Text = Constant.START;
            Biz.GetAllLife();
            Biz.NextGeneration();
        }
      

        private void picCanvas_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaceChunk_Click(object sender, EventArgs e)
        {
            isPlace = true;
            Land.SetPlaceChunk();

        }

        private void btnPlaceSlice_Click(object sender, EventArgs e)
        {
            isPlace = true;
            Land.SetPlaceSlice();
        }

        private void btnPlaceRound_Click(object sender, EventArgs e)
        {
            isPlace = true;
            Land.SetPlaceRound();
        }

        private void btnPlaceKuang_Click(object sender, EventArgs e)
        {
            isPlace = true;
            Land.SetPlaceKuang();
        }

        private void btnPlaceRand_Click(object sender, EventArgs e)
        {
            if (PlaceRand)
            {
                PlaceRand = false;
                btnPlaceRand.Text = "随机";
            }
            else
            {
                PlaceRand = true;
                btnPlaceRand.Text = "停止";
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (isChange)
            {
                isChange = false;
                btnChange.Text = "随机突变";
            }
            else
            {
                isChange = true;
                btnChange.Text = "停止突变";
            }

        }

        private void btnPlaceRemove_Click(object sender, EventArgs e)
        {
            isPlace = false;
        }

        private void btnChangePoint_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtChangeX.Text.ToString());
                int y = Convert.ToInt32(txtChangeY.Text.ToString());
                if (x < 1 || x > 150 || y < 1 || y > 150)
                {
                    MessageBox.Show("坐标范围：1~150");
                    return;
                }
                Biz.giveChange(x, y);
            }
            catch
            {
                MessageBox.Show("输入不合法");
            }
        }

        private void btnChangeChart_Click(object sender, EventArgs e)
        {
            tmrTime.Stop();
            btnStartStop.Text = Constant.START;
            new result().Show();
        }

        private void btnSaveState_Click(object sender, EventArgs e)
        {
            try
            {
                int x_min = Convert.ToInt32(txtDisXmin.Text.ToString());
                int x_max = Convert.ToInt32(txtDisXmax.Text.ToString());
                int y_min = Convert.ToInt32(txtDisYmin.Text.ToString());
                int y_max = Convert.ToInt32(txtDisYmax.Text.ToString());
                if (x_min < 1 || x_max > 150 || y_min < 1 || y_max > 150)
                {
                    MessageBox.Show("坐标范围：1~150");
                    return;
                }
                if (x_min < x_max && y_min < y_max)
                {
                    Biz.giveDisaster(x_min - 1, x_max - 1, y_min - 1, y_max - 1);
                }
            }
            catch
            {
                MessageBox.Show("输入不合法");
            }
        }
    }
}