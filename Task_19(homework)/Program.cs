// 19. Напишите программу, которая 
// 1: принимает на вход пятизначное число и 
// 2: проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool Polindrom(int number)
{
    int a = number / 10000;
    int b = (number / 1000) % 10;
    int c = (number / 10) % 10;
    int d = number % 10;
    int ad = a - d;
    int bc = b - c;
    return ad == 0 && bc == 0;
}

Console.Write("Введите пятизначное число: ");

int num = Convert.ToInt32(Console.ReadLine());


if ( num > 9999 & num < 100000)
{
bool rest = Polindrom(num);
Console.WriteLine( rest ? "Полиндром" : "Не полиндром");
}
else
{
    Console.WriteLine("Надо было ввести ПЯТИЗНАЧНОЕ число!");
}