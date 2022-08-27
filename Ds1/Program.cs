Console.WriteLine("Создан массив из 5 чисел");
int size = 5;
int[] numbers = new int[size];
for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(1,200);
}

void WriteArray(int[] numbers)
{
    Console.Write("[");
    int i = 0;
    int count = numbers.Length;

    while (i < count)
    {
        Console.Write(numbers[i]); i++;
        if (i < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Результат формирования массива: ");
WriteArray(numbers);

int count = 0;
for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 10 && numbers[i] < 99) count++;
}

Console.Write($"Cумма элементов с позициями от 10 до 99: {count}");