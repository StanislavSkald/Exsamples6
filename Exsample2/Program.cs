//Задача 43: Напишите программу, которая найдёт точку пересечения двух
//прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0,5; -0,5)

int Enter(string mes)
{
    Console.WriteLine(mes);
    return Convert.ToInt32(Console.ReadLine());
}


bool Define(double a, double b, double c, double d)
{
    return !(a == b); 
}


(double, double) FundPoint (double a, double b, double c, double d)
{
    double x = (d - c)/(a - b);
    double y = a * (d - c) / (a - b) + c; 
    return (x, y);
}

int b1 = Enter("Введите свободный член b1");
int k1 = Enter("Введите угловой коэффициент k1");
int b2 = Enter("Введите свободный член b2");
int k2 = Enter("Введите угловой коэффициент k2");

if (Define(k1, k2, b1, b2) == true)
{
    (double x, double y) = FundPoint(k1, k2, b1, b2);
    Console.WriteLine($"Точка пересечения находится по координатам: ({x}, {y})");
}
else
{
    Console.WriteLine("Прямые не пересекаются");
}