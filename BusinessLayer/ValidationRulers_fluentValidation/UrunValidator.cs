using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRulers_fluentValidation
{
    public class UrunValidator:AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(x => x.UrunAd).NotEmpty().WithMessage("Ürün Adı Boş Olamaz");
            RuleFor(x => x.Fiyat).NotEmpty().WithMessage("Fiyat Boş Olamaz");
           





        }
    }
}
