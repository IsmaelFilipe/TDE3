using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEServico.Validadores
{
    public class EnderecoValidador : AbstractValidator<Endereco>
    {
        public EnderecoValidador()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                    });

            RuleFor(c => c.CodEndereco)
                .NotEmpty().WithMessage("E necessario informa o Codigo do Endereço")
                .NotNull().WithMessage("E necessario informa o Codigo do Endereço");

            RuleFor(c => c.CodFuncionario)
               .NotEmpty().WithMessage("E necessario informa o Codigo do Funcionário")
               .NotNull().WithMessage("E necessario informa o Codigo do Funcionário");

            RuleFor(c => c.Rua)
               .NotEmpty().WithMessage("E necessario informa a Rua")
               .NotNull().WithMessage("E necessario informa a Rua");

            RuleFor(c => c.Bairro)
            .NotEmpty().WithMessage("E necessario informa o bairro")
            .NotNull().WithMessage("E necessario informa a bairro");

            RuleFor(c => c.Numero)
            .NotEmpty().WithMessage("E necessario informa o Número")
            .NotNull().WithMessage("E necessario informa o Número");

            RuleFor(c => c.Complemento)
            .NotEmpty().WithMessage("E necessario informa o Complemento")
            .NotNull().WithMessage("E necessario informa o Complemento");

            RuleFor(c => c.Cidade)
           .NotEmpty().WithMessage("E necessario informa a Cidade")
           .NotNull().WithMessage("E necessario informa a Cidade");

            RuleFor(c => c.Estado)
           .NotEmpty().WithMessage("E necessario informa o Estado")
           .NotNull().WithMessage("E necessario informa o Estado");

            RuleFor(c => c.CEP)
           .NotEmpty().WithMessage("E necessario informa o CEP")
           .NotNull().WithMessage("E necessario informa o CEP");


        }
    }
}
