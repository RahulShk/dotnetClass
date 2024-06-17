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
                        ListAllUsers();
                        Console.Write("Enter the id of the user you want to delete.");
                        var id = Console.ReadLine();
                        Console.WriteLine("---------------------------------------------");
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
                            Console.WriteLine("---------------------------------------------");
                        }

                        break;

                    case "4":
                        Console.WriteLine("---------------------------------------------");
                        ListAllUsers();
                        Console.WriteLine("---------------------------------------------");
                        Console.Write("Enter the id of the user you want to update: ");
                        var update_id = Console.ReadLine();
                        while (String.IsNullOrEmpty(update_id))
                        {
                            Console.WriteLine("Id cannot be empty!");
                            Console.WriteLine("Please enter the id again: ");
                            update_id = Console.ReadLine();
                        }
                        if(Guid.TryParse(update_id, out Guid result4))
                        {
                            var getUser_ById = _userInfoService.GetUserInfoById(result4);
                            if(getUser_ById == null)
                            {
                                Console.WriteLine("User not found.");
                            }
                            else
                            {
                                Console.WriteLine("Please select what you want to update:");
                                Console.WriteLine("1. Id");
                                Console.WriteLine("2. First Name");
                                Console.WriteLine("3. Last Name");
                                Console.WriteLine("4. Middle Name");
                                Console.WriteLine("5. Email");
                                Console.WriteLine("6. Phone Number");
                                var update_item = Console.ReadLine();

                                while (String.IsNullOrEmpty(update_item))
                                {
                                    Console.WriteLine("Update entity cannot be empty!");
                                    Console.Write("Please enter the feild you want to update again: ");
                                    update_item = Console.ReadLine();
                                }

                                if (int.TryParse(update_item, out int result4_1))
                                {
                                    if(result4_1 == 2)
                                    {
                                        Console.Write("Updated First Name: ");
                                        var updatedFirstName = Console.ReadLine();
                                        while(String.IsNullOrEmpty(updatedFirstName))
                                        {
                                            Console.WriteLine("First Name cannot be empty!");
                                            Console.Write("Please enter the updated First Name again: ");
                                            updatedFirstName = Console.ReadLine();
                                        }
                                        var res = _userInfoService.UpdateFirstName(result4, updatedFirstName);
                                        Console.WriteLine(res);
                                    }
                                    else if (result4_1 == 3)
                                    {
                                        Console.Write("Updated Last Name: ");
                                        var updatedLastName = Console.ReadLine();
                                        while (String.IsNullOrEmpty(updatedLastName))
                                        {
                                            Console.WriteLine("Last Name cannot be empty!");
                                            Console.Write("Please enter the updated Last Name again: ");
                                            updatedLastName = Console.ReadLine();
                                        }
                                        var res = _userInfoService.UpdateLastName(result4, updatedLastName);
                                        Console.WriteLine(res);
                                    }
                                    else if (result4_1 == 4)
                                    {
                                        Console.Write("Updated Middle Name: ");
                                        var updatedMiddleName = Console.ReadLine();
                                        var res = _userInfoService.UpdateMiddleName(result4, updatedMiddleName);
                                        Console.WriteLine(res);
                                    }
                                    else if (result4_1 == 5)
                                    {
                                        Console.Write("Updated Email Name: ");
                                        var updatedEmail = Console.ReadLine();
                                        while (String.IsNullOrEmpty(updatedEmail))
                                        {
                                            Console.WriteLine("Email cannot be empty!");
                                            Console.Write("Please enter the updated Email again: ");
                                            updatedEmail = Console.ReadLine();
                                        }
                                        var res = _userInfoService.UpdateEmail(result4, updatedEmail);
                                        Console.WriteLine(res);
                                    }
                                    else if (result4_1 == 6)
                                    {
                                        Console.Write("Updated Phone Number: ");
                                        var updated_phone = Console.ReadLine();
                                        while (String.IsNullOrEmpty(updated_phone))
                                        {
                                            Console.WriteLine("Phone number cannot be empty!");
                                            Console.Write("Please enter the updated phone number again: ");
                                            updated_phone = Console.ReadLine();
                                        }
                                        var res = _userInfoService.UpdatePhoneNumber(result4, updated_phone);
                                        Console.WriteLine(res);
                                    }
                                    else
                                    {
                                        Console.WriteLine("The given field doesnot exist.");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You entered invalid field!");
                                }
                            }  
                        }
                        else
                        {
                            Console.WriteLine("You entered invalid id!");
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
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Please choose what you want to do.  ");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("  0 => Exit");
            Console.WriteLine("  1 => Add User");
            Console.WriteLine("  2 => Get All User Info");
            Console.WriteLine("  3 => Delete All User Info");
            Console.WriteLine("  4 => Update User Info");
            Console.WriteLine("--------------------------------------");
        }
    }
}
