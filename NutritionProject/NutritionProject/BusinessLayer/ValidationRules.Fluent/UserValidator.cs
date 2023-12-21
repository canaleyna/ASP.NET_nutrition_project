using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.Fluent
{
   public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Yazar Soyadını Boş Geçemezsiniz");
            RuleFor(x => x.UserAbout).NotEmpty().WithMessage("Hakkımda Kısmını Boş Geçemezsiniz");
            RuleFor(x => x.UserTitle).NotEmpty().WithMessage("Unvan Kısmını Boş Geçemezsiniz");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.Surname).MaximumLength(20).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın");

        }
    }
}
