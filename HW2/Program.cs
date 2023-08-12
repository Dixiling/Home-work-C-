Console.WriteLine("Задание 2");
Console.Write("введите первое целое число :");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе целое число :");
int num2 = Convert.ToInt32(Console.ReadLine());
int max = num1 ;
if (num1 >= num2) 
    Console.WriteLine($"Первое число больше чем второе :{max} > {num2}");
else
    Console.WriteLine($"Второе число больше чем первое :{num2} > {max}");
    max = num2 ;