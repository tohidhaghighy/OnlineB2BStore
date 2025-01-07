using Azure.Core;
using Dapper;
using Microsoft.EntityFrameworkCore;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Domain.Db;
using OnlineB2BStoreBackend.Domain.Models;

namespace OnlineB2BStoreBackend.Infrastructure.Services
{
    public class MenuGroupService(ApplicationDbContext _context) : IMenuGroupService
    {
        public async Task<MenuGroup> GetMenuGroup(int id)
        {
            var query = $@"EXEC SP_135_Mart";
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
            var query = $@"EXEC SP_135_Mart";
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

        public async Task<MenuGroup> InsertMenuGroup(MenuGroup menuGroup)
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
    }
}
