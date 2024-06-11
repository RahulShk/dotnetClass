namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());
            var z = $"The full name is {x} {y}";
            Console.WriteLine($"{z}");
            Console.WriteLine("Hello, World!");
        }
    }
}
