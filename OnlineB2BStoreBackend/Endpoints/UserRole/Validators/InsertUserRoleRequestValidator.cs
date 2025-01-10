using FastEndpoints;
using FluentValidation;
using OnlineB2BStoreBackend.Endpoints.UserRole.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.UserRole.Validators
{
    public class InsertUserRoleRequestValidator:Validator<InsertUserRoleRequest>
    {
        public InsertUserRoleRequestValidator()
        {
            RuleFor(u => u.RoleName)
                .NotEmpty().WithMessage("لطفا عنوان نقش را وارد کنید");
        }
    }
}
