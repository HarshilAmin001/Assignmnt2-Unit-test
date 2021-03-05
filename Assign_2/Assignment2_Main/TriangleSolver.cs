using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Main
{
    public class TriangleSolver
    {

        public static string Scan(int h1, int h2, int h3)
        {
            String triangleType = "Not Recognized";

            if (h1 < 1 || h2 < 1 || h3 < 1)
            {
                triangleType = "Not Recognized";
                //Console.WriteLine("Given inputs cannot form a triangle");
            }
            else
            {
                if (((h1 + h2) > h3) && (h2 + h3) > h1 && (h1 + h3) > h2)
                {

                    if (h1 == h2 && h2 == h3)
                    {
                        triangleType = "Equilateral";
                    }
                    else if (h1 == h2 || h2 == h3 || h3 == h1)
                    {
                        triangleType = "Isosceles";
                    }
                    else
                    {
                        triangleType = "Scalene";
                    }
                }
                else
                {
                    triangleType = "Given inputs cannot form a triangle";
                }
            }
            return triangleType;
        }

    
    }
}
