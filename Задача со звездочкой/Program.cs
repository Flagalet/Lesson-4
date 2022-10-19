// Задача “со звездочкой”: Напишите функцию, которая принимает одно число - высоту елочки и рисует ее в консоли звездочками.
void Mass( int num)
{
    string sap = "*";
    string space = " ";
    string sup = String.Empty;
    int n = num;
    for(int j = 0; j < num; j++)
    {
    
        for(int i = 0; i < n; i++)
        {
            Console.Write(space);
        }
    Console.Write(sup);
    sup = sup + sap;
    Console.Write(sup);
    n--;
    Console.WriteLine();
    }

}
Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Mass(n);



