// Программа, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А
// 7 -> 28
// 4 -> 10
// 8 -> 36

int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumFrom1ToA(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
        sum += i;
    return sum;
}

Console.WriteLine($"Сумма чисел от 1 до А: {SumFrom1ToA(InputInt("Введите число А: "))}");
