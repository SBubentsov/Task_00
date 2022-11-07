// 18. Напишите программу, которая
// 1: по заданному номеру четверти
// 2: показывает диапазон возможных координат точек в этой четверти (X. Y).

string Coordinats(int diaposon)
{
    if (diaposon == 1) return "X > 0 , Y > 0";
    if (diaposon == 2) return "X < 0 , Y > 0";
    if (diaposon == 3) return "X < 0 , Y < 0";
    if (diaposon == 4) return "X > 0 , Y < 0";
    return null;

}

Console.WriteLine("Введите номер четверти:");
Console.Write("Четверть № ");
int quar = Convert.ToInt32(Console.ReadLine());

string quarter = Coordinats(quar);

Console.WriteLine(quarter == null 
? "Введен некорректный номер четверти" 
: $"В указанной четверти диапазон значений: {quarter}");

