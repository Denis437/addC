using JaggedArrayLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] intarray = new int[][]
            {
                new int[] { 1, 2, 3, 4 },
                new int[] { 4, 3, 2, 1 },
                new int[] { 3, 2, 6, 1 }
            };
            JaggedArrayInfo info = new JaggedArrayInfo(intarray);
            Console.WriteLine(info.Lowers);//вывести кол-во строк по убыванию
            Console.WriteLine(info.Uppers);//вывести кол-во строк по возрастанию
            Console.WriteLine(info.Ravnie);//вывести кол-во строк равных
            Console.WriteLine(info.Lost);//вывести кол-во строк не отсортированных

            Console.Read();
        }
    }
}
