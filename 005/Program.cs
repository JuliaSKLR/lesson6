// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

int[] array = { 1, 2, 3, 4, 5 };
int[] array2 = array;
array[0] = 10;
PrintArray(array);
PrintArray(array2);

int[] CopyArray(int[] array)
{

    int[] answer = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        answer[i] = array[i];
    }
    return answer;
}
int[] array3 = CopyArray(array);
array[1] = 8;
PrintArray(array3);
PrintArray(array);
PrintArray(array2);
PrintArray(array3);
