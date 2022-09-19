/*
Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetNumber()
{
    Console.WriteLine("Введите трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int num1 = GetNumber();
if (num1 > 99 && num1 < 1000)
    Console.WriteLine((num1 % 100) / 10);
else
    Console.WriteLine("Число не является трёхзначным.");
