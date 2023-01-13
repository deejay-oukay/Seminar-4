// Цикл, который принимает на вход два числа (A и B) и возводит число А в натуральную ступень B
// 3, 5 -> 243 (3 в степени 5)
// 2, 4 -> 16

int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Не уверен, что правильно понял, для чего здесь нужен цикл
// Пусть в цикле do-while запрашиваются числа до тех пор, пока хотя бы одно из них не будет равно 0

void Cicle()
{
    int a = 0, b = 0;

    do
    {
        a = InputInt("Введите число A: ");
        b = InputInt("Введите число B: ");
        Console.WriteLine($"{a} в степени {b} = {Math.Pow(a,b)}");
        Console.WriteLine("Повторим. Чтобы остановиться введите 0 для A или для B...");
    }
    while ((a != 0) && (b != 0));
}

Cicle();
