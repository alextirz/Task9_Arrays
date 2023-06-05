using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_6
{
    internal class Program
    {

        /// <summary>
        /// Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication.
        /// Створіть масив розмірністю 10 елементів, виведіть на екран усі елементи масиву у зворотному порядку.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[] mass = new int[10]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            for (int i = mass.Length; i > 0; i--) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
