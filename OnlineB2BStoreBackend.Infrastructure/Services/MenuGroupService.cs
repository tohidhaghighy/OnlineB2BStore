using Dapper;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Domain.Db;
using OnlineB2BStoreBackend.Domain.Models;

namespace OnlineB2BStoreBackend.Infrastructure.Services
{
    public class MenuGroupService(ApplicationDbContext _context) : IMenuGroupService
    {
        public async Task<MenuGroup> GetMenuGroup(int id)
        {
            var query = $@"select * from Uif.MenuGroup where MenuGroupID={id}";
            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var result = await connection.QueryAsync<MenuGroup>(query, commandTimeout: 190);
                    return result.FirstOrDefault();
                }
                catch (Exception e)
                {
                    throw new Exception(" menu group --- " + e.Message + "\n query =" + query);
                }
            }
        }

        public async Task<List<MenuGroup>> GetMenuGroupList()
        {
            var query = $@"select * from Uif.MenuGroup";
            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var result = await connection.QueryAsync<MenuGroup>(query, commandTimeout: 190);
                    return result.ToList();
                }
                catch (Exception e)
                {
                    throw new Exception(" menu group --- " + e.Message + "\n query =" + query);
                }
            }
        }

        public async Task<int> InsertMenuGroup(MenuGroup menuGroup)
        {
            var query = $@"EXEC Uif.MenuGroupspInsert 
                                @MenuGroupNameEn = {menuGroup.MenuGroupNameEn},
		                        @MenuGroupNameFa = {menuGroup.MenuGroupNameFa},
		                        @MenuGroupCss = {menuGroup.MenuGroupCss},
		                        @MenuGroupIcon = {menuGroup.MenuGroupIcon},
		                        @MenuGroupParentId = {menuGroup.MenuGroupParentId}";
            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var result = await connection.QueryAsync<MenuGroup>(query, commandTimeout: 190);
                    return result.First().MenuGroupId;
                }
                catch (Exception e)
                {
                    throw new Exception(" menu group --- " + e.Message + "\n query =" + query);
                }
            }
        }

        public async Task<MenuGroup> RemoveMenuGroup(MenuGroup menuGroup)
        {
            var query = $@"EXEC SP_135_Mart";
            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var result = await connection.QueryAsync<MenuGroup>(query, commandTimeout: 190);
                    return menuGroup;
                }
                catch (Exception e)
                {
                    throw new Exception(" menu group --- " + e.Message + "\n query =" + query);
                }
            }
        }

        public async Task<MenuGroup> UpdateMenuGroup(MenuGroup menuGroup)
        {
            var query = $@"EXEC Uif.MenuGroupspUpdate
		                        @MenuGroupId = {menuGroup.MenuGroupId},
		                        @MenuGroupNameEn = {menuGroup.MenuGroupNameEn},
		                        @MenuGroupNameFa = {menuGroup.MenuGroupNameFa},
		                        @MenuGroupCss = {menuGroup.MenuGroupCss},
		                        @MenuGroupIcon = {menuGroup.MenuGroupIcon},
		                        @MenuGroupParentId = {menuGroup.MenuGroupParentId}";
            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var result = await connection.QueryAsync<MenuGroup>(query, commandTimeout: 190);
                    return menuGroup;
                }
                catch (Exception e)
                {
                    throw new Exception(" menu group --- " + e.Message + "\n query =" + query);
                }
            }
        }
    }
}
