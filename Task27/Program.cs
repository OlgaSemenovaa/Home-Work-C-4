// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;

do{
    sum = sum + a % 10;
    a = a / 10;
}
while (a>0);
Console.WriteLine($"Сумма цифр в числе = {sum}");

