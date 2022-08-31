//Задача 2: Напишите программу, которая будет 
//преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}
int[] ToBinary(int number)
{
    int[] array = new int[];
    int i = array.Length - 1;
    while (number > 0)
    {
        int bit = number % 2;
        number = number / 2;
        array[i] = bit;
        i--;
    }
    return array;
}
int []array = ToBinary(Prompt("Enter number "));
PrintArray(array);
