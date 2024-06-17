using ConsoleApp1.Model;
using ConsoleApp1.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class UserInfoService : IUserInfoService
    {
        public List<UserInfoModel> UserInfos { get; set; }

        public UserInfoService()
        { 
            UserInfos = new List<UserInfoModel>();
        }

        public string AddUserInfo(UserInfoModel userInfoModel)
        {
            UserInfos.Add(userInfoModel);
            return "Added Successfully.";
        }

        public List<UserInfoModel> GetAllUserInfo()
        {
            return UserInfos;
        }

        public string DeleteUserInfo(Guid id)
        {
            var user = GetUserInfoById(id);
            if (user == null)
            {
                return "User doesnot exist.";
            }
            else
            {
                UserInfos.Remove(user);
                return "Removed Successfully!";
            }
        }

        public UserInfoModel GetUserInfoById(Guid id)
        {
            return UserInfos.FirstOrDefault(x => x.Id == id);
        }

        public string UpdateFirstName(Guid id, string updatedFirstName)
        {
            var item = UserInfos.Find(x => x.Id == id);
            item.FirstName = updatedFirstName;
            return "First Name updated Successfully!";
        }

        public string UpdateLastName(Guid id, string updatedLastName)
        {
            var item = UserInfos.Find(x => x.Id == id);
            item.LastName = updatedLastName;
            return "Last Name updated Successfully!";
        }

        public string UpdateMiddleName(Guid id, string updatedMiddleName)
        {
            var item = UserInfos.Find(x => x.Id == id);
            item.MiddleName = updatedMiddleName;
            return "Middle Name updated Successfully!";
        }

        public string UpdateEmail(Guid id, string updatedEmail)
        {
            var item = UserInfos.Find(x => x.Id == id);
            item.Email = updatedEmail;
            return "Email updated Successfully!";
        }
        public string UpdatePhoneNumber(Guid id, string phonenumber)
        {
            var item = UserInfos.Find(x => x.Id == id);
            item.Phone = phonenumber;
            return "Phone Number updated successfully!";
        }

        public List<UserInfoModel> Search(string searchParam)
        { 
            var result = UserInfos.Where(x => x.FirstName.ToLower().StartsWith(searchParam.ToLower()) ||
                                              x.LastName.ToLower().StartsWith(searchParam.ToLower())  ||
                                              x.MiddleName.ToLower().StartsWith(searchParam.ToLower())||
                                              x.Email.ToLower().StartsWith(searchParam.ToLower())     ||
                                              x.Phone.ToLower().StartsWith(searchParam.ToLower())).ToList();
            return result;
        }
    }
}
