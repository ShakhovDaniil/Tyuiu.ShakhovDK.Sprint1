using Tyuiu.ShakhovDK.Sprint1.Task4.V30.Lib;

class Program
{


    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Шахов Д.К | ИИПБ-24-2";
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                              *");
        Console.WriteLine("* Тема: Class Math                                                                       *");
        Console.WriteLine("* Задание #4                                                                             *");
        Console.WriteLine("* Вариант #30                                                                            *");
        Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                               *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                *");
        Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                               *");
        Console.WriteLine("* Формула: (x + y^3) / (e^2-y)                                                           *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                                        *");
        Console.WriteLine("******************************************************************************************");

        Console.WriteLine("Введите значение x: ");

        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение y: ");

        double y = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("*****************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                            *");
        Console.WriteLine("*****************************************************************************************");

        Console.WriteLine($"(x + y^3) / (e^2-y)  = {Math.Round(ds.Calculate(x, y), 3)}");

        Console.ReadLine();
    }
}