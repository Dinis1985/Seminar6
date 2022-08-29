// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример:
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write($"Введите количество чисел: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] arrayNumb = new int[m];

void Numb(int m)
{
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        arrayNumb[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int PosNumb(int[] arrayNumb)
{
    int count = 0;
    for (int i = 0; i < arrayNumb.Length; i++)
    {
        if (arrayNumb[i] > 0) count += 1;
    }
    return count;
}

Numb(m);
Console.WriteLine($"Вы ввели {PosNumb(arrayNumb)} числа больше 0");