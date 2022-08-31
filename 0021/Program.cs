//метод bool true false
//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
//

int Prompt(string message)
{
    System.Console.Write(message);
    string readValue = Console.ReadLine();
    int result = int.Parse(readValue);
    return result;
}

bool triangle(int a, int b, int c)
{
    if ((a + b > c) && (a + c > b) && (b + c > a))
    {
        return true;
    }
    return false;
}

int a = Prompt("Enter size a ");
int b = Prompt("Enter size b ");
int c = Prompt("Enter size c ");

if (triangle(a, b, c))
{

    Console.WriteLine($"Triangle with size {a} , {b} , {c} reaL");
}
else
{
    Console.WriteLine($"Triangle with size {a} , {b} , {c} not reaL");
}