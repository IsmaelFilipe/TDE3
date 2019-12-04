using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEServico.Validadores
{
    public class UsuarioValidador : AbstractValidator<Usuario>
    {
        public UsuarioValidador()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                    });

            RuleFor(c => c.CodUsuario)
                .NotEmpty().WithMessage("E necessario informa o Codigo de Cadastro")
                .NotNull().WithMessage("E necessario informa o Codigo de Cadastro");

            RuleFor(c => c.Login)
                .NotEmpty().WithMessage("E necessario informa o Login")
                .NotNull().WithMessage("E necessario informa o Login")
                .Length(3, 100);

            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("E necessario informa o Nome")
                .NotNull().WithMessage("E necessario informa o Nome")
                .Length(8, 50);

            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("E necessario informa o CPF")
                .NotNull().WithMessage("E necessario informa o CPF");
            //.Must(validacpf).WithMessage("CPF Inválido!");
        }

        //public static bool validacpf(string cpf)
        //{
        //    return validaCPF.cpfValido(cpf);
        //}
    }
}
