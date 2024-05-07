﻿using System;
using FluentValidation;
using FoundFlow.Shared.Messages;

namespace FoundFlow.Application.Common.Feature.Users.Login;

public class LoginValidator : AbstractValidator<LoginRequest>
{
    public LoginValidator()
    {
        ValidatorOptions.Global.DisplayNameResolver = (_, member, _) => member.Name;

        RuleFor(x => x.Email)
            .NotEmpty()
            .NotNull()
            .EmailAddress()
            .WithMessage(ErrorMessages.UsersLoginValidationEmailMessage);

        RuleFor(x => x.Password)
            .NotEmpty()
            .NotNull()
            .WithMessage(ErrorMessages.UsersCreateValidationPasswordMessage)
            .MinimumLength(6)
            .WithMessage(ErrorMessages.UsersCreateValidationMinLengthPasswordMessage)
            .Must(PasswordExtensions.ValidatePasswordComplexity)
            .WithMessage(ErrorMessages.UsersCreateValidationPasswordComplexityMessage);
    }
}