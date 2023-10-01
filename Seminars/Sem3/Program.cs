// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// int FindQaurter(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     return 0;
// }

// System.Console.Write("Input x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindQaurter(x, y));

// Напишите программу которая на принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до (N).
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4

// void QuadTable(int n)
// {
//     int current = 1;
//     System.Console.Write(n + " -> ");
//     while (current < n)
//     {
//         System.Console.Write(current * current + ", ");
//         current++;
//     }
//     System.Console.Write(current * current);
// }

// System.Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// QuadTable(n);

// Напишите программу которая, по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void Coord_quarter(int qaurter)
// {
//     if (qaurter == 1)
//     {
//         System.Console.WriteLine("x > 0 и y > 0");
//     }
//     else if (qaurter == 2)
//     {
//         System.Console.WriteLine("x < 0 и y > 0");
//     }
//     else if (qaurter == 3)
//     {
//         System.Console.WriteLine("x < 0 и y < 0");
//     }
//     else if (qaurter == 4)
//     {
//         System.Console.WriteLine("x > 0 и y < 0");
//     }
//     else
//     {
//         System.Console.WriteLine("Error!");
//     }
// }

// System.Console.Write("Input qaurter: ");
// int q = Convert.ToInt32(Console.ReadLine());
// Coord_quarter(q);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// А(3, 6) В(2, 1) -> 5,09
// А(7, -5) В(1, -1) -> 7,21

double Distance(double xa, double xb, double ya, double yb)
{
    return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
}

System.Console.WriteLine("Введите знанчение координат: ");
System.Console.Write("Ведите координату X точки A: ");
double xa = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Ведите координату X точки B: ");
double xb = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Ведите координату Y точки A: ");
double ya = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Ведите координату Y точки B: ");
double yb = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine($"A({xa}, {ya}) B({xb}, {yb}) -> {Math.Round(Distance(xa, xb, ya, yb), 2)}");