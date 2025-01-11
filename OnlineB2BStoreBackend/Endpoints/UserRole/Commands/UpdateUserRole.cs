using FastEndpoints;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Endpoints.UserRole.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.UserRole.Commands
{
    public class UpdateUserRole(IUserRoleService userRoleService):Endpoint<UpdateUserRoleRequest, UpdateUserRoleResponse>
    {
        public override void Configure()
        {
            Put("UpdateUserRole");
            AllowAnonymous();
        }

        public override async Task HandleAsync(UpdateUserRoleRequest request, CancellationToken _cancellationToken)
        {
            var userRole = await userRoleService.UpdateUserRole(new Domain.Models.UserRole
            {
                UserRoleID = request.Id,
                UserRoleName = request.RoleName
            });

            await SendAsync(new UpdateUserRoleResponse
            {
                Id = userRole.UserRoleID,
                RoleName = userRole.UserRoleName
            },190,_cancellationToken);
        }
    }
}
