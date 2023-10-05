﻿// Задача № 1
// Внутри класса Answer напишите метод IsPalindrome, 
// который принимает на вход пятизначное число number и проверяет, является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, в противном случае - вывести Число не пятизначное и 
// False в следующей строке.
// Для остальных чисел вернуть True или False.

// 14212 -> False
// 12821 -> True
// 234322 -> Число не пятизначное
// False

using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
      // Введите свое решение ниже
        int num1 = number / 10000;
        int num2 = number / 1000 % 10;
        int rev1 = number % 10;
        int rev2 = number / 10 % 10
        int nul = number / 100000;
        if(number > 9999 && number < 100000)
        {
            return false
        }
        else if (num == rev1 && num2 == rev2)
        {
            return true;
        }
        else
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }
    }
  
  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) 
    {
        int number;

        if (args.Length >= 1) 
        {
            number = int.Parse(args[0]);
        } 
        else 
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }
        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}

// Задача № 2 
// Внутри класса Answer напишите метод DistanceBetweenPoints, 
// который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел,
// и возвращает расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using System;

public class Answer
{
    private static double Length(int[] pointA, int[] pointB)
    {
      // Введите свое решение ниже
        int A = pointB[0] - pointA[0];
        int B = pointB[1] - pointA[1];
        int C = pointB[2] - pointA[2];
        double length = Math.Sqrt(A * A + B * B + C * C);
        return length;

    }

  // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args) {
        int x1, x2, x3, y1, y2, y3;

        if (args.Length >= 6) {
            x1 = int.Parse(args[0]);
            x2 = int.Parse(args[1]);
            x3 = int.Parse(args[2]);
            y1 = int.Parse(args[3]);
            y2 = int.Parse(args[4]);
            y3 = int.Parse(args[5]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            x1 = 3;
            x2 = 6;
            x3 = 8;
            y1 = 2;
            y2 = 1;
            y3 = -7;
        }

        // Не удаляйте строки ниже
        double result = Length(new int[]{x1, x2, x3}, new int[]{y1, y2, y3});
        Console.WriteLine($"{result:F2}");
    }
}

// Задача № 3

// Внутри класса Answer напишите метод ShowCube, который принимает на вход число (N) 
// и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.

// N = 3 
// 1
// 8
// 27

// N = 5
// 1
// 8
// 27
// 64
// 125


using System;

public class Answer
{
   static void ShowCube(int N)
    {
      // Введите свое решение ниже
       for (int i = 1; i <= N; i++)
       {
         Console.WriteLine($"{i * i * i}");
       } 
    }

  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int N;

        if (args.Length >= 1) {
            N = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            N = 6;
        }

        // Не удаляйте строки ниже
        ShowCube(N);
    }
}