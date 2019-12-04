using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEServico.Validadores
{
    public class CampanhasValidador : AbstractValidator<Campanha>
    {
        public CampanhasValidador()
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

            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("E necessario informa o Nome")
                .NotNull().WithMessage("E necessario informa o Nome")
                .Length(3, 100);

            RuleFor(c => c.Tema)
                .NotEmpty().WithMessage("E necessario informa o Tema")
                .NotNull().WithMessage("E necessario informa o Tema")
                .Length(3, 100);

            RuleFor(c => c.DataInicio)
                .NotEmpty().WithMessage("E necessario informa a Data de Início")
                .NotNull().WithMessage("E necessario informa a Data de Início");

            RuleFor(c => c.Premio)
               .NotEmpty().WithMessage("E necessario informa o Premio da Campanha")
               .NotNull().WithMessage("E necessario informa o Premio da Campanha")
               .Must(Premiacao).WithMessage("A premiação tem que ser maior que R$ 100,00 e menor que R$ 3.000,00")
               ;

            RuleFor(c => c.Descricao)
               .NotEmpty().WithMessage("E necessario informa a Descricao")
               .NotNull().WithMessage("E necessario informa a Descricao")
               .Length(500);

            RuleFor(c => c.DataFim)
                .NotEmpty().WithMessage("E necessario informa a Data de Terminio")
                .NotNull().WithMessage("E necessario informa a Data de Terminio");

        }
        public static bool Premiacao(int Premio)
        {
            if (Premio < 100) // minimu premiação
                return false;
            if (Premio > 3000)// maximo 
                return false;
            return true;
        }

    }
}
