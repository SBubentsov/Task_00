// 9. Напишите программу, которая
// 1: выводит случайное число из отрезка [10, 99]
// 2: показывает наибольшую цифру числа

// 78 -> 8
// 12 -> 2
// 85 -> 8


// int firstDigit = num / 10;
// int secondDigit = num % 10;

// int res = firstDigit;
// if (secondDigit > firstDigit) res = secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {num}-> {res} ");

// int result = firstDigit > secondDigit ? firstDigit : secondDigit;
// Console.WriteLine($"Наибольшая цифра числа {num}-> {result} ");

// if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit} ");
// else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit} ");

// int max = Math.Max(firstDigit, secondDigit);
// Console.WriteLine($"Наибольшая цифра числа {num}-> {max} ");

// int MaxDigit(int num)
// {
//     int firstDigit = num / 10;
//     int secondDigit = num % 10;
//     int result = firstDigit > secondDigit ? firstDigit : secondDigit;
//     return result;
// }
// int maxDigit = MaxDigit(num);
// Console.WriteLine($"Наибольшая цифра числа {num}-> {maxDigit} ");

int MaxDigits(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}

int num = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из диапозона 10 - 99 -> {num}");

int maxDigits = MaxDigits(num);
Console.WriteLine($"Наибольшая цифра числа {num}-> {maxDigits} ");