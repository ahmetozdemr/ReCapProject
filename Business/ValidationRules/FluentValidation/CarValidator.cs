using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    { 
        public CarValidator()
    {
        RuleFor(c => c.Description).NotEmpty();
        RuleFor(c => c.Description).MaximumLength(2);
        RuleFor(p => p.DailyPrice).NotEmpty();
        RuleFor(p => p.DailyPrice).GreaterThan(0);
        RuleFor(P => P.DailyPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
        RuleFor(p => p.Description).Must(StartWithA).WithMessage("Ürünler A harfi ile başlamalı");
    }

    private bool StartWithA(string arg)
    {
        return arg.StartsWith("A");
    }
    }
}

