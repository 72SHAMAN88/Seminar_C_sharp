// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void DaysWeeks(int dayNum)
{
    if (dayNum >= 6 && dayNum < 8)
    {
        System.Console.Write("День недели является выходным");
    }
    else if (dayNum >= 1 && dayNum < 6)
    {
        System.Console.Write("День недели не является выходным");
    }
    else
    {
        System.Console.Write("Такого дня недели не существует");
    }
}


System.Console.Write("Введите цифру обозначающую день недели: ");
int dayNum = Convert.ToInt32(Console.ReadLine());
DaysWeeks(dayNum);