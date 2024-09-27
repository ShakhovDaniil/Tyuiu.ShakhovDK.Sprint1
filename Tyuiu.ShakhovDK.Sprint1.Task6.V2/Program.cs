using Tyuiu.ShakhovDK.Sprint1.Task6.V2.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Шахов Д.К | ИИПБ-24-2";
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* Спринт #1                                                                              *");
        Console.WriteLine("* Тема: Работа со строками класс String                                                  *");
        Console.WriteLine("* Задание #6                                                                             *");
        Console.WriteLine("* Вариант #2                                                                             *");
        Console.WriteLine("* Выполнил: Шахов Даниил Константинович | ИИПБ-24-2                                      *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                               *");
        Console.WriteLine("* Написать программу:                                                                    *");
        Console.WriteLine("* Пользователь вводит текст.                                                             *");
        Console.WriteLine("* Проверить, есть ли в строке слово Hello.                                               *");
        Console.WriteLine("******************************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
        Console.WriteLine("******************************************************************************************");

        Console.WriteLine("* Введите строку:                                                                            *");

        string in_str = Console.ReadLine();

        Console.WriteLine("*****************************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                                            *");
        Console.WriteLine("*****************************************************************************************");

        Console.WriteLine($"Ответ на проверку, есть ли в строке слово 'Hello' = {ds.CheckHello(in_str)}");

        Console.ReadKey();
    }
}
