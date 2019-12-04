using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEServico.Validadores
{
    public class FuncionarioValidador : AbstractValidator<Funcionario>
    {
        public FuncionarioValidador()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                    });

            RuleFor(c => c.CodFuncionario)
               .NotEmpty().WithMessage("E necessario informa o Codigo do Funcionario")
               .NotNull().WithMessage("E necessario informa o Codigo do Funcionario");

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("E necessario informa o Nome")
                .NotNull().WithMessage("E necessario informa o Nome")
                .Length(3, 100);

            RuleFor(c => c.CPF)
               .NotEmpty().WithMessage("E necessario informa o CPF")
               .NotNull().WithMessage("E necessario informa o CPF");
              // .Must(validacpf).WithMessage("CPF Inválido!");

            RuleFor(c => c.DataNascimento)
                .NotEmpty().WithMessage("E necessario informa a Data de Nascimento")
                .NotNull().WithMessage("E necessario informa a Data de Nascimento")
                .Must(ValidaMaiorDeIdade).WithMessage("Nao pode ter menos que 14 anos");

            RuleFor(c => c.CodUsuario)
                .NotEmpty().WithMessage("E necessario informa o Codigo do Usuario")
                .NotNull().WithMessage("E necessario informa o Codigo do Usuario");
        }
        public static bool ValidaMaiorDeIdade(DateTime DataNascimento)
        {
            // return DataNascimento <= DateTime.Now.AddYears(-14);
            //mesma coisa que
            if (DataNascimento <= DateTime.Now.AddYears(-14))
            {
                return false;
            }
            return true;
        }
        //public static bool validacpf(string cpf)
        //{
        //    return validaCPF.cpfValido(cpf);
        //}
    }
}
