using FastEndpoints;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Endpoints.User.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.User.Queries
{
    public class GetUserList(IUserService userService):EndpointWithoutRequest<List<GetUserResponse>>
    {
        public override void Configure()
        {
            Get("GetUserList");
            ResponseCache(60);
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken _cancellationToken)
        {
            var users = new List<GetUserResponse>();
            var userList = await userService.GetUserList();
            foreach (var item in userList)
            {
                users.Add(new GetUserResponse()
                {
                    ID = item.UserID,
                    FirstName = item.UserFirstName,
                    LastName = item.UserLastName,
                    Pass = item.UserPass,
                    Email = item.UserEmail,
                    Address = item.UserAddress,
                    City = item.UserCity,
                    Country = item.UserCountry,
                    CreatedDate = item.UserCreatedDate,
                    ImageUrl = item.UserImageUrl,
                    Phone = item.UserPhone,
                    RoleID = item.UserRoleID,
                    TypeID = item.UserTypeID
                });
            }

            await SendAsync(users);
        }
    }
}
