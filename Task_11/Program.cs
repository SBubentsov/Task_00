// 11. Напишите программу котора
// 1: выводит случайное трехзначное число
// 2: удаляет вторую цифру этого числа

// 456 -> 46
// 782 -> 72
// 918 -> 98

int MaxDigits(int number)
{
    int firstDigit = num / 100;
    int therdDigit = num % 10;
    return firstDigit > therdDigit ? firstDigit : secondDigit;
}



int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число -> {num}");

