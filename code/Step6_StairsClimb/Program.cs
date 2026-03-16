// Начало
Console.WriteLine("Подъём по лестнице");
// Ввод данных
Console.Write("На какой этаж нужно подняться?: ");
int targetFloor = Convert.ToInt32(Console.ReadLine());
// Инициализация переменной цикла
int currentFloor = 1;
Console.WriteLine("Начинаем подъём!");
// Цикл while
while (currentFloor < targetFloor)
{
    currentFloor++; // currentFloor = currentFloor + 1
    Console.WriteLine($"Поднялись на {currentFloor}-й этаж");
}
// Вывод результата
Console.WriteLine($"Вы достигли {targetFloor}-го этажа!");
Console.WriteLine("Конец программы");