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

                if (n <= 0 || n > 2)
                {
                    Console.WriteLine("Invalid Entry!!");
                    Menu();
                    n = int.Parse(Console.ReadLine());

                }
                else
                if (n == 1)
                {
                    Console.WriteLine("Enter three numbers for triangle");
                   
                    int x = int.Parse(Console.ReadLine());
                    int y = int.Parse(Console.ReadLine());
                    int z = int.Parse(Console.ReadLine());


                    String val = TriangleSolver.Scan(x, y, z);
                    Console.WriteLine("Given Triangle is " + val);
                }
                else
                {
                    flag = false;
                }
            }

        }
    }
}
