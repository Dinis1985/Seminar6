// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Пример:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] num = new double[2, 2];
double[] point = new double[2];

void Numbers()
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        Console.WriteLine($"Введите значение для {i + 1} уравнения y = k * x + b:");
        for (int j = 0; j < num.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите  k: ");
            else Console.Write($"Введите  b: ");
            num[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Answer(double[,] num)
{
    point[0] = (num[1, 1] - num[0, 1]) / (num[0, 0] - num[1, 0]);
    point[1] = point[0] * num[0, 0] + num[0, 1];
    return point;
}

void Print(double[,] num)
{
    if (num[0, 0] == num[1, 0] && num[0, 1] != num[1, 1])
    {
        Console.WriteLine("Прямые параллельные");
    }
    else if (num[0, 0] == num[1, 0] && num[0, 1] == num[1, 1])
    {
        Console.WriteLine("Прямые одинаковые");
    }
    else
    {
        Answer(num);
        Console.WriteLine($"Точка пересечения двух прямых -> ({point[0]}, {point[1]})");
    }
}

Numbers();
Print(num);