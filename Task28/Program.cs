// Программа, которая принимает на вход число N и выдаёт произведение чисел от 1 до N
// 4 -> 24
// 5 -> 120

int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Product(int n)
{
    int result = 1; //не 0, т.к. далее умножение нуля могло бы помешать получить что-то отлично от 0
    for (int i = 2; i <= n; i++) //здесь можно начать, как с 1 (условие задачи), так и с 2 (умножать на 1 особого смысле нет, а потеря производительности чуть-чуть имеется)
        result *= i;
    return result;
}

Console.WriteLine($"Произведение чисел от 1 до N: {Product(InputInt("Введите число N: "))}");
