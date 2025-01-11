using FastEndpoints;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Endpoints.GroupMenu.Dtos;
using OnlineB2BStoreBackend.Endpoints.UserRole.Dtos;
using OnlineB2BStoreBackend.Infrastructure.Services;

namespace OnlineB2BStoreBackend.Endpoints.UserRole.Queries
{
    public class GetUserRoleList(IUserRoleService userRoleService):EndpointWithoutRequest<List<GetUserRoleResponse>>
    {
        public override void Configure()
        {
            Get("/UserRoleList");
            ResponseCache(60); //cache for 60 seconds
            AllowAnonymous(); // If you don't require authentication
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            // Mock data for products
            var userRoles = new List<GetUserRoleResponse>();
            var userRoleList = await userRoleService.GetUserRoleList();
            foreach (var item in userRoleList)
            {
                userRoles.Add(new GetUserRoleResponse()
                {
                    Id = item.UserRoleID,
                    RoleName = item.UserRoleName
                });
            }

            await SendAsync(userRoles);
        }
    }
}
