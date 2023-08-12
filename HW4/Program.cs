Console.WriteLine("");
Console.WriteLine("Задание 4");
Console.Write("введите первое целое число :");
int num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе целое число :");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите третье целое число :");
int num5 = Convert.ToInt32(Console.ReadLine());
int Mmax =num3 ;
if (num4 > num3)
    Mmax = num4;
if (num5 > Mmax)
    Mmax = num5;
Console.Write($"Получаем максимальное число:{Mmax}");