// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Решение ВАРИНТ 1

//System.Console.Write("Your first number: ");
//int a = Convert.ToInt32(Console.ReadLine());
//System.Console.Write("Your second number: ");
//int b = Convert.ToInt32(Console.ReadLine());
//System.Console.Write("Your third number: ");
//int c = Convert.ToInt32(Console.ReadLine());
//if((a > b) && (a > c))
//{
//    System.Console.Write($"максимальное число {a}");
//}
//else
//     if(b > c)
//{
//    System.Console.Write($"максимальное число {b}");
//}
//     else       
//{
//    System.Console.Write($"максимальное число {c}");
//}

// Решение ВАРИАНТ 2

System.Console.Write("Your first number: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Your second number: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Your third number: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if(a > max)
{
    max = a;
}
if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}
System.Console.Write($"максимальное число {max}");

// Изменение названия главной папки