using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using GalaxySail;
using System.IO;
using System.Threading;

namespace OurWorld
{
    /// <summary>
    /// 业务逻辑代码
    /// </summary>
    public static class Biz
    {
        #region 字段

        public static Node[,] _world = new Node[500, 500];
        public static Node[,] _hiddenWorld = new Node[500, 500];
        public static Random rnd;
        private static PictureBox _canvas;
        private static int _timerCount = -1;
        private static List<Image> _imageList = null;
       
        //private static FormMain form;

        #endregion

        #region 公开属性

        /// <summary>
        /// 静态类的构造函数
        /// </summary>
        static Biz()
        {
            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    _world[i, j] = new Node();
                }
            }
            for (int i = 0; i < 500; i++)
            {
                for (int j = 0; j < 500; j++)
                {
                    _hiddenWorld[i, j] = new Node();
                }
            }
            rnd = new Random();
            //form = new FormMain();
        }

        /// <summary>
        /// PictureBox
        /// </summary>
        public static PictureBox Canvas
        {
            get { return Biz._canvas; }
            set { Biz._canvas = value; }
        }
        /// <summary>
        /// 为防止打开文件时误点击，当此属性大于0时，画布不可点击。
        /// </summary>
        public static int TimerCount
        {
            get { return Biz._timerCount; }
            set { Biz._timerCount = value; }
        }
        /// <summary>
        /// 要制作GIF的图片帧列表
        /// </summary>
        public static List<Image> ImageList
        {
            get { return Biz._imageList; }
            set { Biz._imageList = value; }
        }

        /// <summary>
        /// 中间值
        /// </summary>
        public static Node[,] HiddenWorld
        {
            get { return Biz._hiddenWorld; }
            set { Biz._hiddenWorld = value; }
        }

        /// <summary>
        /// 表示整个二维世界的数组，True为生存，False为死亡
        /// </summary>
        public static Node[,] World
        {
            get { return Biz._world; }
            set { Biz._world = value; }
        }


        #endregion

        #region 私有属性


        #endregion

        
        #region 公开方法

        /// <summary>
        /// 初始化方格
        /// </summary>
        /// <returns>Graphics</returns>
        public static Graphics InitGrid()
        {
            if (Biz.Canvas.Image != null)
            {
                Image tmpImage = Biz.Canvas.Image;
                tmpImage.Dispose();
            }
            //获得画布大小，用白色填充
            Bitmap img = new Bitmap(Constant.CANVAS_WIDTH, Constant.CANVAS_WIDTH);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            Graphics g = Graphics.FromImage(img);
            g.FillRectangle(whiteBrush, 0, 0, img.Width, img.Height);
            //初始化绘制直线的画笔，利用DrawLine方法绘制表格
            Pen p = new Pen(Color.DarkGray);
            for (int i = 0; i < Constant.GRID_COUNT; i++)
            {
                g.DrawLine(p, 0, i * Constant.GRID_WIDTH, Constant.CANVAS_WIDTH, i * Constant.GRID_WIDTH);
                g.DrawLine(p, i * Constant.GRID_WIDTH, 0, i * Constant.GRID_WIDTH, Constant.CANVAS_WIDTH);
            }
            Biz.Canvas.Image = img;

            return g;
        }
        /// <summary>
        /// 根据数组绘制世界
        /// </summary>
        public static void DrawLife()
        {
            SolidBrush blackBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush redBrush = new SolidBrush(Color.Purple);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush purpleBrush = new SolidBrush(Color.Black);
            Graphics g = Graphics.FromImage(Biz.Canvas.Image);
            for (int i = 0; i < Constant.GRID_COUNT; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    int x = j * Constant.GRID_WIDTH + 1;
                    int y = i * Constant.GRID_WIDTH + 1;

                    //根据二维数组中的颜色种类绘制不同的颜色
                    switch (Biz.World[i, j].colorKind)
                    {
                        case Constant.NOLIFE: g.FillRectangle(whiteBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;
                        case Constant.GRASS: g.FillRectangle(greenBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;
                        case Constant.GRASS_ANIMAL: g.FillRectangle(blueBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;
                        case Constant.LOW_ANIMAL: g.FillRectangle(yellowBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;
                        case Constant.HIGH_ANIMAL: g.FillRectangle(redBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;
                        case Constant.PEOPLE_ANIMAL: g.FillRectangle(blackBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;
                        case Constant.BOSS: g.FillRectangle(purpleBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;

                    }
                }
            }
        }
        /// <summary>
        /// 绘制所有生命
        /// </summary>
        public static void DrawAllLife()
        {
            FormMain.form.setCount();
            Random rnd = new Random();
            Graphics g = Biz.InitGrid();
            SolidBrush blackBrush = new SolidBrush(Color.Red);
            SolidBrush whiteBrush = new SolidBrush(Color.White);
            SolidBrush blueBrush = new SolidBrush(Color.Blue);
            SolidBrush greenBrush = new SolidBrush(Color.Green);
            SolidBrush redBrush = new SolidBrush(Color.Purple);
            SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            SolidBrush purpleBrush = new SolidBrush(Color.Black);
            for (int i = 0; i < Constant.GRID_COUNT; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    int x = j * Constant.GRID_WIDTH + 1;
                    int y = i * Constant.GRID_WIDTH + 1;
                    switch (Biz.World[i, j].colorKind)
                    {
                        case Constant.NOLIFE: g.FillRectangle(whiteBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;
                        case Constant.GRASS: g.FillRectangle(greenBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;
                        case Constant.GRASS_ANIMAL: g.FillRectangle(blueBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;
                        case Constant.LOW_ANIMAL: g.FillRectangle(yellowBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;
                        case Constant.HIGH_ANIMAL: g.FillRectangle(redBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;
                        case Constant.PEOPLE_ANIMAL: g.FillRectangle(blackBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;
                        case Constant.BOSS: g.FillRectangle(purpleBrush, x, y, Constant.LIFE_WIDTH, Constant.LIFE_WIDTH); break;

                    }
                }
            }
            Biz.Canvas.Refresh();
        }
        /// <summary>
        /// 获取所有生命
        /// </summary>
        public static void GetAllLife()
        {
            Bitmap img = Biz.Canvas.Image as Bitmap;
            for (int i = 0; i < Constant.GRID_COUNT; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    int x, y;
                    x = j * Constant.GRID_WIDTH + 2;
                    y = i * Constant.GRID_WIDTH + 2;
                }
            }
        }
       
        /// <summary>
        /// 随机布种
        /// </summary>
        public static void RandomSeed()
        {
            Random rnd = new Random();
            byte[] values = new byte[Constant.GRID_COUNT * Constant.GRID_COUNT];
            rnd.NextBytes(values);

            for (int i = 0; i < Constant.GRID_COUNT; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    if (values[i * Constant.GRID_COUNT + j] < Constant.CREAT_LIFE)
                    {
                        FormMain.form.LiveCount[Constant.GRASS - 1]++;
                        Biz.World[i, j].colorKind = Constant.GRASS;
                    }
                    else
                    {
                        Biz.World[i, j].colorKind = Constant.NOLIFE;
                    }
                }
            }
            HiddenWorld = World;
            Biz.DrawAllLife();
        }
        /// <summary>
        /// 计算下一代
        /// </summary>
        public static void NextGeneration()
        {
            FormMain.form.LiveCount = new int[5];
            for (int i = 0; i < Constant.GRID_COUNT; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    if (Biz.World[i, j].colorKind != Constant.BOSS)
                    {
                           
                        Rule.FourthJudeg(i, j);
                        Rule.EigthJudeg(i, j);
                        Rule.FifthJudeg(i, j);
                        Rule.SenventhJudeg(i, j);
                        Rule.FirstJudeg(i, j);
                        Rule.SecondJudeg(i, j);
                        Rule.ThirdJudeg(i, j);
                        Rule.SixthJudeg(i, j);

                        if (Biz.World[i, j].colorKind != Constant.NOLIFE)
                        {
                            Biz.HiddenWorld[i, j].lifeCount++;
                            FormMain.form.LiveCount[Biz.World[i, j].colorKind - 1]++;
                        }
                    }
                    else
                    {
                       Rule.bossJudeg(i, j);
                    }
                }
            }
            
            if (FormMain.form.isChange)
            {
                int n = rnd.Next(100);
                if (n > 98)
                {
                    int x = rnd.Next(Constant.GRID_COUNT);
                    int y = rnd.Next(Constant.GRID_COUNT);
                    string res = "(" + x + "," + y + ")处出现百年一遇的极其凶残的霸王物种";
                    FormMain.form.addItem(res);
                    Biz.HiddenWorld[x, y].colorKind = Constant.BOSS;
                }
            }
            if(FormMain.form.isPlace)
                Rule.eleventhJudeg();
            if(FormMain.form.PlaceRand)
                Rule.tenthJudeg();
            Node[,] tmp = Biz.HiddenWorld;
            Biz.HiddenWorld = Biz.World;
            Biz.World = tmp;
            //绘制
            Biz.DrawAllLife();
        }
        /// 地震
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <param name="y1"></param>
        /// <param name="y2"></param>
        public static void giveDisaster(int x1, int x2, int y1, int y2)
        {
            Rule.getDisasterRank(x1, x2, y1, y2);
            for (int i = x1; i < x2; i++)
            {
                for (int j = y1; j < y2; j++)
                {
                    Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                    Biz.HiddenWorld[i, j].lifeCount = 0;
                }
            }

        }
        /// <summary>
        /// 产生突变
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void giveChange(int x,int y)
        {
            string res = "(" + x + "," + y + ")处出现百年一遇的极其凶残的霸王物种";
            FormMain.form.addItem(res);
            Biz.HiddenWorld[x, y].colorKind = Constant.BOSS;

        }

        #endregion
    }
}
