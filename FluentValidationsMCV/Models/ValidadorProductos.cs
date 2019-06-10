
using FluentValidation;

namespace FluentValidationsMVC.Models
{ 
public class ValidadorProductos: AbstractValidator<productos>
{
	public ValidadorProductos()
	{
        RuleFor(x => x.nombre).NotNull().WithMessage("The name is required").Length(1, 8); ;
        RuleFor(x => x.precio).NotNull().WithMessage("The price is required");
            RuleFor(x => x.descripcion).NotNull().WithMessage("The description is required");
        }



    }
}


