// 11. Напишите программу котора
// 1: выводит случайное трехзначное число
// 2: удаляет вторую цифру этого числа

// 456 -> 46
// 782 -> 72
// 918 -> 98

int FirstTherdDigit(int number)
{
    int firstDigit = number / 100;
    int therdDigit = number % 10;
    int result = firstDigit * 10 + therdDigit;
    return result;
}



int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {num}");

Console.WriteLine(FirstTherdDigit(num));