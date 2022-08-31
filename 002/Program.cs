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

void triangle(int a, int b, int c)
{
    if ((a + b <= c) || (a + c <= b) || (b + c <= a))
    {
        Console.WriteLine($"Triangle with size {a} , {b} , {c} not reaL"); 
    }
    else Console.WriteLine($"Triangle with size {a} , {b} , {c}  reaL");
    
}

int a = Prompt("Enter size a ");
int b = Prompt("Enter size b ");
int c = Prompt("Enter size c ");

triangle(a, b, c);

