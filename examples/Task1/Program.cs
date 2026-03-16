Console.Write("Вес: ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.Write("Рост: ");
double height = Convert.ToDouble(Console.ReadLine());
double bmi = weight / (height * height);
Console.WriteLine($"\nВаш ИМТ: {bmi:F2}");
Console.Write("Категория: ");
if (bmi < 18.5)
{
    Console.WriteLine("Недостаточный вес\nРекомендация: Увеличьте потребление калорий, включите в рацион питательные продукты");
}
else if (bmi >= 18.5 && bmi <= 24.9)
{
    Console.WriteLine("Нормальный вес\nРекомендация: Поддерживайте здоровый образ жизни, продолжайте заниматься физической активностью");
}
else if (bmi >= 25 && bmi <= 29.9)
{
    Console.WriteLine("Избыточный вес\nРекомендация: Увеличьте физическую активность, следите за рационом питания");
}
else
{
    Console.WriteLine("Ожирение\nРекомендация: Обратитесь к врачу для разработки плана снижения веса");
}