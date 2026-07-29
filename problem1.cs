class Program
{
    static void Main(string[] args)
    {
        double radius = 5;

        double area = Math.PI * radius * radius;

        Console.WriteLine("Radius: " + radius);
        Console.WriteLine("The area is: " + area.ToString("F2"));
    }
}
