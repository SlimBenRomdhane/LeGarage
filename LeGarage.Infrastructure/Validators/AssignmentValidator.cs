using FluentValidation;
using LeGarage.Infrastructure.Models;

namespace LeGarage.Infrastructure.Validators
{
    public class AssignmentValidator : AbstractValidator<Assignment>
    {
        public AssignmentValidator()
        {
            RuleFor(x => x.Role)
                .NotEmpty().WithMessage("Role is mandatory")
                .MaximumLength(254).WithMessage("Role must not exceed 254 characters");
        }
    }
}
