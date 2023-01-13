// Программа, которая принимает на вход число и выдаёт количество цифр в числе
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int DigitsCount(int number)
{
    int count = 0;
    while (number > 0)
    {
        count++;
        number /= 10;
    }
    return count;
}

Console.WriteLine($"Количество цифр: {DigitsCount(InputInt("Введите число: "))}");