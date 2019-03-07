using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod3
{
    class Program
    {
        static void Main(string[] args)
        {
            task3();
        }
        public static void task1()
        {
            //•	Напечатать весь массив целых чисел
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                Console.Write(arr[i]);
            }
        }
        public static void task2()
        {
            //•	Найти индекс максимального значения в массиве
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            Console.WriteLine(arr.Max());
        }
        public static void task3()
        {
            //•	Найти индекс максимального четного значения в массиве
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }
            
        }
    }
}
