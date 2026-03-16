// Начало
Console.WriteLine("Таблица умножения");
// Ввод данных
Console.Write("Введите число для таблицы умножения: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Таблица умножения для {number}:");
// Цикл for
for (int i = 1; i <= 10; i++)
{
    int result = number * i;
    Console.WriteLine($"{number} x {i} = {result}");
}
// Конец
Console.WriteLine("Конец программы");