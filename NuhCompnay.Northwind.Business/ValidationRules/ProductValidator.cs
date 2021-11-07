using FluentValidation;
using NuhCompnay.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuhCompnay.Northwind.Business.ValidationRules
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(m => m.CategoryId).NotEmpty();
            RuleFor(m => m.ProductName).NotEmpty();
            RuleFor(m => m.UnitPrice).GreaterThan(0);
            RuleFor(m => m.QuantityPerUnit).NotEmpty();
            RuleFor(m => m.ProductName).Length(2,20);

        }
    }
}
