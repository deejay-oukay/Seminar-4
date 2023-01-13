// Программа, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке
// [1,0,1,1,0,1,0,0]

void PrintArray(int[] arr)
{
    Console.WriteLine($"[{String.Join(",",arr)}]");
}

int[] array = new int[8];

Random rnd = new Random();

for (int i = 0; i < array.Length; i++)
    array[i] = rnd.Next(2);

PrintArray(array);