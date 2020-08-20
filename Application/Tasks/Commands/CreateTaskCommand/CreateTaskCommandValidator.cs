using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Tasks.Commands
{
    public class CreateTaskCommandValidator : AbstractValidator<CreateTaskCommand>
    {
        public CreateTaskCommandValidator()
        {
            RuleFor(v => v.Title).NotEmpty().MaximumLength(50);
            RuleFor(v => v.Description).NotEmpty().MaximumLength(200);
        }
    }
}
