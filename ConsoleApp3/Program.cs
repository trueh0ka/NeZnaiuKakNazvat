using System;

Console.WriteLine("Выберите каую операцию вы хотите выполнить:");
Console.WriteLine("1. Сложить 2 числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из первого числа");
Console.WriteLine("7. Найти 1 процент от первого числа");
Console.WriteLine("8. Найти факториал из первого числа");
Console.WriteLine("9. Выйти из программы");
int oper;
do
{
    oper = Int32.Parse(Console.ReadLine());

    if (oper < 9)
    {
        Console.WriteLine("Введите первое число");
        string input2 = Console.ReadLine();
        int pervoe = Convert.ToInt32(input2);
        Console.WriteLine("Введите второе число");
        string input3 = Console.ReadLine();
        int vtoroe = Convert.ToInt32(input3);
        if (oper == 1)
        {
            Console.WriteLine(pervoe + vtoroe);
        }
        if (oper == 2)
        {
            Console.WriteLine(vtoroe - pervoe);
        }
        if (oper == 3)
        {
            Console.WriteLine(pervoe * vtoroe);
        }
        if (oper == 4)
        {
            Console.WriteLine(pervoe / vtoroe);
        }
        if (oper == 5)
        {
            Console.WriteLine("В какую степень вы хотите возвести первое число?");
            string input4 = Console.ReadLine();
            int N = Convert.ToInt32(input4);
            int a = pervoe;
            for (int i = 1; i < N; i++)
            {
                pervoe = pervoe * a;
            }
            Console.WriteLine(pervoe);
        }
        if (oper == 6)
        {
            Console.WriteLine(Math.Sqrt(pervoe));
        }
        if (oper == 7)
        {
            Console.WriteLine(pervoe / 100);
        }
        if (oper == 8)
        {
            int a = 1;
            for (int i = 1; i <= pervoe; i++)
            {
                a = a * i;
            }
            Console.WriteLine(a);
        }
    }
} while (oper != 9);