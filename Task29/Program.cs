// Программа, которая задаёт массив из 8 элементов и выводит их на экран
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Примеры в условии - из 5 и из 3 элементов, а не из 8, но надеюсь, что правильно понял условия и вывожу 8 элементов

int InputInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
        Console.Write((i > 0 ? ", ":"")+arr[i]);
    Console.Write("]");
}

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
    array[i] = InputInt($"Введите значение для {i}-ого элемента массива: ");
PrintArray(array);
