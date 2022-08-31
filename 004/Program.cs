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

int[] CalcFibo(int numberFibo)
{
    int[] array = new int[numberFibo];
    array[0] = 0;
    array[1] = 1;
    int i = 2;
    while (i < numberFibo)
    {
        array[i] = array[i - 2] + array[i - 1];
        i++;
    }
    return array;

}
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

int[] array = CalcFibo(Prompt("ENter your number "));
PrintArray(array);
