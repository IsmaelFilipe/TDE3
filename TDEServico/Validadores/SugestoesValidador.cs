using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEServico.Validadores
{
    public class SugestoesValidador : AbstractValidator<Sugestoes>
    {
        public SugestoesValidador()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                    });

            RuleFor(c => c.CodSugestoes)
                .NotEmpty().WithMessage("E necessario informa o Codigo da Sugestão")
                .NotNull().WithMessage("E necessario informa o Codigo da Sugestão");

            RuleFor(c => c.CodFuncionario)
               .NotEmpty().WithMessage("E necessario informa o Codigo do Funcionario")
               .NotNull().WithMessage("E necessario informa o Codigo do Funcionario");

            RuleFor(c => c.CodCampanha)
                .NotEmpty().WithMessage("E necessario informa o Codigo da Campanha")
                .NotNull().WithMessage("E necessario informa o Codigo da Campanha");

            RuleFor(c => c.Descrição)
           .NotEmpty().WithMessage("E necessario informa a Descrição")
           .NotNull().WithMessage("E necessario informa a Descrição")
           .Length(200);

            RuleFor(c => c.Custo)
             .NotEmpty().WithMessage("E necessario informa o Custo da Campanha")
             .NotNull().WithMessage("E necessario informa o Custo da Campanha")
             .Must(CustoValidacao).WithMessage("O custo de implatação tem um limite maximo de R$ 1.500,00");

            RuleFor(c => c.DataInicio)
            .NotEmpty().WithMessage("E necessario informa a Data de Início")
            .NotNull().WithMessage("E necessario informa a Data de Início");

            RuleFor(c => c.ReduçãoCusto)
                .NotEmpty().WithMessage("E necessario informa a Redução do Custo")
                .NotNull().WithMessage("E necessario informa a Redução do Custoo");

            //RuleFor(c => c.Investimento)
            //  .NotEmpty().WithMessage("E necessario informa o Investimento")
            //  .NotNull().WithMessage("E necessario informa o Investimento");


        }
        public static bool CustoValidacao(float Custo)
        {
            if (Custo > 1500.00)// maximo 
                return false;
            return true;
        }

    }
}
