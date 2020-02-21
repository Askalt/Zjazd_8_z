using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
   public class OutofpaperEventArgs:EventArgs
    {
        int page_number;

        public OutofpaperEventArgs(int page_number)
        {
            this.page_number = page_number;
        }
    }
}
