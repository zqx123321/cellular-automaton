using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OurWorld
{
    [Serializable]
    public class State
    {
        private bool _liveMode;
        private int _min;
        private int _max;
        private bool[] _lives;
        private bool _haveBorder = true;
        /// <summary>
        /// 是否是生存模式
        /// </summary>
        public bool LiveMode
        {
            get { return _liveMode; }
            set { _liveMode = value; }
        }
        /// <summary>
        /// 区间下限
        /// </summary>
        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }
        /// <summary>
        /// 区间上限
        /// </summary>
        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }
        /// <summary>
        /// 生命组
        /// </summary>
        public bool[] Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }
        /// <summary>
        /// 无参数构造函数
        /// </summary>
        public State()
        {

        }
        /// <summary>
        /// 是否有边界
        /// </summary>
        public bool HaveBorder
        {
            get { return _haveBorder; }
            set { _haveBorder = value; }
        }
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="liveMode">是否生存模式</param>
        /// <param name="min">区间下限</param>
        /// <param name="max">区间上限</param>
        /// <param name="lives">生命组</param>
        public State(bool liveMode, int min, int max, bool haveBorder, bool[,] lives)
        {
            this._liveMode = liveMode;
            this._min = min;
            this._max = max;
            this._haveBorder = haveBorder;
            this._lives = new bool[Constant.GRID_COUNT * Constant.GRID_COUNT];
            for (int i = 0; i < Constant.GRID_COUNT * Constant.GRID_COUNT; i++)
            {
                //_lives[i] = Biz.World[i / Ctt.GRID_COUNT, i % Ctt.GRID_COUNT];
            }
        }
    }
}
