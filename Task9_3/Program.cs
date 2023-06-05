using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task9_3
{
    /// <summary>
    /// 
    ///Використовуючи Visual Studio, створіть проект за шаблоном ConsoleApplication. Потрібно:
    ///1) Створити метод MyReverse(int[] array), 
    ///який приймає як аргумент масив цілих чисел і повертає інвертований масив(елементи масиву у зворотному порядку).
    ///2) Створіть метод int[] SubArray(int[] array, int index, int count). 
    ///Метод повертає частину отриманого як аргумент масиву, починаючи з позиції зазначеної в аргументі index, розмірністю, 
    ///яка відповідає значенню аргументу count.
    ///Якщо аргумент count містить значення більше, ніж кількість елементів, які входять до частини вихідного масиву
    ///(від зазначеного індексу index, до індексу останнього елемента), то при формуванні нового масиву розмірністю в count,
    ///заповніть одиницями ті елементи, які не були скопійовані з вихідного масиву.
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 12, 5, -7, 2, 3 };
            Console.WriteLine("Original array: ");
            WriteArrayElements(array);

            int[] reversed = MyReverse2(array);
            Console.WriteLine("Reversed array: ");
            WriteArrayElements(reversed);

            int[] subArray = SubArray(array, 3, 5);
            Console.WriteLine("SubArray: ");
            WriteArrayElements(subArray);

        }

        //simple solution
        static void MyReverse(int[] array)
        {
            Array.Reverse(array);
        }

        //alternative solution
        static int[] MyReverse2(int[] array)
        {
            int[] reversed = new int[array.Length];
            for (int j = 0; j < reversed.Length; j++)
            {
                reversed[j] = array[array.Length - 1 - j];
            }
            return reversed;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] subArray = new int[count];

            int remainingLength = array.Length - index;
            Array.Copy(array, index, subArray, 0, remainingLength);
            if (remainingLength < count)
            {
                for (int i = remainingLength; i < count; i++)
                {
                    subArray[i] = 1;
                }
            }
            return subArray;
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
