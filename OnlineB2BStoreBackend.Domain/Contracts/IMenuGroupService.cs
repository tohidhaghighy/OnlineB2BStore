using OnlineB2BStoreBackend.Domain.Models;

namespace OnlineB2BStoreBackend.Domain.Contracts
{
    public interface IMenuGroupService
    {
        Task<List<MenuGroup>> GetMenuGroupList();
        Task<MenuGroup> GetMenuGroup(int id);
        Task<MenuGroup> InsertMenuGroup(MenuGroup menuGroup);
        Task<MenuGroup> UpdateMenuGroup(MenuGroup menuGroup);
        Task<MenuGroup> RemoveMenuGroup(MenuGroup menuGroup);
    }
}
