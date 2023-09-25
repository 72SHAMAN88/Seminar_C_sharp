// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Решение ВАРИАНТ 1 (конкретное трехзначное число)

// void exampleMethod(int num)
// {
//     int dec = num / 10;
//         System.Console.WriteLine($"{num} -> {dec % 10}");
// }

// System.Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// exampleMethod(num);

// Решение ВАРИАНТ 2 (рандомное трехзначное число)

void exampleMethod(int num)
{
    int dec = num / 10;
    System.Console.WriteLine($"{num} -> {dec % 10}");
}

int num = new Random().Next(100, 1000);
exampleMethod(num);