using Dapper;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Domain.Db;
using OnlineB2BStoreBackend.Domain.Models;

namespace OnlineB2BStoreBackend.Infrastructure.Services
{
    public class UserService(ApplicationDbContext _context) : IUserService
    {
        public async Task<User> GetUser(int id)
        {
            var query = $@"select * from Usr.User where UserID={id}";
            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var result = await connection.QueryAsync<User>(query, commandTimeout: 190);
                    return result.FirstOrDefault();
                }
                catch (Exception e)
                {
                    throw new Exception(" User --- " + e.Message + "\n query =" + query);
                }
            }
        }

        public async Task<List<User>> GetUserList()
        {
            var query = $@"select * from Usr.User";
            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var result = await connection.QueryAsync<User>(query, commandTimeout: 190);
                    return result.ToList();
                }
                catch (Exception e)
                {

                    throw new Exception(" User --- " + e.Message + "\n query =" + query);
                }
            }
        }

        public async Task<int> InsertUser(User user)
        {
            var query = $@"EXEC Usr.UserSpInsert
		                        @UserFirstName = {user.UserFirstName},
		                        @UserLastName = {user.UserLastName},
		                        @UserEmail = {user.UserEmail},
		                        @UserPhone = {user.UserPhone},
		                        @UserPass = {user.UserPass},
		                        @UserAddress = {user.UserAddress},
		                        @UserCity = {user.UserCity},
		                        @UserCountry = {user.UserCountry},
		                        @UserRoleID = {user.UserRoleID},
		                        @UserTypeID = {user.UserTypeID},
		                        @UserImageUrl = {user.UserImageUrl}";
            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var result = await connection.QueryAsync<User>(query, commandTimeout: 190);
                    return result.First().UserID;
                }
                catch (Exception e)
                {

                    throw new Exception(" User --- " + e.Message + "\n query =" + query);
                }

            }
        }

        public async Task<User> UpdateUser(User user)
        {
            var query = $@"EXEC Usr.UserSpUpdate
		                        @UserID = {user.UserID},
		                        @UserFirstName = {user.UserFirstName},
		                        @UserLastName = {user.UserLastName},
		                        @UserEmail = {user.UserEmail},
		                        @UserPhone = {user.UserPhone},
		                        @UserPass = {user.UserPass},
		                        @UserAddress = {user.UserAddress},
		                        @UserCity = {user.UserCity},
		                        @UserCountry = {user.UserCountry},
		                        @UserRoleID = {user.UserRoleID},
		                        @UserTypeID = {user.UserTypeID},
		                        @UserImageUrl = {user.UserImageUrl}";

            using (var connection = _context.CreateConnection())
            {
                try
                {
                    var result = await connection.QueryAsync<User>(query, commandTimeout: 190);
                    return result.First();
                }
                catch (Exception e)
                {
                    throw new Exception(" User --- " + e.Message + "\n query =" + query);
                }
                
            }
        }
    }
}
