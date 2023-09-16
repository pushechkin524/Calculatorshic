
using System.Numerics;

Console.WriteLine("Выберите какую операцию Вы хотите выполнить: ");
Console.WriteLine("1. Сложить 2 числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое на второе");
Console.WriteLine("5. Возвести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал из числа");
Console.WriteLine("9. Выйти из программы");
int Choice = 0;
while (Choice != 9)
{
    Console.WriteLine("Выберите действие: ");
    Choice = Convert.ToInt32(Console.ReadLine());

    if (Choice == 1)
    {
        Console.WriteLine("Введите первое число");
        double First = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double Second = Convert.ToDouble(Console.ReadLine());
        double DoPer = (First + Second);
        Console.WriteLine("Ответ: " + DoPer);
    }
    if (Choice == 2)
    {
        Console.WriteLine("Введите первое число");
        double First = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double Second = Convert.ToDouble(Console.ReadLine());
        double DoPer = (First - Second);
        Console.WriteLine("Ответ: " + DoPer);
    }
    if (Choice == 3)
    {
        Console.WriteLine("Введите первое число");
        double First = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double Second = Convert.ToDouble(Console.ReadLine());
        double DoPer = (First * Second);
        Console.WriteLine("Ответ: " + DoPer);
    }
    if (Choice == 4)
    {
        Console.WriteLine("Введите первое число");
        double First = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double Second = Convert.ToDouble(Console.ReadLine());
        double DoPer = (First / Second);
        if (Second == 0)
        {
            Console.WriteLine("Иди учи уроки.");
        }
        else
            Console.WriteLine("Ответ: " + DoPer);
    }
    if (Choice == 5)
    {
        Console.WriteLine("Введите первое число");
        double First = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        double Second = Convert.ToDouble(Console.ReadLine());
        double DoPer = Math.Pow(First, Second);
        Console.WriteLine("Ответ: " + DoPer);
    }
    if (Choice == 6)
    {
        Console.WriteLine("Введите первое число");
        double First = Convert.ToDouble(Console.ReadLine());
        double DoPer = Math.Sqrt(First);
        Console.WriteLine("Ответ: " + DoPer);
    }
    if (Choice == 7)
    {
        Console.WriteLine("Введите первое число");
        double First = Convert.ToDouble(Console.ReadLine());
        double DoPer = (First / 100);
        Console.WriteLine("Ответ: " + DoPer);
    }
    if (Choice == 8)
    {
        Console.WriteLine("Введите первое число");
        int First = Convert.ToInt32(Console.ReadLine());
        int FactNaive(int First)
        {
            int r = 1;
            for (int i = 2; i <= First; i++)
                r = r * i;
            return r;
        }
        int DoPer = FactNaive(First);
        Console.WriteLine("Ответ: " + DoPer);
    }

}

