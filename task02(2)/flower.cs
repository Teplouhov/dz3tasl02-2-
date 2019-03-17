using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task02_2_
{
    abstract class flower
    {
        protected int cost;
        protected string color;

        protected flower() { color = "red"; cost = 100; }
        protected flower(string _color, int _cost) 
        { 
            color = _color;
            cost = _cost;
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}
