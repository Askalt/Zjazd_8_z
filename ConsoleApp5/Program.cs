using System;

namespace ConsoleApp5
{
    class Program
    {
         static bool printOK = true;
        static void Main(string[] args)
        {
           
            var printer = new Printer(20);


            printer.Out_of_paper += Out_of_Paper2;
            printer.Out_of_ink += Out_of_Ink;
            for (int i = 1; i < 6; i++)
            {
                printer.Print(i);
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

