// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Решение ВАРИАНТ 1

//System.Console.Write("Input number: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int a = 2;
//if(n > 1)
//{
//    while(a <= n)
//    {
//        System.Console.Write(a + " ");
//        a = a + 2;
//    }
//}

// Решение ВАРИАНТ 2

System.Console.Write("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
for(i = 1; i <= n; i++)
{
    if(i % 2 == 0)
    System.Console.Write(i + " ");
}

// Изменение названия главной папки