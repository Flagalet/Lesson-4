//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Step ( int num, int step)
{
    int a = num;
    for(int i = 1; i != step; i ++)
    {
        a *= num;       
    }
    return a;
    
}

Console.Clear();
Console.WriteLine("Введите возводимое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите степень числа: ");
int B = int.Parse(Console.ReadLine()!);
int result = Step(A, B);
Console.Write(result);
