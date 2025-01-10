using FastEndpoints;
using FluentValidation;
using OnlineB2BStoreBackend.Endpoints.UserRole.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.UserRole.Validators
{
    public class DeleteUserRoleRequestValidator:Validator<DeleteUserRoleRequest>
    {
        public DeleteUserRoleRequestValidator()
        {
            RuleFor(u => u.Id)
                .Must(i => i != 0).WithMessage("لطفا اطلاعات را بصورت صحیح ارسال کنید");
        }
    }
}
