using Dapper;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Domain.Db;
using OnlineB2BStoreBackend.Domain.Models;

namespace OnlineB2BStoreBackend.Infrastructure.Services
{
    public class UserRoleService(ApplicationDbContext _context) : IUserRoleService
    {
        public async Task<UserRole> GetUserRole(int id)
        {
            var query = $@"select * from Usr.UserRole where UserRoleID={id}";

            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var reslt = await connection.QueryAsync<UserRole>(query, commandTimeout: 190);
                    return reslt.FirstOrDefault();
                }
                catch (Exception e)
                {
                    throw new Exception(" UserRole --- " + e.Message + "\n query =" + query);
                }
            }
        }

        public async Task<List<UserRole>> GetUserRoleList()
        {
            var query = $@"select * from Usr.UserRole";

            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var reslt = await connection.QueryAsync<UserRole>(query, commandTimeout: 190);
                    return reslt.ToList();
                }
                catch (Exception e)
                {
                    throw new Exception(" UserRole --- " + e.Message + "\n query =" + query);
                }
            }
        }

        public async Task<int> InsertUserRole(UserRole userRole)
        {
            var query = $@"EXEC dbo.UserSpRoleAdd @json = {userRole.UserRoleName}";

            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var reslt = await connection.QueryAsync<UserRole>(query, commandTimeout: 190);
                    return reslt.First().UserRoleID;
                }
                catch (Exception e)
                {
                    throw new Exception(" UserRole --- " + e.Message + "\n query =" + query);
                }
            }
        }

        public async Task<bool> RemoveUserRole(int id)
        {
            var query = $@"EXEC dbo.UserSpRoleDel @json = {id}";

            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var reslt = await connection.QueryAsync<UserRole>(query, commandTimeout: 190);
                    return true;
                }
                catch (Exception e)
                {
                    throw new Exception(" UserRole --- " + e.Message + "\n query =" + query);
                }
            }
        }

        public async Task<UserRole> UpdateUserRole(UserRole userRole)
        {
            var query = $@"EXEC  dbo.UserSpRoleUpdate @json = {userRole.UserRoleName} ";

            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var reslt = await connection.QueryAsync<UserRole>(query, commandTimeout: 190);
                    return reslt.First();
                }
                catch (Exception e)
                {
                    throw new Exception(" UserRole --- " + e.Message + "\n query =" + query);
                }
            }
        }
    }
}
