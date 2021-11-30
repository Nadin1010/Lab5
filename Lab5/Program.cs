using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                {
                    int[] arrays = new int[] {  2, 4, 5, 7, 10, 11, 12 };
                    int arraysSum = 0;

                    for (int i = 0; i < arrays.Length; i++)
                        arraysSum += arrays[i];

                    Console.WriteLine("среднее арефмитическое: {0}", arraysSum / arrays.Length);
                    Console.ReadLine();
                }
            }
        }
    }
}
