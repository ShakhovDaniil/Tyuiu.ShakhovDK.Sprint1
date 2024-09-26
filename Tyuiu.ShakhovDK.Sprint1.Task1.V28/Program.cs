using Tyuiu.ShakhovDK.Sprint1.Task1.V28.Lib;

class Program
{

    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Шахов Д.К | ИИПБ-24-2";
        Console.WriteLine("*****************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                             *");
        Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                               *");
        Console.WriteLine("* Задание #1                                                                            *");
        Console.WriteLine("* Вариант #28                                                                           *");
        Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                     *");
        Console.WriteLine("*****************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                              *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,               *");
        Console.WriteLine("* вычисляет результат по формуле (x * 2) / (1 + x) и печатает его на экране.            *");
        Console.WriteLine("*                                                                                       *");
        Console.WriteLine("*****************************************************************************************");
        Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
        Console.WriteLine("*****************************************************************************************");

        double x;

        Console.WriteLine("Введите значение x: ");

        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("*****************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                            *");
        Console.WriteLine("*****************************************************************************************");

        Console.WriteLine(ds.Calculate(x));

        Console.ReadLine();

    }
}