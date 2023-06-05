using System;
using System.Linq;
using System.Text;

namespace Task9_2
{
    internal class Program
    {
        /// <summary>
        /// Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. 
        /// Створити масив розміру N елементів, заповнити його довільними цілими значеннями (розмір масиву задає користувач). 
        /// Вивести на екран: найбільше значення масиву, найменше значення масиву, загальну суму всіх елементів, 
        /// середнє арифметичне всіх елементів, вивести усі непарні значення. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            var size = GetUserSizeInput();
            var array = CreateArray(size);
            RandomFillArray(array);
            ConsoleWriteLineArrayElements(array);
         
            WriteMaxArrayElement(array);
            WriteMinArrayElement(array);
            WriteSumOfArrayElements(array);
            WriteAverageOfArrayElements(array);
            WriteUnevenArrayElements(array);
        }

        static int GetUserSizeInput()
        {
            Console.WriteLine("Введіть розмірність масиву: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        #region CreateArray
        static int[] CreateArray (int size) 
        {
            int[] array = new int[size];
            return array;
        }

        static int[] RandomFillArray(int[] array)
        {
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++) 
            {
                array[i] = rand.Next(0, 255);
            }
            return array;
        }

        static void ConsoleWriteLineArrayElements(int[] array)
        {
            for (int i = 0;i < array.Length;i++) 
            {
                Console.WriteLine(array[i]);
            }
        }
        #endregion

        #region Array Elements Logic
        static void WriteMaxArrayElement(int[] array)
        {
            Console.WriteLine("Найбільше значення масиву: " + array.Max()); 
        }

        static void WriteMinArrayElement(int[] array)
        {
            Console.WriteLine("Найменше значення масиву: " + array.Min());
        }
        static void WriteSumOfArrayElements(int[] array)
        {
            Console.WriteLine("Загальна сума всіх елементів: " + array.Sum());
        }
        static void WriteAverageOfArrayElements(int[] array)
        {
            Console.WriteLine("Середнє арифметичне всіх елементів: " + array.Average());
        }

        static void WriteUnevenArrayElements(int[] array)
        {
            Console.WriteLine("Непарні значення: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    Console.WriteLine(array[i]);
            }
        }
        #endregion
    }
}
