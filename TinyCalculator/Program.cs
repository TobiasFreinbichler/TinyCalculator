using System.Data;

Console.WriteLine("Tiny Calculator");
int firstNumber = 0;
Console.WriteLine("Ich mag programmieren");
firstNumber = GetNumbers(firstNumber, out int secondNumber);
int Rechung = GetRechnung();
Console.WriteLine($"{Rechung} and {firstNumber},{secondNumber} = {GetAnswer(Rechung, firstNumber, secondNumber)}");

static int GetRechnung()
{
    Console.Write("Wie möchtest du rechnen? (+ - * /):");
    string z = Console.ReadLine();
    if (z == "+") return 2;
    if (z == "-") return 3;
    if (z == "*") return 4;
    if (z == ":") return 5;
    return 2;
}

static int GetNumbers(int x, out int y)
{
    Console.Write("first Number: ");
    x = Convert.ToInt32(Console.ReadLine());

    Console.Write("second Number:");
    y = Convert.ToInt32(Console.ReadLine());

    return x;
}
static int GetAnswer(int R, int first, int second)
{
    int answer = 0;
    if (R == 2 && first != null && second != null) return answer = first + second;
    if (R == 3 && first != null && second != null) return answer = first - second;
    if (R == 4 && first != null && second != null) return answer = first * second;
    if (R == 5 && first != null && second != null) return answer = first * second;
    return 0;
}
Console.WriteLine(  "Nicht!");