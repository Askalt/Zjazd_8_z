using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class OutOfInkEventArgs:EventArgs
    {
        public OutOfInkEventArgs(string c)
        {
            Color = c;
        }
        public string Color;
    }
}
