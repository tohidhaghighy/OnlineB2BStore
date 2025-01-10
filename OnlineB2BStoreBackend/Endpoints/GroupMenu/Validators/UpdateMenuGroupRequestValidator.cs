using FastEndpoints;
using FluentValidation;
using OnlineB2BStoreBackend.Endpoints.GroupMenu.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.GroupMenu.Validators
{
    public class UpdateMenuGroupRequestValidator : Validator<UpdateMenuGroupRequest>
    {
        public UpdateMenuGroupRequestValidator()
        {
            RuleFor(m => m.Id)
                .Must(i =>  i != 0).WithMessage("اطلاعات را بصورت صحیح وارد کنید");
            RuleFor(m => m.NameFa)
                .NotEmpty().WithMessage("عنوان فارسی منو را وارد کنید");
            RuleFor(m => m.NameEn)
                .NotEmpty().WithMessage("عنوان انگلیسی منو را وارد کنید");

        }
    }
}
