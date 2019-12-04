using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TDEDominio.Entidade;

namespace TDEServico.Validadores
{
    public class UsersValidador : AbstractValidator<Users>
    {
        public UsersValidador()
        {
            RuleFor(c => c)
                   .NotNull()
                   .OnAnyFailure(x =>
                   {
                       throw new ArgumentNullException("Não foi possível encontrar o objeto.");
                   });
            RuleFor(c => c.UserID)
               .NotEmpty().WithMessage("E necessario informa o Id do Usuario")
               .NotNull().WithMessage("E necessario informa o Id do Usuario");

            RuleFor(c => c.AcessKey)
               .NotEmpty().WithMessage("E necessario informa a credencial de acesso")
               .NotNull().WithMessage("E necessario informa a credencial de acesso");

            RuleFor(c => c.userCreated)
            .NotEmpty().WithMessage("E necessario informa o nome do usuario")
            .NotNull().WithMessage("E necessario informa o nome do usuario");

            RuleFor(c => c.userCreated)
          .NotEmpty().WithMessage("E necessario informa o nome do usuario")
          .NotNull().WithMessage("E necessario informa o nome do usuario");

            RuleFor(c => c.lastUser)
   .NotEmpty().WithMessage("E necessario informa o ultimo usuario")
   .NotNull().WithMessage("E necessario informa o ultimo usuario");

            RuleFor(c => c.userCreated)
          .NotEmpty().WithMessage("E necessario informa quando foi criado o usuario")
          .NotNull().WithMessage("E necessario informa quando foi criado o usuario");

            RuleFor(c => c.updatedAt)
           .NotEmpty().WithMessage("E necessario informa qunado foi atualizado")
           .NotNull().WithMessage("E necessario informa oqunado foi atualizado");

            RuleFor(c => c.active)
           .NotEmpty().WithMessage("E necessario informa qunado foi ativo")
           .NotNull().WithMessage("E necessario informa oqunado foi ativo");
        }
    }
}
