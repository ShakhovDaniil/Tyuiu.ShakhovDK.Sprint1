using Tyuiu.ShakhovDK.Sprint1.Task2.V26.Lib;

class Program
{


    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Шахов Д.К | ИИПБ-24-2";
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                              *");
        Console.WriteLine("* Тема: Арифметические операторы в C#                                                    *");
        Console.WriteLine("* Задание #2                                                                             *");
        Console.WriteLine("* Вариант #26                                                                            *");
        Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                               *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                            *");
        Console.WriteLine("* Формулировка задания:                                                                  *");
        Console.WriteLine("* Задано текущее время в часах и минутах. Вычислить, сколько минут прошло с начала суток *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                                        *");
        Console.WriteLine("******************************************************************************************");

        int x; 
        int y;

        Console.WriteLine("Введите значение в часах: ");

        x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение в минутах: ");

        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("*****************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                            *");
        Console.WriteLine("*****************************************************************************************");

        Console.WriteLine(ds.CalculateMinutesSinceStart(x, y));

        Console.ReadLine();


    }
}