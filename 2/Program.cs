using static System.Net.Mime.MediaTypeNames;

string action = "";
string first = "";

do
{
    Console.WriteLine("Выберите номер программы");
    Console.WriteLine("1.Угадай число");
    Console.WriteLine("2.Таблица умножения");
    Console.WriteLine("3.Вывод делителей числа");
    Console.WriteLine("4.Выход");

    action = Console.ReadLine();

    if (action.Equals("1"))
    {
        Console.WriteLine("Угадайте число от 1 до 100: ");

        Random rnd = new Random();
        int value = rnd.Next(100);

        int number = 0;

        do
        {
            first = Console.ReadLine();

            if (int.TryParse(first, out number))
            {
                if (number > value)
                {
                    Console.WriteLine("Надо меньше");
                }

                if (number < value)
                {
                    Console.WriteLine("Надо больше");
                }
            }
            else
                Console.WriteLine("Введенная строка не являлась числом.");

        }
        while (number != value);
        Console.WriteLine("Угадал!");
    }

    if (action.Equals("2"))
    {
        Console.WriteLine("Таблица умножнния");
        Console.WriteLine();

        int[,] mass = new int[9, 9];

        for (int i = 1; i <= 9; i++)
            for (int j = 1; j <= 9; j++)
            {
                mass[i - 1, j - 1] = i * j;
            }

        int row = mass.GetUpperBound(0) + 1;
        int columns = mass.GetUpperBound(1) + 1;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < columns; j++)
                Console.Write($"{mass[i, j],3}");
            Console.WriteLine();
        }
    }

    if (action.Equals("3"))
    {
        Console.WriteLine("Введите число ");
        first = Console.ReadLine();

        if (int.TryParse(first, out int number))
        {
            for (int a = 1; a <= number; a++)
            {
                if (number % a == 0) Console.Write("{0} ", a);
            }
        }
        else
            Console.WriteLine("Введенная строка не являлась числом.");

        Console.WriteLine();
    }
} while (!action.Equals("4"));