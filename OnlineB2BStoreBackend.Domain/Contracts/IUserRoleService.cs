using OnlineB2BStoreBackend.Domain.Models;

namespace OnlineB2BStoreBackend.Domain.Contracts
{
    public interface IUserRoleService
    {
        Task<List<UserRole>> GetUserRoleList();
        Task<UserRole> GetUserRole(int id);
        Task<int> InsertUserRole(UserRole userRole);
        Task<UserRole> UpdateUserRole(UserRole userRole);
        Task<bool> RemoveUserRole(int id);
    }
}
