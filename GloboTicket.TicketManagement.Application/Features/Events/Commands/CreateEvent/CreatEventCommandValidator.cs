using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent
{
    public class CreatEventCommandValidator : AbstractValidator<CreateEventCommand>
    {
        public CreatEventCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{Propery Name} is required")
                .NotNull()
                .MaximumLength(50).WithMessage("{Property Name} must not exceed 50 characters");


            RuleFor(p => p.Date)
            .NotEmpty().WithMessage("{Propery Name} is required")
            .NotNull()
            .GreaterThan(DateTime.Now);


            RuleFor(p => p.Price)
          .NotEmpty().WithMessage("{Propery Name} is required")
          .GreaterThan(0);
        }

    }
}
