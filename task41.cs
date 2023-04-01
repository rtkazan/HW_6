int[] InputArrayManually (int M) 
{
    int[] array = new int[M];
    for (int i = 0; i < M; i = i + 1)
    {
        Console.WriteLine($"Введите {i + 1} элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < M; i = i + 1)
    {
        if (i == M - 1) Console.Write($"{array[i]} -> ");
        else Console.Write($"{array[i]}, "); 
    }
    return array;
}

int PositiveNumbersCounter(int[] array) 
{
    int counter = 0;
    for (int i = 0; i < array.Length; i = i + 1)
    {
        if (array[i] > 0) 
        {
            counter = counter + 1;
        }
    }
    Console.Write(counter);
    return counter;
}

PositiveNumbersCounter(InputArrayManually(3));