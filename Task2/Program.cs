/*Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

double InputDouble(string message)
{
    System.Console.WriteLine(message + ": ");
    return Convert.ToDouble(Console.ReadLine());
}

void PointInterLine(double k1, double b1, double k2, double b2)
{
    if ((k1 == k2) && (b1 == b2))
    {
        System.Console.WriteLine("Прямые совпадают.");
    }
    else if (k1 == k2)
    {
        System.Console.WriteLine("Прямые параллельны.");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        System.Console.WriteLine($"Точка пересечения двух прямых - ({x:F2}; {y:F2})");
    }
}

double k1 = InputDouble("Введите число k1");
double b1 = InputDouble("Введите число b1");
double k2 = InputDouble("Введите число k2");
double b2 = InputDouble("Введите число b2");
PointInterLine(k1, b1, k2, b2);
