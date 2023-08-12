Console.WriteLine("");
Console.WriteLine("Задание 8");
Console.Write("Введите число :");
int num7 = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;

if(num7 > 1)
{
    while(evenNumber <= num7)
    {
        Console.Write($"{evenNumber} ");
        evenNumber = evenNumber + 2;
    }
}
