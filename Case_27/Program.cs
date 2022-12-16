/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.Write($"Сумма цифр числа {number} равна ");

while (number > 0)
{
    int allsum = number % 10;
    sum += allsum;
    number /= 10;
}

Console.WriteLine($"{sum}");

/*

// рандом
int number = new Random().Next(1, 100000);

int sum = 0;
Console.Write($"Сумма цифр числа {number} равна ");

while (number > 0)
{
    int allsum = number % 10;
    sum += allsum;
    number /= 10;
}

Console.WriteLine($"{sum}");
*/


