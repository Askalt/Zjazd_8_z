using System;

namespace ConsoleApp5
{
    class Program
    {
         static bool printOK = true;
        static void Main(string[] args)
        {
           
            var drukarka = new Printer(88);

            drukarka.Out_of_paper += Out_of_Paper2;
            drukarka.Out_of_ink += Out_of_Ink;
            for (int i = 1; i < 10; i++)
            {
                drukarka.Print(i);
                if (!printOK)
                {
                    return;
                }
            }

        }
        static void Out_of_Paper2(object sender, EventArgs args)
        {

            Console.WriteLine("Brak papieru !!!");
            printOK = false;

        }
        static void Out_of_Ink(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine("Brak Tuszu " + args.Color);
            printOK = false;
        }

    }
}

