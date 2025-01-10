using FastEndpoints;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Domain.Utility.MenuGroup;
using OnlineB2BStoreBackend.Endpoints.GroupMenu.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.Category.Queries
{
    public class GetMenuGroupList(IMenuGroupService menuGroupService) : EndpointWithoutRequest<List<GetMenuGroupListResponse>>
    {
        public override void Configure()
        {
            Get("/GroupMenuList");
            ResponseCache(60); //cache for 60 seconds
            AllowAnonymous(); // If you don't require authentication
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            // Mock data for products
            var menues = new List<GetMenuGroupListResponse>();
            var menuList = await menuGroupService.GetMenuGroupList();
            foreach (var item in menuList)
            {
                menues.Add(new GetMenuGroupListResponse()
                {
                    Id = item.MenuGroupId,
                    NameEn = item.MenuGroupNameEn,
                    NameFa = item.MenuGroupNameFa,
                    Slug = item.MenuGroupNameEn.Replace(" ", "-"),
                    Parent = item.MenuGroupParentId,
                    Level = item.MenuGroupId.GetMenuGroupLevel(menuList)
                });
            }

            await SendAsync(menues);
        }

    }
}
