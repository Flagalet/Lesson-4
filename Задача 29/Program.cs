// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
int [] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
            res[i] = int.Parse(nums[i]);
    }
    return res;
}
void Mass(int[] array)
{
     Console.Write($"{"["}");
    for(int i = 0; i < array.Length; i++)
    {
    Console.Write($"{array[i]}");
    if(i != array.Length - 1)
        {
            Console.Write($"{","}");
        }
    }
    Console.Write($"{"]"}");
}
Console.Clear();
Console.WriteLine("Введите массив");
string num = Console.ReadLine();
int[] numers = GetArrayFromString(num);
Mass(numers);