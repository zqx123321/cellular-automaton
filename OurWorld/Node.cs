using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OurWorld
{
    /// <summary>
    /// 
    /// </summary>
    public class Node
    {
        public Node() {
            this.colorKind = 0;
            this.lifeCount = 0;//繁殖了几代
            this.placeMode = 0;
            
        }

        public int colorKind { get; set; }
        public int lifeCount { get; set; }
        public int placeMode { get; set; }
    }
}
