using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Ink
    {
        public Ink(string color, double level)
        {
            this.color = color;
            this.level = level;
        }

        public string color { get; set; }
        public double level { get; set; }



    }
}
