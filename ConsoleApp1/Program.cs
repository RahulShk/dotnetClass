namespace ConsoleApp1
{
    internal class Program
    {
        private static int i;
        private static int j;

        static void Main(string[] args)
        {
            var a = Num_Factorial(5);
            Console.WriteLine(a);

            /*var sum = Add(1, 2);
            var total_with_vat = sum + (0.13 * sum);
            Console.WriteLine($"The total amount with vat is: {total_with_vat}");*/

            /*            Console.Write("x: ");
                        int x = int.Parse(Console.ReadLine());
                        Console.Write("y: ");
                        int y = int.Parse(Console.ReadLine());
                        var z = $"The full name is {x} {y}";
                        Console.WriteLine($"{z}");
                        Console.WriteLine("Hello, test1!");*/

            /* var list1 = new List<string>() { "a", "b", "c", "d", "e", "f", "g" };
             var list2 = new List<string>() { "h", "i", "j","f","g" };
             list1.AddRange(list2);
             list1.Remove("g");
             list1.RemoveAll(x => x == "f");

             foreach (var item in list1)
             {
                 Console.WriteLine(item);
             }*/

            /* Console.WriteLine("Welcome to the game!");
             Console.WriteLine("Do you want to play the game? (Y/N)");

             var response = Console.ReadLine();

             if (response == null || response == "N" || response == "n")
             {
                 Console.WriteLine("Thank you for visiting!");
             }
             while(response == "Y" || response == "y")
             {
                 Console.Write("To begin with, please guess my age in numbers: ");
                 var age = Convert.ToInt16(Console.ReadLine());
                 Random random = new Random();
                 var actual_age = random.Next(18, 40);
                 if (age > 40)
                 {
                     Console.WriteLine("Come on!! I'm not that old!");
                     Console.WriteLine("Wanna try again? (Y/N)");
                     var second_response = Console.ReadLine();
                     if(second_response == "N" || second_response == "n")
                     {
                         Console.WriteLine("Thank you for playing!");
                     }
                     if(second_response == "Y" || second_response == "y")
                     {
                         continue;
                     }
                 }
                 if (age < 18)
                 {
                     Console.WriteLine("Come on!! I'm not that young!");
                     Console.WriteLine("Wanna try again? (Y/N)");
                     var second_response = Console.ReadLine();
                     if (second_response == "N" || second_response == "n")
                     {
                         Console.WriteLine("Thank you for playing!");
                     }
                     if (second_response == "Y" || second_response == "y")
                     {
                         continue;
                     }
                 }
                 if(age == actual_age)
                 {
                     Console.WriteLine("You're absolutely correct!");
                 }
                 if(age <=40 && age>=18)
                 {
                     Console.WriteLine("You were so close!");
                     Console.WriteLine("Wanna try again? (Y/N)");
                     var second_response = Console.ReadLine();
                     if (second_response == "N" || second_response == "n")
                     {
                         Console.WriteLine("Thank you for playing!");
                     }
                     if (second_response == "Y" || second_response == "y")
                     {
                         continue;
                     }
                 }
             }*/

            /*for(i = 0; i<=5; i++)
             {
                 for (j = 0; j<=5; j++)
                 {
                     var z = i + j;
                     if (z == 5)
                     {
                         Console.WriteLine($"The numbers are: {i},{j}");
                     }
                 }
             }*/

        }

        public static int Num_Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number *Num_Factorial(number - 1);
        }
    
        /*static int Add(int a, int b)
        { 
            return a + b; 
        }*/
    }
}
