Console.WriteLine("1. Сложить 2 числа");
Console.WriteLine("2. Вычесть первое из второго");
Console.WriteLine("3. Перемножить два числа");
Console.WriteLine("4. Разделить первое число на второе");
Console.WriteLine("5. Вовзести в степень N первое число");
Console.WriteLine("6. Найти квадратный корень из числа");
Console.WriteLine("7. Найти 1 процент от числа");
Console.WriteLine("8. Найти факториал числа");
Console.WriteLine("9. Выйти из программы");
int nomer_zadachi = 0;
do
{
    Console.WriteLine("Введите номер задачи");
    nomer_zadachi = Convert.ToInt16(Console.ReadLine());
    if (nomer_zadachi == 1)
    {
        Console.WriteLine("Введите первое число");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сумма чисел = " + (first + second));
    }
    else if (nomer_zadachi == 2)
    {
        Console.WriteLine("Введите первое число");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Разность чисел = " + (first - second));
    }
    else if (nomer_zadachi == 3)
    {
        Console.WriteLine("Введите первое число");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Произведение чисел = " + (first * second));
    }
    else if (nomer_zadachi == 4)
    {
        Console.WriteLine("Введите первое число");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число");
        int second = Convert.ToInt32(Console.ReadLine());
        if (second == 0)
        {
            Console.WriteLine("На ноль нельзя делить))");
        }
        else
        {
            Console.WriteLine("Частное чисел = " + (first / second));
        }
    }
    else if (nomer_zadachi == 5)
    {
        Console.WriteLine("Введите число");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите степень, в которую необходимо возвести число");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(second + " Степень числа " + first + " = " + (Math.Pow(first, second)));
    }
    else if (nomer_zadachi == 6)
    {
        Console.WriteLine("Введите число");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Квадратный корень из числа " + first + " = " + (Math.Sqrt(first)));
    }
    else if (nomer_zadachi == 7)
    {
        Console.WriteLine("Введите число");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1 процент от числа " + first + " = " + (first / 100));
    }
    else if (nomer_zadachi == 8)
    {
        Console.WriteLine("Введите число");
        int first = Convert.ToInt32(Console.ReadLine());
        double faktrl = 1;
        if (Convert.ToInt32(first) == Convert.ToDouble(first))
        {

            {
                for (int i = 1; i <= first; i++)
                {
                    faktrl *= i;
                }
            }
            Console.WriteLine("Факториал числа " + first + " = " + faktrl);
            }
    }
    else if (nomer_zadachi != 9)
    {
        Console.WriteLine("Ваше число введено неверно.");
    }
} while (nomer_zadachi != 9);
if (nomer_zadachi == 9) ;
{
    Console.WriteLine("Спасибо за использование!");
}
