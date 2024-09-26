using Tyuiu.ShakhovDK.Sprint1.Task5.V3.Lib;

class Program
{


    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Шахов Д.К | ИИПБ-24-2";
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                              *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                                             *");
        Console.WriteLine("* Задание #5                                                                             *");
        Console.WriteLine("* Вариант #3                                                                             *");
        Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                               *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                                   *");
        Console.WriteLine("* Присвоить целой переменной h третью от конца цифру                                     *");
        Console.WriteLine("* в записи положительного целого числа k (например, если k=130985, то h=9).              *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                                        *");
        Console.WriteLine("******************************************************************************************");

        Console.WriteLine("Введите значение k: ");

        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("*****************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                            *");
        Console.WriteLine("*****************************************************************************************");

        Console.WriteLine($"h = {ds.Calculate(k)}");

        Console.ReadLine();
    }
}