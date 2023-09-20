// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Решение ВАРИАНТ 1

//System.Console.Write("Your first number: ");
//int a = Convert.ToInt32(Console.ReadLine());
//System.Console.Write("Your second number: ");
//int b = Convert.ToInt32(Console.ReadLine());
//if(a > b)
//{
//    System.Console.Write($"{a} > {b}");
//}
//else
//{
//    System.Console.Write($"{a} < {b}");
//}

// Решение ВАРИАНТ 2

System.Console.Write("Your first number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Your second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a > b)
{
    System.Console.Write($"большее число {a}, меньшее число {b}");
}
else
{
    System.Console.Write($"меньшее число {a}, большее число {b}");
}

