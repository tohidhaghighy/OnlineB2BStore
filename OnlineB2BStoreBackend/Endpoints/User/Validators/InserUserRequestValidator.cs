using FastEndpoints;
using FluentValidation;
using OnlineB2BStoreBackend.Endpoints.User.Dtos;

namespace OnlineB2BStoreBackend.Endpoints.User.Validators
{
    public class InserUserRequestValidator:Validator<InsertUserRequest>
    {
        public InserUserRequestValidator()
        {
            RuleFor(u => u.FirstName)
                .NotEmpty().WithMessage("نام شخص نمی تواند خالی باشد")
                .MaximumLength(50).WithMessage("نام شخص نمی تواند بیشتر از 50 کاراکتر باشد");
            RuleFor(u => u.LastName)
               .NotEmpty().WithMessage("نام خانوادگی شخص نمی تواند خالی باشد")
               .MaximumLength(50).WithMessage("نام خانوادگی شخص نمی تواند بیشتر از 50 کاراکتر باشد");
            RuleFor(u => u.Email)
               .NotEmpty().WithMessage("آدرس الکترونیکی شخص نمی تواند خالی باشد")
               .MaximumLength(100).WithMessage("آدرس الکترونیکی شخص نمی تواند بیشتر از 100 کاراکتر باشد");
            RuleFor(u => u.Pass)
               .NotEmpty().WithMessage("رمز عبور شخص نمی تواند خالی باشد");
            RuleFor(u => u.City)
               .Must(c=>c !=0).WithMessage("لطفا شهر محل سکونت خود را انتخاب کنید");
            RuleFor(u => u.Country)
               .Must(c => c != 0).WithMessage("لطفا کشور محل سکونت خود را انتخاب کنید");
            RuleFor(u => u.RoleID)
               .Must(r => r != 0).WithMessage("لطفا نقش کاربر را انتخاب کنید");
            RuleFor(u => u.TypeID)
               .Must(t => t != 0).WithMessage("لطفا نوع کاربر را انتخاب کنید");
        }
    }
}
