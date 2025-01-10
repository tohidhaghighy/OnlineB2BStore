using FastEndpoints;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Endpoints.GroupMenu.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.GroupMenu.Commands
{
    public class InsertMenuGroup(IMenuGroupService menuGroupService) : Endpoint<InsertMenuGroupRequest, InsertMenuGroupResponse>
    {
        public override void Configure()
        {
            Post("/InsertGroupMenu");
            AllowAnonymous(); // If you don't require authentication
        }

        public override async Task HandleAsync(InsertMenuGroupRequest request, CancellationToken _cancellationToken)
        {
            var id =await menuGroupService.InsertMenuGroup(new Domain.Models.MenuGroup
            {
                MenuGroupCss = request.CssAddress,
                MenuGroupIcon = request.IconAddress,
                MenuGroupNameEn = request.NameEn,
                MenuGroupNameFa = request.NameFa,
                MenuGroupParentId = request.ParentId

            });

            await SendAsync(new InsertMenuGroupResponse
            {
                Id = id,
                IsSuccess = true
            }, 190, _cancellationToken);

        }
    }
}
