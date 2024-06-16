using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using ConsoleApp1.Services.Interfaces;

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

        UserInfoModel IUserInfoService.GetUserInfoById()
        {
            throw new NotImplementedException();
        }
    }
}
