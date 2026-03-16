Random rng = new Random();
bool active_game = true;

while (active_game)
{
    int num = rng.Next(1, 101);
    int count = 0;
    bool isFound = false;
    Console.WriteLine("\nNew Game!");

    while (!isFound)
    {
        Console.Write("Ваш вариант: ");
        string input = Console.ReadLine();

        try
        {
            if (string.IsNullOrEmpty(input))
                throw new FormatException();

            int guess = int.Parse(input);
            count++;

            if (guess < 1 || guess > 100)
            {
                Console.WriteLine("Введите число от 1 до 100.");
                continue;
            }

            if (guess < num)
                Console.WriteLine("Больше!");
            else if (guess > num)
                Console.WriteLine("Меньше!");
            else
            {
                Console.WriteLine($"\nВы угадали!");
                Console.WriteLine($"Попыток: {count}");
                isFound = true;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Число слишком большое.");
        }
    }

    Console.Write("\nПродолжить? (да/нет): ");
    switch (Console.ReadLine().ToLower())
    {
        case "да":
        case "д":
        case "yes":
        case "y":
            break;
        default:
            active_game = false;
            Console.WriteLine("\nИгра завершена.");
            break;
    }
}