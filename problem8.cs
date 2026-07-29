using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Choose: A (Area), P (Perimeter), X (Exit): ");
            char choice = Console.ReadLine().ToUpper()[0];

            if (choice == 'X') break;

            Console.Write("Enter radius: ");
            double r = double.Parse(Console.ReadLine());

            if (choice == 'A')
                Console.WriteLine("Area = " + (Math.PI * r * r));
            else if (choice == 'P')
                Console.WriteLine("Perimeter = " + (2 * Math.PI * r));
            else
                Console.WriteLine("Invalid choice!");
        }
    }
}
