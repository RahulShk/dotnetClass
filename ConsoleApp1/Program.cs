namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First Name: ");
            var name1 = Console.ReadLine();
            Console.Write("Last Name: ");
            var name2 = Console.ReadLine();
            var name3 = $"The full name is {name1} {name2}";
            Console.WriteLine($"The full name is {name1} {name2}");
            Console.WriteLine("Hello, World!");
        }
    }
}
