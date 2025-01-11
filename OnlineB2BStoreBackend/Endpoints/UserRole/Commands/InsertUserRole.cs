using FastEndpoints;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Endpoints.UserRole.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.UserRole.Commands
{
    public class InsertUserRole(IUserRoleService userRoleService):Endpoint<InsertUserRoleRequest, InsertUserRoleResponse>
    {
        public override void Configure()
        {
            Post("InsertUserRole");
            AllowAnonymous();
        }

        public override async Task HandleAsync(InsertUserRoleRequest request, CancellationToken _cancellationToken)
        {
          var id = await  userRoleService.InsertUserRole(new Domain.Models.UserRole
            {
                UserRoleName = request.RoleName,
            });

            await SendAsync(new InsertUserRoleResponse
            {
                Id = id,
                IsSuccess = true
            }, 190, _cancellationToken);
        }
    }
}
