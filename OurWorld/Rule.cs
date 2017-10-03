using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurWorld
{
    public static class Rule
    {
        #region 私有方法

        /// <summary>
        /// 获取周围生命的个数
        /// </summary>
        /// <param name="i">行号</param>
        /// <param name="j">列号</param>
        /// <param name="colorKind">列号</param>
        /// <returns>周围生命个数</returns>
        private static int GetLifeCount(int i, int j, int colorKind, int type)
        {

            return GetOneLifeState(i - 1, j - 1, colorKind, type) +
                    GetOneLifeState(i - 1, j, colorKind, type) +
                    GetOneLifeState(i - 1, j + 1, colorKind, type) +
                    GetOneLifeState(i, j - 1, colorKind, type) +
                    GetOneLifeState(i, j + 1, colorKind, type) +
                    GetOneLifeState(i + 1, j - 1, colorKind, type) +
                    GetOneLifeState(i + 1, j, colorKind, type) +
                    GetOneLifeState(i + 1, j + 1, colorKind, type);
        }

        /// <summary>
        /// 无生命
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="colorKind"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        private static void GetLifeCountNo(int i, int j, ref int maxValue, ref int maxJ)
        {
            int[] tempCount = new int[10];
            for (int k = 0; k < 10; k++)
            {
                tempCount[k] = 0;
            }
            tempCount[GetOneLifeState(i - 1, j - 1, 0, 1)]++;
            tempCount[GetOneLifeState(i - 1, j + 1, 0, 1)]++;
            tempCount[GetOneLifeState(i - 1, j, 0, 1)]++;
            tempCount[GetOneLifeState(i, j - 1, 0, 1)]++;
            tempCount[GetOneLifeState(i, j + 1, 0, 1)]++;
            tempCount[GetOneLifeState(i + 1, j - 1, 0, 1)]++;
            tempCount[GetOneLifeState(i + 1, j, 0, 1)]++;
            tempCount[GetOneLifeState(i + 1, j + 1, 0, 1)]++;
            for (int k = 0; k < 10; k++)
            {
                if (maxValue <= tempCount[k])
                {
                    maxValue = tempCount[k];
                    maxJ = k;
                }
            }
        }
        /// <summary>
        /// 获取指定位置生命的状态
        /// </summary>
        /// <param name="i">行号</param>
        /// <param name="j">列号</param>
        /// <returns>1为生存，0为死亡</returns>
        private static int GetOneLifeState(int i, int j, int colorKind, int type)
        {

            if ((i == -1) || (i == Constant.GRID_COUNT) || (j == -1) || (j == Constant.GRID_COUNT))
            {
                return 0;
            }
            else
            {
                if (colorKind == Constant.NOLIFE)
                {
                    return Biz.World[i, j].colorKind;
                }
                else
                {
                    switch (type)
                    {
                        case 1: return Biz.World[i, j].colorKind < colorKind && Biz.World[i, j].colorKind != Constant.NOLIFE ? 1 : 0;
                        case 2: return Biz.World[i, j].colorKind >= colorKind ? 1 : 0;
                        case 3: return Biz.World[i, j].colorKind == colorKind ? 1 : 0;
                        default: return 0;
                    }

                }
            }
        }

        ///可否改成Pair
        private static bool FindNoLife(int i, int j, ref int noI, ref int noJ)
        {
            List<int> noIs = new List<int>();
            List<int> noJs = new List<int>();
            for (int m = -1; m <= 1; m++)
            {
                for (int n = -1; n <= 1; n++)
                {
                    if ((i + m == -1) || (i + m == Constant.GRID_COUNT) || (j + n == -1) || (j + n == Constant.GRID_COUNT)) { continue; }
                    if (m == 0 && n == 0) { continue; }
                    if (Biz.World[i + m, j + n].colorKind == Constant.NOLIFE)
                    {

                        noIs.Add(i + m);
                        noJs.Add(j + n);
                    }

                }
            }
            if (noIs.Count == 0)
                return false;
            else
            {
                int n = Biz.rnd.Next(noIs.Count);
                noI = noIs[n];
                noJ = noJs[n];
                return true;
            }
        }

        #endregion

        #region 共有方法
        /// <summary>
        /// 第一判定条件：生存规则
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void FirstJudeg(int i, int j)
        {
            int colorKind = Biz.World[i, j].colorKind;
            if (colorKind != Constant.NOLIFE && (colorKind != Constant.GRASS))
            {
                int lifeCount = GetLifeCount(i, j, colorKind, 1);

                if (lifeCount < Constant.LiveCountMin[colorKind])
                {

                    Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                    Biz.HiddenWorld[i, j].lifeCount = 0;
                }
            }
        }
        /// <summary>
        /// 第二判定条件，捕食规则
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void SecondJudeg(int i, int j)
        {
            int colorKind = Biz.World[i, j].colorKind;
            if (colorKind != Constant.NOLIFE)
            {
                int DieCount = GetLifeCount(i, j, colorKind, 2);

                if (DieCount >= Constant.DieCountx[colorKind])
                {
                    Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                    Biz.HiddenWorld[i, j].lifeCount = 0;
                }
            }

        }
        /// <summary>
        /// 第三判定条件，同化规则
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void ThirdJudeg(int i, int j)
        {
            if (Biz.World[i, j].colorKind == Constant.NOLIFE)
            {
                int maxValue = 0, maxJ = 0;
                GetLifeCountNo(i, j, ref maxValue, ref maxJ);
                if (maxValue > 2 && maxJ != 0)
                {
                    Biz.HiddenWorld[i, j].colorKind = maxJ;
                }
                else
                {
                    try
                    {
                        int t = Biz.rnd.Next(100);
                        if (t < 96) return;
                        int count = 0;
                        for (int m = -1; m <= 1; m++)
                        {
                            for (int n = -1; n <= 1; n++)
                            {
                                if (m == 0 && n == 0) continue;
                                if (Biz.World[i + m, j + n].colorKind == Constant.NOLIFE)
                                    count++;

                            }
                        }
                        if (count >= 5)
                        {
                            for (int m = -1; m <= 1; m++)
                            {
                                for (int n = -1; n <= 1; n++)
                                {
                                    if (m == 0 && n == 0) continue;
                                    if (Biz.HiddenWorld[i + m, j + n].colorKind != Constant.BOSS)
                                        Biz.HiddenWorld[i + m, j + n].colorKind = Constant.GRASS;
                                }
                            }

                        }
                    }
                    catch
                    {

                    }

                }

            }
        }
        /// <summary>
        /// 第四判定条件，死亡规则
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void FourthJudeg(int i, int j)
        {
            int colorKind = Biz.World[i, j].colorKind;
            if (colorKind != Constant.NOLIFE)
            {
                if (Biz.World[i, j].lifeCount >= Constant.LiveGenerations[colorKind])
                {
                    Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                    Biz.HiddenWorld[i, j].lifeCount = 0;

                }
            }
        }

        /// <summary>
        /// 第五判定条件，繁殖规则
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void FifthJudeg(int i, int j)
        {
            int colorKind = Biz.World[i, j].colorKind;
            if (colorKind != Constant.NOLIFE)
            {
                int SameCount = GetLifeCount(i, j, colorKind, 3);
                if (SameCount > 1)
                {
                    int noI = 0, noJ = 0;
                    if (FindNoLife(i, j, ref noI, ref noJ))
                    {

                        Biz.HiddenWorld[noI, noJ].colorKind = colorKind;
                    }
                }

            }
        }
        /// <summary>
        /// 第六判定条件，竞争规则
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void SixthJudeg(int i, int j)
        {
            int colorKind = Biz.World[i, j].colorKind;
            if (colorKind != Constant.NOLIFE)
            {
                int SameCount = GetLifeCount(i, j, colorKind, 3);
                if (SameCount > Constant.LiveCountMax[colorKind])
                {
                    Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                    Biz.HiddenWorld[i, j].lifeCount = 0;
                }

            }
        }
        /// <summary>
        /// 第七判定条件，进化规则
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void SenventhJudeg(int i, int j)
        {
            int colorKind = Biz.World[i, j].colorKind;
            if (colorKind != Constant.NOLIFE && colorKind != Constant.PEOPLE_ANIMAL && colorKind != Constant.BOSS)
            {
                int n = Biz.rnd.Next(100);
                if (n > 98)
                {
                    Biz.HiddenWorld[i, j].colorKind = colorKind + 1;
                    Biz.HiddenWorld[i, j].lifeCount = 0;
                }
            }
        }

        /// <summary>
        /// 第八判定条件，种群密度
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void EigthJudeg(int i, int j)
        {
            int colorKind = Biz.World[i, j].colorKind;
            if (colorKind != Constant.NOLIFE)
            {
                int SameCount = GetLifeCount(i, j, colorKind, 3);
                if (SameCount >= 7)
                {

                    for (int m = -1; m <= 1; m++)
                    {
                        for (int n = -1; n <= 1; n++)
                        {
                            if ((i + m == -1) || (i + m == Constant.GRID_COUNT) || (j + n == -1) || (j + n == Constant.GRID_COUNT)) { continue; }
                            if (m == 0 && n == 0) { continue; }
                            Biz.HiddenWorld[i + m, j + n].colorKind = Constant.NOLIFE;
                            Biz.HiddenWorld[i + m, j + n].lifeCount = 0;
                        }
                    }

                }
            }
        }

        /// <summary>
        /// 第九判定条件，传染病因素
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void NinthJudeg(int i, int j)
        {
            int colorKind = Biz.World[i, j].colorKind;
            if (colorKind == Constant.NOLIFE || colorKind == Constant.GRASS) return;

            int r = Biz.rnd.Next(0, 10);


            for (int m = i - r; m <= i + r; m++)
            {
                for (int n = j - r; n <= j + r; n++)
                {
                    try
                    {
                        if (Biz.World[m, n].colorKind == colorKind)
                        {
                            Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                            Biz.HiddenWorld[i, j].lifeCount = 0;
                        }
                    }
                    catch { }
                }
            }
        }
        public static void getDisasterRank(int x1, int x2, int y1, int y2)
        {
            int x = (x1 + x2) / 2;
            int y = (y1 + y2) / 2;
            int AreaSum = Constant.GRID_COUNT * Constant.GRID_COUNT;
            int AreaNow = (x2 - x1) * (y2 - y1);
            int rank = 1;
            while (rank < 12)
            {
                if (AreaNow >= AreaSum / rank)
                {
                    break;
                }
                rank++;
            }
            string res = "(" + x + "," + y + ")处发生" + (13 - rank) + "级自然灾害";
            FormMain.form.addItem(res);
        }

        /// <summary>
        /// 第十判定条件，自然灾害
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// 

        public static void tenthJudeg()
        {

            int t = Biz.rnd.Next(20);
            if (t <= 18) return;


            int x1 = Biz.rnd.Next(0, Constant.GRID_COUNT);
            int x2 = Biz.rnd.Next(0, Constant.GRID_COUNT);
            int y1 = Biz.rnd.Next(0, Constant.GRID_COUNT);
            int y2 = Biz.rnd.Next(0, Constant.GRID_COUNT);

            int x_max = x1 >= x2 ? x1 : x2;
            int x_min = x1 <= x2 ? x1 : x2;
            int y_max = y1 >= y2 ? y1 : y2;
            int y_min = y1 <= y2 ? y1 : y2;
            getDisasterRank(x_min, x_max, y_min, y_max);

            for (int i = x_min; i < x_max; i++)
            {
                for (int j = y_min; j < y_max; j++)
                {
                    Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                    Biz.HiddenWorld[i, j].lifeCount = 0;
                }
            }
        }
        public static void bossJudeg(int i, int j)
        {
            for (int m = 0; m < Constant.GRID_COUNT; m++)
            {
                for (int n = 0; n < Constant.GRID_COUNT; n++)
                {
                    if ((m - i) * (m - i) + (n - j) * (n - j) < (Constant.GRID_COUNT / 4) * (Constant.GRID_COUNT / 4))
                    {
                        if (m == i && n == j) continue;
                        if (Biz.World[m, n].colorKind != Constant.BOSS)
                        {
                            Biz.HiddenWorld[m, n].colorKind = Constant.NOLIFE;
                            Biz.HiddenWorld[m, n].lifeCount = 0;
                        }
                    }
                }
            }
            if (Biz.HiddenWorld[i, j].lifeCount + 1 < Constant.LiveGenerations[Constant.BOSS])
            {
                try
                {
                    int x = Biz.rnd.Next(11);
                    int y = Biz.rnd.Next(11);
                    Biz.HiddenWorld[i + (x - 5), j + (y - 5)].lifeCount = Biz.HiddenWorld[i, j].lifeCount + 1;
                    if ((x - 5) != 0 && (y - 5) != 0)
                    {
                        Biz.HiddenWorld[i + (x - 5), j + (y - 5)].colorKind = Constant.BOSS;
                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                        Biz.HiddenWorld[i, j].lifeCount = 0;
                    }

                }

                catch
                {
                    Biz.HiddenWorld[i, j].lifeCount += 1;
                }
            }
            else
            {
                Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                Biz.HiddenWorld[i, j].lifeCount = 0;
            }

        }

        /// <summary>
        /// 第十一判定条件，地形因素
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void eleventhJudeg()
        {
            Random rate = new Random();
            //依据地形对下一代进行纠正
            for (int i = 0; i < Constant.GRID_COUNT; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    int x = j * Constant.GRID_WIDTH + 1;
                    int y = i * Constant.GRID_WIDTH + 1;
                    if (Biz.World[i, j].placeMode == Constant.HIGHLAND)
                    {
                        if (Biz.HiddenWorld[i, j].colorKind != Constant.NOLIFE)
                        {

                            int life_rate = rate.Next(1, 10);
                            //Console.WriteLine(life_rate + "");

                            switch (Biz.World[i, j].colorKind)
                            {
                                case Constant.GRASS:
                                    if (life_rate >= 6)
                                    {//生产者生存率30%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                                case Constant.GRASS_ANIMAL:
                                    if (life_rate >= 6)
                                    {//食草动物生存率20%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                                case Constant.LOW_ANIMAL:
                                    if (life_rate >= 6)
                                    {//低级食肉动物生存率50%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                                case Constant.HIGH_ANIMAL:
                                    if (life_rate >= 6)
                                    {//高级食肉动物生存率50%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                                case Constant.PEOPLE_ANIMAL:
                                    if (life_rate >= 7)
                                    {//人类生存率50%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                            }
                        }
                    }
                    else if (Biz.World[i, j].placeMode == Constant.MOUNTAIN)
                    {//山区
                        if (Biz.HiddenWorld[i, j].colorKind != Constant.NOLIFE)
                        {

                            int life_rate = rate.Next(1, 10);
                            switch (Biz.HiddenWorld[i, j].colorKind)
                            {
                                case Constant.GRASS:
                                    if (life_rate >= 10)
                                    {//生产者生存率80%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                                case Constant.GRASS_ANIMAL:
                                    if (life_rate >= 10)
                                    {//食草动物生存率70%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                                case Constant.LOW_ANIMAL:
                                    if (life_rate >= 10)
                                    {//低级食肉动物生存率60%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                                case Constant.HIGH_ANIMAL:
                                    if (life_rate >= 10)
                                    {//高级食肉动物生存率60%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                                case Constant.PEOPLE_ANIMAL:
                                    if (life_rate >= 5)
                                    {//人类生存率50%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;

                            }
                        }
                    }

                    else if (Biz.World[i, j].placeMode == Constant.LAKE)
                    {//湖泊
                        if (Biz.HiddenWorld[i, j].colorKind != Constant.NOLIFE)
                        {

                            int life_rate = rate.Next(1, 10);
                            switch (Biz.HiddenWorld[i, j].colorKind)
                            {
                                case Constant.GRASS:
                                    if (life_rate >= 8)
                                    {//生产者生存率60%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                                case Constant.GRASS_ANIMAL:
                                    if (life_rate >= 7)
                                    {//食草动物生存率40%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                                case Constant.LOW_ANIMAL:
                                    if (life_rate >= 6)
                                    {//低级食肉动物生存率20%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                                case Constant.HIGH_ANIMAL:
                                    if (life_rate >= 6)
                                    {//高级食肉动物生存率10%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                                case Constant.PEOPLE_ANIMAL:
                                    if (life_rate >= 1)
                                    {//人类生存率0%
                                        Biz.HiddenWorld[i, j].colorKind = Constant.NOLIFE;
                                    }
                                    break;
                            }

                        }
                    }

                }
            }
        }
        #endregion
    }
}
