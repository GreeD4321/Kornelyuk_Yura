using System;

namespace СА
{
    class Program
    {
        static void Main(string[] args)
        {
            double f1x, f2x, x=0, x1, max=0, min =0, minmax = 1000, maxmin =-1000;
            int f1=2, f2=6;
            Console.WriteLine($" x   ---   f1x   ---   f2x   ---   max   ---   min\n");
            for ( x = 0; x <= 4; x = x + 0.04)
            {
                f1x = Math.Pow(2, x);
                f2x = 9 - Math.Pow(x, 2);

                if (f1x >= f1)
                {
                    if (f2x >= f2)
                    {
                        max = Math.Max(f1x / f1, f2x / f2);
                        min = Math.Min(f1x / f1, f2x / f2);

                        minmax = Math.Min(max, minmax);
                        maxmin = Math.Max(min, maxmin);

                        Console.WriteLine($" {Math.Round(x,5)} --- {Math.Round(f1x,5)} --- {Math.Round(f2x,5)} --- {Math.Round(max,5)} --- {Math.Round(min,5)}");
                    }
                }
            }
            Console.WriteLine($"\n minmax = {Math.Round(minmax,5)}\n maxmin = {Math.Round(maxmin,5)}");
            Console.WriteLine($"\n");
            Console.WriteLine($"\n");
            Console.WriteLine($"\nKornelyk Yura branch new");

        }
    }
}
