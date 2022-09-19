/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int GetNumber()
{
    Console.WriteLine("Введите  число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int num1 = GetNumber();
if (num1 < 100)
    Console.WriteLine($"У числа {num1} нет третьей цифры.");
else
{
    while (num1 > 1000)
        num1 /= 10;
}
Console.WriteLine(num1 % 10);