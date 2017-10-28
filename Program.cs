using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int[] y;
            int ele = 0;
            string z = "";
            string[] h = { "one hundred", "two hundre", "three hundre", "four hundred", "fivehundred", "six hundred", "sevenhundred", "eight hundred", "nine hundred" };
            string[] t = { "ten", "twenty", "thrty", "fourty", "fivty", "sixty", "seventy", "eighty", "ninty" };
            string[] o = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] e = { "eleven", "twwelve", "therteen", "fourteen", "fivteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            int[] n = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            
            for (int a = 0; a < 3; a = a + 1)
            {
               y[ a ] = x % 10;
                x = (x - y[a]) / 10;

            }

            for (int b = 0; b < 10; b = b + 1)
            {
                if (y[2] == n[b])
                {
                    z = z + h[b];
                    break;
                }
                if (y[2] == 0)
                {

                    break;
                }

            }
            for (int b = 0; b < 10; b = b + 1)
            {
                if (y[1] == 1)
                {
                    ele = ele + 1;
                    break;
                }
                if (y[1] == n[b])
                {
                    z = z + t[b];
                    break;
                }
                if (y[1] == 0)
                {

                    break;
                }


            }
            for (int b = 0; b < 10; b = b + 1)
            {
                if (y[1] == 1)
                {

                    break;
                }

                if (y[0] == n[b])
                {
                    z = z + o[b];
                    break;
                }
                if (y[0] == 0)
                {

                    break;
                }


            }
            if (y[1] == 1)
            {
                for (int b = 0; b < 10; b = b + 1)
                {


                    if (y[0] == n[b])
                    {
                        z = z + e[b];
                        break;
                    }
                    if (y[0] == 0)
                    {

                        break;
                    }
                }

            }

        }
    }
}

