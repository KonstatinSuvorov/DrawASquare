using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawASquare
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.Write("Введите символ: ");
            char s = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите количество символов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write(s + " ");
                }
            }
            Console.ReadLine();
        }       
    }
}
