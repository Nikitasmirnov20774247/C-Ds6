Console.Write("Введите размер массива - ");
int size = Convert.ToInt32(Console.ReadLine());

if (size < 2)
{
    Console.Write("!! Размер массива не может быть меньше двух элементов !!");
    return;
}
int[] numbers = new int[size];

for(int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().Next(1,10);
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

Console.Write("Произведение пар чисел в одномерном массиве = ");

int j = numbers.Length - 1;
for (int i = 0; i < (numbers.Length + 1) / 2; i++)
{
    if (i == j) 
    {
        Console.Write($"{numbers[i]}");
        return;
    }
    Console.Write(numbers[i] * numbers[j]); j--;
    if (i != j) Console.Write(", ");
}