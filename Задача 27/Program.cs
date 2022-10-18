// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum( int num1)
{
    int a = num1;
    int b = 0;
    while (a > 0)
    {
        b = b + a % 10;
        a = a /10; 
    }
 return b;
}

Console.Clear();
Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sum(A));