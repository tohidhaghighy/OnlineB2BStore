using FastEndpoints;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Endpoints.GroupMenu.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.GroupMenu.Commands
{
    public class UpdateMenuGroup(IMenuGroupService menuGroupService) : Endpoint<UpdateMenuGroupRequest, UpdateMenuGroupResponse>
    {
        public override void Configure()
        {
            Put("/UpdateGroupMenu");
            AllowAnonymous(); // If you don't require authentication
        }

        public override async Task HandleAsync(UpdateMenuGroupRequest request, CancellationToken _cancellationToken)
        {
            var response = await menuGroupService.UpdateMenuGroup(new Domain.Models.MenuGroup
            {
                MenuGroupCss = request.CssAddress,
                MenuGroupIcon = request.IconAddress,
                MenuGroupNameEn = request.NameEn,
                MenuGroupNameFa = request.NameFa,
                MenuGroupId = request.Id

            });

            await SendAsync(new UpdateMenuGroupResponse
            {
                Id = response.MenuGroupId,
                CssAddress = response.MenuGroupCss,
                IconAddress = response.MenuGroupIcon,
                NameEn=response.MenuGroupNameEn, 
                NameFa=response.MenuGroupNameFa,
            }, 190, _cancellationToken);

        }
    }
}
