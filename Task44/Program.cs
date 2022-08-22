// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Вариант 1:
Console.WriteLine("Введите положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 0) Console.WriteLine("0");
if (n == 1) Console.WriteLine("1");
Console.Write("0 1 ");
int fibonacci = 2;
int number1 = 0;
int number2 = 1;
for (int i = 2; i < n; i++)
{

    fibonacci = number1 + number2;
    number1 = number2;
    number2 = fibonacci;
    Console.Write($"{fibonacci} ");
}

// Вариант 2:
// Console.Write("Введите целое положительное число: ");
// int number = int.Parse(Console.ReadLine());

// void ShowFibonacci(int num)
// {
//     int num1 = 0;
//     int num2 = 1;
    
//     Console.Write(num1+" "+num2+" ");

//     for (int i = 2; i < num; i++)
//     {
//         int temp = num1 + num2;
//         num1 = num2;
//         num2 = temp;
//         Console.Write(temp+" ");    
//     }
//     Console.WriteLine();
// }

// ShowFibonacci(number);

