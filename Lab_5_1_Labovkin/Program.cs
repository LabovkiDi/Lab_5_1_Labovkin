using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_1_Labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int[] array = new int[n];

            Console.WriteLine("Введите заданное количесвто чисел");
            float sum = 0; /*используем тип с плавающей запятой*/
            for (int i = 0; i <= n - 1; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }
            Console.Write("Среднее арифметическое = {0:f3}", sum / n);
            Console.WriteLine();
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
