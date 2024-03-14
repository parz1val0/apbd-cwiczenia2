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
static int GetMax(int[] numbers)
{
    int max = 0;
    foreach (var number in numbers)
    {
        if (max < number)
        {
            max = number;
        }
    }
    return max;
}


int[] numbers = { 1, 2, 3, 4 };
Console.WriteLine(GetMax(numbers));
double avg = GetAvarage(numbers);
