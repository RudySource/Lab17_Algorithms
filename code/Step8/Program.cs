Console.Write("Калькулятор с функциями\nВведите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Сложение: {num1} + {num2} = {Sum(num1, num2)}\nВычитание: {num1} - {num2} = {Subtract(num1, num2)}\nУмножение: {num1} * {num2} = {Multiply(num1, num2)}\nДеление: {num1} / {num2} = {Divide(num1, num2)}");
static double Sum(double a, double b) => a + b;
static double Subtract(double a, double b) => a - b;
static double Multiply(double a, double b) => a * b;
static double Divide(double a, double b) => a / b;