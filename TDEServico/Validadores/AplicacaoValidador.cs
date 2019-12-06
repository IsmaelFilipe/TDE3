using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEServico.Validadores
{

    public class AvaliacaoValidador : AbstractValidator<Avaliacao>
    {
        public AvaliacaoValidador()
        {
            RuleFor(c => c)
                    .NotNull()
                    .OnAnyFailure(x =>
                    {
                        throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                    });

            RuleFor(c => c.CodCampanha)
                .NotEmpty().WithMessage("E necessario informa o Codigo da Campanha")
                .NotNull().WithMessage("E necessario informa o Codigo da Campanha");

            RuleFor(c => c.CodFuncionario)
                .NotEmpty().WithMessage("E necessario informa o Codigo do Funcionário")
                .NotNull().WithMessage("E necessario informa o Codigo do Funcionário");

            RuleFor(c => c.CodSugestoes)
                .NotEmpty().WithMessage("E necessario informa o Codigo de Sugestao")
                .NotNull().WithMessage("E necessario informa o Codigo de Sugestao");

            RuleFor(c => c.Criatividade)
                .NotEmpty().WithMessage("E necessario informar a  criatividade")
                .NotNull().WithMessage("E necessario informar a  criatividade")
                .Length(1,50);

            RuleFor(c => c.DataInicio)
                .NotEmpty().WithMessage("E necessario informa a Data de Inicio")
                .NotNull().WithMessage("E necessario informa a Data de Inicio");

            RuleFor(c => c.DataFim)
                .NotEmpty().WithMessage("E necessario informa a Data Final")
                .NotNull().WithMessage("E necessario informa a Data Final");

            RuleFor(c => c.ReducaoCusto)
                .NotEmpty().WithMessage("E necessario o valor de Redução de Custo")
                .NotNull().WithMessage("E necessario o valor de Redução de Custo");

            RuleFor(c => c.Investimento)
                .NotEmpty().WithMessage("E necessario informar o valor de Investimento")
                .NotNull().WithMessage("E necessario informar o valor de Investimento");


        }
    }
}
