using System.Threading.Tasks;
using CCG.AspNetCore.Data.Services;
using CCG.AspNetCore.Data.Services.Models;

namespace DataModel.Tests.Services
{
    public class TestUserService : IUserService
    {
        private CcgAccountUser _userResult;

        public void SetUserResult(CcgAccountUser user)
        {
            _userResult = user;
        }

        public Task<CcgAccountUser> GetUser(string email)
        {
            return Task.FromResult(_userResult);
        }
    }
}
