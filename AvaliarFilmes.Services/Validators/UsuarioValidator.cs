using FluentValidation;
using AvaliarFilmes.Domain.Entities;

namespace AvaliarFilmes.Service.Validators
{
    public class UsuarioValidator : AbstractValidator<Usuario>
    {
        public UsuarioValidator()
        {
            RuleFor(u => u.Nome)
                .NotEmpty().WithMessage("Por favor informe o nome.")
                .NotNull().WithMessage("Por favor informe o nome.")
                .MaximumLength(255).WithMessage("Nome pode ter no máximo 255 caracteres.");

            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("Por favor informe o email.")
                .NotNull().WithMessage("Por favor informe o email.")
                .EmailAddress().WithMessage("Por favor informe um email válido.")
                .MaximumLength(255).WithMessage("Email pode ter no máximo 255 caracteres.");

            RuleFor(u => u.Senha)
                .NotEmpty().WithMessage("Por favor informe a senha.")
                .NotNull().WithMessage("Por favor informe a senha.")
                .MaximumLength(255).WithMessage("Senha pode ter no máximo 255 caracteres.");
        }
    }
}