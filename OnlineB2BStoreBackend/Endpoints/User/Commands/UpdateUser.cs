using FastEndpoints;
using OnlineB2BStoreBackend.Domain.Contracts;
using OnlineB2BStoreBackend.Endpoints.User.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.User.Commands
{
    public class UpdateUser(IUserService userService):Endpoint<UpdateUserRequest, UpdateUserResponse>
    {
        public override void Configure()
        {
            Post("UpdateUser");
            AllowAnonymous();
        }

        public override async Task HandleAsync(UpdateUserRequest request, CancellationToken _cancellationToken)
        {
            var result = await userService.UpdateUser(new Domain.Models.User
            {
                UserID = request.ID,
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
                UserImageUrl = request.ImageUrl
            });

            await SendAsync(new UpdateUserResponse
            {
                ID = result.UserID,
                FirstName = result.UserFirstName,
                LastName = result.UserLastName,
                Pass = result.UserPass,
                Email = result.UserEmail,
                Address = result.UserAddress,
                City = result.UserCity,
                Country = result.UserCountry,
                CreatedDate = result.UserCreatedDate,
                ImageUrl = result.UserImageUrl,
                Phone = result.UserPhone,
                RoleID = result.UserRoleID,
                TypeID = result.UserTypeID
            });
        }
    }
}
