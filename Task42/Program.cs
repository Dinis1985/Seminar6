// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

// Вариант 1:
Console.WriteLine("Введите целое положительное число: ");
int num = int.Parse(Console.ReadLine());

int result = 0;
int mult = 1;
while(num > 0)
{
    result += num % 2 * mult;
    num = num / 2;
    mult *= 10;
}

Console.WriteLine(result);


// Вариан 2--:
// Console.WriteLine("Введите целое число: ");
// int decimalNumber = Convert.ToInt32(Console.ReadLine());
// int temp = decimalNumber;
// int count = 0;


// int[] binaryNumber = new int[20];

// while (temp != 0)
// {
//     binaryNumber[19-count] = temp % 2;
//     temp /= 2; 
//     count ++;
// }

// void PrintArray(int[] array)
// {
//     int i = 0;
//     while (array[i] == 0 )
//     {
//         i++;
//     }
//         while (i < array.Length )
//     {
//         Console.Write($"{array[i]}");
//         i++;
//     }

//         Console.WriteLine();
// }

// PrintArray(binaryNumber);
