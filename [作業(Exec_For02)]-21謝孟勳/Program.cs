using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_For02___21謝孟勳
{
    //等腰星形三角形
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= (i-1)*2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
