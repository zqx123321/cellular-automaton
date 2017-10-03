using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OurWorld
{
    static class Constant
    {
        #region 字符串常量

        public const string LIVE = "生存";
        public const string DIE = "死亡";
        public const string START = "开始";
        public const string STOP = "停止";

        #endregion

        #region 数字常量

        /// <summary>
        /// 网格间距
        /// </summary>
        public const int GRID_WIDTH = 5;
        /// <summary>
        /// 表示生命的方格的宽度
        /// </summary>
        public const int LIFE_WIDTH = 4;
        /// <summary>
        /// 世界的大小
        /// </summary>
        public const int GRID_COUNT = 140;
        /// <summary>
        /// 随机布种时，小于此值则为生命
        /// </summary>
        public const int CREAT_LIFE = 150;

        /// <summary>
        /// 生物种类
        /// </summary>
        public const int NOLIFE = 0;
        public const int GRASS = 1;
        public const int GRASS_ANIMAL = 2;
        public const int LOW_ANIMAL = 3;
        public const int HIGH_ANIMAL = 4;
        public const int PEOPLE_ANIMAL = 5;

        public const int BOSS = 6;


        /// <summary>
        /// 地形种类
        /// </summary>
        public const int FLAT = 1;//平原
        public const int MOUNTAIN = 2;//山区
        public const int LAKE = 3;// 湖泊
        public const int HIGHLAND = 4;//高原







        /// <summary>
        /// 条件变量
        /// </summary> 



        /// <summary>
        /// 生存区间
        /// </summary>
        public static int[] LiveCountMin = new int[7] { 0, 0, 1, 2, 3, 4, 0 };
        public static int[] LiveCountMax = new int[7] { 0, 5, 4, 4, 3, 3, 100 };
        /// <summary>
        /// 死亡区间
        /// </summary>
        public static int[] DieCountx = new int[7] { 0, 2, 4, 3, 3, 3, 100 };
        /// <summary>
        /// 死亡代数
        /// </summary>
        public static int[] LiveGenerations = new int[7] { 0, 3, 4, 4, 6, 6, 50 };

        /// <summary>
        /// 画布尺寸
        /// </summary>
        public const int CANVAS_WIDTH = Constant.GRID_WIDTH * Constant.GRID_COUNT;

        #endregion
    }
}
