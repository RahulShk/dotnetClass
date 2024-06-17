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

        public UserInfoModel GetUserInfoById(Guid id);

        public string DeleteUserInfo(Guid id);

        public string UpdateFirstName(Guid id, string updatedFirstName);

        public string UpdateLastName(Guid id, string updatedLastName);

        public string UpdateMiddleName(Guid id, string updatedMiddleName);

        public string UpdateEmail(Guid id, string updatedEmail);

        public string UpdatePhoneNumber(Guid id, string phonenumber);

        public List<UserInfoModel> Search(string searchParam);
    }
}
