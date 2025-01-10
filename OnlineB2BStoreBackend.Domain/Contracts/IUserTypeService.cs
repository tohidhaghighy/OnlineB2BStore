using OnlineB2BStoreBackend.Domain.Models;

namespace OnlineB2BStoreBackend.Domain.Contracts
{
    public interface IUserTypeService
    {
        Task<List<UserType>> GetUserTypeList();
        Task<UserType> GetUserType(int id);
    }
}
