﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.UserId).NotEmpty().WithMessage("İsim İsmi Boş Geçilemez ! ...");
            RuleFor(c => c.CompanyName).NotEmpty().WithMessage("Şirket İsmi Boş Geçilemez ! ..."); ;
        }
    }
}
