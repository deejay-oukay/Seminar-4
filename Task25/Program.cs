// Цикл, который принимает на вход два числа (A и B) и возводит число А в натуральную ступень B
// 3, 5 -> 243 (3 в степени 5)
// 2, 4 -> 16

int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MyPow(int number, int power)
{
    int result = number;
    for (int i = 1; i < power; i++)
        result *= number;
    return result;
}

int a = InputInt("Введите число A: ");
int b = InputInt("Введите число B: ");

Console.WriteLine($"{a} в степени {b} = {MyPow(a,b)}");