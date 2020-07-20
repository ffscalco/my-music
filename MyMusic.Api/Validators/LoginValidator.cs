using System;
using FluentValidation;
using MyMusic.Api.Resources;

namespace MyMusic.Api.Validators
{
    public class LoginValidator : AbstractValidator<LoginResource>
    {
        public LoginValidator()
        {
            RuleFor(a => a.Username)
                .NotEmpty()
                .MaximumLength(10);
            RuleFor(a => a.Password)
                .NotEmpty()
                .MaximumLength(20)
                .MinimumLength(6);
        }
    }
}
