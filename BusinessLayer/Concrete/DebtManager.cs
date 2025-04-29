using BusinessLayer.Abstract;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DebtManager : IDebtService
    {
        private readonly IDebtDal _debtDal;
        private readonly DebtValidator _validator;

        public DebtManager(IDebtDal debtDal)
        {
            _debtDal = debtDal;
            _validator = new DebtValidator();
        }

        public void TDelete(Debt entity)
        {
            _debtDal.Delete(entity);
        }

        public List<Debt> TGetAll()
        {
            return _debtDal.GetAll();
        }

        public Debt TGetById(int id)
        {
            return _debtDal.GetById(id);
        }

        public void TInsert(Debt entity)
        {
            var validator = new DebtValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                // Hataları fırlat
                throw new ValidationException(result.Errors);
            }
            _debtDal.Insert(entity);

        }

        public void TUpdate(Debt entity)
        {
            var validator = new DebtValidator();
            var result = validator.Validate(entity);

            if (!result.IsValid)
            {
                // Hataları fırlat
                throw new ValidationException(result.Errors);
            }
            _debtDal.Update(entity);
        }
    }
}
