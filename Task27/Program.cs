// Программа, которая принимает на вход число и выдаёт сумму цифр в числе
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigits(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

Console.WriteLine($"Сумма цифр: {SumOfDigits(InputInt("Введите число: "))}");