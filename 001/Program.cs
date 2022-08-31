//Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}
int[] CreateArray(int length)
{
    int[] answer = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < answer.Length; i++)
    {
        answer[i] = rnd.Next(-100, 100);
    }
    return answer;
}
void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}
int[] ReversArr(int[] array)
{
for (int i = 0; i < array.Length/2; i++)
{
    int tmp = array[i];
    array[i] = array[array.Length -1 -i ];
    array[array.Length -1 -i] = tmp;
}    
    return array;
}
int[]array = CreateArray(6);
PrintArray(array);
System.Console.WriteLine();
PrintArray(ReversArr(array));

