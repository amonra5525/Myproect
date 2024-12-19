using System;
public class Pruamoygolnik
{
    public int A {  get; set; }
    public int B { get; set; }
    public void Storona()
    {
        Console.WriteLine("Введите сторону A");
        A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите сторону B");
        B = Convert.ToInt32(Console.ReadLine());
    }
    public void Sum()
    {
        Console.WriteLine($"Сумма всех сторон прямоугольника равна {2 * ( A + B )}");
    }
    public void Ploshad()
    {
        Console.WriteLine($"Площадь прямоугольника равна {A * B}");
    }
    public void Ygol()
    {
        Console.WriteLine("Сумма всех углов прямоугольника равна 360 градусов");
    }
    public void ProcessOption(int option)
    {
        switch (option)
        {
            case 1:
                Storona();
                Sum();
            break;
            case 2:
                Storona();        
                Ploshad();
            break;
            case 3:
                Ygol();
            break;
                default:
                Console.WriteLine("Неверная операция.");
                break;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Pruamoygolnik pru = new Pruamoygolnik();
        while (true)
        {
            ShowMenu();
            if(!int.TryParse(Console.ReadLine(), out int val))
            {
                Console.WriteLine("Ошибка введите корректное число");
                continue;
            }
            if (val == 4)
            {
                Console.WriteLine("Выход из программы");
                break ;
            }
            pru.ProcessOption(val);
            Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
            Console.ReadKey();
            Console.Clear();
        }
    }
    public static void ShowMenu()
    {
        Console.WriteLine("1. Посчитать сумму всех сторон прямоугольника");
        Console.WriteLine("2. Посчитать площадь прямоугольника");
        Console.WriteLine("3. Посчитать сумму всех углов прямоугольника");
        Console.WriteLine("4. Выйти из программы");
        Console.WriteLine("Введите номер операции (1-4):");
    }
}


