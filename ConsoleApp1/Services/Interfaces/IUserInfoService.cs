using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services.Interfaces
{
    public interface IUserInfoService
    {
        public string AddUserInfo(UserInfoModel userInfoModel);
        public List<UserInfoModel> GetAllUserInfo();

        public UserInfoModel GetUserInfoById();

        public string DeleteUserInfo(Guid id);
    }
}
