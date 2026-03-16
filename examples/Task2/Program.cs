Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (IsPrime(num))
    Console.WriteLine($"Простое!");
else
    Console.WriteLine($"Не простое!");

static bool IsPrime(int num)
{
    int zone = (int)Math.Sqrt(num);
    if (num < 2)
        return false;
    if (num == 2)
        return true;
    if (num % 2 == 0)
        return false;
    for (int i = 3; i <= zone; i += 2)
    {
        if (num % i == 0)
            return false;
    }
    return true;
}