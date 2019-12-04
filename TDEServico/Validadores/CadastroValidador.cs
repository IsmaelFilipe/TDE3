using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEServico.Validadores
{
    public class CadastroValidador : AbstractValidator<Cadastro>
    {
        public CadastroValidador()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                    });

            RuleFor(c => c.CodCadastro)
                .NotEmpty().WithMessage("E necessario informa o Codigo de Cadastro")
                .NotNull().WithMessage("E necessario informa o Codigo de Cadastro");

            RuleFor(c => c.Login)
                .NotEmpty().WithMessage("E necessario informa o Login")
                .NotNull().WithMessage("E necessario informa o Login")
                .Length(3, 100);

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("E necessario informa o Nome")
                .NotNull().WithMessage("E necessario informa o Nome")
                .Length(3, 100);

            RuleFor(c => c.Senha)
                .NotEmpty().WithMessage("E necessario informa a Senha")
                .Length(8, 100)
                .NotNull();
            RuleFor(c => c.CPF)
                .NotEmpty().WithMessage("E necessario informa o CPF")
                .NotNull().WithMessage("E necessario informa o CPF");
            //.Must(validacpf).WithMessage("CPF Inválido");
            RuleFor(c => c.CodUsuario)
                .NotEmpty().WithMessage("E necessario informa o Codigo de Cadastro")
                .NotNull().WithMessage("E necessario informa o Codigo de Cadastro");
        }

        //private static bool validacpf(string cpf)
        //{
        //    return validaCPF.cpfValido(cpf);
        //}
    }
}
