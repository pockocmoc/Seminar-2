/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

int GetNumber()
{
    Console.Write("Введите  цифру, обозначающую день недели: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int numDayWeek = GetNumber();

if (numDayWeek == 6 || numDayWeek == 7)
    Console.WriteLine($"{numDayWeek} день недели, является выходным.");

else if (numDayWeek >= 1 && numDayWeek <= 5)
    Console.WriteLine($"{numDayWeek} день недели, это будний день.");
else
    Console.WriteLine($"Ошибка!!! {numDayWeek} дня недели, не существует.");

