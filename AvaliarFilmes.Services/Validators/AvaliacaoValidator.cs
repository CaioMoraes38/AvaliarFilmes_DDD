using FluentValidation;
using AvaliarFilmes.Domain.Entities;

namespace AvaliarFilmes.Service.Validators
{
    public class AvaliacaoValidator : AbstractValidator<Avaliacao>
    {
        public AvaliacaoValidator()
        {
           

            RuleFor(a => a.Comentario)
                .MaximumLength(1000).WithMessage("Comentário pode ter no máximo 1000 caracteres.");

            RuleFor(a => a.IdFilme)
                .NotEmpty().WithMessage("Por favor informe o filme.")
                .NotNull().WithMessage("Por favor informe o filme.");

            RuleFor(a => a.IdUsuario)
                .NotEmpty().WithMessage("Por favor informe o usuário.")
                .NotNull().WithMessage("Por favor informe o usuário.");
        }
    }
}