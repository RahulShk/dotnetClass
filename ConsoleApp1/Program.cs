using ConsoleApp1;
using System.Collections;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<int, Car>();
            var car1 = new Car(1, "Volks Wagen", "Its about excellence", 300, 300000.99f);
            var car2 = new Car(2, "Rolls Royce", "The Royalty's call", 299, 200000.99f);
            dict.Add(1, car1);
            dict.Add(2, car2);
            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} => \n {kvp.Value}");
            }
        }      
    }
}
