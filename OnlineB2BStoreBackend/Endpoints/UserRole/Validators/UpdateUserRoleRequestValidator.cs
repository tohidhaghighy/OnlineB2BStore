using FastEndpoints;
using FluentValidation;
using OnlineB2BStoreBackend.Endpoints.UserRole.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.UserRole.Validators
{
    public class UpdateUserRoleRequestValidator:Validator<UpdateUserRoleRequest>
    {
        public UpdateUserRoleRequestValidator()
        {
            RuleFor(u => u.Id)
                .Must(i=> i != 0).WithMessage("لطفا اطلاعات را بصورت صحیح وارد کنید");
            RuleFor(u => u.RoleName)
                .NotEmpty().WithMessage("لطفا عنوان نقش را وارد کنید");
        }
    }
}
