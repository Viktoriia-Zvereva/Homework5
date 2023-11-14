int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array, int minValue = -10, int maxValue = 10)
{
    maxValue ++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue, maxValue);
    }
}

void FillDoubleArray(double[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble();
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void PrintDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Task34()
{
    //Задайте массив заполненный случайными положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.
    Console.WriteLine("Задача 34");

    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 999);
    PrintArray(numbers);
    int count = 0;
    
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        count ++;
    }

Console.WriteLine($"Количество чётных чисел в массиве: {count}");
}

void Task36()
{
    //Задайте одномерный массив, заполненный случайными числами. Найдите сумму 
    //элементов с нечётными индексами.
    Console.WriteLine("Задача 36");

    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 0, 100);
    PrintArray(numbers);  
    int sum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += numbers[i];
            i ++;
        }
    }
    Console.WriteLine($"Сумма элементов с нечётными индексами равна {sum}");
}

void Task38()
{
    //Задайте массив вещественных чисел. Найдите разницу между максимальным 
    //и минимальным элементами массива.
    Console.WriteLine("Задача 38");

    int size = 10;
    double[] numbers = new double[size];
    FillDoubleArray(numbers);
    PrintDoubleArray(numbers);
    double min = numbers[0];
    double max = numbers[0];
    double result = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > numbers[0])
        {
            max = numbers[i];
            i ++;
        }
        if (numbers[i] < numbers[0])
        {
            min = numbers[i];
            i ++;
        }
    }
    result = max - min;
   
    Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами массива равна {result}");         
}

Console.Clear();
Console.WriteLine("34 - Задача 34\n36 - Задача 36\n38 - Задача 38");
int TaskNumber = Input("Введите номер задачи: ");

switch(TaskNumber)
{
    case 34:
        Task34();
        break;
    case 36:
        Task36();
        break;
    case 38:
        Task38();
        break;
    default:
        Console.WriteLine("Введен неверный номер задачи");
        break;
}
