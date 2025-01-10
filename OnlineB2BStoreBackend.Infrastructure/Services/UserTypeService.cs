using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Domain.Models;

namespace OnlineB2BStoreBackend.Infrastructure.Services
{
    public class UserTypeService : IUserTypeService
    {
        public Task<UserType> GetUserType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserType>> GetUserTypeList()
        {
            throw new NotImplementedException();
        }
    }
}
