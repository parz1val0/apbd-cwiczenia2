// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Pierwsza Zmiana");
Console.WriteLine("Druga zmiania");
Console.WriteLine("3 zmiania");


static double GetAvarage(int[] numbers)
{
    int sum = 0;
    foreach (var number in numbers)
    {
        sum += number;
    }
    return (double) sum/numbers.Length;
}


int[] numbers = { 1, 2, 3, 4 };
double avg = GetAvarage(numbers);
