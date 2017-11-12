using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int [] t;
            string [] s;
            for(int i = 0; i < n; i++)
            {
                s[n]  = Console.ReadLine();
                t[n]  = Console.ReadLine();
            }
            int ch = int.Parse(Console.ReadLine());
            if (ch == 1) {
                p1();
            }
            if (ch == 1)
            {
                p2();
            }
            if (ch == 1) {
                p3();
            }
            private void p1(void) {
                string h = Console.ReadLine();
                for (int i = 0; i < n; i++)
                {
                    if (h == s[i])
                    {
                        Console.WriteLine("{0}", t[i]);
                    }
                    else {
                        Console.WriteLine("student not found");
                    }
                }
                
            }
            private void p2(void) { 
                int max = t[0];
                for (int i= 0; i < n; i++) {
                    if (t[i] > max) {
                        max = t[i];
                        string mas = s[i];
                    }
                    Console.WriteLine("{0}",max);
                    Console.WriteLine("{0}", mas);
                }
                private void p3(void)
                {
                    string h = Console.ReadLine();
                    for (int i = 0; i < n; i++)
                    {
                        if (h == s[i])
                        {
                            Console.WriteLine("enter new nane");
                            string j = Console.ReadLine();
                            s[i] = j;
                        }
                        else
                        {
                            Console.WriteLine("student not found");
                        }
                    }

                }
                



                }
}
}
