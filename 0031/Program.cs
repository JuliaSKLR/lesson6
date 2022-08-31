///Задача 2: Напишите программу, которая будет 
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
int[] ToBinary(int number, int lght)
{
    int[] array = new int[lght];
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
int BinLenght(int number, int lght)
{
    lght = 0;
    if(number % 2 == 0)
    {
        
        lght++;
        BinLenght(number/2, lght);
        
    }
    else
    {
        BinLenght(number-1, lght);
    }
    return lght;
}

int number = Prompt("Enter number ");
int d = 0;
int []array = ToBinary(number, BinLenght(number, d));
PrintArray(array);
