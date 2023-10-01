// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Вариант 1

// int DigitCount(int num)
// {
//     int count = 1;
//     for(int i = 0; num > 10; i++)
//     {
//         num /= 10;
//         count++;
//     }
//     return count;
// }

// System.Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DigitCount(num));

// Вариант 2

// int DigitCount(int num)
// {
//     int count = 0;
//     for(int i = 1; num > 0; i++)
//     {
//         num /= 10;
//         count = i;
//     }
//     return count;
// }

// System.Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DigitCount(num));

// Вариант 3 с отрицательными числами

// int DigitCount(int num)
// {
//     int count = 0;
//     for(int i = 1; Math.Abs(num) > 0; i++)
//     {
//         num /= 10;
//         count = i;
//     }
//     return count;
// }

// System.Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DigitCount(num));

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Вариант для массива любого размера

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input min value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input max value: ");
// int max = Convert.ToInt32(Console.ReadLine());
// PrintArray(CreateRandomArray(size, min, max));

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int FindSum(int a)
// {
//     int sum = 0;
//     for (int i = 0; i <= a; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// System.Console.Write("Input A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write($"{a} -> {FindSum(a)}");

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4  -> 24
// 5  -> 120

int FindFactorial(int n)
{
    int fact = 1;
    for (int i = 1; i <= n; i++)
    {
        fact *= i;
    }
    return fact;
}

System.Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"{n} -> {FindFactorial(n)}");
