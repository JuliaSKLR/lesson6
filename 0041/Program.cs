//с рекурсией
//Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8


int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

void CalcFibo(int numberFibo)
{

    int f1 = 0;
    int f2 = 1;
    int f;
    int i = 2;
    while (i < numberFibo)
    {
        f = f1 + f2;
        f1 = f2;
        f2 = f;
        System.Console.WriteLine(f);
        i++;
    }

}
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

CalcFibo(Prompt("ENter your number "));

