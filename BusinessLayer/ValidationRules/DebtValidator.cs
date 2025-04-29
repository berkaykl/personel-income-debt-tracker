using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class DebtValidator:AbstractValidator<Debt> //AbstractValidator ile T entitysi gönderiyoruz
    {
        //ctor method oluşturuyoruz
        public DebtValidator()
        {
            RuleFor(x => x.DebtName)
                .NotEmpty().WithMessage("Borç adı boş geçilemez.")
                .MinimumLength(2).WithMessage("Borç adı 2 karakterden az olamaz.")
                .MaximumLength(35).WithMessage("Borç adı 35 karakterden fazla olamaz.");

            RuleFor(x => x.DebtDescription).MaximumLength(250).WithMessage("Borç açıklaması en fazla 250 karakter olabilir.");

            RuleFor(x => x.DebtAmount)
                .NotEmpty().WithMessage("Borç miktarı boş olamaz.")
                .Must(x =>
                {
                    if (decimal.TryParse(x, out var value))
                    {
                        return value > 0;
                    }
                    return false;
                }).WithMessage("Borç tutarı 0'dan büyük bir sayı olmalıdır.");


            RuleFor(x => x.DebtCreatedDate).NotEmpty().WithMessage("Borç tarihi boş olamaz.");

        }
    }
}
