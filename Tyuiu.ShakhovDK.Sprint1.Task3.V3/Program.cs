using Tyuiu.ShakhovDK.Sprint1.Task3.V3.Lib;

class Program
{


    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Шахов Д.К | ИИПБ-24-2";
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                              *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                                *");
        Console.WriteLine("* Задание #3                                                                             *");
        Console.WriteLine("* Вариант #3                                                                             *");
        Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                               *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                            *");
        Console.WriteLine("* Расчёты:                                                                               *");
        Console.WriteLine("* Написать программу вычисления объема параллелепипеда.                                  *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                                        *");
        Console.WriteLine("******************************************************************************************");

        double a = 9;

        double b = 7.5;

        double h = 5;

        Console.WriteLine($"Длина параллелепипеда: {a}");

        Console.WriteLine($"Ширина параллелепипеда: {b}");

        Console.WriteLine($"Высота параллелепипеда: {h}");

        Console.WriteLine("*****************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                            *");
        Console.WriteLine("*****************************************************************************************");

        Console.WriteLine($"Объём параллелепипеда = {ds.ParallelepipedVolume(a, b, h)}");

        Console.ReadLine();
    }
}