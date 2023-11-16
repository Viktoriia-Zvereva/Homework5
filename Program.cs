int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Task41()
{
    //Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0
    // ввёл пользователь.
    Console.WriteLine("Задача 41");

    int countNumbers = Input("Введите количество чисел: ");
    int countPositiveNumbers = 0;

    while (countNumbers > 0)
    {
        int number = Input("Введите число: ");
        if (number > 0) countPositiveNumbers ++;
        countNumbers --;
    }
    Console.WriteLine($"Чисел больше нуля: {countPositiveNumbers}");
}

void Task43()
{
    //Напишите программу, которая найдёт точку пересечения двух прямых, 
    //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
    //значения b1, k1, b2 и k2 задаются пользователем.
    //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    Console.WriteLine("Задача 43");

    int b1 = Input("Введите b1: ");
    int k1 = Input("Введите k1: ");
    int b2 = Input("Введите b2: ");
    int k2 = Input("Введите k2: ");
    
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.Write($"Точка пересечения двух прямых: ({x},{y})]");
}

Console.Clear();
Console.WriteLine("41 - Задача 41\n43 - Задача 43");
int TaskNumber = Input("Введите номер задачи: ");

switch (TaskNumber)
{
    case 41:
        Task41();
        break;
    case 43:
        Task43();
        break;
    default:
        Console.WriteLine("Введен неверный номер задачи");
        break;
}