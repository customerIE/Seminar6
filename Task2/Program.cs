//  Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
double x = 0;
double y = 0;
Console.Write("Введеите коэф-т k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите коэф-т b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите коэф-т k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите коэф-т b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
if (((k1/k2)==1) && ((k1/k2)==(b1/b2)))
{
    Console.WriteLine("Прямые совпадают!");
}
else if (((k1/k2)==1) && ((k1/k2)!=(b1/b2)))
{
    Console.WriteLine("Прямые параллельны!");
}
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Прямые пересекаются в точке ({x};{y})");
}

