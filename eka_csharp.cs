/*
 * Тестовое задание для компании EKA
 * Задача №1
 */

using System;

namespace ConsoleApp1
{
    class Program
    {

        /**
         * ==========
         * Функция проверяет наличие нулей в срезе одномерного массива - от 0 до заданного m.
         * ==========
         * 
         * @param testArray -- проверяемый массив
         * @param m -- проверяемое количество элементов, взятое с головы массива
         * 
         * @return true, если присутствует 0.
         * 
         */
        static bool isZeroesPresent(int[] testArray, int m)
        {
            // Берём срез массива от нулевого до m-элемента,
            // преобразовываем его в строку, добавляем запятые в начало и конец
            // (чтобы искать строго ", 0," и не реагировать на нули в числах.

            string testString = ", " + String.Join(", ", testArray[0..m]) + ", ";
            return testString.Contains(", 0,");
        }


        static void Main(string[] args)
        {
            int[] testArray = { 1, 2, 0, 4, 5, 6, 7, 8, 9, 10 };
            int m = 5;
            bool isZeroPresent = isZeroesPresent(testArray, m);  // Собственно функция
           
            // Для того, чтобы вывести строго Yes или No, как требуется в условии задачи,
            // я всё-таки воспользуюсь ветвлением.
            if (isZeroPresent)
            {
                Console.WriteLine("Yes");
            }
            else 
            {
                Console.WriteLine("No");
            }
        }
    }
}
