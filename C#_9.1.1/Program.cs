using System;

namespace C__9._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
if(start == end)
{
return start.ToString();
}
return start+ " "+ PrintNumbers(start-1,end);
}

System.Console.WriteLine(PrintNumbers(n, 1));
        }
    }
}
