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
    string str = Convert.ToString(number);
    return str.Length;
}

Console.WriteLine($"Количество цифр: {DigitsCount(InputInt("Введите число: "))}");