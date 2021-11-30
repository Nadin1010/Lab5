using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray;
            myArray = new int[5, 5]
    {
        {1,0,1,0,1},
        {0,1,0,1,0},
        {1,0,1,0,1},
        {0,1,0,1,0},
        {1,0,1,0,1},
    };
            int height = myArray.GetLength(0);
            int width = myArray.GetLength(1);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(myArray[x, y] + "\t");
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}




        