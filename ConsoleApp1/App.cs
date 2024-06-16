using ConsoleApp1.Services.Interfaces;
using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Services;

namespace ConsoleApp1
{
    public class App
    {
        private readonly IUserInfoService _userInfoService;

        public App(IUserInfoService userInfoService)
        {
            _userInfoService = userInfoService;
        }
        public void Main()
        {
            var isRunning = true;
            Console.WriteLine("Welcome to our contact adding software!");
            while (isRunning == true)
            {
                Option();
                var user_input = Console.ReadLine();

                switch (user_input)
                {
                    case "0":
                        isRunning = false;
                        Console.WriteLine("Thankyou for using our software");
                        break;

                    case "1":
                        var userInfo = new UserInfoModel();

                        userInfo.Id = Guid.NewGuid();

                        Console.Write("Please enter your first name: ");
                        userInfo.FirstName = Console.ReadLine();
                        while(String.IsNullOrEmpty(userInfo.FirstName))
                        {
                            Console.WriteLine("FirstName cannot be empty");
                            Console.WriteLine("Please enter the FirstName: ");
                            userInfo.FirstName = Console.ReadLine();
                        }

                        Console.Write("Please enter your last name: ");
                        userInfo.LastName = Console.ReadLine();
                        while (String.IsNullOrEmpty(userInfo.LastName))
                        {
                            Console.WriteLine("LastName cannot be empty");
                            Console.WriteLine("Please enter the LastName: ");
                            userInfo.LastName = Console.ReadLine();
                        }

                        Console.Write("Please enter your middle name: ");
                        userInfo.MiddleName = Console.ReadLine();

                        Console.Write("Please enter your email: ");
                        userInfo.Email = Console.ReadLine();
                        while (String.IsNullOrEmpty(userInfo.Email))
                        {
                            Console.WriteLine("Email cannot be empty");
                            Console.WriteLine("Please enter the Email: ");
                            userInfo.Email = Console.ReadLine();
                        }

                        Console.Write("Please enter your phone number: ");
                        userInfo.Phone = Console.ReadLine();
                        while (String.IsNullOrEmpty(userInfo.Phone))
                        {
                            Console.WriteLine("Phone number cannot be empty");
                            Console.WriteLine("Please enter the Phone number: ");
                            userInfo.Phone = Console.ReadLine();
                        }

                        var response1 = _userInfoService.AddUserInfo(userInfo);
                        Console.WriteLine(response1);
                        break;

                    case "2":
                        ListAllUsers();
                        break;

                    case "3":
                        Console.Write("Enter the id of the user you want to delete.");
                        var id = Console.ReadLine();
                        Console.WriteLine("-----------------------");
                        while (String.IsNullOrEmpty(id))
                        {
                            Console.WriteLine("Id cannot be empty!");
                            Console.WriteLine("Please enter the id again: ");
                            id = Console.ReadLine();
                        }
                        if (Guid.TryParse(id, out Guid result))
                        {
                            var res = _userInfoService.DeleteUserInfo(result);
                            Console.WriteLine(res);
                        }
                        else
                        {
                            Console.WriteLine("You entered invalid id");
                            Console.WriteLine("-----------------------");
                        }

                        break;

                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
            }
        }
        public void ListAllUsers()
        {
            var response2 = _userInfoService.GetAllUserInfo();
            foreach (var item in response2)
            {
                Console.WriteLine($"Id: {item.Id}\n" + $"First Name: {item.FirstName}\n" + $"Last Name: {item.LastName}\n" + $"Middle Name: {item.MiddleName}\n" + $"Email: {item.Email}\n" + $"Phone Number: {item.Phone}");
            }
        }
        public static void Option()
        {
            Console.WriteLine("Please choose what you want to do.");
            Console.WriteLine("0 => Exit");
            Console.WriteLine("1 => Add User");
            Console.WriteLine("2 => Get All User Info");
            Console.WriteLine("3 => Delete All User Info");
            Console.WriteLine("-----------------------------------");
        }
    }
}
