using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurWorld
{
    public static class Land
    {
        #region 共有方法

        /// <summary>
        /// 块状地形
        /// </summary>
        public static void SetPlaceChunk()
        {
            //加载地形
            for (int i = 0; i < Constant.GRID_COUNT / 2; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT / 2; j++)
                {
                    Biz.World[i, j].placeMode = Constant.HIGHLAND;
                }
                for (int j = Constant.GRID_COUNT / 2 + 1; j < Constant.GRID_COUNT; j++)
                {
                    Biz.World[i, j].placeMode = Constant.MOUNTAIN;
                }
            }
            for (int i = Constant.GRID_COUNT / 2 + 1; i < Constant.GRID_COUNT; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT / 2; j++)
                {
                    Biz.World[i, j].placeMode = Constant.FLAT;
                }
                for (int j = Constant.GRID_COUNT / 2 + 1; j < Constant.GRID_COUNT; j++)
                {
                    Biz.World[i, j].placeMode = Constant.LAKE;
                }
            }

        }
        /// <summary>
        /// 得到地形种类
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        private static int GetPlaceType(Double num)
        {
            //最下半径
            Double Radius = Constant.GRID_COUNT / 8;
            //大于4倍半径，高原
            if (num > 4 * Radius * 4 * Radius)
            {
                return Constant.HIGHLAND;

            }
            //大于3倍半径，山区
            if (num > 3 * Radius * 3 * Radius)
            {
                return Constant.MOUNTAIN;
            }
            //大于2倍半径，湖泊
            if (num > 2 * Radius * 2 * Radius)
            {
                return Constant.LAKE;
            }
            //2倍半径以内，平原
            else
            {
                return Constant.FLAT;
            }
        }
        /// <summary>
        /// 环状地形
        /// </summary>
        public static void SetPlaceRound()
        {
            for (int i = 0; i < Constant.GRID_COUNT; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    Double num = (i - Constant.GRID_COUNT / 2) * (i - Constant.GRID_COUNT / 2) + (j - Constant.GRID_COUNT / 2) * (j - Constant.GRID_COUNT / 2);
                    Biz.World[i, j].placeMode = GetPlaceType(num);
                }
            }

        }

        /// <summary>
        /// 框状地形
        /// </summary>
        public static void SetPlaceKuang()
        {
            for (int i = 0; i < Constant.GRID_COUNT; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    Biz.World[i, j].placeMode = 0;

                }
            }
            int Radius = Constant.GRID_COUNT / 8;
            for (int i = Constant.GRID_COUNT / 2 - Radius; i < Constant.GRID_COUNT / 2 + Radius; i++)
            {
                for (int j = Constant.GRID_COUNT / 2 - Radius; j < Constant.GRID_COUNT / 2 + Radius; j++)
                {
                    if (Biz.World[i, j].placeMode == 0)
                        Biz.World[i, j].placeMode = Constant.FLAT;
                }
            }

            for (int i = Constant.GRID_COUNT / 2 - 2 * Radius; i < Constant.GRID_COUNT / 2 + 2 * Radius; i++)
            {
                for (int j = Constant.GRID_COUNT / 2 - 2 * Radius; j < Constant.GRID_COUNT / 2 + 2 * Radius; j++)
                {
                    if (Biz.World[i, j].placeMode == 0)
                        Biz.World[i, j].placeMode = Constant.LAKE;
                }
            }
            for (int i = Constant.GRID_COUNT / 2 - 3 * Radius; i < Constant.GRID_COUNT / 2 + 3 * Radius; i++)
            {
                for (int j = Constant.GRID_COUNT / 2 - 3 * Radius; j < Constant.GRID_COUNT / 2 + 3 * Radius; j++)
                {
                    if (Biz.World[i, j].placeMode == 0)
                        Biz.World[i, j].placeMode = Constant.MOUNTAIN;
                }
            }

            for (int i = 0; i < Constant.GRID_COUNT; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    if (Biz.World[i, j].placeMode == 0)
                        Biz.World[i, j].placeMode = Constant.HIGHLAND;
                }
            }
        }

        /// <summary>
        /// 条带地形
        /// </summary>
        public static void SetPlaceSlice()
        {
            //加载地形
            for (int i = 0; i < Constant.GRID_COUNT / 8; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    Biz.World[i, j].placeMode = Constant.HIGHLAND;
                }

            }

            for (int i = Constant.GRID_COUNT / 8; i < Constant.GRID_COUNT / 4; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    Biz.World[i, j].placeMode = Constant.MOUNTAIN;
                }

            }
            for (int i = Constant.GRID_COUNT / 4; i < 3 * Constant.GRID_COUNT / 8; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    Biz.World[i, j].placeMode = Constant.LAKE;
                }

            }
            for (int i = 3 * Constant.GRID_COUNT / 8; i < 5 * Constant.GRID_COUNT / 8; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    Biz.World[i, j].placeMode = Constant.FLAT;
                }

            }
            for (int i = 5 * Constant.GRID_COUNT / 8; i < 6 * Constant.GRID_COUNT / 8; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    Biz.World[i, j].placeMode = Constant.LAKE;
                }

            }
            for (int i = 6 * Constant.GRID_COUNT / 8; i < 7 * Constant.GRID_COUNT / 8; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    Biz.World[i, j].placeMode = Constant.MOUNTAIN;
                }

            }
            for (int i = 7 * Constant.GRID_COUNT / 8; i < Constant.GRID_COUNT; i++)
            {
                for (int j = 0; j < Constant.GRID_COUNT; j++)
                {
                    Biz.World[i, j].placeMode = Constant.HIGHLAND;
                }

            }
        }
        #endregion
    }
}
