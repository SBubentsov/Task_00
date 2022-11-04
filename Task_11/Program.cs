// 11. Напишите программу котора
// 1: выводит случайное трехзначное число
// 2: удаляет вторую цифру этого числа

// 456 -> 46
// 782 -> 72
// 918 -> 98

int MaxDigits(int number)
{
    int firstDigit = number / 100;
    int therdDigit = number % 10;
    return firstDigit > therdDigit ? firstDigit : therdDigit;
}



int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {num}");

