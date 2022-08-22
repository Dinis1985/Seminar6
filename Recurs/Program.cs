int number = 13;

void DecToBin(int num)
{
    if(num == 0) return;
    DecToBin(num / 2); // Строку 6 и 7 меняем местами - переворачиваем число
    Console.Write(num % 2); 
}

DecToBin(number);
