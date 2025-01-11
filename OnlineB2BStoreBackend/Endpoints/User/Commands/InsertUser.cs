using FastEndpoints;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Endpoints.User.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.User.Commands
{
    public class InsertUser(IUserService userService) : Endpoint<InsertUserRequest, InsertUserResponse>
    {
        public override void Configure()
        {
            Post("InsertUser");
            AllowAnonymous();
        }

        public override async Task HandleAsync(InsertUserRequest request, CancellationToken _cancellationToken)
        {
            var result = await userService.InsertUser(new Domain.Models.User
            {
                UserFirstName = request.FirstName,
                UserLastName = request.LastName,
                UserEmail = request.Email,
                UserAddress = request.Address,
                UserCity = request.City,
                UserCountry = request.Country,
                UserPhone = request.Phone,
                UserPass = request.Pass,
                UserRoleID = request.RoleID,
                UserTypeID = request.TypeID,
                UserCreatedDate = DateTime.Now,
                UserImageUrl = request.ImageUrl
            });

            await SendAsync(new InsertUserResponse
            {
                Id = result,
                IsSuccess = true
            });
        }
    }
}
