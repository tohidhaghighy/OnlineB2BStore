using FastEndpoints;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Endpoints.UserRole.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.UserRole.Commands
{
    public class DeleteUserRole(IUserRoleService userRoleService):Endpoint<DeleteUserRoleRequest, DeleteUserRoleResponse>
    {
        public override void Configure()
        {
            Post("DeleteUserRole");
            AllowAnonymous();
        }

        public override async Task HandleAsync(DeleteUserRoleRequest request, CancellationToken _cancellationToken)
        {
            var result = await userRoleService.RemoveUserRole(request.Id);

            await SendAsync(new DeleteUserRoleResponse
            {
                IsSuccess = result
            },190,_cancellationToken);
        }
    }
}
