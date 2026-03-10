Console.WriteLine("Выбор одежды по погоде");
Console.Write("Введите текущую температуру на улице: ");
int temperature = Convert.ToInt32(Console.ReadLine());
if (temperature >= 20)
{
  Console.WriteLine("Наденьте лёгкую одежду");

}
else
{
  Console.WriteLine("Наденьте тёплую одежду");
}
Console.WriteLine("Хорошего дня!");