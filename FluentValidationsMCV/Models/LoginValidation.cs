
using FluentValidation;

namespace FluentValidationsMCV.Models
{
    public class LoginValidation : AbstractValidator<Login>
    {
        public  LoginValidation(){

        RuleFor(user => user.name).NotNull().WithMessage("Required!!");
        RuleFor(user => user.email).NotEmpty().WithMessage("Required!!").EmailAddress();
        RuleFor(user => user.password).NotNull().WithMessage("Required!!");
        RuleFor(user => user.passwordConfirmation).NotNull().WithMessage("Required!!");
        RuleFor(user => user.password).Equal(user => user.passwordConfirmation).WithMessage("The passwords do not match!!"); ;
        }
    }
    
}
