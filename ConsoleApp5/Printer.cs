using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace ConsoleApp5
{
    class Printer
    {
        public event EventHandler<OutofpaperEventArgs> Out_of_paper;
        public event EventHandler<OutOfInkEventArgs> Out_of_ink;
        int paper_count;
        List<Ink> inks_levels;

        public Printer()
        {
            Out_of_paper += Out_of_Paper2;
            Out_of_ink +=Out_of_Ink;
            inks_levels = new List<Ink>{
                new Ink("Black",1),
                new Ink("Green",1),
                new Ink("Blue",1),
                new Ink("Red",1)
            };
        }

        public Printer(int paper_count) : this()
        {
            this.paper_count = paper_count;
        }


        public void print(int page_number)
        {
            Out_of_paper.Invoke(this, new OutofpaperEventArgs(page_number));
        }
        private void Outofpaperevent(object sender, EventArgs args)
        {
            Console.WriteLine("print out of paper");
        }
        public void Print(int pageNumber)
        {
            if (paper_count == 0)
            {
                Out_of_paper?.Invoke(this,new OutofpaperEventArgs(pageNumber));
                return;
            }
            else
            {
                foreach (var ink in inks_levels)
                {
                    if (ink.level <= 0)
                    {
                        Out_of_ink.Invoke(this, new OutOfInkEventArgs(ink.color));
                        return;
                    }
                }
                Console.WriteLine("Print...");
                --paper_count;

                foreach (var ink in inks_levels)
                {
                    ink.level -= 0.2;
                }
            }
        }
        private void Out_of_Ink(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine("Ink-low " + args.Color);

        }
        private void Out_of_Paper2(object sender, EventArgs args)
        {
            Console.WriteLine("Paper-low");

        }

    }
}

