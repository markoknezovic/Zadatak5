using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 33; a++)
            {
                for (int b = 2; b <= 34; b++)
                {
                    for (int c = 3; c <= 35; c++)
                    {
                        for (int d = 4; d <= 36; d++)
                        {
                            for (int e = 5; e <= 37; e++)
                            {
                                for (int f = 6; f <= 38; f++)
                                {
                                    for (int g = 7; g <= 39; g++)
                                    {
                                        Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e + " " + f + " " + g);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
