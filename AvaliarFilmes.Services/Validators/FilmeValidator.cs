using FluentValidation;
using AvaliarFilmes.Domain.Entities;

namespace AvaliarFilmes.Service.Validators
{
    public class FilmeValidator : AbstractValidator<Filme>
    {
        public FilmeValidator()
        {
            RuleFor(f => f.Titulo)
                .NotEmpty().WithMessage("Por favor informe o título.")
                .NotNull().WithMessage("Por favor informe o título.")
                .MaximumLength(255).WithMessage("Título pode ter no máximo 255 caracteres.");

            RuleFor(f => f.Descricao)
                .MaximumLength(1000).WithMessage("Descrição pode ter no máximo 1000 caracteres.");


            RuleFor(f => f.Duracao)
                .GreaterThan(0).WithMessage("Duração deve ser maior que zero.");

            RuleFor(f => f.IdCategoria)
                .NotEmpty().WithMessage("Por favor informe a categoria.")
                .NotNull().WithMessage("Por favor informe a categoria.");
        }
    }
}