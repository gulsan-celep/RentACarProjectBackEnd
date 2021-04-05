using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator :AbstractValidator<Car>
    {
        public CarValidator()
        {
            // Kurallar buraya yazılır.
            RuleFor(c => c.CarName).NotEmpty(); // Boş olamaz carName
            RuleFor(c =>c.CarName).MinimumLength(2); // CarName ismi min 2 karakter olmalıdır.
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0); // 0dan bütük olmalı dailyprice

        }
    }
}
