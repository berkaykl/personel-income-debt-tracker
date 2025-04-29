using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WageValidator:AbstractValidator<Wage>
    {
        public WageValidator()
        {
            RuleFor(x => x.WageName)
                .NotEmpty().WithMessage("Gelir adı boş geçilemez.")
                .MinimumLength(2).WithMessage("Gelir adı 2 karakterden az olamaz.")
                .MaximumLength(35).WithMessage("Gelir adı 35 karakterden fazla olamaz.");

            RuleFor(x => x.WageDescription).MaximumLength(250).WithMessage("Gelir açıklaması en fazla 250 karakter olabilir.");

            RuleFor(x => x.WageAmount)
                .NotEmpty().WithMessage("Gelir miktarı boş olamaz.")
                .Must(x =>
                {
                    if (decimal.TryParse(x, out var value))
                    {
                        return value > 0;
                    }
                    return false;
                }).WithMessage("Gelir tutarı 0'dan büyük bir sayı olmalıdır.");


            RuleFor(x => x.WageCreatedDate).NotEmpty().WithMessage("Gelir tarihi boş olamaz.");
        }
    }
}
