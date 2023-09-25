// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Решение ВАРИАНТ 1

// void ThirdDigit(int num)
// {
//     while (num > 999)
//     {
//         num = num / 10;
//     }
//     if (num >= 100 && num < 1000)
//     {
//         int ed = num % 10;
//         System.Console.WriteLine($"третья цифра -> {ed}");
//     }
//     else
//     {
//         System.Console.WriteLine("третьей цифры нет");
//     }
// }

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// ThirdDigit(num);

// Решение ВАРИАНТ 2

void ThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    if (num >= 100 && num < 1000)
    {
        int ed = num % 10;
        System.Console.WriteLine($"третья цифра -> {ed}");
    }
    else
    {
        System.Console.WriteLine("третьей цифры нет");
    }
}

int num = new Random().Next(10, Int32.MaxValue);
System.Console.WriteLine(num);
ThirdDigit(num);