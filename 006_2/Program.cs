// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// x = (b2-b1)/(k1-k2)
// y = k1*x+b1=k1*(b2-b1)/(k1-k2) + b1;

Console.Clear();
Console.WriteLine("Введите пармаметры для уравнений.");

void Coordinat()
{
   Console.WriteLine("Ведите к1: ");
   double k1 = double.Parse(Console.ReadLine()!);
   Console.WriteLine("Ведите к2: ");
   double k2 = double.Parse(Console.ReadLine()!);
   Console.WriteLine("Ведите b1: ");
   double b1 = double.Parse(Console.ReadLine()!);
   Console.WriteLine("Ведите b2: ");
   double b2 = double.Parse(Console.ReadLine()!);
}

double[] CrossPoint(double k1, double k2, double b1, double b2)
{
    double x = 0;
    double y = 0;
    if (k1 == k2)
    {
        if (b1 == b2)
        {
            Console.WriteLine("Прямые совпадающие, имеют бесконечное количество точек пересечения");
        }
        else
        {
            Console.WriteLine("Прямые параллельны, точка пересечения отсутствует");
        }
    }
    else
    {
        x = (b2 - b1) / (k1 - -k2);
        y = k2 * x + b1;
    }
    return new double[2] {x, y}; 
}

Coordinat();
Console.WriteLine($"Точка пересечения двух прямых - {CrossPoint}");


