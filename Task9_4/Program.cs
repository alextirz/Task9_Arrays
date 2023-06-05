using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task9_4
{
    /// <summary>
    /// Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. 
    /// Потрібно: 
    /// Створити метод, який виконуватиме збільшення довжини масиву переданого як аргумент, на 1 елемент. 
    /// Елементи масиву повинні зберегти своє значення та порядок індексів. 
    /// 
    /// Cтворіть метод, який приймає два аргументи, перший аргумент типу int [ ] array, другий аргумент типу int value. 
    /// У тілі методу реалізуйте можливість додавання другого аргументу методу до масиву за індексом – 0, 
    /// при цьому довжина нового масиву повинна збільшитися на 1 елемент, 
    /// а елементи одержуваного масиву як перший аргумент мають скопіюватися в новий масив починаючи з індексу - 1. 
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("Start array: ");
            WriteArrayElements(array);

            var increasedArray = IncreaseArray(array);
            Console.WriteLine("Increased array: ");
            WriteArrayElements(increasedArray);

            Console.WriteLine("Changed array: ");
            var changedArray = AddValueToArray(array, 177);
            WriteArrayElements(changedArray);
        }

        static int[] IncreaseArray(int[] array)
        {
            int[] increasedArray = new int[array.Length + 1];
            Array.Copy(array, increasedArray, array.Length);

            return increasedArray;
        }

        //alternative solution
        static int[] IncreaseArray2(int[] array)
        {
            int[] increasedArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                increasedArray[i] = array[i];
            }

            return increasedArray;

        }

        static int[] AddValueToArray(int[] array, int value)
        {
            int[] changedArray = new int[array.Length + 1];
            changedArray[0] = value;

            for (int i = 0; i < array.Length; i++)
            {
                changedArray[i + 1] = array[i];
            }
           return changedArray;
        }

        static void WriteArrayElements(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
