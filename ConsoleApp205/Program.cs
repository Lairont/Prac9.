using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp205
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.Определить, имеются ли в одномерном массиве случайных чисел элементы, значения которых кратны 11.Вывести такие значения.
            //int[] omas = new int[10];
            //Random rnd = new Random();
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = rnd.Next(0, 99);
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    if (omas[i] % 11 == 0)
            //    {
            //        Console.WriteLine(omas[i]);
            //    }
            //}
            //Console.ReadLine();

            //Задача 2.Найти сумму и количество положительных элементов в одномерном массиве с явной инициализацией.
            // int[] omas = new int[7] { 12, 1, -16, 4, 9, -33, 5 };

            // int count = 0;
            // int val = 0;
            //Array.Clear(omas, 2, 2);
            // for (int i = 0; i < omas.Length; i++)
            // {
            //     Console.WriteLine($"omas[{i}] = {omas[i]}");
            //     if (omas[i] > 0)
            //     {

            //         val += omas[i];
            //         count++;
            //     }
            // }
            // Console.WriteLine($"Сумма = {val}\nКоличество = {count}");
            // Console.ReadLine();





            //Задача 3.Вывести элементы одномерного массива, заполненного с клавиатуры ,в обратном порядке.
            //int[] omas = new int[7];
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    Console.Write($"omas[{i}] = ");
            //    omas[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Reverse(omas, 0, 7);
            //         //for (int i = omas.Length - 1; i >= 0; i--)
            //         //{
            //         //  Console.WriteLine(omas[i]);
            //         //}
            //foreach (var rev in omas)
            //{
            //    Console.WriteLine($"{rev} ");
            //}
            //Console.ReadLine();


        }
    }
}
