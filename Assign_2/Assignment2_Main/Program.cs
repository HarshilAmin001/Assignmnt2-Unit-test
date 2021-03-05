using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Main
{
    class Program
    {
        static void Main(string[] args)
        {
            void Menu()
            {
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
            }


            var flag = true;
            while (flag)
            {
                Menu();
                int n = int.Parse(Console.ReadLine());

                if (n <= 0 || n > 2 )
                {
                    Console.WriteLine("Invalid option!!");
                    Menu();
                    n = int.Parse(Console.ReadLine());

                }
                else
                if (n == 1)
                {
                    Console.WriteLine("Enter three sides values for triangle");

                    Console.WriteLine("Enter Side1");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Side2");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Side3");
                    int z = int.Parse(Console.ReadLine());


                    String val = TriangleSolver.Scan(x, y, z);
                    Console.WriteLine("Given triangle is " + val);
                }
                else
                {
                    flag = false;
                }
            }

        }
    }
}
