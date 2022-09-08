
void Intersection()
{
    Console.WriteLine("Введите данные k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите данные b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите данные k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите данные b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());

    double x = (b1-b2)/(k2-k1);
    double y = k2*x+b2;
    Console.WriteLine($"Координата x равна: {x};  Координата y равна: {y} ");
}
Intersection();