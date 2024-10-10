try
{
    double t = 2;
    double m = 0.2;
    Console.WriteLine("Введите A:");
    double a = double.Parse(Console.ReadLine());
    double w = 2 * Math.PI * Math.PI * Math.Sqrt(a) * Math.Sqrt(m) / Math.Sqrt(t);
    Console.WriteLine($"Ответ {w}");

}
catch
{
    
}