using Tyuiu.ShakhovDK.Sprint1.Task7.V23.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Шахов Д.К | ИИПБ-24-2";
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                              *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                *");
        Console.WriteLine("* Задание #7                                                                             *");
        Console.WriteLine("* Вариант #23                                                                            *");
        Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                               *");
        Console.WriteLine("* Написать программу,                                                                    *");
        Console.WriteLine("* которая вычисляет математическое выражение по исходным значениям данных,               *");
        Console.WriteLine("* вводимых пользователем. Ответ округлите до 3 знаков после запятой.                     *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("                        2                                                                 ");
        Console.WriteLine("                     20x                                                                  ");
        Console.WriteLine("                    -----                                                                 ");
        Console.WriteLine("            sin(x)     3         2                                                        ");
        Console.WriteLine("* z = x - 10       + 3x   + cos(x  - y)                                                   ");
        Console.WriteLine("******************************************************************************************");

        Console.WriteLine("Введите значение x: ");

        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение y: ");

        double y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("*****************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                            *");
        Console.WriteLine("*****************************************************************************************");

        Console.WriteLine($"z = {ds.Calculate(x, y)}");

        Console.ReadKey();
    }
}